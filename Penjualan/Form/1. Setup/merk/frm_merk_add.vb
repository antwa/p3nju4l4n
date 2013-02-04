Public Class frm_merk_add 

    Private Sub cmd_simpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# validation
        Validation.clearRules()
        Validation.addRules(txt_merk.Text, "Merk", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table tbl_merk
        Db.FlushCache()
        Db.Insert("tbl_merk")
        Db.SetField("merk", txt_merk.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_merk_list.loadData()
            Me.Close()
        End If

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class