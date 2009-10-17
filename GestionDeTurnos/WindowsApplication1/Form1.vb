Public Class Form1

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLDetalleHistoriaClinica
        Dim instanciaDeLaEntidad As Entities.EntDetalleHistoriaClinica

        instanciaDeBussinesLogic = New BLClassLibrary.BLDetalleHistoriaClinica
        instanciaDeLaEntidad = New Entities.EntDetalleHistoriaClinica


        instanciaDeLaEntidad.Deta_Descripcion = Me.TextBox1.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = Me.BindingSource1



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
