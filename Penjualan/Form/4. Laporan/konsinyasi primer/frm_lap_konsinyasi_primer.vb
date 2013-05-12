Public Class frm_lap_konsinyasi_primer 

    Sub initComponent()

        tgl_dari.DateTime = DateAdd(DateInterval.Month, -3, Now)
        tgl_sampai.DateTime = Now
        Load_CustomerParent(kode_customer_parent, 1)

        Load_Provinsi(kode_provinsi)
        Load_Kota(kode_kota)
        Load_Grup(kode_group)

    End Sub

    '#------------------------- Tujuan
    Private Sub kode_provinsi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_provinsi.EditValueChanged
        Load_Kota(kode_kota, getValueFromLookup(kode_provinsi))
    End Sub

    Private Sub rdo_tujuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_tujuan.SelectedIndexChanged
        Select Case rdo_tujuan.EditValue
            Case 0
                kode_provinsi.Enabled = False
                kode_kota.Enabled = False
                kode_group.Enabled = False
                kode_customer_parent.Enabled = False
            Case 1
                kode_provinsi.Enabled = True
                kode_kota.Enabled = True
                kode_group.Enabled = True
                kode_customer_parent.Enabled = False
            Case 2
                kode_provinsi.Enabled = False
                kode_kota.Enabled = False
                kode_group.Enabled = False
                kode_customer_parent.Enabled = True
        End Select

    End Sub
    '#-------------------------------- end tujuan

    Sub LoadData()

        Db.FlushCache()
        Db.Selects("a.tgl_terbit, a.no_penjualan, a.kode_customer_parent, b.nama AS nama_customer, a.total_qty, a.total_bruto, a.total_margin, a.total_acara, a.total_toko, a.total_netto")
        Db.From("tbl_konsinyasiprimer a")
        Db.Join("tbl_customer_parent b", "b.kode_customer_parent = a.kode_customer_parent")
        Db.Join("tbl_kota d", "d.kode_kota = b.kode_kota")
        Db.Join("tbl_grup e", "e.kode_grup = b.kode_grup")

        Db.Where_BetweenDate("a.tgl_terbit", tgl_dari.DateTime, tgl_sampai.DateTime)

        If rdo_tujuan.EditValue = 1 Then
            If Not getValueFromLookup(kode_provinsi) = "-1" Then
                Db.Where("d.kode_provinsi", getValueFromLookup(kode_provinsi))
            End If

            If Not getValueFromLookup(kode_kota) = "-1" Then
                Db.Where("b.kode_kota", getValueFromLookup(kode_kota))
            End If

            If Not getValueFromLookup(kode_group) = "-1" Then
                Db.Where("b.kode_grup", getValueFromLookup(kode_group))
            End If
        ElseIf rdo_tujuan.EditValue = 2 Then
            If Not getValueFromLookup(kode_customer_parent) = "-1" Then
                Db.Where("a.kode_customer_parent", getValueFromLookup(kode_customer_parent))
            End If
        End If

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        'format
        GridView1.Columns("tgl_terbit").Caption = "Tanggal"
        GridView1.Columns("no_penjualan").Caption = "No. Penjualan"
        GridView1.Columns("kode_customer_parent").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("total_qty").Caption = "Total Qty"
        GridView1.Columns("total_bruto").Caption = "Bruto"
        GridView1.Columns("total_margin").Caption = "Margin"
        GridView1.Columns("total_acara").Caption = "Acara"
        GridView1.Columns("total_toko").Caption = "Toko"
        GridView1.Columns("total_netto").Caption = "Netto"

        GridView1.Columns("tgl_terbit").Width = 85
        GridView1.Columns("no_penjualan").Width = 95
        GridView1.Columns("kode_customer_parent").Width = 125
        GridView1.Columns("nama_customer").Width = 170
        GridView1.Columns("total_qty").Width = 65
        GridView1.Columns("total_bruto").Width = 80
        GridView1.Columns("total_margin").Width = 80
        GridView1.Columns("total_acara").Width = 80
        GridView1.Columns("total_toko").Width = 80
        GridView1.Columns("total_netto").Width = 80

        FormatColumnNumeric(GridView1.Columns("total_qty"))
        FormatColumnNumeric(GridView1.Columns("total_bruto"))
        FormatColumnNumeric(GridView1.Columns("total_margin"))
        FormatColumnNumeric(GridView1.Columns("total_acara"))
        FormatColumnNumeric(GridView1.Columns("total_toko"))
        FormatColumnNumeric(GridView1.Columns("total_netto"))

        CreateColumnSummary(GridView1.Columns("total_qty"))
        CreateColumnSummary(GridView1.Columns("total_bruto"))
        CreateColumnSummary(GridView1.Columns("total_margin"))
        CreateColumnSummary(GridView1.Columns("total_acara"))
        CreateColumnSummary(GridView1.Columns("total_toko"))
        CreateColumnSummary(GridView1.Columns("total_netto"))

    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call Me.LoadData()
    End Sub

    Private Sub cmd_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        With SaveFileDialog1
            .Filter = "Exel File 2007 (*.Xlsx)|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(.FileName)
            End If
        End With
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        
        '# Create Header
        Dim StrHeader As String = PrintableComponentLink1.RtfReportHeader
        StrHeader = StrHeader.Replace("$tanggal", tgl_dari.DateTime.ToString("yyyy/MM/dd") & " - " & tgl_sampai.DateTime.ToString("yyyy/MM/dd"))
        ' set header and create document print
        PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = True
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
        PrintableComponentLink1.CreateDocument()
        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Laporan Konsinyasi Primer"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub

    Private Sub frm_lap_konsinyasi_primer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.initComponent()
    End Sub

End Class