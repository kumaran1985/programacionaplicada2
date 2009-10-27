Public Class ABM_Consultorios


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLConsultorios
        Dim instanciaDeLaEntidad As Entities.EntConsultorios

        instanciaDeBussinesLogic = New BLClassLibrary.BLConsultorios
        instanciaDeLaEntidad = New Entities.EntConsultorios


        instanciaDeLaEntidad.Cons_Descripcion = Me.txtSRC_CONS_Descripcion.Text
        instanciaDeLaEntidad.Cons_Ubicacion = Me.txtSRC_CONS_UBICACION.Text
        instanciaDeLaEntidad.Cons_Key = Me.txtSRC_CONS_KEY.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1
    End Sub

End Class