Public Class ABMUsuarios

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Botonlistado.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLUsuarios
        Dim instanciaDeLaEntidad As Entities.EntUsuarios

        instanciaDeBussinesLogic = New BLClassLibrary.BLUsuarios
        instanciaDeLaEntidad = New Entities.EntUsuarios


        instanciaDeLaEntidad.User_Apellido = Me.txtapellido.Text
        instanciaDeLaEntidad.User_Nombre = Me.txtnombre.Text




        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1
    End Sub

    Private Sub dgvBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbusqueda.CellContentClick

    End Sub

    Private Sub ABMUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New ABM_Usuarios
        f.Show()
    End Sub
End Class