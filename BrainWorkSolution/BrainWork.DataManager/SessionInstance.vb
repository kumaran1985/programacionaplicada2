Option Strict On
Option Explicit On
<Serializable()> _
Public NotInheritable Class SessionInstance

    Private Shared _InstanceClient As New Generic.Dictionary(Of String, Hashtable)
    Private Shared _InstanceClear As New Generic.Dictionary(Of String, Date)
    Private Shared _InstanceObjectTypes As New Generic.Dictionary(Of String, System.Type)


    Public Shared Function ItemExists(ByVal ClientID As String) As Boolean
        ClientID = ClientID.Trim()
    End Function





    Private Shared Sub setTime(ByVal clientID As String)
        clientID = clientID.Trim()
        If _InstanceClear.ContainsKey(clientID) Then
            _InstanceClear.Item(clientID) = Now
        Else
            _InstanceClear.Add(clientID, Now)
        End If
    End Sub

    Public Shared Function GetSession(ByVal id As String, ByVal ClientID As String) As Object
        If String.IsNullOrEmpty(ClientID) Then Return Nothing
        If String.IsNullOrEmpty(id) Then Return Nothing

        ClientID = ClientID.Trim()
        id = id.Trim.ToLower
        If _InstanceClient.ContainsKey(ClientID) Then
            setTime(ClientID)

            If _InstanceClient.Item(ClientID).ContainsKey(id) Then

                Return _InstanceClient.Item(ClientID).Item(id)

            End If
        End If


        Return Nothing


    End Function


    Public Shared Sub SetSession(ByVal id As String, ByVal Value As Object, ByVal ClientID As String)
        id = id.Trim.ToLower
        ClientID = ClientID.Trim()
        If Not _InstanceClient.ContainsKey(ClientID) Then
            _InstanceClient.Add(ClientID, New Hashtable)
        End If



        If _InstanceClient.Item(ClientID).ContainsKey(id) Then
            _InstanceClient.Item(ClientID).Item(id) = Value
        Else
            _InstanceClient.Item(ClientID).Add(id, Value)
        End If

        setTime(ClientID)
    End Sub


    Public Shared Function GetClientID(ByVal ClientID As String) As Object
        ClientID = ClientID.Trim()
        If _InstanceClient.ContainsKey(ClientID) Then
            setTime(ClientID)
            Return _InstanceClient(ClientID)
        End If
        Return Nothing
    End Function

    Public Shared Function InstanceExists(ByVal clientID As String, Optional ByVal create As Boolean = False) As Boolean
        If String.IsNullOrEmpty(clientID) Then
            Return False
        End If
        clientID = clientID.Trim()
        If Not _InstanceClient.ContainsKey(clientID) AndAlso create Then
            _InstanceClient.Add(clientID, New Hashtable)
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Sub ClearSession(ByVal ClientID As String)
        ClientID = ClientID.Trim()
        If _InstanceClient.ContainsKey(ClientID) Then
            _InstanceClient.Remove(ClientID)
            If _InstanceClear.ContainsKey(ClientID) Then
                _InstanceClear.Remove(ClientID)
            End If
        End If
    End Sub


    Public Shared Sub CleanSessionTime(ByVal Minutes As Integer)

        For Each key As String In _InstanceClear.Keys
            If DateAdd(DateInterval.Minute, Minutes, _InstanceClear.Item(key)) >= Now Then
                _InstanceClear.Remove(key)
                _InstanceClient.Remove(key)
            End If
        Next

    End Sub

    Public Shared Function GetKeys(ByVal ClientID As String) As System.Collections.ICollection
        ClientID = ClientID.Trim()
        If _InstanceClient.ContainsKey(ClientID) Then
            setTime(ClientID)
            Return _InstanceClient.Item(ClientID).Keys
        End If
        Return Nothing
    End Function


    Public Shared Function GetClientSession(ByVal ClientID As String) As Hashtable
        ClientID = ClientID.Trim()
        If _InstanceClient.ContainsKey(ClientID) Then
            setTime(ClientID)
            Return _InstanceClient.Item(ClientID)
        End If
        Return Nothing
    End Function








End Class
