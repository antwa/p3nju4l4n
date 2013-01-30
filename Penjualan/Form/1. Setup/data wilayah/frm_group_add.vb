Public Class frm_group_add 

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode group di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_grup")
        Db.Where("grup", txt_group.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat group tersebut pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_group
        Db.FlushCache()
        Db.Insert("tbl_grup")
        Db.SetField("grup", txt_group.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid3()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class