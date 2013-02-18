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
        Db.From("tbl_customer")
        Db.Where("kode_customer", txt_kode_customer.Text)

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
        Validation.addRules(txt_telp1.Text, "Telepon", "required|numeric|length[10-12]")
        Validation.addRules(txt_email.Text, "Email", "required|email")
        Validation.addRules(txt_margin.Text, "Margin Toko", "required|numeric")
        Validation.addRules(txt_dis_konsumen.Text, "Dis Konsumen", "required|numeric")
        Validation.addRules(txt_plafon.Text, "Plafon", "required")
        Validation.addRules(txt_jatuh_tempo.Text, "Jatuh Tempo", "required|numeric")
        Validation.addRules(lkp_harga.EditValue, "Harga Jual", "required")

        If Validation.isValid Then

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then

                '# insert to table tbl_customer
                Db.FlushCache()
                Db.Insert("tbl_customer")
                Db.SetField("kode_customer", txt_kode_customer.Text)
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

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    ' Inser Code Here
                    frm_customer_list.initGrid()
                    Me.Close()

                End If

            End If

        Else
            Validation.showMessage()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub
End Class