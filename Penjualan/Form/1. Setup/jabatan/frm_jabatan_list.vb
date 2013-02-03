Public Class frm_jabatan_list 

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("kode_jabatan, nama_jabatan")
        Db.From("tbl_jabatan")
        Db.OrderBy("kode_jabatan", cls_database.sorting.Ascending)

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_list.Columns("kode_jabatan").Visible = False
        GridV_list.Columns("nama_jabatan").Caption = "Nama Jabatan"

        GridV_list.Columns("kode_jabatan").Width = 100
        GridV_list.Columns("nama_jabatan").Width = 350

    End Sub

    Private Sub frm_jabatan_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.loadData()
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
        frm_jabatan_edit.Dispose()
        frm_jabatan_edit.initData(row("kode_jabatan"))
        frm_jabatan_edit.ShowDialog(Me)
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_jabatan_add.Dispose()
        frm_jabatan_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
            If MsgBox("Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Kategori") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_jabatan")
                Db.Where("kode_jabatan", row("kode_jabatan"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.loadData()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

End Class