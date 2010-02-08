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
    Private _DataAccess As Object
    Private _Entity As Object

    Private _CurrentPage As Integer
    Private _CurrentRow As Integer
#Region "Propiedades Públicas"

    Protected ReadOnly Property Entity() As BrainWork.Entities.AbstractEntityBase
        Get
            Return CType(_Entity, BrainWork.Entities.AbstractEntityBase)
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
    Protected Sub New(ByVal oUser As BrainWork.Security.ApplicationUser, ByVal oEntity As Object, ByVal oDataAccess As Object)
        Me._userlogged = oUser
        If Me._userlogged Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedUser
        End If

        Me._Entity = oEntity

        If Me._Entity Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedEntity
        End If

        Me._DataAccess = oDataAccess

        If Me._DataAccess Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedEntity
        End If


    End Sub

#End Region

#Region "Funciones de ABM Publicas"

    Public Function Add() As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Add) Then
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
            If ClassValidation(strError, Enums.enumValidationType.Load) Then
                LoadEntity()
                RaiseEvent OnLoad()
            Else
                Throw New Exceptions.ExceptionValidationError(strError)
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function

    Public Function Load(ByVal pk As Object) As Boolean
        Dim strError As String = Nothing

        Try
            If ClassValidation(strError, Enums.enumValidationType.Load) Then
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

    Protected Function GetDataTable() As DataTable
        Return GetDataTableEntity(0, 0)
    End Function
    Protected Function GetDataSet() As DataSet
        Return GetDataSetEntity(0, 0)
    End Function
    Protected Function GetDataTable(ByVal Row As Integer, ByVal Page As Integer) As DataTable
        Me._CurrentPage = Page
        Me._CurrentRow = Row
        Return GetDataTableEntity(Row, Page)
    End Function
    Protected Function GetDataSet(ByVal Row As Integer, ByVal Page As Integer) As DataSet
        Me._CurrentPage = Page
        Me._CurrentRow = Row
        Return GetDataSetEntity(0, 0)
    End Function
    Protected Function GetDataReader() As IDataReader
        Return GetDataReaderEntity(0, 0)
    End Function
    Protected Function GetDataReader(ByVal Row As Integer, ByVal Page As Integer) As IDataReader
        Me._CurrentPage = Page
        Me._CurrentRow = Row
        Return GetDataReaderEntity(Row, Page)
    End Function
    Protected Function GetList() As IList(Of Object)
        Return GetListEntity(0, 0)
    End Function
    Protected Function GetList(ByVal Row As Integer, ByVal Page As Integer) As List(Of Object)
        Me._CurrentPage = Page
        Me._CurrentRow = Row
        Return GetListEntity(Row, Page)
    End Function


#End Region

#Region "Funciones de ABML"
    Protected Overridable Sub AddEntity()
        Me.DataAccess.Add()
    End Sub
    Protected Overridable Sub UpdateEntity()
        Me.DataAccess.Update()
    End Sub
    Protected Overridable Sub DisableEntity()
        Me.DataAccess.Disable()
    End Sub
    Protected Overridable Sub DeleteEntity()
        Me.DataAccess.Delete()
    End Sub
    Protected Overridable Sub LoadEntity()
        Me.DataAccess.Load()
    End Sub
    Protected Overridable Sub LoadEntityByPk(ByVal PK As Object)
        Me.DataAccess.LoadByPk(PK)
    End Sub

    Protected Overridable Function GetDataTableEntity(ByVal Row As Integer, ByVal Page As Integer) As DataTable
        Return Me.DataAccess.GetDataTable(Row, Page)
    End Function

    Protected Overridable Function GetDataSetEntity(ByVal Row As Integer, ByVal Page As Integer) As DataSet
        Return Me.DataAccess.GetDataSet(Row, Page)
    End Function

    Protected Overridable Function GetDataReaderEntity(ByVal Row As Integer, ByVal Page As Integer) As IDataReader
        Return Me.DataAccess.GetDataReader(Row, Page)
    End Function

    Protected Overridable Function GetListEntity(ByVal Row As Integer, ByVal Page As Integer) As List(Of Object)
        Return Me.DataAccess.GetList(Row, Page)
    End Function

#End Region


    Public MustOverride Function ClassValidation(ByRef strError As String, ByVal validationType As Enums.enumValidationType) As Boolean

End Class

Public Class entClass
    Inherits BrainWork.Entities.AbstractEntityBase

End Class
Public Class blClass
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As entClass
    Private _myDataAccess As daClass

    Public Property CurrentEntity() As entClass
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As entClass)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New entClass, New daClass(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, entClass)
        Me._myDataAccess = CType(MyBase.DataAccess, daClass)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
    End Sub


    Public Overrides Function ClassValidation(ByRef strError As String, ByVal validationType As Enums.enumValidationType) As Boolean

    End Function
End Class

Public Class daClass
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess
    Private _CurrentEntity As entClass
    
    Public Property CurrentEntity() As entClass
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As entClass)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New entClass)
        Me._CurrentEntity = CType(MyBase.Entity, entClass)
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
        Me.SP_ADD = ""
        Me.SP_DELETE = ""
        Me.SP_DISABLE = ""
        Me.SP_GETALL = ""
        Me.SP_GETONE = ""
        Me.SP_UPDATE = ""
    End Sub
End Class
