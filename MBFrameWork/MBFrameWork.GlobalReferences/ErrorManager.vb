Public Class ErrorManager
    Inherits System.Exception


 
    Shared Sub NewError(ByVal e As Exception)
        'TODO: registrar las excepciones
        Throw New Exception(e.Message)
    End Sub

    Shared Sub NewError(ByVal sMensaje As String)
        'TODO: registrar las excepciones
        Throw New Exception(sMensaje)
    End Sub

End Class
