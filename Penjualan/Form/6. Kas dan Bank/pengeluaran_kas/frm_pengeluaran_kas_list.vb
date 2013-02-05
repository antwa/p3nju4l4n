Public Class frm_pengeluaran_kas_list

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("a.id_jurnal, a.id_pengeluaran, a.jumlah, a.tanggal, b.keterangan")
        Db.From("tbl_pengeluaran_kas a")
        Db.Join("tbl_jurnal b", "b.id_jurnal = a.id_jurnal")

        If search.Text <> "" Then
            Db.Where("WHERE a.id_jurnal LIKE '" & search.Text & "%'")
            Db.Where("WHERE b.keterangan LIKE '" & search.Text & "%'")
        End If

        Db.OrderBy("a.tanggal", cls_database.sorting.Ascending)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridView1.Columns("id_jurnal").Caption = "Jurnal ID"
        GridView1.Columns("id_pengeluaran").Caption = "No. Transaksi"
        GridView1.Columns("tanggal").Caption = "Tanggal"
        GridView1.Columns("jumlah").Caption = "Jumlah Pengeluaran (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("id_jurnal").Width = 140
        GridView1.Columns("id_pengeluaran").Width = 190
        GridView1.Columns("tanggal").Width = 160
        GridView1.Columns("jumlah").Width = 100
        GridView1.Columns("keterangan").Width = 300

        FormatColumnNumeric(GridView1.Columns("jumlah"))

    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_pengeluaran_kas_add.Dispose()
        frm_pengeluaran_kas_add.ShowDialog(Me)
        'Call Me.loadData()
    End Sub

    Private Sub frm_pengeluaran_kas_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()

    End Sub
End Class