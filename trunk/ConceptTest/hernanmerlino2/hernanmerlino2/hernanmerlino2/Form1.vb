Public Class Form1

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.UsuariosTableAdapter.Update(Me.UsuariosDataSet.Usuarios)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UsuariosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.UsuariosDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'UsuariosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.UsuariosDataSet.Usuarios)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.UsuariosTableAdapter.Update(Me.UsuariosDataSet.Usuarios)

    End Sub

    Private Sub USR_LastAcceessDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USR_LastAcceessDateTimePicker.ValueChanged

    End Sub
End Class
