Public Class frm_template_harga_add 

    

    Private Sub cmd_simpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode kategori di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_template_hargajual")
        Db.Where("kode_template_harga", kode_template_harga.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat No pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# validation
        Validation.clearRules()
        Validation.addRules(kode_template_harga.Text, "No", "required|numeric")
        Validation.addRules(nama_harga.Text, "Nama Harga Jual", "required")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table tbl_template_hargajual
        Db.FlushCache()
        Db.Insert("tbl_template_hargajual")
        Db.SetField("kode_template_harga", kode_template_harga.Text)
        Db.SetField("nama_harga", nama_harga.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_template_harga_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class