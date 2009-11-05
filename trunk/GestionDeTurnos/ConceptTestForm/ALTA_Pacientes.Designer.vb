<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_Pacientes
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TB_Pac_Nombres = New System.Windows.Forms.TextBox
        Me.TB_Pac_Apellidos = New System.Windows.Forms.TextBox
        Me.TB_Pac_Calle = New System.Windows.Forms.TextBox
        Me.MTB_Pac_NumeroExt = New System.Windows.Forms.MaskedTextBox
        Me.TB_Pac_NumeroInt = New System.Windows.Forms.TextBox
        Me.MTB_Pac_Telefono = New System.Windows.Forms.MaskedTextBox
        Me.MTB_Pac_Celular = New System.Windows.Forms.MaskedTextBox
        Me.TB_Pac_Email = New System.Windows.Forms.TextBox
        Me.CB_Pac_Sexo = New System.Windows.Forms.ComboBox
        Me.CB_Pac_EstadoCivil = New System.Windows.Forms.ComboBox
        Me.TB_Pac_Ocupacion = New System.Windows.Forms.TextBox
        Me.TB_Pac_Nacionalidad = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CB_TDOC_Key = New System.Windows.Forms.ComboBox
        Me.TiposDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base2006DataSet = New ConceptTestForm.Base2006DataSet
        Me.Label19 = New System.Windows.Forms.Label
        Me.TB_Pac_NumeroDoc = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TiposDocumentoTableAdapter = New ConceptTestForm.Base2006DataSetTableAdapters.TiposDocumentoTableAdapter
        Me.CB_LOCA_Key = New System.Windows.Forms.ComboBox
        Me.Base2006DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base2006DataSet1 = New ConceptTestForm.Base2006DataSet1
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesTableAdapter = New ConceptTestForm.Base2006DataSet1TableAdapters.LocalidadesTableAdapter
        Me.MTB_Pac_FechaNacimiento = New System.Windows.Forms.MaskedTextBox
        Me.MTB_Pac_FechaAlta = New System.Windows.Forms.MaskedTextBox
        Me.MTB_Pac_FechaCancelacion = New System.Windows.Forms.MaskedTextBox
        CType(Me.TiposDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base2006DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base2006DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base2006DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres(*):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(220, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos(*):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(32, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Calle(*):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(204, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Número(*):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dpto.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(422, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID Localidad(*):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Celular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(381, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "E-mail:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha de Nacimiento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Fecha de Alta:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Fecha de Cancelación:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(18, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Sexo(*):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(176, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Estado Civil:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(362, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Ocupación:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 240)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Nacionalidad:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_Pac_Nombres
        '
        Me.TB_Pac_Nombres.Location = New System.Drawing.Point(71, 6)
        Me.TB_Pac_Nombres.Name = "TB_Pac_Nombres"
        Me.TB_Pac_Nombres.Size = New System.Drawing.Size(143, 20)
        Me.TB_Pac_Nombres.TabIndex = 18
        '
        'TB_Pac_Apellidos
        '
        Me.TB_Pac_Apellidos.Location = New System.Drawing.Point(283, 6)
        Me.TB_Pac_Apellidos.Name = "TB_Pac_Apellidos"
        Me.TB_Pac_Apellidos.Size = New System.Drawing.Size(191, 20)
        Me.TB_Pac_Apellidos.TabIndex = 19
        '
        'TB_Pac_Calle
        '
        Me.TB_Pac_Calle.Location = New System.Drawing.Point(81, 78)
        Me.TB_Pac_Calle.Name = "TB_Pac_Calle"
        Me.TB_Pac_Calle.Size = New System.Drawing.Size(117, 20)
        Me.TB_Pac_Calle.TabIndex = 20
        '
        'MTB_Pac_NumeroExt
        '
        Me.MTB_Pac_NumeroExt.Location = New System.Drawing.Point(257, 78)
        Me.MTB_Pac_NumeroExt.Mask = "99999"
        Me.MTB_Pac_NumeroExt.Name = "MTB_Pac_NumeroExt"
        Me.MTB_Pac_NumeroExt.Size = New System.Drawing.Size(46, 20)
        Me.MTB_Pac_NumeroExt.TabIndex = 21
        Me.MTB_Pac_NumeroExt.ValidatingType = GetType(Integer)
        '
        'TB_Pac_NumeroInt
        '
        Me.TB_Pac_NumeroInt.Location = New System.Drawing.Point(358, 77)
        Me.TB_Pac_NumeroInt.Name = "TB_Pac_NumeroInt"
        Me.TB_Pac_NumeroInt.Size = New System.Drawing.Size(55, 20)
        Me.TB_Pac_NumeroInt.TabIndex = 22
        '
        'MTB_Pac_Telefono
        '
        Me.MTB_Pac_Telefono.Location = New System.Drawing.Point(68, 104)
        Me.MTB_Pac_Telefono.Mask = "00000000000"
        Me.MTB_Pac_Telefono.Name = "MTB_Pac_Telefono"
        Me.MTB_Pac_Telefono.Size = New System.Drawing.Size(75, 20)
        Me.MTB_Pac_Telefono.TabIndex = 24
        '
        'MTB_Pac_Celular
        '
        Me.MTB_Pac_Celular.Location = New System.Drawing.Point(228, 103)
        Me.MTB_Pac_Celular.Mask = "0000000000"
        Me.MTB_Pac_Celular.Name = "MTB_Pac_Celular"
        Me.MTB_Pac_Celular.Size = New System.Drawing.Size(75, 20)
        Me.MTB_Pac_Celular.TabIndex = 25
        '
        'TB_Pac_Email
        '
        Me.TB_Pac_Email.Location = New System.Drawing.Point(425, 103)
        Me.TB_Pac_Email.Name = "TB_Pac_Email"
        Me.TB_Pac_Email.Size = New System.Drawing.Size(117, 20)
        Me.TB_Pac_Email.TabIndex = 26
        '
        'CB_Pac_Sexo
        '
        Me.CB_Pac_Sexo.FormattingEnabled = True
        Me.CB_Pac_Sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CB_Pac_Sexo.Location = New System.Drawing.Point(68, 207)
        Me.CB_Pac_Sexo.Name = "CB_Pac_Sexo"
        Me.CB_Pac_Sexo.Size = New System.Drawing.Size(101, 21)
        Me.CB_Pac_Sexo.TabIndex = 30
        '
        'CB_Pac_EstadoCivil
        '
        Me.CB_Pac_EstadoCivil.FormattingEnabled = True
        Me.CB_Pac_EstadoCivil.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Divorsiado/a", "Viudo/a"})
        Me.CB_Pac_EstadoCivil.Location = New System.Drawing.Point(247, 207)
        Me.CB_Pac_EstadoCivil.Name = "CB_Pac_EstadoCivil"
        Me.CB_Pac_EstadoCivil.Size = New System.Drawing.Size(109, 21)
        Me.CB_Pac_EstadoCivil.TabIndex = 31
        '
        'TB_Pac_Ocupacion
        '
        Me.TB_Pac_Ocupacion.Location = New System.Drawing.Point(435, 204)
        Me.TB_Pac_Ocupacion.Name = "TB_Pac_Ocupacion"
        Me.TB_Pac_Ocupacion.Size = New System.Drawing.Size(101, 20)
        Me.TB_Pac_Ocupacion.TabIndex = 32
        '
        'TB_Pac_Nacionalidad
        '
        Me.TB_Pac_Nacionalidad.Location = New System.Drawing.Point(100, 232)
        Me.TB_Pac_Nacionalidad.Name = "TB_Pac_Nacionalidad"
        Me.TB_Pac_Nacionalidad.Size = New System.Drawing.Size(100, 20)
        Me.TB_Pac_Nacionalidad.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(16, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "ID Tipo de Documento(*):"
        '
        'CB_TDOC_Key
        '
        Me.CB_TDOC_Key.DataSource = Me.TiposDocumentoBindingSource
        Me.CB_TDOC_Key.DisplayMember = "TDOC_Key"
        Me.CB_TDOC_Key.FormattingEnabled = True
        Me.CB_TDOC_Key.Location = New System.Drawing.Point(150, 32)
        Me.CB_TDOC_Key.Name = "CB_TDOC_Key"
        Me.CB_TDOC_Key.Size = New System.Drawing.Size(121, 21)
        Me.CB_TDOC_Key.TabIndex = 35
        Me.CB_TDOC_Key.ValueMember = "TDOC_Key"
        '
        'TiposDocumentoBindingSource
        '
        Me.TiposDocumentoBindingSource.DataMember = "TiposDocumento"
        Me.TiposDocumentoBindingSource.DataSource = Me.Base2006DataSet
        '
        'Base2006DataSet
        '
        Me.Base2006DataSet.DataSetName = "Base2006DataSet"
        Me.Base2006DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(280, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Nº de Documento(*):"
        '
        'TB_Pac_NumeroDoc
        '
        Me.TB_Pac_NumeroDoc.Location = New System.Drawing.Point(385, 31)
        Me.TB_Pac_NumeroDoc.Name = "TB_Pac_NumeroDoc"
        Me.TB_Pac_NumeroDoc.Size = New System.Drawing.Size(100, 20)
        Me.TB_Pac_NumeroDoc.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(21, 263)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(271, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "(*) Valores que deben ser completados Obligatoriamente"
        '
        'TiposDocumentoTableAdapter
        '
        Me.TiposDocumentoTableAdapter.ClearBeforeFill = True
        '
        'CB_LOCA_Key
        '
        Me.CB_LOCA_Key.DataSource = Me.LocalidadesBindingSource
        Me.CB_LOCA_Key.DisplayMember = "LOCA_Key"
        Me.CB_LOCA_Key.FormattingEnabled = True
        Me.CB_LOCA_Key.Location = New System.Drawing.Point(509, 76)
        Me.CB_LOCA_Key.Name = "CB_LOCA_Key"
        Me.CB_LOCA_Key.Size = New System.Drawing.Size(65, 21)
        Me.CB_LOCA_Key.TabIndex = 39
        '
        'Base2006DataSetBindingSource
        '
        Me.Base2006DataSetBindingSource.DataSource = Me.Base2006DataSet
        Me.Base2006DataSetBindingSource.Position = 0
        '
        'Base2006DataSet1
        '
        Me.Base2006DataSet1.DataSetName = "Base2006DataSet1"
        Me.Base2006DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.Base2006DataSet1
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'MTB_Pac_FechaNacimiento
        '
        Me.MTB_Pac_FechaNacimiento.Culture = New System.Globalization.CultureInfo("es-AR")
        Me.MTB_Pac_FechaNacimiento.Location = New System.Drawing.Point(131, 129)
        Me.MTB_Pac_FechaNacimiento.Mask = "00/00/0000"
        Me.MTB_Pac_FechaNacimiento.Name = "MTB_Pac_FechaNacimiento"
        Me.MTB_Pac_FechaNacimiento.Size = New System.Drawing.Size(67, 20)
        Me.MTB_Pac_FechaNacimiento.TabIndex = 43
        '
        'MTB_Pac_FechaAlta
        '
        Me.MTB_Pac_FechaAlta.Location = New System.Drawing.Point(95, 152)
        Me.MTB_Pac_FechaAlta.Mask = "00/00/0000"
        Me.MTB_Pac_FechaAlta.Name = "MTB_Pac_FechaAlta"
        Me.MTB_Pac_FechaAlta.Size = New System.Drawing.Size(62, 20)
        Me.MTB_Pac_FechaAlta.TabIndex = 44
        '
        'MTB_Pac_FechaCancelacion
        '
        Me.MTB_Pac_FechaCancelacion.Location = New System.Drawing.Point(131, 172)
        Me.MTB_Pac_FechaCancelacion.Mask = "00/00/0000"
        Me.MTB_Pac_FechaCancelacion.Name = "MTB_Pac_FechaCancelacion"
        Me.MTB_Pac_FechaCancelacion.Size = New System.Drawing.Size(69, 20)
        Me.MTB_Pac_FechaCancelacion.TabIndex = 45
        Me.MTB_Pac_FechaCancelacion.ValidatingType = GetType(Date)
        '
        'ALTA_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 317)
        Me.Controls.Add(Me.MTB_Pac_FechaCancelacion)
        Me.Controls.Add(Me.MTB_Pac_FechaAlta)
        Me.Controls.Add(Me.MTB_Pac_FechaNacimiento)
        Me.Controls.Add(Me.CB_LOCA_Key)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TB_Pac_NumeroDoc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.CB_TDOC_Key)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TB_Pac_Nacionalidad)
        Me.Controls.Add(Me.TB_Pac_Ocupacion)
        Me.Controls.Add(Me.CB_Pac_EstadoCivil)
        Me.Controls.Add(Me.CB_Pac_Sexo)
        Me.Controls.Add(Me.TB_Pac_Email)
        Me.Controls.Add(Me.MTB_Pac_Celular)
        Me.Controls.Add(Me.MTB_Pac_Telefono)
        Me.Controls.Add(Me.TB_Pac_NumeroInt)
        Me.Controls.Add(Me.MTB_Pac_NumeroExt)
        Me.Controls.Add(Me.TB_Pac_Calle)
        Me.Controls.Add(Me.TB_Pac_Apellidos)
        Me.Controls.Add(Me.TB_Pac_Nombres)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ALTA_Pacientes"
        Me.Text = "Alta Pacientes"
        CType(Me.TiposDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base2006DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base2006DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base2006DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB_Pac_Nombres As System.Windows.Forms.TextBox
    Friend WithEvents TB_Pac_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents TB_Pac_Calle As System.Windows.Forms.TextBox
    Friend WithEvents MTB_Pac_NumeroExt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TB_Pac_NumeroInt As System.Windows.Forms.TextBox
    Friend WithEvents MTB_Pac_Telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MTB_Pac_Celular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TB_Pac_Email As System.Windows.Forms.TextBox
    Friend WithEvents CB_Pac_Sexo As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Pac_EstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Pac_Ocupacion As System.Windows.Forms.TextBox
    Friend WithEvents TB_Pac_Nacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CB_TDOC_Key As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TB_Pac_NumeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Base2006DataSet As ConceptTestForm.Base2006DataSet
    Friend WithEvents TiposDocumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposDocumentoTableAdapter As ConceptTestForm.Base2006DataSetTableAdapters.TiposDocumentoTableAdapter
    Friend WithEvents CB_LOCA_Key As System.Windows.Forms.ComboBox
    Friend WithEvents Base2006DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Base2006DataSet1 As ConceptTestForm.Base2006DataSet1
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadesTableAdapter As ConceptTestForm.Base2006DataSet1TableAdapters.LocalidadesTableAdapter
    Friend WithEvents MTB_Pac_FechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MTB_Pac_FechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MTB_Pac_FechaCancelacion As System.Windows.Forms.MaskedTextBox
End Class
