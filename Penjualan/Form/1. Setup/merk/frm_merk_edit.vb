Public Class frm_merk_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_merk")
        Db.Where("kode_merk", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_merk.Text = .Item("kode_merk").ToString
                txt_merk.Text = .Item("merk").ToString

            End With
        End If
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_merk
        Db.FlushCache()
        Db.Update("tbl_merk")
        'Db.SetField("kode_merk", txt_kode_merk.Text)
        Db.SetField("merk", txt_merk.Text)
        Db.Where("kode_merk", txt_kode_merk.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_merk_list.InitGrid()

            Me.Close()
        End If
    End Sub
End Class