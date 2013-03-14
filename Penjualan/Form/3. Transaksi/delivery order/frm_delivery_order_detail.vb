Public Class frm_delivery_order_detail 
    Public p_no_so As String

    Dim kode_customer As String
    Dim sistem_jual As Integer

    Sub loadData()

        Db.FlushCache()
        Db.Selects("a.tgl_so, a.kode_customer_child, e.nama AS nama_customer, e.alamat, e.mall, g.kota, a.sistem_jual, b.kode_barangjadi, b.qty, f.stok, b.terkirim, b.kode_hargajual, c.harga")
        Db.From("tbl_salesorder a")
        Db.Join("tbl_salesorder_detail b", "b.no_so = a.no_so")
        Db.Join("tbl_hargajual c", "c.kode_hargajual = b.kode_hargajual")
        Db.Join("tbl_customer_child d", "d.kode_customer_child = a.kode_customer_child")
        Db.Join("tbl_customer_parent e", "e.kode_customer_parent = d.kode_customer_parent")
        Db.Join("tbl_persediaan_gudang f", "f.kode_barangjadi = b.kode_barangjadi")
        Db.Join("tbl_kota g", "g.kode_kota = e.kode_kota")

        Db.Where("a.no_so", p_no_so)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("qty").Caption = "Qty (Pcs)"
        GridView1.Columns("stok").Caption = "Stok (Pcs)"
        GridView1.Columns("terkirim").Caption = "Terkirim"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"

        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("qty").Width = 60
        GridView1.Columns("stok").Width = 65
        GridView1.Columns("terkirim").Width = 65
        GridView1.Columns("harga").Width = 75

        GridView1.Columns("tgl_so").Visible = False
        GridView1.Columns("kode_customer_child").Visible = False
        GridView1.Columns("nama_customer").Visible = False
        GridView1.Columns("alamat").Visible = False
        GridView1.Columns("mall").Visible = False
        GridView1.Columns("kota").Visible = False
        GridView1.Columns("sistem_jual").Visible = False
        GridView1.Columns("kode_hargajual").Visible = False

        FormatColumnNumeric(GridView1.Columns("harga"))

        Try
            Dim i As Integer = 0
            Dim row As System.Data.DataRow = GridView1.GetDataRow(0)

            tgl_so.Text = row("tgl_so")
            no_so.Text = p_no_so
            lbl_alamat.Text = row("alamat")
            lbl_kota.Text = row("kota")
            lbl_mall.Text = row("mall")
            lbl_nama.Text = row("nama_customer")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frm_delivery_order_satu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loadData()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub
End Class