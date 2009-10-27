Public Class ABM_TiposDocumento

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLTiposDocumento
        Dim instanciaDeLaEntidad As Entities.EntTiposDocumento

        instanciaDeBussinesLogic = New BLClassLibrary.BLTiposDocumento
        instanciaDeLaEntidad = New Entities.EntTiposDocumento


        instanciaDeLaEntidad.TDOC_Descripcion = Me.txtSRC_TDOC_Descripcion.Text
        instanciaDeLaEntidad.TDOC_Key = Me.txtSRC_TDOC_KEY.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtSRC_TDOC_Descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_TDOC_Descripcion.TextChanged

    End Sub

    Private Sub txtSRC_TDOC_KEY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_TDOC_KEY.TextChanged

    End Sub

    Private Sub dgvBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentClick

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class