Public Class frm_supplier_barang_add

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        

        '# cek kode supplier
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_supplier_barang")
        Db.Where("kode_supplier_barang", txt_kode.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat kode!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '#validasi
        Validation.clearRules()
        Validation.addRules(txt_kode.Text, "Kode", "required|length[1-6]")
        Validation.addRules(txt_nama.Text, "Nama", "required")
        Validation.addRules(txt_alamat.Text, "Alamat", "required")
        Validation.addRules(txt_telp1.Text, "Telepon", "required|numeric|length[1-12]")
        Validation.addRules(txt_jatuh_tempobayar.EditValue, "Jatuh Tempo Bayar", "required")
        Validation.addRules(txt_plafon_debet.EditValue, "Plafon Debet", "required")

        If Validation.isValid Then
            If Connection.ExecuteNonQuery(Db.GetQueryString) Then

                '# insert to table tbl_supplier_barang
                Db.FlushCache()
                Db.Insert("tbl_supplier_barang")
                Db.SetField("kode_supplier_barang", txt_kode.Text)
                Db.SetField("nama", txt_nama.Text)
                Db.SetField("alamat", txt_alamat.Text)
                Db.SetField("kota", txt_kota.Text)
                Db.SetField("telp1", txt_telp1.Text)
                Db.SetField("telp2", txt_telp2.Text)
                Db.SetField("fax", txt_fax.Text)
                Db.SetField("jatuh_tempobayar", txt_jatuh_tempobayar.Text)
                Db.SetField("plafon_debet", txt_plafon_debet.Text)
                'Db.SetField ("hidden",)
                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    ' Inser Code Here
                    frm_supplier_barang_list.initGrid()
                    Me.Close()

                End If
            End If
        Else
            Validation.showMessage()
        End If
    End Sub

    Private Sub frm_supplier_barang_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class