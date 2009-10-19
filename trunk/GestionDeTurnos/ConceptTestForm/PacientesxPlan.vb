Public Class PacientesxPlan

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click


        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPacientesxPlan
        Dim instanciaDeLaEntidad As Entities.EntPacientexPlan

        instanciaDeBussinesLogic = New BLClassLibrary.BLPacientesxPlan
        instanciaDeLaEntidad = New Entities.EntPacientexPlan


        instanciaDeLaEntidad.iNroHC = Me.txt_Descripcion.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = True
        dgvBusqueda.DataSource = Me.BindingSource1


    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_Descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Descripcion.TextChanged

    End Sub

    Private Sub dgvBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentClick

    End Sub
End Class