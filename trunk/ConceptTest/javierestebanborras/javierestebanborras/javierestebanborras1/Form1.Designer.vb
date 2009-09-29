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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim USR_IDLabel As System.Windows.Forms.Label
        Dim USR_NombreLabel As System.Windows.Forms.Label
        Dim USR_PassLabel As System.Windows.Forms.Label
        Dim USR_MustChangePassLabel As System.Windows.Forms.Label
        Dim USR_LastAcceessLabel As System.Windows.Forms.Label
        Me.UsuariosDataSet = New javierestebanborras.UsuariosDataSet
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New javierestebanborras.UsuariosDataSetTableAdapters.UsuariosTableAdapter
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
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
        CType(Me.UsuariosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsuariosDataSet
        '
        Me.UsuariosDataSet.DataSetName = "UsuariosDataSet"
        Me.UsuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.UsuariosDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsuariosBindingNavigatorSaveItem})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(527, 25)
        Me.UsuariosBindingNavigator.TabIndex = 0
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 13)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'UsuariosBindingNavigatorSaveItem
        '
        Me.UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuariosBindingNavigatorSaveItem.Name = "UsuariosBindingNavigatorSaveItem"
        Me.UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'USR_IDLabel
        '
        USR_IDLabel.AutoSize = True
        USR_IDLabel.Location = New System.Drawing.Point(82, 52)
        USR_IDLabel.Name = "USR_IDLabel"
        USR_IDLabel.Size = New System.Drawing.Size(47, 13)
        USR_IDLabel.TabIndex = 1
        USR_IDLabel.Text = "USR ID:"
        '
        'USR_IDTextBox
        '
        Me.USR_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "USR_ID", True))
        Me.USR_IDTextBox.Location = New System.Drawing.Point(223, 49)
        Me.USR_IDTextBox.Name = "USR_IDTextBox"
        Me.USR_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USR_IDTextBox.TabIndex = 2
        '
        'USR_NombreLabel
        '
        USR_NombreLabel.AutoSize = True
        USR_NombreLabel.Location = New System.Drawing.Point(82, 78)
        USR_NombreLabel.Name = "USR_NombreLabel"
        USR_NombreLabel.Size = New System.Drawing.Size(73, 13)
        USR_NombreLabel.TabIndex = 3
        USR_NombreLabel.Text = "USR Nombre:"
        '
        'USR_NombreTextBox
        '
        Me.USR_NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "USR_Nombre", True))
        Me.USR_NombreTextBox.Location = New System.Drawing.Point(223, 75)
        Me.USR_NombreTextBox.Name = "USR_NombreTextBox"
        Me.USR_NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USR_NombreTextBox.TabIndex = 4
        '
        'USR_PassLabel
        '
        USR_PassLabel.AutoSize = True
        USR_PassLabel.Location = New System.Drawing.Point(82, 104)
        USR_PassLabel.Name = "USR_PassLabel"
        USR_PassLabel.Size = New System.Drawing.Size(59, 13)
        USR_PassLabel.TabIndex = 5
        USR_PassLabel.Text = "USR Pass:"
        '
        'USR_PassTextBox
        '
        Me.USR_PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "USR_Pass", True))
        Me.USR_PassTextBox.Location = New System.Drawing.Point(223, 101)
        Me.USR_PassTextBox.Name = "USR_PassTextBox"
        Me.USR_PassTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USR_PassTextBox.TabIndex = 6
        '
        'USR_MustChangePassLabel
        '
        USR_MustChangePassLabel.AutoSize = True
        USR_MustChangePassLabel.Location = New System.Drawing.Point(82, 132)
        USR_MustChangePassLabel.Name = "USR_MustChangePassLabel"
        USR_MustChangePassLabel.Size = New System.Drawing.Size(125, 13)
        USR_MustChangePassLabel.TabIndex = 7
        USR_MustChangePassLabel.Text = "USR Must Change Pass:"
        '
        'USR_MustChangePassCheckBox
        '
        Me.USR_MustChangePassCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosBindingSource, "USR_MustChangePass", True))
        Me.USR_MustChangePassCheckBox.Location = New System.Drawing.Point(223, 127)
        Me.USR_MustChangePassCheckBox.Name = "USR_MustChangePassCheckBox"
        Me.USR_MustChangePassCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.USR_MustChangePassCheckBox.TabIndex = 8
        '
        'USR_LastAcceessLabel
        '
        USR_LastAcceessLabel.AutoSize = True
        USR_LastAcceessLabel.Location = New System.Drawing.Point(82, 161)
        USR_LastAcceessLabel.Name = "USR_LastAcceessLabel"
        USR_LastAcceessLabel.Size = New System.Drawing.Size(100, 13)
        USR_LastAcceessLabel.TabIndex = 9
        USR_LastAcceessLabel.Text = "USR Last Acceess:"
        '
        'USR_LastAcceessDateTimePicker
        '
        Me.USR_LastAcceessDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "USR_LastAcceess", True))
        Me.USR_LastAcceessDateTimePicker.Location = New System.Drawing.Point(223, 157)
        Me.USR_LastAcceessDateTimePicker.Name = "USR_LastAcceessDateTimePicker"
        Me.USR_LastAcceessDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.USR_LastAcceessDateTimePicker.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 273)
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
        Me.Controls.Add(Me.UsuariosBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UsuariosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuariosDataSet As javierestebanborras.UsuariosDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As javierestebanborras.UsuariosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents UsuariosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsuariosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents USR_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USR_NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USR_PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USR_MustChangePassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents USR_LastAcceessDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
