Public Class frm_lap_so 

    Sub initComponent()

        tgl_dari.DateTime = DateAdd(DateInterval.Month, -3, Now)
        tgl_sampai.DateTime = Now
        Load_Customer(kode_customer, sistem_jual.EditValue)

    End Sub

    Private Sub chk_all_provinsi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_provinsi.CheckedChanged
        If chk_all_provinsi.Checked = False Then
            Load_Provinsi(kode_provinsi)
        End If
        kode_provinsi.Enabled = Not chk_all_provinsi.Checked
        chk_all_kota.Checked = chk_all_provinsi.Checked
    End Sub

    Private Sub kode_provinsi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_provinsi.EditValueChanged
        Load_Kota(kode_kota, getValueFromLookup(kode_provinsi))
    End Sub

    Private Sub chk_all_kota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_kota.CheckedChanged
        kode_kota.Enabled = Not chk_all_kota.Checked
    End Sub

    Private Sub chk_all_group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_group.CheckedChanged
        If chk_all_group.Checked = False Then
            Load_Grup(kode_group)
        End If
        kode_group.Enabled = Not chk_all_group.Checked
    End Sub

    Private Sub rdo_tujuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_tujuan.SelectedIndexChanged
        Select Case rdo_tujuan.EditValue
            Case 0
                kode_provinsi.Enabled = False
                chk_all_provinsi.Enabled = False
                kode_kota.Enabled = False
                chk_all_kota.Enabled = False
                kode_group.Enabled = False
                chk_all_group.Enabled = False
                kode_customer.Enabled = False
            Case 1
                kode_provinsi.Enabled = Not chk_all_provinsi.Checked
                chk_all_provinsi.Enabled = True
                kode_kota.Enabled = Not chk_all_kota.Checked
                chk_all_kota.Enabled = True
                kode_group.Enabled = Not chk_all_group.Checked
                chk_all_group.Enabled = True
                kode_customer.Enabled = False
            Case 2
                kode_provinsi.Enabled = False
                chk_all_provinsi.Enabled = False
                kode_kota.Enabled = False
                chk_all_kota.Enabled = False
                kode_group.Enabled = False
                chk_all_group.Enabled = False
                kode_customer.Enabled = True
        End Select

    End Sub

    Private Sub frm_lap_so_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    
    Private Sub sistem_jual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sistem_jual.SelectedIndexChanged
        Load_Customer(kode_customer, sistem_jual.EditValue)
    End Sub

    Sub LoadData()

        Db.FlushCache()
        Db.Selects("a.tgl_so, a.no_so, a.kode_customer, b.nama AS nama_customer, d.grup, a.total_qty")
        Db.From("tbl_salesorder a")
        Db.Join("tbl_customer b", "b.kode_customer = a.kode_customer")
        Db.Join("tbl_kota c", "c.kode_kota = b.kode_kota")
        Db.Join("tbl_grup d", "d.kode_grup = b.kode_grup")

        Db.Where("a.sistem_jual", sistem_jual.EditValue)

        If rdo_tujuan.EditValue = 1 Then
            If chk_all_provinsi.Checked = False Then
                Db.Where("c.kode_provinsi", getValueFromLookup(kode_provinsi))
            End If

            If chk_all_kota.Checked = False Then
                Db.Where("b.kode_kota", getValueFromLookup(kode_kota))
            End If

            If chk_all_group.Checked = False Then
                Db.Where("b.kode_grup", getValueFromLookup(kode_group))
            End If
        ElseIf rdo_tujuan.EditValue = 2 Then
            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
        End If

        Db.Where_BetweenDate("a.tgl_so", tgl_dari.DateTime, tgl_sampai.DateTime)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        'format
        GridView1.Columns("tgl_so").Caption = "Tanggal Terbit"
        GridView1.Columns("no_so").Caption = "Nomor SO"
        GridView1.Columns("kode_customer").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("grup").Caption = "Group"
        GridView1.Columns("total_qty").Caption = "Jumlah (Pcs)"

        GridView1.Columns("tgl_so").Width = 90
        GridView1.Columns("no_so").Width = 75
        GridView1.Columns("kode_customer").Width = 100
        GridView1.Columns("nama_customer").Width = 130
        GridView1.Columns("grup").Width = 50
        GridView1.Columns("total_qty").Width = 75

        FormatColumnNumeric(GridView1.Columns("total_qty"))

        CreateColumnSummary(GridView1.Columns("total_qty"))
        
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
        fc.Text = "Print Laporan Sales Order"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub


End Class