Option Strict On
Option Explicit On
<Serializable()> _
Public MustInherit Class AbstractBussinesLogic
    Private _userlogged As BrainWork.Security.ApplicationUser
    Public Event OnAdd()
    Public Event OnDelete()
    Public Event OnUpdate()
    Public Event OnDisable()
    Public Event OnLoad()
    Private WithEvents _DataAccess As Object
    'Private _Entity_pvt As Object

    Private _CurrentPage As Integer
    Private _CurrentRow As Integer
#Region "Propiedades Públicas"
    Private _RecordCount As Int64
    Public Overridable Property RecordCount() As Int64
        Get
            Return _RecordCount
        End Get
        Set(ByVal value As Int64)
            _RecordCount = value
        End Set
    End Property

    'Protected Property _Entity() As Object
    '    Get
    '        Return _Entity_pvt
    '    End Get
    '    Set(ByVal value As Object)
    '        _Entity_pvt = value
    '        'SetEntity(value)
    '    End Set
    'End Property

    Public MustOverride Property EntityObject() As Object

    Public ReadOnly Property Entity() As BrainWork.Entities.AbstractEntityBase
        Get
            Return CType(EntityObject, BrainWork.Entities.AbstractEntityBase)
        End Get
    End Property

    Protected ReadOnly Property DataAccess() As BrainWork.DataAccessBaseLibrary.AbstractDataAccess
        Get
            Return CType(_DataAccess, BrainWork.DataAccessBaseLibrary.AbstractDataAccess)
        End Get
    End Property

    Protected ReadOnly Property ApplicationUser() As BrainWork.Security.ApplicationUser
        Get
            Return _userlogged
        End Get
    End Property

    ' Public MustOverride Sub SetEntity(ByVal o As Object)



    Public Sub BeginTransaction()
        Me.DataAccess.BeginTransaction()
    End Sub

    Public Sub CommitTransaction()
        Me.DataAccess.CommitTransaction()
    End Sub

    Public Sub RollBackTransaction()
        Me.DataAccess.RollBackTransaction()
    End Sub


    Public ReadOnly Property CurrentRow() As Integer
        Get
            Return _CurrentRow
        End Get

    End Property

    Public ReadOnly Property CurrentPage() As Integer
        Get
            Return _CurrentPage
        End Get
    End Property

#End Region

#Region "Constructores"
    Protected Sub New(ByVal oUser As BrainWork.Security.ApplicationUser, ByVal oDataAccess As Object)
        Me._userlogged = oUser
        If Me._userlogged Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedUser
        End If

        'Me._Entity = oEntity

        'If Me._Entity Is Nothing Then
        '    Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedEntity
        'End If

        Me._DataAccess = oDataAccess

        If Me._DataAccess Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedEntity
        End If


    End Sub





    Public MustOverride Sub RefreshEntityDataAccess()


#End Region

#Region "Funciones de ABM Publicas"

    Public Function Add() As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Add) Then
                ' RefreshEntityDataAccess()
                AddEntity()
                RaiseEvent OnAdd()
            Else
                Throw New Exceptions.ExceptionValidationError(strError)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function Delete() As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Delete) Then
                '  RefreshEntityDataAccess()
                DeleteEntity()
                RaiseEvent OnDelete()
            Else
                Throw New Exceptions.ExceptionValidationError(strError)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function


    Public Function Update() As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Update) Then
                'RefreshEntityDataAccess()
                UpdateEntity()
                RaiseEvent OnUpdate()
            Else
                Throw New Exceptions.ExceptionValidationError(strError)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function Disable() As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Disable) Then
                ' RefreshEntityDataAccess()
                UpdateEntity()
                RaiseEvent OnUpdate()
            Else
                Throw New Exceptions.ExceptionValidationError(strError)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function

    Public Function Load() As Boolean
        Dim strError As String = Nothing

        Try
            ' RefreshEntityDataAccess()
            LoadEntity()
            RaiseEvent OnLoad()

        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function

    Public Function Load(ByVal pk As Object) As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Load) Then
                ' RefreshEntityDataAccess()
                LoadEntityByPk(pk)
                RaiseEvent OnLoad()
            Else
                Throw New Exceptions.ExceptionValidationError(strError)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function

    Public Function GetDataTable() As DataTable
        '  RefreshEntityDataAccess()
        Return GetDataTableEntity(0, 0)
    End Function
    Public Function GetDataSet() As DataSet
        ' RefreshEntityDataAccess()
        Return GetDataSetEntity(0, 0)
    End Function
    Public Function GetDataTable(ByVal Row As Integer, ByVal MaxRecords As Integer) As DataTable
        ' RefreshEntityDataAccess()
        Me._CurrentPage = MaxRecords
        Me._CurrentRow = Row
        Return GetDataTableEntity(Row, MaxRecords)
    End Function

    Public Function GetDataTable(ByVal Row As Integer, ByVal MaxRecords As Integer, ByVal orderByColumn As String) As DataTable
        ' RefreshEntityDataAccess()
        Me._CurrentPage = MaxRecords
        Me._CurrentRow = Row
        Return GetDataTableEntity(Row, MaxRecords, orderByColumn)
    End Function
    Public Function GetDataTableFull(ByVal Row As Integer, ByVal MaxRecords As Integer, ByVal orderByColumn As String) As DataTable
        ' RefreshEntityDataAccess()
        Me._CurrentPage = MaxRecords
        Me._CurrentRow = Row
        Return GetDataTableEntityFull(Row, MaxRecords, orderByColumn)
    End Function


    Public Function GetDataSet(ByVal Row As Integer, ByVal MaxRecords As Integer) As DataSet
        ' RefreshEntityDataAccess()
        Me._CurrentPage = MaxRecords
        Me._CurrentRow = Row
        Return GetDataSetEntity(Row, MaxRecords)
    End Function
    Public Function GetDataReader() As IDataReader
        '   RefreshEntityDataAccess()
        Return GetDataReaderEntity(0, 0)
    End Function
    Public Function GetDataReader(ByVal Row As Integer, ByVal MaxRecords As Integer) As IDataReader
        '  RefreshEntityDataAccess()
        Me._CurrentPage = MaxRecords
        Me._CurrentRow = Row
        Return GetDataReaderEntity(Row, MaxRecords)
    End Function
    Public Function GetList() As IList(Of Object)
        '   RefreshEntityDataAccess()
        Return GetListEntity(0, 0)
    End Function
    Public Function GetList(ByVal Row As Integer, ByVal MaxRecords As Integer) As List(Of Object)
        '  RefreshEntityDataAccess()
        Me._CurrentPage = MaxRecords
        Me._CurrentRow = Row
        Return GetListEntity(Row, MaxRecords)
    End Function


