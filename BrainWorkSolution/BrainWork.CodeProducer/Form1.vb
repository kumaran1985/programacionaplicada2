Imports System.Threading

Public Class Form1
    Private trd As Thread
    Private isready As Boolean = False
    Private Sub ThreadTask()
        Dim c As New EntityCodeGenerator
        c.CnnString = Me.TXTQUERY.Text
        c.OUTPUTPAT = Me.TXTOUTPUT.Text
        c.FillTables()

        c.CreateEntityClass()
        c.CreateProcedures()
        c.CreateBLAndDAClass()

        Me.TXTPROCS.Text = c.GeneratedStored
        Me.TXTBUSSINES.Text = c.GeneratedBussines
        Me.TXTDATAACCESS.Text = c.GeneratedDataAccess
        Me.TXTENTITY.Text = c.GeneratedEntity
        isready = True
        MsgBox("LISTO")

        Me.pnlWaith.Visible = False
        Me.Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        

        Me.Timer1.Enabled = True
        Me.pnlWaith.Top = 0
        Me.pnlWaith.Left = 0
        Me.pnlWaith.Visible = True
        Me.Refresh()
        ThreadTask()
        'trd = New Thread(AddressOf ThreadTask)
        'trd.IsBackground = True
        'trd.Start()

       

       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        ElseIf ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If
        Me.Refresh()

    End Sub
End Class
