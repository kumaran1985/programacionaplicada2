Imports System.Windows.Forms
Public Class Elements

    ''' <summary>
    ''' Carga un combo box
    ''' </summary>
    ''' <param name="Combo">por referencia el control del combo</param>
    ''' <param name="dt">la datatable que contiene la informacion</param>
    ''' <param name="CampoDescripcion">campo que se va a mostrar</param>
    ''' <param name="CampoValor">valor que se recupera</param>
    ''' <remarks></remarks>
    Public Sub LoadCombo(ByRef Combo As ComboBox, _
                         ByVal dt As DataTable, _
                         ByVal CampoDescripcion As String, _
                         ByVal CampoValor As String)
        Combo.Items.Clear()
        Combo.DataSource = dt
        Combo.ValueMember = CampoValor
        Combo.DisplayMember = CampoDescripcion
    End Sub

    ''' <summary>
    ''' Carga un combo box
    ''' </summary>
    ''' <param name="Combo">por referencia el control del combo</param>
    ''' <param name="Lista">Colleccion con los valores</param>
    ''' <param name="CampoDescripcion">campo que se va a mostrar</param>
    ''' <param name="CampoValor">valor que se recupera</param>
    ''' <remarks></remarks>
    Public Sub LoadCombo(ByRef Combo As ComboBox, _
                        ByVal Lista As IList, _
                        ByVal CampoDescripcion As String, _
                        ByVal CampoValor As String)
        Combo.Items.Clear()
        Combo.DataSource = Lista
        Combo.ValueMember = CampoValor
        Combo.DisplayMember = CampoDescripcion
    End Sub
    ''' <summary>
    ''' Carga un combo box con la opcion "seleccione"
    ''' </summary>
    ''' <param name="Combo">por referencia el control del combo</param>
    ''' <param name="dt">la datatable que contiene la informacion</param>
    ''' <param name="CampoDescripcion">campo que se va a mostrar</param>
    ''' <param name="CampoValor">valor que se recupera</param>
    ''' <remarks></remarks>
    Public Sub LoadComboConSeleccione(ByRef Combo As ComboBox, _
                         ByVal dt As DataTable, _
                         ByVal CampoDescripcion As String, _
                         ByVal CampoValor As String)
        Combo.Items.Clear()
        Combo.DataSource = dt
        Combo.ValueMember = CampoValor
        Combo.DisplayMember = CampoDescripcion

    End Sub
End Class
