Public Class Form1

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.Validate Then
            Me.UsuariosBindingSource.EndEdit()
            Me.UsuariosTableAdapter.Update(Me.UsuariosDataSet.Usuarios)
        Else
            System.Windows.Forms.MessageBox.Show(Me, "Validation errors occurred.", "Save", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.UsuariosDataSet.Usuarios.GetChanges Is Nothing Then
            If MessageBox.Show("Existen Datos que han sido modificados, " & _
                              " si cierra el formulario ahora, perderá los cambios. Desea cerrar el formulario?", _
                              "A D V E R T E N C I A", _
                             MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If

        End If
    End Sub
   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UsuariosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.UsuariosDataSet.Usuarios)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub USR_LastAcceessDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USR_LastAcceessDateTimePicker.ValueChanged

    End Sub
    Private Sub USR_LastAcceessLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub USR_MustChangePassCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USR_MustChangePassCheckBox.CheckedChanged

    End Sub
    Private Sub USR_MustChangePassLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub USR_PassTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USR_PassTextBox.TextChanged

    End Sub
    Private Sub USR_PassLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub USR_NombreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USR_NombreTextBox.TextChanged

    End Sub
    Private Sub USR_NombreLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub USR_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USR_IDTextBox.TextChanged

    End Sub
    Private Sub USR_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
