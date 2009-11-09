Public Class ABM_Turnos

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLSysTurnos
        Dim instanciaDeLaEntidad As Entities.EntTurnos

        instanciaDeBussinesLogic = New BLClassLibrary.BLSysTurnos
        instanciaDeLaEntidad = New Entities.EntTurnos

        If Me.turno_fecha.Text = "" And Me.turno_clave.Text = "" Then

            MessageBox.Show("por favor ingrese algo")


        Else

            If Me.turno_clave.Text <> "" Then

                instanciaDeLaEntidad.turno_key = Me.turno_clave.Text

            End If

            If Me.turno_fecha.Text <> "" Then

                instanciaDeLaEntidad.turno_fecha = Me.turno_fecha.Text

            End If
        End If





        'instanciaDeLaEntidad.turno_key = Me.turno_key 




        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)





    End Sub

    Private Sub turno_clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles turno_clave.KeyPress



        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub
End Class












