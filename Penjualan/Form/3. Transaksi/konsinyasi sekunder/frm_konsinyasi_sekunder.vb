Public Class frm_konsinyasi_sekunder 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_konsinyasi_sekunder)

    Sub reIndex()
        Dim i As Integer = 1
        For i = 1 To rcd_list.Count
            rcd_list.Item(i - 1).no = i
        Next

        If rcd_list.Count > 0 Then
            kode_customer.Properties.ReadOnly = True
            tgl_transaksi.Properties.ReadOnly = True
        Else
            kode_customer.Properties.ReadOnly = False
            tgl_transaksi.Properties.ReadOnly = False
        End If

        GridView1.RefreshData()
    End Sub

    Public Sub initComponent()
        Dim i As Integer

        tgl_transaksi.DateTime = Now
        Load_Customer(kode_customer, 1)


        rcd_list = New System.ComponentModel.BindingList(Of rcd_konsinyasi_sekunder)
        GridControl1.DataSource = rcd_list

        Call reIndex()

        '# atur grid
        GridView1.Columns("no").Caption = "No."
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
        Try
            rcd_list.RemoveAt(row)
            Call reIndex()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim vkode_customer As String = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
        Dim i As Integer
        Dim Query As String

        '# Cek Grid
        If GridView1.RowCount = 0 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# START TRANSAKSI
        Connection.TRANS_START()

        For i = 0 To rcd_list.Count - 1
            '# insert to table tbl_konsinyasisekunder
            Db.FlushCache()
            Db.Insert("tbl_konsinyasisekunder")
            Db.SetField("tgl_transaksi", tgl_transaksi.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
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
            Query &= " SET stok = stok - " & rcd_list.Item(i).qty
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

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

    End Sub
End Class