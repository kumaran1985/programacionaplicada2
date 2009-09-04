Imports MBFrameWork.DataAccess.Entities.StoredProcedureFields
Imports MBFrameWork.DataAccess
Public Class Cast
    Shared Function toSystemType(ByVal dbt As ParamTypeEnum) As System.Type

        Select Case dbt
            Case ParamTypeEnum.dbInt16
                Return System.Type.GetType("int16", False, True)

            Case ParamTypeEnum.dbInt32
                Return System.Type.GetType("int32", False, True)

            Case ParamTypeEnum.dbInt64
                Return System.Type.GetType("int64", False, True)

            Case ParamTypeEnum.dbFloat
                Return System.Type.GetType("double", False, True)

            Case ParamTypeEnum.dbDate
                Return System.Type.GetType("datetime", False, True)

            Case ParamTypeEnum.dbString
                Return System.Type.GetType("string", False, True)

            Case ParamTypeEnum.dbMemo
                Return System.Type.GetType("string", False, True)

            Case ParamTypeEnum.dbTime
                Return System.Type.GetType("string", False, True)

            Case ParamTypeEnum.dbBoolean
                Return System.Type.GetType("boolean", False, True)

            Case ParamTypeEnum.dbChar
                Return System.Type.GetType("string", False, True)

            Case ParamTypeEnum.dbXML
                Return System.Type.GetType("string", False, True)

            Case ParamTypeEnum.dbObject
                Return System.Type.GetType("object", False, True)

            Case Else
                Return System.Type.GetType("object", False, True)
        End Select

    End Function

    Shared Function toDBType(ByVal oISPParams As ISPParams, ByVal sdbType As String) As Entities.StoredProcedureFields.ParamTypeEnum
        Return oISPParams.getTypeFromDB(sdbType)
    End Function

#Region "To DBType Methods"

    Shared Function toDBValue(ByVal pObject As Int16) As Int16
        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As Int32) As Int32
        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As Int64) As Int64

        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As Double) As Double

        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As DateTime) As DateTime

        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As Boolean) As Boolean
        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As String) As String
        Return pObject
    End Function

    Shared Function toDBValue(ByVal pObject As Object) As Object
        Return pObject
    End Function

    Shared Function toDbType(ByVal dbType As Type) As Entities.Fields.ParamTypeEnum


        Select Case True

            Case dbType Is System.Type.GetType("int16", False, True)
                Return ParamTypeEnum.dbInt16

            Case dbType Is System.Type.GetType("int32", False, True)
                Return ParamTypeEnum.dbInt32

            Case dbType Is System.Type.GetType("int64", False, True)
                Return ParamTypeEnum.dbInt64

            Case dbType Is System.Type.GetType("double", False, True)
                Return ParamTypeEnum.dbFloat

            Case dbType Is System.Type.GetType("datetime", False, True)
                Return ParamTypeEnum.dbDate

            Case dbType Is System.Type.GetType("string", False, True)
                Return ParamTypeEnum.dbString

            Case dbType Is System.Type.GetType("string", False, True)
                Return ParamTypeEnum.dbMemo

            Case dbType Is System.Type.GetType("string", False, True)
                Return ParamTypeEnum.dbTime

            Case dbType Is System.Type.GetType("boolean", False, True)
                Return ParamTypeEnum.dbBoolean

            Case dbType Is System.Type.GetType("string", False, True)
                Return ParamTypeEnum.dbChar

            Case dbType Is System.Type.GetType("string", False, True)
                Return ParamTypeEnum.dbXML

            Case dbType Is System.Type.GetType("object", False, True)
                Return ParamTypeEnum.dbObject

            Case Else
                Return ParamTypeEnum.dbObject

        End Select


    End Function

#End Region

    'Shared Function toDBValue(ByVal pObject As Object) As Object
    '    Select Case True
    '        Case pObject.GetType() Is System.Type.GetType("int16", False, True)
    '            Return CType(pObject, Int16)

    '        Case pObject.GetType() Is System.Type.GetType("int32", False, True)
    '            Return CType(pObject, Int32)

    '        Case pObject.GetType() Is System.Type.GetType("int64", False, True)
    '            Return CType(pObject, Int64)

    '        Case pObject.GetType() Is System.Type.GetType("double", False, True)
    '            Return CType(pObject, Double)

    '        Case pObject.GetType() Is System.Type.GetType("datetime", False, True)
    '            Return CType(pObject, DateTime)

    '        Case pObject.GetType() Is System.Type.GetType("string", False, True)
    '            Return CType(pObject, DateTime)

    '        Case pObject.GetType() Is System.Type.GetType("boolean", False, True)
    '            Return CType(pObject, Boolean)

    '        Case pObject.GetType() Is System.Type.GetType("string", False, True)
    '            Return CType(pObject, String)

    '        Case pObject.GetType() Is System.Type.GetType("string", False, True)
    '            Return CType(pObject, String)

    '        Case pObject.GetType() Is System.Type.GetType("object", False, True)
    '            Return CType(pObject, Object)

    '        Case Else
    '            Return CType(pObject, Object)

    '    End Select


    'End Function
End Class
