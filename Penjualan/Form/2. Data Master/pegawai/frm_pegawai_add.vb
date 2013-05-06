Imports DevExpress.XtraEditors.Controls

Public Class frm_pegawai_add

    Sub InitData()

        'Load_Status(lkp_status)
        Load_Jabatan(lkp_jabatan)
        Load_CustomerParent(lkp_kode_costumer_parent, "1")

        rdg_jk.Properties.Items.Add(New RadioGroupItem("L", "Laki - Laki"))
        rdg_jk.Properties.Items.Add(New RadioGroupItem("P", "Perempuan"))
        rdg_jk.SelectedIndex = 0

        rdg_statusKaryawan.Properties.Items.Add(New RadioGroupItem("1", "Karyawan Tetap"))
        rdg_statusKaryawan.Properties.Items.Add(New RadioGroupItem("2", "Karyawan Percobaan"))
        rdg_statusKaryawan.SelectedIndex = 0

        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("1", "SPG"))
        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("2", "Pegawai"))
        rdg_group_pegawai.EditValue = "1"

    End Sub

    Private Sub frm_pegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode pegawai
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
        Validation.addRules(txt_noktp.Text, "No KTP", "required|numeric|length[5-16]")
        Validation.addRules(txt_nama_pegawai.Text, "Nama Pegawai", "required")
        Validation.addRules(txt_alamat.Text, "Alamat", "required")
        'Validation.addRules(lkp_jabatan.Text, "Jabatan", "required")
        If rdg_group_pegawai.EditValue = "1" Then
            Validation.addRules(getValueFromLookup(lkp_kode_costumer_parent), "Customer", "[!=]-1")
        End If
        Validation.addRules(txt_telp.Text, "Telepon", "required|numeric|length[6-12]")
        'Validation.addRules(txt_email.Text, "Email", "required|email")
        Validation.addRules(txt_bank.Text, "Nama Bank", "required")
        Validation.addRules(txt_atas_nama.Text, "Atas Nama", "required")
        Validation.addRules(txt_no_rekening.Text, "No Rekening", "required|numeric")
        Validation.addRules(txt_gaji_pokok.EditValue, "Gaji Pokok", "required|numeric")

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

                Db.SetField("[group]", rdg_group_pegawai.EditValue)
                Db.SetField("kode_customer_parent", getValueFromLookup(lkp_kode_costumer_parent))
                Db.SetField("jabatan", getValueFromLookup(lkp_jabatan))
                Db.SetField("jk", rdg_jk.EditValue)
                Db.SetField("tgl_masuk", dte_tgl_masuk.DateTime)

                'Db.SetField("tanggal", tanggal.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))

                Db.SetField("telepon", txt_telp.Text)
                Db.SetField("email", txt_email.Text)

                Db.SetField("nama_bank", txt_bank.Text)
                Db.SetField("no_rekening", txt_no_rekening.Text)
                Db.SetField("atas_nama", txt_atas_nama.Text)


                Db.SetField("status", rdg_statusKaryawan.EditValue)
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
        lkp_kode_costumer_parent.Enabled = IIf(rdg_group_pegawai.EditValue = "1", True, False)
    End Sub

    Private Sub lkp_kode_costumer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkp_kode_costumer_parent.EditValueChanged

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class