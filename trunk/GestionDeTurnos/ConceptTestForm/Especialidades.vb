Public Class Especialidades

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLEspecialidades
        Dim instanciaDeLaEntidad As Entities.EntEspecialidades

        instanciaDeBussinesLogic = New BLClassLibrary.BLEspecialidades
        instanciaDeLaEntidad = New Entities.EntEspecialidades


        instanciaDeLaEntidad.cDescripcion = Me.txt_Descripcion.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = True
        dgvBusqueda.DataSource = Me.BindingSource1

    End Sub
End Class