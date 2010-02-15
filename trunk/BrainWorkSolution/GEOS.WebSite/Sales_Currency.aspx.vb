Partial Class Sales_Currency
    Inherits System.Web.UI.Page
                               
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Me._CurrencyCode.Text = Me._CurrencyCode.Text

        Dim Ent As New GEOS.Entities.EntSales_Currency


        For Each ctrl As System.Web.UI.Control In Me.form1.Controls
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
                                        EntityPropertyInfo.SetValue(Ent, NewValue, Nothing)
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
