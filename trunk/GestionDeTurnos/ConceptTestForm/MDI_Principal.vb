Imports System.Windows.Forms

Public Class MDI_Principal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

     
    Private Sub ListadoToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem6.Click
        ABM_Consultorios.MdiParent = Me
        ABM_Consultorios.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem3.Click
        ABM_HistoriaClinica.MdiParent = Me
        ABM_HistoriaClinica.Show()
    End Sub

    Private Sub MotivoVisitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MotivoVisitaToolStripMenuItem.Click
        ABM_MotivoVisita.MdiParent = Me
        ABM_MotivoVisita.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem2.Click
        ABM_Pacientes.MdiParent = Me
        ABM_Pacientes.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem7.Click
        ABM_TiposDocumento.MdiParent = Me
        ABM_TiposDocumento.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem4.Click
        ABM_Turnos.MdiParent = Me
        ABM_Turnos.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem8.Click
        Especialidades.MdiParent = Me
        Especialidades.Show()
    End Sub

    Private Sub ListadoDeMédicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeMédicosToolStripMenuItem.Click
        Medicos.MdiParent = Me
        Medicos.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem9.Click
        PacientesxPlan.MdiParent = Me
        PacientesxPlan.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem.Click
        Planes.MdiParent = Me
        Planes.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem11.Click
        Form1.MdiParent = Me
        Form1.Show()


    End Sub

    Private Sub RolesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolesToolStripMenuItem2.Click

    End Sub

    Private Sub AltaToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem10.Click
        ALTA_SysRoles.MdiParent = Me
        ALTA_SysRoles.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem12.Click
        Form1.Show()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        ALTA_Pacientes.MdiParent = Me
        ALTA_Pacientes.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        Alta_Medicos.MdiParent = Me
        Alta_Medicos.Show()
    End Sub


    Private Sub ListadoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem1.Click
        ABM_PracticasMedicas.MdiParent = Me
        ABM_PracticasMedicas.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem13.Click
        ABM_PracticasMedicasxPlan.MdiParent = Me
        ABM_PracticasMedicasxPlan.Show()
    End Sub

    Private Sub AltaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem2.Click
        ALTA_PracticasMedicas.MdiParent = Me
        ALTA_PracticasMedicas.Show()
    End Sub

    Private Sub AltaToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem11.Click
        ALTA_PracticasMedicasxPlan.MdiParent = Me
        ALTA_PracticasMedicasxPlan.Show()
    End Sub

    Private Sub AltaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem3.Click
        ALTA_HistoriaClinica.Show()

    End Sub

    Private Sub AltaToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem6.Click
        ALTA_Consultorios.MdiParent = Me
        ALTA_Consultorios.Show()
    End Sub

    Private Sub AltaToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem7.Click
        ALTA_TiposDocumento.MdiParent = Me
        ALTA_TiposDocumento.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoToolStripMenuItem14.Click
        ABM_MotivoVisita.MdiParent = Me
        ABM_MotivoVisita.Show()
    End Sub

    Private Sub AltaToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem12.Click
        ALTA_MotivoVisita.MdiParent = Me
        ALTA_MotivoVisita.Show()
    End Sub
End Class
