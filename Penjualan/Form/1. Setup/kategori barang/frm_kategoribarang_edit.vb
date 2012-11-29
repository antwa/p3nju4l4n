Public Class frm_kategoribarang_edit 

    Public Sub initData(ByVal kode As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kategori_barang")
        Db.Where("kode_kategori", kode)

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
        '# Update table tbl_kategori_barang
        Db.FlushCache()
        Db.Update("tbl_kategori_barang")
        'Db.SetField("kode_kategori", txt_kode_kategori.Text)
        Db.SetField("kategori", txt_kategori.Text)
        Db.Where("kode_kategori", txt_kode_kategori.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.InitGrid()

            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    
    Private Sub frm_kategoribarang_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class