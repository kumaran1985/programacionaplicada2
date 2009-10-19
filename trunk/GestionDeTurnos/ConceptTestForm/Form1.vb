Public Class Form1

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLSysRoles
        Dim instanciaDeLaEntidad As Entities.EntSys_Roles

        instanciaDeBussinesLogic = New BLClassLibrary.BLSysRoles
        instanciaDeLaEntidad = New Entities.EntSys_Roles


        instanciaDeLaEntidad.SYS_ROLE_Descripcion = Me.txtSRC_SYS_ROLE_DESCRIPTION.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = True
        dgvBusqueda.DataSource = Me.BindingSource1




    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub dgvBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtSRC_SYS_ROLE_DESCRIPTION_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_SYS_ROLE_DESCRIPTION.TextChanged

    End Sub
End Class
