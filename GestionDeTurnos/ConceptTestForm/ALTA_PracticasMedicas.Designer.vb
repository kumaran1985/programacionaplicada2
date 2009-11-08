<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_PracticasMedicas
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtPM_Descripcion = New System.Windows.Forms.TextBox
        Me.txtPM_PrecioPracticaMedica = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Practica Medica"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(293, 37)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 29)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtPM_Descripcion
        '
        Me.txtPM_Descripcion.Location = New System.Drawing.Point(149, 39)
        Me.txtPM_Descripcion.Name = "txtPM_Descripcion"
        Me.txtPM_Descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtPM_Descripcion.TabIndex = 3
        '
        'txtPM_PrecioPracticaMedica
        '
        Me.txtPM_PrecioPracticaMedica.Location = New System.Drawing.Point(149, 71)
        Me.txtPM_PrecioPracticaMedica.Name = "txtPM_PrecioPracticaMedica"
        Me.txtPM_PrecioPracticaMedica.Size = New System.Drawing.Size(100, 20)
        Me.txtPM_PrecioPracticaMedica.TabIndex = 4
        '
        'ALTA_PracticasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 127)
        Me.Controls.Add(Me.txtPM_PrecioPracticaMedica)
        Me.Controls.Add(Me.txtPM_Descripcion)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ALTA_PracticasMedicas"
        Me.Text = "ALTA_PracticasMedicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtPM_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtPM_PrecioPracticaMedica As System.Windows.Forms.TextBox
End Class
