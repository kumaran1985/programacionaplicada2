<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_SysRoles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSYS_RoleDescripcion = New System.Windows.Forms.TextBox
        Me.chkSYS_ROLE_Enabled = New System.Windows.Forms.CheckBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtSYS_RoleDescripcion
        '
        Me.txtSYS_RoleDescripcion.Location = New System.Drawing.Point(22, 16)
        Me.txtSYS_RoleDescripcion.Name = "txtSYS_RoleDescripcion"
        Me.txtSYS_RoleDescripcion.Size = New System.Drawing.Size(170, 20)
        Me.txtSYS_RoleDescripcion.TabIndex = 0
        '
        'chkSYS_ROLE_Enabled
        '
        Me.chkSYS_ROLE_Enabled.AutoSize = True
        Me.chkSYS_ROLE_Enabled.Location = New System.Drawing.Point(22, 42)
        Me.chkSYS_ROLE_Enabled.Name = "chkSYS_ROLE_Enabled"
        Me.chkSYS_ROLE_Enabled.Size = New System.Drawing.Size(71, 17)
        Me.chkSYS_ROLE_Enabled.TabIndex = 2
        Me.chkSYS_ROLE_Enabled.Text = "Habiltado"
        Me.chkSYS_ROLE_Enabled.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(223, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 43)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ALTA_SysRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 67)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkSYS_ROLE_Enabled)
        Me.Controls.Add(Me.txtSYS_RoleDescripcion)
        Me.Name = "ALTA_SysRoles"
        Me.Text = "ALTA_SysRoles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSYS_RoleDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents chkSYS_ROLE_Enabled As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
