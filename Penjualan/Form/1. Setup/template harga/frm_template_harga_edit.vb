Public Class frm_template_harga_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_template_hargajual")
        Db.Where("kode_template_harga", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()
                kode_template_harga.Text = .Item("kode_template_harga").ToString
                nama_harga.Text = .Item("nama_harga").ToString
            End With
        End If
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '#validation
        Validation.clearRules()
        Validation.addRules(nama_harga.Text, "Nama Harga Jual", "required")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_merk
        Db.FlushCache()
        Db.Update("tbl_template_hargajual")
        'Db.SetField("kode_merk", txt_kode_merk.Text)
        Db.SetField("nama_harga", nama_harga.Text)
        Db.Where("kode_template_harga", kode_template_harga.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_template_harga_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

End Class