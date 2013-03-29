Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_retur_formalitas

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_retur_formalitas)

    Public Sub reIndex()

        For i = 1 To rcd_list.Count
            rcd_list.Item(i - 1).no = i
        Next
        rcd_list.Item(rcd_list.Count - 1).no = 0

        If rcd_list.Count > 1 Then
            kode_customer_parent.Properties.ReadOnly = True
            sumber.Properties.ReadOnly = True
            'tujuan.Properties.ReadOnly = True
        Else
            kode_customer_parent.Properties.ReadOnly = False
            sumber.Properties.ReadOnly = False
            'tujuan.Properties.ReadOnly = False
        End If

        GridView1.RefreshData()
    End Sub

    Sub initComponent()
        ' inisialisasi componen
        no_retur.EditValue = getNomorUrut(C_RETUR_FORMALITAS)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_retur_formalitas)
        rcd_list.Add(New rcd_retur_formalitas)

        Call Me.reIndex()

        GridControl1.DataSource = rcd_list

        ' format grid
        GridView1.Columns("no").Caption = "No"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barangjadi").Caption = "Nama Artikel"
        GridView1.Columns("stok").Caption = "Stok"
        GridView1.Columns("jml_retur").Caption = "Jml Retur"
        GridView1.Columns("sisa").Caption = "Sisa"

        GridView1.Columns("no").Width = 35
        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("nama_barangjadi").Width = 160
        GridView1.Columns("stok").Width = 40
        GridView1.Columns("jml_retur").Width = 70
        GridView1.Columns("sisa").Width = 40

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns("kode_barangjadi").OptionsColumn.AllowEdit = True
        GridView1.Columns("jml_retur").OptionsColumn.AllowEdit = True

        CreateColumnSummary(GridView1.Columns("jml_retur"))

        tgl_retur.DateTime = Now
        Load_CustomerParent(kode_customer_parent, 1)

    End Sub

    Private Sub frm_retur_formalitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Dim rowNewItem As Integer = rcd_list.Count - 1
        Try
            If row <> rowNewItem Then
                rcd_list.RemoveAt(row)
                Call reIndex()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_RETUR_FORMALITAS
        frm_transaksi_popup_artkel.kode_customer_child = getValueFromLookup(kode_customer_parent) & "." & (sumber.SelectedIndex + 1)
        frm_transaksi_popup_artkel.ShowDialog(Me)
        Call reIndex()
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

                        Dim vkode_customer_child As String = getValueFromLookup(kode_customer_parent) & "." & (sumber.SelectedIndex + 1)

                        '# Get barangjadi from tbl_persediaan_customer
                        Db.FlushCache()
                        Db.Selects("a.kode_barangjadi, b.nama AS nama_barangjadi, a.stok_sekunder")
                        Db.From("tbl_persediaan_customer a")
                        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
                        Db.Where("a.kode_customer_child", vkode_customer_child)
                        Db.Where(" AND a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")

                        Dim res As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                        If res.Rows.Count > 0 Then

                            Dim CountRcd As Integer = rcd_list.Count - 1
                            Dim xKode_barangjadi As String = res.Rows(0).Item("kode_barangjadi")

                            '# cek list, takut ada yg sama (^-^)
                            For i = 0 To CountRcd
                                If rcd_list.Item(i).kode_barangjadi = xKode_barangjadi Then
                                    MsgBox("Kode Atikel : " & xKode_barangjadi & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                                    Exit Sub
                                End If
                            Next

                            rcd_list.Item(row).kode_barangjadi = xKode_barangjadi
                            rcd_list.Item(row).nama_barangjadi = res.Rows(0).Item("nama_barangjadi")
                            rcd_list.Item(row).stok = res.Rows(0).Item("stok_sekunder")
                            rcd_list.Item(row).jml_retur = 0

                            '# refres data
                            rcd_list.Add(New rcd_retur_formalitas)
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

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        '# Cek Grid
        If GridView1.RowCount <= 1 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        For i = 0 To rcd_list.Count - 2
            If rcd_list.Item(i).jml_retur = 0 Then
                MsgBox("Jml Retur barang tidak boleh Nol", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        If sumber.SelectedIndex = tujuan.SelectedIndex Then
            MsgBox("Retur sumber tidak boleh sama dengan tujuan!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim vkode_customer_child_sumber As String = getValueFromLookup(kode_customer_parent) & "." & (sumber.SelectedIndex + 1)
        Dim vkode_customer_child_tujuan As String = getValueFromLookup(kode_customer_parent) & "." & (tujuan.SelectedIndex + 1)
        Dim Query As String = ""

        Connection.TRANS_START()

        '# insert to table tbl_retur_formalitas
        Db.FlushCache()
        Db.Insert("tbl_retur_formalitas")
        Db.SetField("no_retur", no_retur.Text)
        Db.SetField("tgl_retur", tgl_retur.DateTime)
        Db.SetField("kode_customer_parent", getValueFromLookup(kode_customer_parent))
        Db.SetField("sumber", (sumber.SelectedIndex + 1))
        Db.SetField("tujuan", (tujuan.SelectedIndex + 1))
        Db.SetField("total_qty", GridView1.Columns.Item("jml_retur").Summary.Item(0).SummaryValue)
        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 2

            '# insert to table tbl_retur_formalitas_detail
            Db.FlushCache()
            Db.Insert("tbl_retur_formalitas_detail")
            Db.SetField("no_retur", no_retur.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).jml_retur)
            Connection.TRANS_ADD(Db.GetQueryString)


            '# update stok sumber
            Query = ""
            Query &= " UPDATE tbl_persediaan_customer "
            Query &= " SET stok_sekunder = stok_sekunder - " & rcd_list(i).jml_retur & ", "
            Query &= "     stok_primer = stok_primer - " & rcd_list(i).jml_retur & " "
            Query &= " WHERE kode_barangjadi = '" & rcd_list(i).kode_barangjadi & "' "
            Query &= " AND   kode_customer_child = '" & vkode_customer_child_sumber & "' "
            Connection.TRANS_ADD(Query)
            'MsgBox(Query)
            '# insert ato update tujuan
            Query = ""
            Query &= " IF EXISTS (SELECT * FROM tbl_persediaan_customer WHERE kode_customer_child = '" & vkode_customer_child_tujuan & "' AND kode_barangjadi = '" & rcd_list(i).kode_barangjadi & "') "
            Query &= "    UPDATE tbl_persediaan_customer "
            Query &= "    SET stok_sekunder = stok_sekunder + " & rcd_list(i).jml_retur & ", "
            Query &= "        stok_primer = stok_primer + " & rcd_list(i).jml_retur & "  "
            Query &= "    WHERE kode_customer_child = '" & vkode_customer_child_tujuan & "' AND kode_barangjadi = '" & rcd_list(i).kode_barangjadi & "' "
            Query &= " ELSE "
            Query &= "   BEGIN "
            Query &= "    INSERT INTO tbl_persediaan_customer (kode_customer_child, kode_barangjadi, stok_sekunder, stok_primer) "
            Query &= "    VALUES ('" & vkode_customer_child_tujuan & "', '" & rcd_list(i).kode_barangjadi & "', '" & rcd_list(i).jml_retur & "', '" & rcd_list(i).jml_retur & "');"
            Query &= "   END "
            Query &= "; "
            Connection.TRANS_ADD(Query)
            'MsgBox(Query)
            '# insert to histori harga
            '      get histori barang
            Dim data() As String = getHargaFromHistori(tgl_retur.DateTime, _
                                           getValueFromLookup(kode_customer_parent), _
                                           rcd_list(i).kode_barangjadi)
            Query = ""
            Query &= " IF NOT EXISTS (SELECT * FROM tbl_histori_hargacustomer WHERE kode_customer_child = '" & vkode_customer_child_tujuan & "' AND kode_barangjadi = '" & rcd_list(i).kode_barangjadi & "' AND tanggal = '" & tgl_retur.DateTime.ToString("yyyy-MM-dd") & "') "
            Query &= "    INSERT INTO tbl_histori_hargacustomer ([tanggal],[kode_customer_parent],[kode_customer_child],[kelompok],[kode_barangjadi],[harga],[diskon]) "
            Query &= "    VALUES ('" & tgl_retur.DateTime.ToString("yyyy-MM-dd 00:00:00") & "', '" & getValueFromLookup(kode_customer_parent) & "', '" & vkode_customer_child_tujuan & "', '" & (tujuan.SelectedIndex + 1) & "','" & rcd_list(i).kode_barangjadi & "', '" & data(0) & "', '" & data(1) & "'); "
            Query &= "; "
            Connection.TRANS_ADD(Query)
            'MsgBox(Query)
        Next


        If Connection.TRANS_SUCCESS Then
            
            '# print
            rcd_list.RemoveAt(rcd_list.Count - 1)

            Dim rpt As New rpt_retur_formalitas
            rpt.BindingSource1.DataSource = rcd_list
            rpt.lbl_nomor.Text = "Nomor : " & no_retur.Text
            rpt.lbl_tanggal.Text = tgl_retur.Text
            rpt.lbl_customer.Text = kode_customer_parent.Text
            rpt.lbl_keterangan.Text = "Retur Dari " & sumber.Text & " Ke " & tujuan.Text
            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Retur Formalitas"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            Me.initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If


    End Sub



    Private Sub cmd_load_all_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load_all_artikel.Click
        rcd_list.Clear()

        '# Get barangjadi from tbl_persediaan_customer
        Db.FlushCache()
        Db.Selects("a.kode_barangjadi, b.nama AS nama_barangjadi, a.stok_sekunder")
        Db.From("tbl_persediaan_customer a")
        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
        Db.Where(" WHERE a.kode_customer_child LIKE '" & getValueFromLookup(kode_customer_parent) & "%'")
        'Db.Where(" AND a.kode_barangjadi LIKE '" & tmp_kode_barangjadi & "%'")

        Dim res As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If res.Rows.Count > 0 Then
            For i = 0 To res.Rows.Count - 1
                rcd_list.Add(New rcd_retur_formalitas)
                rcd_list.Item(i).kode_barangjadi = res.Rows(i).Item("kode_barangjadi")
                rcd_list.Item(i).nama_barangjadi = res.Rows(i).Item("nama_barangjadi")
                rcd_list.Item(i).stok = res.Rows(i).Item("stok_sekunder")
                rcd_list.Item(i).jml_retur = 0
            Next
            
            '# refres data
            rcd_list.Add(New rcd_retur_formalitas)
            Call Me.reIndex()
            setFocusCell(GridView1, 0, "jml_retur")
            GridView1.RefreshData()
        Else
            rcd_list.Add(New rcd_retur_formalitas)
            MsgBox("Tidak terdapat artikel dalam database!", MsgBoxStyle.Exclamation)
        End If


    End Sub
End Class