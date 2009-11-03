Public Class ABM_Facturas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLFacturas
        Dim instanciaDeLaEntidad As Entities.EntFacturas

        instanciaDeBussinesLogic = New BLClassLibrary.BLFacturas
        instanciaDeLaEntidad = New Entities.EntFacturas


        instanciaDeLaEntidad.Fact_Key = Me.Fact_Key.Text





        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = Me.BindingSource1

    End Sub


End Class