Public Class frm_kota_edit 

    Public Kode_kota As String

    Public Sub PopulateField()

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kota")
        Db.Where("kode_kota", Me.Kode_kota)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode.Text = .Item("kode_kota").ToString
                txt_kota.Text = .Item("kota").ToString
                lkp_kode_provinsi.EditValue = .Item("kode_provinsi").ToString

            End With
        End If

    End Sub

    Private Sub frm_kota_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Provinsi(lkp_kode_provinsi)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# validation
        Validation.clearRules()
        Validation.addRules(txt_kota.Text, "Kota", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_kota
        Db.FlushCache()
        Db.Update("tbl_kota")
        'Db.SetField("kode_kota", txt_kode.Text)
        Db.SetField("kota", txt_kota.Text)
        Db.SetField("kode_provinsi", getValueFromLookup(lkp_kode_provinsi))
        Db.Where("kode_kota", txt_kode.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Kota()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_kota_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.PopulateField()
    End Sub
End Class