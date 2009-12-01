Imports System.Xml
Imports System.Reflection
''' <summary>
''' Clase para el manejo de Objetos mediante Reflection
''' </summary>
''' <remarks></remarks>
Public Class DaemonReflection

    Shared Sub New()
        'Obtengo los elementos a ejecutar
       
    End Sub

    Public Sub ExecuteAll()
        Try
            Dim lstAssemblys As List(Of DaemonAssemblyEntity) = Nothing
            lstAssemblys = DaemonConfig.GetAssemblies()
            If Not lstAssemblys Is Nothing AndAlso lstAssemblys.Count > 0 Then
                For Each oAssembly As DaemonAssemblyEntity In lstAssemblys


                    Dim Ejecutar As Boolean = False
                    Dim dData As New DaemonData
                    Dim ds As DataSet = Nothing



                    Dim strSql As String
                    strSql = "select sysdate from dual"
                    dData.ExecuteText(strSql, ds)
                    If Not dData.validateDataset(ds) Then
                        DaemonLoger.Loguear("NO se puede obtener la hora del servidor", EventLogEntryType.Warning)
                        Exit Sub
                    End If

                    Dim Ahora As Date = CDate(ds.Tables(0).Rows(0).Item(0))

                    Dim lastExec As Date = GetLastExecution(oAssembly)
                    If lastExec = Date.MinValue Then
                        Ejecutar = True
                    Else
                        Dim tipoIntervalo As String = oAssembly.TimerSpanType
                        Dim tmInterval As Double = CDbl(oAssembly.TimerSpanValue)

                        Select Case tipoIntervalo.ToLower
                            Case "h"
                                If DateDiff(DateInterval.Second, DateAdd(DateInterval.Hour, tmInterval, lastExec), Ahora) > 0 Then
                                    Ejecutar = True
                                End If
                            Case "d"
                                If DateDiff(DateInterval.Second, DateAdd(DateInterval.Day, tmInterval, lastExec), Ahora) > 0 Then
                                    Ejecutar = True
                                End If

                            Case "m"
                                If DateDiff(DateInterval.Second, DateAdd(DateInterval.Minute, tmInterval, lastExec), Ahora) > 0 Then
                                    Ejecutar = True
                                End If
                            Case "s"
                                If DateDiff(DateInterval.Second, DateAdd(DateInterval.Second, tmInterval, lastExec), Ahora) > 0 Then
                                    Ejecutar = True
                                End If
                            Case Else
                                Ejecutar = False
                                DaemonLoger.Loguear("el intervalo " & tipoIntervalo & " no está reconocido", EventLogEntryType.Error)
                        End Select
                    End If



                    If Ejecutar Then
                        If Not oAssembly.ExecuteMethod Is Nothing Then
                            ExecuteMethod(oAssembly)
                        End If

                        If Not oAssembly.ExecuteProperty Is Nothing Then
                            ExecuteProperty(oAssembly)
                        End If

                        SetLastExecution(Ahora, oAssembly)

                    End If


                Next
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function GetLastExecution(ByVal oAssembly As DaemonAssemblyEntity) As Date

        Dim DFileName As String = DaemonConfig.ApplicationPath & "\" & _
                                     oAssembly.LibraryName & "." & _
                                     oAssembly.ClassName & "." & _
                                     IIf(oAssembly.ExecuteMethod Is Nothing, "", oAssembly.ExecuteMethod).ToString & _
                                     IIf(oAssembly.ExecuteProperty Is Nothing, "", oAssembly.ExecuteMethod).ToString
        If Not System.IO.File.Exists(DFileName) Then
            Return Date.MinValue
        End If

        Dim fr As IO.StreamReader = Nothing
        Try
            fr = New IO.StreamReader(DFileName)
            Dim dt As String = fr.ReadLine()

            Return CDate(dt)

        Catch ex As Exception
            Return Date.MinValue
        Finally
            If Not fr Is Nothing Then fr.Close()
        End Try
        
        
    End Function

    Private Sub SetLastExecution(ByVal pDate As Date, ByVal oAssembly As DaemonAssemblyEntity)
        Dim DFileName As String = DaemonConfig.ApplicationPath & "\" & _
                                     oAssembly.LibraryName & "." & _
                                     oAssembly.ClassName & "." & _
                                     IIf(oAssembly.ExecuteMethod Is Nothing, "", oAssembly.ExecuteMethod).ToString & _
                                     IIf(oAssembly.ExecuteProperty Is Nothing, "", oAssembly.ExecuteMethod).ToString
        Dim fs As New System.IO.FileStream(DFileName, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
        Dim fw As New IO.StreamWriter(fs)
        fw.Write(pDate.ToString)
        fw.Flush()
        fw.Close()
        fs.Close()
    End Sub


    Shared Sub GetObjectPropertys(ByVal o As Object)
        Dim m As System.Reflection

    End Sub

    ''' <summary>
    ''' ejecuta un método mediante la instancia del tipo DaemonAssemblyEntity que NO retorna valor
    ''' </summary>
    ''' <param name="oAssemblyEntity">Instancia del nombre del ensamblado y metodo a ejecutar</param>
    ''' <remarks></remarks>
    Shared Sub ExecuteMethod(ByVal oAssemblyEntity As DaemonAssemblyEntity)
        Try


            Dim objectType As Type = Type.GetType(oAssemblyEntity.LibraryName & _
                                                "." & oAssemblyEntity.ClassName & _
                                                ", " & oAssemblyEntity.LibraryName, True)

            Dim myObject As Object = Activator.CreateInstance(objectType) ' Crea la instancia del objeto

            Dim mi As Reflection.MethodInfo = myObject.GetType().GetMethod(oAssemblyEntity.ExecuteMethod)

            If oAssemblyEntity.params Is Nothing Then
                mi.Invoke(myObject, Nothing)     ' Invoca al método (sin parámetros)
            Else
                Dim parameters() As Object = Nothing
                Dim i As Integer = 0
                For e As Int32 = 1 To oAssemblyEntity.params.Count Step 2
                    ReDim Preserve parameters(i)

                    If oAssemblyEntity.params(e - 1).ToLower = "nothing" Then
                        parameters(i) = Nothing
                    Else

                        Select Case oAssemblyEntity.params(e).ToLower
                            Case Is = "string"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), String)
                            Case Is = "int16"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Int16)
                            Case Is = "int32"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Int32)
                            Case Is = "int64"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Int64)
                            Case Is = "double"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Double)
                            Case Is = "boolean"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Boolean)
                            Case Is = "char"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Char)
                            Case Is = "date"
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Date)

                            Case Else
                                parameters(i) = CType(oAssemblyEntity.params(e - 1), Object)

                        End Select
                    End If
                    i = i + 1
                Next
                mi.Invoke(myObject, parameters)
            End If
            DaemonLoger.Loguear("Ejecutado: " & oAssemblyEntity.LibraryName & "." & oAssemblyEntity.ClassName)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' ejecuta un método mediante la instancia del tipo DaemonAssemblyEntity que retorna un valor
    ''' </summary>
    ''' <param name="oAssemblyEntity">Instancia del nombre del ensamblado y metodo a ejecutar</param>
    ''' <remarks></remarks>
    Shared Function ExecuteMethodOut(ByVal oAssemblyEntity As DaemonAssemblyEntity) As Object
        Try


            Dim objectType As Type = Type.GetType(oAssemblyEntity.LibraryName & _
                                                 "." & oAssemblyEntity.ClassName & _
                                                 ", " & oAssemblyEntity.LibraryName, True)

            Dim myObject As Object = Activator.CreateInstance(objectType) ' Crea la instancia del objeto

            Dim mi As Reflection.MethodInfo = myObject.GetType().GetMethod(oAssemblyEntity.ExecuteMethod)

            Dim oreOut As Object
            oreOut = mi.Invoke(myObject, Nothing)     ' Invoca al método (sin parámetros)
            DaemonLoger.Loguear("Ejecutado: " & oAssemblyEntity.LibraryName & "." & oAssemblyEntity.ClassName)
            Return oreOut

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Ejecuta la propiedad indicada en el objeto
    ''' </summary>
    ''' <param name="oAssemblyEntity">olbjeto que contiene la instancia de la clase</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function ExecuteProperty(ByVal oAssemblyEntity As DaemonAssemblyEntity) As Object
        Try

            Dim objectType As Type = Type.GetType(oAssemblyEntity.LibraryName & _
                                                 "." & oAssemblyEntity.ClassName & _
                                                 ", " & oAssemblyEntity.LibraryName, True)

            Dim myObject As Object = Activator.CreateInstance(objectType) ' Crea la instancia del objeto

            Dim pi As Reflection.PropertyInfo = myObject.GetType.GetProperty(oAssemblyEntity.ExecuteProperty)

            Dim oreOut As Object = pi.GetValue(myObject, Nothing) ' Recupera el valor de la propiedad
            DaemonLoger.Loguear("Ejecutado: " & oAssemblyEntity.LibraryName & "." & oAssemblyEntity.ClassName)
            Return oreOut
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
