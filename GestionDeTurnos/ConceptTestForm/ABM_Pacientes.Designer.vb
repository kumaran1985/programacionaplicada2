<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Pacientes
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
        Me.txtSRC_Pac_NumeroDoc = New System.Windows.Forms.TextBox
        Me.txtSRC_TDOC_Key = New System.Windows.Forms.TextBox
        Me.txtSRC_Pac_NumeroExt = New System.Windows.Forms.TextBox
        Me.txtSRC_Pac_Calle = New System.Windows.Forms.TextBox
        Me.txtSRC_Pac_Apellidos = New System.Windows.Forms.TextBox
        Me.txtSRC_Pac_Nombres = New System.Windows.Forms.TextBox
        Me.txtSRC_Pac_Key = New System.Windows.Forms.TextBox
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.Pac_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDOC_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_NumeroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Calle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_NumeroExt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_NumeroInt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LOCA_Key = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Celular = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_FechaCancelacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_EstadoCivil = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Ocupacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pac_Nacionalidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label
        Me.DTP_Pac_FechaAlta = New System.Windows.Forms.DateTimePicker
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Calle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Altura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Docuento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Número"
        '
        'txtSRC_Pac_NumeroDoc
        '
        Me.txtSRC_Pac_NumeroDoc.Location = New System.Drawing.Point(99, 200)
        Me.txtSRC_Pac_NumeroDoc.Name = "txtSRC_Pac_NumeroDoc"
        Me.txtSRC_Pac_NumeroDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_Pac_NumeroDoc.TabIndex = 17
        '
        'txtSRC_TDOC_Key
        '
        Me.txtSRC_TDOC_Key.Location = New System.Drawing.Point(98, 174)
        Me.txtSRC_TDOC_Key.Name = "txtSRC_TDOC_Key"
        Me.txtSRC_TDOC_Key.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_TDOC_Key.TabIndex = 16
        '
        'txtSRC_Pac_NumeroExt
        '
        Me.txtSRC_Pac_NumeroExt.Location = New System.Drawing.Point(98, 122)
        Me.txtSRC_Pac_NumeroExt.Name = "txtSRC_Pac_NumeroExt"
        Me.txtSRC_Pac_NumeroExt.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_Pac_NumeroExt.TabIndex = 15
        '
        'txtSRC_Pac_Calle
        '
        Me.txtSRC_Pac_Calle.Location = New System.Drawing.Point(98, 98)
        Me.txtSRC_Pac_Calle.Name = "txtSRC_Pac_Calle"
        Me.txtSRC_Pac_Calle.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_Pac_Calle.TabIndex = 14
        '
        'txtSRC_Pac_Apellidos
        '
        Me.txtSRC_Pac_Apellidos.Location = New System.Drawing.Point(98, 50)
        Me.txtSRC_Pac_Apellidos.Name = "txtSRC_Pac_Apellidos"
        Me.txtSRC_Pac_Apellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_Pac_Apellidos.TabIndex = 13
        '
        'txtSRC_Pac_Nombres
        '
        Me.txtSRC_Pac_Nombres.Location = New System.Drawing.Point(98, 27)
        Me.txtSRC_Pac_Nombres.Name = "txtSRC_Pac_Nombres"
        Me.txtSRC_Pac_Nombres.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_Pac_Nombres.TabIndex = 12
        '
        'txtSRC_Pac_Key
        '
        Me.txtSRC_Pac_Key.Location = New System.Drawing.Point(98, 5)
        Me.txtSRC_Pac_Key.Name = "txtSRC_Pac_Key"
        Me.txtSRC_Pac_Key.Size = New System.Drawing.Size(100, 20)
        Me.txtSRC_Pac_Key.TabIndex = 11
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pac_Key, Me.TDOC_Key, Me.Pac_NumeroDoc, Me.Pac_Nombres, Me.Pac_Apellidos, Me.Pac_Calle, Me.Pac_NumeroExt, Me.Pac_NumeroInt, Me.LOCA_Key, Me.Pac_Telefono, Me.Pac_Celular, Me.Pac_Email, Me.Pac_FechaNacimiento, Me.Pac_FechaAlta, Me.Pac_FechaCancelacion, Me.Pac_Sexo, Me.Pac_EstadoCivil, Me.Pac_Ocupacion, Me.Pac_Nacionalidad})
        Me.dgvBusqueda.Location = New System.Drawing.Point(214, 5)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(623, 272)
        Me.dgvBusqueda.TabIndex = 19
        '
        'Pac_Key
        '
        Me.Pac_Key.DataPropertyName = "Pac_Key"
        Me.Pac_Key.HeaderText = "ID de Paciente"
        Me.Pac_Key.Name = "Pac_Key"
        '
        'TDOC_Key
        '
        Me.TDOC_Key.DataPropertyName = "TDOC_Key"
        Me.TDOC_Key.HeaderText = "ID de Tipo de Documento"
        Me.TDOC_Key.Name = "TDOC_Key"
        '
        'Pac_NumeroDoc
        '
        Me.Pac_NumeroDoc.DataPropertyName = "Pac_NumeroDoc"
        Me.Pac_NumeroDoc.HeaderText = "Nº de Documento"
        Me.Pac_NumeroDoc.Name = "Pac_NumeroDoc"
        '
        'Pac_Nombres
        '
        Me.Pac_Nombres.DataPropertyName = "Pac_Nombres"
        Me.Pac_Nombres.HeaderText = "Nobres"
        Me.Pac_Nombres.Name = "Pac_Nombres"
        '
        'Pac_Apellidos
        '
        Me.Pac_Apellidos.DataPropertyName = "Pac_Apellidos"
        Me.Pac_Apellidos.HeaderText = "Apellidos"
        Me.Pac_Apellidos.Name = "Pac_Apellidos"
        '
        'Pac_Calle
        '
        Me.Pac_Calle.DataPropertyName = "Pac_Calle"
        Me.Pac_Calle.HeaderText = "Calle"
        Me.Pac_Calle.Name = "Pac_Calle"
        '
        'Pac_NumeroExt
        '
        Me.Pac_NumeroExt.DataPropertyName = "Pac_NumeroExt"
        Me.Pac_NumeroExt.HeaderText = "Numero"
        Me.Pac_NumeroExt.Name = "Pac_NumeroExt"
        '
        'Pac_NumeroInt
        '
        Me.Pac_NumeroInt.DataPropertyName = "Pac_NumeroInt"
        Me.Pac_NumeroInt.HeaderText = "Dpto."
        Me.Pac_NumeroInt.Name = "Pac_NumeroInt"
        '
        'LOCA_Key
        '
        Me.LOCA_Key.DataPropertyName = "LOCA_Key"
        Me.LOCA_Key.HeaderText = "ID de Localidad"
        Me.LOCA_Key.Name = "LOCA_Key"
        '
        'Pac_Telefono
        '
        Me.Pac_Telefono.DataPropertyName = "Pac_Telefono"
        Me.Pac_Telefono.HeaderText = "Telefono"
        Me.Pac_Telefono.Name = "Pac_Telefono"
        '
        'Pac_Celular
        '
        Me.Pac_Celular.DataPropertyName = "Pac_Celular"
        Me.Pac_Celular.HeaderText = "Celular"
        Me.Pac_Celular.Name = "Pac_Celular"
        '
        'Pac_Email
        '
        Me.Pac_Email.DataPropertyName = "Pac_Email"
        Me.Pac_Email.HeaderText = "e-mail"
        Me.Pac_Email.Name = "Pac_Email"
        '
        'Pac_FechaNacimiento
        '
        Me.Pac_FechaNacimiento.DataPropertyName = "Pac_FechaNacimiento"
        Me.Pac_FechaNacimiento.HeaderText = "Fecha de Nacimiento"
        Me.Pac_FechaNacimiento.Name = "Pac_FechaNacimiento"
        '
        'Pac_FechaAlta
        '
        Me.Pac_FechaAlta.DataPropertyName = "Pac_FechaAlta"
        Me.Pac_FechaAlta.HeaderText = "Fecha de Alta"
        Me.Pac_FechaAlta.Name = "Pac_FechaAlta"
        '
        'Pac_FechaCancelacion
        '
        Me.Pac_FechaCancelacion.DataPropertyName = "Pac_FechaCancelacion"
        Me.Pac_FechaCancelacion.HeaderText = "Fecha de Cancelación"
        Me.Pac_FechaCancelacion.Name = "Pac_FechaCancelacion"
        '
        'Pac_Sexo
        '
        Me.Pac_Sexo.DataPropertyName = "Pac_Sexo"
        Me.Pac_Sexo.HeaderText = "Sexo"
        Me.Pac_Sexo.Name = "Pac_Sexo"
        '
        'Pac_EstadoCivil
        '
        Me.Pac_EstadoCivil.DataPropertyName = "Pac_EstadoCivil"
        Me.Pac_EstadoCivil.HeaderText = "Estado Civil"
        Me.Pac_EstadoCivil.Name = "Pac_EstadoCivil"
        '
        'Pac_Ocupacion
        '
        Me.Pac_Ocupacion.DataPropertyName = "Pac_Ocupacion"
        Me.Pac_Ocupacion.HeaderText = "Ocupación"
        Me.Pac_Ocupacion.Name = "Pac_Ocupacion"
        '
        'Pac_Nacionalidad
        '
        Me.Pac_Nacionalidad.DataPropertyName = "Pac_Nacionalidad"
        Me.Pac_Nacionalidad.HeaderText = "Nacionalidad"
        Me.Pac_Nacionalidad.Name = "Pac_Nacionalidad"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(62, 280)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(136, 23)
        Me.cmdBuscar.TabIndex = 19
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fecha de Alta"
        '
        'DTP_Pac_FechaAlta
        '
        Me.DTP_Pac_FechaAlta.Checked = False
        Me.DTP_Pac_FechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Pac_FechaAlta.Location = New System.Drawing.Point(99, 233)
        Me.DTP_Pac_FechaAlta.Name = "DTP_Pac_FechaAlta"
        Me.DTP_Pac_FechaAlta.ShowCheckBox = True
        Me.DTP_Pac_FechaAlta.Size = New System.Drawing.Size(99, 20)
        Me.DTP_Pac_FechaAlta.TabIndex = 18
        '
        'ABM_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 315)
        Me.Controls.Add(Me.DTP_Pac_FechaAlta)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.txtSRC_Pac_Key)
        Me.Controls.Add(Me.txtSRC_Pac_Nombres)
        Me.Controls.Add(Me.txtSRC_Pac_Apellidos)
        Me.Controls.Add(Me.txtSRC_Pac_Calle)
        Me.Controls.Add(Me.txtSRC_Pac_NumeroExt)
        Me.Controls.Add(Me.txtSRC_TDOC_Key)
        Me.Controls.Add(Me.txtSRC_Pac_NumeroDoc)
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
        Me.Name = "ABM_Pacientes"
        Me.Text = "Listado Pacientes"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSRC_Pac_NumeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtSRC_TDOC_Key As System.Windows.Forms.TextBox
    Friend WithEvents txtSRC_Pac_NumeroExt As System.Windows.Forms.TextBox
    Friend WithEvents txtSRC_Pac_Calle As System.Windows.Forms.TextBox
    Friend WithEvents txtSRC_Pac_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtSRC_Pac_Nombres As System.Windows.Forms.TextBox
    Friend WithEvents txtSRC_Pac_Key As System.Windows.Forms.TextBox
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Pac_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDOC_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_NumeroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_NumeroExt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_NumeroInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCA_Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_FechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_FechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_FechaCancelacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_EstadoCivil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Ocupacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pac_Nacionalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTP_Pac_FechaAlta As System.Windows.Forms.DateTimePicker
End Class
