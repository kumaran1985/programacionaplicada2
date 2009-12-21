Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page


    Function getTablePDFFamily(ByVal FML_ID As Integer, ByVal ds As DataSet) As iTextSharp.text.Table
        Dim helper As BrainWork.Utils.PDF.PDFDocument = New BrainWork.Utils.PDF.PDFDocument()
        helper.Open()



        Dim dv As New DataView(ds.Tables(0), "FML_ID = 1", "", DataViewRowState.CurrentRows)
        Dim TablaDeDosCeldas As iTextSharp.text.Table = Nothing
        TablaDeDosCeldas = helper.GetTable(1, 2, New Integer() {24, 24})

        Dim TablaDeSeisColumnas As iTextSharp.text.Table = Nothing
        TablaDeSeisColumnas = helper.GetTable(dv.Count, 6, New Integer() {4, 4, 4, 4, 4, 4})


        For i As Integer = 0 To dv.Count - 1
            helper.PutNormalCell(dv(i)("campo_codigo").ToString(), i, 0, TablaDeSeisColumnas)
            helper.PutNormalCell(dv(i)("campo_cod:ao").ToString(), i, 1, TablaDeSeisColumnas)
            helper.PutNormalCell(dv(i)("campo_tipoValoR").ToString(), i, 2, TablaDeSeisColumnas)
            helper.PutNormalCell(dv(i)("campo").ToString(), i, 3, TablaDeSeisColumnas)
            helper.PutNormalCell(dv(i)("campo").ToString(), i, 4, TablaDeSeisColumnas)
            helper.PutNormalCell(dv(i)("campo").ToString(), i, 5, TablaDeSeisColumnas)
        Next
        helper.PutTitleCell(dv(0)("campo_nOMBRE DE LA FAMILIA").ToString(), 0, 0, TablaDeDosCeldas)

        TablaDeDosCeldas.InsertTable(TablaDeSeisColumnas, 0, 1)

        Return TablaDeDosCeldas

    End Function


    Function getDataSet() As Data.DataSet
        getDataSet = New DataSet
        Dim cnn As New SqlClient.SqlConnection("Data Source=10.11.12.10\SQL2005;Initial Catalog=CRMOCA_DEV;Persist Security Info=true;User ID=sa;Password=123")
        cnn.Open()
        Dim ocmd As New SqlClient.SqlCommand("Select * From Clientes", cnn)
        Dim oda As New SqlClient.SqlDataAdapter(ocmd)
        oda.Fill(getDataSet)

        cnn.Close()

    End Function




    Private Function GetPdfByHelper(ByVal code As Integer) As System.IO.MemoryStream
        Dim helper As BrainWork.Utils.PDF.PDFDocument = New BrainWork.Utils.PDF.PDFDocument(iTextSharp.text.PageSize.A4.Rotate())
        helper.Open()

        Dim TablaDePDF As iTextSharp.text.Table = Nothing
        Dim c As iTextSharp.text.Cell = Nothing

        '<Header>
        helper.PutTitleText("TITULO")
        helper.PutHorizontalLine(10, 585, 785, 1)
        helper.PutTitleText(" ") 'espacio en blanco o salto de línea
        helper.PutSubTitleText("Subtitulo")
         

        helper.PutTextStyle1("Estilo de texto simple")
        helper.PutHorizontalLine(10, 585, 1000, 1)
 

        '</Header>



        '<Step1>
        'Dim pepe As Integer() = {140, 300}

        'obtengo una nueva tabla
        Dim anchos(1) As Integer
        anchos(0) = 140
        anchos(1) = 300
        TablaDePDF = helper.GetTable(1, 2, anchos)
        Dim TablaDePDF2 As iTextSharp.text.Table = Nothing
        TablaDePDF2 = helper.GetTable(2, 2, New Integer() {70, 150})
        TablaDePDF2.AutoFillEmptyCells = True
        TablaDePDF.InsertTable(TablaDePDF2, 0, 0)
        TablaDePDF.AutoFillEmptyCells = True


        TablaDePDF = helper.GetTable(6, 2, New Integer() {140, 300})

        helper.PutTitleCell("Titulo Columna 1 fila 1", 0, 0, TablaDePDF, BrainWork.Utils.PDF.enumHorizontalAlignment.center, BrainWork.Utils.PDF.enumVerticalAlignment.middle)
        helper.PutNormalCell(("texto fila 1 Columna 2").ToString(), 0, 1, TablaDePDF, BrainWork.Utils.PDF.enumHorizontalAlignment.center, BrainWork.Utils.PDF.enumVerticalAlignment.middle)

        'helper.PutTitleCell("Titulo Columna 1 fila 2", 1, 0, TablaDePDF)
        'helper.PutNormalCell(("texto fila 2 Columna 2").ToString(), 1, 1, TablaDePDF)

        'helper.PutTitleCell("Titulo Columna 1 fila 3", 2, 0, TablaDePDF)
        'helper.PutNormalCell(("texto fila 3 Columna 2").ToString(), 2, 1, TablaDePDF)

        'helper.PutTitleCell("Titulo Columna 1 fila 4", 3, 0, TablaDePDF)
        'helper.PutNormalCell(("texto fila 4 Columna 2").ToString(), 3, 1, TablaDePDF)

        'helper.PutTitleCell("Titulo Columna 1 fila 5", 4, 0, TablaDePDF)
        'helper.PutNormalCell(("texto fila 5 Columna 2").ToString(), 4, 1, TablaDePDF)

        'helper.PutTitleCell("Titulo Columna 1 fila 6", 5, 0, TablaDePDF)
        'helper.PutNormalCell(("texto fila 6 Columna 2").ToString(), 5, 1, TablaDePDF)

        helper.Add(TablaDePDF)
        '</Step1>

        helper.PutHorizontalLine(10, 585, 785, 1)

        helper.PutTextStyle3("asdasd asdadsads asdasdas")

        helper.Close()
        Return helper.GetAsStream()
        
    End Function


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Response.ClearHeaders()
        Response.ContentType = "application/pdf"
        Response.Clear()
        Response.AddHeader("Content-Disposition", "inline;filename=""Filename.pdf""")
        Dim stream As System.IO.MemoryStream = GetPdfByHelper(1)
        Response.BinaryWrite(stream.ToArray())
        Response.End()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getDataSet()
    End Sub
End Class
