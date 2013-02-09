Public Class frm_rencana_distribusi 



    Public rcd_list As New DataTable

    Public Sub AddArtikelToList(ByVal mKode_barangjadi As String, ByVal mNama_barangjadi As String, ByVal mStok As Integer, ByVal mQty As Integer)
        Dim i As Integer
        For i = 4 To rcd_list.Columns.Count - 1
            If rcd_list.Rows(0).Item(i) = mKode_barangjadi Then
                'MsgBox("Artikel Sudah ada dalam list!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        rcd_list.Columns.Add(mKode_barangjadi.Substring(0, 8) & " [" & mStok & "]")

        Dim LastColumn As Integer = rcd_list.Columns.Count - 1

        rcd_list.Rows(0).Item(LastColumn) = mKode_barangjadi
        rcd_list.Rows(1).Item(LastColumn) = mNama_barangjadi
        rcd_list.Rows(2).Item(LastColumn) = mStok

        For i = 3 To rcd_list.Rows.Count - 1
            rcd_list.Rows(i).Item(LastColumn) = mQty
        Next


        Call Me.FormatGridview()

    End Sub

    Sub initComponent()
        no_rencana.Text = getNomorUrut(C_RENCANA_DISTRIBUSI)
        tanggal.DateTime = Now
        keterangan.Text = vbNullString
    End Sub

    Sub FormatGridview()
        Dim i As Integer
        GridView1.PopulateColumns()

        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("kode_customer").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("rank").Caption = "R"

        GridView1.Columns("no").Width = 30
        GridView1.Columns("kode_customer").Width = 100
        GridView1.Columns("nama_customer").Width = 150
        GridView1.Columns("rank").Width = 40

        ' disable
        GridView1.Columns("no").OptionsColumn.AllowEdit = False
        GridView1.Columns("kode_customer").OptionsColumn.AllowEdit = False
        GridView1.Columns("nama_customer").OptionsColumn.AllowEdit = False
        GridView1.Columns("rank").OptionsColumn.AllowEdit = False

        ' atur warna cell
        GridView1.Columns.Item("no").AppearanceCell.BackColor = Color.LemonChiffon
        GridView1.Columns.Item("kode_customer").AppearanceCell.BackColor = Color.LemonChiffon
        GridView1.Columns.Item("nama_customer").AppearanceCell.BackColor = Color.LemonChiffon
        GridView1.Columns.Item("rank").AppearanceCell.BackColor = Color.LemonChiffon

        ' atur align
        'For i = 0 To 3
        '    GridView1.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '    GridView1.Columns(i).AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        'Next

        For i = 4 To rcd_list.Columns.Count - 1
            GridView1.Columns(i).Width = 40
            GridView1.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next

        Call Me.reIndex()
    End Sub

    Sub reIndex()
        Dim i As Integer
        For i = 3 To rcd_list.Rows.Count - 1
            rcd_list.Rows(i).Item("no") = i - 2
        Next

        '# popup
        For i = 4 To rcd_list.Columns.Count - 1
            GridView1.Columns(i).ToolTip = "Kode Artikel : " & rcd_list.Rows(0).Item(i) & vbCrLf & _
                                                "Nama Artikel : " & rcd_list.Rows(1).Item(i) & vbCrLf & _
                                                "Stok : " & rcd_list.Rows(2).Item(i)
        Next
        
    End Sub

    Private Sub frm_rencana_distribusi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()

    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load_customer.Click
        rcd_list = New DataTable

        rcd_list.Columns.Add("no", GetType(Integer))
        rcd_list.Columns.Add("kode_customer", GetType(String))
        rcd_list.Columns.Add("nama_customer", GetType(String))
        rcd_list.Columns.Add("rank", GetType(String))

        rcd_list.Rows.Add(New Object() {0, "artikel", "artikel", "artikel"})
        rcd_list.Rows.Add(New Object() {1, "nama", "nama", "nama"})
        rcd_list.Rows.Add(New Object() {2, "qty", "qty", "qty"})

        '# load customer
        Db.FlushCache()
        Db.Selects("a.kode_customer, a.nama, b.kota, a.prioritas")
        Db.From("tbl_customer a")
        Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
        Db.Where("sistem_jual", "1")
        Db.OrderBy("a.prioritas", cls_database.sorting.Ascending)

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        If dt.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1
                rcd_list.Rows.Add(New Object() {2, dt.Rows(i).Item("kode_customer").ToString, dt.Rows(i).Item("nama").ToString & " [" & dt.Rows(i).Item("kota").ToString & "]", dt.Rows(i).Item("prioritas").ToString})
            Next
        End If

        GridControl1.DataSource = rcd_list
        Call FormatGridview()

    End Sub

    Private Sub cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_GETARTIKEL
        frm_transaksi_popup_artkel.txt_artikel = kode_barangjadi
        frm_transaksi_popup_artkel.lbl_nama_artikel = lbl_nama_artikel
        frm_transaksi_popup_artkel.txt_stok = stok
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub cmd_tambah_kelist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_kelist.Click
        'cek row
        If rcd_list.Rows.Count = 0 Then
            MsgBox("Load Customer terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Validation.clearRules()

        Validation.addRules(kode_barangjadi.Text, "Kode Artikel", "required")
        Validation.addRules(txt_qty.EditValue, "Qty/Jumlah Artikel", "required|numeric")

        If Validation.isValid Then
            Call Me.AddArtikelToList(kode_barangjadi.Text, lbl_nama_artikel.Text, stok.EditValue, txt_qty.EditValue)
            kode_barangjadi.Text = vbNullString
            txt_qty.Text = vbNullString
        Else
            Validation.showMessage()
        End If

    End Sub


    Private Function Transform(ByVal g As Graphics, ByVal degree As Integer, ByVal r As Rectangle) As Rectangle
        g.RotateTransform(degree)
        Dim cos As Single = CSng(Math.Round(Math.Cos(degree * (Math.PI / 180)), 2))
        Dim sin As Single = CSng(Math.Round(Math.Sin(degree * (Math.PI / 180)), 2))
        Dim r1 As Rectangle = r
        r1.X = CInt(Fix(r.X * cos + r.Y * sin))
        r1.Y = CInt(Fix(r.X * (-sin) + r.Y * cos))
        r1.Offset(7, 0)
        Return r1

    End Function
    Private Sub GridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles GridView1.CustomDrawColumnHeader
        Dim r As Rectangle = e.Info.CaptionRect
        e.Info.Caption = ""
        e.Painter.DrawObject(e.Info)
        If Not e.Column Is Nothing Then

            Dim state As System.Drawing.Drawing2D.GraphicsState = e.Graphics.Save()
            Dim sf As StringFormat = New StringFormat()
            sf.Trimming = StringTrimming.EllipsisCharacter
            sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.NoWrap
            'If vertical Then
            If e.Column.ColumnHandle > 3 Then
                sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.DirectionVertical
                'r = Transform(e.Graphics, 45, r)
            End If
            'End If
            'If diagonal Then
            '    r = Transform(e.Graphics, 30, r)
            'End If
            e.Graphics.DrawString(e.Column.GetTextCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf)
            e.Graphics.Restore(state)
        End If
        e.Handled = True
        GridView1.ColumnPanelRowHeight = 95
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub cmd_load_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load_artikel.Click
        frm_rencana_popup_artkel.Dispose()
        frm_rencana_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.Click

        '# validation



        'Begin Transaction
        Connection.TRANS_START()

        '# insert to table tbl_rencana_distribusi
        Db.FlushCache()
        Db.Insert("tbl_rencana_distribusi")
        Db.SetField("no_rencana", no_rencana.Text)
        Db.SetField("tanggal", tanggal.DateTime)
        Db.SetField("keterangan", keterangan.Text)

        Connection.TRANS_ADD(Db.GetQueryString)

        '# Insert Detail
        Dim Cus As Integer
        Dim Art As Integer
        For Cus = 3 To rcd_list.Rows.Count - 1
            For Art = 4 To rcd_list.Columns.Count - 1
                '# insert to table tbl_rencana_distribusi_detail
                Db.FlushCache()
                Db.Insert("tbl_rencana_distribusi_detail")
                Db.SetField("no_rencana", no_rencana.Text)
                Db.SetField("kode_customer", rcd_list.Rows(Cus).Item("kode_customer"))
                Db.SetField("kode_barangjadi", rcd_list.Rows(0).Item(Art))
                Db.SetField("qty", rcd_list.Rows(Cus).Item(Art))

                Connection.TRANS_ADD(Db.GetQueryString)

            Next
        Next
        
        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            'MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            'Call initComponent()
            '# Create Header
            Dim StrHeader As String = "Laporan Rencana Distribusi"
            'StrHeader = StrHeader.Replace("$tgl_print", Now)
            'StrHeader = StrHeader.Replace("$kode_barangjadi", kode_barangjadi.Text)
            'StrHeader = StrHeader.Replace("$tgl_dari", tgl_dari.Text)
            'StrHeader = StrHeader.Replace("$tgl_sampai", tgl_sampai.Text)
            ' set header and create document print
            PrintableComponentLink1.RtfReportHeader = StrHeader
            PrintableComponentLink1.Landscape = True
            PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
            PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
            PrintableComponentLink1.CreateDocument()
            ' set printable to form report control
            Dim fc As New FormReportControl
            fc.Text = "Print Rencana Distribusi"
            fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
            'fc.MdiParent = formMDI
            fc.ShowDialog(Me)
            Me.Close()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub

    Private Sub GridView1_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs) Handles GridView1.CustomRowFilter
        If e.ListSourceRow = 0 Or e.ListSourceRow = 1 Or e.ListSourceRow = 3 Then
            e.Visible = False
            e.Handled = True
        End If
    End Sub
End Class