Public Class frm_targetpenjualan 

    Dim rcd_percustomer As New DataTable
    Dim rcd_perbulan As New System.ComponentModel.BindingList(Of rcd_targetpenjualan_perbulan)


    Sub initComponent()

        Dim tahun As Integer = CInt(Now.ToString("yyyy")) - 2
        Dim i As Integer

        '@ per customer
        Load_Customer(pc_kode_customer, 1)
        For i = tahun To tahun + 4
            pc_tahun.Properties.Items.Add(i)
        Next
        pc_tahun.EditValue = tahun + 2

        ' load data
        Call loadData_percustomer()


        '@ per bulan
        pb_bulan.Properties.Items.Add("Januari")
        pb_bulan.Properties.Items.Add("Februari")
        pb_bulan.Properties.Items.Add("Maret")
        pb_bulan.Properties.Items.Add("April")
        pb_bulan.Properties.Items.Add("Mei")
        pb_bulan.Properties.Items.Add("Juni")
        pb_bulan.Properties.Items.Add("Juli")
        pb_bulan.Properties.Items.Add("Agustus")
        pb_bulan.Properties.Items.Add("September")
        pb_bulan.Properties.Items.Add("Oktober")
        pb_bulan.Properties.Items.Add("Nopember")
        pb_bulan.Properties.Items.Add("Desember")

        pb_bulan.SelectedIndex = CInt(Now.ToString("MM")) - 1

        'tahun
        For i = tahun To tahun + 4
            pb_tahun.Properties.Items.Add(i)
        Next
        pb_tahun.EditValue = tahun + 2

    End Sub


    Sub loadData_percustomer()

        My.Application.DoEvents()

        ' grid
        rcd_percustomer.Columns.Clear()
        rcd_percustomer.Columns.Add("id", GetType(Integer))
        rcd_percustomer.Columns.Add("no", GetType(Integer))
        rcd_percustomer.Columns.Add("bulan", GetType(String))
        rcd_percustomer.Columns.Add("jml_pcs", GetType(Integer))
        rcd_percustomer.Columns.Add("jml_rupiah", GetType(Integer))
        rcd_percustomer.Columns.Add("keterangan", GetType(String))

        ' clear all item
        rcd_percustomer.Clear()

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_targetpenjualan")
        Db.Where("tahun", pc_tahun.Text)
        Db.Where("kode_customer", getValueFromLookup(pc_kode_customer))
        Db.OrderBy("bulan")

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        Dim i As Integer

        If r.Rows.Count > 0 Then
            rcd_percustomer.Rows.Add(New Object() {r.Rows(0).Item("id"), 1, "Januari", r.Rows(0).Item("jml_pcs"), r.Rows(0).Item("jml_rupiah"), r.Rows(0).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(1).Item("id"), 2, "Pebruari", r.Rows(1).Item("jml_pcs"), r.Rows(1).Item("jml_rupiah"), r.Rows(1).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(2).Item("id"), 3, "Maret", r.Rows(2).Item("jml_pcs"), r.Rows(2).Item("jml_rupiah"), r.Rows(2).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(3).Item("id"), 4, "April", r.Rows(3).Item("jml_pcs"), r.Rows(3).Item("jml_rupiah"), r.Rows(3).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(4).Item("id"), 5, "Mei", r.Rows(4).Item("jml_pcs"), r.Rows(4).Item("jml_rupiah"), r.Rows(4).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(5).Item("id"), 6, "Juni", r.Rows(5).Item("jml_pcs"), r.Rows(5).Item("jml_rupiah"), r.Rows(5).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(6).Item("id"), 7, "Juli", r.Rows(6).Item("jml_pcs"), r.Rows(6).Item("jml_rupiah"), r.Rows(6).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(7).Item("id"), 8, "Agustus", r.Rows(7).Item("jml_pcs"), r.Rows(7).Item("jml_rupiah"), r.Rows(7).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(8).Item("id"), 9, "September", r.Rows(8).Item("jml_pcs"), r.Rows(8).Item("jml_rupiah"), r.Rows(8).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(9).Item("id"), 10, "Oktober", r.Rows(9).Item("jml_pcs"), r.Rows(9).Item("jml_rupiah"), r.Rows(9).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(10).Item("id"), 11, "Nopember", r.Rows(10).Item("jml_pcs"), r.Rows(10).Item("jml_rupiah"), r.Rows(10).Item("keterangan")})
            rcd_percustomer.Rows.Add(New Object() {r.Rows(11).Item("id"), 12, "Desember", r.Rows(11).Item("jml_pcs"), r.Rows(11).Item("jml_rupiah"), r.Rows(11).Item("keterangan")})

        Else
            rcd_percustomer.Rows.Add(New Object() {0, 1, "Januari", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 2, "Pebruari", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 3, "Maret", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 4, "April", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 5, "Mei", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 6, "Juni", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 7, "Juli", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 8, "Agustus", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 9, "September", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 10, "Oktober", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 11, "Nopember", 0, 0, vbNullString})
            rcd_percustomer.Rows.Add(New Object() {0, 12, "Desember", 0, 0, vbNullString})
        End If

        pc_GridControl1.DataSource = rcd_percustomer

        pc_GridView1.Columns("no").Caption = "No."
        pc_GridView1.Columns("bulan").Caption = "Bulan"
        pc_GridView1.Columns("jml_pcs").Caption = "Target Pcs"
        pc_GridView1.Columns("jml_rupiah").Caption = "Target Rupiah"
        pc_GridView1.Columns("keterangan").Caption = "Keterangan"

        pc_GridView1.Columns("no").Width = 35
        pc_GridView1.Columns("bulan").Width = 75
        pc_GridView1.Columns("jml_pcs").Width = 70
        pc_GridView1.Columns("jml_rupiah").Width = 85
        pc_GridView1.Columns("keterangan").Width = 150

        ' format colomn
        FormatColumnNumeric(pc_GridView1.Columns("jml_pcs"))
        FormatColumnNumeric(pc_GridView1.Columns("jml_rupiah"))

        ' desable cell
        pc_GridView1.Columns("id").Visible = False
        For i = 0 To pc_GridView1.Columns.Count - 1
            pc_GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        pc_GridView1.Columns("jml_pcs").OptionsColumn.AllowEdit = True
        pc_GridView1.Columns("jml_rupiah").OptionsColumn.AllowEdit = True
        pc_GridView1.Columns("keterangan").OptionsColumn.AllowEdit = True

        ' sumary
        CreateColumnSummary(pc_GridView1.Columns("jml_pcs"))
        CreateColumnSummary(pc_GridView1.Columns("jml_rupiah"))

    End Sub

    Sub loadData_Perbulan()
        My.Application.DoEvents()

        Dim i As Integer

        rcd_perbulan.Clear()

        '# get customer
        Db.FlushCache()
        Db.Selects("a.kode_customer, a.nama as nama_customer")
        Db.From("tbl_customer a")
        Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")

        If chk_all_provinsi.Checked = False Then
            Db.Where("b.kode_provinsi", getValueFromLookup(kode_provinsi))
        End If

        If chk_all_kota.Checked = False Then
            Db.Where("a.kode_kota", getValueFromLookup(kode_kota))
        End If

        If chk_all_group.Checked = False Then
            Db.Where("a.kode_grup", getValueFromLookup(kode_group))
        End If

        Dim cust As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        ' jika terdapat customer
        If cust.Rows.Count > 0 Then
            Dim count_cust As Integer = cust.Rows.Count - 1
            
            For i = 0 To count_cust
                rcd_perbulan.Add(New rcd_targetpenjualan_perbulan)

                rcd_perbulan.Item(i).no = i + 1
                rcd_perbulan.Item(i).kode_customer = cust.Rows(i).Item("kode_customer")
                rcd_perbulan.Item(i).nama_customer = cust.Rows(i).Item("nama_customer")

                '# get pcs bulan lalu dari primer ato sekunder
                If pb_data_lalu.EditValue = 1 Then ' primer
                    Db.FlushCache()
                    Db.Selects("kode_customer, SUM(total_qty) AS qty, SUM(total_netto) as rupiah")
                    Db.From("tbl_konsinyasiprimer")
                    Db.Where("kode_customer", cust.Rows(i).Item("kode_customer"))
                    Db.Where("MONTH(tgl_terbit)", pb_bulan.SelectedIndex + 1)
                    Db.Where("YEAR(tgl_terbit)", pb_tahun.Text)
                    Db.GroupBy("kode_customer")

                    Dim row As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                    If row.Rows.Count > 0 Then
                        rcd_perbulan.Item(i).jml_pcs_lalu = row.Rows(0).Item("qty")
                        rcd_perbulan.Item(i).jml_rupiah_lalu = row.Rows(0).Item("rupiah")

                    Else
                        rcd_perbulan.Item(i).jml_pcs_lalu = 0
                        rcd_perbulan.Item(i).jml_rupiah_lalu = 0

                    End If

                Else ' sekunder
                    Db.FlushCache()
                    Db.Selects("kode_customer, SUM(qty) AS qty, SUM(total) as rupiah")
                    Db.From("tbl_konsinyasisekunder")
                    Db.Where("kode_customer", cust.Rows(i).Item("kode_customer"))
                    Db.Where("MONTH(tgl_transaksi)", pb_bulan.SelectedIndex + 1)
                    Db.Where("YEAR(tgl_transaksi)", pb_tahun.Text)
                    Db.GroupBy("kode_customer")

                    Dim row As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                    If row.Rows.Count > 0 Then
                        rcd_perbulan.Item(i).jml_pcs_lalu = row.Rows(0).Item("qty")
                        rcd_perbulan.Item(i).jml_rupiah_lalu = row.Rows(0).Item("rupiah")

                    Else
                        rcd_perbulan.Item(i).jml_pcs_lalu = 0
                        rcd_perbulan.Item(i).jml_rupiah_lalu = 0

                    End If

                End If


                '# get data target penjualan jika ada
                Db.FlushCache()
                Db.Selects("*")
                Db.From("tbl_targetpenjualan")
                Db.Where("bulan", pb_bulan.SelectedIndex + 1)
                Db.Where("tahun", pb_tahun.Text)
                Db.Where("kode_customer", cust.Rows(i).Item("kode_customer"))

                Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

                If r.Rows.Count > 0 Then
                    rcd_perbulan.Item(i).id = r.Rows(0).Item("id")
                    rcd_perbulan.Item(i).jml_pcs = r.Rows(0).Item("jml_pcs")
                    rcd_perbulan.Item(i).jml_rupiah = r.Rows(0).Item("jml_rupiah")
                    rcd_perbulan.Item(i).keterangan = r.Rows(0).Item("keterangan")
                Else
                    rcd_perbulan.Item(i).id = 0
                    rcd_perbulan.Item(i).jml_pcs = 0
                    rcd_perbulan.Item(i).jml_rupiah = 0
                    rcd_perbulan.Item(i).keterangan = vbNullString
                End If

            Next

            pb_GridControl1.DataSource = rcd_perbulan

            ' format
            pb_GridView1.Columns("id").Visible = False
            pb_GridView1.Columns("no").Caption = "No."
            pb_GridView1.Columns("kode_customer").Caption = "Kode Customer"
            pb_GridView1.Columns("nama_customer").Caption = "Nama Customer"
            pb_GridView1.Columns("jml_pcs_lalu").Caption = "Bln Lalu (Pcs)"
            pb_GridView1.Columns("jml_rupiah_lalu").Caption = "Bln Lalu (Rp.)"
            pb_GridView1.Columns("persentase").Visible = False
            pb_GridView1.Columns("jml_pcs").Caption = "Target Pcs"
            pb_GridView1.Columns("jml_rupiah").Caption = "Target Rupiah"
            pb_GridView1.Columns("keterangan").Caption = "Keterangan"

            'pb_GridView1.Columns("id").Width = 20
            pb_GridView1.Columns("no").Width = 30
            pb_GridView1.Columns("kode_customer").Width = 90
            pb_GridView1.Columns("nama_customer").Width = 210
            pb_GridView1.Columns("jml_pcs_lalu").Width = 80
            pb_GridView1.Columns("jml_rupiah_lalu").Width = 90
            'pb_GridView1.Columns("persentase").Width = 20
            pb_GridView1.Columns("jml_pcs").Width = 80
            pb_GridView1.Columns("jml_rupiah").Width = 80
            pb_GridView1.Columns("keterangan").Width = 175

            'format column
            FormatColumnNumeric(pb_GridView1.Columns("jml_pcs_lalu"))
            FormatColumnNumeric(pb_GridView1.Columns("jml_rupiah_lalu"))
            FormatColumnNumeric(pb_GridView1.Columns("jml_pcs"))
            FormatColumnNumeric(pb_GridView1.Columns("jml_rupiah"))

            ' desable cell
            For i = 0 To pb_GridView1.Columns.Count - 1
                pb_GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
            Next
            pb_GridView1.Columns("jml_pcs").OptionsColumn.AllowEdit = True
            pb_GridView1.Columns("jml_rupiah").OptionsColumn.AllowEdit = True
            pb_GridView1.Columns("keterangan").OptionsColumn.AllowEdit = True

            ' sumary
            CreateColumnSummary(pb_GridView1.Columns("jml_pcs_lalu"))
            CreateColumnSummary(pb_GridView1.Columns("jml_rupiah_lalu"))
            CreateColumnSummary(pb_GridView1.Columns("jml_pcs"))
            CreateColumnSummary(pb_GridView1.Columns("jml_rupiah"))

        Else
            MsgBox("Tidak terdapat data dalam database!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub frm_targetpenjualan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub pc_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_print.Click
        '# Create Header
        Dim StrHeader As String = PrintableComponentLink1.RtfReportHeader
        StrHeader = StrHeader.Replace("$nama_customer", pc_kode_customer.Text)
        StrHeader = StrHeader.Replace("$tahun", pc_tahun.Text)

        ' set header and create document print
        PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = False
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)

        PrintableComponentLink1.CreateDocument()

        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Laporan Penerimaan Barang"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        'fc.MdiParent = formMDI
        fc.Height = 500
        fc.ShowDialog(Me)

    End Sub

    Private Sub pc_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pc_simpan.Click
        If MsgBox("Apakah data yang dimasukan telah benar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

            '# tansaksi start
            Connection.TRANS_START()

            Dim i As Integer
            Dim count As Integer = rcd_percustomer.Rows.Count - 1
            With rcd_percustomer
                For i = 0 To count
                    If .Rows(i).Item("id") = 0 Then
                        '# insert to table tbl_targetpenjualan
                        Db.FlushCache()
                        Db.Insert("tbl_targetpenjualan")
                        Db.SetField("kode_customer", getValueFromLookup(pc_kode_customer))
                        Db.SetField("tgl_input", Now)
                        Db.SetField("bulan", .Rows(i).Item("no"))
                        Db.SetField("tahun", pc_tahun.Text)
                        Db.SetField("jml_pcs", .Rows(i).Item("jml_pcs"))
                        Db.SetField("jml_rupiah", .Rows(i).Item("jml_rupiah"))
                        Db.SetField("keterangan", .Rows(i).Item("keterangan"))
                        Db.SetField("username", Auth.Username)

                        Connection.TRANS_ADD(Db.GetQueryString)

                    Else
                        '# insert to table tbl_targetpenjualan
                        Db.FlushCache()
                        Db.Update("tbl_targetpenjualan")
                        'Db.SetField("kode_customer", getValueFromLookup(pc_kode_customer))
                        'Db.SetField("tgl_input", Now)
                        'Db.SetField("bulan", .Rows(i).Item("bulan"))
                        'Db.SetField("tahun", pc_tahun.Text)
                        Db.SetField("jml_pcs", .Rows(i).Item("jml_pcs"))
                        Db.SetField("jml_rupiah", .Rows(i).Item("jml_rupiah"))
                        Db.SetField("keterangan", .Rows(i).Item("keterangan"))
                        'Db.SetField("username", Auth.Username)
                        Db.Where("id", .Rows(i).Item("id"))

                        Connection.TRANS_ADD(Db.GetQueryString)

                    End If
                Next

                If Connection.TRANS_SUCCESS Then
                    MsgBox("Data berhasil disimpan.")
                    Call initComponent()
                Else
                    MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
                End If
            End With
        End If
    End Sub

    Private Sub frm_targetpenjualan_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.initComponent()
    End Sub

    Private Sub pb_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_load.Click
        Call Me.loadData_Perbulan()
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

    Private Sub pb_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_print.Click
        '# Create Header
        Dim StrHeader As String = PrintableComponentLink2.RtfReportHeader
        StrHeader = StrHeader.Replace("$bulan", pb_bulan.Text)
        StrHeader = StrHeader.Replace("$tahun", pc_tahun.Text)

        ' set header and create document print
        PrintableComponentLink2.RtfReportHeader = StrHeader
        PrintableComponentLink2.Landscape = False
        PrintableComponentLink2.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink2.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)

        PrintableComponentLink2.CreateDocument()

        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Laporan Penerimaan Barang"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink2.PrintingSystem
        'fc.MdiParent = formMDI
        fc.Height = 500
        fc.ShowDialog(Me)
    End Sub

    Private Sub pb_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_simpan.Click

        If rcd_perbulan.Count > 0 Then

            If MsgBox("Apakah data yang dimasukan sudah benar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

                Dim i As Integer
                Dim count As Integer = rcd_perbulan.Count - 1

                Connection.TRANS_START()

                For i = 0 To count
                    If rcd_perbulan.Item(i).id = 0 Then
                        '# insert to table tbl_targetpenjualan
                        Db.FlushCache()
                        Db.Insert("tbl_targetpenjualan")
                        Db.SetField("kode_customer", rcd_perbulan.Item(i).kode_customer)
                        Db.SetField("tgl_input", Now)
                        Db.SetField("bulan", pb_bulan.SelectedIndex + 1)
                        Db.SetField("tahun", pb_tahun.Text)
                        Db.SetField("jml_pcs", rcd_perbulan.Item(i).jml_pcs)
                        Db.SetField("jml_rupiah", rcd_perbulan.Item(i).jml_rupiah)
                        Db.SetField("keterangan", rcd_perbulan.Item(i).keterangan)
                        Db.SetField("username", Auth.Username)

                        Connection.TRANS_ADD(Db.GetQueryString)
                    Else
                        '# insert to table tbl_targetpenjualan
                        Db.FlushCache()
                        Db.Update("tbl_targetpenjualan")
                        'Db.SetField("kode_customer", rcd_perbulan.Item(i).kode_customer)
                        'Db.SetField("tgl_input", Now)
                        'Db.SetField("bulan", pb_bulan.SelectedIndex + 1)
                        'Db.SetField("tahun", pb_tahun.Text)
                        Db.SetField("jml_pcs", rcd_perbulan.Item(i).jml_pcs)
                        Db.SetField("jml_rupiah", rcd_perbulan.Item(i).jml_rupiah)
                        Db.SetField("keterangan", rcd_perbulan.Item(i).keterangan)
                        'Db.SetField("username", Auth.Username)
                        Db.Where("id", rcd_perbulan.Item(i).id)

                        Connection.TRANS_ADD(Db.GetQueryString)

                    End If
                Next

                If Connection.TRANS_SUCCESS Then
                    MsgBox("Data berhasil disimpan")
                    rcd_perbulan.Clear()
                    pb_GridView1.RefreshData()
                Else
                    MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
                End If

            End If

        Else
            MsgBox("Tidak ada data untuk disimpan", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub XtraTabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Click

    End Sub
End Class