Public Class frm_kota_add 

    Private Sub frm_kota_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Provinsi(lkp_kode_provinsi)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# validation
        Validation.clearRules()
        Validation.addRules(txt_kode.Text, "Kode Kota", "required|length[1-5]")
        Validation.addRules(txt_kota.Text, "Kota", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If


        '# cek kode kota di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kota")
        Db.Where("kode_kota", txt_kode.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat kode tersebut pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If


        '# insert to table tbl_kota
        Db.FlushCache()
        Db.Insert("tbl_kota")
        Db.SetField("kode_kota", txt_kode.Text)
        Db.SetField("kota", txt_kota.Text)
        Db.SetField("kode_provinsi", getValueFromLookup(lkp_kode_provinsi))


        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Kota()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class