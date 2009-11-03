<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_MotivoVisita
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
        Me.txtSRC_MOVI_KEY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.MOVI_KEY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOVI_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOVI_MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtSRC_MOVI_Descripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSRC_MOVI_MOTIVO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSRC_MOVI_KEY
        '
        Me.txtSRC_MOVI_KEY.Location = New System.Drawing.Point(144, 18)
        Me.txtSRC_MOVI_KEY.Name = "txtSRC_MOVI_KEY"
        Me.txtSRC_MOVI_KEY.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_MOVI_KEY.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Clave"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MOVI_KEY, Me.MOVI_DESCRIPCION, Me.MOVI_MOTIVO})
        Me.dgvBusqueda.Location = New System.Drawing.Point(78, 110)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(442, 171)
        Me.dgvBusqueda.TabIndex = 15
        '
        'MOVI_KEY
        '
        Me.MOVI_KEY.DataPropertyName = "MOVI_KEY"
        Me.MOVI_KEY.HeaderText = "ID Motivo Visita"
        Me.MOVI_KEY.Name = "MOVI_KEY"
        '
        'MOVI_DESCRIPCION
        '
        Me.MOVI_DESCRIPCION.DataPropertyName = "MOVI_DESCRIPCION"
        Me.MOVI_DESCRIPCION.HeaderText = "Descripcion"
        Me.MOVI_DESCRIPCION.Name = "MOVI_DESCRIPCION"
        '
        'MOVI_MOTIVO
        '
        Me.MOVI_MOTIVO.DataPropertyName = "MOVI_MOTIVO"
        Me.MOVI_MOTIVO.HeaderText = "Motivo"
        Me.MOVI_MOTIVO.Name = "MOVI_MOTIVO"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(360, 18)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(160, 75)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.Text = "Buscar Motivo Visita"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtSRC_MOVI_Descripcion
        '
        Me.txtSRC_MOVI_Descripcion.Location = New System.Drawing.Point(144, 46)
        Me.txtSRC_MOVI_Descripcion.Name = "txtSRC_MOVI_Descripcion"
        Me.txtSRC_MOVI_Descripcion.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_MOVI_Descripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripcion"
        '
        'txtSRC_MOVI_MOTIVO
        '
        Me.txtSRC_MOVI_MOTIVO.Location = New System.Drawing.Point(144, 73)
        Me.txtSRC_MOVI_MOTIVO.Name = "txtSRC_MOVI_MOTIVO"
        Me.txtSRC_MOVI_MOTIVO.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_MOVI_MOTIVO.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Motivo"
        '
        'ABM_MotivoVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 322)
        Me.Controls.Add(Me.txtSRC_MOVI_MOTIVO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSRC_MOVI_KEY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtSRC_MOVI_Descripcion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_MotivoVisita"
        Me.Text = "ABM_MotivoVisita"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSRC_MOVI_KEY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtSRC_MOVI_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSRC_MOVI_MOTIVO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MOVI_KEY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOVI_DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOVI_MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
