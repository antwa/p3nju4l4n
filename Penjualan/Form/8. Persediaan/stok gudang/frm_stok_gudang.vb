Public Class frm_stok_gudang 

    Sub initComponent()
        tgl_dari.DateTime = DateAdd(DateInterval.Month, -6, Now)
        tgl_sampai.DateTime = Now

        stok.Properties.Items.Add("Semua Stok")
        stok.Properties.Items.Add("Stok Kosong")
        stok.Properties.Items.Add("Stok Lebih Dari Nol")

        stok.SelectedIndex = 0

    End Sub

    Sub loadData()

        Db.FlushCache()
        Db.Selects("a.kode_barangjadi, b.nama, c.kategori, b.harga_pokok, a.stok, b.keterangan")
        Db.From("tbl_persediaan_gudang a")
        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
        Db.Join("tbl_kategori_barang c", "c.kode_kategori = b.kode_kategori")

        Db.OrderBy("a.kode_barangjadi")

        If chk_all_aartikel.Checked = False Then
            Db.Where("a.kode_barangjadi", kode_barangjadi.Text)
        End If

        If stok.SelectedIndex = 1 Then
            Db.Where("a.stok", "0", "<=")
        ElseIf stok.SelectedIndex = 2 Then
            Db.Where("a.stok", "0", ">")
        End If

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        '# format grid
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama").Caption = "Nama Artikel"
        GridView1.Columns("kategori").Caption = "Kategori"
        GridView1.Columns("harga_pokok").Caption = "Harga Pokok (Rp.)"
        GridView1.Columns("stok").Caption = "Stok (Pcs)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("kode_barangjadi").Width = 115
        GridView1.Columns("nama").Width = 150
        GridView1.Columns("kategori").Width = 85
        GridView1.Columns("harga_pokok").Width = 100
        GridView1.Columns("stok").Width = 70
        GridView1.Columns("keterangan").Width = 240

        FormatColumnNumeric(GridView1.Columns("harga_pokok"))
        FormatColumnNumeric(GridView1.Columns("stok"))

    End Sub

    Private Sub cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_GETARTIKEL
        frm_transaksi_popup_artkel.txt_artikel = kode_barangjadi
        frm_transaksi_popup_artkel.lbl_nama_artikel = lbl_nama_artikel
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_aartikel.CheckedChanged
        kode_barangjadi.Enabled = Not chk_all_aartikel.Checked
        cmd_cari.Enabled = Not chk_all_aartikel.Checked
    End Sub

    Private Sub frm_stok_gudang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call Me.loadData()
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        '# Create Header
        Dim StrHeader As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}}\viewkind4\uc1\pard\qc\b\f0\fs24 LAPORAN STOK GUDANG\b0\fs20\par $tgl_dari-$tgl_sampai \par\par\par}"
        StrHeader = StrHeader.Replace("$tgl_dari", tgl_dari.Text)
        StrHeader = StrHeader.Replace("$tgl_sampai", tgl_sampai.Text)
        ' set header and create document print
        PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = True
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
        PrintableComponentLink1.CreateDocument()
        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Stok Gudang"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub

    Private Sub cmd_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_excel.Click
        With SaveFileDialog1
            .Filter = "Exel File 2007 (*.Xlsx)|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(.FileName)
            End If
        End With
    End Sub
End Class