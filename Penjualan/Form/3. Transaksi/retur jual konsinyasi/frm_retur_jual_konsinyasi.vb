Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frm_retur_jual_konsinyasi

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_retur_jual_konsinyasi)

    Sub initComponent()
        'load nomor
        no_retur.Text = getNomorUrut(C_RETUR_JUAL_KONSINYASI)
        tgl_retur.DateTime = Now
        Load_CustomerParent(kode_customer_parent, 1)
        Call CustomerDetail()

        rcd_list = New System.ComponentModel.BindingList(Of rcd_retur_jual_konsinyasi)
        rcd_list.Add(New rcd_retur_jual_konsinyasi)

        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("stok").Caption = "Stok"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("jml_retur").Caption = "Jml Retur"
        GridView1.Columns("total").Caption = "Total (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("no").Width = 45
        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("nama").Width = 120
        GridView1.Columns("stok").Width = 60
        GridView1.Columns("harga").Width = 90
        GridView1.Columns("jml_retur").Width = 75
        GridView1.Columns("total").Width = 90
        GridView1.Columns("keterangan").Width = 250

        FormatColumnNumeric(GridView1.Columns("harga"))
        FormatColumnNumeric(GridView1.Columns("total"))

        ' enable/disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("kode_barangjadi").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("jml_retur").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("keterangan").OptionsColumn.AllowEdit = True

        ' Create summary
        CreateColumnSummary(GridView1.Columns("jml_retur"))
        CreateColumnSummary(GridView1.Columns("total"))

    End Sub

    Sub CustomerDetail()
        Db.FlushCache()
        Db.Selects("a.kode_customer_parent, a.nama, a.alamat, b.kota, a.mall")
        Db.From("tbl_customer_parent a")
        Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
        Db.Where("a.kode_customer_parent", getValueFromLookup(kode_customer_parent))
        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rcd.HasRows Then
            rcd.Read()
            lbl_nama.Text = rcd.Item("nama").ToString
            lbl_alamat.Text = rcd.Item("alamat").ToString
            lbl_mall.Text = rcd.Item("mall").ToString
            lbl_kota.Text = rcd.Item("kota").ToString
        End If
    End Sub

    Public Sub reIndex()
        Try

            Dim i As Integer = 1
            For i = 1 To rcd_list.Count
                rcd_list.Item(i - 1).no = i
            Next

            rcd_list.Item(rcd_list.Count - 1).no = 0

            If rcd_list.Count > 1 Then
                tgl_retur.Properties.ReadOnly = True
                kode_customer_parent.Properties.ReadOnly = True
                cmb_tipecustomer.Properties.ReadOnly = True
            Else
                tgl_retur.Properties.ReadOnly = False
                kode_customer_parent.Properties.ReadOnly = False
                cmb_tipecustomer.Properties.ReadOnly = False
            End If

            GridView1.RefreshData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_retur_jual_konsinyasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
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

    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer_parent.EditValueChanged
        Call Me.CustomerDetail()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_RETUR_JUAL_KONSINYASI
        frm_transaksi_popup_artkel.kode_customer_child = getValueFromLookup(kode_customer_parent) & "." & (cmb_tipecustomer.SelectedIndex + 1)
        frm_transaksi_popup_artkel.ShowDialog(Me)
        Call Me.reIndex()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer
        Dim query As String

        'Cek Grid
        If rcd_list.Count <= 1 Then
            MsgBox("Isi data yang akan diretur!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        For i = 0 To rcd_list.Count - 2
            If rcd_list.Item(i).jml_retur <= 0 Then
                MsgBox("Jumlah Retur tidak boleh Nol!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        Connection.TRANS_START()

        Dim vkode_customer_child As String = getValueFromLookup(kode_customer_parent) & "." & (cmb_tipecustomer.SelectedIndex + 1)

        '# insert to table tbl_retur_konsinyasi
        Db.FlushCache()
        Db.Insert("tbl_retur_konsinyasi")
        Db.SetField("no_retur", no_retur.Text)
        Db.SetField("tgl_retur", tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("kode_customer_child", vkode_customer_child)
        Db.SetField("total_qty", GridView1.Columns("jml_retur").Summary(0).SummaryValue)
        Db.SetField("total", GridView1.Columns("total").Summary(0).SummaryValue)
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 2
            '# insert to table tbl_retur_konsinyasi_detail
            Db.FlushCache()
            Db.Insert("tbl_retur_konsinyasi_detail")
            Db.SetField("no_retur", no_retur.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).jml_retur)
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.SetField("total", rcd_list.Item(i).total)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# mengurangi stok customer
            query = ""
            query &= " UPDATE tbl_persediaan_customer "
            query &= " SET stok_sekunder = stok_sekunder - " & rcd_list.Item(i).jml_retur & ", stok_primer = stok_primer - " & rcd_list.Item(i).jml_retur & " "
            query &= " WHERE kode_customer_child = '" & vkode_customer_child & "' AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'"
            Connection.TRANS_ADD(query)

            '# menambah stok gudang
            query = ""
            query &= " UPDATE tbl_persediaan_gudang "
            query &= " SET stok = stok + " & rcd_list.Item(i).jml_retur & " "
            query &= " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'"
            Connection.TRANS_ADD(query)

            '# insert ke kartu stok
            Db.FlushCache()
            Db.Insert("tbl_kartustok_gudang")
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("tanggal", tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Db.SetField("referensi", "No. Retur : " & no_retur.Text)
            Db.SetField("deskripsi", "Retur dari " & lbl_nama.Text)
            Db.SetField("masuk", rcd_list.Item(i).jml_retur)
            Db.SetField("keluar", "0")
            Connection.TRANS_ADD(Db.GetQueryString)

        Next


        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            'Dim rpt As New rpt_retur_penerimaanbarang
            'rpt.BindingSource1.DataSource = rcd_list
            'rpt.nomor_retur.Text = "Nomor : " & nomor_retur.Text
            'rpt.tanggal.Text = tanggal.DateTime.ToString("dd/MM/yyy")
            'rpt.lbl_nama_supplier.Text = lbl_nama_supplier.Text
            'rpt.nomor_terima.Text = nomor_terima.Text
            'rpt.lbl_tanggal_terima.Text = lbl_tanggal_terima.Text
            'rpt.CreateDocument()

            'Dim fc As New FormReportControl
            'fc.Text = "Print Bukti Retur Barang"
            'fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            'fc.Height = 600
            'fc.ShowDialog(Me)

            Call initComponent()
            Call reIndex()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation) ' transaksi gagal dan secara otomatis akan di rollback
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
                    If tmp_kode_barangjadi.Length < 7 Then
                        MsgBox("Masukan kode dengan benar!", MsgBoxStyle.Exclamation)
                    Else
                        tmp_kode_barangjadi = tmp_kode_barangjadi.Substring(0, 2) & "." & tmp_kode_barangjadi.Substring(2, 3) & "." & tmp_kode_barangjadi.Substring(5, 2)

                        Dim vKode_customer_child As String = getValueFromLookup(kode_customer_parent) & "." & (cmb_tipecustomer.SelectedIndex + 1)

                        '# get barang jadi
                        Db.FlushCache()
                        Db.Selects("a.kode_barangjadi, b.nama, a.stok_sekunder as stok")
                        Db.From("tbl_persediaan_customer a")
                        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
                        Db.Where("a.kode_customer_child", vKode_customer_child)
                        Db.Where(" AND a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")
                        Dim dt1 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If dt1.Rows.Count > 0 Then

                            '# cek list, takut ada yg sama (^-^)
                            For i = 0 To rcd_list.Count - 1
                                If rcd_list.Item(i).kode_barangjadi = dt1.Rows(0).Item("kode_barangjadi") Then
                                    MsgBox("Kode Atikel : " & dt1.Rows(0).Item("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                                    Exit Sub
                                End If
                            Next

                            '# insert to list
                            rcd_list.Item(rowItemNew).kode_barangjadi = dt1.Rows(0).Item("kode_barangjadi")
                            rcd_list.Item(rowItemNew).nama = dt1.Rows(0).Item("nama")
                            rcd_list.Item(rowItemNew).stok = dt1.Rows(0).Item("stok")

                            '# ambil harga yg ditetapkan
                            Db.FlushCache()
                            Db.Selects("TOP 1 a.harga, a.diskon")
                            Db.From("tbl_histori_hargacustomer a")
                            Db.Where("a.kode_barangjadi", dt1.Rows(0).Item("kode_barangjadi"))
                            Db.Where("a.kode_customer_child", vKode_customer_child)
                            Db.Where("a.tanggal", tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
                            Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

                            Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
                            If rc.HasRows Then
                                rc.Read()
                                rcd_list.Item(rowItemNew).harga = rc.Item("harga").ToString
                            Else
                                rcd_list.Item(rowItemNew).harga = 0
                            End If

                            '# refres data
                            rcd_list.Add(New rcd_retur_jual_konsinyasi)
                            Call Me.reIndex()
                            setFocusCell(GridView1, row, "jml_retur")
                            GridView1.RefreshData()
                        Else
                            MsgBox("Tidak terdapat kode barang '" & tmp_kode_barangjadi & "'", MsgBoxStyle.Exclamation)
                        End If
                    End If

                Case "jml_retur"
                    If row < rowItemNew Then
                        setFocusCell(GridView1, row + 1, "kode_barangjadi")
                    End If
            End Select
        End If
    End Sub


End Class