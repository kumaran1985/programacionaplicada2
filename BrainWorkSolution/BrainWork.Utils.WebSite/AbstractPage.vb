Imports System.Web.UI.HtmlControls

Public Class AbstractPage
    Inherits System.Web.UI.Page
    


    Public Shared Property CurrentUser() As BrainWork.Security.ApplicationUser
        Get
            Dim u As New BrainWork.Security.ApplicationUser
            u.GetUserIDentification = "jborras"
            u.SessionID = 9999 'Me.Session.SessionID}

            Return TryCast(System.Web.HttpContext.Current.Session("userlogged"), BrainWork.Security.ApplicationUser)
            'Session("_CurrentUser") = u
            'Return TryCast(Session("_CurrentUser"), BrainWork.Security.ApplicationUser)
        End Get
        Set(ByVal value As BrainWork.Security.ApplicationUser)
            'Session("_CurrentUser") = value
        End Set
    End Property

    Protected Sub SucessAction(ByVal message As String)
        If Not Me.Page.ClientScript.IsStartupScriptRegistered("_SucessAction") Then
            Me.Page.ClientScript.RegisterStartupScript(Me.GetType, "_SucessAction", "alert('" & message & "')", True)
        End If
    End Sub

    Protected Sub ExceptionMessage(ByVal ex As Exception)
        If Not Me.Page.ClientScript.IsStartupScriptRegistered("_ExceptionMessage") Then
            Me.Page.ClientScript.RegisterStartupScript(Me.GetType, "_ExceptionMessage", "alert('" & ex.Message.Replace("'"c, " "c) & "')", True)
        End If
    End Sub

   
    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("userlogged") Is Nothing Then
            Response.Redirect("LogIn.aspx")
        End If
    End Sub
End Class
