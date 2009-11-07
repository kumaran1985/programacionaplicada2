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
        Me.Button1 = New System.Windows.Forms.Button
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView
        Me.PM_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btn_PM_Description = New System.Windows.Forms.Button
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Salir = New System.Windows.Forms.Button
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Listado Practicas Medicas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PM_Key, Me.PM_Descripcion, Me.PM_PrecioUnitario})
        Me.DgvBusqueda.Location = New System.Drawing.Point(52, 12)
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.Size = New System.Drawing.Size(356, 300)
        Me.DgvBusqueda.TabIndex = 8
        '
        'PM_Key
        '
        Me.PM_Key.DataPropertyName = "PM_Key"
        Me.PM_Key.HeaderText = "Id Practica Medica"
        Me.PM_Key.Name = "PM_Key"
        '
        'PM_Descripcion
        '
        Me.PM_Descripcion.DataPropertyName = "PM_Descripcion"
        Me.PM_Descripcion.HeaderText = "Descripcion"
        Me.PM_Descripcion.Name = "PM_Descripcion"
        '
        'PM_PrecioUnitario
        '
        Me.PM_PrecioUnitario.DataPropertyName = "PM_PrecioUnitario"
        Me.PM_PrecioUnitario.HeaderText = "Precio Practica Medica"
        Me.PM_PrecioUnitario.Name = "PM_PrecioUnitario"
        '
        'Btn_PM_Description
        '
        Me.Btn_PM_Description.Location = New System.Drawing.Point(458, 60)
        Me.Btn_PM_Description.Name = "Btn_PM_Description"
        Me.Btn_PM_Description.Size = New System.Drawing.Size(169, 33)
        Me.Btn_PM_Description.TabIndex = 9
        Me.Btn_PM_Description.Text = "Listar por Descripcion"
        Me.Btn_PM_Description.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(458, 277)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(169, 33)
        Me.Btn_Salir.TabIndex = 10
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'ABM_PracticasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 322)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_PM_Description)
        Me.Controls.Add(Me.DgvBusqueda)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ABM_PracticasMedicas"
        Me.Text = "ABM_PracticasMedicas"
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents PM_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_PM_Description As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
