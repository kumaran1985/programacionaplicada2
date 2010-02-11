<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.TXTQUERY = New System.Windows.Forms.TextBox
        Me.TXTOUTPUT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TXTPROCS = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TXTENTITY = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TXTBUSSINES = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.TXTDATAACCESS = New System.Windows.Forms.TextBox
        Me.pnlWaith = New System.Windows.Forms.Panel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.pnlWaith.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(785, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "GENERAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXTQUERY
        '
        Me.TXTQUERY.Location = New System.Drawing.Point(27, 26)
        Me.TXTQUERY.Name = "TXTQUERY"
        Me.TXTQUERY.Size = New System.Drawing.Size(752, 20)
        Me.TXTQUERY.TabIndex = 1
        Me.TXTQUERY.Text = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWor" & _
            "ks;Data Source=localhost\sqlexpress"
        '
        'TXTOUTPUT
        '
        Me.TXTOUTPUT.Location = New System.Drawing.Point(27, 68)
        Me.TXTOUTPUT.Name = "TXTOUTPUT"
        Me.TXTOUTPUT.Size = New System.Drawing.Size(752, 20)
        Me.TXTOUTPUT.TabIndex = 3
        Me.TXTOUTPUT.Text = "c:\PruebaGenerador\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OUTPUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Connection String"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 94)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(881, 373)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TXTPROCS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(873, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stored Procedures"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TXTPROCS
        '
        Me.TXTPROCS.Location = New System.Drawing.Point(6, 6)
        Me.TXTPROCS.Multiline = True
        Me.TXTPROCS.Name = "TXTPROCS"
        Me.TXTPROCS.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTPROCS.Size = New System.Drawing.Size(861, 338)
        Me.TXTPROCS.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TXTENTITY)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(873, 347)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entitys"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TXTENTITY
        '
        Me.TXTENTITY.Location = New System.Drawing.Point(6, 4)
        Me.TXTENTITY.Multiline = True
        Me.TXTENTITY.Name = "TXTENTITY"
        Me.TXTENTITY.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTENTITY.Size = New System.Drawing.Size(861, 338)
        Me.TXTENTITY.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TXTBUSSINES)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(873, 347)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bussines Logic"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TXTBUSSINES
        '
        Me.TXTBUSSINES.Location = New System.Drawing.Point(6, 4)
        Me.TXTBUSSINES.Multiline = True
        Me.TXTBUSSINES.Name = "TXTBUSSINES"
        Me.TXTBUSSINES.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTBUSSINES.Size = New System.Drawing.Size(861, 338)
        Me.TXTBUSSINES.TabIndex = 5
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TXTDATAACCESS)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(873, 347)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Data Access"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TXTDATAACCESS
        '
        Me.TXTDATAACCESS.Location = New System.Drawing.Point(6, 4)
        Me.TXTDATAACCESS.Multiline = True
        Me.TXTDATAACCESS.Name = "TXTDATAACCESS"
        Me.TXTDATAACCESS.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTDATAACCESS.Size = New System.Drawing.Size(861, 338)
        Me.TXTDATAACCESS.TabIndex = 5
        '
        'pnlWaith
        '
        Me.pnlWaith.Controls.Add(Me.ProgressBar1)
        Me.pnlWaith.Controls.Add(Me.Label3)
        Me.pnlWaith.Location = New System.Drawing.Point(5, 469)
        Me.pnlWaith.Name = "pnlWaith"
        Me.pnlWaith.Size = New System.Drawing.Size(900, 554)
        Me.pnlWaith.TabIndex = 7
        Me.pnlWaith.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(80, 96)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(715, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pere un cacho..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 481)
        Me.Controls.Add(Me.pnlWaith)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTOUTPUT)
        Me.Controls.Add(Me.TXTQUERY)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Code Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.pnlWaith.ResumeLayout(False)
        Me.pnlWaith.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TXTQUERY As System.Windows.Forms.TextBox
    Friend WithEvents TXTOUTPUT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TXTPROCS As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TXTENTITY As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TXTBUSSINES As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TXTDATAACCESS As System.Windows.Forms.TextBox
    Friend WithEvents pnlWaith As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
