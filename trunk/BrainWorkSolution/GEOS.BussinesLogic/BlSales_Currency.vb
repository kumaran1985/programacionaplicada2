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
            RefreshEntityDataAccess()
        End Set
    End Property

    Public Overrides Sub RefreshEntityDataAccess()
        If Me._myDataAccess Is Nothing = False Then
            Me._myDataAccess.CurrentEntity = Me.CurrentEntity
        End If
    End Sub

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)

        MyBase.New(oUser, New DaSales_Currency(oUser))
        Me.CurrentEntity = New EntSales_Currency
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_Currency)


        Me.CurrentEntity.CurrencyCode = Nothing
        Me.CurrentEntity.ModifiedDate = Nothing
        Me.CurrentEntity.Name = Nothing

    End Sub


    Public Overrides Function ClassValidation(ByRef strError As String, _
             ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean
        If Me.CurrentEntity.CurrencyCode Is Nothing OrElse _
           Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _
           Me.CurrentEntity.Name Is Nothing OrElse _
                                             False Then
            strError = "Error de validación general"
            Return False
        Else
            Return True
        End If

    End Function



    'Public Overrides Sub SetEntity(ByVal value As Object)
    '    If Not value.GetType.Name = "EntSales_Currency" Then
    '        Throw New Exception("la clase base debe ser del tipo EntSales_Currency")
    '    End If
    '    _CurrentEntity = value
    '    MyBase._Entity = _CurrentEntity
    '    RefreshEntityDataAccess()
    'End Sub

    Public Overrides Property EntityObject() As Object
        Get
            Return Me.CurrentEntity
        End Get
        Set(ByVal value As Object)
            If Not value.GetType.Name = "EntSales_Currency" Then
                Throw New Exception("la clase base debe ser del tipo EntSales_Currency")
            End If
            Me.CurrentEntity = value
        End Set
    End Property
End Class