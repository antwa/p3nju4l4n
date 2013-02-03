Public Class frm_jabatan_add 

    

    Private Sub cmd_simpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        
        '# validation
        Validation.clearRules()
        Validation.addRules(nama_jabatan.Text, "Nama Jabatan", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table 
        Db.FlushCache()
        Db.Insert("tbl_jabatan")
        Db.SetField("nama_jabatan", nama_jabatan.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_jabatan_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_jabatan_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class