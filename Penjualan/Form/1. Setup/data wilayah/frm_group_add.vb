Public Class frm_group_add 

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_group.Text, "Group", "required|length[1-20]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table tbl_group
        Db.FlushCache()
        Db.Insert("tbl_grup")
        Db.SetField("grup", txt_group.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Group()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

End Class