#End Region

#Region "Funciones de ABML"
    Protected Overridable Sub AddEntity()
        RefreshEntityDataAccess()
        Me.DataAccess.Add()
    End Sub
    Protected Overridable Sub UpdateEntity()
        RefreshEntityDataAccess()
        Me.DataAccess.Update()
    End Sub
    Protected Overridable Sub DisableEntity()
        RefreshEntityDataAccess()
        Me.DataAccess.Disable()
    End Sub
    Protected Overridable Sub DeleteEntity()
        RefreshEntityDataAccess()
        Me.DataAccess.Delete()
    End Sub
    Protected Overridable Sub LoadEntity()
        RefreshEntityDataAccess()
        Me.DataAccess.Load()
    End Sub
    Protected Overridable Sub LoadEntityByPk(ByVal PK As Object)
        RefreshEntityDataAccess()
        Me.DataAccess.LoadByPk(PK)
    End Sub

    Protected Overridable Function GetDataTableEntity(ByVal Row As Integer, ByVal Page As Integer) As DataTable
        RefreshEntityDataAccess()
        GetDataTableEntity = Me.DataAccess.GetDataTable(Row, Page)
        RecordCount = Me.DataAccess.RecordCount
    End Function

    Protected Overridable Function GetDataTableEntityFull(ByVal Row As Integer, ByVal Page As Integer, ByVal orderByColumn As String) As DataTable
        RefreshEntityDataAccess()
        GetDataTableEntityFull = Me.DataAccess.GetDataTableFull(Row, Page, orderByColumn)
        RecordCount = Me.DataAccess.RecordCount
    End Function

    Protected Overridable Function GetDataTableEntity(ByVal Row As Integer, ByVal Page As Integer, ByVal orderByColumn As String) As DataTable
        RefreshEntityDataAccess()
        GetDataTableEntity = Me.DataAccess.GetDataTable(Row, Page, orderByColumn)
        RecordCount = Me.DataAccess.RecordCount
    End Function

    Protected Overridable Function GetDataSetEntity(ByVal Row As Integer, ByVal Page As Integer) As DataSet
        RefreshEntityDataAccess()
        Return Me.DataAccess.GetDataSet(Row, Page)
    End Function

    Protected Overridable Function GetDataReaderEntity(ByVal Row As Integer, ByVal Page As Integer) As IDataReader
        RefreshEntityDataAccess()
        Return Me.DataAccess.GetDataReader(Row, Page)
    End Function

    Protected Overridable Function GetListEntity(ByVal Row As Integer, ByVal Page As Integer) As List(Of Object)
        RefreshEntityDataAccess()
        Return Me.DataAccess.GetList(Row, Page)
    End Function

#End Region


    Public MustOverride Function ClassValidation(ByRef strError As String, ByVal validationType As Enums.enumValidationType) As Boolean

End Class
 
'Public Class entClass
'    Inherits BrainWork.Entities.AbstractEntityBase

'End Class
'Public Class blClass
'    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
'    Private _CurrentEntity As entClass
'    Private _myDataAccess As daClass

'    Public Property CurrentEntity() As entClass
'        Get
'            Return _CurrentEntity
'        End Get
'        Set(ByVal value As entClass)
'            _CurrentEntity = value
'        End Set
'    End Property

'    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
'        MyBase.New(oUser, New entClass, New daClass(oUser))
'        Me._CurrentEntity = CType(MyBase.Entity, entClass)
'        Me._myDataAccess = CType(MyBase.DataAccess, daClass)
'        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
'    End Sub


'    Public Overrides Function ClassValidation(ByRef strError As String, ByVal validationType As Enums.enumValidationType) As Boolean

'    End Function
'End Class

'Public Class daClass
'    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess
'    Private _CurrentEntity As entClass

'    Public Property CurrentEntity() As entClass
'        Get
'            Return _CurrentEntity
'        End Get
'        Set(ByVal value As entClass)
'            _CurrentEntity = value
'        End Set
'    End Property

'    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
'        MyBase.New(oUser, New entClass)
'        Me._CurrentEntity = CType(MyBase.Entity, entClass)
'    End Sub

'    Protected Overrides Sub DisableEntity()

'    End Sub

'    Protected Overrides Sub SetStoredProcedures()
'        Me.SP_ADD = ""
'        Me.SP_DELETE = ""
'        Me.SP_DISABLE = ""
'        Me.SP_GETALL = ""
'        Me.SP_GETONE = ""
'        Me.SP_UPDATE = ""
'    End Sub
'End Class
