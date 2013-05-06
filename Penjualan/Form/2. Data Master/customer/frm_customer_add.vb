Imports DevExpress.XtraEditors.Controls

Public Class frm_customer_add

    Sub InitData()

        Load_Kota(lkp_kota)
        Load_Zona(lkp_zona)
        Load_TemplateHarga(lkp_harga)
        Load_Grup(lkp_grup)

        rdg_sistem_jual.Properties.Items.Add(New RadioGroupItem("1", "Konsinyasi"))
        rdg_sistem_jual.Properties.Items.Add(New RadioGroupItem("2", "Putus"))
        rdg_sistem_jual.SelectedIndex = 0

        dte_tgl_buka.DateTime = Now
        dte_tgl_masuk.DateTime = Now

    End Sub

    Private Sub frm_customer_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# cek kode pegawai
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_customer_parent")
        Db.Where("kode_customer_parent", txt_kode_customer.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat Customer!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        'Validation
        Validation.clearRules()
        Validation.addRules(txt_kode_customer.Text, "Kode", "required|length[1-6]")
        Validation.addRules(txt_nama.Text, "Nama", "required")
        Validation.addRules(txt_alamat.Text, "Alamat", "required")
        Validation.addRules(txt_mall.Text, "Mall", "required")
        Validation.addRules(txt_telp1.Text, "Telepon", "required|numeric|length[6-12]")
        'Validation.addRules(txt_email.Text, "Email", "required|email")
        Validation.addRules(txt_margin.Text, "Margin Toko", "required|numeric")
        Validation.addRules(txt_dis_konsumen.Text, "Dis Konsumen", "required|numeric")
        Validation.addRules(txt_plafon.Text, "Plafon", "required")
        Validation.addRules(txt_jatuh_tempo.Text, "Jatuh Tempo", "required|numeric")
        Validation.addRules(getValueFromLookup(lkp_harga), "Harga Jual", "required")
        Validation.addRules(getValueFromLookup(lkp_kota), "Kota", "[!=]-1")
        Validation.addRules(getValueFromLookup(lkp_grup), "Group", "[!=]-1")

        If Validation.isValid Then

            Connection.TRANS_START()

            '# insert to table tbl_customer
            Db.FlushCache()
            Db.Insert("tbl_customer_parent")
            Db.SetField("kode_customer_parent", txt_kode_customer.Text)
            Db.SetField("nama", txt_nama.Text)
            Db.SetField("alamat", txt_alamat.Text)
            Db.SetField("mall", txt_mall.Text)
            Db.SetField("kode_kota", getValueFromLookup(lkp_kota))
            Db.SetField("kode_zona", getValueFromLookup(lkp_zona))
            Db.SetField("telp1", txt_telp1.Text)
            Db.SetField("telp2", txt_telp2.Text)
            Db.SetField("fax", txt_fax.Text)
            Db.SetField("email", txt_email.Text)
            Db.SetField("kode_grup", getValueFromLookup(lkp_grup))
            Db.SetField("sistem_jual", rdg_sistem_jual.EditValue)
            Db.SetField("kode_template_harga", getValueFromLookup(lkp_harga))
            Db.SetField("margin_toko", txt_margin.Text)
            Db.SetField("dis_konsumen", txt_dis_konsumen.Text)
            Db.SetField("plafon_kredit", txt_plafon.Text)
            Db.SetField("tgl_masuk", dte_tgl_masuk.DateTime)
            Db.SetField("tgl_buka", dte_tgl_buka.DateTime)
            Db.SetField("prioritas", txt_prioritas.Text)
            Db.SetField("jatuh_tempobayar", txt_jatuh_tempo.Text)
            Db.SetField("hidden", "0")

            Connection.TRANS_ADD(Db.GetQueryString)

            If rdg_sistem_jual.EditValue = "1" Then
                '# insert to table tbl_customer_child
                Db.FlushCache()
                Db.Insert("tbl_customer_child")
                Db.SetField("kode_customer_child", txt_kode_customer.Text & ".1")
                Db.SetField("kode_customer_parent", txt_kode_customer.Text)
                Db.SetField("kelompok", "1")
                Db.SetField("deskripsi", "Normal")
                Connection.TRANS_ADD(Db.GetQueryString)

                Db.FlushCache()
                Db.Insert("tbl_customer_child")
                Db.SetField("kode_customer_child", txt_kode_customer.Text & ".2")
                Db.SetField("kode_customer_parent", txt_kode_customer.Text)
                Db.SetField("kelompok", "2")
                Db.SetField("deskripsi", "Obral")
                Connection.TRANS_ADD(Db.GetQueryString)

                Db.FlushCache()
                Db.Insert("tbl_customer_child")
                Db.SetField("kode_customer_child", txt_kode_customer.Text & ".3")
                Db.SetField("kode_customer_parent", txt_kode_customer.Text)
                Db.SetField("kelompok", "3")
                Db.SetField("deskripsi", "Spesial Price")
                Connection.TRANS_ADD(Db.GetQueryString)

            Else
                Db.FlushCache()
                Db.Insert("tbl_customer_child")
                Db.SetField("kode_customer_child", txt_kode_customer.Text & ".4")
                Db.SetField("kode_customer_parent", txt_kode_customer.Text)
                Db.SetField("kelompok", "4")
                Db.SetField("deskripsi", "Jual Putus")
                Connection.TRANS_ADD(Db.GetQueryString)
            End If


            If Connection.TRANS_SUCCESS Then
                frm_customer_list.loadData()
                Me.Close()
            Else
                MsgBox(Connection.TRANS_MESSAGE)
            End If

        Else
            Validation.showMessage()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

End Class