Public Class frm_kode_akun_edit

    Public kode_akun As String

    Sub initData()

        '# load 
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_akun")
        Db.Where("kode_akun", kode_akun)

        Dim rcd As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        '# populate record
        With rcd.Rows(0)
            rdg_tipe_akun.EditValue = .Item("tipe").ToString

            lkp_kelompok.EditValue = CInt(.Item("kelompok").ToString)
            lkp_posisi.EditValue = .Item("kode_parent").ToString
            txt_kode_akun2.Text = .Item("kode_akun").ToString.Split("-")(1)
            txt_nama_akun.Text = .Item("nama_akun").ToString
            txt_deskripsi.Text = .Item("deskripsi").ToString

            '# cek
            If .Item("kode_parent").ToString = "0" Then
                rdg_tipe_akun.Enabled = False
                lkp_kelompok.Enabled = False
                lkp_posisi.Enabled = False
                txt_kode_akun2.Properties.ReadOnly = True
            Else
                rdg_tipe_akun.Enabled = False
                lkp_kelompok.Enabled = False
            End If

        End With

    End Sub

    Private Sub frm_kode_akun_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_akun_master(lkp_kelompok)

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

        If kode_akun <> Me.kode_akun Then
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
        Db.Update("tbl_akun")
        Db.SetField("kode_akun", kode_akun)
        Db.SetField("kode_parent", lkp_posisi.Text)
        Db.SetField("kelompok", txt_kode_akun1.Text)
        Db.SetField("tipe", rdg_tipe_akun.EditValue)
        Db.SetField("nama_akun", txt_nama_akun.Text)
        Db.SetField("deskripsi", txt_deskripsi.Text)

        Db.Where("kode_akun", Me.kode_akun)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            frm_kode_akun_list.LoadData()
            Me.Close()
        Else
            MsgBox("Data gagal disimpan", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_kode_akun_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.initData()
    End Sub

End Class