Public Class frm_size_edit 

    Public kode_size As String

    Public Sub populateField()

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_size")
        Db.Where("kode_size", Me.kode_size)

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

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_kode_size.Text, "Kode Size", "required|numeric|length[2-2]")
        Validation.addRules(txt_size.Text, "Size", "required|length[1-30]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_size
        Db.FlushCache()
        Db.Update("tbl_size")
        Db.SetField("size", txt_size.Text)
        Db.Where("kode_size", txt_kode_size.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_size_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_size_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.populateField()
    End Sub
End Class