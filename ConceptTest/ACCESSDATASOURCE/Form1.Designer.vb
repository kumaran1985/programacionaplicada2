<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim USR_IDLabel As System.Windows.Forms.Label
        Dim USR_NombreLabel As System.Windows.Forms.Label
        Dim USR_PassLabel As System.Windows.Forms.Label
        Dim USR_MustChangePassLabel As System.Windows.Forms.Label
        Dim USR_LastAcceessLabel As System.Windows.Forms.Label
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosDataSet = New ACCESSDATASOURCE.UsuariosDataSet
        Me.UsuariosTableAdapter = New ACCESSDATASOURCE.UsuariosDataSetTableAdapters.UsuariosTableAdapter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.USR_IDTextBox = New System.Windows.Forms.TextBox
        Me.USR_NombreTextBox = New System.Windows.Forms.TextBox
        Me.USR_PassTextBox = New System.Windows.Forms.TextBox
        Me.USR_MustChangePassCheckBox = New System.Windows.Forms.CheckBox
        Me.USR_LastAcceessDateTimePicker = New System.Windows.Forms.DateTimePicker
        USR_IDLabel = New System.Windows.Forms.Label
        USR_NombreLabel = New System.Windows.Forms.Label
        USR_PassLabel = New System.Windows.Forms.Label
        USR_MustChangePassLabel = New System.Windows.Forms.Label
        USR_LastAcceessLabel = New System.Windows.Forms.Label
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.UsuariosDataSet
        '
        'UsuariosDataSet
        '
        Me.UsuariosDataSet.DataSetName = "UsuariosDataSet"
        Me.UsuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'UsuariosBindingSource1
        '
        Me.UsuariosBindingSource1.DataMember = "Usuarios"
        Me.UsuariosBindingSource1.DataSource = Me.UsuariosDataSet
        '
        'USR_IDLabel
        '
        USR_IDLabel.AutoSize = True
        USR_IDLabel.Location = New System.Drawing.Point(220, 69)
        USR_IDLabel.Name = "USR_IDLabel"
        USR_IDLabel.Size = New System.Drawing.Size(21, 13)
        USR_IDLabel.TabIndex = 0
        USR_IDLabel.Text = "ID:"
        AddHandler USR_IDLabel.Click, AddressOf Me.USR_IDLabel_Click
        '
        'USR_IDTextBox
        '
        Me.USR_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "USR_ID", True))
        Me.USR_IDTextBox.Location = New System.Drawing.Point(351, 66)
        Me.USR_IDTextBox.Name = "USR_IDTextBox"
        Me.USR_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USR_IDTextBox.TabIndex = 1
        '
        'USR_NombreLabel
        '
        USR_NombreLabel.AutoSize = True
        USR_NombreLabel.Location = New System.Drawing.Point(220, 95)
        USR_NombreLabel.Name = "USR_NombreLabel"
        USR_NombreLabel.Size = New System.Drawing.Size(47, 13)
        USR_NombreLabel.TabIndex = 2
        USR_NombreLabel.Text = "Nombre:"
        AddHandler USR_NombreLabel.Click, AddressOf Me.USR_NombreLabel_Click
        '
        'USR_NombreTextBox
        '
        Me.USR_NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "USR_Nombre", True))
        Me.USR_NombreTextBox.Location = New System.Drawing.Point(351, 92)
        Me.USR_NombreTextBox.Name = "USR_NombreTextBox"
        Me.USR_NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USR_NombreTextBox.TabIndex = 3
        '
        'USR_PassLabel
        '
        USR_PassLabel.AutoSize = True
        USR_PassLabel.Location = New System.Drawing.Point(220, 121)
        USR_PassLabel.Name = "USR_PassLabel"
        USR_PassLabel.Size = New System.Drawing.Size(56, 13)
        USR_PassLabel.TabIndex = 4
        USR_PassLabel.Text = "Password:"
        AddHandler USR_PassLabel.Click, AddressOf Me.USR_PassLabel_Click
        '
        'USR_PassTextBox
        '
        Me.USR_PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "USR_Pass", True))
        Me.USR_PassTextBox.Location = New System.Drawing.Point(351, 118)
        Me.USR_PassTextBox.Name = "USR_PassTextBox"
        Me.USR_PassTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USR_PassTextBox.TabIndex = 5
        '
        'USR_MustChangePassLabel
        '
        USR_MustChangePassLabel.AutoSize = True
        USR_MustChangePassLabel.Location = New System.Drawing.Point(220, 149)
        USR_MustChangePassLabel.Name = "USR_MustChangePassLabel"
        USR_MustChangePassLabel.Size = New System.Drawing.Size(94, 13)
        USR_MustChangePassLabel.TabIndex = 6
        USR_MustChangePassLabel.Text = "Cambiar Password"
        AddHandler USR_MustChangePassLabel.Click, AddressOf Me.USR_MustChangePassLabel_Click
        '
        'USR_MustChangePassCheckBox
        '
        Me.USR_MustChangePassCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosBindingSource, "USR_MustChangePass", True))
        Me.USR_MustChangePassCheckBox.Location = New System.Drawing.Point(351, 144)
        Me.USR_MustChangePassCheckBox.Name = "USR_MustChangePassCheckBox"
        Me.USR_MustChangePassCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.USR_MustChangePassCheckBox.TabIndex = 7
        '
        'USR_LastAcceessLabel
        '
        USR_LastAcceessLabel.AutoSize = True
        USR_LastAcceessLabel.Location = New System.Drawing.Point(220, 178)
        USR_LastAcceessLabel.Name = "USR_LastAcceessLabel"
        USR_LastAcceessLabel.Size = New System.Drawing.Size(78, 13)
        USR_LastAcceessLabel.TabIndex = 8
        USR_LastAcceessLabel.Text = "Ultimo Acceso:"
        AddHandler USR_LastAcceessLabel.Click, AddressOf Me.USR_LastAcceessLabel_Click
        '
        'USR_LastAcceessDateTimePicker
        '
        Me.USR_LastAcceessDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "USR_LastAcceess", True))
        Me.USR_LastAcceessDateTimePicker.Location = New System.Drawing.Point(351, 174)
        Me.USR_LastAcceessDateTimePicker.Name = "USR_LastAcceessDateTimePicker"
        Me.USR_LastAcceessDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.USR_LastAcceessDateTimePicker.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 335)
        Me.Controls.Add(USR_IDLabel)
        Me.Controls.Add(Me.USR_IDTextBox)
        Me.Controls.Add(USR_NombreLabel)
        Me.Controls.Add(Me.USR_NombreTextBox)
        Me.Controls.Add(USR_PassLabel)
        Me.Controls.Add(Me.USR_PassTextBox)
        Me.Controls.Add(USR_MustChangePassLabel)
        Me.Controls.Add(Me.USR_MustChangePassCheckBox)
        Me.Controls.Add(USR_LastAcceessLabel)
        Me.Controls.Add(Me.USR_LastAcceessDateTimePicker)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuariosDataSet As ACCESSDATASOURCE.UsuariosDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ACCESSDATASOURCE.UsuariosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents USR_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USR_NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USR_PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USR_MustChangePassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents USR_LastAcceessDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
