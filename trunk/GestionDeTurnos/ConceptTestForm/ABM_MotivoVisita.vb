Public Class ABM_MotivoVisita


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Me.txtSRC_MOVI_Descripcion.Text = "" AndAlso Me.txtSRC_MOVI_MOTIVO.Text = "" AndAlso Me.txtSRC_MOVI_KEY.Text = "" Then

            MsgBox("Ingrese algun campo para la busqueda", MsgBoxStyle.Information, "Informacion")

        Else
            Dim instanciaDeBussinesLogic As BLClassLibrary.BLMotivoVisita
            Dim instanciaDeLaEntidad As Entities.EntMotivoVisita

            instanciaDeBussinesLogic = New BLClassLibrary.BLMotivoVisita
            instanciaDeLaEntidad = New Entities.EntMotivoVisita


            instanciaDeLaEntidad.MOVI_Descripcion = Me.txtSRC_MOVI_Descripcion.Text
            instanciaDeLaEntidad.MOVI_Motivo = Me.txtSRC_MOVI_MOTIVO.Text
            If Me.txtSRC_MOVI_KEY.Text <> "" Then
                instanciaDeLaEntidad.MOVI_Key = Me.txtSRC_MOVI_KEY.Text
            End If

            Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


            dgvBusqueda.AutoGenerateColumns = False
            dgvBusqueda.DataSource = Me.BindingSource1
        End If
    End Sub

    Private Sub txtSRC_MOVI_KEY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRC_MOVI_KEY.KeyPress

        ' para que me deje escribir solo numero 
        'If Not IsNumeric(e.KeyChar) Then
        '    e.Handled = True
        'End If


        'pasa todo a mayuscula
        'Dim s As Char = UCase(e.KeyChar)

        ' para que me deje escribir solo letras mayuscula
        'If 64 < Asc(s) AndAlso Asc(s) < 91 Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If

        If InStr("0123456789*", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtSRC_MOVI_KEY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_MOVI_KEY.TextChanged
        If txtSRC_MOVI_KEY.Text = "*" Then
            Dim instanciaDeBussinesLogic As BLClassLibrary.BLMotivoVisita
            Dim instanciaDeLaEntidad As Entities.EntMotivoVisita
            instanciaDeBussinesLogic = New BLClassLibrary.BLMotivoVisita
            instanciaDeLaEntidad = New Entities.EntMotivoVisita
            Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)
            dgvBusqueda.AutoGenerateColumns = False
            dgvBusqueda.DataSource = Me.BindingSource1
            txtSRC_MOVI_KEY.Text = ""
        End If
    End Sub
End Class