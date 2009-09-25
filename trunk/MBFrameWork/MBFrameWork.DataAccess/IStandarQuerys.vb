Public Interface IStandarQuerys
    Function GetOneByPK(ByVal tableName As String, ByVal value As Object) As DataSet
    Function GetOneByPK(ByVal tableName As String, ByVal pk As List(Of Entities.Fields)) As DataSet
    Function GetOneByPK(ByVal tableName As String, ByVal pk As List(Of Entities.Fields), ByVal pageNumber As Int64, ByVal pageSize As Int32) As DataSet

    Function GetOne(ByVal tableName As String, ByVal values As List(Of Entities.Fields)) As DataSet
    Function GetOne(ByVal tableName As String, ByVal oEntity As Object) As DataSet

    Function GetAll(ByVal tableName As String) As DataSet
    Function GetAll(ByVal tableName As String, ByVal pageNumber As Int64, ByVal pageSize As Int32) As DataSet
    Function GetAll(ByVal tableName As String, ByVal oEntity As Object) As DataSet
    Function GetAll(ByVal tableName As String, ByVal oEntity As Object, ByVal pageNumber As Int64, ByVal pageSize As Int32) As DataSet

    Function Insert(ByVal tableName As String, ByVal values As List(Of Entities.Fields), ByRef PK As Object) As Boolean
    Function Insert(ByVal tableName As String, ByVal values As List(Of Entities.Fields)) As Boolean
    Function UpdateByPk(ByVal tableName As String, ByVal pk As List(Of Entities.Fields)) As Boolean

    Function GetTableInfo(ByVal tableName As String) As Entities.TableInfo

    Function GetPagedData(ByVal da As IDbDataAdapter, ByVal pageNumber As Integer, ByVal pageSize As Integer) As DataSet

    Function DeleteByPK(ByVal da As IDbDataAdapter, ByVal pk As Object) As Boolean



    Function toDBDate(ByVal strValue As Object) As String

End Interface
