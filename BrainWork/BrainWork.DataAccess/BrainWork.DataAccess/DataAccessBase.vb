Public MustInherit Class DataAccessBase
    Shared _DataMan As DataManager
    Private Property DataMan() As DataManager
        Get
            Return _DataMan
        End Get
        Set(ByVal value As DataManager)
            _DataMan = value
        End Set
    End Property

    Private ReadOnly Property ActiveDataMan() As DataManager
        Get
            If _DataMan Is Nothing Then
                _DataMan = New DataManager
                _DataMan.Connect()
            End If
            Return _DataMan
        End Get

    End Property
    Public Function Insert(ByVal entityObject As BrainWork.Entity.IEntity, ByVal generalObject As Object, ByRef strErrrorMessage As String) As Boolean
ActiveDataMan.ExecuteInsert(
    End Function

End Class
