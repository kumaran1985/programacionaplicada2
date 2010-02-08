Namespace Exceptions
    Public Class ExceptionNotSetedUser
        Inherits ExceptionBase

        Sub New()
            MyBase.New("No se ha generado la instancia del usuario")
        End Sub

    End Class

    Public Class ExceptionNotSetedEntity
        Inherits ExceptionBase

        Sub New()
            MyBase.New("No se ha generado la instancia de la entidad")
        End Sub

    End Class

    Public Class ExceptionNotSetedDataAccess
        Inherits ExceptionBase

        Sub New()
            MyBase.New("No se ha generado la instancia de la DataAccess")
        End Sub

    End Class
End Namespace

