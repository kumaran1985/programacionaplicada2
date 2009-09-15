Public Class CLLogin
    Inherits MBFrameWork.BussinesLogic.BLBas e

    Public Function Login(ByVal usuario As String, ByVal password As String, ByRef msg As String) As Entities.EntUsuarios
        Dim da As New DataAccessCL.CLLogin
        Dim USR_ID As Integer
        USR_ID = da.Login(usuario, password)
        If USR_ID = -1 Then
            msg = "Usuario o contraseña incorrectos"
            Return Nothing
        Else
            Dim ds As DataSet = da.GetOneByPK("usuarios", USR_ID)
            If Convert.ToBoolean(ds.Tables(0).Rows(0).Item("USR_MustChangePass")) Then
                msg = "No debe cambiar la contraseña"
                Return Nothing
            Else
                'hacer otra cosa
                Return CrearEntity(ds.Tables(0).Rows(0))
            End If
        End If
    End Function

    Private Function CrearEntity(ByVal Dr As DataRow) As Entities.EntUsuarios
        Dim objEnt As New Entities.EntUsuarios
        objEnt.USR_ID = Dr.Item("USR_ID")
        objEnt.USR_LastAcceess = CDate(Dr.Item("USR_LastAcceess"))
        objEnt.USR_MustChangePass = Convert.ToBoolean(Dr.Item("USR_MustChangePass"))
        objEnt.USR_Nombre = Dr.Item("USR_Nombre")
        objEnt.USR_Pass = Dr.Item("USR_Pass")
        Return objEnt
    End Function

    Public Function GetAll() As List(Of Entities.EntUsuarios)
        Return New List(Of Entities.EntUsuarios)
    End Function

    Public Sub Insertar()

    End Sub

    Public Sub Eliminar()

    End Sub
End Class
