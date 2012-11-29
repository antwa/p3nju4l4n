Public Class frm_jenisharga_list 

    Public Sub InitGrid()
        'Dim rcd_list As System.ComponentModel.BindingList(Of rcd_kategori_barang)
        ' init grid from database
        'rcd_list = New System.ComponentModel.BindingList(Of rcd_kategori_barang)
        Db.FlushCache()
        Db.Selects("kode_jenis_harga, jenis")
        Db.From("tbl_jenis_hargabarang")

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("kode_jenis_hargabarang, jenis")
        Db.From("tbl_jenis_hargabarang")

        If txt_cari.Text <> "" Then
            Db.Where("WHERE kode_jenis_harga LIKE '" & txt_cari.Text & "%'")
        End If

        Db.OrderBy("kode_jenis_harga", cls_database.sorting.Ascending)

        grid_list.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_list.Columns("kode_jenis_harga").Caption = "Kode"
        GridV_list.Columns("jenis").Caption = "Jenis"

        GridV_list.Columns("kode_jenis_harga").Width = 20
        GridV_list.Columns("jenis").Width = 100

    End Sub

    Private Sub frm_jenisharga_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitGrid()
        Call Me.loadData()
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_jenisharga_add.Dispose()
        frm_jenisharga_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
        frm_jenisharga_edit.Dispose()
        frm_jenisharga_edit.initData(row("kode_jenis_harga"))
        frm_jenisharga_edit.ShowDialog(Me)
    End Sub

    Private Sub txt_cari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cari.Click
        
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim row As System.Data.DataRow = GridV_list.GetDataRow(GridV_list.FocusedRowHandle)
            If MsgBox("Jenis Harga : " & row("Jenis") & vbCrLf & vbCrLf & vbCrLf & "Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Kategori") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_jenis_hargabarang")
                Db.Where("kode_jenis_hargabarang", row("Kode"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Jenis Harga : " & row("Jenis") & ", Berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call InitGrid()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call Me.loadData()
    End Sub

    Private Sub txt_cari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Me.loadData()
        End If
    End Sub
End Class