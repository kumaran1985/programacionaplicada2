Public Class BuscarXDescripcion


    Private Sub Btn_buscar_descripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar_descripcion.Click
        Dim instanciadelabussineslogic As BLClassLibrary.BLPracticasMedicas
        Dim instanciadelaentidad As Entities.EntPracticasMedicas

        instanciadelabussineslogic = New BLClassLibrary.BLPracticasMedicas
        instanciadelaentidad = New Entities.EntPracticasMedicas

        instanciadelaentidad.PM_Descripcion = Me.Txt_PM_Description.Text
        ABM_PracticasMedicas.BindingSource2.DataSource = instanciadelabussineslogic.GetListOfEntity(instanciadelaentidad)

        Me.Close()

    End Sub
End Class