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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSRC_SYS_ROLE_DESCRIPTION = New System.Windows.Forms.TextBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'txtSRC_SYS_ROLE_DESCRIPTION
        '
        Me.txtSRC_SYS_ROLE_DESCRIPTION.Location = New System.Drawing.Point(71, 19)
        Me.txtSRC_SYS_ROLE_DESCRIPTION.Name = "txtSRC_SYS_ROLE_DESCRIPTION"
        Me.txtSRC_SYS_ROLE_DESCRIPTION.Size = New System.Drawing.Size(196, 20)
        Me.txtSRC_SYS_ROLE_DESCRIPTION.TabIndex = 1
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(280, 16)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(160, 23)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar Rol por descripcion"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(12, 71)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(442, 150)
        Me.dgvBusqueda.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 269)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtSRC_SYS_ROLE_DESCRIPTION)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSRC_SYS_ROLE_DESCRIPTION As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource

End Class
