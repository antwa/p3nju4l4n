Public Class frm_jenisharga_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_jenis_hargabarang")
        Db.Where("jenis", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode.Text = .Item("kode_jenis_harga").ToString
                txt_jenis.Text = .Item("jenis").ToString

            End With
        End If
    End Sub


    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_jenis_hargabarang
        Db.FlushCache()
        Db.Update("tbl_jenis_hargabarang")
        Db.SetField("jenis", txt_jenis.Text)
        Db.Where("kode_jenis_harga", txt_kode.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.InitGrid()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class