Partial Class Sales_Currency
    Inherits BrainWork.Utils.Web.AbstractPage

    Public ReadOnly Property MyGrid() As BrainWork.Utils.Web.WebControls.Data.GridView
        Get
            Return Me.GridView1
        End Get
    End Property

    Public Function GetNewBussinesLogic() As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
        Return CType(New GEOS.BussinesLogic.BlSales_Currency(CurrentUser), BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic)
    End Function

    Public Sub LoadSearchValuesInGrid(ByVal ent As Object)
        MyGrid.DataSource = Nothing
        MyGrid.DataBind()

        Dim bl As GEOS.BussinesLogic.BlSales_Currency
        bl = GetNewBussinesLogic()
        bl.CurrentEntity = CType(ent, GEOS.Entities.EntSales_Currency)
        MyGrid.SetDataSourceBussines(bl)
        ' MyGrid.DataSource = bl.GetDataTable()
        MyGrid.DataBind()
        'MyGrid.DataBindBussinesLogic()
    End Sub



    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            Dim Ent As New GEOS.Entities.EntSales_Currency
            GetEntityFromControls(Ent, Me.form1)
            Dim bl As New GEOS.BussinesLogic.BlSales_Currency(Me.CurrentUser)
            bl.CurrentEntity = Ent
            bl.Add()
            SucessAction("Se ha agregado el nuevo elemento, con el ID: " & bl.CurrentEntity.CurrencyCode)
        Catch ex As Exception
            ExceptionMessage(ex)
        End Try




    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SearchControl1.Entity = New GEOS.Entities.EntSales_Currency
        '  LoadSearchValuesInGrid(New GEOS.Entities.EntSales_Currency)
    End Sub

    Public Sub New()

    End Sub
End Class
