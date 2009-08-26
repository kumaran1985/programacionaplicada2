Namespace Entities
    Public Class Params
        Private _ParamName As String
        Private _ParamValue As Object
        Private _ParamType As ParamTypeEnum
        Public Enum ParamTypeEnum
            dbInt16
            dbInt32
            dbInt64
            dbFloat
            dbDate
            dbString
            dbMemo

        End Enum



        Public Property ParamName() As String
            Get
                Return _ParamName
            End Get
            Set(ByVal value As String)
                _ParamName = value
            End Set
        End Property

        Public Property ParamValue() As Object
            Get
                Return _ParamValue
            End Get
            Set(ByVal value As Object)
                _ParamValue = value
            End Set
        End Property

        Public Property ParamType() As ParamTypeEnum
            Get
                Return _ParamType
            End Get
            Set(ByVal value As ParamTypeEnum)
                _ParamType = value
            End Set
        End Property

    End Class
End Namespace
