Public Class ABM_PracticasMedicas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPracticasMedicas
        Dim instanciaDeLaEntidad As Entities.EntPracticasMedicas

        instanciaDeBussinesLogic = New BLClassLibrary.BLPracticasMedicas
        instanciaDeLaEntidad = New Entities.EntPracticasMedicas

        If Me.mtbPM_Key.Text = "" And Me.txtPM_Descripcion.Text = "" Then
            MsgBox("Por favor ingrese algun dato para efectuar la busqueda")
        Else
            If Me.mtbPM_Key.Text <> "" Then
                instanciaDeLaEntidad.PM_Key = Me.mtbPM_Key.Text
            End If
            If Me.txtPM_Descripcion.Text <> "" Then
                instanciaDeLaEntidad.PM_Descripcion = Me.txtPM_Descripcion.Text
            End If
        End If

        Me.BindingSource2.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)

        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource2

    End Sub
    Private Sub ABM_PracticasMedicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base2006DataSet2.PracticasMedicas' Puede moverla o quitarla según sea necesario.
        Me.PracticasMedicasTableAdapter.Fill(Me.Base2006DataSet2.PracticasMedicas)

    End Sub
End Class