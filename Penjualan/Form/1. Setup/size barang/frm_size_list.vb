Public Class frm_size_list 

    Public Sub InitGrid()
        'Dim rcd_list As System.ComponentModel.BindingList(Of rcd_kategori_barang)
        ' init grid from database
        'rcd_list = New System.ComponentModel.BindingList(Of rcd_kategori_barang)
        Db.FlushCache()
        Db.Selects("kode_size, size")
        Db.From("tbl_size")

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("kode_size, size")
        Db.From("tbl_size")

        If txt_cari.Text <> "" Then
            Db.Where("WHERE kode_size LIKE '" & txt_cari.Text & "%'")
        End If

        Db.OrderBy("kode_size", cls_database.sorting.Ascending)

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_list.Columns("kode_size").Caption = "Kode"
        GridV_list.Columns("size").Caption = "Size"

        GridV_list.Columns("kode_size").Width = 20
        GridV_list.Columns("size").Width = 100

    End Sub

    Private Sub cmd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
        frm_size_edit.Dispose()
        frm_size_edit.initData(row("kode_size"))
        frm_size_edit.ShowDialog(Me)
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_size_add.Dispose()
        frm_size_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
            If MsgBox("Size : " & row("Size") & vbCrLf & vbCrLf & vbCrLf & "Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Size") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_size")
                Db.Where("kode_size", row("Kode"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Size : " & row("Size") & ", Berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call InitGrid()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txt_cari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Me.loadData()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call Me.loadData()
    End Sub

    Private Sub frm_size_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitGrid()
        Call Me.loadData()
    End Sub
End Class