Public Class frm_jabatan_edit 

    Dim kode_jabatan As Integer

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_jabatan")
        Db.Where("kode_jabatan", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()
                kode_jabatan = kode
                nama_jabatan.Text = .Item("nama_jabatan").ToString
            End With
        End If
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '#validation
        Validation.clearRules()
        Validation.addRules(nama_jabatan.Text, "Nama Jabatan", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_merk
        Db.FlushCache()
        Db.Update("tbl_jabatan")
        Db.SetField("nama_jabatan", nama_jabatan.Text)
        Db.Where("kode_jabatan", kode_jabatan)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_jabatan_list.loadData()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

End Class