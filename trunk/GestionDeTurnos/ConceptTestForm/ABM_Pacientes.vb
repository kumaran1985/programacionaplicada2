Public Class ABM_Pacientes

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPacientes
        Dim instanciaDeLaEntidad As Entities.EntPacientes

        instanciaDeBussinesLogic = New BLClassLibrary.BLPacientes
        instanciaDeLaEntidad = New Entities.EntPacientes


        instanciaDeLaEntidad.Pac_Nombres = Me.txtSRC_Pac_Nombres.Text
        instanciaDeLaEntidad.Pac_Apellidos = Me.txtSRC_Pac_Apellidos.Text
        instanciaDeLaEntidad.Pac_Calle = Me.txtSRC_Pac_Calle.Text
        instanciaDeLaEntidad.Pac_NumeroExt = Me.txtSRC_Pac_NumeroExt.Text
        instanciaDeLaEntidad.TDOC_Key = Me.txtSRC_TDOC_Key.Text
        instanciaDeLaEntidad.Pac_NumeroDoc = Me.txtSRC_Pac_NumeroDoc.Text
        If Me.DTP_Pac_FechaAlta.Checked = True Then
            instanciaDeLaEntidad.Pac_FechaAlta = Me.DTP_Pac_FechaAlta.Text
        End If






        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1

    End Sub
End Class