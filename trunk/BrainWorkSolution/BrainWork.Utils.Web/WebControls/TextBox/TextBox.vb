Imports BrainWork.Entities
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Namespace WebControls
    <Serializable()> _
    <DefaultProperty("Text"), ToolboxData("<{0}:CustomTextBox runat=server></{0}:CustomTextBox>")> _
    <ValidationProperty("Text")> _
    Public Class CustomTextBox : Inherits BrainWork.Utils.Web.AbstractControl
        Implements System.Web.UI.WebControls.IPostBackContainer
        Implements System.Web.UI.IValidator
        Implements System.Web.UI.IPostBackDataHandler
        Implements System.Web.UI.IPostBackEventHandler



        Implements BrainWork.Entities.Interfaces.IEntityFieldExtendsAttribute

        Private _DefaultValue As String
        Private _ForeingTable As String
        Private _IsForeingKey As Boolean
        Private _FieldType As Entities.EnumFieldType
        Private _FieldName As String
        Private _FieldDescription As String
        Private _MainTable As String
        Private _Constraint As String
        Private _DbType As System.Data.DbType
        Private _Direction As System.Data.ParameterDirection
        Private _IsNullable As Boolean
        Private _ParameterName As String
        Private _SourceColumn As String
        Private _SourceVersion As System.Data.DataRowVersion
        Private _Value As Object
        Private _Precision As Byte
        Private _Scale As Byte
        Private _Size As Integer
        Private _EntityClassContainer As String
        Private _TypeName As String
         

        Private _CustomValidationExpression As String
        Private _ForeingCRUD As String
        Private _Order As Integer
        Private _RelationType As EnumRelationType
        Private _Visibility As EnumVisibility
        Private _MaxValue As Double
        Private _MinValue As Double
        Private _IsDescription As Boolean

        Private _ForeingFieldName As String
        Private _DefaultOrderBy As Boolean
        Private _IsEnableField As Boolean
        Private _PropertyName As String
        Private _LabelText As String



        Public Property PropertyName() As String Implements Interfaces.IEntityFieldExtendsAttribute.PropertyName
            Get
                Return _PropertyName
            End Get
            Set(ByVal value As String)
                _PropertyName = value
            End Set
        End Property


        Public Property IsEnableField() As Boolean Implements Interfaces.IEntityFieldExtendsAttribute.IsEnableField
            Get
                Return _IsEnableField
            End Get
            Set(ByVal value As Boolean)
                _IsEnableField = value
            End Set
        End Property
        Public Property MaxValue() As Double Implements Interfaces.IEntityFieldExtendsAttribute.MaxValue
            Get
                Return _MaxValue
            End Get
            Set(ByVal value As Double)
                _MaxValue = value
            End Set
        End Property

        Public Property MinValue() As Double Implements Interfaces.IEntityFieldExtendsAttribute.MinValue
            Get
                Return _MinValue
            End Get
            Set(ByVal value As Double)
                _MinValue = value
            End Set
        End Property

        Public Property EntityClassContainer() As String Implements Interfaces.IEntityFieldExtendsAttribute.EntityClassContainer
            Get
                Return _EntityClassContainer
            End Get
            Set(ByVal value As String)
                _EntityClassContainer = value
            End Set
        End Property

        Public Property FieldName() As String Implements Interfaces.IEntityFieldExtendsAttribute.FieldName
            Get
                Return _FieldName
            End Get
            Set(ByVal value As String)
                _FieldName = value
            End Set
        End Property

        Public Property FieldDescription() As String Implements Interfaces.IEntityFieldExtendsAttribute.FieldDescription

            Get
                Return _FieldDescription
            End Get
            Set(ByVal value As String)
                _FieldDescription = value
            End Set
        End Property

        Public Property FieldType() As EnumFieldType Implements Interfaces.IEntityFieldExtendsAttribute.FieldType
            Get
                Return _FieldType
            End Get
            Set(ByVal value As EnumFieldType)
                _FieldType = value
            End Set
        End Property

        Public Property ForeingTable() As String Implements Interfaces.IEntityFieldExtendsAttribute.ForeingTable
            Get
                Return _ForeingTable
            End Get
            Set(ByVal value As String)
                _ForeingTable = value
            End Set
        End Property

        Public Property DefaultValue() As String Implements Interfaces.IEntityFieldExtendsAttribute.DefaultValue
            Get
                Return _DefaultValue
            End Get
            Set(ByVal value As String)
                _DefaultValue = value
            End Set
        End Property

        Public Property MainTable() As String Implements Interfaces.IEntityFieldExtendsAttribute.MainTable
            Get
                Return _MainTable
            End Get
            Set(ByVal value As String)
                _MainTable = value
            End Set
        End Property

        Private Property Constraint() As String Implements Interfaces.IEntityFieldExtendsAttribute.Constraint
            Get
                Return _Constraint
            End Get
            Set(ByVal value As String)
                _Constraint = value
            End Set
        End Property


        Public Property DbType() As System.Data.DbType Implements System.Data.IDataParameter.DbType
            Get
                Return _DbType
            End Get
            Set(ByVal value As System.Data.DbType)
                _DbType = value
            End Set
        End Property

        Public Property Direction() As System.Data.ParameterDirection Implements System.Data.IDataParameter.Direction
            Get
                Return _Direction
            End Get
            Set(ByVal value As System.Data.ParameterDirection)
                _Direction = value
            End Set
        End Property

        Public ReadOnly Property IsNullable() As Boolean Implements System.Data.IDataParameter.IsNullable
            Get
                Return _IsNullable
            End Get
        End Property

        Public Property ParameterName() As String Implements System.Data.IDataParameter.ParameterName
            Get
                Return _ParameterName
            End Get
            Set(ByVal value As String)
                _ParameterName = value
            End Set
        End Property

        Public Property SourceColumn() As String Implements System.Data.IDataParameter.SourceColumn
            Get
                Return _SourceColumn
            End Get
            Set(ByVal value As String)
                _SourceColumn = value
            End Set
        End Property

        Public Property SourceVersion() As System.Data.DataRowVersion Implements System.Data.IDataParameter.SourceVersion
            Get
                Return _SourceVersion
            End Get
            Set(ByVal value As System.Data.DataRowVersion)
                _SourceVersion = value
            End Set
        End Property

        Public Property Value() As Object Implements System.Data.IDataParameter.Value
            Get
                Return _Value
            End Get
            Set(ByVal values As Object)
                _Value = values
            End Set
        End Property

        Public Property Precision() As Byte Implements System.Data.IDbDataParameter.Precision
            Get
                Return _Precision
            End Get
            Set(ByVal value As Byte)
                _Precision = value
            End Set
        End Property

        Public Property Scale() As Byte Implements System.Data.IDbDataParameter.Scale
            Get
                Return _Scale
            End Get
            Set(ByVal value As Byte)
                _Scale = value
            End Set
        End Property

        Public Property Size() As Integer Implements System.Data.IDbDataParameter.Size
            Get
                Return _Size
            End Get
            Set(ByVal value As Integer)
                _Size = value
            End Set
        End Property


        Public Property CustomValidationExpression() As String Implements Interfaces.IEntityFieldExtendsAttribute.CustomValidationExpression
            Get
                Return _CustomValidationExpression
            End Get
            Set(ByVal value As String)

            End Set
        End Property

        Public Property ForeingCRUD() As String Implements Interfaces.IEntityFieldExtendsAttribute.ForeingCRUD
            Get
                Return _ForeingCRUD
            End Get
            Set(ByVal value As String)
                _ForeingCRUD = value
            End Set
        End Property

        Public Property Order() As Integer Implements Interfaces.IEntityFieldExtendsAttribute.Order
            Get
                Return _Order
            End Get
            Set(ByVal value As Integer)
                _Order = value
            End Set
        End Property

        Public Property RelationType() As EnumRelationType Implements Interfaces.IEntityFieldExtendsAttribute.RelationType
            Get
                Return _RelationType
            End Get
            Set(ByVal value As EnumRelationType)
                _RelationType = value
            End Set
        End Property

        Public Property Visibility() As EnumVisibility Implements Interfaces.IEntityFieldExtendsAttribute.Visibility
            Get
                Return _Visibility
            End Get
            Set(ByVal value As EnumVisibility)
                _Visibility = value
            End Set
        End Property

        Public Property TypeName() As String Implements Interfaces.IEntityFieldExtendsAttribute.TypeName
            Get
                Return _TypeName
            End Get
            Set(ByVal value As String)
                _TypeName = value
            End Set
        End Property


        Public Property IsDescription() As Boolean Implements Entities.Interfaces.IEntityFieldExtendsAttribute.IsDescription
            Get
                Return _IsDescription
            End Get
            Set(ByVal value As Boolean)
                _IsDescription = value
            End Set
        End Property

        Public Property ForeingFieldName() As String Implements Entities.Interfaces.IEntityFieldExtendsAttribute.ForeingFieldName
            Get
                Return _ForeingFieldName
            End Get
            Set(ByVal value As String)
                _ForeingFieldName = value
            End Set
        End Property


        Public Property DefaultOrderBy() As Boolean Implements Entities.Interfaces.IEntityFieldExtendsAttribute.IsDefaultOrderBy
            Get
                Return _DefaultOrderBy
            End Get
            Set(ByVal value As Boolean)
                _DefaultOrderBy = value
            End Set
        End Property




        '<Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property LabelText() As String
        '    Get

        '        If _LabelText Is Nothing Then
        '            Return String.Empty
        '        Else
        '            Return _LabelText
        '        End If
        '    End Get

        '    Set(ByVal Value As String)
        '        _LabelText = Value
        '    End Set
        'End Property
        '
        


        Private _AddTDTag As Boolean = True
        <Bindable(True), Category("Appearance"), DefaultValue("True"), Localizable(True)> Public Property AddTDTag() As Boolean
            Get
                Return _AddTDTag
            End Get
            Set(ByVal value As Boolean)
                _AddTDTag = value
            End Set
        End Property
        '



        <Bindable(True), Category("Appearance"), DefaultValue("EntityClass"), Localizable(True)> Property EntityClass() As Object
            Get

                ' Dim s As BrainWork.Entities.EntityFieldExtendsAttribute = TryCast(ViewState("_EntityClass"), BrainWork.Entities.EntityFieldExtendsAttribute)
                'If ViewState("_EntityClass") Is Nothing Then
                '    ' Dim p As Object = Activator.CreateInstance(System.Type.GetType(Me.PropertyName, False, True))
                '    Dim p As Object = Activator.CreateInstance(System.Type.GetType("BrainWork.Entities.AbstractEntityBase", False, True))
                '    Return p
                'End If


                Return ViewState("_EntityClass")


            End Get
            Set(ByVal value As Object)
                ViewState("_EntityClass") = value
                'ViewState("_EntityClass") = CType(value, BrainWork.Entities.EntityFieldExtendsAttribute)
                'If Not value Is Nothing Then

                '    Dim newVal As BrainWork.Entities.EntityFieldExtendsAttribute
                '    newVal = CType(value, BrainWork.Entities.AbstractEntityBase).

                '    For Each entidadOrigen As Reflection.PropertyInfo In newVal.GetType.GetProperties()
                '        If entidadOrigen.CanRead Then

                '            'Select Case entidadOrigen.Name.ToLower
                '            '    Case "DefaultValue".ToLower
                '            '        Me.DefaultValue = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "ForeingTable".ToLower
                '            '        Me.ForeingTable = entidadOrigen.GetValue(value, Nothing)
                '            '        'Case "IsForeingKey".ToLower
                '            '        '    Me.FieldType = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "FieldType".ToLower
                '            '        Me.FieldType = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "FieldName".ToLower
                '            '        Me.FieldName = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "FieldDescription".ToLower
                '            '        Me.FieldDescription = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "MainTable".ToLower
                '            '        Me.MainTable = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Constraint".ToLower
                '            '        Me.Constraint = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "DbType".ToLower
                '            '        Me.DbType = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Direction".ToLower
                '            '        Me.Direction = entidadOrigen.GetValue(value, Nothing)
                '            '        'Case "IsNullable".ToLower
                '            '        '    Me.IsNullable = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "ParameterName".ToLower
                '            '        Me.ParameterName = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "SourceColumn".ToLower
                '            '        Me.SourceColumn = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "SourceVersion".ToLower
                '            '        Me.SourceVersion = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Value".ToLower
                '            '        Me.Value = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Precision".ToLower
                '            '        Me.Precision = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Scale".ToLower
                '            '        Me.Scale = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Size".ToLower
                '            '        Me.Size = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "TypeName".ToLower
                '            '        Me.TypeName = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "MaxValue".ToLower
                '            '        Me.MaxValue = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "MinValue".ToLower
                '            '        Me.MinValue = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "CustomValidationExpression".ToLower
                '            '        Me.CustomValidationExpression = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "ForeingCRUD".ToLower
                '            '        Me.ForeingCRUD = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Order".ToLower
                '            '        Me.Order = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "RelationType".ToLower
                '            '        Me.RelationType = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "Visibility".ToLower
                '            '        Me.Visibility = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "EntityClassContainer".ToLower
                '            '        Me.EntityClassContainer = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "IsDescription".ToLower
                '            '        Me.IsDescription = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "ForeingFieldName".ToLower
                '            '        Me.ForeingFieldName = entidadOrigen.GetValue(value, Nothing)
                '            '        'Case "IsDefaultOrderBy".ToLower
                '            '        '    Me.IsDefaultOrderBy = entidadOrigen.GetValue(value, Nothing)
                '            '    Case "PropertyName".ToLower
                '            '        Me.PropertyName = entidadOrigen.GetValue(value, Nothing)
                '            '    Case Else
                '            '        Dim s As String
                '            'End Select
                '            For Each entidadDestino As Reflection.PropertyInfo In Me.GetType.GetProperties()
                '                If entidadOrigen.Name = entidadDestino.Name Then
                '                    Dim oValue As Object = entidadOrigen.GetValue(newVal, Nothing)
                '                    entidadDestino.SetValue(Me, oValue, Nothing)
                '                    Exit For
                '                End If
                '            Next
                '        End If
                '    Next
                ' End If
            End Set
        End Property


        Public Sub RefreshValues()
            If Me.EntityClass Is Nothing Then
                Return
                Throw New Exception("No se ha declarado el valor de la entity Class")
            End If

            If Me.PropertyName Is Nothing Then
                Return
                Throw New Exception("No se ha declarado la PropertyName")
            End If


            Dim fieldAtt As BrainWork.Entities.EntityFieldExtendsAttribute
            fieldAtt = CType(Me.EntityClass, BrainWork.Entities.AbstractEntityBase).GetPropertyAttributes(Me.PropertyName)

            If fieldAtt Is Nothing Then
                Return
            End If

            For Each campoOrigen As Reflection.PropertyInfo In fieldAtt.GetType.GetProperties()
                If campoOrigen.CanRead And campoOrigen.CanWrite Then

                    For Each campoDestino As Reflection.PropertyInfo In Me.GetType.GetProperties()


                        If campoOrigen.Name = campoDestino.Name Then

                            If campoDestino.CanWrite = True Then
                                Dim oValue As Object = campoOrigen.GetValue(fieldAtt, Nothing)
                                campoDestino.SetValue(Me, oValue, Nothing)
                            End If

                            Exit For
                        End If
                    Next

                End If
            Next









        End Sub


        Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)

            renderizarControl(writer)

            'writer.Flush()


            'Dim rfv As New RequiredFieldValidator
            'rfv.ID = Me.ClientID & "_rfv"
            'rfv.ErrorMessage = "*"
            'rfv.Visible = True
            'rfv.ControlToValidate = GetControlID()
            'rfv.Display = ValidatorDisplay.Dynamic
            'rfv.EnableClientScript = True
            'rfv.Enabled = True
            'rfv.EnableTheming = True
            'rfv.EnableViewState = True
            'rfv.Text = "*"
            'rfv.ToolTip = rfv.ErrorMessage
            ''rfv.Style.Add("visibility", "hidden")
            'writer.Flush()

            'rfv.RenderControl(writer)

            ' rf = New RequiredFieldValidator
            ' rf.Display = ValidatorDisplay.Dynamic
            ' rf.ErrorMessage = "You must enter a value"

            ' rf.ControlToValidate = "txt" + intX.ToString
            'rf.EnableClientScript = True
            'rf.Enabled = True
            'rf.EnableViewState = True




            'For Each Ctrli As Control In Page.Controls
            '    If TypeOf Ctrli Is System.Web.UI.HtmlControls.HtmlForm Then
            '        Ctrli.Controls.Add(rfv)
            '    End If

            'Next

        End Sub

        '<System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
        'Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
        '    writer.Write("Custom Contents")
        '    MyBase.RenderContents(writer)
        'End Sub 'RenderContents

       

        'Private Function GetTextType() As enumTextType

        '    Select Case True
        '        Case (Me.DbType = System.Data.DbType.Currency) _
        '             OrElse (Me.DbType = System.Data.DbType.Decimal) _
        '             OrElse (Me.DbType = System.Data.DbType.Double) _
        '             OrElse (Me.DbType = System.Data.DbType.VarNumeric)
        '            Return enumTextType.DoubleType
        '        Case (Me.DbType = System.Data.DbType.Byte) _
        '                OrElse (Me.DbType = System.Data.DbType.Int16) _
        '                OrElse (Me.DbType = System.Data.DbType.Int32) _
        '                OrElse (Me.DbType = System.Data.DbType.Int64) _
        '                OrElse (Me.DbType = System.Data.DbType.UInt16) _
        '                OrElse (Me.DbType = System.Data.DbType.UInt32) _
        '                OrElse (Me.DbType = System.Data.DbType.UInt64)
        '            Return enumTextType.IntegerType

        '        Case (Me.DbType = System.Data.DbType.Date) _
        '                OrElse (Me.DbType = System.Data.DbType.DateTime) _
        '                OrElse (Me.DbType = System.Data.DbType.DateTime2) _
        '                OrElse (Me.DbType = System.Data.DbType.DateTimeOffset)
        '            Return enumTextType.DateType
        '        Case Else
        '            Return enumTextType.TextType


        '    End Select

        'End Function

        Private Function GetControlID() As String
            Return Me.ClientID & "_Value"
        End Function



        Private Sub SetTextBox()

        End Sub
        Private Sub SetControlProperties(ByVal Ctrl As Control)
            Dim mainPi As Reflection.PropertyInfo() = Me.GetType.GetProperties

            For Each pi As Reflection.PropertyInfo In Ctrl.GetType.GetProperties()
                If pi.CanWrite AndAlso pi.CanRead Then
                    For i As Integer = 0 To mainPi.Length - 1
                        If mainPi(i).Name = pi.Name Then
                            Dim o As Object = mainPi(i).GetValue(Me, Nothing)
                            pi.SetValue(Ctrl, o, Nothing)
                        End If
                    Next
                End If
            Next


        End Sub

        Private Sub CreateTextBox(ByRef writer As HtmlTextWriter)

            Select Case GetTextType(Me.DbType)

                Case enumTextType.IntegerType
                    Dim Ctrl As New TextBox
                    SetControlProperties(Ctrl)
                    SetNumericInteger(Ctrl)
                    Ctrl.ID = GetControlID()
                    Ctrl.Text = Me.Text
                    Ctrl.CausesValidation = True
                    Ctrl.CssClass = Me.CssClass
                    Ctrl.Attributes.Add("OnFocus", Me.OnFocus)
                    Ctrl.Attributes.Add("OnBlur", Me.OnBlur)
                    Ctrl.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    Ctrl.RenderControl(writer)

                Case enumTextType.DoubleType
                    Dim Ctrl As New TextBox
                    SetControlProperties(Ctrl)
                    SetNumericDouble(Ctrl)
                    Ctrl.ID = GetControlID()
                    Ctrl.Text = Me.Text
                    Ctrl.CausesValidation = True
                    Ctrl.CssClass = Me.CssClass
                    Ctrl.Attributes.Add("OnFocus", Me.OnFocus)
                    Ctrl.Attributes.Add("OnBlur", Me.OnBlur)
                    Ctrl.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    Ctrl.RenderControl(writer)

                Case enumTextType.MultilineType
                    Dim Ctrl As New TextBox
                    SetControlProperties(Ctrl)
                    ' SetNumericDouble(Ctrl)
                    Ctrl.ID = GetControlID()
                    Ctrl.Text = Me.Text
                    Ctrl.CausesValidation = True
                    Ctrl.CssClass = Me.CssClass
                    Ctrl.Attributes.Add("OnFocus", Me.OnFocus)
                    Ctrl.Attributes.Add("OnBlur", Me.OnBlur)
                    Ctrl.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    Ctrl.RenderControl(writer)
                Case enumTextType.TextType
                    Dim Ctrl As New TextBox
                    SetControlProperties(Ctrl)
                    ' SetNumericDouble(Ctrl)
                    Ctrl.ID = GetControlID()
                    Ctrl.Text = Me.Text
                    Ctrl.CausesValidation = True
                    Ctrl.CssClass = Me.CssClass
                    Me.OnFocus = "this.className = '" & Me.CssClassOnFocus & "'"
                    Me.OnBlur = "this.className = '" & Me.CssClass & "'"

                    Ctrl.Attributes.Add("OnFocus", Me.OnFocus)
                    Ctrl.Attributes.Add("OnBlur", Me.OnBlur)
                    Ctrl.Attributes.Add("OnKeyPress", Me.OnKeyPress)
                    Ctrl.RenderControl(writer)

                Case enumTextType.DateType
                    Dim Ctrl As New BrainWork.Utils.Web.Calendar(Me.Page, GetControlID())
                    'SetControlProperties(Ctrl)

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
            End Select








            ''<object  
            'writer.WriteBeginTag("input")

            ''classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" 
            'writer.WriteAttribute("type", "text")

            'writer.WriteAttribute("class", Me.CssClass)

            'writer.WriteAttribute("id", Me.ClientID & "_Value")

            'writer.WriteAttribute("value", Me.Text)

            'AppendOnBlur(writer)

            'writer.Write(System.Web.UI.HtmlTextWriter.SelfClosingTagEnd)

        End Sub

        Private Sub CreateComboBox(ByRef writer As HtmlTextWriter)

        End Sub

        Private Sub CreatePopUp(ByRef writer As HtmlTextWriter)

        End Sub


        Private Sub AppendOnBlur(ByRef writer As HtmlTextWriter)

            If Me.OnBlur.Count > 0 Then
                Dim sb As New System.Text.StringBuilder()
                For Each att As String In Me.OnBlur
                    If Not att.Trim.EndsWith(";") Then att += ";"
                    sb.Append(att)
                Next
                writer.WriteAttribute("onblur", sb.ToString)
            End If
        End Sub


        Private Sub renderizarControl(ByRef writer As HtmlTextWriter)
            If AddTDTag Then
                writer.WriteBeginTag("TD")
                writer.WriteAttribute("aling", "right")
                writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            End If
            writer.WriteBeginTag("span")
            writer.WriteAttribute("id", Me.ClientID & "_Label")
            writer.WriteAttribute("class", Me.CssClassLabel)

            If Not String.IsNullOrEmpty(Me.FieldDescription) Then
                BrainWork.Utils.Web.JavaScript.JavaScriptUtils.JS_ToolTip(Me.Page, Me.GetType)
                writer.WriteAttribute("onMouseover", "ddrivetip('" & Me.FieldDescription.Replace("'"c, "").Replace(""""c, "") & "','#FFFFE0', 300);")
                writer.WriteAttribute("onMouseout", "hideddrivetip();")
            End If

            writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)

            If Not String.IsNullOrEmpty(Me.Label) Then
                writer.WriteEncodedText(Me.Label & "  ")
            Else
                writer.WriteEncodedText(Me.FieldName & "___________________________  ")

            End If

            writer.WriteEndTag("span")
            If AddTDTag Then
                writer.WriteEndTag("TD")
            End If

            If AddTDTag Then
                writer.WriteBeginTag("TD")
                writer.WriteAttribute("aling", "left")
                writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)
            End If

            Select Case Me.RelationType
                Case EnumRelationType.Combo
                    Me.CreatePopUp(writer)
                Case EnumRelationType.Embebed

                Case EnumRelationType.PopUp
                    Me.CreatePopUp(writer)

                Case Else
                    Me.CreateTextBox(writer)
            End Select


            If AddTDTag Then
                writer.WriteEndTag("TD")
            End If

            'writer.Write(System.Web.UI.HtmlTextWriter.TagRightChar)

            '


            ''<param name="movie" value="http://localhost:1939/WebSite/ChartItems/FC_2_3_MSColumn3D.swf" />
            'writer.WriteBeginTag("param")
            'writer.WriteAttribute("name", "movie")
            'writer.WriteAttribute("value", Me.ParamSWFLoaction)
            'writer.Write(System.Web.UI.HtmlTextWriter.SelfClosingTagEnd)


            ''<param name="FlashVars" value="&dataXML=Data_.xml&chartWidth=900&chartHeight=300" />
            'writer.WriteBeginTag("param")
            'writer.WriteAttribute("name", "FlashVars")
            'writer.WriteAttribute("value", flashVars)
            'writer.Write(System.Web.UI.HtmlTextWriter.SelfClosingTagEnd)

            ''<param name="quality" value="high" />
            'writer.WriteBeginTag("param")
            'writer.WriteAttribute("name", "quality")
            'writer.WriteAttribute("value", Me.Quality)
            'writer.Write(System.Web.UI.HtmlTextWriter.SelfClosingTagEnd)





            '</object>
            'writer.WriteEndTag("object")

        End Sub

        Public Sub SetValues(ByVal oEntity As BrainWork.Entities.Interfaces.IEntityFieldExtendsAttribute)
            Me._Constraint = oEntity.Constraint
            Me._DbType = oEntity.DbType
            Me._DefaultValue = oEntity.DefaultValue
            Me._Direction = oEntity.Direction
            Me._FieldDescription = oEntity.FieldDescription
            Me._FieldName = oEntity.FieldName
            Me._FieldType = oEntity.FieldType
            Me._ForeingTable = oEntity.ForeingTable
            Me._IsNullable = oEntity.IsNullable
            Me._MainTable = oEntity.MainTable
            Me._ParameterName = oEntity.ParameterName
            Me._Precision = oEntity.Precision
            Me._Scale = oEntity.Scale
            Me._Size = oEntity.Size
            Me._SourceColumn = oEntity.SourceColumn
            Me._SourceVersion = oEntity.SourceVersion
            Me._Value = oEntity.Value

            If Not String.IsNullOrEmpty(Me.Value) Then
                Me.Text = Me.Value
            ElseIf Not String.IsNullOrEmpty(Me.DefaultValue) Then
                Me.Text = Me.DefaultValue
            End If

        End Sub

        Private Sub CustomTextBox_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        End Sub

        Private Sub CustomTextBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.Page.IsPostBack Then
                If Not System.Web.HttpContext.Current.Request.Form(GetControlID) Is Nothing Then
                    Me.Text = System.Web.HttpContext.Current.Request.Form(GetControlID)
                End If
            End If
        End Sub



        Private Sub CustomTextBox_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender


        End Sub

        Public Sub New()

        End Sub

        Public Function GetPostBackOptions(ByVal buttonControl As System.Web.UI.WebControls.IButtonControl) As System.Web.UI.PostBackOptions Implements System.Web.UI.WebControls.IPostBackContainer.GetPostBackOptions

        End Function

        Private _ErrorMessage As String = ""
        Public Property ErrorMessage() As String Implements System.Web.UI.IValidator.ErrorMessage
            Get
                Return _ErrorMessage
            End Get
            Set(ByVal value As String)
                _ErrorMessage = value
            End Set
        End Property

        Private _IsValid As Boolean = True
        Public Property IsValid() As Boolean Implements System.Web.UI.IValidator.IsValid
            Get
                Return _IsValid
            End Get
            Set(ByVal value As Boolean)
                _IsValid = value
            End Set
        End Property

        Public Sub Validate() Implements System.Web.UI.IValidator.Validate

        End Sub

        Public Event TextChanged As EventHandler


        Public Function LoadPostData(ByVal postDataKey As String, ByVal postCollection As System.Collections.Specialized.NameValueCollection) As Boolean Implements System.Web.UI.IPostBackDataHandler.LoadPostData
            Dim presentValue As String = Text
            Dim postedValue As String = postCollection(postDataKey)

            If presentValue Is Nothing Or Not presentValue.Equals(postedValue) Then
                Text = postedValue
                Return True
            End If

            Return False

        End Function


        Protected Overridable Sub OnTextChanged(ByVal e As EventArgs)
            RaiseEvent TextChanged(Me, e)
        End Sub



        Public Overridable Shadows Sub RaisePostDataChangedEvent() Implements System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent
            OnTextChanged(EventArgs.Empty)
        End Sub

        Public Sub RaisePostBackEvent(ByVal eventArgument As String) Implements System.Web.UI.IPostBackEventHandler.RaisePostBackEvent

        End Sub
        Private _label As String
        Public Property Label() As String Implements Entities.Interfaces.IEntityFieldExtendsAttribute.Label
            Get
                If _label Is Nothing Then
                    Return PropertyName
                Else
                    Return _label
                End If
            End Get
            Set(ByVal value As String)
                _label = value
            End Set
        End Property
    End Class
End Namespace

