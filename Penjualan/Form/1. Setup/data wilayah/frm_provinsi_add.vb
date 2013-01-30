Public Class frm_provinsi_add 

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# cek kode provinsi di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_provinsi")
        Db.Where("kode_provinsi", txt_kode.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat kode tersebut pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# insert to table tbl_provinsi
        Db.FlushCache()
        Db.Insert("tbl_provinsi")
        Db.SetField("kode_provinsi", txt_kode.Text)
        Db.SetField("provinsi", txt_provinsi.Text)


        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid4()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class