Public Class frm_barangjadi_list 

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("a.kode_barangjadi, a.nama, b.kategori, a.harga_pokok, a.keterangan")
        Db.From("tbl_barangjadi a")
        Db.Join("tbl_kategori_barang b", "b.kode_kategori = a.kode_kategori")

        If search.Text <> "" Then
            Db.Where("WHERE a.kode_barangjadi LIKE '" & search.Text & "%'")
        End If

        Db.OrderBy("a.kode_barangjadi", cls_database.sorting.Ascending)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridView1.Columns("kode_barangjadi").Caption = "Kode"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("kategori").Caption = "Kategori"
        GridView1.Columns("harga_pokok").Caption = "Harga Pokok (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("kode_barangjadi").Width = 140
        GridView1.Columns("nama").Width = 190
        GridView1.Columns("kategori").Width = 160
        GridView1.Columns("harga_pokok").Width = 100
        GridView1.Columns("keterangan").Width = 300

        FormatColumnNumeric(GridView1.Columns("harga_pokok"))

    End Sub

    Private Sub frm_barangjadi_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.loadData()
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If MsgBox("Kode Artikel : " & row("kode_barangjadi") & vbCrLf & "Nama : " & row("nama") & vbCrLf & vbCrLf & _
                      "Apakah akan menghapus artikel diatas?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Artikel") = MsgBoxResult.Yes Then
                Db.FlushCache()
                Db.Delete("tbl_barangjadi")
                Db.Where("kode_barangjadi", row("kode_barangjadi"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                    Call Me.loadData()
                Else
                    MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles search.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Me.loadData()
        End If
    End Sub

    Private Sub cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari.Click
        Me.loadData()
    End Sub

    Private Sub cmd_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_refresh.Click
        Call Me.loadData()
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_barangjadi_add.Dispose()
        frm_barangjadi_add.ShowDialog(Me)
        Call Me.loadData()
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Try
            Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            frm_barangjadi_edit.Dispose()
            frm_barangjadi_edit.initData(row("kode_barangjadi"))
            frm_barangjadi_edit.ShowDialog(Me)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_formula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_formula.Click
        Try
            Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            frm_barangjadi_edit_formula.Dispose()
            frm_barangjadi_edit_formula.initData(row("kode_barangjadi"), row("nama"))
            frm_barangjadi_edit_formula.ShowDialog(Me)

        Catch ex As Exception

        End Try
    End Sub

End Class