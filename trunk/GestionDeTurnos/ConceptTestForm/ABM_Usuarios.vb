
Public Class ABM_Usuarios




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim miEntity As New Entities.EntUsuarios
        miEntity.User_Nombre = Nombre1.Text


        miEntity.User_Apellido = Apellido1.Text


        Dim instanciaBL As New BLClassLibrary.BLUsuarios

        instanciaBL.InsertEntity(miEntity)


    End Sub
End Class