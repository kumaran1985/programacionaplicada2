Public Class ALTA_PracticasMedicasxPlan

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim instanciaDeLaEntidad As New Entities.EntPracticasMedicasxPlan
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLPracticaMedicaxPlan

        If Me.txtOS_Key.Text = "" Or Me.txtPlan_Key.Text = "" Or Me.txtPMxP_PorcentajeDescuento.Text = "" Then
            MsgBox("Por favor ingrese valores a todos los campos")
        Else
            instanciaDeLaEntidad.Plan_Key = Me.txtPlan_Key.Text
            instanciaDeLaEntidad.OS_Key = Me.txtOS_Key.Text
            instanciaDeLaEntidad.PMxP_PorcentajeDescuento = Me.txtPMxP_PorcentajeDescuento.Text

            instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)
            MsgBox("La Practica Medica x Plan fue registrada")
        End If


    End Sub

    Private Sub txtPlan_Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlan_Key.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtOS_Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOS_Key.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtPMxP_PorcentajeDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPMxP_PorcentajeDescuento.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class