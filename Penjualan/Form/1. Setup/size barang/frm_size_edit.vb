Public Class frm_size_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_size")
        Db.Where("kode_size", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_size.Text = .Item("kode_size").ToString
                txt_size.Text = .Item("size").ToString

            End With
        End If
    End Sub


    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_size
        Db.FlushCache()
        Db.Update("tbl_size")
        ' Db.SetField("kode_size", txt_kode_size.Text)
        Db.SetField("size", txt_size.Text)
        Db.Where("kode_size", txt_kode_size.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.InitGrid()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class