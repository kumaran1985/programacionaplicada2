<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nombre1 = New System.Windows.Forms.TextBox
        Me.Apellido1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Nombre1
        '
        Me.Nombre1.Location = New System.Drawing.Point(218, 13)
        Me.Nombre1.Name = "Nombre1"
        Me.Nombre1.Size = New System.Drawing.Size(221, 20)
        Me.Nombre1.TabIndex = 2
        '
        'Apellido1
        '
        Me.Apellido1.Location = New System.Drawing.Point(218, 57)
        Me.Apellido1.Name = "Apellido1"
        Me.Apellido1.Size = New System.Drawing.Size(221, 20)
        Me.Apellido1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 52)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Alta Usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ABM_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 242)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Apellido1)
        Me.Controls.Add(Me.Nombre1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Usuarios"
        Me.Text = "Alta de usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents Apellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
