<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuarios
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
        Me.Botonlistado = New System.Windows.Forms.Button
        Me.txtapellido = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvbusqueda = New System.Windows.Forms.DataGridView
        Me.User_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.User_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Botonlistado
        '
        Me.Botonlistado.Location = New System.Drawing.Point(396, 27)
        Me.Botonlistado.Name = "Botonlistado"
        Me.Botonlistado.Size = New System.Drawing.Size(132, 63)
        Me.Botonlistado.TabIndex = 0
        Me.Botonlistado.Text = "Actualizar Datos"
        Me.Botonlistado.UseVisualStyleBackColor = True
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(164, 30)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(207, 20)
        Me.txtapellido.TabIndex = 1
        Me.txtapellido.Text = "Ingrese apellido de busqueda"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(164, 70)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(207, 20)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.Text = "Ingrese Nombre de busqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'BindingSource1
        '
        '
        'dgvbusqueda
        '
        Me.dgvbusqueda.AutoGenerateColumns = False
        Me.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User_apellido, Me.User_nombre})
        Me.dgvbusqueda.DataSource = Me.BindingSource1
        Me.dgvbusqueda.Location = New System.Drawing.Point(26, 195)
        Me.dgvbusqueda.Name = "dgvbusqueda"
        Me.dgvbusqueda.Size = New System.Drawing.Size(501, 173)
        Me.dgvbusqueda.TabIndex = 5
        '
        'User_apellido
        '
        Me.User_apellido.DataPropertyName = "user_apellido"
        Me.User_apellido.HeaderText = "Apellido Usuario"
        Me.User_apellido.Name = "User_apellido"
        '
        'User_nombre
        '
        Me.User_nombre.DataPropertyName = "user_nombre"
        Me.User_nombre.HeaderText = "Nombre Usuario"
        Me.User_nombre.Name = "User_nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 57)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvbusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.Botonlistado)
        Me.Name = "ABMUsuarios"
        Me.Text = "Usuarios"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Botonlistado As System.Windows.Forms.Button
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvbusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents User_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
