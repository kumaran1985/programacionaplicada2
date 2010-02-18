Imports BrainWork.Entities
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Public Class AbstractControl : Inherits System.Web.UI.WebControls.WebControl
    Private _OnBlur As String = ""

    Public Enum enumTextType
        IntegerType
        DoubleType
        TextType
        MultilineType
        DateType
    End Enum

    Public Function GetTextType(ByVal dtype As DbType) As enumTextType

        Select Case True
            Case dtype = System.Data.DbType.Currency _
                 OrElse (dtype = System.Data.DbType.Decimal) _
                 OrElse (dtype = System.Data.DbType.Double) _
                 OrElse (dtype = System.Data.DbType.VarNumeric)
                Return enumTextType.DoubleType
            Case dtype = System.Data.DbType.Byte _
                    OrElse (dtype = System.Data.DbType.Int16) _
                    OrElse (dtype = System.Data.DbType.Int32) _
                    OrElse (dtype = System.Data.DbType.Int64) _
                    OrElse (dtype = System.Data.DbType.UInt16) _
                    OrElse (dtype = System.Data.DbType.UInt32) _
                    OrElse (dtype = System.Data.DbType.UInt64)
                Return enumTextType.IntegerType

            Case dtype = System.Data.DbType.Date _
                    OrElse (dtype = System.Data.DbType.DateTime) _
                    OrElse (dtype = System.Data.DbType.DateTime2) _
                    OrElse (dtype = System.Data.DbType.DateTimeOffset)
                Return enumTextType.DateType
            Case Else
                Return enumTextType.TextType 
        End Select
    End Function

    <Bindable(True), Category("Appearance"), DefaultValue("CustomTextBox"), Localizable(True)> Overrides Property CssClass() As String
        Get
            Dim s As String = TryCast(ViewState("_CustomTextBox"), String)
            If s Is Nothing Then
                Return "CustomTextBox"
            Else
                Return s
            End If
        End Get
        Set(ByVal value As String)
            ViewState("_CustomTextBox") = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue("CustomTextBoxOnFocus"), Localizable(True)> Property CssClassOnFocus() As String
        Get
            Dim s As String = TryCast(ViewState("_CustomTextBoxOnFocus"), String)
            If s Is Nothing Then
                Return "CustomTextBoxOnFocus"
            Else
                Return s
            End If
        End Get
        Set(ByVal value As String)
            ViewState("_CustomTextBoxOnFocus") = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue("CustomTextBoxNumeric"), Localizable(True)> Property CssClassNumeric() As String
        Get
            Dim s As String = TryCast(ViewState("_CustomTextBoxNumeric"), String)
            If s Is Nothing Then
                Return "CustomTextBoxNumeric"
            Else
                Return s
            End If
        End Get
        Set(ByVal value As String)
            ViewState("_CustomTextBoxNumeric") = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue("CustomTextBoxLabel"), Localizable(True)> Property CssClassLabel() As String
        Get
            Dim s As String = TryCast(ViewState("_CustomTextBoxLabel"), String)
            If s Is Nothing Then
                Return "CustomTextBoxLabel"
            Else
                Return s
            End If
        End Get
        Set(ByVal value As String)
            ViewState("_CustomTextBoxLabel") = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue("CssClassCalendar"), Localizable(True)> Property CssClassCalendar() As String
        Get
            Dim s As String = TryCast(ViewState("_CssClassCalendar"), String)
            If s Is Nothing Then
                Return "CssClassCalendar"
            Else
                Return s
            End If
        End Get
        Set(ByVal value As String)
            ViewState("_CssClassCalendar") = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue("CssClassButton"), Localizable(True)> Property CssClassButton() As String
        Get
            Dim s As String = TryCast(ViewState("_CssClassButton"), String)
            If s Is Nothing Then
                Return "_CssClassButton"
            Else
                Return s
            End If
        End Get
        Set(ByVal value As String)
            ViewState("_CssClassButton") = value
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property Text() As String
        Get
            Dim s As String = CStr(ViewState("Text"))
            If s Is Nothing Then
                Return String.Empty
            Else
                Return s
            End If
        End Get

        Set(ByVal Value As String)
            ViewState("Text") = Value
        End Set
    End Property

    Dim _OnKeyPress As String = ""
    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property OnKeyPress() As String

        Get
            If Me._OnKeyPress Is Nothing Then
                Me._OnKeyPress = ""
            End If
            Return Me._OnKeyPress
        End Get
        Set(ByVal value As String)
            Me._OnKeyPress += value & ";"
        End Set
    End Property

    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property OnBlur() As String

        Get
            If Me._OnBlur Is Nothing Then
                Me._OnBlur = ""
            End If
            Return Me._OnBlur
        End Get
        Set(ByVal value As String)
            Me._OnBlur += value & ";"
        End Set
    End Property


    Private _OnFocus As String = ""
    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property OnFocus() As String
        Get
            If Me._OnFocus Is Nothing Then
                Me._OnFocus = ""
            End If
            Return Me._OnFocus
        End Get
        Set(ByVal value As String)
            Me._OnFocus += value & ";"
        End Set
    End Property

    Public Sub SetNumericInteger(ByRef ctrl As TextBox)
        Me.OnFocus = "this.select()"
        Me.OnFocus = "this.className = '" & Me.CssClassOnFocus & "'"
        Me.OnBlur = "this.className = '" & Me.CssClassNumeric & "'"
        Me.CssClass = CssClassNumeric

        Dim sb As New System.Text.StringBuilder

        sb.Append("	if(num=='')")
        sb.Append("	{")
        sb.Append("		alert('Número Inválido');	this.focus();	this.select(); return false;	")
        sb.Append("	}")
        sb.Append("	if(isNaN(num))")
        sb.Append("	{")
        sb.Append("		alert('Número Inválido');	this.focus();	this.select(); return false;")
        sb.Append("	}")
        sb.Append("	else")
        sb.Append("	{")
        sb.Append("				if(num.indexOf(',')>-1)")
        sb.Append("				{")
        sb.Append("					alert('Número Inválido');	this.focus();	this.select(); return false;")
        sb.Append("				}")
        sb.Append("				if(num.indexOf('.')>-1)")
        sb.Append("				{")
        sb.Append("					alert('Número Inválido');	this.focus();	this.select(); return false;")
        sb.Append("				}")
        sb.Append("	}")
        sb.Append("	this.value=Number(this.value);return true;")

        Me.OnBlur = "if(this.value!=''){if(isNaN(this.value)){this.focus();this.select();}else{this.value=Number(this.value)}}"

        sb = New System.Text.StringBuilder

        sb.Append(" try")
        sb.Append(" {")
        sb.Append("     isNetscape = (document.layers);")
        sb.Append("     eventChooser = (isNetscape) ? keyStroke.which : event.keyCode;")
        sb.Append("     if(((eventChooser < 48)||(eventChooser > 57)))")
        sb.Append("     {")
        sb.Append("         if(isNetscape)")
        sb.Append("         {")
        sb.Append("             keyStroke.which = 0;")
        sb.Append("         }")
        sb.Append("         else")
        sb.Append("         {")
        sb.Append("             event.keyCode = 0;")
        sb.Append("         }")
        sb.Append("     }")
        sb.Append(" }")
        sb.Append(" catch(e){}")

        Me.OnKeyPress = sb.ToString()
    End Sub

    Public Sub SetCalendar(ByRef Ctrl As BrainWork.Utils.Web.Calendar)
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
    End Sub

    Public Sub SetNumericDouble(ByRef ctrl As TextBox)
        Me.OnFocus = "this.select()"
        Me.OnFocus = "this.className = '" & Me.CssClassOnFocus & "'"
        Me.OnBlur = "this.className = '" & Me.CssClassNumeric & "'"

        Dim sb As New System.Text.StringBuilder
        sb.Append("	if(num=='')")
        sb.Append("	{")
        sb.Append("		alert('Número Inválido');	this.focus();	this.select(); return false;	")
        sb.Append("	}")
        sb.Append("	if(isNaN(num))")
        sb.Append("	{")
        sb.Append("		alert('Número Inválido');	this.focus();	this.select(); return false;")
        sb.Append("	}")
        sb.Append("	else")
        sb.Append("	{")
        sb.Append("				if(num.indexOf(',')>-1)")
        sb.Append("				{")
        sb.Append("					alert('Número Inválido');	this.focus();	this.select(); return false;")
        sb.Append("				}")
        sb.Append("				if(num.indexOf('.')>-1)")
        sb.Append("				{")
        sb.Append("					alert('Número Inválido');	this.focus();	this.select(); return false;")
        sb.Append("				}")
        sb.Append("	}")
        sb.Append("	this.value=Number(this.value);return true;")

        Me.OnBlur = "if(this.value!=''){if(isNaN(this.value)){this.focus();this.select();}else{this.value=Number(this.value)}}"

        sb = New System.Text.StringBuilder

        sb.Append(" try")
        sb.Append(" {")
        sb.Append("     isNetscape = (document.layers);")
        sb.Append("     eventChooser = (isNetscape) ? keyStroke.which : event.keyCode;")
        sb.Append("     if(eventChooser != 46)")
        sb.Append("     {")
        sb.Append("         if(((eventChooser < 48)||(eventChooser > 57)))")
        sb.Append("         {")
        sb.Append("             if(isNetscape)")
        sb.Append("             {")
        sb.Append("                 keyStroke.which = 0;")
        sb.Append("             }")
        sb.Append("             else")
        sb.Append("             {")
        sb.Append("                 event.keyCode = 0;")
        sb.Append("             }")
        sb.Append("         }")
        sb.Append("     }")
        sb.Append(" }")
        sb.Append(" catch(e){}")

        Me.OnKeyPress = sb.ToString()
    End Sub
End Class
