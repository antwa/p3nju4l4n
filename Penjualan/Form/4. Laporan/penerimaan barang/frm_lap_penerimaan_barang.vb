Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_lap_penerimaan_barang

    Sub load_data()

        My.Application.DoEvents()

        Dim tg_dari As DateTime = tgl_dari.DateTime
        Dim tg_sampai As DateTime = tgl_sampai.DateTime

        '# master
        Db.FlushCache()
        Db.Selects("a.nomor_terima, a.tanggal, b.kode_barangjadi, c.nama AS nama_barang, b.qty, b.keterangan, a.kode_supplier_barang, d.nama AS nama_supplier, a.no_suratjalan")
        Db.From("tbl_penerimaanbarang a")
        Db.Join("tbl_penerimaanbarang_detail b", "b.nomor_terima = a.nomor_terima")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
        Db.Join("tbl_supplier_barang d", "d.kode_supplier_barang = a.kode_supplier_barang")

        Db.Where_BetweenDate("a.tanggal", tgl_dari.DateTime, tgl_sampai.DateTime)

        If kode_barangjadi.Text <> "" Then
            Db.Where(" AND b.kode_barangjadi LIKE '" & kode_barangjadi.Text & "%'")
        End If

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        '# format grid
        GridView1.Columns("nomor_terima").Caption = "No. Terima"
        GridView1.Columns("tanggal").Caption = "Tanggal"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barang").Caption = "Nama Artikel"
        GridView1.Columns("kode_supplier_barang").Caption = "Kode Supplier"
        GridView1.Columns("nama_supplier").Caption = "Nama Supplier"
        GridView1.Columns("no_suratjalan").Caption = "No. Surat Jalan"

        GridView1.Columns("nomor_terima").Width = 95
        GridView1.Columns("tanggal").Width = 85
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("nama_barang").Width = 130
        GridView1.Columns("kode_supplier_barang").Width = 105
        GridView1.Columns("nama_supplier").Width = 135
        GridView1.Columns("no_suratjalan").Width = 100

    End Sub

    Private Sub frm_lap_penerimaan_barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl_dari.DateTime = DateAdd(DateInterval.Month, -3, Now)
        tgl_sampai.DateTime = Now
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        '# Create Header
        Dim StrHeader As String = PrintableComponentLink1.RtfReportHeader
        StrHeader = StrHeader.Replace("$tannggal", tgl_dari.Text & "/" & tgl_sampai.Text)
        
        PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = True
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
        PrintableComponentLink1.CreateDocument()
        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Laporan Penerimaan Barang"
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        GridView1.ExpandAllGroups()
    End Sub

    Private Sub GridView1_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GridView1.MasterRowExpanded
        Dim masterView As GridView = CType(sender, GridView)
        Dim detailView As GridView = CType(masterView.GetDetailView(e.RowHandle, e.RelationIndex), GridView)

        detailView.Columns("nomor_terima").Visible = False
        detailView.Columns("kode_barangjadi").Caption = "Kode Artikel"
        detailView.Columns("nama_barang").Caption = "Nama Artikel"
        detailView.Columns("qty").Caption = "Qty (Pcs)"
        detailView.Columns("keterangan").Caption = "Keterangan"

        detailView.BestFitColumns()

    End Sub
End Class