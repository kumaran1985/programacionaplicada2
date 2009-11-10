
Public Class ALTA_PracticasMedicas

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Instancio la entidad Practicas Medicas
        Dim instanciaDeLaEntidad As New Entities.EntPracticasMedicas
        'Instanciamos la Business Logic Practicas Medicas
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLPracticasMedicas

        'Validamos que se ingresen valores en los campos
        If Me.txtPM_Descripcion.Text = "" Or Me.txtPM_PrecioPracticaMedica.Text = "" Then
            MsgBox("Por favor ingrese valores a todos los campos")
        Else
            'Colocamos en la entidad, los valores ingresados en el form de alta
            instanciaDeLaEntidad.PM_Descripcion = Me.txtPM_Descripcion.Text
            instanciaDeLaEntidad.PM_PrecioUnitario = Me.txtPM_PrecioPracticaMedica.Text

            'Llamamos a la DataAccess para ingresar los datos en la Base de Datos
            instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)
            MsgBox("La Practica Medica fue registrada")
            'Una vez guardado, limpiamos la pantalla
            Limpiar_Todo()
        End If
    End Sub

    Private Sub txtPM_PrecioPracticaMedica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPM_PrecioPracticaMedica.KeyPress
        'Nos aseguramos que no nos dejen ingresar otros valores que no sean numeros
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Limpiar_Todo()
        'Decimos que poner "Limpiar_Todo", nos deje en blanco todos los campos
        Me.txtPM_Descripcion.Text = ""
        Me.txtPM_PrecioPracticaMedica.Text = ""
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Al hacer click en "Cancelar" se limpian todos los campos
        Limpiar_Todo()
    End Sub
End Class