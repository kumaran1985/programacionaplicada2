Imports BrainWork.Security
Public MustInherit Class AbstractConnection


    Public Event OnConnect(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnDisconect(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnOpenConnection(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnCloseConnection(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnBeginTransaction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnCommitTransaction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnRollBackTransaction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnExecuteAction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnModifyValues(ByVal source As Object, ByVal e As System.EventArgs)

    Public Sub DBConnection_OnConnect(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnConnect
         
        RaiseEvent OnConnect(source, e)
    End Sub
    Public Sub DBConnection_OnDisconect(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnDisconect
        RaiseEvent OnDisconect(source, e)
    End Sub
    Public Sub DBConnection_OnOpenConnection(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnOpenConnection
        RaiseEvent OnOpenConnection(source, e)
    End Sub
    Public Sub DBConnection_OnCloseConnection(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnCloseConnection
        RaiseEvent OnCloseConnection(source, e)
    End Sub
    Public Sub DBConnection_OnBeginTransaction(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnBeginTransaction
        RaiseEvent OnBeginTransaction(source, e)
    End Sub
    Public Sub DBConnection_OnCommitTransaction(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnCommitTransaction
        RaiseEvent OnCommitTransaction(source, e)
    End Sub
    Public Sub DBConnection_OnExecuteAction(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnExecuteAction
        RaiseEvent OnExecuteAction(source, e)
    End Sub
    Public Sub DBConnection_OnModifyValues(ByVal source As Object, ByVal e As System.EventArgs) Handles Me.OnModifyValues
        RaiseEvent OnModifyValues(source, e)
    End Sub

    


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
        'AddHandler Me.OnModifyValues, AddressOf DBConnection_OnModifyValues
        'AddHandler Me.OnExecuteAction, AddressOf DBConnection_OnExecuteAction
        'AddHandler Me.OnCommitTransaction, AddressOf DBConnection_OnCommitTransaction
        'AddHandler Me.OnBeginTransaction, AddressOf DBConnection_OnBeginTransaction
        'AddHandler Me.OnCloseConnection, AddressOf DBConnection_OnCloseConnection
        'AddHandler Me.OnOpenConnection, AddressOf DBConnection_OnOpenConnection
        'AddHandler Me.OnDisconect, AddressOf DBConnection_OnDisconect
        'AddHandler Me.OnConnect, AddressOf DBConnection_OnConnect

    End Sub

End Class
