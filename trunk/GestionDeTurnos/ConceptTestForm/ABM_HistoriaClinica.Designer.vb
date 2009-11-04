<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_HistoriaClinica
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.deta_key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_ApellidosMedico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_FechaConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_Diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_Tratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_Medicacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_DuracionTratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deta_Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº de Historia Clinica"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(211, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.deta_key, Me.Deta_ApellidosMedico, Me.Column1, Me.Deta_FechaConsulta, Me.Deta_Diagnostico, Me.Deta_Tratamiento, Me.Deta_Medicacion, Me.Deta_DuracionTratamiento, Me.Deta_Observacion})
        Me.DataGridView1.Location = New System.Drawing.Point(62, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(944, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'deta_key
        '
        Me.deta_key.DataPropertyName = "deta_key"
        Me.deta_key.HeaderText = "Nº Hist. Clinica"
        Me.deta_key.Name = "deta_key"
        '
        'Deta_ApellidosMedico
        '
        Me.Deta_ApellidosMedico.DataPropertyName = "Deta_ApellidosMedico"
        Me.Deta_ApellidosMedico.HeaderText = "Apellido de Medico"
        Me.Deta_ApellidosMedico.Name = "Deta_ApellidosMedico"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "deta_nombresMedico"
        Me.Column1.HeaderText = "Nombre de Medico"
        Me.Column1.Name = "Column1"
        '
        'Deta_FechaConsulta
        '
        Me.Deta_FechaConsulta.DataPropertyName = "Deta_FechaConsulta"
        Me.Deta_FechaConsulta.HeaderText = "Fecha de Consulta"
        Me.Deta_FechaConsulta.Name = "Deta_FechaConsulta"
        '
        'Deta_Diagnostico
        '
        Me.Deta_Diagnostico.DataPropertyName = "Deta_Diagnostico"
        Me.Deta_Diagnostico.HeaderText = "Diagnostico"
        Me.Deta_Diagnostico.Name = "Deta_Diagnostico"
        '
        'Deta_Tratamiento
        '
        Me.Deta_Tratamiento.DataPropertyName = "Deta_Tratamiento"
        Me.Deta_Tratamiento.HeaderText = "Tratamiento"
        Me.Deta_Tratamiento.Name = "Deta_Tratamiento"
        '
        'Deta_Medicacion
        '
        Me.Deta_Medicacion.DataPropertyName = "Deta_Medicacion"
        Me.Deta_Medicacion.HeaderText = "Detalle de Medicacion"
        Me.Deta_Medicacion.Name = "Deta_Medicacion"
        '
        'Deta_DuracionTratamiento
        '
        Me.Deta_DuracionTratamiento.DataPropertyName = "Deta_DuracionTratamiento"
        Me.Deta_DuracionTratamiento.HeaderText = "Duracion de Tratamiento"
        Me.Deta_DuracionTratamiento.Name = "Deta_DuracionTratamiento"
        '
        'Deta_Observacion
        '
        Me.Deta_Observacion.DataPropertyName = "Deta_Observacion"
        Me.Deta_Observacion.HeaderText = "Observaciones"
        Me.Deta_Observacion.Name = "Deta_Observacion"
        '
        'ABM_HistoriaClinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 318)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ABM_HistoriaClinica"
        Me.Text = "ABM_HistoriaClinica"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents deta_key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_ApellidosMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_FechaConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_Diagnostico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_Tratamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_Medicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_DuracionTratamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deta_Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
