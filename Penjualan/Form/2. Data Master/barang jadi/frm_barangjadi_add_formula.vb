Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_barangjadi_add_formula

    Public vkode_barangjadi As String
    Public vnama As String

    Public rcd_list As New DataTable

    Private Sub frm_barangjadi_add_formula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kode_barangjadi.Text = vkode_barangjadi
        lbl_nama.Text = vnama

        rcd_list = New DataTable
        rcd_list.Columns.Add("nama_harga", GetType(String))
        rcd_list.Columns.Add("harga", GetType(Integer))
        GridControl1.DataSource = rcd_list

        GridView1.Columns("nama_harga").Caption = "Nama Harga"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"

        GridView1.Columns("nama_harga").Width = 250
        GridView1.Columns("harga").Width = 100

        FormatColumnNumeric(GridView1.Columns("harga"))

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        'Validation
        If rcd_list.Rows.Count = 0 Then
            MsgBox("Data harga tidak boleh kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To rcd_list.Rows.Count - 1
            MsgBox(GridView1.GetDataRow(i).Item("nama_harga"))

            '# insert to table tbl_hargajual
            Db.FlushCache()
            Db.Insert("tbl_hargajual")
            Db.SetField("kode_barangjadi", kode_barangjadi.Text)
            Db.SetField("nama_harga", GridView1.GetDataRow(i).Item("nama_harga"))
            Db.SetField("harga", GridView1.GetDataRow(i).Item("harga"))

            Connection.TRANS_ADD(Db.GetQueryString)

        Next

        Me.Close()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Try
            rcd_list.Rows.RemoveAt(row)
        Catch ex As Exception

        End Try
    End Sub
End Class