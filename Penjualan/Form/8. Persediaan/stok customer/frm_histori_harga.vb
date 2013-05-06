Public Class frm_histori_harga 

    Sub initComponent()
        tgl_dari.DateTime = DateAdd(DateInterval.Month, -3, Now)
        tgl_sampai.DateTime = Now

        'Load_Customer(kode_customer, 1)

    End Sub

    Public Sub loadData()
        Dim i As Integer

        Db.FlushCache()
        Db.Selects("a.kode_customer, b.nama AS nama_customer, a.kode_barangjadi, c.nama AS nama_barangjadi, a.tanggal, a.harga, a.diskon")
        Db.From("tbl_histori_hargacustomer a")
        Db.Join("tbl_customer b", "b.kode_customer = a.kode_customer")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = a.kode_barangjadi")
        Db.Where_BetweenDate("a.tanggal", tgl_dari.DateTime, tgl_sampai.DateTime)

        If chk_semua_customer.Checked = False Then
            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
        End If

        Db.OrderBy("kode_customer", cls_database.sorting.Ascending)
        Db.OrderBy("kode_barangjadi", cls_database.sorting.Ascending)
        Db.OrderBy("tanggal", cls_database.sorting.Ascending)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        '# format grid
        GridView1.Columns("kode_customer").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barangjadi").Caption = "Nama Artikel"
        GridView1.Columns("tanggal").Caption = "Tanggal"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("diskon").Caption = "Diskon (%)"

        GridView1.Columns("kode_customer").Width = 100
        GridView1.Columns("nama_customer").Width = 140
        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("nama_barangjadi").Width = 170
        GridView1.Columns("tanggal").Width = 85
        GridView1.Columns("harga").Width = 75
        GridView1.Columns("diskon").Width = 65

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next

        FormatColumnNumeric(GridView1.Columns("harga"))

        '# Grouping
        GridView1.ClearGrouping()

        If chk_semua_customer.Checked Then
            GridView1.Columns("kode_customer").GroupIndex = 0
            GridView1.Columns("kode_barangjadi").GroupIndex = 1
        Else
            GridView1.Columns("kode_barangjadi").GroupIndex = 0
        End If

        GridView1.ExpandAllGroups()

    End Sub

    Private Sub frm_histori_harga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Call Me.loadData()
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        '# Create Header
        Dim StrHeader As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}}\viewkind4\uc1\pard\qc\f0\fs28 Laporan Harga Jual Customer\b\fs20\par\b0\fs18 Tgl : $tgl_dari-$tgl_sampai\fs20\par\pard\par\par}"
        StrHeader = StrHeader.Replace("$tgl_dari", tgl_dari.Text)
        StrHeader = StrHeader.Replace("$tgl_sampai", tgl_sampai.Text)
        ' set header and create document print 
        PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = False
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
        PrintableComponentLink1.CreateDocument()
        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Harga Jual Customer"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub

    Private Sub chk_semua_customer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_semua_customer.CheckedChanged
        kode_customer.Enabled = Not chk_semua_customer.Checked
    End Sub

    Private Sub cmd_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_add.Click
        formMDI.LoadFormToTab(frm_histori_harga_add)
    End Sub

    Private Sub cmd_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        With SaveFileDialog1
            .Filter = "Exel File 2007 (*.Xlsx)|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(.FileName)
            End If
        End With
    End Sub
End Class