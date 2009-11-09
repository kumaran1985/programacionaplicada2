<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Turnos
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
        Me.turno_clave = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.turno_fecha = New System.Windows.Forms.DateTimePicker
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tboxidturno = New System.Windows.Forms.MaskedTextBox
        Me.lbidturno = New System.Windows.Forms.Label
        Me.tboxestado = New System.Windows.Forms.MaskedTextBox
        Me.lbfechaestado = New System.Windows.Forms.Label
        Me.tboxfechacancelacion = New System.Windows.Forms.MaskedTextBox
        Me.lbcancelacion = New System.Windows.Forms.Label
        Me.tboxidmedico = New System.Windows.Forms.MaskedTextBox
        Me.lbidmedico = New System.Windows.Forms.Label
        Me.tboxidpaciente = New System.Windows.Forms.MaskedTextBox
        Me.lbidpaciente = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'turno_clave
        '
        Me.turno_clave.Location = New System.Drawing.Point(131, 60)
        Me.turno_clave.Name = "turno_clave"
        Me.turno_clave.Size = New System.Drawing.Size(196, 20)
        Me.turno_clave.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Clave"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(340, 31)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(160, 49)
        Me.cmdBuscar.TabIndex = 8
        Me.cmdBuscar.Text = "Buscar fecha de turno"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "fecha"
        '
        'turno_fecha
        '
        Me.turno_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.turno_fecha.Location = New System.Drawing.Point(127, 34)
        Me.turno_fecha.Name = "turno_fecha"
        Me.turno_fecha.Size = New System.Drawing.Size(200, 20)
        Me.turno_fecha.TabIndex = 12
        '
        'tboxidturno
        '
        Me.tboxidturno.Location = New System.Drawing.Point(27, 128)
        Me.tboxidturno.Mask = "9999"
        Me.tboxidturno.Name = "tboxidturno"
        Me.tboxidturno.Size = New System.Drawing.Size(100, 20)
        Me.tboxidturno.TabIndex = 13
        '
        'lbidturno
        '
        Me.lbidturno.AutoSize = True
        Me.lbidturno.Location = New System.Drawing.Point(53, 112)
        Me.lbidturno.Name = "lbidturno"
        Me.lbidturno.Size = New System.Drawing.Size(43, 13)
        Me.lbidturno.TabIndex = 14
        Me.lbidturno.Text = "Id turno"
        '
        'tboxestado
        '
        Me.tboxestado.Location = New System.Drawing.Point(177, 128)
        Me.tboxestado.Mask = "00/00/0000"
        Me.tboxestado.Name = "tboxestado"
        Me.tboxestado.Size = New System.Drawing.Size(100, 20)
        Me.tboxestado.TabIndex = 15
        Me.tboxestado.ValidatingType = GetType(Date)
        '
        'lbfechaestado
        '
        Me.lbfechaestado.AutoSize = True
        Me.lbfechaestado.Location = New System.Drawing.Point(184, 112)
        Me.lbfechaestado.Name = "lbfechaestado"
        Me.lbfechaestado.Size = New System.Drawing.Size(78, 13)
        Me.lbfechaestado.TabIndex = 16
        Me.lbfechaestado.Text = "fecha e estado"
        '
        'tboxfechacancelacion
        '
        Me.tboxfechacancelacion.Location = New System.Drawing.Point(304, 128)
        Me.tboxfechacancelacion.Mask = "00/00/0000"
        Me.tboxfechacancelacion.Name = "tboxfechacancelacion"
        Me.tboxfechacancelacion.Size = New System.Drawing.Size(100, 20)
        Me.tboxfechacancelacion.TabIndex = 17
        Me.tboxfechacancelacion.ValidatingType = GetType(Date)
        '
        'lbcancelacion
        '
        Me.lbcancelacion.AutoSize = True
        Me.lbcancelacion.Location = New System.Drawing.Point(301, 112)
        Me.lbcancelacion.Name = "lbcancelacion"
        Me.lbcancelacion.Size = New System.Drawing.Size(110, 13)
        Me.lbcancelacion.TabIndex = 18
        Me.lbcancelacion.Text = "fecha de cancelacion"
        '
        'tboxidmedico
        '
        Me.tboxidmedico.Location = New System.Drawing.Point(445, 128)
        Me.tboxidmedico.Mask = "99999"
        Me.tboxidmedico.Name = "tboxidmedico"
        Me.tboxidmedico.Size = New System.Drawing.Size(100, 20)
        Me.tboxidmedico.TabIndex = 19
        Me.tboxidmedico.ValidatingType = GetType(Integer)
        '
        'lbidmedico
        '
        Me.lbidmedico.AutoSize = True
        Me.lbidmedico.Location = New System.Drawing.Point(445, 111)
        Me.lbidmedico.Name = "lbidmedico"
        Me.lbidmedico.Size = New System.Drawing.Size(67, 13)
        Me.lbidmedico.TabIndex = 20
        Me.lbidmedico.Text = "id de medico"
        '
        'tboxidpaciente
        '
        Me.tboxidpaciente.Location = New System.Drawing.Point(588, 128)
        Me.tboxidpaciente.Mask = "99999"
        Me.tboxidpaciente.Name = "tboxidpaciente"
        Me.tboxidpaciente.Size = New System.Drawing.Size(100, 20)
        Me.tboxidpaciente.TabIndex = 21
        Me.tboxidpaciente.ValidatingType = GetType(Integer)
        '
        'lbidpaciente
        '
        Me.lbidpaciente.AutoSize = True
        Me.lbidpaciente.Location = New System.Drawing.Point(596, 112)
        Me.lbidpaciente.Name = "lbidpaciente"
        Me.lbidpaciente.Size = New System.Drawing.Size(74, 13)
        Me.lbidpaciente.TabIndex = 22
        Me.lbidpaciente.Text = "id de paciente"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(127, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ABM_Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 266)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbidpaciente)
        Me.Controls.Add(Me.tboxidpaciente)
        Me.Controls.Add(Me.lbidmedico)
        Me.Controls.Add(Me.tboxidmedico)
        Me.Controls.Add(Me.lbcancelacion)
        Me.Controls.Add(Me.tboxfechacancelacion)
        Me.Controls.Add(Me.lbfechaestado)
        Me.Controls.Add(Me.tboxestado)
        Me.Controls.Add(Me.lbidturno)
        Me.Controls.Add(Me.tboxidturno)
        Me.Controls.Add(Me.turno_fecha)
        Me.Controls.Add(Me.turno_clave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Turnos"
        Me.Text = "ABM_Turnos"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents turno_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents turno_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tboxidturno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbidturno As System.Windows.Forms.Label
    Friend WithEvents tboxestado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbfechaestado As System.Windows.Forms.Label
    Friend WithEvents tboxfechacancelacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbcancelacion As System.Windows.Forms.Label
    Friend WithEvents tboxidmedico As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbidmedico As System.Windows.Forms.Label
    Friend WithEvents tboxidpaciente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbidpaciente As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
