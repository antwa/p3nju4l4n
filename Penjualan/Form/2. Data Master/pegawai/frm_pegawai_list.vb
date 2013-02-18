Public Class frm_pegawai_list

    Public Sub loadData()

        Call initGrid()

        If search.Text <> "" Then
            Db.Where("WHERE nama LIKE '%" & search.Text & "%'")
        End If

        Db.OrderBy("nik", cls_database.sorting.Ascending)

        gridcontrol1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        gridview1.Columns("NIK").Caption = "NIK"
        gridview1.Columns("No KTP").Caption = "No KTP"
        gridview1.Columns("Nama").Caption = "Nama"
        gridview1.Columns("Alamat").Caption = "Alamat"

    End Sub

    Public Sub initGrid()
        Db.FlushCache()
        Db.Selects("tbl_pegawai.nik AS [NIK], tbl_pegawai.no_ktp AS [No KTP], tbl_pegawai.nama AS Nama, tbl_pegawai.alamat AS [Alamat]")
        Db.From("tbl_pegawai")


        gridcontrol1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub
    Private Sub frm_pegawai_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initGrid()
    End Sub

    Private Sub cmd_tambah_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_user.Click
        frm_pegawai_add.Dispose()
        frm_pegawai_add.ShowDialog(Me)
    End Sub

    Private Sub gridcontrol1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridcontrol1.DoubleClick
        'Try
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_pegawai_edit.Dispose()
        frm_pegawai_edit.initData(row("NIK"))
        frm_pegawai_edit.ShowDialog(Me)

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cmd_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_user.Click
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_pegawai_edit.Dispose()
        frm_pegawai_edit.initData(row("NIK"))
        frm_pegawai_edit.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call initGrid()
    End Sub

    Private Sub cmd_hapus_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_user.Click
        Try
            Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
            If MsgBox("NIK : " & row("nik") & vbCrLf & "Nama : " & row("nama") & vbCrLf & vbCrLf & _
                      "Apakah akan menghapus data diatas?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Data") = MsgBoxResult.Yes Then
                Db.FlushCache()
                Db.Delete("tbl_pegawai")
                Db.Where("nik", row("nik"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                    Call Me.initGrid()
                Else
                    MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari.Click
        Me.loadData()
    End Sub

    Private Sub search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles search.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.loadData()
        End If
    End Sub
End Class