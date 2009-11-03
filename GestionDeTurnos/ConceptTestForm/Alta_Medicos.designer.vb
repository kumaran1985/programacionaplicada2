<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txt_Med_NumeroExt
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Med_Nombres = New System.Windows.Forms.TextBox
        Me.txt_Med_Apellidos = New System.Windows.Forms.TextBox
        Me.Apellidos = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_TDoc_key = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Med_NumeroDoc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Med_Calle = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Med_telefonos = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Med_Celular = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Med_Email = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_Med_NumeroInt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmb_Med_sexo = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.dt_Med_FechaNac = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_LOCA_key = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmb_Med_Especialidad = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmb_Med_Matricula = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_Med_Matricula1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.dt_Med_FechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.btn_guardar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'txt_Med_Nombres
        '
        Me.txt_Med_Nombres.AcceptsReturn = True
        Me.txt_Med_Nombres.AcceptsTab = True
        Me.txt_Med_Nombres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txt_Med_Nombres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txt_Med_Nombres.Location = New System.Drawing.Point(84, 12)
        Me.txt_Med_Nombres.Name = "txt_Med_Nombres"
        Me.txt_Med_Nombres.Size = New System.Drawing.Size(202, 20)
        Me.txt_Med_Nombres.TabIndex = 1
        '
        'txt_Med_Apellidos
        '
        Me.txt_Med_Apellidos.Location = New System.Drawing.Point(372, 12)
        Me.txt_Med_Apellidos.Name = "txt_Med_Apellidos"
        Me.txt_Med_Apellidos.Size = New System.Drawing.Size(204, 20)
        Me.txt_Med_Apellidos.TabIndex = 4
        '
        'Apellidos
        '
        Me.Apellidos.AutoSize = True
        Me.Apellidos.Location = New System.Drawing.Point(317, 18)
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Size = New System.Drawing.Size(49, 13)
        Me.Apellidos.TabIndex = 5
        Me.Apellidos.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Doc"
        '
        'cmb_TDoc_key
        '
        Me.cmb_TDoc_key.FormattingEnabled = True
        Me.cmb_TDoc_key.Items.AddRange(New Object() {"1-DNI", "2-LC", "3-LE", "4-CI"})
        Me.cmb_TDoc_key.Location = New System.Drawing.Point(84, 54)
        Me.cmb_TDoc_key.Name = "cmb_TDoc_key"
        Me.cmb_TDoc_key.Size = New System.Drawing.Size(79, 21)
        Me.cmb_TDoc_key.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Documento"
        '
        'txt_Med_NumeroDoc
        '
        Me.txt_Med_NumeroDoc.Location = New System.Drawing.Point(256, 55)
        Me.txt_Med_NumeroDoc.Name = "txt_Med_NumeroDoc"
        Me.txt_Med_NumeroDoc.Size = New System.Drawing.Size(110, 20)
        Me.txt_Med_NumeroDoc.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Calle"
        '
        'txt_Med_Calle
        '
        Me.txt_Med_Calle.Location = New System.Drawing.Point(84, 189)
        Me.txt_Med_Calle.Name = "txt_Med_Calle"
        Me.txt_Med_Calle.Size = New System.Drawing.Size(255, 20)
        Me.txt_Med_Calle.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Telefono"
        '
        'txt_Med_telefonos
        '
        Me.txt_Med_telefonos.Location = New System.Drawing.Point(84, 228)
        Me.txt_Med_telefonos.Name = "txt_Med_telefonos"
        Me.txt_Med_telefonos.Size = New System.Drawing.Size(132, 20)
        Me.txt_Med_telefonos.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Celular"
        '
        'txt_Med_Celular
        '
        Me.txt_Med_Celular.Location = New System.Drawing.Point(281, 231)
        Me.txt_Med_Celular.Name = "txt_Med_Celular"
        Me.txt_Med_Celular.Size = New System.Drawing.Size(139, 20)
        Me.txt_Med_Celular.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "E-Mail"
        '
        'txt_Med_Email
        '
        Me.txt_Med_Email.Location = New System.Drawing.Point(84, 264)
        Me.txt_Med_Email.Name = "txt_Med_Email"
        Me.txt_Med_Email.Size = New System.Drawing.Size(220, 20)
        Me.txt_Med_Email.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Número Externo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 298)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(227, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Numero Interno"
        '
        'txt_Med_NumeroInt
        '
        Me.txt_Med_NumeroInt.Location = New System.Drawing.Point(320, 298)
        Me.txt_Med_NumeroInt.Name = "txt_Med_NumeroInt"
        Me.txt_Med_NumeroInt.Size = New System.Drawing.Size(100, 20)
        Me.txt_Med_NumeroInt.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Sexo"
        '
        'cmb_Med_sexo
        '
        Me.cmb_Med_sexo.FormattingEnabled = True
        Me.cmb_Med_sexo.Items.AddRange(New Object() {"masculino", "femenino"})
        Me.cmb_Med_sexo.Location = New System.Drawing.Point(84, 123)
        Me.cmb_Med_sexo.Name = "cmb_Med_sexo"
        Me.cmb_Med_sexo.Size = New System.Drawing.Size(106, 21)
        Me.cmb_Med_sexo.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Estado Civil"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"soltero", "casado", "divorciado"})
        Me.ComboBox1.Location = New System.Drawing.Point(107, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'dt_Med_FechaNac
        '
        Me.dt_Med_FechaNac.Checked = False
        Me.dt_Med_FechaNac.Location = New System.Drawing.Point(136, 92)
        Me.dt_Med_FechaNac.Name = "dt_Med_FechaNac"
        Me.dt_Med_FechaNac.Size = New System.Drawing.Size(215, 20)
        Me.dt_Med_FechaNac.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Localidad"
        '
        'cmb_LOCA_key
        '
        Me.cmb_LOCA_key.FormattingEnabled = True
        Me.cmb_LOCA_key.Location = New System.Drawing.Point(421, 189)
        Me.cmb_LOCA_key.Name = "cmb_LOCA_key"
        Me.cmb_LOCA_key.Size = New System.Drawing.Size(121, 21)
        Me.cmb_LOCA_key.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Especialidad"
        '
        'cmb_Med_Especialidad
        '
        Me.cmb_Med_Especialidad.FormattingEnabled = True
        Me.cmb_Med_Especialidad.Location = New System.Drawing.Point(107, 342)
        Me.cmb_Med_Especialidad.Name = "cmb_Med_Especialidad"
        Me.cmb_Med_Especialidad.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Med_Especialidad.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Tipo de Matricula"
        '
        'cmb_Med_Matricula
        '
        Me.cmb_Med_Matricula.FormattingEnabled = True
        Me.cmb_Med_Matricula.Items.AddRange(New Object() {"nacional", "provincial"})
        Me.cmb_Med_Matricula.Location = New System.Drawing.Point(122, 370)
        Me.cmb_Med_Matricula.Name = "cmb_Med_Matricula"
        Me.cmb_Med_Matricula.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Med_Matricula.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(259, 378)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Nº Matricula"
        '
        'txt_Med_Matricula1
        '
        Me.txt_Med_Matricula1.Location = New System.Drawing.Point(330, 375)
        Me.txt_Med_Matricula1.Name = "txt_Med_Matricula1"
        Me.txt_Med_Matricula1.Size = New System.Drawing.Size(125, 20)
        Me.txt_Med_Matricula1.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 412)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Fecha Ingreso"
        '
        'dt_Med_FechaIngreso
        '
        Me.dt_Med_FechaIngreso.Checked = False
        Me.dt_Med_FechaIngreso.Location = New System.Drawing.Point(107, 405)
        Me.dt_Med_FechaIngreso.Name = "dt_Med_FechaIngreso"
        Me.dt_Med_FechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dt_Med_FechaIngreso.TabIndex = 38
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(115, 444)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 39
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(229, 444)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 40
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(340, 444)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 41
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'txt_Med_NumeroExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 479)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dt_Med_FechaIngreso)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_Med_Matricula1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmb_Med_Matricula)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmb_Med_Especialidad)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmb_LOCA_key)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt_Med_FechaNac)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmb_Med_sexo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_Med_NumeroInt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Med_Email)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_Med_Celular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Med_telefonos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Med_Calle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Med_NumeroDoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_TDoc_key)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Apellidos)
        Me.Controls.Add(Me.txt_Med_Apellidos)
        Me.Controls.Add(Me.txt_Med_Nombres)
        Me.Controls.Add(Me.Label2)
        Me.Name = "txt_Med_NumeroExt"
        Me.Text = "Alta_Medicos"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Nombres As System.Windows.Forms.TextBox
    Friend WithEvents txt_Med_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Apellidos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_TDoc_key As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_NumeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Calle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_telefonos As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Celular As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_NumeroInt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents dt_Med_FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_LOCA_key As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_Especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_Med_Matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Med_Matricula1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dt_Med_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
