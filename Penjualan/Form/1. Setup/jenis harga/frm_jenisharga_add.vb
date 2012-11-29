Public Class frm_jenisharga_add 

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek jenis harga barang di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_jenis_hargabarang")
        Db.Where("jenis", txt_jenis.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat jenis pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_jenis_hargabarang
        Db.FlushCache()
        Db.Insert("tbl_jenis_hargabarang")
        'Db.SetField("kode_size", txt_kode_size.Text)
        Db.SetField("jenis", txt_jenis.Text)


        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_jenisharga_list.InitGrid()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class