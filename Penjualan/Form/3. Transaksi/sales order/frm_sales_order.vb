Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frm_sales_order

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_sales_order)

    Sub reIndex()
        If rcd_list.Count > 0 Then
            sistem_jual.Properties.ReadOnly = True
            kode_customer.Properties.ReadOnly = True
        Else
            sistem_jual.Properties.ReadOnly = False
            kode_customer.Properties.ReadOnly = False
        End If
    End Sub

    Sub initComponent()

        '# get nomor SO
        no_so.EditValue = getNomorUrut(C_SALES_ORDER)

        '# Grid
        rcd_list = New System.ComponentModel.BindingList(Of rcd_sales_order)
        GridControl1.DataSource = rcd_list

        GridView1.Columns.Item(0).Caption = "Kode Artikel"
        GridView1.Columns.Item(1).Caption = "Nama Artikel"
        GridView1.Columns.Item(2).Caption = "Qty (Pcs)"
        'GridView1.Columns.Item(3).Caption = "Keterangan"
        GridView1.Columns.Item(4).Caption = "Harga (Rp.)"
        GridView1.Columns.Item(5).Caption = "Total (Rp.)"
        GridView1.Columns.Item(6).Caption = "Keterangan"
        GridView1.Columns.Item(7).Caption = "Stok (Pcs)"

        GridView1.Columns.Item(3).Visible = False

        GridView1.Columns.Item(0).Width = 100
        GridView1.Columns.Item(1).Width = 200
        'GridView1.Columns.Item(2).Width = 200
        'GridView1.Columns.Item(3).Width = 200
        GridView1.Columns.Item(4).Width = 110
        GridView1.Columns.Item(5).Width = 110
        GridView1.Columns.Item(6).Width = 300
        'GridView1.Columns.Item(7).Width = 300

        FormatColumnNumeric(GridView1.Columns.Item(4))
        FormatColumnNumeric(GridView1.Columns.Item(5))

        GridView1.Columns("qty").Summary.Clear()
        GridView1.Columns("qty").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "qty", "{0:n0}")
        GridView1.Columns("total").Summary.Clear()
        GridView1.Columns("total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total", "{0:n0}")

        ' desable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item(2).OptionsColumn.AllowEdit = True
        GridView1.Columns.Item(6).OptionsColumn.AllowEdit = True

        tgl_so.DateTime = Now
        tgl_kirim.DateTime = Now
        tgl_rinciandist.DateTime = Now

        Load_Customer(kode_customer, sistem_jual.EditValue)

    End Sub

    Private Sub frm_sales_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub sistem_jual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sistem_jual.SelectedIndexChanged
        Load_Customer(kode_customer, sistem_jual.EditValue)
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Try
            rcd_list.RemoveAt(row)
            Call reIndex()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_SALES_ORDER
        frm_transaksi_popup_artkel.ShowDialog(Me)
        Call reIndex()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim vkode_customer As String = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount = 0 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# cek nomor
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_salesorder")
        Db.Where("no_so", no_so.EditValue)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If


        '# START TRANSAKSI
        Connection.TRANS_START()

        '# insert to table tbl_salesorder
        Db.FlushCache()
        Db.Insert("tbl_salesorder")
        Db.SetField("no_so", no_so.EditValue)
        Db.SetField("tgl_so", tgl_so.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("tgl_rinciandist", tgl_rinciandist.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("tgl_kirim", tgl_kirim.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("sistem_jual", sistem_jual.EditValue)
        Db.SetField("kode_customer", vkode_customer)
        Db.SetField("total_qty", GridView1.Columns.Item("qty").Summary.Item(0).SummaryValue)
        Db.SetField("total_value", GridView1.Columns.Item("total").Summary.Item(0).SummaryValue)
        Db.SetField("status", "0")
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 1
            '# insert to table tbl_salesorder_detail
            Db.FlushCache()
            Db.Insert("tbl_salesorder_detail")
            Db.SetField("no_so", no_so.EditValue)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("kode_hargajual", rcd_list.Item(i).kode_hargajual)
            Db.SetField("total", rcd_list.Item(i).total)
            Db.SetField("terkirim", "0")
            Db.SetField("ketarangan", rcd_list.Item(i).keterangan)

            Connection.TRANS_ADD(Db.GetQueryString)

        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            Call initComponent()
            Call reIndex()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub


    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer.EditValueChanged
        'MsgBox(kode_customer.GetColumnValue("kode_template_harga"))
    End Sub

    Private Sub GridControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseDoubleClick
        Try
            Dim row As Integer = GridView1.FocusedRowHandle
            Dim ghi As GridHitInfo = GridView1.CalcHitInfo(e.Location)

            If ghi.Column.FieldName = "harga" Then
                frm_transaksi_popup_harga.Dispose()
                frm_transaksi_popup_harga.parameter1 = C_SALES_ORDER
                frm_transaksi_popup_harga.kode_barangjadi = rcd_list.Item(row).kode_barangjadi
                frm_transaksi_popup_harga.nama = rcd_list.Item(row).nama
                frm_transaksi_popup_harga.row = row
                frm_transaksi_popup_harga.ShowDialog(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class