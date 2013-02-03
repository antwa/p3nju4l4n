Public Class frm_template_harga_list 

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("kode_template_harga, nama_harga")
        Db.From("tbl_template_hargajual")
        Db.OrderBy("kode_template_harga", cls_database.sorting.Ascending)

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_list.Columns("kode_template_harga").Caption = "No."
        GridV_list.Columns("nama_harga").Caption = "Nama Harga Jual"

        GridV_list.Columns("kode_template_harga").Width = 50
        GridV_list.Columns("nama_harga").Width = 300

    End Sub

    Private Sub frm_template_harga_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.loadData()
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
        frm_template_harga_edit.Dispose()
        frm_template_harga_edit.initData(row("kode_template_harga"))
        frm_template_harga_edit.ShowDialog(Me)
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_template_harga_add.Dispose()
        frm_template_harga_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
            If MsgBox("Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Kategori") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_template_hargajual")
                Db.Where("kode_template_harga", row("kode_template_harga"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.loadData()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

End Class