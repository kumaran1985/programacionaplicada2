Public Class ABM_MotivoVisita


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLMotivoVisita
        Dim instanciaDeLaEntidad As Entities.EntMotivoVisita

        instanciaDeBussinesLogic = New BLClassLibrary.BLMotivoVisita
        instanciaDeLaEntidad = New Entities.EntMotivoVisita


        instanciaDeLaEntidad.MOVI_Descripcion = Me.txtSRC_MOVI_Descripcion.Text
        instanciaDeLaEntidad.MOVI_Motivo = Me.txtSRC_MOVI_MOTIVO.Text
        instanciaDeLaEntidad.MOVI_Key = Me.txtSRC_MOVI_KEY.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1
    End Sub

End Class