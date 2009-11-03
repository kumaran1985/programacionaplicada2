Public Class ABM_Pacientes

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPacientes
        Dim instanciaDeLaEntidad As Entities.EntPacientes

        instanciaDeBussinesLogic = New BLClassLibrary.BLPacientes
        instanciaDeLaEntidad = New Entities.EntPacientes

        If Me.txtSRC_Pac_Key.Text <> "" Then
            instanciaDeLaEntidad.Pac_key = Me.txtSRC_Pac_Key.Text
        End If
        instanciaDeLaEntidad.Pac_Nombres = Me.txtSRC_Pac_Nombres.Text
        instanciaDeLaEntidad.Pac_Apellidos = Me.txtSRC_Pac_Apellidos.Text
        instanciaDeLaEntidad.Pac_Calle = Me.txtSRC_Pac_Calle.Text
        instanciaDeLaEntidad.Pac_NumeroExt = Me.txtSRC_Pac_NumeroExt.Text
        If Me.txtSRC_TDOC_Key.Text <> "" Then
            instanciaDeLaEntidad.TDOC_Key = Me.txtSRC_TDOC_Key.Text
        End If
        instanciaDeLaEntidad.Pac_NumeroDoc = Me.txtSRC_Pac_NumeroDoc.Text
        If Me.DTP_Pac_FechaAlta.Checked = True Then
            instanciaDeLaEntidad.Pac_FechaAlta = Me.DTP_Pac_FechaAlta.Text
        End If






        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1

    End Sub

    Private Sub txtSRC_Pac_Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRC_Pac_Key.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSRC_Pac_Key_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_Pac_Key.TextChanged
    End Sub

    Private Sub txtSRC_Pac_Nombres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_Pac_Nombres.TextChanged

    End Sub

    Private Sub txtSRC_Pac_NumeroExt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRC_Pac_NumeroExt.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSRC_Pac_NumeroExt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_Pac_NumeroExt.TextChanged

    End Sub

    Private Sub txtSRC_Pac_NumeroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRC_Pac_NumeroDoc.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSRC_Pac_NumeroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_Pac_NumeroDoc.TextChanged

    End Sub
End Class