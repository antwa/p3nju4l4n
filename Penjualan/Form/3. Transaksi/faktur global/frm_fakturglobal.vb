Public Class frm_fakturglobal 

    Public rcd_list As New System.ComponentModel.BindingList(Of rcd_fakturglobal)

    Sub initComponent()

        no_faktur.Text = getNomorUrut(C_FAKTUR_GLOBAL)
        tgl_terbit.DateTime = Now
        Load_CustomerParent(kode_customer_parent, 1)
        tgl_dari.DateTime = Now
        tgl_sampai.DateTime = Now

        tgl_terbit.Enabled = True
        kode_customer_parent.Enabled = True

        '# Grid
        rcd_list.Clear()
        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barangjadi").Caption = "Nama Artikel"
        GridView1.Columns("qty").Caption = "Qty (Pcs)"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("total").Caption = "Total (Rp.)"

        'width
        GridView1.Columns("no").Width = 35
        GridView1.Columns("kode_barangjadi").Width = 105
        GridView1.Columns("nama_barangjadi").Width = 135
        GridView1.Columns("qty").Width = 60
        GridView1.Columns("harga").Width = 80
        GridView1.Columns("total").Width = 80

        'format numeric
        FormatColumnNumeric(GridView1.Columns("qty"))
        FormatColumnNumeric(GridView1.Columns("harga"))
        FormatColumnNumeric(GridView1.Columns("total"))

        'add sumary
        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("total"))

        ' desable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next

        GridView1.RefreshData()

    End Sub

    Sub LoadData()

        'rcd_list = New System.ComponentModel.BindingList(Of rcd_fakturglobal)
        rcd_list.Clear()

        Db.FlushCache()
        Db.Selects("b.kode_barangjadi, c.nama, SUM(b.qty) AS qty, b.harga")
        Db.From("tbl_suratjalan a")
        Db.Join("tbl_suratjalan_detail b", "a.no_surat = b.no_surat")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
        Db.Where(" WHERE a.kode_customer_child LIKE '" & getValueFromLookup(kode_customer_parent) & "%'")
        Db.Where_BetweenDate("a.tgl_surat", tgl_dari.DateTime, tgl_sampai.DateTime)

        Db.GroupBy("b.kode_barangjadi, c.nama, b.harga")

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        Dim i As Integer

        If dt.Rows.Count > 0 Then
            Dim count As Integer = dt.Rows.Count - 1
            For i = 0 To count
                rcd_list.Add(New rcd_fakturglobal(i + 1, dt.Rows(i).Item("kode_barangjadi"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("qty"), dt.Rows(i).Item("harga")))
            Next

            kode_customer_parent.Enabled = False
            tgl_terbit.Enabled = False

            GridView1.RefreshData()
        Else
            MsgBox("Tidak terdapat transaksi.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub frm_fakturglobal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        rcd_list.Clear()
        kode_customer_parent.Enabled = True
        tgl_terbit.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call Me.LoadData()
    End Sub

    Private Sub cmd_print_amplop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print_amplop_polos.Click
        generateColumnGrid(GridView1)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer
        Dim count As Integer = rcd_list.Count - 1

        '# validation
        If Not rcd_list.Count > 0 Then
            MsgBox("Tidak ada data yang akan disimpan kedalam database!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Transaksi
        Connection.TRANS_START()

        '# insert to table tbl_fakturglobal
        Db.FlushCache()
        Db.Insert("tbl_fakturglobal")
        Db.SetField("no_faktur", no_faktur.Text)
        Db.SetField("kode_customer_parent", getValueFromLookup(kode_customer_parent))
        Db.SetField("tgl_terbit", tgl_terbit.DateTime)
        Db.SetField("total_qty", GridView1.Columns.Item("qty").Summary.Item(0).SummaryValue)
        Db.SetField("total_harga", GridView1.Columns.Item("total").Summary.Item(0).SummaryValue)
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        '# insert to detail
        For i = 0 To count
            '# insert to table tbl_fakturglobal_detail
            Db.FlushCache()
            Db.Insert("tbl_fakturglobal_detail")
            Db.SetField("no_faktur", no_faktur.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.SetField("total", rcd_list.Item(i).total)

            Connection.TRANS_ADD(Db.GetQueryString)
        Next

        'Commit transaksi
        If Connection.TRANS_SUCCESS Then
            'ambil informasi customer
            Db.FlushCache()
            Db.Selects("a.nama, b.kota, a.mall, a.alamat")
            Db.From("tbl_customer_parent a")
            Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
            Db.Where("a.kode_customer_parent", getValueFromLookup(kode_customer_parent))

            Dim rcustomer As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
            rcustomer.Read()

            '# Print
            Dim rpt As New rpt_fakturglobal
            rpt.BindingSource1.DataSource = rcd_list

            rpt.no_faktur.Text = "Nomor : " & no_faktur.Text
            rpt.tgl_teribit.Text = tgl_terbit.Text
            rpt.nama.Text = rcustomer.Item("nama").ToString
            rpt.alamat.Text = rcustomer.Item("alamat").ToString
            rpt.mall.Text = rcustomer.Item("mall").ToString
            rpt.kota.Text = rcustomer.Item("kota").ToString

            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Faktur Global"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            Call Me.initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub cmd_print_amplop_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print_amplop.Click
        Db.FlushCache()
        Db.Selects("a.nama AS nama_customer, a.alamat, b.kota")
        Db.From("tbl_customer a")
        Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
        Db.Where("kode_customer", getValueFromLookup(kode_customer_parent))

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If r.Rows.Count > 0 Then
            '# Print
            Dim rpt As New rpt_amplop

            rpt.lbl_nama_customer.Text = r.Rows(0).Item("nama_customer")
            rpt.lbl_alamat.Text = r.Rows(0).Item("alamat")
            rpt.lbl_kota.Text = r.Rows(0).Item("kota")

            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Amplop"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 500
            fc.ShowDialog(Me)
        End If

    End Sub
End Class
