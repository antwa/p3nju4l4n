Public Class frm_zona_add 

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Validasi
        Validation.clearRules()
        Validation.addRules(txt_zona.Text, "Zona", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table tbl_zona
        Db.FlushCache()
        Db.Insert("tbl_zona")
        Db.SetField("zona", txt_zona.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Zona()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class