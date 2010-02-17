Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Configuration
Imports System.ComponentModel


Namespace WebControls.Data
    <DefaultProperty("PageSize"), ToolboxData("<{0}:GridView runat=server></{0}:GridView>")> _
    Public Class GridView
        Inherits System.Web.UI.WebControls.GridView

        Private _CurrentBussines As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
        
        Public Property VerTodos() As Boolean
            Get
                Return Not Me.AllowPaging
            End Get
            Set(ByVal value As Boolean)
                Me.AllowPaging = Not value
                cargarDatos()
            End Set
        End Property


        Public Property CurrentOrderBY() As String
            Get
                If HttpContext.Current.Session(Me.ClientID & "_CurrentOrderBY") Is Nothing Then
                    If Not Me._CurrentBussines Is Nothing Then
                        HttpContext.Current.Session(Me.ClientID & "_CurrentOrderBY") = _CurrentBussines.Entity.GetDefaultOrderByField
                    End If
                End If
                Return TryCast(HttpContext.Current.Session(Me.ClientID & "_CurrentOrderBY"), String)
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session(Me.ClientID & "_CurrentOrderBY") = value
            End Set
        End Property

        Public Property RecordCount() As Long
            Get
                Return CLng(ViewState(Me.ClientID & "_RecordCount"))
            End Get
            Set(ByVal value As Long)
                ViewState(Me.ClientID & "_RecordCount") = value
            End Set
        End Property

        Public Overrides Property DataSource() As Object
            Get
                Return MyBase.DataSource
            End Get
            Set(ByVal value As Object)
                asignarDatosPaginado() 
                MyBase.DataSource = value
            End Set
        End Property

        Private Sub asignarDatosPaginado()
            Me.PageSize = 10 'CInt(ConfigurationManager.AppSettings("GRID_PAGE_SIZE"))
            Me.PagerStyle.CssClass = "PagerStyle" 
        End Sub

        Private Sub GridView_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
            Me.AllowPaging = True
            Me.AllowSorting = True
        End Sub

        Private Sub setDataSourceFromBL()
            Dim sort As String = CurrentOrderBY


            Me.DataSource = _CurrentBussines.GetDataTable(Me.PageSize + Me.PageIndex, Me.PageSize, sort)
            'RecordCount = _CurrentBussines.RefreshEntityDataAccess
        End Sub


        Public Sub SetDataSourceBussines(ByVal blClass As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic)
            _CurrentBussines = blClass
            setDataSourceFromBL()
            asignarDatosPaginado()
        End Sub

        Private Sub GridView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
            Me.HeaderStyle.CssClass = "HeaderStyle"
            Me.FooterStyle.CssClass = "FooterStyle"
            Me.RowStyle.CssClass = "RowStyle"
            Me.SelectedRowStyle.CssClass = "SelectedRowStyle"
            Me.AlternatingRowStyle.CssClass = "AlternatingRowStyle"
            Me.CssClass = "GridView"

        End Sub

        Private Sub GridView_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PageIndexChanged

        End Sub

        Private Sub cargarDatos()
            setDataSourceFromBL()
            Me.DataBind()
        End Sub

        Private Sub GridView_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Me.PageIndexChanging
            Me.PageIndex = e.NewPageIndex

            cargarDatos()
        End Sub

        'Libera la grilla
        Public Sub GridDispose() 
        End Sub

        Private Sub GridView_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Sorted

        End Sub

        Private Sub GridView_Sorting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSortEventArgs) Handles Me.Sorting
            Me.CurrentOrderBY = e.SortExpression
            cargarDatos()
        End Sub
    End Class

End Namespace
