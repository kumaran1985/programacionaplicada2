Public Class ALTA_Pacientes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLPacientes
        Dim instanciaDeLaEntidad As Entities.EntPacientes

        instanciaDeBussinesLogic = New BLClassLibrary.BLPacientes
        instanciaDeLaEntidad = New Entities.EntPacientes
        Dim StrMsgbox As String = ""


        If Me.TB_Pac_Nombres.Text = "" Or Me.TB_Pac_Apellidos.Text = "" Or Me.CB_TDOC_Key.Text = "" Or Me.TB_Pac_NumeroDoc.Text = "" Or Me.TB_Pac_Calle.Text = "" Or Me.MTB_Pac_NumeroExt.Text = "" Or Me.CB_TDOC_Key.Text = "" Or Me.CB_Pac_Sexo.Text = "" Then

            If Me.TB_Pac_Nombres.Text = "" Then
                StrMsgbox = StrMsgbox & ", Nombres"
            End If
            If Me.TB_Pac_Apellidos.Text = "" Then
                StrMsgbox = StrMsgbox & ", Apellidos"
            End If
            If Me.CB_TDOC_Key.Text = "" Then
                StrMsgbox = StrMsgbox & ", ID Tipo de Documento"
            End If
            If Me.TB_Pac_NumeroDoc.Text = "" Then
                StrMsgbox = StrMsgbox & ", Nº de Documento"
            End If
            If Me.TB_Pac_Calle.Text = "" Then
                StrMsgbox = StrMsgbox & ", Calle"
            End If
            If Me.MTB_Pac_NumeroExt.Text = "" Then
                StrMsgbox = StrMsgbox & ", Número"
            End If
            If Me.CB_LOCA_Key.Text = "" Then
                StrMsgbox = StrMsgbox & ", ID Localidad"
            End If
            If Me.CB_Pac_Sexo.Text = "" Then
                StrMsgbox = StrMsgbox & ", Sexo"
            End If

            StrMsgbox = "Es necesario que complete los siguientes campos para ar el alta: " & StrMsgbox.Remove(0, 1)

            MsgBox(StrMsgbox)
        Else
            instanciaDeLaEntidad.Pac_Nombres = Me.TB_Pac_Nombres.Text
            instanciaDeLaEntidad.Pac_Apellidos = Me.TB_Pac_Apellidos.Text
            instanciaDeLaEntidad.Pac_Calle = Me.TB_Pac_Calle.Text
            instanciaDeLaEntidad.Pac_NumeroExt = Me.MTB_Pac_NumeroExt.Text
            instanciaDeLaEntidad.TDOC_Key = Me.CB_TDOC_Key.Text
            instanciaDeLaEntidad.Pac_NumeroDoc = Me.TB_Pac_NumeroDoc.Text
            instanciaDeLaEntidad.LOCA_Key = Me.CB_TDOC_Key.Text
            instanciaDeLaEntidad.Pac_Sexo = Me.CB_Pac_Sexo.Text
            If Me.TB_Pac_NumeroInt.Text <> "" Then
                instanciaDeLaEntidad.Pac_NumeroInt = Me.TB_Pac_NumeroInt.Text
            End If
            If Me.MTB_Pac_Telefono.Text <> "" Then
                instanciaDeLaEntidad.Pac_Telefonos = Me.MTB_Pac_Telefono.Text
            End If
            If Me.MTB_Pac_Celular.Text <> "" Then
                instanciaDeLaEntidad.Pac_Celular = Me.MTB_Pac_Celular.Text
            End If
            If Me.TB_Pac_Email.Text <> "" Then
                instanciaDeLaEntidad.Pac_Email = Me.TB_Pac_Email.Text
            End If
            If Me.MTB_Pac_FechaNacimiento.MaskCompleted = True Then
                instanciaDeLaEntidad.Pac_FechaNacimiento = Me.MTB_Pac_FechaNacimiento.Text
            Else
                instanciaDeLaEntidad.Pac_FechaNacimiento = Date.MinValue
            End If
            If Me.MTB_Pac_FechaAlta.MaskCompleted = True Then
                instanciaDeLaEntidad.Pac_FechaAlta = Me.MTB_Pac_FechaAlta.Text
            Else
                instanciaDeLaEntidad.Pac_FechaAlta = Date.MinValue
            End If
            If Me.MTB_Pac_FechaCancelacion.MaskCompleted = True Then
                instanciaDeLaEntidad.Pac_FechaCancelacion = Me.MTB_Pac_FechaCancelacion.Text
            Else
                instanciaDeLaEntidad.Pac_FechaCancelacion =Date.MinValue
            End If
            If Me.CB_Pac_EstadoCivil.Text <> "" Then
                instanciaDeLaEntidad.Pac_EstadoCivil = Me.CB_Pac_EstadoCivil.Text
            End If
            If Me.TB_Pac_Ocupacion.Text <> "" Then
                instanciaDeLaEntidad.Pac_Ocupacion = Me.TB_Pac_Ocupacion.Text
            End If
            If Me.TB_Pac_Nacionalidad.Text <> "" Then
                instanciaDeLaEntidad.Pac_Nacionalidad = Me.TB_Pac_Nacionalidad.Text
            End If

            instanciaDeBussinesLogic.InsertEntity(instanciaDeLaEntidad)

            MsgBox("El Paciente ha sido dado de alta correctamente en el Sistema")

        End If
    End Sub

    Private Sub ALTA_Pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base2006DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.Base2006DataSet1.Localidades)
        'TODO: esta línea de código carga datos en la tabla 'Base2006DataSet.TiposDocumento' Puede moverla o quitarla según sea necesario.
        Me.TiposDocumentoTableAdapter.Fill(Me.Base2006DataSet.TiposDocumento)

    End Sub
End Class