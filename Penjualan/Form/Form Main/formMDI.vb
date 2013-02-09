Public Class formMDI

    Private Sub HakAkses()

        ' User
        'CPengguna_ListPengguna.Enabled = Auth.canAccess(frm_user_list.Name)


    End Sub

    Public Sub LoadFormToTab(ByVal MForm As DevExpress.XtraEditors.XtraForm)
        MForm.MdiParent = Me
        MForm.Show()
        MForm.Focus()

        Call HakAkses()
    End Sub

    Private Sub formMDI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub formMDI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = "Aplikasi Penjualan Version : " & APP.Version
        sts_status.Caption = "Login Sebagai : " & Auth.NamaAkses
        sts_tanggal.Caption = FormatDateTime(Now, DateFormat.LongDate)
        sts_waktu.Caption = FormatDateTime(Now, DateFormat.LongTime)

        Call HakAkses()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            sts_tanggal.Caption = FormatDateTime(Now, DateFormat.LongDate)
            sts_waktu.Caption = FormatDateTime(Now, DateFormat.LongTime)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CPengguna_ListPengguna_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CPengguna_ListPengguna.ItemClick
        LoadFormToTab(frm_user_list)
    End Sub

    Private Sub CPengguna_KataSandiku_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CPengguna_KataSandiku.ItemClick
        frm_my_password.ShowDialog(Me)
    End Sub

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick

    End Sub

    Private Sub BarButtonItem48_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_merk.ItemClick
        LoadFormToTab(frm_merk_list)
    End Sub

    Private Sub cTransaksi_penerimaanbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_penerimaanbarang.ItemClick
        LoadFormToTab(frm_penerimaanbarang)
    End Sub

    Private Sub cTransaksi_returbelibarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_returbelibarang.ItemClick
        LoadFormToTab(frm_retur_penerimaanbarang)
    End Sub

    Private Sub cTransaksi_so_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_so.ItemClick
        LoadFormToTab(frm_sales_order)
    End Sub

    Private Sub cTransaksi_do_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_do.ItemClick
        LoadFormToTab(frm_delivery_order)
    End Sub

    Private Sub cTransaksi_suratjalan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_suratjalan.ItemClick
        LoadFormToTab(frm_surat_jalan)
    End Sub

    Private Sub cTransaksi_konsinyasi_sekunder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_konsinyasi_sekunder.ItemClick
        LoadFormToTab(frm_konsinyasi_sekunder)
    End Sub

    Private Sub cTransaksi_konsinyasi_primer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_konsinyasi_primer.ItemClick
        LoadFormToTab(frm_konsinyasi_primer)
    End Sub

    Private Sub cTransaksi_faktur_konsinyasi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_faktur_konsinyasi.ItemClick
        LoadFormToTab(frm_faktur_konsinyasi)
    End Sub

    Private Sub cMaster_barangjadi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cMaster_barangjadi.ItemClick
        LoadFormToTab(frm_barangjadi_list)
    End Sub

    Private Sub cTransaksi_retur_jualputus_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_retur_jualputus.ItemClick
        LoadFormToTab(frm_retur_jual_putus)
    End Sub

    Private Sub cTransaksi_retur_jualkonsinyasi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_retur_jualkonsinyasi.ItemClick
        LoadFormToTab(frm_retur_jual_konsinyasi)
    End Sub

    Private Sub cPersediaan_lap_kartustok_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cPersediaan_lap_kartustok.ItemClick
        LoadFormToTab(frm_kartu_stok_gudang)
    End Sub

    Private Sub cSetup_kategori_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_kategori.ItemClick
        LoadFormToTab(frm_kategoribarang_list)
    End Sub

    Private Sub cSetup_size_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_size.ItemClick
        LoadFormToTab(frm_size_list)
    End Sub

    Private Sub cPersediaan_harga_customer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cPersediaan_harga_customer.ItemClick
        LoadFormToTab(frm_histori_harga)
    End Sub

    Private Sub cPersediaan_stok_customer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cPersediaan_stok_customer.ItemClick
        LoadFormToTab(frm_stok_customer)
    End Sub

    Private Sub cTransaksi_rencanadistribusi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_rencanadistribusi.ItemClick
        LoadFormToTab(frm_rencana_distribusi)
    End Sub

    Private Sub cPersediaan_gudang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cPersediaan_gudang.ItemClick
        LoadFormToTab(frm_stok_gudang)
    End Sub

    Private Sub cMaster_pegawai_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cMaster_pegawai.ItemClick
        LoadFormToTab(frm_pegawai_list)
    End Sub

    Private Sub cLaporan_penerimaanbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cLaporan_penerimaanbarang.ItemClick
        LoadFormToTab(frm_lap_penerimaan_barang)
    End Sub

    Private Sub cTransaksi_memo_pengeluaran_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_memo_pengeluaran.ItemClick
        LoadFormToTab(frm_memo_pengeluaran)
    End Sub

    Private Sub cTransaksi_pengeluaran_barangjadi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_pengeluaran_barangjadi.ItemClick
        LoadFormToTab(frm_keluar_barang)
    End Sub

    Private Sub cPenggajian_input_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cPenggajian_input.ItemClick
        LoadFormToTab(frm_input_gaji_spg)
    End Sub

    Private Sub cPenggajian_rekap_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cPenggajian_rekap.ItemClick
        LoadFormToTab(frm_rekap_gaji_spg)
    End Sub

    Private Sub cSetup_datawilayah_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_datawilayah.ItemClick
        LoadFormToTab(frm_wilayah_list)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_template_harga.ItemClick
        LoadFormToTab(frm_template_harga_list)
    End Sub

    Private Sub cMaster_supplierbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cMaster_supplierbarang.ItemClick
        LoadFormToTab(frm_supplier_barang_list)
    End Sub

    Private Sub cMaster_customerbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cMaster_customerbarang.ItemClick
        LoadFormToTab(frm_customer_list)
    End Sub

    Private Sub cSetup_jabatan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_jabatan.ItemClick
        LoadFormToTab(frm_jabatan_list)
    End Sub

    Private Sub cSetup_kodeakun_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cSetup_kodeakun.ItemClick
        LoadFormToTab(frm_kode_akun_list)
    End Sub

    Private Sub cKasBank_Penerimaan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cKasBank_Penerimaan.ItemClick
        LoadFormToTab(frm_penerimaan_kas)
    End Sub

    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        LoadFormToTab(frm_pengeluaran_kas_list)
    End Sub

    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        LoadFormToTab(frm_mutasi_kas)
    End Sub

    Private Sub cTransaksi_faktur_global_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_faktur_global.ItemClick
        LoadFormToTab(frm_fakturglobal)
    End Sub

    Private Sub cTransaksi_targetpenjualan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cTransaksi_targetpenjualan.ItemClick
        LoadFormToTab(frm_targetpenjualan)
    End Sub
End Class