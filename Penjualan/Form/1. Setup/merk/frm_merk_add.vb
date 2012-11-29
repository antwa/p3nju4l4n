Public Class frm_merk_add 

    

    Private Sub cmd_simpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode kategori di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_merk")
        Db.Where("merk", txt_kode_merk.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat merk pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_merk
        Db.FlushCache()
        Db.Insert("tbl_merk")
        'Db.SetField("kode_merk", txt_kode_merk.Text)
        Db.SetField("merk", txt_merk.Text)


        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_merk_list.InitGrid()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class