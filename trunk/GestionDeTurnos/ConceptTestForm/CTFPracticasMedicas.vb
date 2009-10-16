Public Class CTFPracticasMedicas


    Private Sub CMDBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBuscar.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPracticasMedicas
        Dim instanciaDeLaEntidad As Entities.EntPracticasMedicas

        instanciaDeBussinesLogic = New BLClassLibrary.BLPracticasMedicas
        instanciaDeLaEntidad = New Entities.EntPracticasMedicas


        instanciaDeLaEntidad.PM_Descripcion = Me.TXTPM_Description.Text


        Me.BDS_PracticasMedicas.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        DGVPracticasmedicas.AutoGenerateColumns = True
        DGVPracticasmedicas.DataSource = Me.BDS_PracticasMedicas




    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class