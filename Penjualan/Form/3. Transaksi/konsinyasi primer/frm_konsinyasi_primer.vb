Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_konsinyasi_primer

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_konsinyasi_primer)

    Sub reIndex()
        Dim i As Integer = 1
        For i = 1 To rcd_list.Count
            rcd_list.Item(i - 1).no = i
        Next

        rcd_list.Item(rcd_list.Count - 1).no = 0

        If rcd_list.Count > 1 Then
            kode_customer.Properties.ReadOnly = True
            'tgl.Properties.ReadOnly = True
        Else
            kode_customer.Properties.ReadOnly = False
            'tgl_transaksi.Properties.ReadOnly = False
        End If

        GridView1.RefreshData()
    End Sub

    Sub InformasiCustomer()
        Dim vkode_customer As String = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)

        Try
            Db.FlushCache()
            Db.Selects("a.kode_customer, a.nama, a.alamat, a.mall, b.kota, a.margin_toko, a.dis_konsumen")
            Db.From("tbl_customer a")
            Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
            Db.Where("a.kode_customer", vkode_customer)

            Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

            If rc.HasRows Then
                With rc
                    .Read()
                    lbl_alamat.Text = .Item("alamat").ToString
                    lbl_kota.Text = .Item("kota").ToString
                    lbl_mall.Text = .Item("mall").ToString
                    lbl_nama.Text = .Item("nama").ToString

                    margin_toko.Text = .Item("margin_toko").ToString
                    margin_konsumen.Text = .Item("dis_konsumen").ToString

                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub initComponent()

        no_penjualan.Text = getNomorUrut(C_KONSINYASI_PRIMER)
        tgl_terbit.DateTime = Now

        Load_Customer(kode_customer, 1)
        Call InformasiCustomer()

        rcd_list = New System.ComponentModel.BindingList(Of rcd_konsinyasi_primer)
        GridControl1.DataSource = rcd_list

        '# new item
        rcd_list.Add(New rcd_konsinyasi_primer)

        Call reIndex()

        'disc_acara.Text = "0"
        'disc_acara_kita.Text = "0"
        'disc_acara_toko.Text = "0"

        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("tgl_transaksi").Caption = "Tgl Trans"
        GridView1.Columns("kode_barangjadi").Caption = "Kode"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("qty").Caption = "Jml"
        GridView1.Columns("harga").Caption = "Harga"
        GridView1.Columns("diskon").Caption = "Disc"
        GridView1.Columns("total").Caption = "Total"
        GridView1.Columns("harga2").Caption = "Harga"
        GridView1.Columns("diskon2").Caption = "Disc"
        GridView1.Columns("bruto").Caption = "Bruto"
        GridView1.Columns("margin").Caption = "Margin (-)"
        GridView1.Columns("acara").Caption = "Acara (-)"
        GridView1.Columns("toko").Caption = "Toko (+)"
        GridView1.Columns("netto").Caption = "Netto"
        GridView1.Columns("disc_acara").Caption = "Acara"
        GridView1.Columns("disc_acara_kita").Caption = "Kita"
        GridView1.Columns("disc_acara_toko").Caption = "Toko"
        GridView1.Columns("margin_toko").Caption = "Toko"
        GridView1.Columns("margin_konsumen").Caption = "Kons"

        GridView1.Columns("no").Width = 30
        GridView1.Columns("tgl_transaksi").Width = 100
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("nama").Width = 100
        GridView1.Columns("qty").Width = 50
        GridView1.Columns("harga").Width = 75
        GridView1.Columns("diskon").Width = 50
        GridView1.Columns("total").Width = 75
        GridView1.Columns("harga2").Width = 75
        GridView1.Columns("diskon2").Width = 50
        GridView1.Columns("bruto").Width = 75
        GridView1.Columns("margin").Width = 75
        GridView1.Columns("acara").Width = 75
        GridView1.Columns("toko").Width = 75
        GridView1.Columns("netto").Width = 75
        GridView1.Columns("disc_acara").Width = 40
        GridView1.Columns("disc_acara_kita").Width = 35
        GridView1.Columns("disc_acara_toko").Width = 35
        GridView1.Columns("margin_toko").Width = 35
        GridView1.Columns("margin_konsumen").Width = 35

        '' visible column
        GridView1.Columns("total").Visible = False
        GridView1.Columns("sebelum_disc_acara").Visible = False
        'GridView1.Columns("disc_acara").Visible = False
        'GridView1.Columns("disc_acara_kita").Visible = False
        'GridView1.Columns("disc_acara_toko").Visible = False
        'GridView1.Columns("margin_toko").Visible = False
        'GridView1.Columns("margin_konsumen").Visible = False

        ' format
        FormatColumnNumeric(GridView1.Columns("harga"))
        FormatColumnNumeric(GridView1.Columns("total"))
        FormatColumnNumeric(GridView1.Columns("harga2"))
        FormatColumnNumeric(GridView1.Columns("bruto"))
        FormatColumnNumeric(GridView1.Columns("margin"))
        FormatColumnNumeric(GridView1.Columns("acara"))
        FormatColumnNumeric(GridView1.Columns("toko"))
        FormatColumnNumeric(GridView1.Columns("netto"))

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns("tgl_transaksi").OptionsColumn.AllowEdit = True
        GridView1.Columns("kode_barangjadi").OptionsColumn.AllowEdit = True
        GridView1.Columns("qty").OptionsColumn.AllowEdit = True
        GridView1.Columns("harga").OptionsColumn.AllowEdit = True
        GridView1.Columns("diskon").OptionsColumn.AllowEdit = True
        GridView1.Columns("disc_acara").OptionsColumn.AllowEdit = True
        GridView1.Columns("disc_acara_kita").OptionsColumn.AllowEdit = True
        'GridView1.Columns("disc_acara_toko").OptionsColumn.AllowEdit = True
        GridView1.Columns("margin_toko").OptionsColumn.AllowEdit = True
        GridView1.Columns("margin_konsumen").OptionsColumn.AllowEdit = True

        ' Atur warna cell
        GridView1.Columns.Item("harga2").AppearanceCell.BackColor = Color.SeaShell
        GridView1.Columns.Item("diskon2").AppearanceCell.BackColor = Color.SeaShell

        GridView1.Columns("bruto").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(255, 254, 182)
        GridView1.Columns("margin").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(255, 254, 182)
        GridView1.Columns("acara").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(255, 254, 182)
        GridView1.Columns("toko").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(255, 254, 182)
        GridView1.Columns("netto").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(255, 254, 182)

        GridView1.Columns.Item("margin_toko").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(215, 255, 252)
        GridView1.Columns.Item("margin_konsumen").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(215, 255, 252)
        GridView1.Columns.Item("disc_acara").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(215, 255, 252)
        GridView1.Columns.Item("disc_acara_kita").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(215, 255, 252)
        GridView1.Columns.Item("disc_acara_toko").AppearanceCell.BackColor = System.Drawing.Color.FromArgb(215, 255, 252)

        ' Create summary
        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("bruto"))
        CreateColumnSummary(GridView1.Columns("margin"))
        CreateColumnSummary(GridView1.Columns("acara"))
        CreateColumnSummary(GridView1.Columns("toko"))
        CreateColumnSummary(GridView1.Columns("netto"))

        '# Create Band
        Dim BArtikel As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BDijual As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BDitetapkan As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim Bketerangan As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BMargin As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BDiskon As New DevExpress.XtraGrid.Views.BandedGrid.GridBand

        With BArtikel
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = "Artikel"
        End With
        With BDijual
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = "Yang Dijual"
        End With
        With BDitetapkan
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = "Yang Ditetapkan"
        End With
        With Bketerangan
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = " "
        End With
        With BMargin
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = "Margin (%)"
        End With
        With BDiskon
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = "Diskon (%)"
        End With

        GridView1.Bands.Clear()
        GridView1.Bands.Add(BArtikel)
        GridView1.Bands.Add(BDijual)
        GridView1.Bands.Add(BDitetapkan)
        GridView1.Bands.Add(Bketerangan)
        GridView1.Bands.Add(BMargin)
        GridView1.Bands.Add(BDiskon)

        '#  atur aparance
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next

        '# add column to band
        ' Artikel
        BArtikel.Columns.Add(GridView1.Columns("no"))
        BArtikel.Columns.Add(GridView1.Columns("tgl_transaksi"))
        BArtikel.Columns.Add(GridView1.Columns("kode_barangjadi"))
        BArtikel.Columns.Add(GridView1.Columns("nama"))

        BDijual.Columns.Add(GridView1.Columns("qty"))
        BDijual.Columns.Add(GridView1.Columns("harga"))
        BDijual.Columns.Add(GridView1.Columns("diskon"))
        BDijual.Columns.Add(GridView1.Columns("total"))

        BDitetapkan.Columns.Add(GridView1.Columns("harga2"))
        BDitetapkan.Columns.Add(GridView1.Columns("diskon2"))

        Bketerangan.Columns.Add(GridView1.Columns("bruto"))
        Bketerangan.Columns.Add(GridView1.Columns("margin"))
        Bketerangan.Columns.Add(GridView1.Columns("acara"))
        Bketerangan.Columns.Add(GridView1.Columns("toko"))
        Bketerangan.Columns.Add(GridView1.Columns("netto"))

        ' untuk debug
        'BMargin.Columns.Add(GridView1.Columns("sebelum_disc_acara"))
        BMargin.Columns.Add(GridView1.Columns("margin_toko"))
        BMargin.Columns.Add(GridView1.Columns("margin_konsumen"))
        BDiskon.Columns.Add(GridView1.Columns("disc_acara"))
        BDiskon.Columns.Add(GridView1.Columns("disc_acara_kita"))
        BDiskon.Columns.Add(GridView1.Columns("disc_acara_toko"))

    End Sub

    Private Sub frm_konsinyasi_primer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub disc_acara_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc_acara.EditValueChanged
        Try
            disc_acara_kita.Text = CInt(disc_acara.Text) / 2
            disc_acara_toko.Text = CInt(disc_acara.Text) / 2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub disc_acara_kita_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc_acara_kita.EditValueChanged
        Try
            If CInt(disc_acara_kita.Text) > CInt(disc_acara.Text) Then
                'MsgBox("Disc acara tidak boleh lebih kecil", MsgBoxStyle.Exclamation)
                disc_acara_kita.Text = disc_acara.Text
            End If

            disc_acara_toko.Text = CInt(disc_acara.Text) - CInt(disc_acara_kita.Text)

            Dim i As Integer
            For i = 0 To rcd_list.Count - 1
                rcd_list.Item(i).disc_acara = disc_acara.Text
                rcd_list.Item(i).disc_acara_kita = disc_acara_kita.Text
                rcd_list.Item(i).disc_acara_toko = disc_acara_toko.Text
                rcd_list.Item(i).Sumary()
            Next

            GridView1.RefreshData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_KONSINYASI_PRIMER
        frm_transaksi_popup_artkel.kode_customer = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
        frm_transaksi_popup_artkel.ShowDialog(Me)
        Call reIndex()
    End Sub

    Private Sub sebelum_disc_acara_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sebelum_disc_acara.SelectedIndexChanged
        Try
            Dim sbl_acara As Boolean = IIf(sebelum_disc_acara.EditValue = "1", True, False)
            Dim i As Integer
            For i = 0 To rcd_list.Count - 1
                rcd_list.Item(i).sebelum_disc_acara = sbl_acara
                rcd_list.Item(i).Sumary()
            Next

            GridView1.RefreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub margin_toko_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles margin_toko.EditValueChanged
        Try
            Dim i As Integer
            For i = 0 To rcd_list.Count - 1
                rcd_list.Item(i).margin_toko = margin_toko.Text
                rcd_list.Item(i).Sumary()
            Next

            GridView1.RefreshData()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub margin_konsumen_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles margin_konsumen.EditValueChanged
        Try
            Dim i As Integer
            For i = 0 To rcd_list.Count - 1
                rcd_list.Item(i).margin_konsumen = margin_konsumen.Text
                rcd_list.Item(i).Sumary()
            Next

            GridView1.RefreshData()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Dim rowNewItem As Integer = rcd_list.Count - 1
        Try
            If row <> rowNewItem Then
                rcd_list.RemoveAt(row)
                Call reIndex()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim vkode_customer As String = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
        Dim i As Integer
        Dim Query As String = vbNullString

        '# Cek Grid
        If GridView1.RowCount <= 1 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# cek nomor penjualan
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_konsinyasiprimer")
        Db.Where("no_penjualan", no_penjualan.Text)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# Begin Transaction
        Connection.TRANS_START()

        '# insert to table tbl_konsinyasiprimer
        Db.FlushCache()
        Db.Insert("tbl_konsinyasiprimer")
        Db.SetField("no_penjualan", no_penjualan.Text)
        Db.SetField("tgl_terbit", tgl_terbit.DateTime)
        Db.SetField("kode_customer", vkode_customer)
        Db.SetField("margin", sebelum_disc_acara.EditValue)
        Db.SetField("disc_acara", disc_acara.Text)
        Db.SetField("disc_acara_kita", disc_acara_kita.Text)
        Db.SetField("disc_acara_toko", disc_acara_toko.Text)
        Db.SetField("margin_toko", margin_toko.Text)
        Db.SetField("margin_konsumen", margin_konsumen.Text)
        Db.SetField("total_qty", GridView1.Columns("qty").Summary.Item(0).SummaryValue)
        Db.SetField("total_bruto", GridView1.Columns("bruto").Summary.Item(0).SummaryValue)
        Db.SetField("total_margin", GridView1.Columns("margin").Summary.Item(0).SummaryValue)
        Db.SetField("total_acara", GridView1.Columns("acara").Summary.Item(0).SummaryValue)
        Db.SetField("total_toko", GridView1.Columns("toko").Summary.Item(0).SummaryValue)
        Db.SetField("total_netto", GridView1.Columns("netto").Summary.Item(0).SummaryValue)
        Db.SetField("keterangan", keterangan.Text)
        Db.SetField("status", "0")
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 2
            '# insert to table tbl_konsinyasiprimer_detail
            Db.FlushCache()
            Db.Insert("tbl_konsinyasiprimer_detail")
            Db.SetField("no_penjualan", no_penjualan.Text)
            Db.SetField("tgl_transaksi", rcd_list.Item(i).tgl_transaksi)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.SetField("diskon", rcd_list.Item(i).diskon)
            Db.SetField("total", rcd_list.Item(i).total)
            Db.SetField("bruto", rcd_list.Item(i).bruto)
            Db.SetField("margin", rcd_list.Item(i).margin)
            Db.SetField("acara", rcd_list.Item(i).acara)
            Db.SetField("toko", rcd_list.Item(i).toko)
            Db.SetField("netto", rcd_list.Item(i).netto)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update stok customer
            Query = ""
            Query &= " UPDATE tbl_persediaan_customer "
            Query &= " SET stok_primer = stok_primer - " & rcd_list.Item(i).qty
            Query &= " WHERE kode_customer = '" & vkode_customer & "' "
            Query &= " AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "' "

            Connection.TRANS_ADD(Query)
        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If


    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        GridView1.RefreshData()
    End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If e.Column.FieldName = "tgl_transaksi" Then

            Dim CurRow As Integer = e.RowHandle
            Dim rc As SqlClient.SqlDataReader
            Dim tgl As DateTime = e.Value

            '# ambil harga yg ditetapkan
            Db.FlushCache()
            Db.Selects("TOP 1 a.harga, a.diskon")
            Db.From("tbl_histori_hargacustomer a")
            Db.Where("a.kode_barangjadi", rcd_list.Item(CurRow).kode_barangjadi)
            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
            Db.Where("a.tanggal", tgl.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
            Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

            rc = Connection.ExecuteToDataReader(Db.GetQueryString)

            If rc.HasRows Then
                rc.Read()
                rcd_list.Item(CurRow).harga = rc.Item("harga").ToString
                rcd_list.Item(CurRow).diskon = rc.Item("diskon").ToString

                '.rcd_list.Item(lastrow).kode_hargajual2 = rc.Item("kode_hargajual").ToString
                rcd_list.Item(CurRow).harga2 = rc.Item("harga").ToString
                rcd_list.Item(CurRow).diskon2 = rc.Item("diskon").ToString
            Else
                rcd_list.Item(CurRow).harga = 0
                rcd_list.Item(CurRow).diskon = 0

                '.rcd_list.Item(lastrow).kode_hargajual2 = rc.Item("kode_hargajual").ToString
                rcd_list.Item(CurRow).harga2 = 0
                rcd_list.Item(CurRow).diskon2 = 0
            End If

            rcd_list.Item(CurRow).Sumary()

        End If

        GridView1.RefreshData()
    End Sub

    Private Sub GridControl1_EditorKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.EditorKeyPress
        Dim grid As GridControl = CType(sender, GridControl)
        GridView1_KeyPress(grid.FocusedView, e)
    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        Dim view As GridView = CType(sender, GridView)
        Dim row As Integer = view.FocusedRowHandle
        Dim rowItemNew As Integer = rcd_list.Count - 1

        If view.FocusedColumn.FieldName = "kode_barangjadi" And row <> rowItemNew Then
            e.Handled = True
            Exit Sub
        End If

        If Asc(e.KeyChar) = 13 Then
            If rcd_list.Item(row).kode_barangjadi = vbNullString Then Exit Sub

            Select Case view.FocusedColumn.FieldName
                Case "kode_barangjadi"
                    Dim tmp_kode_barangjadi As String = rcd_list.Item(row).kode_barangjadi
                    tmp_kode_barangjadi = tmp_kode_barangjadi.Replace(".", vbNullString)
                    If tmp_kode_barangjadi.Length < 6 Then
                        MsgBox("Masukan kode dengan benar!", MsgBoxStyle.Exclamation)
                    Else
                        tmp_kode_barangjadi = tmp_kode_barangjadi.Substring(0, 1) & "." & tmp_kode_barangjadi.Substring(1, 3) & "." & tmp_kode_barangjadi.Substring(4, 2)

                        '# get barang jadi
                        Db.FlushCache()
                        Db.Selects("a.kode_barangjadi, b.nama, c.jenis, a.stok_primer as stok")
                        Db.From("tbl_persediaan_customer a")
                        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
                        Db.Join("tbl_jenis_hargabarang c", "c.kode_jenis_harga = a.kode_jenis_harga")
                        Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
                        Db.Where(" AND a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")

                        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If dt1.Rows.Count > 0 Then
                            rcd_list.Item(row).kode_barangjadi = dt1.Rows(0).Item("kode_barangjadi").ToString
                            rcd_list.Item(row).nama = dt1.Rows(0).Item("nama").ToString
                            'rcd_list.Item(row).stok = dt1.Rows(0).Item("stok").ToString

                            '# ambil harga yg ditetapkan
                            Db.FlushCache()
                            Db.Selects("TOP 1 a.harga, a.diskon")
                            Db.From("tbl_histori_hargacustomer a")
                            Db.Where("a.kode_barangjadi", rcd_list.Item(row).kode_barangjadi)
                            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
                            Db.Where("a.tanggal", rcd_list.Item(row).tgl_transaksi.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
                            Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

                            Dim dt2 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
                            If dt2.Rows.Count > 0 Then
                                rcd_list.Item(row).harga = dt2.Rows(0).Item("harga").ToString
                                rcd_list.Item(row).diskon = dt2.Rows(0).Item("diskon").ToString
                                rcd_list.Item(row).harga2 = dt2.Rows(0).Item("harga").ToString
                                rcd_list.Item(row).diskon2 = dt2.Rows(0).Item("diskon").ToString
                            Else
                                rcd_list.Item(row).harga = 0
                                rcd_list.Item(row).diskon = 0
                                rcd_list.Item(row).harga2 = 0
                                rcd_list.Item(row).diskon2 = 0
                            End If

                            rcd_list.Item(row).disc_acara = disc_acara.Text
                            rcd_list.Item(row).disc_acara_kita = disc_acara_kita.Text
                            rcd_list.Item(row).disc_acara_toko = disc_acara_toko.Text

                            rcd_list.Item(row).margin_toko = margin_toko.Text
                            rcd_list.Item(row).margin_konsumen = margin_konsumen.Text

                            rcd_list.Item(row).Sumary()

                            '# refres data
                            rcd_list.Add(New rcd_konsinyasi_primer)
                            Call Me.reIndex()
                            setFocusCell(GridView1, row, "qty")
                            GridView1.RefreshData()
                        Else
                            MsgBox("Tidak terdapat kode barang '" & tmp_kode_barangjadi & "'", MsgBoxStyle.Exclamation)
                        End If
                    End If

                Case "qty"
                    If row < rowItemNew Then
                        setFocusCell(GridView1, row + 1, "kode_barangjadi")
                    End If
            End Select
        End If
    End Sub


    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer.EditValueChanged
        Call InformasiCustomer()
    End Sub
End Class