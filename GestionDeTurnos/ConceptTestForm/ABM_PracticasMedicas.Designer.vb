<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_PracticasMedicas
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
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Txt_PM_Descripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView
        Me.PM_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource2
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(454, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar Practica Medica"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Txt_PM_Descripcion
        '
        Me.Txt_PM_Descripcion.Location = New System.Drawing.Point(120, 85)
        Me.Txt_PM_Descripcion.Name = "Txt_PM_Descripcion"
        Me.Txt_PM_Descripcion.Size = New System.Drawing.Size(272, 20)
        Me.Txt_PM_Descripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id Practica Medica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripcion"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio Unitario"
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PM_Key, Me.PM_Descripcion, Me.PM_PrecioUnitario})
        Me.DgvBusqueda.Location = New System.Drawing.Point(94, 156)
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.Size = New System.Drawing.Size(452, 150)
        Me.DgvBusqueda.TabIndex = 8
        '
        'PM_Key
        '
        Me.PM_Key.HeaderText = "Id Practica Medica"
        Me.PM_Key.Name = "PM_Key"
        '
        'PM_Descripcion
        '
        Me.PM_Descripcion.HeaderText = "Descripcion"
        Me.PM_Descripcion.Name = "PM_Descripcion"
        '
        'PM_PrecioUnitario
        '
        Me.PM_PrecioUnitario.HeaderText = "Precio Practica Medica"
        Me.PM_PrecioUnitario.Name = "PM_PrecioUnitario"
        '
        'ABM_PracticasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 318)
        Me.Controls.Add(Me.DgvBusqueda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_PM_Descripcion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ABM_PracticasMedicas"
        Me.Text = "ABM_PracticasMedicas"
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PM_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents PM_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
