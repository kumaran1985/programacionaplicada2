Public MustInherit Class BrainWorkConnection
    Inherits AbstractConnection
    Private _TransactionCounter As Integer
    Protected Const PAGED_ROW_PARAMETER As String = "@Row"
    Protected Const PAGED_MAXVALUES_PARAMETER As String = "@MaxValues"
    Protected Const ORDER_BY_PARAMETER As String = "@OrderBy"

    Public CurrentRow As Integer
    Public CurrentMaxRecord As Integer


    Protected MustOverride Function CastParameter(ByVal p As System.Data.IDbDataParameter) As System.Data.IDbDataParameter
    Public MustOverride Function GetNewParameter() As IDbDataParameter

    Protected Overridable Function HasStandarParametersSettings(ByRef oCmd As IDbCommand, ByVal row As Integer, ByVal page As Integer) As Boolean
        HasStandarParametersSettings = True

        If Not oCmd.Parameters.Contains(PAGED_ROW_PARAMETER) OrElse _
           Not oCmd.Parameters.Contains(PAGED_MAXVALUES_PARAMETER) OrElse _
           Not oCmd.Parameters.Contains(ORDER_BY_PARAMETER) Then
            HasStandarParametersSettings = False
        End If
        'If Not oCmd.Parameters.Contains(PAGED_ROW_PARAMETER) Then
        '    'Dim p As IDbDataParameter = Me.GetNewParameter
        '    'p.ParameterName = PAGED_ROW_PARAMETER
        '    'p.Direction = ParameterDirection.Input
        '    'p.DbType = DbType.Int32
        '    'p.Value = row
        '    HasStandarParametersSettings = False
        'End If

        'If Not oCmd.Parameters.Contains(PAGED_PAGE_PARAMETER) Then
        '    'Dim p As IDbDataParameter = Me.GetNewParameter
        '    'p.ParameterName = PAGED_PAGE_PARAMETER
        '    'p.Direction = ParameterDirection.Input
        '    'p.DbType = DbType.Int32
        '    'p.Value = page
        '    HasStandarParametersSettings = False
        'End If

        'If Not oCmd.Parameters.Contains(ORDER_BY_PARAMETER) Then
        '    'Dim p As IDbDataParameter = Me.GetNewParameter
        '    'p.ParameterName = PAGED_PAGE_PARAMETER
        '    'p.Direction = ParameterDirection.Input
        '    'p.DbType = DbType.String
        '    'p.Value = ""
        '    HasStandarParametersSettings = False
        'End If

    End Function



    Public Property TransactionCounter() As Int32
        Get
            Return _TransactionCounter
        End Get
        Set(ByVal value As Int32)
            _TransactionCounter = value
        End Set
    End Property

    Protected ReadOnly Property IsInTransaction() As Boolean
        Get
            Return (TransactionCounter > 0)
        End Get
    End Property

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)
    End Sub

End Class
