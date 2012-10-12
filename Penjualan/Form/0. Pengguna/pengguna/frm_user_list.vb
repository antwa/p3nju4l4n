Public Class frm_user_list 

    Sub HakAkses()
        'cmd_tambah_user.Enabled = Auth.canInsert(Me.Name)
        'cmd_edit_user.Enabled = Auth.canUpdate(Me.Name)
        'cmd_hapus_user.Enabled = Auth.canDelete(Me.Name)

        'cmd_tambah_level.Enabled = Auth.canInsert(Me.Name)
        'cmd_edit_level.Enabled = Auth.canUpdate(Me.Name)
        'cmd_hapus_level.Enabled = Auth.canDelete(Me.Name)

    End Sub

    Public Sub InitGrid()

        ' init grid from database
        ' user
        Db.FlushCache()
        Db.Selects("a.username AS Username, b.nama_level AS Level, a.nama_lengkap AS [Nama Lengkap], a.jabatan AS Jabatan")
        Db.From("sys_user a")
        Db.Join("sys_level b", "a.kode_level = b.kode_level")

        grid_user.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        ' level
        Db.FlushCache()
        Db.Selects("kode_level AS [Kode Level Akses], nama_level AS [Nama Level Akses]")
        Db.From("sys_level")

        grid_level.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_user.Click
        frm_user_add.Dispose()
        frm_user_add.ShowDialog(Me)
    End Sub

    Private Sub frm_user_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitGrid()
        Call HakAkses()
        ' auth button
        'cmd_tambah_user.Enabled = Auth.canInsert(Me.Name)
        'cmd_edit_user.Enabled = Auth.canUpdate(Me.Name)
        'cmd_hapus_user.Enabled = Auth.canDelete(Me.Name)

        'cmd_tambah_level.Enabled = Auth.canInsert(Me.Name)
        'cmd_edit_level.Enabled = Auth.canUpdate(Me.Name)
        'cmd_hapus_level.Enabled = Auth.canDelete(Me.Name)

    End Sub

    Private Sub cmd_tambah_level_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_level.Click
        frm_userlevel_add.Dispose()
        frm_userlevel_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_edit_level_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_level.Click
        Dim row As System.Data.DataRow = GridV_level.GetDataRow(GridV_level.FocusedRowHandle)
        frm_userlevel_edit.Dispose()
        frm_userlevel_edit.initData(row("Kode Level Akses"), row("Nama Level Akses"))
        frm_userlevel_edit.ShowDialog(Me)
    End Sub

    Private Sub GridV_level_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridV_level.DoubleClick
        Call cmd_edit_level_Click(sender, e)
    End Sub

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim i As Integer
        Dim row As System.Data.DataRow
        For i = 0 To GridV_level.RowCount - 1
            row = GridV_level.GetDataRow(i)
            MsgBox("Kode Level : " & row("Kode Level Akses"))
        Next
    End Sub

    Private Sub cmd_hapus_level_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_level.Click
        Try
            Dim row As System.Data.DataRow = GridV_level.GetDataRow(GridV_level.FocusedRowHandle)
            If MsgBox("Kode Level : " & row(0) & vbCrLf & "Nama Level : " & row(1) & vbCrLf & vbCrLf & "Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Level Akses") = MsgBoxResult.Yes Then
                Db.FlushCache()
                Db.Delete("sys_level")
                Db.Where("kode_level", row(0))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    Db.FlushCache()
                    Db.Delete("sys_level_detail")
                    Db.Where("kode_level", row(0))

                    If Connection.ExecuteNonQuery(Db.GetQueryString) Then

                        MsgBox("Kode Level : " & row(0) & ", Berhasil dihapus", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                        Call InitGrid()

                    End If

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_user.Click
        Dim row As System.Data.DataRow = GridV_user.GetDataRow(GridV_user.FocusedRowHandle)

        frm_user_edit.Dispose()
        frm_user_edit.initData(row("Username"))
        frm_user_edit.ShowDialog(Me)

    End Sub

    Private Sub grid_level_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_level.Click

    End Sub

    Private Sub cmd_hapus_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_user.Click
        Try
            Dim row As System.Data.DataRow = GridV_user.GetDataRow(GridV_user.FocusedRowHandle)
            If MsgBox("Username : " & row("Username") & vbCrLf & vbCrLf & vbCrLf & "Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Username") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("sys_user")
                Db.Where("username", row("Username"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Username : " & row("Username") & ", Berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call InitGrid()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class