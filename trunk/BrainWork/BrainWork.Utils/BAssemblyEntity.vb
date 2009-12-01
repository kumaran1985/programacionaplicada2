''' <summary>
''' Entity que representa los datos 
''' de un ensamblado
''' </summary>
''' <remarks></remarks>
Public Class BAssemblyEntity
    Private _LibraryName As String
    Private _ClassName As String
    Private _ExecuteMethod As String
    Private _ExecuteProperty As String
    Private _TimerSpanValue As String
    Private _TimerSpanType As String

    Private _params As List(Of String)

    ''' <summary>
    ''' Cada cuanto debe ejecutarse el procedimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TimerSpanValue() As String
        Get
            Return _TimerSpanValue
        End Get
        Set(ByVal value As String)
            _TimerSpanValue = value
        End Set
    End Property


    ''' <summary>
    ''' que tipo puede ser, D, m, s
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TimerSpanType() As String
        Get
            Return _TimerSpanType
        End Get
        Set(ByVal value As String)
            _TimerSpanType = value.ToLower.Trim
        End Set
    End Property

    ''' <summary>
    ''' Nombre de la librería o el ensamblado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LibraryName() As String
        Get
            Return _LibraryName
        End Get
        Set(ByVal value As String)
            _LibraryName = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre de la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ClassName() As String
        Get
            Return _ClassName
        End Get
        Set(ByVal value As String)
            _ClassName = value
        End Set
    End Property

    ''' <summary>
    ''' Método a Ejecutar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ExecuteMethod() As String
        Get
            Return _ExecuteMethod
        End Get
        Set(ByVal value As String)
            _ExecuteMethod = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad a obtener
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ExecuteProperty() As String
        Get
            Return _ExecuteProperty
        End Get
        Set(ByVal value As String)
            _ExecuteProperty = value
        End Set
    End Property


    Public Sub New()

        _LibraryName = Nothing
        _ClassName = Nothing
        _ExecuteMethod = Nothing
        _ExecuteProperty = Nothing
        _params = Nothing
    End Sub

    ''' <summary>
    ''' Colección de parámetros asociados al método
    ''' Debe ir una secuencia de Valor y luego Tipo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property params() As List(Of String)
        Get
            Return _params
        End Get
        Set(ByVal value As List(Of String))
            _params = value
        End Set
    End Property

End Class
