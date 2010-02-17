Imports System.Web.UI.HtmlControls

Public Class AbstractPage
    Inherits System.Web.UI.Page
    


    Protected Property CurrentUser() As BrainWork.Security.ApplicationUser
        Get
            Dim u As New BrainWork.Security.ApplicationUser
            u.GetUserIDentification = "jborras"
            u.SessionID = 9999 'Me.Session.SessionID
            Return u
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

   
End Class
