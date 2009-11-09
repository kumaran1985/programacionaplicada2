Imports System.Text.RegularExpressions ' Espacio de nombres con clases para el manejo de expresiones regulares en .NET

Public Class Alta_Medicos
    Dim respuesta As MsgBoxResult 'declaro una variable que va a servir para evaluarla y hacer ciertas acciones a partir del botón que se presione en una caja de mensaje
    Private Sub Alta_Medicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim instanciabllocalidad As New BLClassLibrary.BLLocalidades 'instancia la bussiness logic de Localidades
        Dim instanciablespecialidades As New BLClassLibrary.BLEspecialidades 'instancia la bussiness logic de Especialidades
        Dim tabla1 As New Data.DataTable 'instancio un datatable donde volcare la consulta que se haga sobre la tabla localidades
        Dim tabla2 As New Data.DataTable 'instancio un datatable donde volcare la consulta que se haga sobre la tabla especialidades

        Me.BindingSource1.DataSource = instanciabllocalidad.GetTable()

        tabla1 = Me.BindingSource1.DataSource
        Me.cmb_LOCA_key.DataSource = Me.BindingSource1
        Me.cmb_LOCA_key.DisplayMember = tabla1.Columns(2).ToString 'muestra todo los nombres de localidades contenidas en la columna LOCA_Nombre en la tabla Localidades
        Me.cmb_LOCA_key.ValueMember = tabla1.Columns(0).ToString 'permite que cuando selecciona una localidad, el valor que guarde sea LOCA_Key, es decir la clave de la taba localidad
        Me.cmb_LOCA_key.Text = ""
        Me.BindingSource2.DataSource = instanciablespecialidades.GetTable()

        tabla2 = Me.BindingSource2.DataSource
        Me.cmb_Med_Especialidad.DataSource = Me.BindingSource2
        Me.cmb_Med_Especialidad.DisplayMember = tabla2.Columns(1).ToString 'muestra todo los nombres de las especialidades contenidas en la tabla especialidades
        Me.cmb_Med_Especialidad.ValueMember = tabla2.Columns(0).ToString 'permite que cuando selecciona una especialidad, el valor que guarde sea el valor de la clave primaria de la tabala especialidades
        Me.cmb_Med_Especialidad.Text = ""

        Me.txt_Med_Nombres.Focus() 'hago que cuando inice el formulario el foco este en el primer campo que es el campo nombre

    End Sub

    Private Sub txt_Med_Nombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Med_Nombres.KeyPress
        'valido que solo se ingresen letras, se pueda presiona el backspace o se pueda usar la barra espaciadora
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(8) Or e.KeyChar = Microsoft.VisualBasic.ChrW(32)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Med_Apellidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Med_Apellidos.KeyPress
        'valido que solo se ingresen letras, se pueda presiona el backspace o se pueda usar la barra espaciadora
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(8) Or e.KeyChar = Microsoft.VisualBasic.ChrW(32)) Then
            e.Handled = True
        End If
    End Sub
    Private Function validar_email(ByVal strmail As String) As Boolean
        'funciona que valida que se esciba una dirección mail en la estructura correcta es 
        'decir nombre@correo.com, devuelve true o false
        Return Regex.IsMatch(strmail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

    End Function


    'creamos un procedimiento que evalue la respuesta o click que hago en una ventana de mensaje del tipo Aceptar - Cancelar
    Private Sub evaluar_respuesta(ByVal respuesta As MsgBoxResult, ByVal cajatexto As System.Windows.Forms.Control)
        'evalular el botón que presiono en la ventana de mensaje, es decir si presiono aceptar o cancelar
        If respuesta = MsgBoxResult.Cancel Then 'si presiono cancelar limpia la caja de texto y envia el foco al botón cancelar del formulario
            cajatexto.Text = ""
            Me.btn_cancelar.Focus()
        Else                         'si lo que presiono es aceptar limpia la caja de texto y deja el foco en la misma
            cajatexto.Text = ""
            cajatexto.Focus()
        End If
    End Sub
    ' creamos una función para validar que coloque una fecha valida
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

    Private Sub txt_Med_FechaNac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Med_FechaNac.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then 'valido que solo ingrese números
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Med_FechaNac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Med_FechaNac.LostFocus

        validar_fecha(Me.txt_Med_FechaNac)


    End Sub

    Private Sub txt_Med_FechaIngreso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Med_FechaIngreso.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then 'valido que solo ingrese números
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Med_FechaIngreso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Med_FechaIngreso.LostFocus

        Dim fecha1 As String
        Dim fecha_ingreso As String
        Dim diferencia As Integer

        If validar_fecha(Me.txt_Med_FechaIngreso) Then 'valido que en  la fecha el número de mes no sea superior a 12, valida que no sea un año bisiesto, y que no sea superior al a fecha de hoy
            fecha1 = Me.txt_Med_FechaNac.Text
            fecha_ingreso = Me.txt_Med_FechaIngreso.Text
            diferencia = DateDiff(DateInterval.Day, CDate(fecha1), CDate(fecha_ingreso))
            If diferencia <= 0 Then
                respuesta = MsgBox("Fecha de Nacimiento no puede ser mayor a fecha de ingreso " & Me.txt_Med_FechaIngreso.Text, MsgBoxStyle.OkCancel, "Error")
                evaluar_respuesta(respuesta, Me.txt_Med_FechaIngreso)
            End If
        End If

    End Sub

    Private Sub txt_Med_Email_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Med_Email.LostFocus
        Dim strmail As String 'cadena que se usara para validar que se introduzca una dirección de correo electronico en formato correcto
        strmail = Me.txt_Med_Email.Text
        If strmail.Length > 0 Then
            If validar_email(strmail) = False Then
                MsgBox("El formato de la dirección no es valido " & strmail & " No tiene el formato algo@dominio.subdominio", MsgBoxStyle.Exclamation, "Error")
                txt_Med_Email.Clear()
            End If
        End If
    End Sub
    Private Sub limpiar_todo()
        Me.cmb_LOCA_key.Text = ""
        Me.cmb_Med_Especialidad.Text = ""
        Me.cmb_Med_Matricula.Text = ""
        Me.cmb_Med_sexo.Text = ""
        Me.cmb_TDoc_key.Text = ""
        Me.txt_Med_Apellidos.Clear()
        Me.txt_Med_Calle.Clear()
        Me.txt_Med_celular.Clear()
        Me.txt_Med_Email.Clear()
        Me.txt_Med_FechaIngreso.Clear()
        Me.txt_Med_FechaNac.Clear()
        Me.txt_Med_Matricula1.Clear()
        Me.txt_Med_Nombres.Clear()
        Me.txt_Med_NumeroDoc.Clear()
        Me.txt_Med_NumeroExt.Clear()
        Me.txt_Med_NumeroInt.Clear()
        Me.txt_Med_telefono.Clear()
        Me.cmb_Med_EstadoCivil.Text = ""
    End Sub
    Private Function datos_requeridos() As Boolean

        If txt_Med_Nombres.Text = "" Then
            MsgBox("Debe ingresar el nombre del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_Nombres.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_Apellidos.Text = "" Then
            MsgBox("Debe ingresar el apellido del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_Apellidos.Focus()
            Return True
            Exit Function
        End If
        If cmb_TDoc_key.Text = "" Then
            MsgBox("Debe ingresar el tipo de documento del médico", MsgBoxStyle.Exclamation, "Error")
            cmb_TDoc_key.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_NumeroDoc.Text = "" Then
            MsgBox("Debe ingresar el número de documento del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_NumeroDoc.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_FechaNac.Text = "  /  /" Then
            MsgBox("Debe ingresar la fecha de nacimiento del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_FechaNac.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_telefono.Text = "" Then
            MsgBox("Debe ingresar el teléfono del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_telefono.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_celular.Text = "   -" Then
            MsgBox("Debe ingresar el teléfono celular del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_celular.Focus()
            Return True
            Exit Function
        End If
        If cmb_Med_Especialidad.Text = "" Then
            MsgBox("Debe ingresar la especialidad del médico", MsgBoxStyle.Exclamation, "Error")
            cmb_Med_Especialidad.Focus()
            Return True
            Exit Function
        End If
        If cmb_Med_Matricula.Text = "" Then
            MsgBox("Debe ingresar el tipo de matrícula del médico", MsgBoxStyle.Exclamation, "Error")
            cmb_Med_Matricula.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_Matricula1.Text = "" Then
            MsgBox("Debe ingresar el número de matrícula del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_Matricula1.Focus()
            Return True
            Exit Function
        End If
        If txt_Med_FechaIngreso.Text = "  /  /" Then
            MsgBox("Debe ingresar la fecha de ingreso del médico", MsgBoxStyle.Exclamation, "Error")
            txt_Med_FechaIngreso.Focus()
            Return True
            Exit Function
        End If
        Return False
    End Function
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim instanciaBLMedicos As New BLClassLibrary.BLMedicos 'instancio la business logic de Medicos
        Dim instanciaentidad As New Entities.EntMedicos 'instancio la entidad medicos
        Dim tipo_doc As Integer 'contendra el número correspondiente de acuerdo al tipo de documento seleccionado
        Dim campo_requerido As Boolean ' sirve para trabajar con la funcion que valida el ingreso de campos requeridos

        'llamo a la funcion que valida el ingreso de campos requeridos y luego salgo del procedimiento Sub
        campo_requerido = datos_requeridos()
        If campo_requerido = True Then
            Exit Sub
        End If

        Select Case Me.cmb_TDoc_key.SelectedItem
            Case "DNI"
                tipo_doc = 1
            Case "LC"
                tipo_doc = 2
            Case "LE"
                tipo_doc = 3
            Case Else
                tipo_doc = 4
        End Select

        instanciaentidad.Med_Apellidos = Me.txt_Med_Apellidos.Text
        instanciaentidad.Med_Nombres = Me.txt_Med_Nombres.Text
        instanciaentidad.TDOC_Key = tipo_doc
        instanciaentidad.Med_NumeroDoc = Me.txt_Med_NumeroDoc.Text
        instanciaentidad.Med_FechaNacimiento = CDate(Me.txt_Med_FechaNac.Text)
        instanciaentidad.Med_Sexo = Me.cmb_Med_sexo.SelectedItem
        instanciaentidad.Med_EstadoCivil = Me.cmb_Med_EstadoCivil.SelectedItem
        instanciaentidad.Med_Calle = Me.txt_Med_Calle.Text
        instanciaentidad.LOCA_Key = Me.cmb_LOCA_key.SelectedValue
        instanciaentidad.Med_Matricula = Me.cmb_Med_Matricula.SelectedValue
        instanciaentidad.Med_Telefonos = Me.txt_Med_telefono.Text
        instanciaentidad.Med_Celular = Me.txt_Med_celular.Text
        instanciaentidad.Med_Email = Me.txt_Med_Email.Text
        instanciaentidad.Med_NumeroExt = Me.txt_Med_NumeroExt.Text
        instanciaentidad.Med_NumeroInt = Me.txt_Med_NumeroInt.Text
        instanciaentidad.Med_Especialidad = Me.cmb_Med_Especialidad.SelectedValue
        instanciaentidad.Med_Matricula = Me.cmb_Med_Matricula.SelectedItem
        instanciaentidad.Med_Matricula1 = CInt(Me.txt_Med_Matricula1.Text)
        instanciaentidad.Med_FechaIngreso = Me.txt_Med_FechaIngreso.Text

        instanciaBLMedicos.InsertEntity(instanciaentidad) 'llamo al insert de mi dataacces para insertar los datos en la base de datos

        MsgBox("Guardado Satisfactoriamente")
        limpiar_todo()

    End Sub
    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        respuesta = MsgBox("Esta seguro de que desea cancelar?", MsgBoxStyle.OkCancel, "Atención") 'aparece un mensaje dando la opción de aceptar o cancelar
        If respuesta = MsgBoxResult.Ok Then
            limpiar_todo()   'si se presiona aceptar se limpian todos los campos del formulario
        End If

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        respuesta = MsgBox("Esta seguro de que desea salir?", MsgBoxStyle.OkCancel, "Atención") 'aparece un mensaje dando la opción de aceptar o cancelar
        If respuesta = MsgBoxResult.Ok Then  'si presiona Aceptar se cierra el formulario
            Me.Close()
        End If

    End Sub


End Class