Public Class frm_supplier_barang_edit

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# Update table tbl_supplier_barang
        Db.FlushCache()
        Db.Update("tbl_supplier_barang")
        Db.SetField("kode_supplier_barang", txt_kode.Text)
        Db.SetField("nama", txt_nama.Text)
        Db.SetField("alamat", txt_alamat.Text)
        Db.SetField("kota", txt_kota.Text)
        Db.SetField("telp1", txt_telp1.Text)
        Db.SetField("telp2", txt_telp2.Text)
        Db.SetField("fax", txt_fax.Text)
        Db.SetField("jatuh_tempobayar", txt_jatuh_tempobayar.Text)
        Db.SetField("plafon_debet", txt_plafon_debet.Text)
        'Db.SetField("hidden", )
        Db.Where("kode_supplier_barang", txt_kode.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            MsgBox("Data berhasil diperbaharui.", MsgBoxStyle.Information)
            frm_pegawai_list.initGrid()
            Me.Close()
        Else
            MsgBox("Data gagal disimpan!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub initData(ByVal kode As String)

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_supplier_barang")
        Db.Where("kode_supplier_barang", kode)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                .Read()
                txt_kode.Text = kode
                txt_nama.Text = .Item("nama").ToString
                txt_alamat.EditValue = .Item("alamat").ToString
                txt_kota.Text = .Item("kota").ToString
                txt_telp1.Text = .Item("telp1").ToString
                txt_telp2.Text = .Item("telp2").ToString
                txt_fax.Text = .Item("fax").ToString
                txt_jatuh_tempobayar.Text = .Item("jatuh_tempobayar").ToString
                txt_plafon_debet.Text = .Item("plafon_debet").ToString

            End With
        End If

    End Sub

    Private Sub frm_supplier_barang_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class