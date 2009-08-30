Namespace Entities
    Public Class TableFields
        Inherits Fields
        Private m_isPrimary As Boolean = False
        Private m_ForeingKey As String
        Private m_ForeingTable As String
        Private m_FieldDescription As String



        Public Property isPrimary() As Boolean
            Get
                Return m_isPrimary
            End Get
            Set(ByVal value As Boolean)
                m_isPrimary = value
            End Set
        End Property

        

        Public Property ForeingKey() As String
            Get
                Return m_ForeingKey
            End Get
            Set(ByVal value As String)
                m_ForeingKey = value
            End Set
        End Property

        Public Property ForeingTable() As String
            Get
                Return m_ForeingTable
            End Get
            Set(ByVal value As String)
                m_ForeingTable = value
            End Set
        End Property

        Public Property FieldDescription() As String
            Get
                Return m_FieldDescription
            End Get
            Set(ByVal value As String)
                m_FieldDescription = value
            End Set
        End Property

    End Class

End Namespace
