Public Class frm_supplier_barang_list

    Public Sub initGrid()
        Db.FlushCache()
        Db.Selects("tbl_supplier_barang.kode_supplier_barang AS [KODE], tbl_supplier_barang.nama AS [Nama Supplier], tbl_supplier_barang.alamat AS [Alamat], tbl_supplier_barang.kota AS [Kota]")
        Db.From("tbl_supplier_barang")

        gridcontrol1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub

    Private Sub frm_supplier_barang_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initGrid()
    End Sub

    Private Sub cmd_tambah_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah_user.Click
        frm_supplier_barang_add.Dispose()
        frm_supplier_barang_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_user.Click
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_supplier_barang_add.Dispose()
        frm_supplier_barang_edit.initData(row("KODE"))
        frm_supplier_barang_edit.ShowDialog(Me)
    End Sub

    Private Sub cmd_hapus_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_user.Click
        Try
            Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
            If MsgBox("Kode : " & row("kode_supplier_barang") & vbCrLf & "Nama : " & row("nama") & vbCrLf & vbCrLf & _
                      "Apakah akan menghapus data diatas?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Data") = MsgBoxResult.Yes Then
                Db.FlushCache()
                Db.Delete("tbl_supplier_barang")
                Db.Where("kode_supplier_barang", row("kode_supplier_barang"))

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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call initGrid()
    End Sub

    Private Sub gridcontrol1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridcontrol1.DoubleClick
        Dim row As System.Data.DataRow = gridview1.GetDataRow(gridview1.FocusedRowHandle)
        frm_supplier_barang_add.Dispose()
        frm_supplier_barang_edit.initData(row("KODE"))
        frm_supplier_barang_edit.ShowDialog(Me)
    End Sub
End Class