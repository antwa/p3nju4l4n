﻿Imports DevExpress.XtraEditors.Controls

Public Class frm_pegawai_edit

    Public kode As String

    Sub initControl()
        Load_CustomerParent(lkp_kode_costumer_parent, 1)
        Load_Jabatan(lkp_jabatan)

        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("1", "SPG"))
        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("2", "Pegawai"))

        rdg_statusKaryawan.Properties.Items.Add(New RadioGroupItem("1", "Karyawan Tetap"))
        rdg_statusKaryawan.Properties.Items.Add(New RadioGroupItem("2", "Karyawan Percobaan"))
        rdg_statusKaryawan.SelectedIndex = 0


        rdg_jk.Properties.Items.Add(New RadioGroupItem("L", "Laki - Laki"))
        rdg_jk.Properties.Items.Add(New RadioGroupItem("P", "Perempuan"))
    End Sub

    Public Sub initData()

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_pegawai")
        'Db.Join("PRO_AKSESORIS_DETAIL", "PRO_AKSESORIS.AKS_KODE = PRO_AKSESORIS_DETAIL.AKS_KODE")
        Db.Where("nik", kode)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                .Read()
                txt_nik.Text = kode
                txt_noktp.Text = .Item("no_ktp").ToString
                txt_nama_pegawai.Text = .Item("nama").ToString
                txt_alamat.EditValue = .Item("alamat").ToString
                txt_kota.Text = .Item("kota").ToString
                rdg_group_pegawai.EditValue = .Item("group").ToString
                lkp_kode_costumer_parent.EditValue = .Item("kode_customer_parent").ToString

                rdg_jk.EditValue = .Item("jk").ToString
                dte_tgl_masuk.EditValue = .Item("tgl_masuk").ToString
                txt_telp.Text = .Item("telepon").ToString
                txt_email.Text = .Item("email").ToString
                txt_bank.Text = .Item("nama_bank").ToString
                txt_no_rekening.Text = .Item("no_rekening").ToString
                txt_atas_nama.Text = .Item("atas_nama").ToString
                rdg_statusKaryawan.EditValue = .Item("status").ToString
                txt_gaji_pokok.Text = .Item("gaji_pokok").ToString
                txt_premi_harian.Text = .Item("premi_harian").ToString
                txt_lembur_jam.Text = .Item("lembur_jam").ToString
                txt_tunjangan.Text = .Item("tunjangan").ToString
                txt_hari_besar.Text = .Item("lembur_haribesar").ToString

            End With
        End If

    End Sub
    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_pegawai
        Db.FlushCache()
        Db.Update("tbl_pegawai")
        Db.SetField("nik", txt_nik.Text)
        Db.SetField("no_ktp", txt_noktp.Text)
        Db.SetField("nama", txt_nama_pegawai.Text)
        Db.SetField("alamat", txt_alamat.Text)
        Db.SetField("kota", txt_kota.Text)
        Db.SetField("[group]", rdg_group_pegawai.EditValue)
        Db.SetField("kode_customer_parent", getValueFromLookup(lkp_kode_costumer_parent))
        Db.SetField("jk", rdg_jk.EditValue)
        Db.SetField("tgl_masuk", dte_tgl_masuk.DateTime)
        Db.SetField("telepon", txt_telp.Text)
        Db.SetField("email", txt_email.Text)
        Db.SetField("no_rekening", txt_no_rekening.Text)
        Db.SetField("atas_nama", txt_atas_nama.Text)
        Db.SetField("status", rdg_statusKaryawan.EditValue)
        Db.SetField("gaji_pokok", txt_gaji_pokok.Text)
        Db.SetField("premi_harian", txt_premi_harian.Text)
        Db.SetField("lembur_jam", txt_lembur_jam.Text)
        Db.SetField("tunjangan", txt_tunjangan.Text)
        Db.SetField("lembur_haribesar", txt_hari_besar.Text)
        Db.Where("nik", txt_nik.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            MsgBox("Data berhasil diperbaharui.", MsgBoxStyle.Information)
            frm_pegawai_list.initGrid()
            Me.Close()
        Else
            MsgBox("Data gagal disimpan!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub frm_pegawai_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initControl()
    End Sub

    Private Sub lkp_jabatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkp_jabatan.EditValueChanged

    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub frm_pegawai_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.initData()
    End Sub
End Class