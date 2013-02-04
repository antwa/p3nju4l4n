Public Class frm_merk_edit 

    Public kode_merk As String

    Public Sub populateField()

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_merk")
        Db.Where("kode_merk", Me.kode_merk)

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
        '# validation
        Validation.clearRules()
        Validation.addRules(txt_merk.Text, "Merk", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_merk
        Db.FlushCache()
        Db.Update("tbl_merk")
        Db.SetField("merk", txt_merk.Text)
        Db.Where("kode_merk", txt_kode_merk.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_merk_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_merk_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.populateField()
    End Sub

End Class