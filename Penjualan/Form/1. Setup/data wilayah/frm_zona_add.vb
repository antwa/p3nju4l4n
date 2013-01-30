Public Class frm_zona_add 

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode zona di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_zona")
        Db.Where("zona", txt_zona.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat zona tersebut pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_zona
        Db.FlushCache()
        Db.Insert("tbl_zona")
        Db.SetField("zona", txt_zona.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid2()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class