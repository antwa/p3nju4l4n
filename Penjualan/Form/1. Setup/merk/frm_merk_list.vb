Public Class frm_merk_list 

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("kode_merk, merk")
        Db.From("tbl_merk")

        If txt_cari.Text <> "" Then
            Db.Where("WHERE merk LIKE '%" & txt_cari.Text & "%'")
        End If

        Db.OrderBy("kode_merk", cls_database.sorting.Ascending)

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_list.Columns("kode_merk").Caption = "Kode"
        GridV_list.Columns("merk").Caption = "Merk"

        GridV_list.Columns("kode_merk").Width = 20
        GridV_list.Columns("merk").Width = 100

    End Sub

    Private Sub frm_merk_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.loadData()
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
        frm_merk_edit.Dispose()
        frm_merk_edit.kode_merk = row("kode_merk")
        frm_merk_edit.ShowDialog(Me)
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_merk_add.Dispose()
        frm_merk_add.ShowDialog(Me)
    End Sub

    Private Sub txt_cari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Me.loadData()
        End If
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
            If MsgBox("Merk : " & row("Merk") & vbCrLf & vbCrLf & vbCrLf & "Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_merk")
                Db.Where("kode_merk", row("kode_merk"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Merk : " & row("Merk") & ", Berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.loadData()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call Me.loadData()
    End Sub
End Class