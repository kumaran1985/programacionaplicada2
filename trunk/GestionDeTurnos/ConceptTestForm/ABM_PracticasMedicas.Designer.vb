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
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.txtPM_Descripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.PM_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PM_PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PracticasMedicasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base2006DataSet2 = New ConceptTestForm.Base2006DataSet2
        Me.PracticasMedicasTableAdapter = New ConceptTestForm.Base2006DataSet2TableAdapters.PracticasMedicasTableAdapter
        Me.mtbPM_Key = New System.Windows.Forms.MaskedTextBox
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PracticasMedicasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base2006DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(411, 24)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(175, 46)
        Me.cmdBuscar.TabIndex = 0
        Me.cmdBuscar.Text = "Buscar Practica Medica"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtPM_Descripcion
        '
        Me.txtPM_Descripcion.Location = New System.Drawing.Point(120, 50)
        Me.txtPM_Descripcion.Name = "txtPM_Descripcion"
        Me.txtPM_Descripcion.Size = New System.Drawing.Size(272, 20)
        Me.txtPM_Descripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Practica Medica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripcion"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PM_Key, Me.PM_Descripcion, Me.PM_PrecioUnitario})
        Me.dgvBusqueda.Location = New System.Drawing.Point(63, 114)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(343, 191)
        Me.dgvBusqueda.TabIndex = 8
        '
        'PM_Key
        '
        Me.PM_Key.DataPropertyName = "PM_Key"
        Me.PM_Key.HeaderText = "ID Practica Medica"
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
        'PracticasMedicasBindingSource
        '
        Me.PracticasMedicasBindingSource.DataMember = "PracticasMedicas"
        Me.PracticasMedicasBindingSource.DataSource = Me.Base2006DataSet2
        '
        'Base2006DataSet2
        '
        Me.Base2006DataSet2.DataSetName = "Base2006DataSet2"
        Me.Base2006DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PracticasMedicasTableAdapter
        '
        Me.PracticasMedicasTableAdapter.ClearBeforeFill = True
        '
        'mtbPM_Key
        '
        Me.mtbPM_Key.Location = New System.Drawing.Point(120, 24)
        Me.mtbPM_Key.Mask = "99"
        Me.mtbPM_Key.Name = "mtbPM_Key"
        Me.mtbPM_Key.Size = New System.Drawing.Size(49, 20)
        Me.mtbPM_Key.TabIndex = 9
        '
        'ABM_PracticasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 323)
        Me.Controls.Add(Me.mtbPM_Key)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPM_Descripcion)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Name = "ABM_PracticasMedicas"
        Me.Text = "ABM_PracticasMedicas"
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PracticasMedicasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base2006DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPM_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents PM_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM_PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Base2006DataSet2 As ConceptTestForm.Base2006DataSet2
    Friend WithEvents PracticasMedicasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PracticasMedicasTableAdapter As ConceptTestForm.Base2006DataSet2TableAdapters.PracticasMedicasTableAdapter
    Friend WithEvents mtbPM_Key As System.Windows.Forms.MaskedTextBox
End Class
