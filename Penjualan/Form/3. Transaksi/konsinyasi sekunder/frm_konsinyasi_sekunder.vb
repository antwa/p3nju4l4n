Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_konsinyasi_sekunder

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_konsinyasi_sekunder)

    Sub reIndex()
        Dim i As Integer = 1
        For i = 1 To rcd_list.Count
            rcd_list.Item(i - 1).no = i
        Next

        rcd_list.Item(rcd_list.Count - 1).no = 0

        If rcd_list.Count > 1 Then
            kode_customer.Properties.ReadOnly = True
        Else
            kode_customer.Properties.ReadOnly = False
        End If

        GridView1.RefreshData()
    End Sub

    Public Sub initComponent()
        Dim i As Integer

        Load_Customer(kode_customer, 1)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_konsinyasi_sekunder)
        GridControl1.DataSource = rcd_list

        '# new row
        rcd_list.Add(New rcd_konsinyasi_sekunder)

        Call reIndex()

        '# atur grid
        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("tgl_transaksi").Caption = "Tanggal"
        GridView1.Columns("kode_barangjadi").Caption = "Kode"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("stok").Caption = "Stok"
        GridView1.Columns("qty").Caption = "Qty"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("diskon").Caption = "Disc (%)"
        GridView1.Columns("total").Caption = "Total (Rp.)"
        GridView1.Columns("harga2").Caption = "Harga (Rp.)"
        GridView1.Columns("diskon2").Caption = "Disc (%)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("no").Width = 50
        GridView1.Columns("tgl_transaksi").Width = 90
        GridView1.Columns("kode_barangjadi").Width = 115
        GridView1.Columns("nama").Width = 130
        GridView1.Columns("stok").Width = 60
        GridView1.Columns("qty").Width = 60
        GridView1.Columns("harga").Width = 90
        GridView1.Columns("diskon").Width = 60
        GridView1.Columns("total").Width = 90
        GridView1.Columns("harga2").Width = 90
        GridView1.Columns("diskon2").Width = 60
        GridView1.Columns("keterangan").Width = 250

        ' visible column
        GridView1.Columns("kode_hargajual").Visible = False
        GridView1.Columns("kode_hargajual2").Visible = False
        GridView1.Columns("beban_spg").Visible = False

        FormatColumnNumeric(GridView1.Columns("harga"))
        FormatColumnNumeric(GridView1.Columns("total"))
        FormatColumnNumeric(GridView1.Columns("harga2"))

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns("tgl_transaksi").OptionsColumn.AllowEdit = True
        GridView1.Columns("kode_barangjadi").OptionsColumn.AllowEdit = True
        GridView1.Columns("qty").OptionsColumn.AllowEdit = True
        GridView1.Columns("harga").OptionsColumn.AllowEdit = True
        GridView1.Columns("diskon").OptionsColumn.AllowEdit = True
        GridView1.Columns("keterangan").OptionsColumn.AllowEdit = True

        ' Atur warna cell
        GridView1.Columns.Item("harga2").AppearanceCell.BackColor = Color.SeaShell
        GridView1.Columns.Item("diskon2").AppearanceCell.BackColor = Color.SeaShell

        '# Create Band
        Dim BArtikel As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BDijual As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BDitetapkan As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim Bketerangan As New DevExpress.XtraGrid.Views.BandedGrid.GridBand

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


        GridView1.Bands.Clear()
        GridView1.Bands.Add(BArtikel)
        GridView1.Bands.Add(BDijual)
        GridView1.Bands.Add(BDitetapkan)
        GridView1.Bands.Add(Bketerangan)

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
        BArtikel.Columns.Add(GridView1.Columns("stok"))

        BDijual.Columns.Add(GridView1.Columns("qty"))
        BDijual.Columns.Add(GridView1.Columns("harga"))
        BDijual.Columns.Add(GridView1.Columns("diskon"))
        BDijual.Columns.Add(GridView1.Columns("total"))

        BDitetapkan.Columns.Add(GridView1.Columns("harga2"))
        BDitetapkan.Columns.Add(GridView1.Columns("diskon2"))

        Bketerangan.Columns.Add(GridView1.Columns("keterangan"))

    End Sub

    Private Sub frm_konsinyasi_sekunder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_KONSINYASI_SEKUNDER
        frm_transaksi_popup_artkel.kode_customer = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
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
        Dim vkode_customer As String = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
        Dim i As Integer
        Dim Query As String

        '# Cek Grid
        If GridView1.RowCount <= 1 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# START TRANSAKSI
        Connection.TRANS_START()

        For i = 0 To rcd_list.Count - 2
            '# insert to table tbl_konsinyasisekunder
            Db.FlushCache()
            Db.Insert("tbl_konsinyasisekunder")
            Db.SetField("tgl_transaksi", rcd_list.Item(i).tgl_transaksi)
            Db.SetField("kode_customer", vkode_customer)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.SetField("diskon", rcd_list.Item(i).diskon)
            Db.SetField("total", rcd_list.Item(i).total)
            Db.SetField("status", "0")
            Db.SetField("username", Auth.Username)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update stok customer
            Query = ""
            Query &= " UPDATE tbl_persediaan_customer "
            Query &= " SET stok_sekunder = stok_sekunder - " & rcd_list.Item(i).qty
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

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If e.Column.FieldName = "tgl_transaksi" Then
            Dim Row As Integer = e.RowHandle
            Dim tgl As DateTime = e.Value

            '# ambil harga yg ditetapkan
            Db.FlushCache()
            Db.Selects("TOP 1 a.harga, a.diskon")
            Db.From("tbl_histori_hargacustomer a")
            Db.Where("a.kode_barangjadi", rcd_list.Item(row).kode_barangjadi)
            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
            Db.Where("a.tanggal", tgl.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
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

            '# refres data
            'setFocusCell(GridView1, Row, "qty")
            rcd_list.Item(Row).sumary()
            GridView1.RefreshData()

        End If
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
                        Db.Selects("a.kode_barangjadi, b.nama, c.jenis, a.stok_sekunder as stok")
                        Db.From("tbl_persediaan_customer a")
                        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
                        Db.Join("tbl_jenis_hargabarang c", "c.kode_jenis_harga = a.kode_jenis_harga")
                        Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
                        Db.Where(" AND a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")

                        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If dt1.Rows.Count > 0 Then
                            rcd_list.Item(row).kode_barangjadi = dt1.Rows(0).Item("kode_barangjadi").ToString
                            rcd_list.Item(row).nama = dt1.Rows(0).Item("nama").ToString
                            rcd_list.Item(row).stok = dt1.Rows(0).Item("stok").ToString

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

                            '# refres data
                            rcd_list.Add(New rcd_konsinyasi_sekunder)
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
End Class