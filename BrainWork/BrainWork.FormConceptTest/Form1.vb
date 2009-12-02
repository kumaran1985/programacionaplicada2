Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim o As Object
        Dim typee As Type
        typee = Type.GetType("mi_clase", False, False)

        Dim p As Object
        p = CType(o, Type.GetType("mi_clase", False, False))




    End Sub
End Class

Class mi_clase
    Public v As String
    Public s As Integer
    Public d As Long
    Public c As mi_clase2

End Class

Class mi_clase2
    Public v As String
    Public s As Integer
    Public d As Long

End Class
