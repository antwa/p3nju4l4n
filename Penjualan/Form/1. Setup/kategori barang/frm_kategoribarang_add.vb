Public Class frm_kategoribarang_add 

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '#validation
        Validation.clearRules()
        Validation.addRules(txt_kategori.Text, "Kategori", "required|length[1-50]")
        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table tbl_kategori_barang
        Db.FlushCache()
        Db.Insert("tbl_kategori_barang")
        Db.SetField("kategori", txt_kategori.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.loadData()
            Me.Close()
        End If
    End Sub

End Class