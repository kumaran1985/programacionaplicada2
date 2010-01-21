Public Class ConnectionManager
    Inherits BrainWork.Connections.AbstractConnection
    Private Shared _singletonSession As Session
    Private oDBConnection As BrainWork.Connections.Interfaces.IDBrainWorkConnection

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)

    End Sub


    Private ReadOnly Property IsTransaction() As Boolean
        Get
            If GetSharedConnection Is Nothing Then
                Return False
            Else
                Return GetSharedConnection.TransactionCount > 0
            End If
        End Get

    End Property

    Private Shared ReadOnly Property UserInstance() As BrainWork.Security.ApplicationUser
        Get
            Return TryCast(_singletonSession("UserLogged"), BrainWork.Security.ApplicationUser)
        End Get
    End Property



    Private ReadOnly Property Session() As Session
        Get

            If ApplicationUser Is Nothing Then
                Throw New Exception("Connection Manager No ha detectado un usuario logueado")
            End If

            If _singletonSession Is Nothing Then
                _singletonSession = New Session(ApplicationUser.SessionID)

            ElseIf Not _singletonSession.ContainsClientIdentification(ApplicationUser.SessionID) Then
                _singletonSession = New Session(ApplicationUser.SessionID)
                _singletonSession.Add("UserLogged", ApplicationUser)
            End If

            _singletonSession.ClientID = ApplicationUser.SessionID


            Return _singletonSession
        End Get
    End Property

    Private ReadOnly Property GetSharedConnection() As BrainWork.Connections.Interfaces.IDBrainWorkConnection
        Get
            Dim oConexion As BrainWork.Connections.Interfaces.IDBrainWorkConnection
            oConexion = TryCast(Session("sharedConnection"), BrainWork.Connections.Interfaces.IDBrainWorkConnection)

            If oConexion Is Nothing Then
                Session("sharedConnection") = GetConnection(True)
            End If


            Return TryCast(Session("sharedConnection"), BrainWork.Connections.Interfaces.IDBrainWorkConnection)
        End Get
    End Property
    Private Sub SetSharedConnection()
        If Not Session.ContainsKey("sharedConnection") Then
            Session.Add("sharedConnection", GetConnection())
        End If

    End Sub




    Public Function getConnectionUser() As BrainWork.Connections.Interfaces.IDBrainWorkConnection
        Dim oConexion As BrainWork.Connections.Interfaces.IDBrainWorkConnection
        If IsTransaction Then
            oConexion = GetSharedConnection
            If oConexion Is Nothing Then
                oConexion = GetSharedConnection()
            End If
        Else
            oConexion = GetConnection()
        End If

        Return oConexion

    End Function

    

    Private Function GetConnection(Optional ByVal createNew As Boolean = False) As BrainWork.Connections.BrainWorkConnection

        If oDBConnection Is Nothing OrElse createNew Then
            oDBConnection = New BrainWork.Connections.SQLConnection.SQLDBrainWorkConnection(Me.ApplicationUser)
        End If
        Return oDBConnection
    End Function

    Public Sub BeginTransaction()
        GetSharedConnection.BeginTransaction()
    End Sub

    Public Sub commitTransaction()
        GetSharedConnection.CommitTransaction()
        If Not Me.IsTransaction Then
            Session("sharedConnection") = Nothing
        End If
    End Sub

    Public Sub rollbackTransaction()
        GetSharedConnection.RollBackTransaction()
        If Not Me.IsTransaction Then
            Session("sharedConnection") = Nothing
        End If

    End Sub

 
 



     
End Class
