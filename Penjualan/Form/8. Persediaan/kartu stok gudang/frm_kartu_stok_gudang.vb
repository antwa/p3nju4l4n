Public Class frm_kartu_stok_gudang 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_kartu_stok_gudang)

    Sub load_data()
        Dim tg_dari As DateTime = tgl_dari.DateTime
        Dim tg_sampai As DateTime = tgl_sampai.DateTime
        Dim i As Integer

        rcd_list.Clear()

        '# ambil saldo awal
        Db.FlushCache()
        Db.Selects("kode_barangjadi, SUM(masuk) AS masuk, SUM(keluar) AS keluar")
        Db.From("tbl_kartustok_gudang")
        Db.Where("kode_barangjadi", kode_barangjadi.Text)
        Db.Where("tanggal", tg_dari.ToString("yyyy-MM-dd 00:00:00"), "<=")
        Db.GroupBy("kode_barangjadi")
        'Db.OrderBy("tanggal", cls_database.sorting.Ascending)

        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        If dt1.Rows.Count > 0 Then
            rcd_list.Add(New rcd_kartu_stok_gudang(1, Nothing, vbNullString, "Saldo Awal", dt1.Rows(0).Item("masuk").ToString, dt1.Rows(0).Item("keluar").ToString, (CInt(dt1.Rows(0).Item("masuk").ToString) - CInt(dt1.Rows(0).Item("keluar").ToString))))
        Else
            rcd_list.Add(New rcd_kartu_stok_gudang(1, Nothing, "-", "Saldo Awal", 0, 0, 0))
        End If

        '# ambil artikel
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kartustok_gudang")
        Db.Where("kode_barangjadi", kode_barangjadi.Text)
        Db.Where_BetweenDate("tanggal", tg_dari.ToString("yyyy-MM-dd"), tg_sampai.ToString("yyyy-MM-dd"))
        Db.OrderBy("tanggal", cls_database.sorting.Ascending)

        Dim dt2 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        Dim nom As Integer = 2
        If dt2.Rows.Count > 0 Then
            For i = 0 To dt2.Rows.Count - 1
                rcd_list.Add(New rcd_kartu_stok_gudang(nom, dt2.Rows(i).Item("tanggal").ToString, dt2.Rows(i).Item("referensi").ToString, dt2.Rows(i).Item("deskripsi").ToString, dt2.Rows(i).Item("masuk").ToString, dt2.Rows(i).Item("keluar").ToString, (rcd_list.Item(i).saldo + dt2.Rows(i).Item("masuk").ToString) - CInt(dt2.Rows(i).Item("keluar").ToString)))
                nom += 1
            Next
        End If

        dt1 = Nothing
        dt2 = Nothing
    End Sub

    Private Sub frm_kartu_stok_gudang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl_dari.DateTime = DateAdd(DateInterval.Month, -3, Now)
        tgl_sampai.DateTime = Now

        rcd_list = New System.ComponentModel.BindingList(Of rcd_kartu_stok_gudang)

        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("tanggal").Caption = "Tanggal"
        GridView1.Columns("referensi").Caption = "Referensi"
        GridView1.Columns("deskripsi").Caption = "Deskripsi"
        GridView1.Columns("masuk").Caption = "Masuk"
        GridView1.Columns("keluar").Caption = "Keluar"
        GridView1.Columns("saldo").Caption = "Saldo"

        GridView1.Columns("no").Width = 35
        GridView1.Columns("tanggal").Width = 85
        GridView1.Columns("referensi").Width = 130
        GridView1.Columns("deskripsi").Width = 145
        GridView1.Columns("masuk").Width = 65
        GridView1.Columns("keluar").Width = 65
        GridView1.Columns("saldo").Width = 65

        FormatColumnAccounting(GridView1.Columns("masuk"))
        FormatColumnAccounting(GridView1.Columns("keluar"))
        FormatColumnAccounting(GridView1.Columns("saldo"))

        ' tambah sumary dan atur formatnya pada footer
        GridView1.Columns("masuk").Summary.Clear()
        GridView1.Columns("masuk").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "masuk", "{0:n0}")

        GridView1.Columns("keluar").Summary.Clear()
        GridView1.Columns("keluar").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "keluar", "{0:n0}")

        'GridView1.Columns("saldo").Summary.Clear()
        'GridView1.Columns("saldo").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "saldo", "{0:n0}")

    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        '# Create Header
        Dim StrHeader As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}}\viewkind4\uc1\pard\qc\b\f0\fs24 KARTU STOK BARANG JADI\par\b0\fs20 $tgl_print\par\parKode Artikel : \b $kode_barangjadi\b0    ($tgl_dari - $tgl_sampai)\par\par}"
        StrHeader = StrHeader.Replace("$tgl_print", Now)
        StrHeader = StrHeader.Replace("$kode_barangjadi", kode_barangjadi.Text)
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
        fc.Text = "Print Kartu Stok Gudang"
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

    Private Sub cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_GETARTIKEL
        frm_transaksi_popup_artkel.txt_artikel = kode_barangjadi
        frm_transaksi_popup_artkel.lbl_nama_artikel = lbl_nama_artikel
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        load_data()
    End Sub
End Class