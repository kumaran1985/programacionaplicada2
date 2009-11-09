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
        Me.Med_NumeroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Med_Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Med_Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Med_Matricula1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Med_Apellidos = New System.Windows.Forms.TextBox
        Me.Apellido1 = New System.Windows.Forms.Label
        Me.btnbuscarapellido = New System.Windows.Forms.Button
        Me.Documento = New System.Windows.Forms.Label
        Me.txt_Med_NumeroDoc = New System.Windows.Forms.TextBox
        Me.btn_buscardoc = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
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
        Me.dgvMedicos.Location = New System.Drawing.Point(32, 104)
        Me.dgvMedicos.Name = "dgvMedicos"
        Me.dgvMedicos.Size = New System.Drawing.Size(444, 150)
        Me.dgvMedicos.TabIndex = 0
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
        'Documento
        '
        Me.Documento.AutoSize = True
        Me.Documento.Location = New System.Drawing.Point(29, 52)
        Me.Documento.Name = "Documento"
        Me.Documento.Size = New System.Drawing.Size(62, 13)
        Me.Documento.TabIndex = 4
        Me.Documento.Text = "Documento"
        '
        'txt_Med_NumeroDoc
        '
        Me.txt_Med_NumeroDoc.Location = New System.Drawing.Point(97, 52)
        Me.txt_Med_NumeroDoc.Name = "txt_Med_NumeroDoc"
        Me.txt_Med_NumeroDoc.Size = New System.Drawing.Size(100, 20)
        Me.txt_Med_NumeroDoc.TabIndex = 5
        '
        'btn_buscardoc
        '
        Me.btn_buscardoc.Location = New System.Drawing.Point(219, 52)
        Me.btn_buscardoc.Name = "btn_buscardoc"
        Me.btn_buscardoc.Size = New System.Drawing.Size(139, 23)
        Me.btn_buscardoc.TabIndex = 6
        Me.btn_buscardoc.Text = "Buscar por Documento"
        Me.btn_buscardoc.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(97, 281)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(246, 281)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 326)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscardoc)
        Me.Controls.Add(Me.txt_Med_NumeroDoc)
        Me.Controls.Add(Me.Documento)
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
    Friend WithEvents Documento As System.Windows.Forms.Label
    Friend WithEvents txt_Med_NumeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscardoc As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
