Public Class frmABMConceptTest
    Private WithEvents bindingSource1 As New BindingSource()
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click


        Dim bl As New BLClassLibrary.BLSysRoles
        Dim ent As New Entities.EntSys_Roles
        ent.SYS_ROLE_Descripcion = txtSRC_SYS_ROLE_Description.Text


        With Me.dgvBusqueda

            .AutoGenerateColumns = True
            .AutoSize = True

            bindingSource1.DataSource = bl.GetListOfEntity(ent)
            .DataSource = bindingSource1
 
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

            .BorderStyle = BorderStyle.Fixed3D

            .EditMode = DataGridViewEditMode.EditOnEnter
            .Columns(0).HeaderText = "Rol ID"
            .Columns(1).HeaderText = "Descripcion"




        End With



    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.bindingSource1.g()
    End Sub

    Private Sub BindingSource2_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles bindingSource1.AddingNew

    End Sub

    Private Sub BindingSource2_CurrentItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bindingSource1.CurrentItemChanged

    End Sub
End Class