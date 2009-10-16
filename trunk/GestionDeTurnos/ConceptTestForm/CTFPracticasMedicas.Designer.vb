<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTFPracticasMedicas
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
        Me.CMDBuscar = New System.Windows.Forms.Button
        Me.DGVPracticasmedicas = New System.Windows.Forms.DataGridView
        Me.TXTPM_Description = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BDS_PracticasMedicas = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGVPracticasmedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDS_PracticasMedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMDBuscar
        '
        Me.CMDBuscar.Location = New System.Drawing.Point(386, 49)
        Me.CMDBuscar.Name = "CMDBuscar"
        Me.CMDBuscar.Size = New System.Drawing.Size(149, 20)
        Me.CMDBuscar.TabIndex = 0
        Me.CMDBuscar.Text = "Buscar Practica Médica"
        Me.CMDBuscar.UseVisualStyleBackColor = True
        '
        'DGVPracticasmedicas
        '
        Me.DGVPracticasmedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPracticasmedicas.Location = New System.Drawing.Point(28, 102)
        Me.DGVPracticasmedicas.Name = "DGVPracticasmedicas"
        Me.DGVPracticasmedicas.Size = New System.Drawing.Size(507, 230)
        Me.DGVPracticasmedicas.TabIndex = 1
        '
        'TXTPM_Description
        '
        Me.TXTPM_Description.Location = New System.Drawing.Point(111, 49)
        Me.TXTPM_Description.Name = "TXTPM_Description"
        Me.TXTPM_Description.Size = New System.Drawing.Size(254, 20)
        Me.TXTPM_Description.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripción"
        '
        'CTFPracticasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 357)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTPM_Description)
        Me.Controls.Add(Me.DGVPracticasmedicas)
        Me.Controls.Add(Me.CMDBuscar)
        Me.Name = "CTFPracticasMedicas"
        Me.Text = "CTFPracticasMedicas"
        CType(Me.DGVPracticasmedicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDS_PracticasMedicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDBuscar As System.Windows.Forms.Button
    Friend WithEvents DGVPracticasmedicas As System.Windows.Forms.DataGridView
    Friend WithEvents TXTPM_Description As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BDS_PracticasMedicas As System.Windows.Forms.BindingSource
End Class
