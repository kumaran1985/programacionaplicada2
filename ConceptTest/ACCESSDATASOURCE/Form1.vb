Public Class Form1

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        
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

    
End Class
