Public Class formMDI

    Private Sub HakAkses()

        ' User
        CM_frm_barangjadi_list.Enabled = Auth.canAccess(frm_barangjadi_list.Name)
        CM_frm_customer_list.Enabled = Auth.canAccess(frm_customer_list.Name)
        CM_frm_pegawai_list.Enabled = Auth.canAccess(frm_pegawai_list.Name)
        CM_frm_supplier_barang_list.Enabled = Auth.canAccess(frm_supplier_barang_list.Name)
        CM_frm_user_list.Enabled = Auth.canAccess(frm_user_list.Name)
        CM_frm_wilayah_list.Enabled = Auth.canAccess(frm_wilayah_list.Name)
        CM_frm_jabatan_list.Enabled = Auth.canAccess(frm_jabatan_list.Name)
        CM_frm_kategoribarang_list.Enabled = Auth.canAccess(frm_kategoribarang_list.Name)
        CM_frm_kode_akun_list.Enabled = Auth.canAccess(frm_kode_akun_list.Name)
        CM_frm_merk_list.Enabled = Auth.canAccess(frm_merk_list.Name)
        CM_frm_size_list.Enabled = Auth.canAccess(frm_size_list.Name)
        CM_frm_template_harga_list.Enabled = Auth.canAccess(frm_template_harga_list.Name)
        CM_frm_delivery_order.Enabled = Auth.canAccess(frm_delivery_order.Name)
        CM_frm_fakturglobal.Enabled = Auth.canAccess(frm_fakturglobal.Name)
        CM_frm_faktur_konsinyasi.Enabled = Auth.canAccess(frm_faktur_konsinyasi.Name)
        CM_frm_keluar_barang.Enabled = Auth.canAccess(frm_keluar_barang.Name)
        CM_frm_konsinyasi_primer.Enabled = Auth.canAccess(frm_konsinyasi_primer.Name)
        CM_frm_konsinyasi_sekunder.Enabled = Auth.canAccess(frm_konsinyasi_sekunder.Name)
        CM_frm_memo_pengeluaran.Enabled = Auth.canAccess(frm_memo_pengeluaran.Name)
        CM_frm_penerimaanbarang.Enabled = Auth.canAccess(frm_penerimaanbarang.Name)
        CM_frm_rencana_distribusi.Enabled = False 'Auth.canAccess(frm_rencana_distribusi.Name)
        CM_frm_retur_jual_konsinyasi.Enabled = Auth.canAccess(frm_retur_jual_konsinyasi.Name)
        CM_frm_retur_jual_putus.Enabled = Auth.canAccess(frm_retur_jual_putus.Name)
        CM_frm_retur_penerimaanbarang.Enabled = Auth.canAccess(frm_retur_penerimaanbarang.Name)
        CM_frm_sales_order.Enabled = Auth.canAccess(frm_sales_order.Name)
        CM_frm_surat_jalan.Enabled = Auth.canAccess(frm_surat_jalan.Name)
        CM_frm_targetpenjualan.Enabled = Auth.canAccess(frm_targetpenjualan.Name)


    End Sub

    Public Sub LoadFormToTab(ByVal MForm As DevExpress.XtraEditors.XtraForm)
        MForm.MdiParent = Me
        MForm.Show()
        MForm.Focus()
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

    Private Sub CPengguna_ListPengguna_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_user_list.ItemClick
        LoadFormToTab(frm_user_list)
    End Sub

    Private Sub CPengguna_KataSandiku_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CPengguna_KataSandiku.ItemClick
        frm_my_password.ShowDialog(Me)
    End Sub

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick

    End Sub

    Private Sub BarButtonItem48_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_merk_list.ItemClick
        LoadFormToTab(frm_merk_list)
    End Sub

    Private Sub cTransaksi_penerimaanbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_penerimaanbarang.ItemClick
        LoadFormToTab(frm_penerimaanbarang)
    End Sub

    Private Sub cTransaksi_returbelibarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_retur_penerimaanbarang.ItemClick
        LoadFormToTab(frm_retur_penerimaanbarang)
    End Sub

    Private Sub cTransaksi_so_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_sales_order.ItemClick
        LoadFormToTab(frm_sales_order)
    End Sub

    Private Sub cTransaksi_do_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_delivery_order.ItemClick
        LoadFormToTab(frm_delivery_order)
    End Sub

    Private Sub cTransaksi_suratjalan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_surat_jalan.ItemClick
        LoadFormToTab(frm_surat_jalan)
    End Sub

    Private Sub cTransaksi_konsinyasi_sekunder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_konsinyasi_sekunder.ItemClick
        LoadFormToTab(frm_konsinyasi_sekunder)
    End Sub

    Private Sub cTransaksi_konsinyasi_primer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_konsinyasi_primer.ItemClick
        LoadFormToTab(frm_konsinyasi_primer)
    End Sub

    Private Sub cTransaksi_faktur_konsinyasi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_faktur_konsinyasi.ItemClick
        LoadFormToTab(frm_faktur_konsinyasi)
    End Sub

    Private Sub cMaster_barangjadi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_barangjadi_list.ItemClick
        LoadFormToTab(frm_barangjadi_list)
    End Sub

    Private Sub cTransaksi_retur_jualputus_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_retur_jual_putus.ItemClick
        LoadFormToTab(frm_retur_jual_putus)
    End Sub

    Private Sub cTransaksi_retur_jualkonsinyasi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_retur_jual_konsinyasi.ItemClick
        LoadFormToTab(frm_retur_jual_konsinyasi)
    End Sub

    Private Sub cPersediaan_lap_kartustok_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_kartu_stok_gudang.ItemClick
        LoadFormToTab(frm_kartu_stok_gudang)
    End Sub

    Private Sub cSetup_kategori_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_kategoribarang_list.ItemClick
        LoadFormToTab(frm_kategoribarang_list)
    End Sub

    Private Sub cSetup_size_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_size_list.ItemClick
        LoadFormToTab(frm_size_list)
    End Sub

    Private Sub cPersediaan_harga_customer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_histori_harga.ItemClick
        LoadFormToTab(frm_histori_harga)
    End Sub

    Private Sub cPersediaan_stok_customer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_stok_customer.ItemClick
        LoadFormToTab(frm_stok_customer)
    End Sub

    Private Sub cTransaksi_rencanadistribusi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_rencana_distribusi.ItemClick
        LoadFormToTab(frm_rencana_distribusi)
    End Sub

    Private Sub cPersediaan_gudang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_stok_gudang.ItemClick
        LoadFormToTab(frm_stok_gudang)
    End Sub

    Private Sub cMaster_pegawai_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_pegawai_list.ItemClick
        LoadFormToTab(frm_pegawai_list)
    End Sub

    Private Sub cLaporan_penerimaanbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cLaporan_penerimaanbarang.ItemClick
        LoadFormToTab(frm_lap_penerimaan_barang)
    End Sub

    Private Sub cTransaksi_memo_pengeluaran_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_memo_pengeluaran.ItemClick
        LoadFormToTab(frm_memo_pengeluaran)
    End Sub

    Private Sub cTransaksi_pengeluaran_barangjadi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_keluar_barang.ItemClick
        LoadFormToTab(frm_keluar_barang)
    End Sub

    Private Sub cPenggajian_input_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_input_gaji_spg.ItemClick
        LoadFormToTab(frm_input_gaji_spg)
    End Sub

    Private Sub cPenggajian_rekap_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_rekap_gaji_spg.ItemClick
        LoadFormToTab(frm_rekap_gaji_spg)
    End Sub

    Private Sub cSetup_datawilayah_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_wilayah_list.ItemClick
        LoadFormToTab(frm_wilayah_list)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_template_harga_list.ItemClick
        LoadFormToTab(frm_template_harga_list)
    End Sub

    Private Sub cMaster_supplierbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_supplier_barang_list.ItemClick
        LoadFormToTab(frm_supplier_barang_list)
    End Sub

    Private Sub cMaster_customerbarang_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_customer_list.ItemClick
        LoadFormToTab(frm_customer_list)
    End Sub

    Private Sub cSetup_jabatan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_jabatan_list.ItemClick
        LoadFormToTab(frm_jabatan_list)
    End Sub

    Private Sub cSetup_kodeakun_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_kode_akun_list.ItemClick
        LoadFormToTab(frm_kode_akun_list)
    End Sub

    Private Sub cKasBank_Penerimaan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_penerimaan_kas.ItemClick
        LoadFormToTab(frm_penerimaan_kas)
    End Sub

    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cKasBank_pengeluaran.ItemClick
        LoadFormToTab(frm_pengeluaran_kas_list)
    End Sub

    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cKasBank_mutasi_kas.ItemClick
        LoadFormToTab(frm_mutasi_kas)
    End Sub

    Private Sub cTransaksi_faktur_global_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_fakturglobal.ItemClick
        LoadFormToTab(frm_fakturglobal)
    End Sub

    Private Sub cTransaksi_targetpenjualan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_targetpenjualan.ItemClick
        LoadFormToTab(frm_targetpenjualan)
    End Sub

    Private Sub CM_frm_lap_so_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_lap_so.ItemClick
        LoadFormToTab(frm_lap_so)
    End Sub

    Private Sub CM_frm_margin_customer_list_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_margin_customer_list.ItemClick
        LoadFormToTab(frm_margin_customer_list)
    End Sub

    Private Sub CM_frm_retur_formalitas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CM_frm_retur_formalitas.ItemClick
        LoadFormToTab(frm_retur_formalitas)
    End Sub
End Class