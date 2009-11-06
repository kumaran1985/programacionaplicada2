Imports System.Text.RegularExpressions

Public Class Alta_Medicos

    Private Sub txt_Med_Nombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Med_Nombres.KeyPress
        'valido que solo se ingresen letras, se pueda presiona el backspace o se pueda usar la barra espaciadora
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(8) Or e.KeyChar = Microsoft.VisualBasic.ChrW(32)) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt_Med_Nombres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Med_Nombres.TextChanged

    End Sub

    Private Sub txt_Med_Apellidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Med_Apellidos.KeyPress
        'valido que solo se ingresen letras, se pueda presiona el backspace o se pueda usar la barra espaciadora
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(8) Or e.KeyChar = Microsoft.VisualBasic.ChrW(32)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Med_Apellidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Med_Apellidos.TextChanged

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
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
    Private Function validar_email(ByVal strmail As String) As Boolean
        'funciona que valida que se esciba una dirección mail en la estructura correcta es 
        'decir nombre@correo.com, devuelve true o false
        Return Regex.IsMatch(strmail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

    End Function

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmb_LOCA_key_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_LOCA_key.SelectedIndexChanged
      
    End Sub

    Private Sub txt_Med_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Med_Email.TextChanged

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim instanciaBLMedicos As New BLClassLibrary.BLMedicos 'instancio la business logic de Medicos
        Dim instanciaentidad As New Entities.EntMedicos 'instancio la entidad medicos
        Dim strmail As String 'cadena que se usara para validar que se introduzca una dirección de correo electronico en formato correcto
        Dim tipo_doc As Integer 'contendra el número correspondiente de acuerdo al tipo de documento seleccionado

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

        strmail = Me.txt_Med_Email.Text
        If strmail.Length > 0 Then
            If validar_email(strmail) = False Then
                MsgBox("El formato de la dirección no es valido")
            End If
        End If


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


        instanciaBLMedicos.InsertEntity(instanciaentidad)

        MsgBox("Guardado Satisfactoriamente")


    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub cmb_TDoc_key_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TDoc_key.SelectedIndexChanged

    End Sub
End Class