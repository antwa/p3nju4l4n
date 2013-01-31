Imports DevExpress.XtraEditors.Controls

Public Class frm_rekap_gaji_spg

    Dim rcd_list As DataTable

    Sub initComponent()
        ' init bulan dan tahun
        cmb_bulan.Properties.Items.Add("Januari")
        cmb_bulan.Properties.Items.Add("Februari")
        cmb_bulan.Properties.Items.Add("Maret")
        cmb_bulan.Properties.Items.Add("April")
        cmb_bulan.Properties.Items.Add("Mei")
        cmb_bulan.Properties.Items.Add("Juni")
        cmb_bulan.Properties.Items.Add("Juli")
        cmb_bulan.Properties.Items.Add("Agustus")
        cmb_bulan.Properties.Items.Add("September")
        cmb_bulan.Properties.Items.Add("Oktober")
        cmb_bulan.Properties.Items.Add("Nopember")
        cmb_bulan.Properties.Items.Add("Desember")

        cmb_bulan.SelectedItem = Now.ToString("MMMM")

        cmb_tahun.Properties.Items.Add(CInt(Now.ToString("yyyy") - 1))
        cmb_tahun.Properties.Items.Add(Now.ToString("yyyy"))
        cmb_tahun.Properties.Items.Add(CInt(Now.ToString("yyyy") + 1))

        cmb_tahun.SelectedItem = Now.ToString("yyyy")

        '# init radio group
        rdo_status.Properties.Items.Add(New RadioGroupItem("1", "Semua"))
        rdo_status.Properties.Items.Add(New RadioGroupItem("2", "Belum Terbayar"))

        rdo_status.SelectedIndex = 0

        rdo_berdasarkan.Properties.Items.Add(New RadioGroupItem("1", "Customer"))
        rdo_berdasarkan.Properties.Items.Add(New RadioGroupItem("2", "Wilayah"))

        rdo_berdasarkan.SelectedIndex = 0

        '# load customer
        Load_Customer(kode_customer, "1")

    End Sub

    Sub loadData()
        Db.FlushCache()
        Db.Selects("b.nama, (a.j_hadir*a.p_hadir) AS t_hadir, (a.j_lembur1*a.p_lembur1) AS lembur, (a.j_lembur2*a.p_lembur2) AS h_besar, (a.j_bonus*a.p_bonus) AS bonus, a.total_insentif AS insentif, a.pengembalian_jaminan, a.total_potongan AS potongan, a.jaminan_kerja, a.total_utang AS utang, a.grand_total AS total, b.nama_bank, b.no_rekening, b.atas_nama")
        Db.Selects("a.j_hadir, a.p_hadir, a.j_lembur1, a.p_lembur1, a.j_lembur2, a.p_lembur2, a.j_bonus, a.p_bonus, a.periode, b.kode_customer, a.tgl_transfer, a.id_pegawai")
        Db.From("tbl_penggajian a")
        Db.Join("tbl_pegawai b", "b.id_pegawai = a.id_pegawai")
        Db.Where("b.[group]", "2") ' berdasarkan SPG
        Db.Where("a.periode", cmb_bulan.Text & " " & cmb_tahun.Text)

        If txt_nama_bank.Text <> vbNullString Then
            Db.Where("b.nama_bank", "%" & txt_nama_bank.Text & "%", "LIKE")
        End If

        If rdo_status.SelectedIndex = 1 Then ' jika belum bayar yg diseleksi
            Db.Where("a.status", "0")
        End If

        If rdo_berdasarkan.SelectedIndex = 0 Then ' berdasarkan customer
            If Not chk_semua_customer.Checked Then
                Db.Where("b.kode_customer", getValueFromLookup(kode_customer))
            End If

        Else ' berdasarkan wilayah

        End If


        rcd_list = New DataTable
        rcd_list = Connection.ExecuteToDataTable(Db.GetQueryString)
        rcd_list.Columns.Add("check", GetType(Boolean))

        Dim i As Integer
        For i = 0 To rcd_list.Rows.Count - 1
            rcd_list.Rows(i).Item("check") = False
        Next

        GridControl1.DataSource = rcd_list

        GridView1.Columns("nama").Caption = "Nama SPG"
        GridView1.Columns("t_hadir").Caption = "P Hadir"
        GridView1.Columns("lembur").Caption = "Lembur"
        GridView1.Columns("h_besar").Caption = "H Besar"
        GridView1.Columns("bonus").Caption = "Bonus"
        GridView1.Columns("insentif").Caption = "Insentif"
        GridView1.Columns("pengembalian_jaminan").Caption = "Png Jaminan"
        GridView1.Columns("potongan").Caption = "Potongan"
        GridView1.Columns("jaminan_kerja").Caption = "Jaminan Kerja"
        GridView1.Columns("utang").Caption = "Utang"
        GridView1.Columns("total").Caption = "Total"
        GridView1.Columns("nama_bank").Caption = "Bank"
        GridView1.Columns("no_rekening").Caption = "No. Rekening"
        GridView1.Columns("atas_nama").Caption = "A/N"
        GridView1.Columns("check").Caption = "C"

        GridView1.Columns("nama").Width = 110
        GridView1.Columns("t_hadir").Width = 70
        GridView1.Columns("lembur").Width = 70
        GridView1.Columns("h_besar").Width = 70
        GridView1.Columns("bonus").Width = 70
        GridView1.Columns("insentif").Width = 70
        GridView1.Columns("pengembalian_jaminan").Width = 70
        GridView1.Columns("potongan").Width = 70
        GridView1.Columns("jaminan_kerja").Width = 70
        GridView1.Columns("utang").Width = 70
        GridView1.Columns("total").Width = 70
        GridView1.Columns("nama_bank").Width = 80
        GridView1.Columns("no_rekening").Width = 85
        GridView1.Columns("atas_nama").Width = 110
        GridView1.Columns("check").Width = 40

        FormatColumnNumeric(GridView1.Columns("t_hadir"))
        FormatColumnNumeric(GridView1.Columns("lembur"))
        FormatColumnNumeric(GridView1.Columns("h_besar"))
        FormatColumnNumeric(GridView1.Columns("bonus"))
        FormatColumnNumeric(GridView1.Columns("insentif"))
        FormatColumnNumeric(GridView1.Columns("pengembalian_jaminan"))
        FormatColumnNumeric(GridView1.Columns("potongan"))
        FormatColumnNumeric(GridView1.Columns("jaminan_kerja"))
        FormatColumnNumeric(GridView1.Columns("utang"))
        FormatColumnNumeric(GridView1.Columns("total"))

        ' Enable/desable
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("check").OptionsColumn.AllowEdit = True

        For i = 12 To GridView1.Columns.Count - 2
            GridView1.Columns.Item(i).Visible = False
        Next

    End Sub

    Private Sub frm_rekap_gaji_spg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub chk_semua_customer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_semua_customer.CheckedChanged
        kode_customer.Enabled = Not chk_semua_customer.Checked
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call Me.loadData()
    End Sub

    Private Sub chk_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_check.CheckedChanged
        Try
            Dim i As Integer
            For i = 0 To rcd_list.Rows.Count - 1
                rcd_list.Rows(i).Item("check") = chk_check.Checked
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdo_berdasarkan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_berdasarkan.SelectedIndexChanged
        If rdo_berdasarkan.SelectedIndex = 0 Then
            chk_semua_customer.Enabled = True
            kode_customer.Enabled = Not chk_semua_customer.Checked


        Else
            chk_semua_customer.Enabled = False
            kode_customer.Enabled = False


        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        With SaveFileDialog1
            .Filter = "Exel File 2007 (*.Xlsx)|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(.FileName)
            End If
        End With
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            Dim i As Integer
            With rcd_list
                '#PRINT MULTI
                Dim rpt_multi As New DevExpress.XtraReports.UI.XtraReport

                For i = 0 To .Rows.Count - 1
                    If .Rows(i).Item("check") Then

                        '#Membuat Page Report
                        Dim rpt As New rpt_slip_gaji
                        'rpt.BindingSource1.DataSource = rcd_tmp
                        rpt.lbl_nama.Text = .Rows(i).Item("nama")
                        rpt.lbl_toko.Text = getNamacustomer(.Rows(i).Item("kode_customer"))
                        rpt.lbl_periode.Text = .Rows(i).Item("periode")

                        rpt.lbl_j_hadir.Text = Format(.Rows(i).Item("j_hadir"), "n0")
                        rpt.lbl_p_hadir.Text = Format(.Rows(i).Item("p_hadir"), "n0")
                        rpt.lbl_total_hadir.Text = Format(.Rows(i).Item("t_hadir"), "n0")

                        rpt.lbl_j_lembur1.Text = Format(.Rows(i).Item("j_lembur1"), "n0")
                        rpt.lbl_p_lembur1.Text = Format(.Rows(i).Item("p_lembur1"), "n0")
                        rpt.lbl_total_lembur1.Text = Format(.Rows(i).Item("lembur"), "n0")

                        rpt.lbl_j_lembur2.Text = Format(.Rows(i).Item("j_lembur2"), "n0")
                        rpt.lbl_p_lembur2.Text = Format(.Rows(i).Item("p_lembur2"), "n0")
                        rpt.lbl_total_lembur2.Text = Format(.Rows(i).Item("h_besar"), "n0")

                        rpt.lbl_j_bonus.Text = Format(.Rows(i).Item("j_bonus"), "n0")
                        rpt.lbl_p_bonus.Text = Format(.Rows(i).Item("p_bonus"), "n0")
                        rpt.lbl_total_bonus.Text = Format(.Rows(i).Item("bonus"), "n0")

                        rpt.lbl_total_insentif.Text = Format(.Rows(i).Item("insentif"), "n0")
                        rpt.lbl_total_pengembalian_jaminan.Text = Format(.Rows(i).Item("pengembalian_jaminan"), "n0")

                        Dim Total1 As Double = .Rows(i).Item("t_hadir") + .Rows(i).Item("lembur") + .Rows(i).Item("h_besar") + .Rows(i).Item("bonus") + .Rows(i).Item("insentif") + .Rows(i).Item("pengembalian_jaminan")
                        rpt.lbl_Total_1.Text = Format(Total1, "n0")


                        rpt.lbl_total_potongan.Text = Format(.Rows(i).Item("potongan"), "n0")
                        rpt.lbl_total_jaminan.Text = Format(.Rows(i).Item("potongan"), "n0")

                        rpt.lbl_grand_total.Text = Format(.Rows(i).Item("total"), "n0")

                        rpt.lbl_nama_bank.Text = .Rows(i).Item("nama_bank")
                        rpt.lbl_tgl_transfer.Text = .Rows(i).Item("tgl_transfer")

                        rpt.lbl_yang_menerima.Text = .Rows(i).Item("nama")

                        '# get total jaminan kerja
                        Try
                            Db.FlushCache()
                            Db.Selects("id_pegawai, SUM(jaminan_kerja) AS total_jaminan")
                            Db.From("tbl_penggajian")
                            Db.Where("id_pegawai", .Rows(i).Item("id_pegawai"))
                            Db.GroupBy("id_pegawai")

                            Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
                            If dt.Rows.Count > 0 Then
                                rpt.lbl_total_jaminan.Text = Format(CDbl(dt.Rows(0).Item("total_jaminan")), "n0")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        rpt.CreateDocument()

                        '#Tambahkan Page Ke Report
                        rpt_multi.Pages.AddRange(rpt.Pages)

                    End If
                Next

                '#Tampilkan Report
                Dim fc As New FormReportControl
                fc.Text = "Print Slip Gaji"
                fc.PrintControl1.PrintingSystem = rpt_multi.PrintingSystem
                fc.Height = 600
                fc.ShowDialog(Me)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            If rcd_list.Rows.Count > 0 Then
                Dim rcd_rekap As New System.ComponentModel.BindingList(Of rcd_rekap_transfer)
                Dim i As Integer

                For i = 0 To rcd_list.Rows.Count - 1
                    rcd_rekap.Add(New rcd_rekap_transfer)

                    rcd_rekap.Item(i).no = i + 1
                    rcd_rekap.Item(i).nama_toko = getNamacustomer(rcd_list.Rows(i).Item("kode_customer"))
                    rcd_rekap.Item(i).nama_spg = rcd_list.Rows(i).Item("nama")
                    rcd_rekap.Item(i).total = rcd_list.Rows(i).Item("total")
                    rcd_rekap.Item(i).nama_bank = rcd_list.Rows(i).Item("nama_bank")
                    rcd_rekap.Item(i).no_rekening = rcd_list.Rows(i).Item("no_rekening")
                    rcd_rekap.Item(i).atas_nama = rcd_list.Rows(i).Item("atas_nama")
                    rcd_rekap.Item(i).tgl_transfer = rcd_list.Rows(i).Item("tgl_transfer")

                Next

                '# Print
                Dim rpt As New rpt_rekap_transfer
                rpt.BindingSource1.DataSource = rcd_rekap
                rpt.lbl_tanggal.Text = Now.ToString("dd/MM/yyyy")

                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Rekap Transfer"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.MdiParent = formMDI
                fc.Show()

            End If
        Catch ex As Exception

        End Try
        
    End Sub


    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            If rcd_list.Rows.Count > 0 Then
                Dim rcd_rekap As New System.ComponentModel.BindingList(Of rcd_rekap_gaji)
                Dim i As Integer

                For i = 0 To rcd_list.Rows.Count - 1
                    rcd_rekap.Add(New rcd_rekap_gaji)

                    rcd_rekap.Item(i).no = i + 1
                    rcd_rekap.Item(i).nama_toko = getNamacustomer(rcd_list.Rows(i).Item("kode_customer"))
                    rcd_rekap.Item(i).nama_spg = rcd_list.Rows(i).Item("nama")

                    rcd_rekap.Item(i).t_hadir = rcd_list.Rows(i).Item("t_hadir")
                    rcd_rekap.Item(i).t_lembur = rcd_list.Rows(i).Item("lembur")
                    rcd_rekap.Item(i).t_hari_besar = rcd_list.Rows(i).Item("h_besar")
                    rcd_rekap.Item(i).t_bonus = rcd_list.Rows(i).Item("bonus")
                    rcd_rekap.Item(i).t_insentif = rcd_list.Rows(i).Item("insentif")
                    rcd_rekap.Item(i).t_pengembalian_jaminan = rcd_list.Rows(i).Item("pengembalian_jaminan")
                    rcd_rekap.Item(i).t_potongan = rcd_list.Rows(i).Item("potongan")
                    rcd_rekap.Item(i).t_jaminan_kerja = rcd_list.Rows(i).Item("jaminan_kerja")
                    rcd_rekap.Item(i).t_total = rcd_list.Rows(i).Item("total")

                Next

                '# Print
                Dim rpt As New rpt_rekap_gaji
                rpt.BindingSource1.DataSource = rcd_rekap
                rpt.lbl_tanggal.Text = Now.ToString("dd/MM/yyyy")

                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Rekap Gaji"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.MdiParent = formMDI
                fc.Show()

            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
