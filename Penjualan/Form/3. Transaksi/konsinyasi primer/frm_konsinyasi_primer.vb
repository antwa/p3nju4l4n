Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Public Class frm_konsinyasi_primer

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_konsinyasi_primer)
    Dim sebelum_margin As New DataTable
    Dim repo_sebelum_margin As New RepositoryItemGridLookUpEdit

    Sub reIndex()
        Dim i As Integer = 1
        For i = 1 To rcd_list.Count
            rcd_list.Item(i - 1).no = i
        Next

        rcd_list.Item(rcd_list.Count - 1).no = 0

        If rcd_list.Count > 1 Then
            kode_customer_parent.Properties.ReadOnly = True
            'tgl.Properties.ReadOnly = True
        Else
            kode_customer_parent.Properties.ReadOnly = False
            'tgl_transaksi.Properties.ReadOnly = False
        End If

        GridView1.RefreshData()
    End Sub

    Sub InformasiCustomer()
        
        Try
            'ambil informasi customer
            Db.FlushCache()
            Db.Selects("a.nama, c.kota, a.mall, a.alamat")
            Db.From("tbl_customer_parent a")
            'Db.Join("tbl_customer_child b", "b.kode_customer_parent = a.kode_customer_parent")
            Db.Join("tbl_kota c", "c.kode_kota = a.kode_kota")
            Db.Where("a.kode_customer_parent", getValueFromLookup(kode_customer_parent))

            Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

            If rc.HasRows Then
                With rc
                    .Read()
                    lbl_alamat.Text = .Item("alamat").ToString
                    lbl_kota.Text = .Item("kota").ToString
                    lbl_mall.Text = .Item("mall").ToString
                    lbl_nama.Text = .Item("nama").ToString

                    'margin_toko.Text = .Item("margin_toko").ToString
                    'margin_konsumen.Text = .Item("dis_konsumen").ToString

                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub initComponent()

        no_penjualan.Text = getNomorUrut(C_KONSINYASI_PRIMER)
        tgl_terbit.DateTime = Now

        Load_CustomerParent(kode_customer_parent, 1)
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
        GridView1.Columns("kelompok_desk").Caption = "Customer"
        GridView1.Columns("kode_barangjadi").Caption = "Kode"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("stok").Caption = "Stok"
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

        GridView1.Columns("sebelum_disc_acara").Caption = "Margin Acara"
        GridView1.Columns("disc_acara").Caption = "Acara"
        GridView1.Columns("disc_acara_kita").Caption = "Kita"
        GridView1.Columns("disc_acara_toko").Caption = "Toko"
        GridView1.Columns("margin_toko").Caption = "Toko"
        GridView1.Columns("margin_konsumen").Caption = "Kons"

        GridView1.Columns("no").Width = 30
        GridView1.Columns("tgl_transaksi").Width = 100
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("nama").Width = 100
        GridView1.Columns("stok").Width = 50
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
        'GridView1.Columns("sebelum_disc_acara").Visible = false
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
            .Caption = "Penjualan"
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
        'GridView1.Bands.Add(BDitetapkan)
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
        BArtikel.Columns.Add(GridView1.Columns("kelompok_desk"))
        BArtikel.Columns.Add(GridView1.Columns("kode_barangjadi"))
        BArtikel.Columns.Add(GridView1.Columns("nama"))
        BArtikel.Columns.Add(GridView1.Columns("stok"))

        BDijual.Columns.Add(GridView1.Columns("qty"))
        BDijual.Columns.Add(GridView1.Columns("harga"))
        BDijual.Columns.Add(GridView1.Columns("diskon"))
        BDijual.Columns.Add(GridView1.Columns("total"))

        'BDitetapkan.Columns.Add(GridView1.Columns("harga2"))
        'BDitetapkan.Columns.Add(GridView1.Columns("diskon2"))

        Bketerangan.Columns.Add(GridView1.Columns("bruto"))
        Bketerangan.Columns.Add(GridView1.Columns("margin"))
        Bketerangan.Columns.Add(GridView1.Columns("acara"))
        Bketerangan.Columns.Add(GridView1.Columns("toko"))
        Bketerangan.Columns.Add(GridView1.Columns("netto"))

        ' untuk debug
        BMargin.Columns.Add(GridView1.Columns("sebelum_disc_acara"))
        BMargin.Columns.Add(GridView1.Columns("margin_toko"))
        BMargin.Columns.Add(GridView1.Columns("margin_konsumen"))
        BDiskon.Columns.Add(GridView1.Columns("disc_acara"))
        BDiskon.Columns.Add(GridView1.Columns("disc_acara_kita"))
        BDiskon.Columns.Add(GridView1.Columns("disc_acara_toko"))

        ' editor view
        GridView1.Columns("sebelum_disc_acara").ColumnEdit = repo_sebelum_margin

    End Sub

    Private Sub frm_konsinyasi_primer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sebelum_margin.Columns.Add("kode", GetType(Boolean))
        sebelum_margin.Columns.Add("desc", GetType(String))
        sebelum_margin.Rows.Add(New Object() {True, "Sebelum"})
        sebelum_margin.Rows.Add(New Object() {False, "Setelah"})

        repo_sebelum_margin.DataSource = sebelum_margin
        repo_sebelum_margin.ValueMember = "kode"
        repo_sebelum_margin.DisplayMember = "desc"

        Call initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_KONSINYASI_PRIMER
        frm_transaksi_popup_artkel.kode_customer_child = kode_customer_parent.Properties.GetKeyValueByDisplayText(kode_customer_parent.Text)
        frm_transaksi_popup_artkel.ShowDialog(Me)
        Call reIndex()
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
        Dim vkode_customer_parent As String = getValueFromLookup(kode_customer_parent)
        Dim vkode_customer_child As String = ""
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
        Db.SetField("kode_customer_parent", vkode_customer_parent)
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
            vkode_customer_child = vkode_customer_parent & "." & rcd_list.Item(i).kelompok

            '# insert to table tbl_konsinyasiprimer_detail
            Db.FlushCache()
            Db.Insert("tbl_konsinyasiprimer_detail")
            Db.SetField("no_penjualan", no_penjualan.Text)
            Db.SetField("tgl_transaksi", rcd_list.Item(i).tgl_transaksi)
            Db.SetField("kode_customer_child", vkode_customer_child)
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

            Db.SetField("_margin", IIf(rcd_list.Item(i).sebelum_disc_acara = True, "1", "0"))
            Db.SetField("_disc_acara", rcd_list.Item(i).disc_acara)
            Db.SetField("_disc_acara_kita", rcd_list.Item(i).disc_acara_kita)
            Db.SetField("_disc_acara_toko", rcd_list.Item(i).disc_acara_toko)
            Db.SetField("_margin_toko", rcd_list.Item(i).margin_toko)
            Db.SetField("_margin_konsumen", rcd_list.Item(i).margin_konsumen)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update stok customer
            Query = ""
            Query &= " UPDATE tbl_persediaan_customer "
            Query &= " SET stok_primer = stok_primer - " & rcd_list.Item(i).qty
            Query &= " WHERE kode_customer_child = '" & vkode_customer_child & "' "
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
            Dim tgl As DateTime = e.Value

            Dim data() As String = getHargaFromHistori(tgl, _
                                                       getValueFromLookup(kode_customer_parent), _
                                                       rcd_list.Item(CurRow).kode_barangjadi)

            '# get Info barangjadi di persediaan customer
            Dim data1() As String = getInfoBarangjadiInCustomer(getValueFromLookup(kode_customer_parent) & "." & data(2), data(4))

            Dim margin() As String = getMarginCustomer(tgl, getValueFromLookup(kode_customer_parent) & "." & data(2))

            rcd_list.Item(CurRow).stok = data1(3)

            rcd_list.Item(CurRow).harga = data(0)
            rcd_list.Item(CurRow).diskon = data(1)
            rcd_list.Item(CurRow).harga2 = data(0)
            rcd_list.Item(CurRow).diskon2 = data(1)

            rcd_list.Item(CurRow).kelompok = data(2)
            rcd_list.Item(CurRow).kelompok_desk = data(3)

            rcd_list.Item(CurRow).sebelum_disc_acara = margin(0)
            rcd_list.Item(CurRow).disc_acara = margin(1)
            rcd_list.Item(CurRow).disc_acara_kita = margin(2)
            rcd_list.Item(CurRow).disc_acara_toko = margin(3)
            rcd_list.Item(CurRow).margin_toko = margin(4)
            rcd_list.Item(CurRow).margin_konsumen = margin(5)

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
                    If tmp_kode_barangjadi.Length < 7 Then
                        MsgBox("Masukan kode dengan benar!", MsgBoxStyle.Exclamation)
                    Else
                        tmp_kode_barangjadi = tmp_kode_barangjadi.Substring(0, 2) & "." & tmp_kode_barangjadi.Substring(2, 3) & "." & tmp_kode_barangjadi.Substring(5, 2)

                        '# get histori barang
                        Dim data() As String = getHargaFromHistori(rcd_list.Item(row).tgl_transaksi, _
                                                       getValueFromLookup(kode_customer_parent), _
                                                       tmp_kode_barangjadi)

                        If data(2) <> "0" Then
                            '# get Info barangjadi di persediaan customer
                            Dim data1() As String = getInfoBarangjadiInCustomer(getValueFromLookup(kode_customer_parent) & "." & data(2), data(4))

                            '# get margin
                            Dim margin() As String = getMarginCustomer(rcd_list.Item(row).tgl_transaksi, getValueFromLookup(kode_customer_parent) & "." & data(2))

                            rcd_list.Item(row).kode_barangjadi = data1(0)
                            rcd_list.Item(row).nama = data1(1)
                            rcd_list.Item(row).stok = data1(3)

                            rcd_list.Item(row).harga = data(0)
                            rcd_list.Item(row).diskon = data(1)
                            rcd_list.Item(row).harga2 = data(0)
                            rcd_list.Item(row).diskon2 = data(1)

                            rcd_list.Item(row).kelompok = data(2)
                            rcd_list.Item(row).kelompok_desk = data(3)

                            '# margin
                            rcd_list.Item(row).sebelum_disc_acara = margin(0)
                            rcd_list.Item(row).disc_acara = margin(1)
                            rcd_list.Item(row).disc_acara_kita = margin(2)
                            rcd_list.Item(row).disc_acara_toko = margin(3)
                            rcd_list.Item(row).margin_toko = margin(4)
                            rcd_list.Item(row).margin_konsumen = margin(5)

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

    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer_parent.EditValueChanged
        Call InformasiCustomer()
    End Sub

End Class