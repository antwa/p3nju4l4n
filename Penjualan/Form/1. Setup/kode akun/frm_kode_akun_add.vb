Public Class frm_kode_akun_add 

    Sub initComponent()

        Load_akun_master(lkp_kelompok)


    End Sub

    Private Sub frm_kode_akun_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub lkp_kelompok_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkp_kelompok.EditValueChanged
        Call Load_akun_header_byKelompok(lkp_posisi, getValueFromLookup(lkp_kelompok))
        txt_kode_akun1.Text = getValueFromLookup(lkp_kelompok)
    End Sub

    Private Sub lkp_posisi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkp_posisi.EditValueChanged
        lbl_nama_posisi_akun.Text = lkp_posisi.GetColumnValue("nama_akun")
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim kode_akun As String = txt_kode_akun1.Text & "-" & txt_kode_akun2.Text

        ' validation
        '# cek kode akun
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_akun")
        Db.Where("kode_akun", kode_akun)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            MsgBox("Maaf kode akun '" & kode_akun & "' sudah terdaftar, gunakan kode yang lain.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Validation.clearRules()
        Validation.addRules(txt_kode_akun2.Text, "Kode Akun", "required|numeric|length[4-4]")
        Validation.addRules(txt_nama_akun.Text, "Nama Akun", "required")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '@ end validation

        '# insert to table tbl_akun
        Db.FlushCache()
        Db.Insert("tbl_akun")
        Db.SetField("kode_akun", kode_akun)
        Db.SetField("kode_parent", getValueFromLookup(lkp_posisi))
        Db.SetField("kelompok", txt_kode_akun1.Text)
        Db.SetField("tipe", rdg_tipe_akun.EditValue)
        Db.SetField("nama_akun", txt_nama_akun.Text)
        Db.SetField("deskripsi", txt_deskripsi.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            frm_kode_akun_list.LoadData()
            Me.Close()
        Else
            MsgBox("Data gagal disimpan", MsgBoxStyle.Exclamation)
        End If

    End Sub
End Class