Public Class ALTA_SysRoles

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim instanciaDeLaEntidad As New Entities.EntSys_Roles
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLSysRoles

        'completo los datos de la entidad

        instanciaDeLaEntidad.SYS_ROLE_Descripcion = Me.txtSYS_RoleDescripcion.Text

        If Me.chkSYS_ROLE_Enabled.Checked Then
            instanciaDeLaEntidad.SYS_ROLE_Enabled = 1

        Else
            instanciaDeLaEntidad.SYS_ROLE_Enabled = 0
        End If

        instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)


    End Sub

    Private Sub ALTA_SysRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class