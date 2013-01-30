Public Class frm_zona_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_zona")
        Db.Where("kode_zona", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_zona.Text = .Item("kode_zona").ToString
                txt_zona.Text = .Item("zona").ToString

            End With
        End If

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_zona
        Db.FlushCache()
        Db.Update("tbl_zona")
        Db.SetField("zona", txt_zona.Text)
        Db.Where("kode_zona", txt_kode_zona.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid2()

            Me.Close()
        End If
    End Sub
End Class