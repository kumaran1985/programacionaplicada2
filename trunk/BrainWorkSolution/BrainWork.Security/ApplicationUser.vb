<Serializable()> _
Public Class ApplicationUser
    Dim _GetUserIDentification As String
    Public Property SessionID() As String
        Get
            Return "drrrr"
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property GetUserIDentification() As String
        Get
            Return _GetUserIDentification
        End Get
        Set(ByVal value As String)
            _GetUserIDentification = value
        End Set
    End Property
End Class
