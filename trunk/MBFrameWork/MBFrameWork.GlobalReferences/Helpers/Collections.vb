Imports System
Imports System.Reflection
Imports System.Collections
Imports System.Collections.Generic

Namespace Helpers


    Public Class Collections
        Public Shared Function ListaATabla(ByVal Lista As IList) As DataTable

            Dim Tabla As New DataTable()
            If Lista.Count > 0 Then

                Dim ObjetoBase As Object = Lista(0)
                Dim objectType As Type = ObjetoBase.GetType()
                Dim properties As PropertyInfo() = objectType.GetProperties()
                ' agregar columnas al Datatable
                Dim Columna As DataColumn
                For Each propertyInf As PropertyInfo In properties

                    Columna = New DataColumn()
                    Columna.ColumnName = CType(propertyInf.Name, String)

                    Dim dataType As Type = propertyInf.PropertyType
                    If dataType.IsGenericType _
                        AndAlso dataType.FullName.Contains("System.Nullable") Then 'Is GetType(System.Nullable) Then

                        dataType = System.Nullable.GetUnderlyingType(dataType)
                    End If

                    Columna.DataType = dataType
                    Tabla.Columns.Add(Columna)

                Next

                ' agregar filas de IList
                Dim Fila As DataRow
                For Each objItem As Object In Lista

                    Fila = Tabla.NewRow()
                    For Each propertyInf As PropertyInfo In properties

                        Dim val As Object = propertyInf.GetValue(objItem, Nothing)

                        Fila(propertyInf.Name) = IIf(val Is Nothing, DBNull.Value, val)

                    Next

                    Tabla.Rows.Add(Fila)

                Next

            End If

            Return Tabla

        End Function


    End Class


End Namespace
