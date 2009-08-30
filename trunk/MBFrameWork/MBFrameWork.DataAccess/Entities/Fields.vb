Namespace Entities

    Public Class Fields
        Private _FieldName As String
        Private _FieldValue As Object
        Private _FieldType As ParamTypeEnum
        Private _FieldLength As Int32
        Private _FieldPrecision As Int32
        Private _FieldScale As Int32
        Private _FieldOrder As Int32
        Private _DotNetEquivalent As System.Type
        Public Enum ParamTypeEnum
            dbInt16
            dbInt32
            dbInt64
            dbFloat
            dbDate
            dbString
            dbMemo
            dbTime
            dbBoolean
            dbChar
            dbXML
            dbObject

        End Enum



        Public Property FieldName() As String
            Get
                Return _FieldName
            End Get
            Set(ByVal value As String)
                _FieldName = value
            End Set
        End Property

        Public Property FieldValue() As Object
            Get
                Return _FieldValue
            End Get
            Set(ByVal value As Object)
                _FieldValue = value
            End Set
        End Property

        Public Property FieldType() As ParamTypeEnum
            Get
                Return _FieldType
            End Get
            Set(ByVal value As ParamTypeEnum)
                _FieldType = value
            End Set
        End Property

        Public Property FieldLength() As Int32
            Get
                Return _FieldLength
            End Get
            Set(ByVal value As Int32)
                _FieldLength = value
            End Set
        End Property

        Public Property FieldPrecision() As Int32
            Get
                Return _FieldPrecision
            End Get
            Set(ByVal value As Int32)
                _FieldPrecision = value
            End Set
        End Property

        Public Property FieldScale() As Int32
            Get
                Return _FieldScale
            End Get
            Set(ByVal value As Int32)
                _FieldScale = value
            End Set
        End Property

        Public Property FieldOrder() As Int32
            Get
                Return _FieldOrder
            End Get
            Set(ByVal value As Int32)
                _FieldOrder = value
            End Set
        End Property
    End Class

End Namespace