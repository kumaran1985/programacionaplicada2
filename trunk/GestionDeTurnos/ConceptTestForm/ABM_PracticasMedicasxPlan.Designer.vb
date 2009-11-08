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
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.PMxP_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Plan_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OS_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PMxP_PorcentajeDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtbPMxP_Key = New System.Windows.Forms.MaskedTextBox
        Me.mtbOS_Key = New System.Windows.Forms.MaskedTextBox
        Me.mtbPlan_Key = New System.Windows.Forms.MaskedTextBox
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PMxP_Key, Me.Plan_Key, Me.OS_Key, Me.PMxP_PorcentajeDescuento})
        Me.dgvBusqueda.Location = New System.Drawing.Point(42, 93)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(483, 159)
        Me.dgvBusqueda.TabIndex = 0
        '
        'PMxP_Key
        '
        Me.PMxP_Key.DataPropertyName = "PMxP_Key"
        Me.PMxP_Key.HeaderText = "ID Practica Medica x Plan"
        Me.PMxP_Key.Name = "PMxP_Key"
        '
        'Plan_Key
        '
        Me.Plan_Key.DataPropertyName = "Plan_Key"
        Me.Plan_Key.HeaderText = "ID Plan"
        Me.Plan_Key.Name = "Plan_Key"
        '
        'OS_Key
        '
        Me.OS_Key.DataPropertyName = "OS_Key"
        Me.OS_Key.HeaderText = "ID Obra Social"
        Me.OS_Key.Name = "OS_Key"
        '
        'PMxP_PorcentajeDescuento
        '
        Me.PMxP_PorcentajeDescuento.DataPropertyName = "PMxP_PorcentajeDescuento"
        Me.PMxP_PorcentajeDescuento.HeaderText = "Porcentaje Descuento"
        Me.PMxP_PorcentajeDescuento.Name = "PMxP_PorcentajeDescuento"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(399, 8)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(176, 45)
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
        Me.Label3.Location = New System.Drawing.Point(0, 36)
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
        'mtbPMxP_Key
        '
        Me.mtbPMxP_Key.Location = New System.Drawing.Point(172, 8)
        Me.mtbPMxP_Key.Name = "mtbPMxP_Key"
        Me.mtbPMxP_Key.Size = New System.Drawing.Size(39, 20)
        Me.mtbPMxP_Key.TabIndex = 6
        '
        'mtbOS_Key
        '
        Me.mtbOS_Key.Location = New System.Drawing.Point(172, 57)
        Me.mtbOS_Key.Name = "mtbOS_Key"
        Me.mtbOS_Key.Size = New System.Drawing.Size(39, 20)
        Me.mtbOS_Key.TabIndex = 7
        '
        'mtbPlan_Key
        '
        Me.mtbPlan_Key.Location = New System.Drawing.Point(172, 33)
        Me.mtbPlan_Key.Name = "mtbPlan_Key"
        Me.mtbPlan_Key.Size = New System.Drawing.Size(39, 20)
        Me.mtbPlan_Key.TabIndex = 8
        '
        'ABM_PracticasMedicasxPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 332)
        Me.Controls.Add(Me.mtbPlan_Key)
        Me.Controls.Add(Me.mtbOS_Key)
        Me.Controls.Add(Me.mtbPMxP_Key)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Name = "ABM_PracticasMedicasxPlan"
        Me.Text = "ABM_PracticasMedicasxPlan"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PMxP_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Plan_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OS_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMxP_PorcentajeDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtbPMxP_Key As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbOS_Key As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbPlan_Key As System.Windows.Forms.MaskedTextBox
End Class
