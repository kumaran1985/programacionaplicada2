Public Class ALTA_PracticasMedicas

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim instanciaDeLaEntidad As New Entities.EntPracticasMedicas
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLPracticasMedicas

        If Me.txtPM_Descripcion.Text = "" Or Me.txtPM_PrecioPracticaMedica.Text = "" Then
            MsgBox("Por favor ingrese valores a todos los campos")
        Else
            instanciaDeLaEntidad.PM_Descripcion = Me.txtPM_Descripcion.Text
            instanciaDeLaEntidad.PM_PrecioUnitario = Me.txtPM_PrecioPracticaMedica.Text

            instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)
            MsgBox("La Practica Medica fue registrada")
        End If



    End Sub

    Private Sub txtPM_PrecioPracticaMedica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPM_PrecioPracticaMedica.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class