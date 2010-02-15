Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace ControlTest

    ' Renders the following HTML: 
    ' <span onclick="alert('Hello');" style="color:Red;">Custom Contents</span>
    Public Class MyWebControl
        Inherits TextBox


        Public Sub New()
            MyBase.New()
        End Sub 'New      

        '<System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
        'Protected Overrides Sub AddAttributesToRender(ByVal writer As HtmlTextWriter)

        '    writer.AddAttribute(HtmlTextWriterAttribute.Onclick, "alert('Hello');")
        '    writer.AddStyleAttribute(HtmlTextWriterStyle.Color, "Red")
        '    MyBase.AddAttributesToRender(writer)

        'End Sub 'AddAttributesToRender       

        '        <System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
        Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)

            'Dim t As New TextBox
            't.ID = Me.ClientID & "___s"
            't.RenderControl(writer)




            '' writer.Write("Custom Contents")

            MyBase.RenderContents(writer)
        End Sub 'RenderContents

    End Class 'MyWebControl

End Namespace 'ControlTest
