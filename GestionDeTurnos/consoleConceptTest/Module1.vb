Imports BLClassLibrary
Module Module1

    Sub Main()
        Dim oLogin As CLLogin
        Dim msg As String = ""
        oLogin = New CLLogin

        oLogin.Login("juan perez", "123", msg)
        Console.ReadLine()
    End Sub

End Module
