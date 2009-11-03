Public Class ABM_TiposDocumento

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLTiposDocumento
        Dim instanciaDeLaEntidad As Entities.EntTiposDocumento

        instanciaDeBussinesLogic = New BLClassLibrary.BLTiposDocumento
        instanciaDeLaEntidad = New Entities.EntTiposDocumento


        instanciaDeLaEntidad.TDOC_Descripcion = Me.txtSRC_TDOC_Descripcion.Text
        If txtSRC_TDOC_KEY.Text <> "" Then
            instanciaDeLaEntidad.TDOC_Key = Me.txtSRC_TDOC_KEY.Text
        End If

        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1
    End Sub

    Private Sub txtSRC_TDOC_KEY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRC_TDOC_KEY.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class