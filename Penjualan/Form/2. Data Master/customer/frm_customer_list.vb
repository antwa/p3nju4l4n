Public Class frm_customer_list 

    Public Sub loadData()

        Db.FlushCache()
        Db.Selects("kode_customer_parent AS [Kode], nama AS [Nama], alamat AS Alamat, telp1 AS [Telepon 1]")
        Db.From("tbl_customer_parent")

        If search.Text <> "" Then
            Db.Where("WHERE nama LIKE '%" & search.Text & "%'")
        End If

        Db.OrderBy("kode_customer_parent", cls_database.sorting.Ascending)

        gridcontrol1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        gridview1.Columns("Kode").Caption = "Kode"
        gridview1.Columns("Nama").Caption = "Nama"
        gridview1.Columns("Alamat").Caption = "Alamat"
        gridview1.Columns("Telepon 1").Caption = "Telepon 1"

    End Sub

    Private Sub frm_customer_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.loadData()
    End Sub

    Private Sub cmd_tambah_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_user.Click
        frm_customer_add.Dispose()
        frm_customer_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_user.Click
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_customer_edit.Dispose()
        frm_customer_edit.kode = row("Kode")
        frm_customer_edit.ShowDialog(Me)
    End Sub

    Private Sub gridcontrol1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridcontrol1.DoubleClick
        Try
            Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
            frm_customer_edit.Dispose()
            frm_customer_edit.kode = row("Kode")
            frm_customer_edit.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call Me.loadData()
    End Sub

    Private Sub cmd_hapus_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_user.Click
        Try
            Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
            If MsgBox("Kode : " & row("Kode") & vbCrLf & "Nama : " & row("Nama") & vbCrLf & vbCrLf & _
                      "Apakah akan menghapus data diatas?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Data") = MsgBoxResult.Yes Then

                Connection.TRANS_START()

                ' delete in customer parent
                Db.FlushCache()
                Db.Delete("tbl_customer_parent")
                Db.Where("kode_customer_parent", row("Kode"))
                Connection.TRANS_ADD(Db.GetQueryString)

                ' delete in customer child
                Db.FlushCache()
                Db.Delete("tbl_customer_child")
                Db.Where("kode_customer_parent", row("Kode"))
                Connection.TRANS_ADD(Db.GetQueryString)

                If Connection.TRANS_SUCCESS Then
                    MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                    Call Me.loadData()
                Else
                    MsgBox("Data gagal dihapus" & vbCrLf & Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
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
            Call Me.loadData()
        End If
    End Sub
End Class