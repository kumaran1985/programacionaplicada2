Public Class EntEspecialidades
    Private _iEspecialidad As Nullable(Of Integer)
    Private _cDescripcion As String
    Private _iConsultorio As Nullable(Of Integer)

    Public Property iEspecialidad() As Nullable(Of Integer)
        Get
            Return _iEspecialidad
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _iEspecialidad = value

        End Set
    End Property
    Public Property cDescripcion() As String
        Get
            Return _cDescripcion
        End Get
        Set(ByVal value As String)
            _cDescripcion = value

        End Set
    End Property
    Public Property iConsultorio() As Nullable(Of Integer)
        Get
            Return _iConsultorio
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _iConsultorio = value

        End Set
    End Property

End Class
