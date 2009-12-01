Imports System.Xml
''' <summary>
''' Clase de lectura y escritura
''' de los archivos de configuración de
''' la aplicación
''' </summary>
''' <remarks></remarks>

Public Class Config
    Shared Function GetConfigValue(ByVal key As String) As String
        Return ""
    End Function

    Shared Function GetConfigItems(ByVal xmlEntry As String) As System.Xml.XmlNodeList
        Return Nothing
    End Function


    ''' <summary>
    ''' Nombre del Owner del catalogo
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared CatalogName As String
    ''' <summary>
    ''' Intervalo en milisegundos que se ejecuta el 
    ''' demonio
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Intervalo As Int64
    ''' <summary>
    ''' Path en donde se está ejecutando el ensamblado
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared ApplicationPath As String
    Shared Sub New()
        'Intervalo = CInt(System.Configuration.ConfigurationManager.AppSettings("intervalo"))
        'CatalogName = System.Configuration.ConfigurationManager.AppSettings("CatalogName")
        ApplicationPath = System.IO.Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly.Location).ToString
    End Sub

    Private Shared Function ValidateValue(ByVal value As String) As String
        If String.IsNullOrEmpty(value) Then
            Return Nothing
        Else
            Return value.Trim
        End If
    End Function

    ''' <summary>
    ''' Obtiene la lista de ensamblados almacenados en el archivo
    ''' config.xml
    ''' </summary>
    ''' <returns>Colección</returns>
    ''' <remarks></remarks>
    Public Shared Function GetAssemblies() As List(Of BAssemblyEntity)
        Dim oXML As New Xml.XmlDocument
        Try
            oXML.Load(ApplicationPath & "\Config.xml")
            If Not oXML.HasChildNodes Then
                Throw New Exception("No se puede encontrar los elementos")
            End If
            'Nueva instancia de la colección
            GetAssemblies = New List(Of BAssemblyEntity)
            Dim oEntity As BAssemblyEntity = Nothing

            For Each nodo As XmlNode In oXML.SelectNodes("Configuration/Assemblies/Assembly")
                oEntity = New BAssemblyEntity
                oEntity.ClassName = ValidateValue(nodo.Item("ClassName").GetAttribute("value"))
                oEntity.ExecuteMethod = ValidateValue(nodo.Item("ExecuteMethod").GetAttribute("value"))
                oEntity.ExecuteProperty = ValidateValue(nodo.Item("ExecuteProperty").GetAttribute("value"))
                If Not ValidateValue(nodo.Item("ExecuteMethod").GetAttribute("value")) Is Nothing Then
                    If Not ValidateValue(nodo.Item("ExecuteMethod").GetAttribute("params")) Is Nothing Then
                        Dim s() As String
                        Dim lstr As New List(Of String)
                        s = ValidateValue(nodo.Item("ExecuteMethod").GetAttribute("params")).Split(CChar(","))
                        For i As Integer = 0 To s.Length - 1
                            Dim ostr As String = s(i).Trim
                            lstr.Add(ostr)
                        Next

                        If lstr.Count > 0 Then
                            oEntity.params = lstr
                        End If

                    End If
                End If
                oEntity.TimerSpanType = ValidateValue(nodo.Item("TimerSpan").GetAttribute("TimeType"))
                oEntity.TimerSpanValue = ValidateValue(nodo.Item("TimerSpan").GetAttribute("value"))
                oEntity.LibraryName = ValidateValue(nodo.Item("LibraryName").GetAttribute("value"))
                GetAssemblies.Add(oEntity)
            Next

            If GetAssemblies.Count <= 0 Then Return Nothing

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Function

End Class
