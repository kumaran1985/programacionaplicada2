<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_PracticasMedicasxPlan
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_PMxP_Key = New System.Windows.Forms.TextBox
        Me.TXT_PMxP_PorcentajeDescuento = New System.Windows.Forms.TextBox
        Me.TXT_OS_Key = New System.Windows.Forms.TextBox
        Me.TXT_Plan_Key = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(463, 128)
        Me.DataGridView1.TabIndex = 0
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(388, 12)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(118, 46)
        Me.cmdBuscar.TabIndex = 1
        Me.cmdBuscar.Text = "Buscar Practica Medica x Plan"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave Practicas Medicas x Plan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Clave Plan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Clave Obra Social"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Porcentaje Descuento"
        '
        'TXT_PMxP_Key
        '
        Me.TXT_PMxP_Key.Location = New System.Drawing.Point(159, 8)
        Me.TXT_PMxP_Key.Name = "TXT_PMxP_Key"
        Me.TXT_PMxP_Key.Size = New System.Drawing.Size(223, 20)
        Me.TXT_PMxP_Key.TabIndex = 7
        '
        'TXT_PMxP_PorcentajeDescuento
        '
        Me.TXT_PMxP_PorcentajeDescuento.Location = New System.Drawing.Point(159, 83)
        Me.TXT_PMxP_PorcentajeDescuento.Name = "TXT_PMxP_PorcentajeDescuento"
        Me.TXT_PMxP_PorcentajeDescuento.Size = New System.Drawing.Size(223, 20)
        Me.TXT_PMxP_PorcentajeDescuento.TabIndex = 8
        '
        'TXT_OS_Key
        '
        Me.TXT_OS_Key.Location = New System.Drawing.Point(159, 57)
        Me.TXT_OS_Key.Name = "TXT_OS_Key"
        Me.TXT_OS_Key.Size = New System.Drawing.Size(223, 20)
        Me.TXT_OS_Key.TabIndex = 9
        '
        'TXT_Plan_Key
        '
        Me.TXT_Plan_Key.Location = New System.Drawing.Point(159, 33)
        Me.TXT_Plan_Key.Name = "TXT_Plan_Key"
        Me.TXT_Plan_Key.Size = New System.Drawing.Size(223, 20)
        Me.TXT_Plan_Key.TabIndex = 10
        '
        'ABM_PracticasMedicasxPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 266)
        Me.Controls.Add(Me.TXT_Plan_Key)
        Me.Controls.Add(Me.TXT_OS_Key)
        Me.Controls.Add(Me.TXT_PMxP_PorcentajeDescuento)
        Me.Controls.Add(Me.TXT_PMxP_Key)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ABM_PracticasMedicasxPlan"
        Me.Text = "ABM_PracticasMedicasxPlan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_PMxP_Key As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PMxP_PorcentajeDescuento As System.Windows.Forms.TextBox
    Friend WithEvents TXT_OS_Key As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Plan_Key As System.Windows.Forms.TextBox
End Class
