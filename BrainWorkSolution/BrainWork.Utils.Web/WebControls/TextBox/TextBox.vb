﻿Imports BrainWork.Entities
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
    Public Class CustomTextBox : Inherits System.Web.UI.WebControls.WebControl


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

        Private _OnBlur As List(Of String)

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

        <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property LabelText() As String
            Get

                If _LabelText Is Nothing Then
                    Return String.Empty
                Else
                    Return _LabelText
                End If
            End Get

            Set(ByVal Value As String)
                _LabelText = Value
            End Set
        End Property

        <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> ReadOnly Property OnBlur() As List(Of String)
            Get
                If Me._OnBlur Is Nothing Then
                    Me._OnBlur = New List(Of String)
                End If
                Return Me._OnBlur
            End Get
        End Property




        <Bindable(True), Category("Appearance"), DefaultValue("CustomTextBox"), Localizable(True)> Overrides Property CssClass() As String
            Get
                Dim s As String = TryCast(ViewState("_CssClass"), String)
                If s Is Nothing Then
                    Return "CustomTextBox"
                Else
                    Return s
                End If
            End Get
            Set(ByVal value As String)
                ViewState("_CssClass") = value
            End Set
        End Property

        <Bindable(True), Category("Appearance"), DefaultValue("CustomTextBoxLabel"), Localizable(True)> Property LabelCssClass() As String
            Get
                Dim s As String = TryCast(ViewState("_LabelCssClass"), String)
                If s Is Nothing Then
                    Return "CustomTextBoxLabel"
                Else
                    Return s
                End If
            End Get
            Set(ByVal value As String)
                ViewState("_LabelCssClass") = value
            End Set
        End Property


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

        End Sub


        Private Sub PutTextType(ByRef writer As Html32TextWriter)

            Select Case True
                Case (Me.DbType = Data.DbType.Currency) _
                     OrElse (Me.DbType = Data.DbType.Decimal) _
                     OrElse (Me.DbType = Data.DbType.Double) _
                     OrElse (Me.DbType = Data.DbType.VarNumeric)

                Case (Me.DbType = Data.DbType.Byte) _
                        OrElse (Me.DbType = Data.DbType.Int16) _
                        OrElse (Me.DbType = Data.DbType.Int32) _
                        OrElse (Me.DbType = Data.DbType.Int64) _
                        OrElse (Me.DbType = Data.DbType.UInt16) _
                        OrElse (Me.DbType = Data.DbType.UInt32) _
                        OrElse (Me.DbType = Data.DbType.UInt64)


                Case (Me.DbType = Data.DbType.Date) _
                        OrElse (Me.DbType = Data.DbType.DateTime) _
                        OrElse (Me.DbType = Data.DbType.DateTime2) _
                        OrElse (Me.DbType = Data.DbType.DateTimeOffset)

                Case Else



            End Select

        End Sub

        Private Sub CreateTextBox(ByRef writer As HtmlTextWriter)
            '<object  
            writer.WriteBeginTag("input")

            'classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" 
            writer.WriteAttribute("type", "text")

            writer.WriteAttribute("class", Me.CssClass)

            writer.WriteAttribute("id", Me.ClientID)

            AppendOnBlur(writer)

            writer.Write(System.Web.UI.HtmlTextWriter.SelfClosingTagEnd)

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

            writer.WriteBeginTag("span")
            writer.WriteAttribute("id", Me.ClientID & "_Label")
            writer.Write(System.Web.UI.HtmlTextWriter.SelfClosingTagEnd)

            If Not String.IsNullOrEmpty(Me.LabelText) Then
                writer.WriteEncodedText(Me.LabelText & "  ")
            Else
                If Not String.IsNullOrEmpty(Me.PropertyName) Then
                    Dim strToConvert As String = ""
                    Dim cv() As Char = Me.PropertyName.ToCharArray()
                    For i As Integer = 0 To cv.Length - 1
                        If i = 0 Then
                            strToConvert += UCase(cv(i))
                        Else
                            If (Char.IsUpper(cv(i))) Then
                                strToConvert += " "
                            End If
                            strToConvert += cv(i)
                        End If
                    Next
                    writer.WriteEncodedText(strToConvert & "  ")
                Else
                    writer.WriteEncodedText(Me.LabelText & "___________________________  ")
                End If
            End If

            writer.WriteEndTag("span")


            Select Case Me.RelationType
                Case EnumRelationType.Combo
                    Me.CreatePopUp(writer)
                Case EnumRelationType.Embebed

                Case EnumRelationType.PopUp
                    Me.CreatePopUp(writer)

                Case Else
                    Me.CreateTextBox(writer)
            End Select

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


         
    End Class
End Namespace

