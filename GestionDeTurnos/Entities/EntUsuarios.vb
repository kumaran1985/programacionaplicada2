Public Class EntUsuarios
    Private m_USR_ID As Integer
    Private m_USR_Nombre As String
    Private m_USR_Pass As String
    Private m_USR_MustChangePass As Boolean
    Private m_USR_LastAcceess As Date


    Public Property USR_ID() As Integer
        Get
            Return m_USR_ID
        End Get
        Set(ByVal value As Integer)
            m_USR_ID = value
        End Set
    End Property

    Public Property USR_Nombre() As String
        Get
            Return m_USR_Nombre
        End Get
        Set(ByVal value As String)
            m_USR_Nombre = value
        End Set
    End Property

    Public Property USR_Pass() As String
        Get
            Return m_USR_Pass
        End Get
        Set(ByVal value As String)
            m_USR_Pass = value
        End Set
    End Property

    Public Property USR_MustChangePass() As Boolean
        Get
            Return m_USR_MustChangePass
        End Get
        Set(ByVal value As Boolean)
            m_USR_MustChangePass = value
        End Set
    End Property

    Public Property USR_LastAcceess() As Date
        Get
            Return m_USR_LastAcceess
        End Get
        Set(ByVal value As Date)
            m_USR_LastAcceess = value
        End Set
    End Property

End Class
