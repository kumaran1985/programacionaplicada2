Public Class Form1

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.UsuariosTableAdapter.Update(Me.UsuariosDataSet.Usuarios)

    End Sub


   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UsuariosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.UsuariosDataSet.Usuarios)
      
    End Sub

    

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click
        If USR_MustChangePassCheckBox.Checked Then
            MsgBox("El usuario, debe cambiar la contraseña")
        End If
       
    End Sub

    'MsgBox(Me.UsuariosDataSet.Usuarios(CInt(Me.BindingNavigatorPositionItem.Text) - 1).USR_ID())

    
End Class
