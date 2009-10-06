Public Class EntFacturas
    Private _Fact_Key As Integer
    Private _Pac_Key As Integer
    Private _Fact_FechaFactura As Date
    Private _Fact_Tipo As String
    Private _Fact_Monto As Integer
    Private _Fact_TipoDoc As Integer
    Private _Fact_NumeroDoc As String
    Private _Fact_Cantidad As Integer
    Private _PM_Key As Integer
    Private _Fact_Observacion As String
    Private _Fact_FechaAlta As Date
    Private _Fact_FechaCancelacion As Date

    Public Property Fact_Key() As Integer
        Get
            Return _Fact_Key
        End Get
        Set(ByVal value As Integer)
            _Fact_Key = value
        End Set
    End Property

    Public Property Pac_key() As Integer
        Get
            Return _Pac_Key
        End Get
        Set(ByVal value As Integer)
            _Pac_Key = value
        End Set
    End Property

    Public Property fact_fechafactura() As Date
        Get
            Return _Fact_FechaFactura
        End Get
        Set(ByVal value As Date)
            _Fact_FechaFactura = value
        End Set
    End Property

    Public Property Fact_Tipo() As String
        Get
            Return _Fact_Tipo
        End Get
        Set(ByVal value As String)
            _Fact_Tipo = value
        End Set
    End Property

    Public Property Fact_Monto() As Integer
        Get
            Return _Fact_Monto
        End Get
        Set(ByVal value As Integer)
            _Fact_Monto = value
        End Set
    End Property

    Public Property Fact_TipoDoc() As Integer
        Get
            Return _Fact_TipoDoc
        End Get
        Set(ByVal value As Integer)
            _Fact_TipoDoc = value
        End Set
    End Property

    Public Property Fact_NumeroDoc() As String
        Get
            Return _Fact_NumeroDoc
        End Get
        Set(ByVal value As String)
            _Fact_NumeroDoc = value
        End Set
    End Property

    Public Property Fact_Cantidad() As Integer
        Get
            Return _Fact_Cantidad
        End Get
        Set(ByVal value As Integer)
            _Fact_Cantidad = value
        End Set
    End Property

    Public Property PM_Key() As Integer
        Get
            Return _PM_Key
        End Get
        Set(ByVal value As Integer)
            _PM_Key = value
        End Set
    End Property

    Public Property Fact_Observacion() As String
        Get
            Return _Fact_Observacion
        End Get
        Set(ByVal value As String)
            _Fact_Observacion = value
        End Set
    End Property

    Public Property Fact_FechaAlta() As Date
        Get
            Return _Fact_FechaAlta
        End Get
        Set(ByVal value As Date)
            _Fact_FechaAlta = value
        End Set
    End Property

    Public Property Fact_FechaCancelacion() As Date
        Get
            Return _Fact_FechaCancelacion
        End Get
        Set(ByVal value As Date)
            _Fact_FechaCancelacion = value
        End Set
    End Property
End Class
