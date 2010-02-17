Partial Class Sales_Currency
    Inherits BrainWork.Utils.Web.AbstractCRUDPage

    

    Public Overrides ReadOnly Property MyGrid() As BrainWork.Utils.Web.WebControls.Data.GridView
        Get
            Return Me.GridView1
        End Get
    End Property

    'Public Function GetNewBussinesLogic() As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    '    Return CType(New GEOS.BussinesLogic.BlSales_Currency(CurrentUser), BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic)
    'End Function

    



    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        


        MyBase.AddCurrentValues()



    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SearchControl1.Entity = New GEOS.Entities.EntSales_Currency

        LoadSearchValuesInGrid(CType(Me.SearchControl1.GetEntityFiltered, GEOS.Entities.EntSales_Currency))


        '  LoadSearchValuesInGrid(New GEOS.Entities.EntSales_Currency)
    End Sub

    Public Sub New()
        MyBase.MainEntity = New GEOS.Entities.EntSales_Currency
        MyBase.MainBL = New GEOS.BussinesLogic.BlSales_Currency(CurrentUser)
    End Sub

    Protected Overrides Function GetCurrentForm() As System.Web.UI.HtmlControls.HtmlForm
        Return Me.form1
    End Function

    Public Overrides ReadOnly Property ControlsCointainerID() As String
        Get
            Return "pnlViewRead"
        End Get
    End Property
End Class
