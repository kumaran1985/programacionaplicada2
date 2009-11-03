Public Class ABM_DetalleHistoriaClinica

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLDetalleHistoriaClinica
        Dim instanciaDeLaEntidad As Entities.EntDetalleHistoriaClinica

        instanciaDeBussinesLogic = New BLClassLibrary.BLDetalleHistoriaClinica
        instanciaDeLaEntidad = New Entities.EntDetalleHistoriaClinica

        'instanciaDeLaEntidad.SYS_ROLE_KEY = Me.txtSRC_SYS_ROL_KEY.Text
        instanciaDeLaEntidad.Deta_key = Me.txtSrc_Deta_key.text





        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        DataGridView1.AutoGenerateColumns = False

        DataGridView1.DataSource = Me.BindingSource1
    End Sub
End Class