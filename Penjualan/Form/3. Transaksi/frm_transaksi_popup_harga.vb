Public Class frm_transaksi_popup_harga 

    Public parameter1 As String
    Public kode_barangjadi As String
    Public nama As String
    Public stok As Integer
    Public row As Integer

    Sub addArtikel()
        Dim i As Integer = 0
        Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        Select Case parameter1

            Case C_SALES_ORDER
                With frm_sales_order
                    .rcd_list.Item(0).kode_hargajual = row("kode_hargajual")
                    .rcd_list.Item(0).harga = row("harga")
                    .GridView1.RefreshData()
                End With

        End Select

        Me.Close()
    End Sub

    Private Sub frm_transaksi_popup_harga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_kode_barangjadi.Text = kode_barangjadi
        lbl_nama.Text = nama

        ' load harga
        Db.FlushCache()
        Db.Selects("a.kode_hargajual, b.nama_harga, a.harga")
        Db.From("tbl_hargajual a")
        Db.Join("tbl_template_hargajual b", "b.kode_template_harga = a.kode_template_harga")
        Db.Where("kode_barangjadi", kode_barangjadi)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridView1.Columns.Item(0).Visible = False
        GridView1.Columns.Item(1).Caption = "Nama Harga"
        GridView1.Columns.Item(2).Caption = "Harga (Rp.)"

        FormatColumnNumeric(GridView1.Columns.Item(2))

        GridView1.Columns.Item(1).Caption = "Nama Harga"
        GridView1.Columns.Item(2).Caption = "Harga (Rp.)"

        GridView1.Columns.Item(1).Width = 200
        GridView1.Columns.Item(2).Width = 100

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Call addArtikel()
    End Sub
End Class