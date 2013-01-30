Public Class frm_customer_list 
    Public Sub initGrid()
        Db.FlushCache()
        Db.Selects("tbl_customer.kode_customer AS [Kode], tbl_customer.nama AS [Nama], tbl_customer.alamat AS Alamat, tbl_customer.telp1 AS [Telepon 1]")
        Db.From("tbl_customer")

        gridcontrol1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub
    Private Sub frm_customer_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initGrid()
    End Sub

    Private Sub cmd_tambah_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_user.Click
        frm_customer_add.Dispose()
        frm_customer_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_user.Click
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_customer_edit.Dispose()
        frm_customer_edit.initData(row("Kode"))
        frm_customer_edit.ShowDialog(Me)
    End Sub

    Private Sub gridcontrol1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridcontrol1.DoubleClick
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_customer_edit.Dispose()
        frm_customer_edit.initData(row("Kode"))
        frm_customer_edit.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call initGrid()
    End Sub

    Private Sub cmd_hapus_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_user.Click
        Try
            Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
            If MsgBox("Kode : " & row("kode_customer") & vbCrLf & "Nama : " & row("nama") & vbCrLf & vbCrLf & _
                      "Apakah akan menghapus data diatas?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Data") = MsgBoxResult.Yes Then
                Db.FlushCache()
                Db.Delete("tbl_customer")
                Db.Where("kode_customer", row("Kode"))

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
End Class