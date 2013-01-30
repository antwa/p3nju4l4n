Imports DevExpress.XtraEditors.Controls

Public Class frm_customer_add

    Sub InitData()
        Load_Kota(lkp_kota)
        Load_Zona(lkp_zona)
        Load_Harga(lkp_harga)
        Load_Grup(lkp_grup)

        rdg_sistem_jual.Properties.Items.Add(New RadioGroupItem("1", "Konsinyasi"))
        rdg_sistem_jual.Properties.Items.Add(New RadioGroupItem("2", "Putus"))

    End Sub

    Private Sub frm_customer_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode pegawai
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_customer")
        Db.Where("kode_customer", txt_kode_customer.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat Customer!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then

            '# insert to table tbl_customer
            Db.FlushCache()
            Db.Insert("tbl_customer")
            Db.SetField("kode_customer", txt_kode_customer.Text)
            Db.SetField("nama", txt_nama.Text)
            Db.SetField("alamat", txt_alamat.Text)
            Db.SetField("mall", txt_mall.Text)
            Db.SetField("kode_kota", lkp_kota.Properties.GetKeyValueByDisplayText(lkp_kota.Text))
            Db.SetField("kode_zona", lkp_zona.Properties.GetKeyValueByDisplayText(lkp_zona.Text))
            Db.SetField("telp1", txt_telp1.Text)
            Db.SetField("telp2", txt_telp2.Text)
            Db.SetField("fax", txt_fax.Text)
            Db.SetField("email", txt_email.Text)
            Db.SetField("kode_group", lkp_grup.Properties.GetKeyValueByDisplayText(lkp_grup.Text))
            Db.SetField("sistem_jual", rdg_sistem_jual.EditValue)
            Db.SetField("kode_template_harga", lkp_harga.EditValue)
            Db.SetField("margin_toko", txt_margin.Text)
            Db.SetField("dis_konsumen", txt_dis_konsumen.Text)
            Db.SetField("plafon_kredit", txt_plafon.Text)
            Db.SetField("tgl_masuk", dte_tgl_masuk.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Db.SetField("tgl_buka", dte_tgl_buka.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Db.SetField("prioritas", txt_prioritas.Text)
            Db.SetField("jatuh_tempobayar", txt_jatuh_tempo.Text)
            ' Db.SetField("hidden", )

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                ' Inser Code Here
                frm_customer_list.initGrid()
                Me.Close()

            End If

        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class