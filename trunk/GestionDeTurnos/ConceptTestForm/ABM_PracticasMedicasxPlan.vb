Public Class ABM_PracticasMedicasxPlan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPracticaMedicaxPlan
        Dim instanciaDeLaEntidad As Entities.EntPracticasMedicasxPlan

        instanciaDeBussinesLogic = New BLClassLibrary.BLPracticaMedicaxPlan
        instanciaDeLaEntidad = New Entities.EntPracticasMedicasxPlan

        If Me.mtbPMxP_Key.Text = "" And Me.mtbPlan_Key.Text = "" And Me.mtbOS_Key.Text = "" Then
            MsgBox("Por favor ingrese algun dato para poder realizar la busqueda")
        Else
            If Me.mtbPMxP_Key.Text <> "" Then
                instanciaDeLaEntidad.PMxP_Key = Me.mtbPMxP_Key.Text
            End If
            If Me.mtbPlan_Key.Text <> "" Then
                instanciaDeLaEntidad.Plan_Key = Me.mtbPlan_Key.Text
            End If
            If Me.mtbOS_Key.Text <> "" Then
                instanciaDeLaEntidad.OS_Key = Me.mtbOS_Key.Text
            End If
        End If

        Me.BindingSource3.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource3

    End Sub

End Class