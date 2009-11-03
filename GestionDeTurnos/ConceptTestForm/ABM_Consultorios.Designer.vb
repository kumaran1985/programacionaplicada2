<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Consultorios
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
        Me.txtSRC_CONS_UBICACION = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSRC_CONS_KEY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.Cons_KEY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cons_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONS_UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtSRC_CONS_Descripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSRC_CONS_UBICACION
        '
        Me.txtSRC_CONS_UBICACION.Location = New System.Drawing.Point(119, 82)
        Me.txtSRC_CONS_UBICACION.Name = "txtSRC_CONS_UBICACION"
        Me.txtSRC_CONS_UBICACION.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_CONS_UBICACION.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Ubicacion"
        '
        'txtSRC_CONS_KEY
        '
        Me.txtSRC_CONS_KEY.Location = New System.Drawing.Point(119, 27)
        Me.txtSRC_CONS_KEY.Name = "txtSRC_CONS_KEY"
        Me.txtSRC_CONS_KEY.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_CONS_KEY.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Clave"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cons_KEY, Me.Cons_DESCRIPCION, Me.CONS_UBICACION})
        Me.dgvBusqueda.Location = New System.Drawing.Point(53, 140)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(442, 151)
        Me.dgvBusqueda.TabIndex = 23
        '
        'Cons_KEY
        '
        Me.Cons_KEY.DataPropertyName = "Cons_KEY"
        Me.Cons_KEY.HeaderText = "ID Consultorio"
        Me.Cons_KEY.Name = "Cons_KEY"
        '
        'Cons_DESCRIPCION
        '
        Me.Cons_DESCRIPCION.DataPropertyName = "Cons_DESCRIPCION"
        Me.Cons_DESCRIPCION.HeaderText = "Descripcion"
        Me.Cons_DESCRIPCION.Name = "Cons_DESCRIPCION"
        '
        'CONS_UBICACION
        '
        Me.CONS_UBICACION.DataPropertyName = "CONS_UBICACION"
        Me.CONS_UBICACION.HeaderText = "Ubicacion"
        Me.CONS_UBICACION.Name = "CONS_UBICACION"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(335, 27)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(160, 76)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.Text = "Buscar Consultorios"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtSRC_CONS_Descripcion
        '
        Me.txtSRC_CONS_Descripcion.Location = New System.Drawing.Point(119, 56)
        Me.txtSRC_CONS_Descripcion.Name = "txtSRC_CONS_Descripcion"
        Me.txtSRC_CONS_Descripcion.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_CONS_Descripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Descripcion"
        '
        'ABM_Consultorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 320)
        Me.Controls.Add(Me.txtSRC_CONS_UBICACION)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSRC_CONS_KEY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtSRC_CONS_Descripcion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Consultorios"
        Me.Text = "ABM_Consultorios"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSRC_CONS_UBICACION As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSRC_CONS_KEY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtSRC_CONS_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Cons_KEY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cons_DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONS_UBICACION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
