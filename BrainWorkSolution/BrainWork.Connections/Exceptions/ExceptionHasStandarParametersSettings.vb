Namespace Exceptions
    Public Class ExceptionHasStandarParametersSettings
        Inherits Exception
        Sub New()
            MyBase.New("No se han declarado alguno de los parámetros standar (order by,Row,MaxRow) en el stored procedure seleccionado")
        End Sub
    End Class

End Namespace