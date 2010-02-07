Namespace Exceptions
    Public Class ExceptionValidationError
        Inherits BrainWork.TrunkLibrary.Exceptions.ExceptionBase
        Public Sub New(ByVal Message As String)
            MyBase.New("No se puede instanciar la clase " & Message)
        End Sub
    End Class
End Namespace