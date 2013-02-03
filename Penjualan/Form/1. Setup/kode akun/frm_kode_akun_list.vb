Imports DevExpress.XtraTreeList.StyleFormatConditions

Public Class frm_kode_akun_list


    Public Sub LoadData()
        Dim i As Integer

        Db.FlushCache()
        Db.Selects("kode_akun AS kode, *")
        Db.From("tbl_akun")
        Db.OrderBy("kode_akun", cls_database.sorting.Ascending)
        Db.OrderBy("nama_akun", cls_database.sorting.Ascending)

        TreeList1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        TreeList1.PopulateColumns()
        TreeList1.KeyFieldName = "kode_akun"
        TreeList1.ParentFieldName = "kode_parent"

        '# visible
        For i = 0 To TreeList1.Columns.Count - 1
            TreeList1.Columns(i).Visible = False
        Next
        TreeList1.Columns("kode").Visible = True
        TreeList1.Columns("nama_akun").Visible = True
        TreeList1.Columns("tipe").Visible = True

        ' caption
        TreeList1.Columns("kode").Caption = "Kode"
        TreeList1.Columns("nama_akun").Caption = "Nama Akun"
        TreeList1.Columns("tipe").Caption = "Tipe"

        ' position column
        TreeList1.Columns("kode").VisibleIndex = 1
        TreeList1.Columns("nama_akun").VisibleIndex = 0
        TreeList1.Columns("tipe").VisibleIndex = 2

        ' width
        TreeList1.Columns("kode").Width = 60
        TreeList1.Columns("nama_akun").Width = 300
        TreeList1.Columns("tipe").Width = 30
        

        TreeList1.ExpandAll()

    End Sub

    Private Sub frm_kode_akun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.LoadData()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call Me.LoadData()
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_kode_akun_add.Dispose()
        frm_kode_akun_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        Try
            Dim kode As String = TreeList1.FocusedNode("kode").ToString()
            frm_kode_akun_edit.Dispose()
            frm_kode_akun_edit.kode_akun = kode
            frm_kode_akun_edit.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus.Click
        Try
            Dim kode As String = TreeList1.FocusedNode("kode")
            If TreeList1.FocusedNode("kode_parent") = "0" Then
                MsgBox("Maaf untuk Akun ini tidak bisa dihapus dari database.", MsgBoxStyle.Exclamation)
            Else
                'If TreeList1.FocusedNode("tipe") = "H" Then

                'Else
                If MsgBox("Apakah akan menghapus Akun dengan kode '" & kode & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then
                    Db.FlushCache()
                    Db.Delete("tbl_akun")
                    Db.Where("kode_akun", kode)
                    Db.Where("kode_parent", kode, "=", "OR")

                    If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                        MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                        Me.LoadData()
                    End If
                End If
                'End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class