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
End Class
