<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_HistoriaClinica
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
        Me.Btn_GUARDAR = New System.Windows.Forms.Button
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
        Me.MTB_FechaConsulta = New System.Windows.Forms.MaskedTextBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.TxBx_Diagnostico = New System.Windows.Forms.TextBox
        Me.TxBx_Medicacion = New System.Windows.Forms.TextBox
        Me.TxBx_Tratamiento = New System.Windows.Forms.TextBox
        Me.TxBx_DuracionTratamiento = New System.Windows.Forms.TextBox
        Me.TxBx_Observacion = New System.Windows.Forms.TextBox
        Me.TxBx_Descripcion = New System.Windows.Forms.TextBox
        Me.CmBx_Especialidad = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Cmb_NombresMedico = New System.Windows.Forms.ComboBox
        Me.Cmbx_Apellido = New System.Windows.Forms.ComboBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmb_NroPaciente = New System.Windows.Forms.ComboBox
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_GUARDAR
        '
        Me.Btn_GUARDAR.Location = New System.Drawing.Point(424, 554)
        Me.Btn_GUARDAR.Name = "Btn_GUARDAR"
        Me.Btn_GUARDAR.Size = New System.Drawing.Size(75, 47)
        Me.Btn_GUARDAR.TabIndex = 1
        Me.Btn_GUARDAR.Text = "GUARDAR"
        Me.Btn_GUARDAR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(49, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero de Paciente(*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(49, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Consulta(*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(49, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Especialidad(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(49, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombres de Medico(*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(411, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Apellido de Medico(*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(52, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Diagnóstico(*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(52, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Medicaión(*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(52, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Trataminento(*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(52, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Duración del Tratamiento(*)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 502)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Observación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 554)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Descripción"
        '
        'MTB_FechaConsulta
        '
        Me.MTB_FechaConsulta.Location = New System.Drawing.Point(187, 146)
        Me.MTB_FechaConsulta.Mask = "00/00/0000"
        Me.MTB_FechaConsulta.Name = "MTB_FechaConsulta"
        Me.MTB_FechaConsulta.Size = New System.Drawing.Size(100, 20)
        Me.MTB_FechaConsulta.TabIndex = 15
        Me.MTB_FechaConsulta.ValidatingType = GetType(Date)
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(545, 554)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 46)
        Me.Btn_Cancelar.TabIndex = 25
        Me.Btn_Cancelar.Text = "CANCELAR"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Location = New System.Drawing.Point(666, 554)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(75, 45)
        Me.Btn_Cerrar.TabIndex = 26
        Me.Btn_Cerrar.Text = "CERRAR"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'TxBx_Diagnostico
        '
        Me.TxBx_Diagnostico.Location = New System.Drawing.Point(187, 304)
        Me.TxBx_Diagnostico.Name = "TxBx_Diagnostico"
        Me.TxBx_Diagnostico.Size = New System.Drawing.Size(100, 20)
        Me.TxBx_Diagnostico.TabIndex = 30
        '
        'TxBx_Medicacion
        '
        Me.TxBx_Medicacion.Location = New System.Drawing.Point(187, 351)
        Me.TxBx_Medicacion.Name = "TxBx_Medicacion"
        Me.TxBx_Medicacion.Size = New System.Drawing.Size(100, 20)
        Me.TxBx_Medicacion.TabIndex = 31
        '
        'TxBx_Tratamiento
        '
        Me.TxBx_Tratamiento.Location = New System.Drawing.Point(187, 398)
        Me.TxBx_Tratamiento.Name = "TxBx_Tratamiento"
        Me.TxBx_Tratamiento.Size = New System.Drawing.Size(100, 20)
        Me.TxBx_Tratamiento.TabIndex = 32
        '
        'TxBx_DuracionTratamiento
        '
        Me.TxBx_DuracionTratamiento.Location = New System.Drawing.Point(187, 449)
        Me.TxBx_DuracionTratamiento.Name = "TxBx_DuracionTratamiento"
        Me.TxBx_DuracionTratamiento.Size = New System.Drawing.Size(100, 20)
        Me.TxBx_DuracionTratamiento.TabIndex = 33
        '
        'TxBx_Observacion
        '
        Me.TxBx_Observacion.Location = New System.Drawing.Point(187, 494)
        Me.TxBx_Observacion.Name = "TxBx_Observacion"
        Me.TxBx_Observacion.Size = New System.Drawing.Size(100, 20)
        Me.TxBx_Observacion.TabIndex = 34
        '
        'TxBx_Descripcion
        '
        Me.TxBx_Descripcion.Location = New System.Drawing.Point(187, 546)
        Me.TxBx_Descripcion.Name = "TxBx_Descripcion"
        Me.TxBx_Descripcion.Size = New System.Drawing.Size(100, 20)
        Me.TxBx_Descripcion.TabIndex = 35
        '
        'CmBx_Especialidad
        '
        Me.CmBx_Especialidad.FormattingEnabled = True
        Me.CmBx_Especialidad.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CmBx_Especialidad.Location = New System.Drawing.Point(187, 190)
        Me.CmBx_Especialidad.Name = "CmBx_Especialidad"
        Me.CmBx_Especialidad.Size = New System.Drawing.Size(121, 21)
        Me.CmBx_Especialidad.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(64, 669)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "(*)Campos Obligatorios "
        '
        'Cmb_NombresMedico
        '
        Me.Cmb_NombresMedico.FormattingEnabled = True
        Me.Cmb_NombresMedico.Location = New System.Drawing.Point(187, 254)
        Me.Cmb_NombresMedico.Name = "Cmb_NombresMedico"
        Me.Cmb_NombresMedico.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_NombresMedico.TabIndex = 38
        '
        'Cmbx_Apellido
        '
        Me.Cmbx_Apellido.FormattingEnabled = True
        Me.Cmbx_Apellido.Location = New System.Drawing.Point(545, 253)
        Me.Cmbx_Apellido.Name = "Cmbx_Apellido"
        Me.Cmbx_Apellido.Size = New System.Drawing.Size(121, 21)
        Me.Cmbx_Apellido.TabIndex = 39
        '
        'Cmb_NroPaciente
        '
        Me.Cmb_NroPaciente.FormattingEnabled = True
        Me.Cmb_NroPaciente.Location = New System.Drawing.Point(187, 100)
        Me.Cmb_NroPaciente.Name = "Cmb_NroPaciente"
        Me.Cmb_NroPaciente.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_NroPaciente.TabIndex = 40
        '
        'ALTA_HistoriaClinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 748)
        Me.Controls.Add(Me.Cmb_NroPaciente)
        Me.Controls.Add(Me.Cmbx_Apellido)
        Me.Controls.Add(Me.Cmb_NombresMedico)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CmBx_Especialidad)
        Me.Controls.Add(Me.TxBx_Descripcion)
        Me.Controls.Add(Me.TxBx_Observacion)
        Me.Controls.Add(Me.TxBx_DuracionTratamiento)
        Me.Controls.Add(Me.TxBx_Tratamiento)
        Me.Controls.Add(Me.TxBx_Medicacion)
        Me.Controls.Add(Me.TxBx_Diagnostico)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.MTB_FechaConsulta)
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
        Me.Controls.Add(Me.Btn_GUARDAR)
        Me.Name = "ALTA_HistoriaClinica"
        Me.Text = "ALTA HISTORIA CLINICA"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_GUARDAR As System.Windows.Forms.Button
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
    Friend WithEvents MTB_FechaConsulta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents TxBx_Diagnostico As System.Windows.Forms.TextBox
    Friend WithEvents TxBx_Medicacion As System.Windows.Forms.TextBox
    Friend WithEvents TxBx_Tratamiento As System.Windows.Forms.TextBox
    Friend WithEvents TxBx_DuracionTratamiento As System.Windows.Forms.TextBox
    Friend WithEvents TxBx_Observacion As System.Windows.Forms.TextBox
    Friend WithEvents TxBx_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents CmBx_Especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Cmb_NombresMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbx_Apellido As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_NroPaciente As System.Windows.Forms.ComboBox
End Class
