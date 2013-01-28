Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_memo_pengeluaran

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_memo_pengeluaran)

    Sub initComponent()
        ' inisialisasi componen
        keterangan.Text = vbNullString
        tgl_terbit.DateTime = Now
        no_keluar.EditValue = getNomorUrut(C_KELUAR_BARANG)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_memo_pengeluaran)
        rcd_list.Add(New rcd_memo_pengeluaran)

        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barang").Caption = "Nama Artikel"
        GridView1.Columns("stok").Caption = "Stok (Pcs)"
        GridView1.Columns("qty").Caption = "Qty (pcs)"
        GridView1.Columns("harga_pokok").Caption = "Harga Pokok (Rp.)"

        GridView1.Columns("no").Width = 35
        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("nama_barang").Width = 155
        GridView1.Columns("stok").Width = 65
        GridView1.Columns("qty").Width = 65
        GridView1.Columns("harga_pokok").Width = 100

        ' enable/disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("kode_barangjadi").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("qty").OptionsColumn.AllowEdit = True

        ' forat cell
        FormatColumnNumeric(GridView1.Columns("harga_pokok"))

        
    End Sub

    Sub reIndex()
        Try
            Dim i As Integer
            For i = 0 To rcd_list.Count - 2
                rcd_list.Item(i).no = i + 1
            Next

            GridView1.RefreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_memo_pengeluaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount <= 1 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# cek nomor
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_keluar_barangjadi")
        Db.Where("no_keluar", no_keluar.EditValue)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        If keterangan.Text = vbNullString Then
            MsgBox("Field Keterangan harus diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

       
        '# START TRANSAKSI
        Connection.TRANS_START()

        '# insert to table tbl_keluar_barangjadi
        Db.FlushCache()
        Db.Insert("tbl_keluar_barangjadi")
        Db.SetField("no_keluar", no_keluar.Text)
        Db.SetField("tgl_terbit", tgl_terbit.DateTime)
        Db.SetField("keterangan", keterangan.Text)
        Db.SetField("username", Auth.Username)
        Db.SetField("status", "0")

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 2
            '# insert to table tbl_keluar_barangjadi_detail
            Db.FlushCache()
            Db.Insert("tbl_keluar_barangjadi_detail")
            Db.SetField("no_keluar", no_keluar.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("harga_pokok", rcd_list.Item(i).harga_pokok)

            Connection.TRANS_ADD(Db.GetQueryString)

        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            '# hapus baris new item pada grid
            rcd_list.RemoveAt(rcd_list.Count - 1)

            Dim rpt As New rpt_memo
            rpt.BindingSource1.DataSource = rcd_list
            rpt.lbl_nomor.Text = "Nomor : " & no_keluar.Text
            rpt.lbl_tanggal.Text = tgl_terbit.Text
            rpt.lbl_keterangan.Text = keterangan.Text
            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Memo Pengeluaran Barang"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
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
                        Db.Selects("a.kode_barangjadi, b.nama, b.harga_pokok, a.stok")
                        Db.From("tbl_persediaan_gudang a")
                        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
                        Db.Where(" WHERE a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")

                        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If dt1.Rows.Count > 0 Then
                            rcd_list.Item(row).kode_barangjadi = dt1.Rows(0).Item("kode_barangjadi").ToString
                            rcd_list.Item(row).nama_barang = dt1.Rows(0).Item("nama").ToString
                            rcd_list.Item(row).stok = dt1.Rows(0).Item("stok")
                            rcd_list.Item(row).qty = 0
                            rcd_list.Item(row).harga_pokok = dt1.Rows(0).Item("harga_pokok")

                            '# refres data
                            rcd_list.Add(New rcd_memo_pengeluaran)
                            setFocusCell(GridView1, row, "qty")
                            GridView1.RefreshData()
                            Call Me.reIndex()
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
End Class