
Namespace Exceptions
    <Serializable()> _
    Public Class ExceptionNotSetedStored
        Inherits BrainWork.TrunkLibrary.Exceptions.ExceptionBase
        Public Sub New()
            MyBase.New("No se puede instanciar la clase con valores de stored Procedures en Nothing,")
        End Sub
    End Class
End Namespace


