
Partial Class _Default
    Inherits System.Web.UI.Page
  

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CustomTextBox1.OnBlur.Add("alert('hola');")
    End Sub
End Class
