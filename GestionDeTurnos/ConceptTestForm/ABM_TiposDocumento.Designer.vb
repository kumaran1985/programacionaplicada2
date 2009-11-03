<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_TiposDocumento
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
        Me.txtSRC_TDOC_KEY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.TDoc_KEY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDOC_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtSRC_TDOC_Descripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSRC_TDOC_KEY
        '
        Me.txtSRC_TDOC_KEY.Location = New System.Drawing.Point(110, 24)
        Me.txtSRC_TDOC_KEY.Name = "txtSRC_TDOC_KEY"
        Me.txtSRC_TDOC_KEY.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_TDOC_KEY.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Clave"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TDoc_KEY, Me.TDOC_DESCRIPCION})
        Me.dgvBusqueda.Location = New System.Drawing.Point(44, 93)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(442, 150)
        Me.dgvBusqueda.TabIndex = 9
        '
        'TDoc_KEY
        '
        Me.TDoc_KEY.DataPropertyName = "TDoc_KEY"
        Me.TDoc_KEY.HeaderText = "ID de Tipo de Documento"
        Me.TDoc_KEY.Name = "TDoc_KEY"
        '
        'TDOC_DESCRIPCION
        '
        Me.TDOC_DESCRIPCION.DataPropertyName = "TDOC_DESCRIPCION"
        Me.TDOC_DESCRIPCION.HeaderText = "Descripcion"
        Me.TDOC_DESCRIPCION.Name = "TDOC_DESCRIPCION"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(312, 24)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(160, 49)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.Text = "Buscar Tipo de Documento"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtSRC_TDOC_Descripcion
        '
        Me.txtSRC_TDOC_Descripcion.Location = New System.Drawing.Point(110, 53)
        Me.txtSRC_TDOC_Descripcion.Name = "txtSRC_TDOC_Descripcion"
        Me.txtSRC_TDOC_Descripcion.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_TDOC_Descripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Descripcion"
        '
        'ABM_TiposDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 281)
        Me.Controls.Add(Me.txtSRC_TDOC_KEY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtSRC_TDOC_Descripcion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_TiposDocumento"
        Me.Text = "ABM_TiposDocumento"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSRC_TDOC_KEY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtSRC_TDOC_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TDoc_KEY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDOC_DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
