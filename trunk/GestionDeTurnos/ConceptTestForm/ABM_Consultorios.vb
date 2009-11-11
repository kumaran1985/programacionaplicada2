Public Class ABM_Consultorios


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        If Me.txtSRC_CONS_Descripcion.Text = "" And Me.txtSRC_CONS_UBICACION.Text = "" And Me.txtSRC_CONS_KEY.Text = "" Then
            MsgBox("Ingrese algun campo para la busqueda", MsgBoxStyle.Information, "Informacion")
        Else

            Dim instanciaDeBussinesLogic As BLClassLibrary.BLConsultorios
            Dim instanciaDeLaEntidad As Entities.EntConsultorios

            instanciaDeBussinesLogic = New BLClassLibrary.BLConsultorios
            instanciaDeLaEntidad = New Entities.EntConsultorios

            instanciaDeLaEntidad.Cons_Descripcion = Me.txtSRC_CONS_Descripcion.Text

            instanciaDeLaEntidad.Cons_Ubicacion = Me.txtSRC_CONS_UBICACION.Text

            If Me.txtSRC_CONS_KEY.Text <> "" Then
                instanciaDeLaEntidad.Cons_Key = Me.txtSRC_CONS_KEY.Text
            End If

            Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


            dgvBusqueda.AutoGenerateColumns = False
            dgvBusqueda.DataSource = Me.BindingSource1
        End If
    End Sub

    Private Sub txtSRC_CONS_KEY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRC_CONS_KEY.KeyPress
        If InStr("0123456789*", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSRC_CONS_KEY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_CONS_KEY.TextChanged
        If txtSRC_CONS_KEY.Text = "*" Then
            Dim instanciaDeBussinesLogic As BLClassLibrary.BLConsultorios
            Dim instanciaDeLaEntidad As Entities.EntConsultorios
            instanciaDeBussinesLogic = New BLClassLibrary.BLConsultorios
            instanciaDeLaEntidad = New Entities.EntConsultorios
            Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)
            dgvBusqueda.AutoGenerateColumns = False
            dgvBusqueda.DataSource = Me.BindingSource1
            txtSRC_CONS_KEY.Text = ""
        End If
    End Sub
End Class