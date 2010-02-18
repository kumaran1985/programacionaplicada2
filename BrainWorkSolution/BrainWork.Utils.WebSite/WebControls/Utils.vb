Namespace WebControls
    Public Class Utils
        Shared Sub LoadComboFromEntity(ByRef cmb As System.Web.UI.WebControls.DropDownList, _
                                        ByVal oEntity As BrainWork.Entities.AbstractEntityBase, _
                                        ByVal bl As BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic, _
                                        Optional ByVal DefaultSelected As String = Nothing, _
                                         Optional ByVal WithSelectAll As String = Nothing)
            Dim dt As New DataTable
            dt = bl.GetDataTable()
            Dim pk As String = oEntity.ExtendedClassAttributes.PrimaryKeyFieldName

            Dim desc As String = oEntity.ExtendedClassAttributes.DescriptionFieldName
            LoadComboFromDataTable(cmb, dt, desc, pk, DefaultSelected, WithSelectAll)
        End Sub

        Shared Sub LoadComboFromDataTable(ByRef cmb As System.Web.UI.WebControls.DropDownList, _
                                          ByVal dt As DataTable, ByVal DescriptionField As String, _
                                          ByVal ValueField As String, Optional ByVal DefaultSelected As String = "", _
                                          Optional ByVal WithSelectAll As String = Nothing)

            cmb.Items.Clear()
            If Not WithSelectAll Is Nothing Then
                Dim li As New System.Web.UI.WebControls.ListItem("--Seleccione--", -1)
                cmb.Items.Add(li)
            End If

            For i As Integer = 0 To dt.Rows.Count
                Dim li As New System.Web.UI.WebControls.ListItem(dt.Rows(i)(DescriptionField), dt.Rows(i)(ValueField))
                If dt.Rows(i)(ValueField).ToString.ToLower = DefaultSelected.ToLower Then
                    li.Selected = True
                End If
                cmb.Items.Add(li)
            Next

        End Sub


    End Class
End Namespace
