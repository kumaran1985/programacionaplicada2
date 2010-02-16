Imports System.Web.UI.WebControls
Imports System.Web.UI

Public Class TextBoxRequired
    Inherits System.Web.UI.WebControls.TextBox

    'Private req As RequiredFieldValidator
    Public InvalidMessage As String = "*"
    Public ClientScript As Boolean = True

    Private Function Req() As RequiredFieldValidator
        Req = New RequiredFieldValidator()
        Req.ControlToValidate = Me.ID
        Req.ErrorMessage = Me.InvalidMessage
        Req.EnableClientScript = ClientScript
        Req.Display = ValidatorDisplay.Dynamic
        Controls.Add(Req)
        Return Req
    End Function


    Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
        MyBase.Render(writer)
        req.RenderControl(writer)
    End Sub

   
    'Protected Overloads Overrides Sub Render(ByVal w As HtmlTextWriter)
    '    MyBase.Render(w)
    '    req.RenderControl(w)
    'End Sub

    Protected Overrides Sub OnInit(ByVal e As System.EventArgs)
        MyBase.OnInit(e)
        
    End Sub


    Private Sub TextBoxRequired_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

       


    End Sub
End Class
