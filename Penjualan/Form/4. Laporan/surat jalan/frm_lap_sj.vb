Public Class frm_lap_sj 

    Sub initComponent()

        tgl_dari.DateTime = DateAdd(DateInterval.Month, -3, Now)
        tgl_sampai.DateTime = Now
        Load_CustomerParent(kode_customer_parent, sistem_jual.EditValue)

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

    Private Sub sistem_jual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sistem_jual.SelectedIndexChanged
        Load_CustomerParent(kode_customer_parent, sistem_jual.EditValue)
    End Sub

    Private Sub frm_lap_sj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub LoadData()

        Db.FlushCache()
        Db.Selects("a.tgl_surat, a.no_surat, a.no_do, c.kode_customer_child, d.nama AS nama_customer, SUM(b.qty) AS qty, SUM(b.total) AS total")
        Db.From("tbl_suratjalan a")
        Db.Join("tbl_suratjalan_detail b", "b.no_surat = a.no_surat")
        Db.Join("tbl_customer_child c", "c.kode_customer_child = a.kode_customer_child")
        Db.Join("tbl_customer_parent d", "d.kode_customer_parent = c.kode_customer_parent")
        Db.Join("tbl_kota e", "e.kode_kota = d.kode_kota")
        Db.Join("tbl_grup f", "f.kode_grup = d.kode_grup")
        Db.Join("tbl_salesorder g", "g.no_so = a.no_so")

        Db.GroupBy("a.tgl_surat, a.no_surat, a.no_do, c.kode_customer_child, d.nama")

        Db.Where("g.sistem_jual", sistem_jual.EditValue)

        If rdo_tujuan.EditValue = 1 Then
            If Not getValueFromLookup(kode_provinsi) = "-1" Then
                Db.Where("e.kode_provinsi", getValueFromLookup(kode_provinsi))
            End If

            If Not getValueFromLookup(kode_kota) = "-1" Then
                Db.Where("d.kode_kota", getValueFromLookup(kode_kota))
            End If

            If Not getValueFromLookup(kode_group) = "-1" Then
                Db.Where("d.kode_grup", getValueFromLookup(kode_group))
            End If
        ElseIf rdo_tujuan.EditValue = 2 Then
            If Not getValueFromLookup(kode_customer_parent) = "-1" Then
                Db.Where(" AND a.kode_customer_child LIKE '" & getValueFromLookup(kode_customer_parent) & "%'")
            End If
        End If

        Db.Where_BetweenDate("a.tgl_surat", tgl_dari.DateTime, tgl_sampai.DateTime)

        GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        'format
        GridView1.Columns("tgl_surat").Caption = "Tanggal"
        GridView1.Columns("no_surat").Caption = "No Surat Jalan"
        GridView1.Columns("no_do").Caption = "No. DO"
        GridView1.Columns("kode_customer_child").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("qty").Caption = "Qty (Pcs)"
        GridView1.Columns("total").Caption = "Total (Rp.)"

        GridView1.Columns("tgl_surat").Width = 95
        GridView1.Columns("no_surat").Width = 95
        GridView1.Columns("no_do").Width = 95
        GridView1.Columns("kode_customer_child").Width = 115
        GridView1.Columns("nama_customer").Width = 210
        GridView1.Columns("qty").Width = 75
        GridView1.Columns("total").Width = 75


        FormatColumnNumeric(GridView1.Columns("qty"))
        FormatColumnNumeric(GridView1.Columns("total"))

        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("total"))

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
        fc.Text = "Print Laporan Surat Jalan"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub


    Private Sub frm_lap_sj_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.initComponent()
    End Sub
End Class