Partial Class Sales_Currency
    Inherits BrainWork.Utils.Web.AbstractPage

    
                               
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
End Class
