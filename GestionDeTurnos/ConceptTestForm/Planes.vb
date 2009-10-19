Public Class Planes

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPlanes
        Dim instanciaDeLaEntidad As Entities.EntPlanes

        instanciaDeBussinesLogic = New BLClassLibrary.BLPlanes
        instanciaDeLaEntidad = New Entities.EntPlanes


        instanciaDeLaEntidad.Plan_Descripcion = Me.txt_Descripcion.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = True
        dgvBusqueda.DataSource = Me.BindingSource1

    End Sub
End Class