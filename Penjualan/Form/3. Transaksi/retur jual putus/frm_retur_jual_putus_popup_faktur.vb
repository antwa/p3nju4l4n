Public Class frm_retur_jual_putus_popup_faktur 

    Public kode_customer_child As String
    Public kode_barangjadi As String
    Public Kembali As Boolean = False

    Public Sub loadData()

        Dim kode_customer_parent As String = kode_customer_child.Split(".")(0)

        Db.FlushCache()
        Db.Selects("a.no_faktur, a.kode_customer_parent, b.no_penjualan, c.kode_barangjadi, c.harga")
        Db.From("tbl_fakturkonsinyasi a")
        Db.Join("tbl_fakturkonsinyasi_detail b", "a.no_faktur = b.no_faktur")
        Db.Join("tbl_suratjalan_detail c", "b.no_penjualan = c.no_surat")
        If txt_search.Text <> vbNullString Then
            Db.Where("WHERE a.no_faktur LIKE '%" & txt_search.Text & "%'")
        End If
        Db.Where("c.kode_barangjadi", kode_barangjadi)
        Db.Where("a.kode_customer_parent", kode_customer_parent)
        Db.OrderBy("a.no_faktur", cls_database.sorting.Ascending)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub

    Public Sub AddData()
        With frm_retur_jual_putus
            Try
                Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                .rcd_list.Add(New rcd_retur_jual_putus(1, row("no_faktur"), row("kode_barangjadi"), row("harga"), 0, 0, ""))

                Me.Close()
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub frm_retur_jual_putus_popup_faktur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.loadData()
    End Sub

    Private Sub Cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_cari.Click
        Call Me.loadData()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Kembali = True
        Me.Close()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Call Me.AddData()
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        Call Me.AddData()
    End Sub
End Class