Public MustInherit Class BrainWorkConnection
    Inherits AbstractConnection
    Private _TransactionCounter As Integer



    Protected MustOverride Function CastParameter(ByVal p As System.Data.Common.DbParameter) As System.Data.Common.DbParameter
    Public Property TransactionCounter() As Int32
        Get
            Return _TransactionCounter
        End Get
        Set(ByVal value As Int32)
            _TransactionCounter = value
        End Set
    End Property

    Protected ReadOnly Property IsInTransaction() As Boolean
        Get
            Return (TransactionCounter > 0)
        End Get
    End Property

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)
    End Sub

End Class
