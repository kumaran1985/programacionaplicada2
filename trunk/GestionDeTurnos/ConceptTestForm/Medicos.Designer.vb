<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicos
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
        Me.dgvMedicos = New System.Windows.Forms.DataGridView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Med_Apellidos = New System.Windows.Forms.TextBox
        Me.Apellido1 = New System.Windows.Forms.Label
        Me.btnbuscarapellido = New System.Windows.Forms.Button
        Me.Med_NumeroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Med_Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Med_Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Med_Matricula1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMedicos
        '
        Me.dgvMedicos.AutoGenerateColumns = False
        Me.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Med_NumeroDoc, Me.Med_Nombres, Me.Med_Apellidos, Me.Med_Matricula1})
        Me.dgvMedicos.DataSource = Me.BindingSource1
        Me.dgvMedicos.Location = New System.Drawing.Point(29, 62)
        Me.dgvMedicos.Name = "dgvMedicos"
        Me.dgvMedicos.Size = New System.Drawing.Size(444, 150)
        Me.dgvMedicos.TabIndex = 0
        '
        'txt_Med_Apellidos
        '
        Me.txt_Med_Apellidos.Location = New System.Drawing.Point(74, 10)
        Me.txt_Med_Apellidos.Name = "txt_Med_Apellidos"
        Me.txt_Med_Apellidos.Size = New System.Drawing.Size(271, 20)
        Me.txt_Med_Apellidos.TabIndex = 1
        '
        'Apellido1
        '
        Me.Apellido1.AutoSize = True
        Me.Apellido1.Location = New System.Drawing.Point(29, 13)
        Me.Apellido1.Name = "Apellido1"
        Me.Apellido1.Size = New System.Drawing.Size(44, 13)
        Me.Apellido1.TabIndex = 2
        Me.Apellido1.Text = "Apellido"
        '
        'btnbuscarapellido
        '
        Me.btnbuscarapellido.Location = New System.Drawing.Point(351, 7)
        Me.btnbuscarapellido.Name = "btnbuscarapellido"
        Me.btnbuscarapellido.Size = New System.Drawing.Size(122, 23)
        Me.btnbuscarapellido.TabIndex = 3
        Me.btnbuscarapellido.Text = "Buscar Por Apellido"
        Me.btnbuscarapellido.UseVisualStyleBackColor = True
        '
        'Med_NumeroDoc
        '
        Me.Med_NumeroDoc.DataPropertyName = "Med_NumeroDoc"
        Me.Med_NumeroDoc.HeaderText = "Documento"
        Me.Med_NumeroDoc.Name = "Med_NumeroDoc"
        '
        'Med_Nombres
        '
        Me.Med_Nombres.DataPropertyName = "Med_Nombres"
        Me.Med_Nombres.HeaderText = "Nombres"
        Me.Med_Nombres.Name = "Med_Nombres"
        '
        'Med_Apellidos
        '
        Me.Med_Apellidos.DataPropertyName = "Med_Apellidos"
        Me.Med_Apellidos.HeaderText = "Apellidos"
        Me.Med_Apellidos.Name = "Med_Apellidos"
        '
        'Med_Matricula1
        '
        Me.Med_Matricula1.DataPropertyName = "Med_Matricula1"
        Me.Med_Matricula1.HeaderText = "Matricula"
        Me.Med_Matricula1.Name = "Med_Matricula1"
        '
        'Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 266)
        Me.Controls.Add(Me.btnbuscarapellido)
        Me.Controls.Add(Me.Apellido1)
        Me.Controls.Add(Me.txt_Med_Apellidos)
        Me.Controls.Add(Me.dgvMedicos)
        Me.Name = "Medicos"
        Me.Text = "Medicos"
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMedicos As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txt_Med_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Apellido1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscarapellido As System.Windows.Forms.Button
    Friend WithEvents Med_NumeroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Med_Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Med_Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Med_Matricula1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
