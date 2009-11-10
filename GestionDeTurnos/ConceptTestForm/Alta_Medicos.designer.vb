<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Medicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_Medicos))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Med_Apellidos = New System.Windows.Forms.TextBox
        Me.Apellidos = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_TDoc_key = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Med_Calle = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Med_Email = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmb_Med_sexo = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_Med_EstadoCivil = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_LOCA_key = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmb_Med_Especialidad = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmb_Med_Matricula = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btn_guardar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.txt_Med_Nombres = New System.Windows.Forms.TextBox
        Me.txt_Med_NumeroDoc = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_FechaNac = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_NumeroExt = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_NumeroInt = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_telefono = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_celular = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_FechaIngreso = New System.Windows.Forms.MaskedTextBox
        Me.txt_Med_Matricula1 = New System.Windows.Forms.MaskedTextBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres (*)"
        '
        'txt_Med_Apellidos
        '
        Me.txt_Med_Apellidos.Location = New System.Drawing.Point(201, 52)
        Me.txt_Med_Apellidos.Name = "txt_Med_Apellidos"
        Me.txt_Med_Apellidos.Size = New System.Drawing.Size(255, 20)
        Me.txt_Med_Apellidos.TabIndex = 2
        '
        'Apellidos
        '
        Me.Apellidos.AutoSize = True
        Me.Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Apellidos.Location = New System.Drawing.Point(15, 55)
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Size = New System.Drawing.Size(97, 17)
        Me.Apellidos.TabIndex = 5
        Me.Apellidos.Text = "Apellidos (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Documento (*)"
        '
        'cmb_TDoc_key
        '
        Me.cmb_TDoc_key.FormattingEnabled = True
        Me.cmb_TDoc_key.Items.AddRange(New Object() {"DNI", "LC", "LE", "CI"})
        Me.cmb_TDoc_key.Location = New System.Drawing.Point(201, 88)
        Me.cmb_TDoc_key.Name = "cmb_TDoc_key"
        Me.cmb_TDoc_key.Size = New System.Drawing.Size(115, 21)
        Me.cmb_TDoc_key.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Documento (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha Nacimiento (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Calle"
        '
        'txt_Med_Calle
        '
        Me.txt_Med_Calle.Location = New System.Drawing.Point(201, 272)
        Me.txt_Med_Calle.Name = "txt_Med_Calle"
        Me.txt_Med_Calle.Size = New System.Drawing.Size(255, 20)
        Me.txt_Med_Calle.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Telefono (*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Celular (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "E-Mail"
        '
        'txt_Med_Email
        '
        Me.txt_Med_Email.Location = New System.Drawing.Point(166, 116)
        Me.txt_Med_Email.Name = "txt_Med_Email"
        Me.txt_Med_Email.Size = New System.Drawing.Size(291, 20)
        Me.txt_Med_Email.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Número Externo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Numero Interno"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Sexo"
        '
        'cmb_Med_sexo
        '
        Me.cmb_Med_sexo.FormattingEnabled = True
        Me.cmb_Med_sexo.Items.AddRange(New Object() {"masculino", "femenino"})
        Me.cmb_Med_sexo.Location = New System.Drawing.Point(201, 203)
        Me.cmb_Med_sexo.Name = "cmb_Med_sexo"
        Me.cmb_Med_sexo.Size = New System.Drawing.Size(115, 21)
        Me.cmb_Med_sexo.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Estado Civil"
        '
        'cmb_Med_EstadoCivil
        '
        Me.cmb_Med_EstadoCivil.FormattingEnabled = True
        Me.cmb_Med_EstadoCivil.Items.AddRange(New Object() {"soltero", "casado", "divorciado"})
        Me.cmb_Med_EstadoCivil.Location = New System.Drawing.Point(201, 237)
        Me.cmb_Med_EstadoCivil.Name = "cmb_Med_EstadoCivil"
        Me.cmb_Med_EstadoCivil.Size = New System.Drawing.Size(115, 21)
        Me.cmb_Med_EstadoCivil.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Localidad"
        '
        'cmb_LOCA_key
        '
        Me.cmb_LOCA_key.FormattingEnabled = True
        Me.cmb_LOCA_key.Location = New System.Drawing.Point(201, 310)
        Me.cmb_LOCA_key.Name = "cmb_LOCA_key"
        Me.cmb_LOCA_key.Size = New System.Drawing.Size(115, 21)
        Me.cmb_LOCA_key.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Especialidad (*)"
        '
        'cmb_Med_Especialidad
        '
        Me.cmb_Med_Especialidad.FormattingEnabled = True
        Me.cmb_Med_Especialidad.Items.AddRange(New Object() {"2", "2"})
        Me.cmb_Med_Especialidad.Location = New System.Drawing.Point(201, 35)
        Me.cmb_Med_Especialidad.Name = "cmb_Med_Especialidad"
        Me.cmb_Med_Especialidad.Size = New System.Drawing.Size(255, 21)
        Me.cmb_Med_Especialidad.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 17)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Tipo de Matricula (*)"
        '
        'cmb_Med_Matricula
        '
        Me.cmb_Med_Matricula.FormattingEnabled = True
        Me.cmb_Med_Matricula.Items.AddRange(New Object() {"nacional", "provincial"})
        Me.cmb_Med_Matricula.Location = New System.Drawing.Point(201, 93)
        Me.cmb_Med_Matricula.Name = "cmb_Med_Matricula"
        Me.cmb_Med_Matricula.Size = New System.Drawing.Size(115, 21)
        Me.cmb_Med_Matricula.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 17)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Nº Matricula (*)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 17)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Fecha Ingreso (*)"
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_guardar.Location = New System.Drawing.Point(22, 19)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(80, 60)
        Me.btn_guardar.TabIndex = 39
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cancelar.Location = New System.Drawing.Point(211, 17)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 60)
        Me.btn_cancelar.TabIndex = 40
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_salir.Location = New System.Drawing.Point(381, 19)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 60)
        Me.btn_salir.TabIndex = 41
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'txt_Med_Nombres
        '
        Me.txt_Med_Nombres.AcceptsReturn = True
        Me.txt_Med_Nombres.AcceptsTab = True
        Me.txt_Med_Nombres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txt_Med_Nombres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txt_Med_Nombres.Location = New System.Drawing.Point(201, 19)
        Me.txt_Med_Nombres.Name = "txt_Med_Nombres"
        Me.txt_Med_Nombres.Size = New System.Drawing.Size(255, 20)
        Me.txt_Med_Nombres.TabIndex = 1
        '
        'txt_Med_NumeroDoc
        '
        Me.txt_Med_NumeroDoc.Location = New System.Drawing.Point(201, 121)
        Me.txt_Med_NumeroDoc.Mask = "99999999"
        Me.txt_Med_NumeroDoc.Name = "txt_Med_NumeroDoc"
        Me.txt_Med_NumeroDoc.Size = New System.Drawing.Size(115, 20)
        Me.txt_Med_NumeroDoc.TabIndex = 4
        '
        'txt_Med_FechaNac
        '
        Me.txt_Med_FechaNac.Location = New System.Drawing.Point(201, 158)
        Me.txt_Med_FechaNac.Mask = "00/00/0000"
        Me.txt_Med_FechaNac.Name = "txt_Med_FechaNac"
        Me.txt_Med_FechaNac.Size = New System.Drawing.Size(115, 20)
        Me.txt_Med_FechaNac.TabIndex = 5
        Me.txt_Med_FechaNac.ValidatingType = GetType(Date)
        '
        'txt_Med_NumeroExt
        '
        Me.txt_Med_NumeroExt.Location = New System.Drawing.Point(168, 200)
        Me.txt_Med_NumeroExt.Mask = "99999"
        Me.txt_Med_NumeroExt.Name = "txt_Med_NumeroExt"
        Me.txt_Med_NumeroExt.Size = New System.Drawing.Size(161, 20)
        Me.txt_Med_NumeroExt.TabIndex = 13
        Me.txt_Med_NumeroExt.ValidatingType = GetType(Integer)
        '
        'txt_Med_NumeroInt
        '
        Me.txt_Med_NumeroInt.Location = New System.Drawing.Point(168, 242)
        Me.txt_Med_NumeroInt.Mask = "999"
        Me.txt_Med_NumeroInt.Name = "txt_Med_NumeroInt"
        Me.txt_Med_NumeroInt.Size = New System.Drawing.Size(161, 20)
        Me.txt_Med_NumeroInt.TabIndex = 14
        '
        'txt_Med_telefono
        '
        Me.txt_Med_telefono.Location = New System.Drawing.Point(166, 26)
        Me.txt_Med_telefono.Mask = "0000000"
        Me.txt_Med_telefono.Name = "txt_Med_telefono"
        Me.txt_Med_telefono.Size = New System.Drawing.Size(291, 20)
        Me.txt_Med_telefono.TabIndex = 10
        '
        'txt_Med_celular
        '
        Me.txt_Med_celular.Location = New System.Drawing.Point(166, 56)
        Me.txt_Med_celular.Mask = "000-000000000"
        Me.txt_Med_celular.Name = "txt_Med_celular"
        Me.txt_Med_celular.Size = New System.Drawing.Size(291, 20)
        Me.txt_Med_celular.TabIndex = 11
        '
        'txt_Med_FechaIngreso
        '
        Me.txt_Med_FechaIngreso.Location = New System.Drawing.Point(201, 215)
        Me.txt_Med_FechaIngreso.Mask = "00/00/0000"
        Me.txt_Med_FechaIngreso.Name = "txt_Med_FechaIngreso"
        Me.txt_Med_FechaIngreso.Size = New System.Drawing.Size(115, 20)
        Me.txt_Med_FechaIngreso.TabIndex = 18
        Me.txt_Med_FechaIngreso.ValidatingType = GetType(Date)
        '
        'txt_Med_Matricula1
        '
        Me.txt_Med_Matricula1.Location = New System.Drawing.Point(201, 155)
        Me.txt_Med_Matricula1.Mask = "99999"
        Me.txt_Med_Matricula1.Name = "txt_Med_Matricula1"
        Me.txt_Med_Matricula1.Size = New System.Drawing.Size(115, 20)
        Me.txt_Med_Matricula1.TabIndex = 17
        Me.txt_Med_Matricula1.ValidatingType = GetType(Integer)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_Med_Nombres)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Apellidos)
        Me.GroupBox1.Controls.Add(Me.txt_Med_Apellidos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_TDoc_key)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Med_FechaNac)
        Me.GroupBox1.Controls.Add(Me.txt_Med_NumeroDoc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmb_Med_sexo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmb_Med_EstadoCivil)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_Med_Calle)
        Me.GroupBox1.Controls.Add(Me.cmb_LOCA_key)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 370)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label18.Location = New System.Drawing.Point(204, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 9)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Día / Mes/ Año"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_Med_telefono)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_Med_celular)
        Me.GroupBox2.Controls.Add(Me.txt_Med_NumeroInt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_Med_NumeroExt)
        Me.GroupBox2.Controls.Add(Me.txt_Med_Email)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(511, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 270)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Referenciales"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmb_Med_Especialidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_Med_FechaIngreso)
        Me.GroupBox3.Controls.Add(Me.txt_Med_Matricula1)
        Me.GroupBox3.Controls.Add(Me.cmb_Med_Matricula)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 270)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Profesionales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.Location = New System.Drawing.Point(199, 243)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 9)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Día / Mes/ Año"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox4.Controls.Add(Me.btn_guardar)
        Me.GroupBox4.Controls.Add(Me.btn_cancelar)
        Me.GroupBox4.Controls.Add(Me.btn_salir)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(511, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(479, 90)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.Location = New System.Drawing.Point(513, 410)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(333, 44)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Sistemas de Alta "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(518, 635)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(328, 13)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Los campos marcados con (*) son de llenado obligatorio."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label22.Location = New System.Drawing.Point(513, 468)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 44)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "De"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label23.Location = New System.Drawing.Point(513, 530)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(318, 44)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Personal Médico"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(837, 410)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 164)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(864, 425)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(117, 23)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Centro Médico"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label25.Location = New System.Drawing.Point(852, 448)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(142, 17)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = """Manuel Belgrano"""
        '
        'Alta_Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1002, 667)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Alta_Medicos"
        Me.Text = " "
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Apellidos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_TDoc_key As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Calle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_EstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_LOCA_key As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_Especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_Matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents txt_Med_Nombres As System.Windows.Forms.TextBox
    Friend WithEvents txt_Med_NumeroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_FechaNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_NumeroExt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_NumeroInt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_FechaIngreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Med_Matricula1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
