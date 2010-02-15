<Serializable()> _
Public Class ModifyQueryEventArgs
    Inherits EventArgs
    Private _StoredProcedureName
    Private _Parameters() As System.Data.IDbDataParameter

    Public ReadOnly Property StoredProcedureName() As String
        Get
            Return _StoredProcedureName
        End Get
    End Property


    Public ReadOnly Property Parameters() As System.Data.IDbDataParameter()
        Get
            Return _Parameters
        End Get
    End Property

    Public Sub New(ByVal StoredProcedureNameParam As String, ByVal ParametersParam() As System.Data.IDbDataParameter)
        _StoredProcedureName = StoredProcedureNameParam
        _Parameters = ParametersParam
    End Sub





End Class
