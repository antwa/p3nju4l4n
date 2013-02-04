Public Class frm_kategoribarang_edit 

    Public kode_kategori As String

    Public Sub populateField()

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kategori_barang")
        Db.Where("kode_kategori", Me.kode_kategori)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_kategori.Text = .Item("kode_kategori").ToString
                txt_kategori.Text = .Item("kategori").ToString

            End With
        End If

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '#validation
        Validation.clearRules()
        Validation.addRules(txt_kategori.Text, "Kategori", "required|length[1-50]")
        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_kategori_barang
        Db.FlushCache()
        Db.Update("tbl_kategori_barang")
        Db.SetField("kategori", txt_kategori.Text)
        Db.Where("kode_kategori", txt_kode_kategori.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_kategoribarang_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.populateField()
    End Sub
End Class