<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarXDescripcion
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt_PM_Description = New System.Windows.Forms.TextBox
        Me.Btn_buscar_descripcion = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la Descripcion que desea Buscar..."
        '
        'Txt_PM_Description
        '
        Me.Txt_PM_Description.Location = New System.Drawing.Point(47, 47)
        Me.Txt_PM_Description.Name = "Txt_PM_Description"
        Me.Txt_PM_Description.Size = New System.Drawing.Size(207, 20)
        Me.Txt_PM_Description.TabIndex = 1
        '
        'Btn_buscar_descripcion
        '
        Me.Btn_buscar_descripcion.Location = New System.Drawing.Point(118, 89)
        Me.Btn_buscar_descripcion.Name = "Btn_buscar_descripcion"
        Me.Btn_buscar_descripcion.Size = New System.Drawing.Size(75, 23)
        Me.Btn_buscar_descripcion.TabIndex = 2
        Me.Btn_buscar_descripcion.Text = "Buscar"
        Me.Btn_buscar_descripcion.UseVisualStyleBackColor = True
        '
        'BuscarXDescripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 124)
        Me.Controls.Add(Me.Btn_buscar_descripcion)
        Me.Controls.Add(Me.Txt_PM_Description)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BuscarXDescripcion"
        Me.Text = "BuscarXDescripcion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_PM_Description As System.Windows.Forms.TextBox
    Friend WithEvents Btn_buscar_descripcion As System.Windows.Forms.Button
End Class
