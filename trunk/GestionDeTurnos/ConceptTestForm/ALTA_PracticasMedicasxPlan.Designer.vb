<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_PracticasMedicasxPlan
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPlan_Key = New System.Windows.Forms.TextBox
        Me.txtPMxP_PorcentajeDescuento = New System.Windows.Forms.TextBox
        Me.txtOS_Key = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Plan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Obra Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Porcentaje Descuento"
        '
        'txtPlan_Key
        '
        Me.txtPlan_Key.Location = New System.Drawing.Point(181, 19)
        Me.txtPlan_Key.Name = "txtPlan_Key"
        Me.txtPlan_Key.Size = New System.Drawing.Size(100, 20)
        Me.txtPlan_Key.TabIndex = 3
        '
        'txtPMxP_PorcentajeDescuento
        '
        Me.txtPMxP_PorcentajeDescuento.Location = New System.Drawing.Point(181, 70)
        Me.txtPMxP_PorcentajeDescuento.Name = "txtPMxP_PorcentajeDescuento"
        Me.txtPMxP_PorcentajeDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtPMxP_PorcentajeDescuento.TabIndex = 4
        '
        'txtOS_Key
        '
        Me.txtOS_Key.Location = New System.Drawing.Point(181, 44)
        Me.txtOS_Key.Name = "txtOS_Key"
        Me.txtOS_Key.Size = New System.Drawing.Size(100, 20)
        Me.txtOS_Key.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(317, 19)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(83, 38)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ALTA_PracticasMedicasxPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 122)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtOS_Key)
        Me.Controls.Add(Me.txtPMxP_PorcentajeDescuento)
        Me.Controls.Add(Me.txtPlan_Key)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ALTA_PracticasMedicasxPlan"
        Me.Text = "ALTA_PracticasMedicasxPlan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlan_Key As System.Windows.Forms.TextBox
    Friend WithEvents txtPMxP_PorcentajeDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtOS_Key As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class