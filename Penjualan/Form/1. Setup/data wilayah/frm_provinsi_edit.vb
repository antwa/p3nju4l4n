Public Class frm_provinsi_edit 

    Public kode_provinsi As String

    Public Sub PopulateField()
        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_provinsi")
        Db.Where("kode_provinsi", Me.kode_provinsi)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode.Text = .Item("kode_provinsi").ToString
                txt_provinsi.Text = .Item("provinsi").ToString

            End With
        End If

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# validation
        Validation.clearRules()
        Validation.addRules(txt_provinsi.Text, "Provinsi", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_provinsi
        Db.FlushCache()
        Db.Update("tbl_provinsi")
        'Db.SetField("kode_provinsi", txt_kode.Text)
        Db.SetField("provinsi", txt_provinsi.Text)
        Db.Where("kode_provinsi", txt_kode.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Provinsi()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_provinsi_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.PopulateField()
    End Sub
End Class