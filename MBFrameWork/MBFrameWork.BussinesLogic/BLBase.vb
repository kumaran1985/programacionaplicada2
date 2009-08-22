Public Class BLBase


    Public Sub New()
        Dim daBase As New DataAccess.DABase
        Dim cnn As System.Data.SqlClient.SqlConnection
        cnn = CType(daBase.GetOpenConnection, SqlClient.SqlConnection)





    End Sub
End Class
