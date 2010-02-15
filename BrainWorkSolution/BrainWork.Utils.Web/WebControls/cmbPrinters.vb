Imports System.ComponentModel
Imports System.Web.UI
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web
Imports System.Web.UI.WebControls

Namespace WebControls
    <DefaultProperty("DataSource"), ToolboxData("<{0}:cmbPrinter runat=server>"), Description("Origen de las Impresoras"), DefaultEvent("Click")> _
Public Class cmbPrinter
        Inherits System.Web.UI.WebControls.WebControl
        Implements INamingContainer

        Friend _datasource As System.Drawing.Printing.PrinterSettings.StringCollection
        Dim cmbCombo As New System.Web.UI.WebControls.DropDownList

        Public Event Click(ByVal sender As Object, ByVal e As EventArgs)

        Protected Overrides Sub CreateChildControls()
            CrearControles()
            Controls.Clear()
            Controls.Add(cmbCombo)
        End Sub

        Friend Function CrearControles()
            cmbCombo.DataSource = _datasource
            cmbCombo.DataBind()
        End Function

        Public Sub New()
            _datasource = System.Drawing.Printing.PrinterSettings.InstalledPrinters()
        End Sub
    End Class

    Public Class LoadPrinters
        Inherits System.Web.UI.Design.ControlDesigner

        Public Overrides Function GetDesignTimeHtml() As String
            Dim ctl As cmbPrinter = CType(Me.Component, cmbPrinter)

            Dim cmbPrint As New System.Web.UI.WebControls.DropDownList
            Dim sw As New System.IO.StringWriter
            Dim tw As New System.Web.UI.HtmlTextWriter(sw)

            ' muestro el control en diseño
            With cmbPrint
                .DataSource = ctl._datasource
                .RenderControl(tw)
            End With

            Return sw.ToString
        End Function
    End Class
End Namespace
