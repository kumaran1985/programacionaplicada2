

Public Class ALTA_HistoriaClinica
    Dim respuesta As MsgBoxResult
    

       
    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        respuesta = MsgBox("Esta seguro de que desea salir?", MsgBoxStyle.OkCancel, "Atención")
        If respuesta = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click

        respuesta = MsgBox("ESTA SEGURO SE PERDERAN TODOS LOS DATOS !!", MsgBoxStyle.OkCancel, "Atención")
        If respuesta = MsgBoxResult.Ok Then
            Limpar_Pantalla()
            
        End If

    End Sub

    Private Sub Btn_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GUARDAR.Click
        Dim instanciaDeLaEntidad As New Entities.EntDetalleHistoriaClinica
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLDetalleHistoriaClinica

        Dim StrMsgbox As String = ""

        

        If Me.MTB_FechaConsulta.Text = "00/00/0000" Or Me.Cmb_NombresMedico.Text = "" Or Me.Cmbx_Apellido.Text = "" Or Me.TxBx_Diagnostico.Text = "" Or Me.TxBx_Medicacion.Text = "" Or Me.TxBx_Tratamiento.Text = "" Or Me.TxBx_DuracionTratamiento.Text = "" Then

            If Me.MTB_FechaConsulta.Text = "00/00/0000" Then
                StrMsgbox = StrMsgbox & ", Fecha de consulta"
            End If
            If Me.Cmb_NombresMedico.Text = "" Then
                StrMsgbox = StrMsgbox & ", Nombre"
            End If
            If Cmbx_Apellido.Text = "" Then
                StrMsgbox = StrMsgbox & ", Apellido"
            End If
            If Me.TxBx_Diagnostico.Text = "" Then
                StrMsgbox = StrMsgbox & ", Diagnostico"
            End If
            If Me.TxBx_Medicacion.Text = "" Then
                StrMsgbox = StrMsgbox & ", Medicacion"
            End If
            If Me.TxBx_Tratamiento.Text = "" Then
                StrMsgbox = StrMsgbox & ", Tratamiento"
            End If
            If Me.TxBx_DuracionTratamiento.Text = "" Then
                StrMsgbox = StrMsgbox & ", Duracion de Tratamiento"
            End If

            respuesta = MsgBox("Los campos con(*) son obligatorios", MsgBoxStyle.OkCancel, "Atención")
            If respuesta = MsgBoxResult.Ok Then


                StrMsgbox = "Dede completar siguientes campos para dar el alta: " & StrMsgbox.Remove(0, 1)

                MsgBox(StrMsgbox)

            End If
        Else




            'completo los datos de la entidad

            'instanciaDeLaEntidad.Deta_key = Me.MaskedTextBox1.Text
            instanciaDeLaEntidad.Pac_key = Me.Cmb_NroPaciente.Text
            instanciaDeLaEntidad.Deta_FechaConsulta = Me.MTB_FechaConsulta.Text
            instanciaDeLaEntidad.Deta_Especialidad = Me.CmBx_Especialidad.TabIndex
            instanciaDeLaEntidad.Deta_NombresMedico = Me.Cmb_NombresMedico.TabIndex
            instanciaDeLaEntidad.Deta_ApellidosMedico = Me.Cmbx_Apellido.Text
            instanciaDeLaEntidad.Deta_Diagnostico = Me.TxBx_Diagnostico.Text
            instanciaDeLaEntidad.Deta_Medicacion = Me.TxBx_Medicacion.Text
            instanciaDeLaEntidad.Deta_Tratamiento = Me.TxBx_Tratamiento.Text
            instanciaDeLaEntidad.Deta_DuracionTratamiento = Me.TxBx_DuracionTratamiento.Text
            instanciaDeLaEntidad.Deta_Observacion = Me.TxBx_Observacion.Text
            instanciaDeLaEntidad.Deta_Descripcion = Me.TxBx_Descripcion.Text


            instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)

            MsgBox("La HISTORIA CLINICA ha sido dada de alta correctamente en el Sistema")

            Limpar_Pantalla()



        End If


    End Sub
    Private Sub Limpar_Pantalla()

        ' Me.MaskedTextBox1.Text = ""
        Me.Cmb_NroPaciente.Text = ""
        Me.MTB_FechaConsulta.Text = ""
        Me.CmBx_Especialidad.Text = ""
        Me.Cmb_NombresMedico.Text = ""
        Me.Cmbx_Apellido.Text = ""
        Me.TxBx_Diagnostico.Clear()
        Me.TxBx_Medicacion.Clear()
        Me.TxBx_Tratamiento.Clear()
        Me.TxBx_DuracionTratamiento.Clear()
        Me.TxBx_Observacion.Clear()
        Me.TxBx_Descripcion.Clear()


    End Sub

    ' creamos una función para validar que coloque una fecha validaC:\LocalSVN\GestionDeTurnos\ConceptTestForm\ALTA_HistoriaClinica.vb
    Private Function validar_fecha(ByVal cajatexto As System.Windows.Forms.Control) As Boolean
        Dim cadena As String
        cadena = cajatexto.Text
        If cadena.Trim = "/  /" Then 'verificamos si colocamos una fecha o la dejamos vacia
            respuesta = MsgBox("Debe ingresar una fecha", MsgBoxStyle.OkCancel, "Error") 'devuelve el valor del botón presionado Aceptar o Cancelar
            evaluar_respuesta(respuesta, cajatexto)
            Return False
            Exit Function
        Else
            If Not IsDate(cadena) Then  'valido que en  la fecha el número de mes no sea superior a 12, valida que no sea un año bisiesto
                respuesta = MsgBox("Fecha Invalida " & cadena, MsgBoxStyle.OkCancel, "Error")
                evaluar_respuesta(respuesta, cajatexto)
                Return False
                Exit Function

            Else
                If CDate(cadena) > Now OrElse CDate(cadena) <= Date.MinValue Then 'Evaluo que la fecha que introduzca no sea mayor que la de hoy o menor igual que la minima fecha considerada por vb.net
                    respuesta = MsgBox("La fecha es superior a la fecha actual o no es Valida " & cadena, MsgBoxStyle.OkCancel, "Error")
                    evaluar_respuesta(respuesta, cajatexto)
                    Return False
                    Exit Function
                End If
            End If
            Return True
        End If
    End Function


    Private Sub evaluar_respuesta(ByVal respuesta As MsgBoxResult, ByVal cajatexto As System.Windows.Forms.Control)

        'evalular el botón que presiono en la ventana de mensaje, es decir si presiono aceptar o cancelar
        If respuesta = MsgBoxResult.Cancel Then 'si presiono cancelar limpia la caja de texto y envia el foco al botón cancelar del formulario
            cajatexto.Text = ""
            Me.btn_cancelar.Focus()
        Else
            cajatexto.Text = ""
            cajatexto.Focus()
        End If
    End Sub

    Private Sub MTB_FechaConsulta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MTB_FechaConsulta.LostFocus
        validar_fecha(Me.MTB_FechaConsulta)
    End Sub


    Private Sub ALTA_HistoriaClinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Dim instanciaBLMedicos As New BLClassLibrary.BLMedicos

       
        Dim tabla1 As New Data.DataTable

        Me.BindingSource1.DataSource = instanciaBLMedicos.GetTable

        tabla1 = Me.BindingSource1.DataSource

        Me.Cmb_NombresMedico.DataSource = Me.BindingSource1
        Me.Cmb_NombresMedico.DisplayMember = tabla1.Columns(3).ToString 'muestra todo los nombres de los medicos contenidos en la columna Med_Especialidad en la tabla MEDICOS

        Me.Cmb_NombresMedico.Text = ""
        Me.Cmbx_Apellido.DataSource = Me.BindingSource1
        Me.Cmbx_Apellido.DisplayMember = tabla1.Columns(4).ToString 'muestra todo los apellidos de medicos contenidas en la columna Med_Apellidos en la tabla MEDICOS
        Me.Cmbx_Apellido.Text = ""

        Me.CmBx_Especialidad.DataSource = Me.BindingSource1
        Me.CmBx_Especialidad.DisplayMember = tabla1.Columns(9).ToString 'muestra todos los codigos de las especialidades contenidas en la tabla MEDICOS
        Me.CmBx_Especialidad.Text = ""





        'Dim instanciaBLPacientes As New BLClassLibrary.BLPacientes


        'Dim tabla2 As New Data.DataTable 'instancio un datatable donde volcare la consulta que se haga sobre la tabla pacientes

        ' Me.BindingSource2.DataSource = instanciaBLPacientes.GetTable

        'tabla2 = Me.BindingSource2.DataSource

        'Me.Cmb_NroPaciente.DataSource = Me.BindingSource2
        'Me.Cmb_NroPaciente.DisplayMember = tabla2.Columns(4).ToString 'muestra todos los numeros de pacientes
        'Me.Cmb_NroPaciente.Text = ""


        
    End Sub
End Class