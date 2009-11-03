<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Turnos
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
        Me.txtSRC_SYS_ROL_KEY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.turno_key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.turno_estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.turno_fechacancelacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.turno_fecha = New System.Windows.Forms.DateTimePicker
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSRC_SYS_ROL_KEY
        '
        Me.txtSRC_SYS_ROL_KEY.Location = New System.Drawing.Point(131, 60)
        Me.txtSRC_SYS_ROL_KEY.Name = "txtSRC_SYS_ROL_KEY"
        Me.txtSRC_SYS_ROL_KEY.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_SYS_ROL_KEY.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Clave"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.turno_key, Me.turno_estado, Me.turno_fechacancelacion})
        Me.dgvBusqueda.Location = New System.Drawing.Point(58, 104)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(442, 150)
        Me.dgvBusqueda.TabIndex = 9
        '
        'turno_key
        '
        Me.turno_key.DataPropertyName = "turno_key"
        Me.turno_key.HeaderText = "ID de turno"
        Me.turno_key.Name = "turno_key"
        '
        'turno_estado
        '
        Me.turno_estado.DataPropertyName = "turno_estado"
        Me.turno_estado.HeaderText = "fecha estado"
        Me.turno_estado.Name = "turno_estado"
        '
        'turno_fechacancelacion
        '
        Me.turno_fechacancelacion.DataPropertyName = "turno_fechacancelacion"
        Me.turno_fechacancelacion.HeaderText = "FdeCancelacion"
        Me.turno_fechacancelacion.Name = "turno_fechacancelacion"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(340, 31)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(160, 49)
        Me.cmdBuscar.TabIndex = 8
        Me.cmdBuscar.Text = "Buscar fecha de turno"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "fecha"
        '
        'turno_fecha
        '
        Me.turno_fecha.Location = New System.Drawing.Point(127, 34)
        Me.turno_fecha.Name = "turno_fecha"
        Me.turno_fecha.Size = New System.Drawing.Size(200, 20)
        Me.turno_fecha.TabIndex = 12
        '
        'ABM_Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 266)
        Me.Controls.Add(Me.turno_fecha)
        Me.Controls.Add(Me.txtSRC_SYS_ROL_KEY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Turnos"
        Me.Text = "ABM_Turnos"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSRC_SYS_ROL_KEY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents turno_key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turno_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turno_fechacancelacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turno_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
