
Public MustInherit Class AbstractFields
    Private _FieldType As DbType

    Public Property FieldType() As DbType
        Get
            Return _FieldType
        End Get
        Set(ByVal value As DbType)
            _FieldType = value
        End Set
    End Property

    Public Property FieldSize() As Long
        Get

        End Get
        Set(ByVal value As Long)

        End Set
    End Property

    Public Sub SetNewValue(ByVal Val As Boolean)

    End Sub

    Public Sub SetNewValue(ByVal Value As Int16)

    End Sub

    Public Sub SetNewValue(ByVal Value As Int32)

    End Sub

    Public Sub SetNewValue(ByVal Value As Int64)

    End Sub

    Public Sub SetNewValue(ByVal Value As Date)

    End Sub

    Public Sub SetNewValue(ByVal Value As Byte)

    End Sub

    Public Sub SetNewValue(ByVal Value As Char)

    End Sub

    Public Sub SetNewValue(ByVal Value As Decimal)

    End Sub

    Public Sub SetNewValue(ByVal Value As String)

    End Sub
End Class
