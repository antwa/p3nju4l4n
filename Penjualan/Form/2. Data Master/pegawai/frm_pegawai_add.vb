﻿Imports DevExpress.XtraEditors.Controls

Public Class frm_pegawai_add
    Sub InitData()
        Load_Jabatan(lkp_jabatan)


        rdg_jk.Properties.Items.Add(New RadioGroupItem("1", "Laki - Laki"))
        rdg_jk.Properties.Items.Add(New RadioGroupItem("2", "Perempuan"))



        Load_Customer(lkp_kode_costumer, "1")

        Load_Jabatan(lkp_jabatan)

        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("1", "SPG"))
        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("2", "Pegawai"))
        rdg_group_pegawai.EditValue = "1"


    End Sub
    Private Sub frm_pegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitData()



    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode supplier
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_pegawai")
        Db.Where("nik", txt_nik.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat NIK!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_nik.Text, "NIK", "required|length[3-5]")
        Validation.addRules(txt_noktp.Text, "No KTP", "required|length[1-50]")
        Validation.addRules(txt_nama_pegawai.Text, "Nama Pegawai", "required")
        Validation.addRules(txt_alamat.Text, "Alamat", "required")
        Validation.addRules(lkp_jabatan.Text, "Jabatan", "required")
        'end Validation

        If Validation.isValid Then

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then

                '# insert to table tbl_pegawai
                Db.FlushCache()
                Db.Insert("tbl_pegawai")
                Db.SetField("nik", txt_nik.Text)
                Db.SetField("no_ktp", txt_noktp.Text)
                Db.SetField("nama", txt_nama_pegawai.Text)
                Db.SetField("alamat", txt_alamat.Text)
                Db.SetField("kota", txt_kota.Text)

                Db.SetField("kode_customer", lkp_kode_costumer.Properties.GetKeyValueByDisplayText(lkp_kode_costumer.Text))
                Db.SetField("jabatan", lkp_jabatan.Properties.GetKeyValueByDisplayText(lkp_jabatan.Text))
                Db.SetField("jk", rdg_jk.Text)
                Db.SetField("tgl_masuk", dte_tgl_masuk.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))

                'Db.SetField("tanggal", tanggal.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))

                Db.SetField("telepon", txt_telp.Text)
                Db.SetField("email", txt_email.Text)

                Db.SetField("no_rekening", txt_no_rekening.Text)
                Db.SetField("atas_nama", txt_atas_nama.Text)


                Db.SetField("status", lkp_status.Properties.GetKeyValueByDisplayText(lkp_status.Text))
                Db.SetField("gaji_pokok", txt_gaji_pokok.EditValue)
                Db.SetField("premi_harian", txt_premi_harian.EditValue)

                Db.SetField("lembur_jam", txt_lembur_jam.EditValue)
                Db.SetField("tunjangan", txt_tunjangan.EditValue)
                Db.SetField("lembur_haribesar", txt_hari_besar.EditValue)

                'MsgBox(Db.GetQueryString)

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    ' Inser Code Here
                    frm_pegawai_list.initGrid()
                    Me.Close()

                End If

            End If

        Else
            Validation.showMessage()
        End If


    End Sub

    Private Sub txt_atasnama_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_atas_nama.EditValueChanged

    End Sub

    Private Sub rdg_group_pegawai_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdg_group_pegawai.SelectedIndexChanged
        lkp_kode_costumer.Enabled = IIf(rdg_group_pegawai.EditValue = "1", True, False)
    End Sub
End Class