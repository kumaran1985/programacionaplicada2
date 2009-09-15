Public Class CLLogin
    Inherits MBFrameWork.DataAccess.DAOledb

    Public Function Login(ByVal userName, ByVal password) As Integer
        Dim ds As DataSet = Nothing
        ds = Me.GetDataSet("Select * From usuarios Where USR_ID Like '" & userName & "' and USR_PASS = '" & password & "'", CommandType.Text)
        If ds Is Nothing Then
            Return -1
        Else
            Return CInt(ds.Tables(0).Rows(0).Item("USR_ID"))
        End If
    End Function

    'Function GetAll() As DataSet
    '    Return New DataSet
    'End Function
    'Sub Update()

    'End Sub
    'Sub Insert()

    'End Sub
End Class
