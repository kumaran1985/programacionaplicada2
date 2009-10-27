Public Class ABM_PracticasMedicas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPracticasMedicas
        Dim instanciaDeLaEntidad As Entities.EntPracticasMedicas

        instanciaDeBussinesLogic = New BLClassLibrary.BLPracticasMedicas
        instanciaDeLaEntidad = New Entities.EntPracticasMedicas

        instanciaDeLaEntidad.PM_Descripcion = Me.Txt_PM_Descripcion.Text

        Me.BindingSource2.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)

        dgvBusqueda.AutoGenerateColumns = False
        DgvBusqueda.DataSource = Me.BindingSource2

    End Sub
End Class