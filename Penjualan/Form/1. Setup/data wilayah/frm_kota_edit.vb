Public Class frm_kota_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kota")
        Db.Where("kode_kota", kode)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode.Text = .Item("kode_kota").ToString
                txt_kota.Text = .Item("kota").ToString
                lkp_kode_provinsi.Text = .Item("kode_provinsi").ToString

            End With
        End If

    End Sub

    Private Sub frm_kota_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Provinsi(lkp_kode_provinsi)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Update table tbl_kota
        Db.FlushCache()
        Db.Update("tbl_kota")
        Db.SetField("kode_kota", txt_kode.Text)
        Db.SetField("kota", txt_kota.Text)
        Db.SetField("kode_provinsi", lkp_kode_provinsi.Text)
        Db.Where("kode_kota", txt_kode.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.InitGrid1()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class