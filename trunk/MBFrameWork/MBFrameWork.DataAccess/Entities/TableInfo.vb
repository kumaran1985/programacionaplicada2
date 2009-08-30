Namespace Entities
    Public Class TableInfo
        Private m_TableName As String
        Private m_TableFields As List(Of Entities.TableFields)


        Public Property TableName() As String
            Get
                Return m_TableName
            End Get
            Set(ByVal value As String)
                m_TableName = value
            End Set
        End Property

        Public Property TableFields() As List(Of Entities.TableFields)
            Get
                Return m_TableFields
            End Get
            Set(ByVal value As List(Of Entities.TableFields))
                m_TableFields = value
            End Set
        End Property

    End Class
End Namespace
