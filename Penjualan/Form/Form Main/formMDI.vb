﻿Public Class formMDI

    Private Sub HakAkses()

        ' User
        'CPengguna_ListPengguna.Enabled = Auth.canAccess(frm_user_list.Name)


    End Sub

    Sub LoadFormToTab(ByVal MForm As DevExpress.XtraEditors.XtraForm)
        MForm.MdiParent = Me
        MForm.Show()
        MForm.Focus()

        Call HakAkses()
    End Sub

    Private Sub formMDI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub formMDI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
End Class