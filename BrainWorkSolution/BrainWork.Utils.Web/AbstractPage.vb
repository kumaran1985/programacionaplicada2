Imports System.Web.UI.HtmlControls

Public Class AbstractPage
    Inherits System.Web.UI.Page
    Public Enum EnumABMLMode
        Lista
        Alta
        Baja
        Modificacion
        Reporte
    End Enum


    Protected Property Mode() As EnumABMLMode
        Get
            If ViewState("_Mode") Is Nothing Then
                ViewState("_Mode") = EnumABMLMode.Lista
            End If

            Return CType(ViewState("_Mode"), EnumABMLMode)
        End Get
        Set(ByVal value As EnumABMLMode)
            ViewState("_Mode") = value
        End Set
    End Property


    Protected Property CurrentUser() As BrainWork.Security.ApplicationUser
        Get
            Dim u As New BrainWork.Security.ApplicationUser
            u.GetUserIDentification = "jborras"
            u.SessionID = Me.Session.SessionID
            Session("_CurrentUser") = u
            Return TryCast(Session("_CurrentUser"), BrainWork.Security.ApplicationUser)
        End Get
        Set(ByVal value As BrainWork.Security.ApplicationUser)
            Session("_CurrentUser") = value
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

    Protected Sub GetEntityFromControls(ByRef Ent As Object, Optional ByVal pForm As HtmlForm = Nothing)
        If pForm Is Nothing Then
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is HtmlForm Then
                    pForm = ctrl
                End If
            Next
        End If

        For Each ctrl As System.Web.UI.Control In pForm.Controls
            If Not ctrl Is Nothing Then
                If TypeOf ctrl Is BrainWork.Utils.Web.WebControls.CustomTextBox Then
                    Dim ctrlNew As BrainWork.Utils.Web.WebControls.CustomTextBox
                    ctrlNew = CType(ctrl, BrainWork.Utils.Web.WebControls.CustomTextBox)
                    For Each EntityPropertyInfo As System.Reflection.PropertyInfo In Ent.GetType.GetProperties
                        For Each ControlPropertyInfo As System.Reflection.PropertyInfo In ctrlNew.GetType.GetProperties()
                            If ControlPropertyInfo.CanRead AndAlso ControlPropertyInfo.CanWrite Then

                                If ControlPropertyInfo.Name.ToLower = "propertyname" Then
                                    Dim objValue As Object = ControlPropertyInfo.GetValue(ctrl, Nothing)
                                    If Not objValue Is Nothing AndAlso objValue.ToString.ToLower = EntityPropertyInfo.Name.ToLower Then
                                        Dim NewValue As Object = IIf(String.IsNullOrEmpty(ctrlNew.Text), Nothing, CObj(ctrlNew.Text))
                                        Select Case True
                                            Case ctrlNew.TypeName.ToLower = "date" OrElse ctrlNew.TypeName.ToLower = "datetime"
                                                If IsDate(NewValue) Then
                                                    EntityPropertyInfo.SetValue(Ent, CDate(NewValue), Nothing)
                                                Else
                                                    Throw New ApplicationException("Tipo de dato no valido:" & ctrlNew.PropertyName)
                                                End If

                                            Case ctrlNew.TypeName.ToLower = "integer" OrElse _
                                                 ctrlNew.TypeName.ToLower = "int32" OrElse _
                                                 ctrlNew.TypeName.ToLower = "int16" OrElse _
                                                 ctrlNew.TypeName.ToLower = "int64" OrElse _
                                                 ctrlNew.TypeName.ToLower = "double" OrElse _
                                                 ctrlNew.TypeName.ToLower = "float"

                                                If IsNumeric(NewValue) Then
                                                    EntityPropertyInfo.SetValue(Ent, Val(NewValue), Nothing)
                                                Else
                                                    Throw New ApplicationException("Tipo de dato no valido" & ctrlNew.PropertyName)
                                                End If

                                            Case Else
                                                EntityPropertyInfo.SetValue(Ent, NewValue, Nothing)

                                        End Select

                                    End If
                                    Exit For
                                End If
                            End If
                        Next
                    Next
                End If
            End If

        Next
    End Sub
End Class
