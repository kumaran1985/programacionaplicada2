Public Class BlSales_Currency
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_Currency
    Private _myDataAccess As DaSales_Currency

    Public Property CurrentEntity() As EntSales_Currency
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Currency)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Currency, New DaSales_Currency(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Currency)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_Currency)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CurrencyCode  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CurrencyCode is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class