Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_stok_customer

    Public rcd_list As New System.ComponentModel.BindingList(Of rcd_stok_customer)

    Sub initComponent()
        Load_CustomerParent(kode_customer_parent, 1)

        stok.Properties.Items.Add("Semua Stok")
        stok.Properties.Items.Add("Stok Kosong")
        stok.Properties.Items.Add("Stok Lebih Dari Nol")
        stok.SelectedIndex = 0

        GridControl1.DataSource = rcd_list

        'GridView1.Columns("id").Caption = ""
        GridView1.Columns("kode_customer").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barangjadi").Caption = "Nama Artikel"
        GridView1.Columns("stok_sekunder").Caption = "Stok (S)"
        GridView1.Columns("stok_primier").Caption = "Stok (P)"
        GridView1.Columns("kode_jenis_barang").Visible = False

        GridView1.Columns("id").Width = 29
        GridView1.Columns("kode_customer").Width = 90
        GridView1.Columns("nama_customer").Width = 110
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("nama_barangjadi").Width = 125
        GridView1.Columns("stok_sekunder").Width = 65
        GridView1.Columns("stok_primier").Width = 65
        'GridView1.Columns("kode_jenis_barang").Width = 225

        ' Allow Edit
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        'GridView1.Columns.Item("kode_jenis_barang").OptionsColumn.AllowEdit = True

        ' visible
        GridView1.Columns("id").Visible = False

        ' repositori grid
        'Dim jenis_harga As New RepositoryItemRadioGroup
        'Dim rc As DataTable = Connection.ExecuteToDataTable("SELECT * FROM tbl_jenis_hargabarang ORDER BY kode_jenis_harga ASC")
        'If rc.Rows.Count > 0 Then
        '    For i = 0 To rc.Rows.Count - 1
        '        jenis_harga.Items.Add(New RadioGroupItem(rc.Rows(i).Item("kode_jenis_harga"), rc.Rows(i).Item("jenis").ToString))
        '    Next
        'End If
        'GridView1.Columns.Item("kode_jenis_barang").ColumnEdit = jenis_harga
        'GridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways


    End Sub

    Public Sub LoadData()
        rcd_list.Clear()

        Db.FlushCache()
        Db.Selects("a.id, a.kode_customer_child, c.nama AS nama_customer, a.kode_barangjadi, d.nama AS nama_barangjadi, a.stok_sekunder, a.stok_primer")
        Db.From("tbl_persediaan_customer a")
        Db.Join("tbl_customer_child b", "b.kode_customer_child = a.kode_customer_child")
        Db.Join("tbl_customer_parent c", "c.kode_customer_parent = b.kode_customer_parent")
        Db.Join("tbl_barangjadi d", "d.kode_barangjadi = a.kode_barangjadi")

        Db.OrderBy("a.kode_customer_child", cls_database.sorting.Ascending)
        Db.OrderBy("a.kode_barangjadi", cls_database.sorting.Ascending)


        If chk_semua_customer.Checked = False Then
            If cmb_tipecustomer.SelectedIndex = 0 Then
                Db.Where(" WHERE a.kode_customer_child LIKE '" & getValueFromLookup(kode_customer_parent) & "%'")
            Else
                Db.Where("a.kode_customer_child", getValueFromLookup(kode_customer_parent) & "." & cmb_tipecustomer.SelectedIndex)
            End If
        Else
            If Not cmb_tipecustomer.SelectedIndex = 0 Then
                Db.Where(" WHERE a.kode_customer_child LIKE '%." & cmb_tipecustomer.SelectedIndex & "'")
            End If
        End If

        If kode_barangjadi.Text <> "" = False Then
            Db.Where("a.kode_barangjadi", kode_barangjadi.Text)
        End If

        If stok.SelectedIndex = 1 Then
            Db.Where("a.stok_sekunder", "0", "<=")
            Db.Where("a.stok_primer", "0", "<=", "OR")
        ElseIf stok.SelectedIndex = 2 Then
            Db.Where("a.stok_sekunder", "0", ">")
            Db.Where("a.stok_primer", "0", ">", "OR")
        End If

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        If dt.Rows.Count > 0 Then
            Dim i As Integer
            Dim x As Integer = dt.Rows.Count - 1
            For i = 0 To x
                rcd_list.Add(New rcd_stok_customer(dt.Rows(i).Item("id").ToString, dt.Rows(i).Item("kode_customer_child").ToString, dt.Rows(i).Item("nama_customer").ToString, dt.Rows(i).Item("kode_barangjadi").ToString, dt.Rows(i).Item("nama_barangjadi").ToString, dt.Rows(i).Item("stok_sekunder").ToString, dt.Rows(i).Item("stok_primer").ToString, 0))
            Next
        End If

        ' Grouping
        GridView1.ClearGrouping()
        'If chk_semua_customer.Checked Then
        '    GridView1.Columns("a.kode_customer_child").GroupIndex = 0
        'End If

        GridView1.ExpandAllGroups()
    End Sub

    Private Sub frm_stok_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call LoadData()
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        '# Create Header
        'Dim StrHeader As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}}\viewkind4\uc1\pard\qc\b\f0\fs24 KARTU STOK BARANG JADI\par\b0\fs20 $tgl_print\par\parKode Artikel : \b $kode_barangjadi\b0    ($tgl_dari - $tgl_sampai)\par\par}"
        'StrHeader = StrHeader.Replace("$tgl_print", Now)
        'StrHeader = StrHeader.Replace("$kode_barangjadi", kode_barangjadi.Text)
        'StrHeader = StrHeader.Replace("$tgl_dari", tgl_dari.Text)
        'StrHeader = StrHeader.Replace("$tgl_sampai", tgl_sampai.Text)
        '' set header and create document print
        'PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = False
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
        PrintableComponentLink1.CreateDocument()
        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Stok Customer"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub

    Private Sub cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_GETARTIKEL
        frm_transaksi_popup_artkel.txt_artikel = kode_barangjadi
        frm_transaksi_popup_artkel.lbl_nama_artikel = lbl_nama_artikel
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub chk_semua_artikel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'kode_barangjadi.Enabled = Not chk_semua_artikel.Checked
        'cmd_cari.Enabled = Not chk_semua_artikel.Checked
    End Sub

    Private Sub chk_semua_customer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_semua_customer.CheckedChanged
        kode_customer_parent.Enabled = Not chk_semua_customer.Checked
    End Sub

    'Private Sub cmd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
    '    cmd_simpan.Enabled = True
    '    cmd_edit.Enabled = False
    '    GridView1.OptionsBehavior.Editable = True
    'End Sub

    'Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
    '    cmd_simpan.Enabled = False
    '    cmd_edit.Enabled = True
    '    GridView1.OptionsBehavior.Editable = False

    '    Connection.TRANS_START()

    '    Dim i As Integer
    '    For i = 0 To rcd_list.Count - 1
    '        Db.FlushCache()
    '        Db.Update("tbl_persediaan_customer")
    '        Db.SetField("kode_jenis_harga", rcd_list.Item(i).kode_jenis_barang)
    '        Db.Where("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
    '        Db.Where("kode_customer", rcd_list.Item(i).kode_customer)

    '        Connection.TRANS_ADD(Db.GetQueryString)
    '    Next

    '    If Connection.TRANS_SUCCESS Then
    '        Call Me.LoadData()
    '        MsgBox("Data Berhasil disimpan", MsgBoxStyle.Information)
    '    Else
    '        MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation, "Error")
    '    End If

    'End Sub

    Private Sub cmd_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_excel.Click
        With SaveFileDialog1
            .Filter = "Exel File 2007 (*.Xlsx)|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(.FileName)
            End If
        End With
    End Sub
End Class