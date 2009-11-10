Imports System.Text.RegularExpressions

Public Class ALTA_HistoriaClinica
    Dim respuesta As MsgBoxResult
    

       
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        respuesta = MsgBox("Esta seguro de que desea salir?", MsgBoxStyle.OkCancel, "Atención")
        If respuesta = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click

        respuesta = MsgBox("ESTA SEGURO SE PERDERAN TODOS LOS DATOS !!", MsgBoxStyle.OkCancel, "Atención")
        If respuesta = MsgBoxResult.Ok Then

            Me.MaskedTextBox1.Text = ""
            Me.MaskedTextBox2.Text = ""
            Me.MaskedTextBox3.Text = ""
            Me.TextBox2.Text = ""
            Me.ComboBox1.Text = ""
            Me.TextBox2.Clear()
            Me.TextBox3.Clear()
            Me.TextBox4.Clear()
            Me.TextBox5.Clear()
            Me.TextBox6.Clear()
            Me.TextBox7.Clear()
            Me.TextBox8.Clear()
            Me.TextBox9.Clear()
        End If

    End Sub

    Private Sub Btn_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GUARDAR.Click
        Dim instanciaDeLaEntidad As New Entities.EntDetalleHistoriaClinica
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLDetalleHistoriaClinica

        'completo los datos de la entidad

        instanciaDeLaEntidad.Deta_key = Me.MaskedTextBox1.Text
        instanciaDeLaEntidad.Pac_key = Me.MaskedTextBox2.Text
        instanciaDeLaEntidad.Deta_FechaConsulta = Me.MaskedTextBox3.Text
        instanciaDeLaEntidad.Deta_Especialidad = Me.ComboBox1.TabIndex
        instanciaDeLaEntidad.Deta_NombresMedico = Me.TextBox2.Text
        instanciaDeLaEntidad.Deta_ApellidosMedico = Me.TextBox3.Text
        instanciaDeLaEntidad.Deta_Diagnostico = Me.TextBox4.Text
        instanciaDeLaEntidad.Deta_Medicacion = Me.TextBox5.Text
        instanciaDeLaEntidad.Deta_Tratamiento = Me.TextBox6.Text
        instanciaDeLaEntidad.Deta_DuracionTratamiento = Me.TextBox7.Text
        instanciaDeLaEntidad.Deta_Observacion = Me.TextBox8.Text
        instanciaDeLaEntidad.Deta_Descripcion = Me.TextBox9.Text


        instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)

    End Sub
End Class