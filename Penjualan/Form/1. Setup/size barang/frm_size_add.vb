Public Class frm_size_add 

    
    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode size di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_size")
        Db.Where("size", txt_kode_size.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat size pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_kategori_barang
        Db.FlushCache()
        Db.Insert("tbl_size")
        'Db.SetField("kode_size", txt_kode_size.Text)
        Db.SetField("size", txt_size.Text)


        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_size_list.InitGrid()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class