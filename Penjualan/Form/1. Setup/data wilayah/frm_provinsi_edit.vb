Public Class frm_provinsi_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_provinsi")
        Db.Where("kode_provinsi", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode.Text = .Item("kode_provinsi").ToString
                txt_provinsi.Text = .Item("provinsi").ToString

            End With
        End If

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_provinsi
        Db.FlushCache()
        Db.Update("tbl_provinsi")
        Db.SetField("kode_provinsi", txt_kode.Text)
        Db.SetField("kategori", txt_provinsi.Text)
        Db.Where("kode_kategori", txt_kode.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid4()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class