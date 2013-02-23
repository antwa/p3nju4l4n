Imports DevExpress.XtraEditors.Controls


Public Class frm_customer_edit

    Public kode As String

    Public Sub initControl()
        Load_Kota(lkp_kota)
        Load_Zona(lkp_zona)
        Load_TemplateHarga(lkp_harga)
        Load_Grup(lkp_grup)

        rdg_sistem_jual.Properties.Items.Add(New RadioGroupItem("1", "Konsinyasi"))
        rdg_sistem_jual.Properties.Items.Add(New RadioGroupItem("2", "Putus"))
        rdg_sistem_jual.SelectedIndex = 0

    End Sub

    Public Sub initData()

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_customer")
        'Db.Join("PRO_AKSESORIS_DETAIL", "PRO_AKSESORIS.AKS_KODE = PRO_AKSESORIS_DETAIL.AKS_KODE")
        Db.Where("kode_customer", Me.kode)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                .Read()
                txt_kode_customer.Text = kode
                txt_nama.Text = .Item("nama").ToString
                txt_mall.Text = .Item("mall").ToString
                txt_alamat.EditValue = .Item("alamat").ToString
                lkp_kota.EditValue = .Item("kode_kota").ToString
                lkp_zona.EditValue = .Item("kode_zona").ToString
                txt_telp1.Text = .Item("telp1").ToString
                txt_telp2.Text = .Item("telp2").ToString
                txt_email.Text = .Item("email").ToString
                txt_fax.Text = .Item("fax").ToString
                lkp_grup.EditValue = .Item("kode_grup").ToString
                rdg_sistem_jual.EditValue = .Item("sistem_jual").ToString
                lkp_harga.EditValue = .Item("kode_template_harga").ToString
                txt_margin.Text = .Item("margin_toko").ToString
                txt_dis_konsumen.Text = .Item("dis_konsumen").ToString
                txt_plafon.Text = .Item("plafon_kredit").ToString
                dte_tgl_masuk.EditValue = .Item("tgl_masuk").ToString
                dte_tgl_buka.EditValue = .Item("tgl_buka").ToString
                txt_prioritas.Text = .Item("prioritas").ToString
                txt_jatuh_tempo.Text = .Item("jatuh_tempobayar").ToString

            End With
        End If

    End Sub
    Private Sub frm_customer_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# validatoin
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_customer")
        Db.Where("kode_customer", txt_kode_customer.Text)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

      

        '# Update table tbl_customer
        Db.FlushCache()
        Db.Update("tbl_customer")
        Db.SetField("kode_customer", txt_kode_customer.Text)
        Db.SetField("nama", txt_nama.Text)
        Db.SetField("alamat", txt_alamat.Text)
        Db.SetField("mall", txt_mall.Text)
        Db.SetField("kode_kota", lkp_kota.EditValue)
        Db.SetField("kode_zona", lkp_zona.EditValue)
        Db.SetField("telp1", txt_telp1.Text)
        Db.SetField("telp2", txt_telp2.Text)
        Db.SetField("fax", txt_fax.Text)
        Db.SetField("email", txt_email.Text)
        Db.SetField("kode_grup", lkp_grup.EditValue)
        Db.SetField("sistem_jual", rdg_sistem_jual.EditValue)
        Db.SetField("kode_template_harga", lkp_harga.EditValue)
        Db.SetField("margin_toko", txt_margin.Text)
        Db.SetField("dis_konsumen", txt_dis_konsumen.Text)
        Db.SetField("plafon_kredit", txt_plafon.Text)
        Db.SetField("tgl_masuk", dte_tgl_masuk.EditValue)
        Db.SetField("tgl_buka", dte_tgl_buka.EditValue)
        Db.SetField("prioritas", txt_prioritas.Text)
        Db.SetField("jatuh_tempobayar", txt_jatuh_tempo.Text)
        'Db.SetField("hidden", )
        Db.Where("kode_customer", txt_kode_customer.Text)


        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            MsgBox("Data berhasil diperbaharui.", MsgBoxStyle.Information)
            frm_customer_list.initGrid()
            Me.Close()
        Else
            MsgBox("Data gagal disimpan!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_customer_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call initControl()
        Call initData()
    End Sub
End Class