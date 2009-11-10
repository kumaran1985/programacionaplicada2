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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medicos))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMedicos
        '
        Me.dgvMedicos.AutoGenerateColumns = False
        Me.dgvMedicos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Med_NumeroDoc, Me.Med_Nombres, Me.Med_Apellidos, Me.Med_Matricula1})
        Me.dgvMedicos.DataSource = Me.BindingSource1
        Me.dgvMedicos.GridColor = System.Drawing.SystemColors.Highlight
        Me.dgvMedicos.Location = New System.Drawing.Point(31, 385)
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
        Me.txt_Med_Apellidos.Location = New System.Drawing.Point(150, 37)
        Me.txt_Med_Apellidos.Name = "txt_Med_Apellidos"
        Me.txt_Med_Apellidos.Size = New System.Drawing.Size(271, 20)
        Me.txt_Med_Apellidos.TabIndex = 1
        '
        'Apellido1
        '
        Me.Apellido1.AutoSize = True
        Me.Apellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Apellido1.Location = New System.Drawing.Point(6, 37)
        Me.Apellido1.Name = "Apellido1"
        Me.Apellido1.Size = New System.Drawing.Size(66, 17)
        Me.Apellido1.TabIndex = 2
        Me.Apellido1.Text = "Apellido"
        '
        'btnbuscarapellido
        '
        Me.btnbuscarapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnbuscarapellido.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnbuscarapellido.Location = New System.Drawing.Point(6, 83)
        Me.btnbuscarapellido.Name = "btnbuscarapellido"
        Me.btnbuscarapellido.Size = New System.Drawing.Size(160, 60)
        Me.btnbuscarapellido.TabIndex = 3
        Me.btnbuscarapellido.Text = "Buscar Por Apellido"
        Me.btnbuscarapellido.UseVisualStyleBackColor = True
        '
        'Documento
        '
        Me.Documento.AutoSize = True
        Me.Documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Documento.Location = New System.Drawing.Point(15, 173)
        Me.Documento.Name = "Documento"
        Me.Documento.Size = New System.Drawing.Size(89, 17)
        Me.Documento.TabIndex = 4
        Me.Documento.Text = "Documento"
        '
        'txt_Med_NumeroDoc
        '
        Me.txt_Med_NumeroDoc.Location = New System.Drawing.Point(167, 184)
        Me.txt_Med_NumeroDoc.Name = "txt_Med_NumeroDoc"
        Me.txt_Med_NumeroDoc.Size = New System.Drawing.Size(271, 20)
        Me.txt_Med_NumeroDoc.TabIndex = 5
        '
        'btn_buscardoc
        '
        Me.btn_buscardoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_buscardoc.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_buscardoc.Location = New System.Drawing.Point(9, 227)
        Me.btn_buscardoc.Name = "btn_buscardoc"
        Me.btn_buscardoc.Size = New System.Drawing.Size(160, 60)
        Me.btn_buscardoc.TabIndex = 6
        Me.btn_buscardoc.Text = "Buscar por Documento"
        Me.btn_buscardoc.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cancelar.Location = New System.Drawing.Point(21, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(160, 60)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_salir.Location = New System.Drawing.Point(253, 43)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(160, 60)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.Apellido1)
        Me.GroupBox1.Controls.Add(Me.txt_Med_Apellidos)
        Me.GroupBox1.Controls.Add(Me.btnbuscarapellido)
        Me.GroupBox1.Controls.Add(Me.btn_buscardoc)
        Me.GroupBox1.Controls.Add(Me.Documento)
        Me.GroupBox1.Controls.Add(Me.txt_Med_NumeroDoc)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 329)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(501, 385)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 150)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label23.Location = New System.Drawing.Point(493, 158)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(318, 44)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Personal Médico"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.Location = New System.Drawing.Point(493, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(430, 44)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Sistemas de Búsqueda"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label22.Location = New System.Drawing.Point(493, 95)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 44)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "De"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label25.Location = New System.Drawing.Point(785, 237)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(142, 17)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = """Manuel Belgrano"""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(797, 214)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(117, 23)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Centro Médico"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(770, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 164)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(968, 665)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvMedicos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Medicos"
        Me.Text = "Medicos"
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
