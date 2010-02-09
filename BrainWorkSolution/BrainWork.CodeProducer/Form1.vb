Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As New EntityCodeGenerator
        c.CnnString = Me.TXTQUERY.Text
        c.OUTPUTPAT = Me.TXTOUTPUT.Text
        c.FillTables()

        c.CreateEntityClass()
        c.CreateProcedures()
        c.CreateBLAndDAClass()
        Me.TXTPROCS.Text = c.GeneratedStored
        MsgBox("LISTO")



    End Sub
End Class
