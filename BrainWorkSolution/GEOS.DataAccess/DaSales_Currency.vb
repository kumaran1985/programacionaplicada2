Public Class DaSales_Currency
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess


    Protected Overrides Function GetEntity() As Object
        Return _CurrentEntity
    End Function

    Public Property CurrentEntity() As EntSales_Currency
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Currency)
            _CurrentEntity = value
        End Set
    End Property 


    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Currency)

    End Sub

    Protected Overrides Sub SetStoredProcedures()
        Me.SP_ADD = "prc_SalesCurrency_Insert"
        Me.SP_DELETE = "prc_SalesCurrency_Delete"
        Me.SP_DISABLE = "prc_SalesCurrency_Disable"
        Me.SP_GETALL = "prc_SalesCurrency_SelectAll"
        Me.SP_GETALL_FULLDESCRIPTION = "prc_SalesCurrency_SelectFullDescriptionAll"
        Me.SP_GETONE = "prc_SalesCurrency_SlectOne"
        Me.SP_UPDATE = "prc_SalesCurrency_Update"
        Me.SP_UPDATE_BY_PK = "prc_SalesCurrency_UpdateByPK"

    End Sub

   
End Class

