Imports System.ComponentModel
Imports System.Web.UI

Namespace WebControls.Data
    <DefaultProperty("PageSize"), ToolboxData("<{0}:SearchControl runat=server></{0}:SearchControl>")> _
    Public Class SearchControl : Inherits BrainWork.Utils.Web.AbstractControl

        Private WithEvents btnSearch As System.Web.UI.WebControls.Button
        Private WithEvents cmbFields As System.Web.UI.WebControls.DropDownList

        Public Property ClientIDGrid() As String
            Get
                Return TryCast(ViewState(Me.ClientID & "_ClientIdGrid"), String)
            End Get
            Set(ByVal value As String)
                ViewState(Me.ClientID & "_ClientIdGrid") = value
            End Set
        End Property

        Private _Entity As Object
        Public Property Entity() As Object
            Get
                Return _Entity
            End Get
            Set(ByVal value As Object)
                _Entity = value
            End Set
        End Property

        Public ReadOnly Property CurrentFilters() As Dictionary(Of String, String)
            Get
                If ViewState(Me.ClientID & "_CurrentFilters") Is Nothing Then
                    ViewState(Me.ClientID & "_CurrentFilters") = New Dictionary(Of String, String)
                End If
                Return TryCast(ViewState(Me.ClientID & "_CurrentFilters"), Dictionary(Of String, String))
            End Get
        End Property

        Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
            renderizarControl(writer)
        End Sub


        Private SelectedPropertyName As String = ""

        Private Function GetControlSearchType() As enumTextType
            If Me.Entity Is Nothing Then
                Return enumTextType.TextType
            ElseIf SelectedPropertyName.Trim.Length > 0 Then
                Dim eField As BrainWork.Entities.EntityFieldExtendsAttribute
                eField = CType(Me.Entity, BrainWork.Entities.AbstractEntityBase).GetPropertyAttributes(SelectedPropertyName)
                Return Me.GetTextType(eField.DbType)
            Else
                SelectedPropertyName = CType(Me.Entity, BrainWork.Entities.AbstractEntityBase).ExtendedClassAttributes.PrimaryKeyPropertyName
                Dim eField As BrainWork.Entities.EntityFieldExtendsAttribute
                eField = CType(Me.Entity, BrainWork.Entities.AbstractEntityBase).GetPropertyAttributes(SelectedPropertyName)

                Return Me.GetTextType(eField.DbType)
            End If

        End Function

        Private Sub renderizarControl(ByRef writer As HtmlTextWriter)
            If Not Me.Page.IsPostBack Then
                SelectedPropertyName = CType(Me.Entity, BrainWork.Entities.AbstractEntityBase).ExtendedClassAttributes.PrimaryKeyPropertyName
            End If
            writer.WriteBeginTag("table")
            writer.WriteAttribute("cellpadding", "0")
            writer.WriteAttribute("cellspacing", "0")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)

            'tr---------------------------
            writer.WriteBeginTag("tr")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)



            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "left")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            Dim lbl As New System.Web.UI.WebControls.Label
            lbl.Text = "Buscar Por: "
            lbl.ID = Me.ID & "_lbl"
            lbl.CssClass = Me.CssClassLabel
            lbl.RenderControl(writer)
            writer.WriteEndTag("td")
            '-------------/td---------------------------


            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "left")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            cmbFields = New System.Web.UI.WebControls.DropDownList
            cmbFields.AutoPostBack = True
            cmbFields.ID = Me.ID & "_cmbFields"
            cmbFields.CssClass = Me.CssClass

            If Not Entity Is Nothing Then
                Dim ent As BrainWork.Entities.AbstractEntityBase
                ent = CType(Entity, BrainWork.Entities.AbstractEntityBase)
                Dim col As Dictionary(Of String, BrainWork.Entities.PropertysExtendedAtributtes) = ent.GetExtendedFieldsAttributes
                For Each Key As String In col.Keys
                    Dim item As New System.Web.UI.WebControls.ListItem
                    item.Value = col(Key).PropertyAttributes.FieldName
                    item.Text = col(Key).PropertyAttributes.Label
                    If Key = SelectedPropertyName Then
                        item.Selected = True
                    End If
                    cmbFields.Items.Add(item)
                Next
            End If


            'cmbFields.Attributes.Add("onFocus", "this.className ='" & Me.CssClassOnFocus & "'")
            cmbFields.Attributes.Add("onBlur", "this.className ='" & Me.CssClass & "'")
            cmbFields.Attributes.Add("onchange", "javascript:setTimeout('__doPostBack(\'" & cmbFields.ClientID & "\',\'\')', 0)")
            cmbFields.RenderControl(writer)
            writer.WriteEndTag("td")
            '-------------/td---------------------------


            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "left")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            Select Case GetControlSearchType()
                Case enumTextType.DateType
                    Dim Ctrl As New BrainWork.Utils.Web.Calendar(Me.Page, Me.ID & "_txt")
                     
                    Ctrl.Text = Me.Text
                    Ctrl.CausesValidation = True
                    Ctrl.CssClass = Me.CssClassCalendar
                    Me.OnFocus = "this.className = '" & Me.CssClassOnFocus & "'"
                    Me.OnBlur = "this.className = '" & Me.CssClass & "'"
                    Me.OnBlur = "verificarFecha(this.value,this)"
                    For Each key As String In Ctrl.Attributes.Keys
                        Select Case key.ToLower
                            Case "onfocus"
                                Me.OnFocus = Ctrl.Attributes("OnFocus")
                            Case "onblur"
                                Me.OnBlur = Ctrl.Attributes("OnBlur")
                            Case "onkeypress"
                                Me.OnKeyPress = Ctrl.Attributes("OnKeyPress")
                        End Select
                    Next
                    Ctrl.Style.Add("width", "55px")
                    Ctrl.Attributes.Add("OnFocus", Me.OnFocus)
                    Ctrl.Attributes.Add("OnBlur", Me.OnBlur)
                    Ctrl.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    Ctrl.RenderControl(writer)

                Case enumTextType.DoubleType
                    Dim ctrDbl As New System.Web.UI.WebControls.TextBox
                    SetNumericInteger(ctrDbl)
                    ctrDbl.Attributes.Add("OnFocus", Me.OnFocus)
                    ctrDbl.Attributes.Add("OnBlur", Me.OnBlur)
                    ctrDbl.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    ctrDbl.ID = Me.ID & "_txt"
                    ctrDbl.CssClass = Me.CssClass
                    ctrDbl.RenderControl(writer)

                Case enumTextType.IntegerType
                    Dim ctrInt As New System.Web.UI.WebControls.TextBox
                    SetNumericInteger(ctrInt)
                    ctrInt.Attributes.Add("OnFocus", Me.OnFocus)
                    ctrInt.Attributes.Add("OnBlur", Me.OnBlur)
                    ctrInt.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    ctrInt.ID = Me.ID & "_txt"
                    ctrInt.CssClass = Me.CssClass
                    ctrInt.RenderControl(writer)

                Case enumTextType.MultilineType
                Case enumTextType.TextType
                    Dim txtSearch As System.Web.UI.WebControls.TextBox
                    txtSearch = New System.Web.UI.WebControls.TextBox
                    txtSearch.Attributes.Add("onFocus", "this.className ='" & Me.CssClassOnFocus & "'")
                    txtSearch.Attributes.Add("onBlur", "this.className ='" & Me.CssClass & "'")
                    txtSearch.ID = Me.ID & "_txt"
                    txtSearch.CssClass = Me.CssClass
                    txtSearch.RenderControl(writer)

            End Select
            writer.WriteEndTag("td")
            '-------------/td---------------------------


           
           



            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "right")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            btnSearch = New System.Web.UI.WebControls.Button
            btnSearch.ID = Me.ID & "_btn"
            btnSearch.Text = "Buscar"
            btnSearch.CssClass = Me.CssClassButton
            btnSearch.RenderControl(writer)
            writer.WriteEndTag("td")
            '-------------/td---------------------------

            '/tr---------------------------
            writer.WriteEndTag("tr")




            'tr---------------------------
            writer.WriteBeginTag("tr")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "right")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            Dim lblCurrentFiltes As New System.Web.UI.WebControls.Label
            lblCurrentFiltes.Text = "Filtrado Por: "
            lblCurrentFiltes.ID = Me.ID & "_lblCurrentFiltes"
            lblCurrentFiltes.CssClass = Me.CssClassLabel
            lblCurrentFiltes.RenderControl(writer)
            writer.WriteEndTag("td")
            '-------------/td---------------------------

            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "right")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            Dim lblFilters As New System.Web.UI.WebControls.Label
            lblFilters.ID = Me.ID & "_lblFilters"
            lblFilters.CssClass = Me.CssClassLabel
            lblFilters.Text = " "
            For Each k As String In Me.CurrentFilters.Keys
                lblFilters.Text += k & " = " & Me.CurrentFilters(k) & ";"
            Next
            lblFilters.Text = " " & lblFilters.Text.Remove(lblFilters.Text.Length - 1, 1)

            lblFilters.RenderControl(writer)
            writer.WriteEndTag("td")
            '-------------/td---------------------------

            '-------------td---------------------------
            writer.WriteBeginTag("td")
            writer.WriteAttribute("align", "right")
            writer.WriteAttribute("colspan", "2")
            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            Dim btnClearSearch As New System.Web.UI.WebControls.Button
            btnClearSearch.ID = Me.ID & "_btnClearSearch"
            btnClearSearch.CssClass = Me.CssClassButton
            btnClearSearch.Text = "Limpiar Filtros"
            btnClearSearch.RenderControl(writer)
            writer.WriteEndTag("td")
            '-------------/td---------------------------
            '/tr---------------------------
            writer.WriteEndTag("tr")



            writer.WriteEndTag("table")




        End Sub

 

        Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        End Sub

        Private Sub SearchControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.Page.IsPostBack Then
                GetValuesFromRequest()
            End If
        End Sub

        Private Sub GetValuesFromRequest()
            If System.Web.HttpContext.Current.Request.Form(Me.ID & "_txt").Trim.Length > 0 Then
                Dim key As String = System.Web.HttpContext.Current.Request.Form(Me.ID & "_cmbFields")
                Dim value As String = System.Web.HttpContext.Current.Request.Form(Me.ID & "_txt")
                SelectedPropertyName = key
                If Me.CurrentFilters.ContainsKey(key) Then
                    Me.CurrentFilters(key) = value
                Else
                    Me.CurrentFilters.Add(key, value)
                End If


            ElseIf System.Web.HttpContext.Current.Request.Form(Me.ID & "_cmbFields").Trim.Length > 0 Then
                SelectedPropertyName = System.Web.HttpContext.Current.Request.Form(Me.ID & "_cmbFields")

            End If
        End Sub

        Public Function GetEntityFiltered()
            If Me.Page.IsPostBack Then
                GetValuesFromRequest()
            End If
            If Me.CurrentFilters.Count > 0 Then
                For Each key As String In CurrentFilters.Keys
                    Dim pi As Reflection.PropertyInfo
                    pi = Me.Entity.GetType.GetProperty(key)


                    Dim NewValue As Object = IIf(String.IsNullOrEmpty(CurrentFilters(key)), Nothing, CObj(CurrentFilters(key)))
                    If Not NewValue Is Nothing Then
                        Select Case True

                            Case pi.PropertyType.Name.ToLower.Contains("date")
                                If IsDate(NewValue) Then
                                    pi.SetValue(Me.Entity, CDate(NewValue), Nothing)
                                Else
                                    Throw New ApplicationException("Tipo de dato no valido:" & key)
                                End If

                            Case pi.PropertyType.Name.ToLower.Contains("integer") OrElse _
                                 pi.PropertyType.Name.ToLower.Contains("int32") OrElse _
                                 pi.PropertyType.Name.ToLower.Contains("int16") OrElse _
                                 pi.PropertyType.Name.ToLower.Contains("int64") OrElse _
                                 pi.PropertyType.Name.ToLower.Contains("double") OrElse _
                                 pi.PropertyType.Name.ToLower.Contains("float")

                                If IsNumeric(NewValue) Then
                                    pi.SetValue(Me.Entity, Val(NewValue), Nothing)
                                Else
                                    Throw New ApplicationException("Tipo de dato no valido" & key)
                                End If

                            Case Else
                                pi.SetValue(Me.Entity, NewValue, Nothing)


                        End Select

                    End If














                Next
            End If
            Return Entity
        End Function

        Private Sub cmbFields_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFields.SelectedIndexChanged

        End Sub
    End Class
End Namespace

