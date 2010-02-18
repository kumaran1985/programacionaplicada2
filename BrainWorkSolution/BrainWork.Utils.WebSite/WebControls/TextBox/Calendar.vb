Option Explicit On
Option Strict On
Imports System.Web.UI
'Namespace Components.CustomControls

Public Class Calendar
    Inherits System.Web.UI.WebControls.TextBox


    Const rFrom As Integer = 2000
    Const rTo As Integer = 2019

    Dim _ifFormat As String = "%d/%m/%Y"
    Dim _ButtonTarget As String
    Dim _showsTime As String = "false"

    Public Property ifFormat() As String
        Get
            Return Me._ifFormat
        End Get
        Set(ByVal value As String)
            Me._ifFormat = value
        End Set
    End Property

    Public Property ButtonTarget() As String
        Get
            Return Me._ButtonTarget
        End Get
        Set(ByVal value As String)
            Me._ButtonTarget = value
        End Set
    End Property

    Public Property showsTime() As String
        Get
            Return Me._showsTime
        End Get
        Set(ByVal value As String)
            Me._showsTime = value
        End Set
    End Property



    Private Sub Calendar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub


    Private Sub Calendar_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender

       
    End Sub


    Public Sub New(ByVal Page As Page, ByVal IDControl As String)
        Me.ID = IDControl
        BrainWork.Utils.Web.JavaScript.JavaScriptUtils.JS_Calendar(Page, Me.GetType())
        BrainWork.Utils.Web.JavaScript.JavaScriptUtils.JS_CalendarLang_es(Page, Me.GetType())
        BrainWork.Utils.Web.JavaScript.JavaScriptUtils.JS_CalendarSetup(rFrom, rTo, Page, Me.GetType())

        If Me.ButtonTarget = "" Then
            Me.ButtonTarget = Me.ClientID
        End If
        BrainWork.Utils.Web.JavaScript.JavaScriptUtils.JS_CalendarInitializate(Me.ClientID, Me.ifFormat, Me.ButtonTarget, Me.showsTime, Page, Me.GetType())

        If Me.showsTime = "false" Then
            BrainWork.Utils.Web.JavaScript.JavaScriptUtils.JS_verificarFecha(Page, Me.GetType())

        End If
    End Sub
End Class

'End Namespace
