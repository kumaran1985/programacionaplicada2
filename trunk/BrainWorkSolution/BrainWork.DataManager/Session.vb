Option Strict On
Option Explicit On

Imports System.Collections.Generic

<Serializable()> _
Public Class Session
    Implements System.Collections.Generic.IDictionary(Of String, Object)


    Private _ClientID As String

    Public Property ClientID() As String
        Get
            Return _ClientID
        End Get
        Set(ByVal value As String)
            SessionInstance.InstanceExists(value, True)
            _ClientID = value
        End Set
    End Property



    Public Sub Add(ByVal item As System.Collections.Generic.KeyValuePair(Of String, Object)) Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).Add
        SessionInstance.SetSession(item.Key, item.Value, ClientID)
    End Sub

    Public Sub Clear() Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).Clear
        SessionInstance.ClearSession(ClientID)
    End Sub

    Public Function Contains(ByVal item As System.Collections.Generic.KeyValuePair(Of String, Object)) As Boolean Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).Contains
        Return SessionInstance.GetClientSession(ClientID).Contains(item.Key)
    End Function

    Public Sub CopyTo(ByVal array() As System.Collections.Generic.KeyValuePair(Of String, Object), ByVal arrayIndex As Integer) Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).CopyTo
        SessionInstance.GetClientSession(ClientID).CopyTo(array, arrayIndex)
    End Sub

    Public ReadOnly Property Count() As Integer Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).Count
        Get
            Return SessionInstance.GetClientSession(ClientID).Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly() As Boolean Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).IsReadOnly
        Get
            Return SessionInstance.GetClientSession(ClientID).IsReadOnly
        End Get
    End Property

    Public Function Remove(ByVal item As System.Collections.Generic.KeyValuePair(Of String, Object)) As Boolean Implements System.Collections.Generic.ICollection(Of System.Collections.Generic.KeyValuePair(Of String, Object)).Remove
        If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
            SessionInstance.GetClientSession(ClientID).Remove(item.Key)
        End If
        Return False
    End Function

    Public Sub Add(ByVal key As String, ByVal value As Object) Implements System.Collections.Generic.IDictionary(Of String, Object).Add
        SessionInstance.SetSession(key, value, ClientID)
    End Sub

    Public Function ContainsClientIdentification(ByVal ClientID As String) As Boolean
        Return (Not (SessionInstance.GetClientSession(ClientID) Is Nothing))
    End Function

    Public Function ContainsKey(ByVal key As String) As Boolean Implements System.Collections.Generic.IDictionary(Of String, Object).ContainsKey
        If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
            Return SessionInstance.GetClientSession(ClientID).ContainsKey(key)
        End If
        Return False
    End Function

    Default Public Property Item(ByVal key As String) As Object Implements System.Collections.Generic.IDictionary(Of String, Object).Item
        Get

            Return SessionInstance.GetSession(key, ClientID)

        End Get
        Set(ByVal value As Object)

            SessionInstance.SetSession(key, value, ClientID)

        End Set
    End Property

    Public ReadOnly Property Keys() As System.Collections.Generic.ICollection(Of String) Implements System.Collections.Generic.IDictionary(Of String, Object).Keys
        Get
            If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
                Dim c As New List(Of String)
                For Each d As String In SessionInstance.GetClientSession(ClientID).Keys
                    c.Add(d.ToString)
                Next

                Return CType(c, System.Collections.Generic.ICollection(Of String))
            End If
            Return Nothing
        End Get
    End Property

    Public Function Remove(ByVal key As String) As Boolean Implements System.Collections.Generic.IDictionary(Of String, Object).Remove
        If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
            SessionInstance.GetClientSession(ClientID).Remove(key)
        End If
        Return False
    End Function

    Public Function TryGetValue(ByVal key As String, ByRef value As Object) As Boolean Implements System.Collections.Generic.IDictionary(Of String, Object).TryGetValue

    End Function

    Public ReadOnly Property Values() As System.Collections.Generic.ICollection(Of Object) Implements System.Collections.Generic.IDictionary(Of String, Object).Values
        Get
            If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
                Dim i As New List(Of Object)
                For Each v As Object In SessionInstance.GetClientSession(ClientID).Values
                    i.Add(v)
                Next
                Return CType(i, System.Collections.Generic.ICollection(Of Object))
            End If
            Return Nothing
        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) Implements System.Collections.Generic.IEnumerable(Of System.Collections.Generic.KeyValuePair(Of String, Object)).GetEnumerator
        'If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
        '    Return SessionInstance.GetClientSession(ClientID).GetEnumerator
        'End If
        Return Nothing
    End Function

    Public Function GetEnumerator1() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        If Not SessionInstance.GetClientSession(ClientID) Is Nothing Then
            Return SessionInstance.GetClientSession(ClientID).GetEnumerator
        End If
        Return Nothing
    End Function

    Public Sub New(ByVal ClientID As String)
        Me.ClientID = ClientID

    End Sub
End Class
