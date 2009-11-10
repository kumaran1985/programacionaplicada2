Public Class ALTA_PracticasMedicasxPlan

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        'Instancio la entidad Practicas Medicas x Plan
        Dim instanciaDeLaEntidad As New Entities.EntPracticasMedicasxPlan
        'Instanciamos la business logic Practicas Medicas x Plan
        Dim instanciaDeLaBussienes As New BLClassLibrary.BLPracticaMedicaxPlan

        'Validamos que se ingresen valores en los campos
        If Me.txt_ID_Plan.Text = "" Or Me.txt_ID_ObraSocial.Text = "" Or Me.txtPMxP_PorcentajeDescuento.Text = "" Then
            MsgBox("Por favor ingrese valores a los campos")
        Else
            'Colocamos en la entidad, los valores ingresados en el form de alta
            instanciaDeLaEntidad.Plan_Key = Me.txt_ID_Plan.Text
            instanciaDeLaEntidad.OS_Key = Me.txt_ID_ObraSocial.Text
            instanciaDeLaEntidad.PMxP_PorcentajeDescuento = Me.txtPMxP_PorcentajeDescuento.Text

            'Llamamos a la DataAccess para ingresar los datos en la Base de Datos
            instanciaDeLaBussienes.InsertEntity(instanciaDeLaEntidad)
            MsgBox("La Practica Medica x Plan fue registrada")
            'Una vez guardado, limpiamos la pantalla
            Limpiar_Todo()
        End If


    End Sub

    Private Sub txtPlan_Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Nos aseguramos que no nos dejen ingresar otros valores que no sean numeros
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtOS_Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Nos aseguramos que no nos dejen ingresar otros valores que no sean numeros
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtPMxP_PorcentajeDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPMxP_PorcentajeDescuento.KeyPress
        'Nos aseguramos que no nos dejen ingresar otros valores que no sean numeros
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 And (Asc(e.KeyChar)) <> 46 And (Asc(e.KeyChar)) <> 45 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Limpiar_Todo()
        'Decimos que poner "Limpiar_Todo", nos deje en blanco todos los campos
        Me.txt_ID_ObraSocial.Text = ""
        Me.txt_ID_Plan.Text = ""
        Me.txtPMxP_PorcentajeDescuento.Text = ""
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Al hacer click en "Cancelar" se limpian todos los campos
        Limpiar_Todo()
    End Sub


    'Intentamos realizar un ComboBox, pero no pudimos lograr que el combo no arranque con nada (""), apesar de poner "Me.cmb_ID_Plan.Text = " ""
    ' Private Sub ALTA_PracticasMedicasxPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Dim instanciablplanes As New BLClassLibrary.BLPlanes
    'Dim Tabla As New Data.DataTable

    ' Me.BindingSource1.DataSource = instanciablplanes.GetTable

    'Tabla = Me.BindingSource1.DataSource
    'Me.cmb_ID_Plan.DataSource = Me.BindingSource1
    'Me.cmb_ID_Plan.DisplayMember = Tabla.Columns(0).ToString
    'Me.cmb_ID_Plan.ValueMember = Tabla.Columns(0).ToString
    'Me.cmb_ID_Plan.Text = " "
    'Me.BindingSource1.DataSource = instanciablplanes.GetTable

    'Tabla = Me.BindingSource1.DataSource
    'Me.cmb_ID_ObraSocial.DataSource = Me.BindingSource1
    'Me.cmb_ID_ObraSocial.DisplayMember = Tabla.Columns(1).ToString
    'Me.cmb_ID_ObraSocial.ValueMember = Tabla.Columns(0).ToString
    'Me.cmb_ID_ObraSocial.Text = " "
    ''Me.BindingSource1.DataSource = instanciablplanes.GetTable

    'Me.cmb_ID_Plan.Focus()

    'End Sub

End Class