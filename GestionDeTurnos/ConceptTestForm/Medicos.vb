Public Class Medicos
    Dim respuesta As MsgBoxResult 'declaro una variable que va a servir para evaluarla y hacer ciertas acciones a partir del bot�n que se presione en una caja de mensaje
    Private Sub btnbuscarapellido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarapellido.Click
        Dim instanciaDeBussinesLogic As BLClassLibrary.BLMedicos
        Dim instanciaDeLaEntidad As Entities.EntMedicos

        instanciaDeBussinesLogic = New BLClassLibrary.BLMedicos
        instanciaDeLaEntidad = New Entities.EntMedicos


        instanciaDeLaEntidad.Med_Apellidos = Me.txt_Med_Apellidos.Text


        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeLaEntidad)

        If Me.BindingSource1.DataSource Is Nothing Then
            MsgBox("No se econtraron resultados para la busqueda realizada", MsgBoxStyle.Exclamation, "Error")
        End If

        dgvMedicos.AutoGenerateColumns = False
        dgvMedicos.DataSource = Me.BindingSource1

    End Sub


    Private Sub dgvMedicos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMedicos.CellContentClick

    End Sub

    Private Sub txt_Med_Apellidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Med_Apellidos.TextChanged

    End Sub

    Private Sub btn_buscardoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscardoc.Click
        Dim instanciaDeBussinesLogic As New BLClassLibrary.BLMedicos
        Dim instanciaDeEntidad As New Entities.EntMedicos

        instanciaDeEntidad.Med_NumeroDoc = Me.txt_Med_NumeroDoc.Text
        Me.BindingSource1.DataSource = instanciaDeBussinesLogic.GetListOfEntity(instanciaDeEntidad)
        If Me.BindingSource1.DataSource Is Nothing Then
            MsgBox("No se econtraron resultados para la busqueda realizada", MsgBoxStyle.Exclamation, "Error")
        End If
        dgvMedicos.DataSource = Me.BindingSource1

    End Sub

    Private Sub Medicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        respuesta = MsgBox("Esta seguro de que desea salir?", MsgBoxStyle.OkCancel, "Atenci�n")
        If respuesta = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        respuesta = MsgBox("Esta seguro de que desea Cancelar?", MsgBoxStyle.OkCancel, "Atenci�n")
        If respuesta = MsgBoxResult.Ok Then
            Me.txt_Med_Apellidos.Clear()
            Me.txt_Med_NumeroDoc.Clear()
            Me.dgvMedicos.Rows.Clear()
        End If
       
    End Sub

   
End Class