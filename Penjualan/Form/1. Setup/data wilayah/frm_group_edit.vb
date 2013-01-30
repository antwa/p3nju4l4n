Public Class frm_group_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_grup")
        Db.Where("kode_grup", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_group.Text = .Item("kode_grup").ToString
                txt_group.Text = .Item("[grup").ToString

            End With
        End If

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_group
        Db.FlushCache()
        Db.Update("tbl_grup")
        Db.SetField("grup", txt_group.Text)
        Db.Where("kode_grup", txt_kode_group.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid3()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class