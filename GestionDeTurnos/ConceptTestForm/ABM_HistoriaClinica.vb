Public Class ABM_HistoriaClinica

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLDetalleHistoriaClinica
        Dim instanciaDeLaEntidad As Entities.EntDetalleHistoriaClinica

        instanciaDeBussinesLogic = New BLClassLibrary.BLDetalleHistoriaClinica
        instanciaDeLaEntidad = New Entities.EntDetalleHistoriaClinica
        If Me.TextBox1.Text = "" Then
            MsgBox("Debe ingresar un numero de historia clinica")
            Me.TextBox1.Focus()
        Else
            instanciaDeLaEntidad.Deta_key = Me.TextBox1.Text()
            'instanciaDeLaEntidad.SYS_ROLE_KEY = Me.txtSRC_SYS_ROL_KEY.Text

            Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)
            If Me.BindingSource1.Count = 0 Then
                MsgBox("No existe ningún Paciente registrado con los datos suministrados")

            End If
        End If






        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        DataGridView1.AutoGenerateColumns = False


        DataGridView1.DataSource = Me.BindingSource1



    End Sub

    Private Sub ABM_HistoriaClinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        

    End Sub
End Class