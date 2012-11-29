Public Class frm_kategoribarang_add 

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode kategori di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kategori_barang")
        Db.Where("kategori", txt_kategori.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat kategori tersebut pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_kategori_barang
        Db.FlushCache()
        Db.Insert("tbl_kategori_barang")
        'Db.SetField("kode_kategori", txt_kode_kategori.Text)
        Db.SetField("kategori", txt_kategori.Text)

        MsgBox(Db.GetQueryString)
        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.InitGrid()

            Me.Close()
        End If
    End Sub
End Class