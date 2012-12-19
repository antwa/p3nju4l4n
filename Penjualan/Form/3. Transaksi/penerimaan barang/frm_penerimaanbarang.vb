Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_penerimaanbarang

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_penerimaanbarang)

    Sub initComponent()
        ' inisialisasi componen

        nomor_terima.EditValue = getNomorUrut(C_PENERIMAAN_BARANG)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_penerimaanbarang)
        rcd_list.Add(New rcd_penerimaanbarang)

        GridControl1.DataSource = rcd_list
        GridView1.Columns.Item(0).Caption = "Kode Artikel"
        GridView1.Columns.Item(1).Caption = "Nama Artikel"
        GridView1.Columns.Item(2).Caption = "Qty (Pcs)"
        GridView1.Columns.Item(3).Caption = "Keterangan"

        GridView1.Columns.Item(0).Width = 100
        GridView1.Columns.Item(1).Width = 200
        GridView1.Columns.Item(3).Width = 300

        GridView1.Columns.Item(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.Item(2).DisplayFormat.FormatString = "#,##0"

        tanggal.DateTime = Now
        Load_SupplierBarang(kode_supplier_barang)
        no_suratjalan.EditValue = vbNullString

    End Sub

    Private Sub frm_penerimaanbarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Dim rowNewItem As Integer = rcd_list.Count - 1
        Try
            If row <> rowNewItem Then
                rcd_list.RemoveAt(row)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_PENERIMAAN_BARANG
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim vkode_supplier As String = kode_supplier_barang.Properties.GetKeyValueByDisplayText(kode_supplier_barang.Text)
        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount <= 1 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# cek nomor
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_penerimaanbarang")
        Db.Where("nomor_terima", nomor_terima.EditValue)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# validation
        Validation.clearRules()
        Validation.addRules(no_suratjalan.Text, "No. Surat Jalan", "required")

        If Validation.isValid Then
            '# START TRANSAKSI
            Connection.TRANS_START()

            '# insert to table tbl_penerimaanbarang
            Db.FlushCache()
            Db.Insert("tbl_penerimaanbarang")
            Db.SetField("nomor_terima", nomor_terima.EditValue)
            Db.SetField("tanggal", tanggal.DateTime)
            Db.SetField("kode_supplier_barang", vkode_supplier)
            Db.SetField("no_suratjalan", no_suratjalan.EditValue)
            Db.SetField("username", Auth.Username)

            Connection.TRANS_ADD(Db.GetQueryString)

            For i = 0 To rcd_list.Count - 2
                '# insert to table tbl_penerimaanbarang_detail
                Db.FlushCache()
                Db.Insert("tbl_penerimaanbarang_detail")
                Db.SetField("nomor_terima", nomor_terima.EditValue)
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("qty", rcd_list.Item(i).qty)
                Db.SetField("ketarangan", rcd_list.Item(i).keterangan)

                Connection.TRANS_ADD(Db.GetQueryString)

                '# update persediaan gudang
                Db.Query(" UPDATE tbl_persediaan_gudang set stok = stok + " & rcd_list.Item(i).qty & _
                         " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'")
                Connection.TRANS_ADD(Db.GetQueryString)

                '# insert ke kartu stok
                Db.FlushCache()
                Db.Insert("tbl_kartustok_gudang")
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("tanggal", tanggal.DateTime)
                Db.SetField("referensi", "No. Terima : " & nomor_terima.EditValue)
                Db.SetField("deskripsi", "Terima dari " & getValueFromLookup(kode_supplier_barang))
                Db.SetField("masuk", rcd_list.Item(i).qty)
                Db.SetField("keluar", "0")
                Connection.TRANS_ADD(Db.GetQueryString)

            Next

            '# COMMITE TRANSAKSI
            If Connection.TRANS_SUCCESS Then
                'MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")

                '# delete row new item
                rcd_list.RemoveAt(rcd_list.Count - 1)

                Dim rpt As New rpt_penerimaanbarang
                rpt.BindingSource1.DataSource = rcd_list
                rpt.nomor_terima.Text = "Nomor : " & nomor_terima.Text
                rpt.tanggal.Text = tanggal.DateTime.ToString("dd/MM/yyy")
                rpt.kode_supplier_barang.Text = kode_supplier_barang.Text
                rpt.no_suratjalan.Text = no_suratjalan.Text
                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Bukti Penerimaan Barang"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.Height = 600
                fc.ShowDialog(Me)

                Call initComponent()
            Else
                MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
            End If

        Else
            Validation.showMessage()
        End If

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
            Select Case view.FocusedColumn.FieldName
                Case "kode_barangjadi"
                    Dim tmp_kode_barangjadi As String = rcd_list.Item(row).kode_barangjadi
                    tmp_kode_barangjadi = tmp_kode_barangjadi.Replace(".", vbNullString)
                    If tmp_kode_barangjadi.Length < 6 Then
                        MsgBox("Masukan kode dengan benar!", MsgBoxStyle.Exclamation)
                    Else
                        tmp_kode_barangjadi = tmp_kode_barangjadi.Substring(0, 1) & "." & tmp_kode_barangjadi.Substring(1, 3) & "." & tmp_kode_barangjadi.Substring(4, 2)

                        '# get barang jadi
                        Db.FlushCache()
                        Db.Selects("a.kode_barangjadi, a.nama")
                        Db.From("tbl_barangjadi a")
                        Db.Where(" WHERE a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")

                        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If dt1.Rows.Count > 0 Then
                            rcd_list.Item(row).kode_barangjadi = dt1.Rows(0).Item("kode_barangjadi").ToString
                            rcd_list.Item(row).nama = dt1.Rows(0).Item("nama").ToString

                            '# refres data
                            rcd_list.Add(New rcd_penerimaanbarang)
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


End Class