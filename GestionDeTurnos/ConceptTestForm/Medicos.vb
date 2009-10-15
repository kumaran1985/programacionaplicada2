Public Class Medicos

    Private Sub btnbuscarapellido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarapellido.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLMedicos
        Dim instanciaDeLaEntidad As Entities.EntMedicos

        instanciaDeBussinesLogic = New BLClassLibrary.BLMedicos
        instanciaDeLaEntidad = New Entities.EntMedicos


        instanciaDeLaEntidad.Med_Apellidos = Me.txt_Med_Apellidos.Text

        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvMedicos.AutoGenerateColumns = True
        dgvMedicos.DataSource = Me.BindingSource1

    End Sub

    Private Sub dgvMedicos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMedicos.CellContentClick

    End Sub
End Class