Imports BrainWork.Security
Public MustInherit Class AbstractConnection
    Protected MustOverride Function CastParameter(ByVal p As System.Data.Common.DbParameter) As System.Data.Common.DbParameter
    Public Event OnConnect()
    Public Event OnDisconect()
    Public Event OnOpenConnection()
    Public Event OnCloseConnection()
    Public Event OnBeginTransaction()
    Public Event OnCommitTransaction()
    Public Event OnRollBackTransaction()
    Public Event OnExecuteAction()

    Public MustOverride Sub DBConnection_OnConnect() Handles Me.OnConnect



    Public _ApplicationUser As ApplicationUser
    Public ReadOnly Property ApplicationUser() As ApplicationUser
        Get
            Return _ApplicationUser
        End Get
    End Property

    Public Sub New(ByVal oUser As ApplicationUser)
        If oUser Is Nothing Then
            Throw New NotUserLoggedException
        End If
        _ApplicationUser = oUser
    End Sub

End Class
