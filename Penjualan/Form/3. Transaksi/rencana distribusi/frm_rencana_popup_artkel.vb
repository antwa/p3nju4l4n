Public Class frm_rencana_popup_artkel

    Sub initGrid()

        Db.FlushCache()
        Db.Selects("a.kode_barangjadi, a.nama, c.kategori, b.stok")
        Db.From("tbl_barangjadi a")
        Db.Join("tbl_persediaan_gudang b", "a.kode_barangjadi = b.kode_barangjadi")
        Db.Join("tbl_kategori_barang c", "a.kode_kategori = c.kode_kategori")

        If txt_search.Text <> vbNullString Then
            Db.Where(" AND a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
        End If

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        dt.Columns.Add("checked", GetType(Boolean))

        GridControl1.DataSource = dt

        With GridView1
            .Columns("kode_barangjadi").Caption = "Kode Artikel"
            .Columns("nama").Caption = "Nama"
            .Columns("kategori").Caption = "Kategori"
            .Columns("stok").Caption = "Stok"
            .Columns("checked").Caption = "-"
        End With

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("checked").OptionsColumn.AllowEdit = True

        For i = 0 To GridView1.RowCount
            GridView1.SetRowCellValue(i, "checked", False)
        Next

    End Sub

    Sub addArtikel()

        If GridView1.RowCount <= 0 Then
            MsgBox("Tidak terdapat artikel!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim i As Integer = 0
        For i = 0 To GridView1.RowCount - 1
            Dim R As System.Data.DataRow = GridView1.GetDataRow(i)
            If R.Item("checked") = True Then
                frm_rencana_distribusi.AddArtikelToList(R.Item("kode_barangjadi").ToString, R.Item("nama").ToString, R.Item("stok").ToString, 0)
            End If
        Next

        Me.Close()
    End Sub

    Private Sub frm_rancana_popup_artkel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initGrid()
    End Sub


    Private Sub Cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_cari.Click
        Call initGrid()
    End Sub

    Private Sub txt_search_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.EditValueChanged

    End Sub

    Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_search.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Call initGrid()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        Call addArtikel()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        'Call addArtikel()
    End Sub
End Class