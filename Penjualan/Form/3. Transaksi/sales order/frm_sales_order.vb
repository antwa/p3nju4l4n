﻿Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_sales_order

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_sales_order)

    Sub reIndex()
        Dim i As Integer = 1
        For i = 1 To rcd_list.Count
            rcd_list.Item(i - 1).no = i
        Next

        rcd_list.Item(rcd_list.Count - 1).no = 0

        If rcd_list.Count > 1 Then
            sistem_jual.Properties.ReadOnly = True
            kode_customer_parent.Properties.ReadOnly = True
        Else
            sistem_jual.Properties.ReadOnly = False
            kode_customer_parent.Properties.ReadOnly = False
        End If

        GridView1.RefreshData()
    End Sub

    Sub initComponent()

        '# get nomor SO
        no_so.EditValue = getNomorUrut(C_SALES_ORDER)

        '# Grid
        rcd_list = New System.ComponentModel.BindingList(Of rcd_sales_order)
        rcd_list.Add(New rcd_sales_order)

        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("qty").Caption = "Qty (Pcs)"
        'GridView1.Columns("kode_hargajual").Caption = ""
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("total").Caption = "Total (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"
        GridView1.Columns("stok").Caption = "Stok (Pcs)"

        GridView1.Columns("no").Width = 35
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("nama").Width = 150
        GridView1.Columns("qty").Width = 65
        GridView1.Columns("kode_hargajual").Width = 90
        GridView1.Columns("harga").Width = 75
        GridView1.Columns("total").Width = 75
        GridView1.Columns("keterangan").Width = 200
        GridView1.Columns("stok").Width = 65

        FormatColumnNumeric(GridView1.Columns.Item("harga"))
        FormatColumnNumeric(GridView1.Columns.Item("total"))

        'visible colum
        GridView1.Columns("kode_hargajual").Visible = False

        ' sumary
        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("total"))

        ' desable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns("kode_barangjadi").OptionsColumn.AllowEdit = True
        GridView1.Columns("qty").OptionsColumn.AllowEdit = True
        GridView1.Columns("keterangan").OptionsColumn.AllowEdit = True

        tgl_so.DateTime = Now
        tgl_kirim.DateTime = Now
        tgl_rinciandist.DateTime = Now

        Load_CustomerParent(kode_customer_parent, sistem_jual.EditValue)

    End Sub

    Private Sub frm_sales_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub sistem_jual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sistem_jual.SelectedIndexChanged
        If sistem_jual.EditValue = "1" Then
            cmb_tipecustomer.Enabled = True
        Else
            cmb_tipecustomer.Enabled = False
        End If
        Load_CustomerParent(kode_customer_parent, sistem_jual.EditValue)
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Dim rowNewItem As Integer = rcd_list.Count - 1
        Try
            If row <> rowNewItem Then
                rcd_list.RemoveAt(row)
                Call Me.reIndex()
            End If
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
        Dim vkode_customer As String

        If sistem_jual.EditValue = "1" Then
            vkode_customer = getValueFromLookup(kode_customer_parent) & "." & (CInt(cmb_tipecustomer.SelectedIndex) + 1)
        Else
            vkode_customer = getValueFromLookup(kode_customer_parent) & ".4"
        End If

        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount <= 1 Then
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
        Db.SetField("tgl_so", tgl_so.DateTime)
        Db.SetField("tgl_rinciandist", tgl_rinciandist.DateTime)
        Db.SetField("tgl_kirim", tgl_kirim.DateTime)
        Db.SetField("sistem_jual", sistem_jual.EditValue)
        Db.SetField("kode_customer_child", vkode_customer)
        Db.SetField("total_qty", GridView1.Columns.Item("qty").Summary.Item(0).SummaryValue)
        Db.SetField("total_value", GridView1.Columns.Item("total").Summary.Item(0).SummaryValue)
        Db.SetField("status", "0")
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 2
            '# insert to table tbl_salesorder_detail
            Db.FlushCache()
            Db.Insert("tbl_salesorder_detail")
            Db.SetField("no_so", no_so.EditValue)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("kode_hargajual", rcd_list.Item(i).kode_hargajual)
            Db.SetField("total", rcd_list.Item(i).total)
            Db.SetField("terkirim", "0")
            Db.SetField("keterangan", rcd_list.Item(i).keterangan)

            Connection.TRANS_ADD(Db.GetQueryString)

        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then

            'ambil informasi customer
            Db.FlushCache()
            Db.Selects("a.nama, b.kota, a.mall, a.alamat")
            Db.From("tbl_customer_parent a")
            Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
            Db.Where("a.kode_customer_parent", getValueFromLookup(kode_customer_parent))

            Dim rcustomer As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
            rcustomer.Read()

            '# delete row new item
            rcd_list.RemoveAt(rcd_list.Count - 1)

            '# Print
            Dim rpt As New rpt_sales_order
            rpt.BindingSource1.DataSource = rcd_list
            rpt.no_so.Text = "Nomor : " & no_so.Text
            rpt.tgl_rinciandist.Text = tgl_rinciandist.DateTime.ToString("dd/MM/yyyy")
            rpt.tgl_kirim.Text = tgl_kirim.DateTime.ToString("dd/MM/yyyy")
            rpt.nama.Text = rcustomer.Item("nama").ToString
            rpt.alamat.Text = rcustomer.Item("alamat").ToString
            rpt.mall.Text = rcustomer.Item("mall").ToString
            rpt.kota.Text = rcustomer.Item("kota").ToString
            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Sales Order"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            Call initComponent()
            Call reIndex()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub


    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer_parent.EditValueChanged
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

    Private Sub GridControl1_EditorKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.EditorKeyPress
        Dim grid As GridControl = CType(sender, GridControl)
        GridView1_KeyPress(grid.FocusedView, e)
    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        Dim view As GridView = CType(sender, GridView)
        Dim row As Integer = view.FocusedRowHandle
        Dim rowItemNew As Integer = rcd_list.Count - 1

        If view.FocusedColumn.FieldName = "kode_barangjadi" And row <> rowItemNew Then
            e.Handled = True
            Exit Sub
        End If

        If Asc(e.KeyChar) = 13 Then
            '# cek customer
            If getValueFromLookup(kode_customer_parent) = "-1" Then
                MsgBox("Pilih Customer dengan benar!" & vbCrLf & vbCrLf & "Jangan pilih semua customer", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Select Case view.FocusedColumn.FieldName
                Case "kode_barangjadi"
                    Dim tmp_kode_barangjadi As String = rcd_list.Item(row).kode_barangjadi
                    tmp_kode_barangjadi = tmp_kode_barangjadi.Replace(".", vbNullString)
                    If tmp_kode_barangjadi.Length < 7 Then
                        MsgBox("Masukan kode dengan benar!", MsgBoxStyle.Exclamation)
                    Else
                        tmp_kode_barangjadi = tmp_kode_barangjadi.Substring(0, 2) & "." & tmp_kode_barangjadi.Substring(2, 3) & "." & tmp_kode_barangjadi.Substring(5, 2)

                        '# get barang jadi
                        Db.FlushCache()
                        Db.Selects("a.kode_barangjadi, a.nama, b.stok")
                        Db.From("tbl_barangjadi a")
                        Db.Join("tbl_persediaan_gudang b", "a.kode_barangjadi = b.kode_barangjadi")
                        Db.Where(" AND a.kode_barangjadi LIKE '%" & tmp_kode_barangjadi & "%'")

                        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If dt1.Rows.Count > 0 Then
                            Dim kode_barangjadi As String = dt1.Rows(0).Item("kode_barangjadi").ToString

                            ' cek artikel, takut kalo ada yang sama
                            For i = 0 To rcd_list.Count - 1
                                If rcd_list.Item(i).kode_barangjadi = kode_barangjadi Then
                                    MsgBox("Kode artikel " & kode_barangjadi & ", Sudah diinputkan. ganti dengan yang lain", MsgBoxStyle.Exclamation)
                                    Exit Sub
                                End If
                            Next

                            rcd_list.Item(row).kode_barangjadi = kode_barangjadi
                            rcd_list.Item(row).nama = dt1.Rows(0).Item("nama").ToString
                            rcd_list.Item(row).stok = dt1.Rows(0).Item("stok").ToString

                            '# ambil harga
                            Db.FlushCache()
                            Db.Selects("kode_hargajual, kode_template_harga, harga")
                            Db.From("tbl_hargajual")
                            Db.Where("kode_barangjadi", rcd_list.Item(row).kode_barangjadi)
                            Db.Where("kode_template_harga", kode_customer_parent.GetColumnValue("kode_template_harga"))

                            Dim dt2 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                            rcd_list.Item(row).kode_hargajual = dt2.Rows(0).Item("kode_hargajual").ToString
                            rcd_list.Item(row).harga = dt2.Rows(0).Item("harga").ToString

                            '# refres data
                            rcd_list.Add(New rcd_sales_order)
                            Call Me.reIndex()
                            setFocusCell(GridView1, row, "qty")
                            GridView1.RefreshData()
                        Else
                            MsgBox("Tidak terdapat kode barang '" & tmp_kode_barangjadi & "'", MsgBoxStyle.Exclamation)
                        End If
                    End If

                Case "qty"
                    If row < rowItemNew Then
                        setFocusCell(GridView1, row + 1, "kode_barangjadi")
                    End If
            End Select
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub cmd_load_rencana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load_rencana.Click

        Db.FlushCache()
        Db.Selects("a.tanggal, b.kode_barangjadi, c.nama AS nama_barangjadi, b.qty")
        Db.From("tbl_rencana_distribusi a")
        Db.Join("tbl_rencana_distribusi_detail b", "b.no_rencana = a.no_rencana")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
        Db.Where("b.kode_customer", getValueFromLookup(kode_customer_parent))
        Db.Where_BetweenDate("a.tanggal", tgl_rinciandist.DateTime, tgl_rinciandist.DateTime)

        Dim row As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If row.Rows.Count > 0 Then

            rcd_list.Clear()

            Dim i As Integer
            Dim count As Integer = row.Rows.Count - 1

            For i = 0 To count
                rcd_list.Add(New rcd_sales_order)

                '# get stock gudang
                Db.FlushCache()
                Db.Selects("*")
                Db.From("tbl_persediaan_gudang")
                Db.Where("kode_barangjadi", row.Rows(i).Item("kode_barangjadi"))

                Dim stok As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                If stok.Rows.Count > 0 Then
                    rcd_list.Item(i).stok = stok.Rows(0).Item("stok")
                End If

                '# get harga barang
                Db.FlushCache()
                Db.Selects("kode_hargajual, kode_template_harga, harga")
                Db.From("tbl_hargajual")
                Db.Where("kode_barangjadi", row.Rows(i).Item("kode_barangjadi"))
                Db.Where("kode_template_harga", kode_customer_parent.GetColumnValue("kode_template_harga"))

                Dim harga As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                rcd_list.Item(i).kode_hargajual = harga.Rows(0).Item("kode_hargajual")
                rcd_list.Item(i).harga = harga.Rows(0).Item("harga")

                '# insert item
                rcd_list.Item(i).kode_barangjadi = row.Rows(i).Item("kode_barangjadi")
                rcd_list.Item(i).nama = row.Rows(i).Item("nama_barangjadi")
                rcd_list.Item(i).qty = row.Rows(i).Item("qty")

            Next


            rcd_list.Add(New rcd_sales_order)
            Call reIndex()
        Else
            MsgBox("Tidak terdapat rencana distribusi pada tanggal " & tgl_rinciandist.Text, MsgBoxStyle.Exclamation)
        End If

    End Sub
End Class