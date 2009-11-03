Public Class ABM_Turnos

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLSysTurnos
        Dim instanciaDeLaEntidad As Entities.EntTurnos

        instanciaDeBussinesLogic = New BLClassLibrary.BLSysTurnos
        instanciaDeLaEntidad = New Entities.EntTurnos


        instanciaDeLaEntidad.turno_fecha = CType(Me.turno_fecha.Text.ToString, Date)

        'instanciaDeLaEntidad.turno_key = Me.turno_key 




        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)


        dgvBusqueda.AutoGenerateColumns = False
        dgvBusqueda.DataSource = Me.BindingSource1


    End Sub

    
    Private Sub txtSRC_SYS_ROL_KEY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSRC_SYS_ROL_KEY.TextChanged

    End Sub

    Private Sub turno_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turno_fecha.ValueChanged

    End Sub
End Class