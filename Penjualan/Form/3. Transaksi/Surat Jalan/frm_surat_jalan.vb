﻿Public Class frm_surat_jalan 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_surat_jalan)
    Public rpt_multi As New DevExpress.XtraReports.UI.XtraReport

    Dim kode_customer_child As String
    Dim sistem_jual As String

    Sub initComponent()
        rpt_multi = New DevExpress.XtraReports.UI.XtraReport
        rcd_list = New System.ComponentModel.BindingList(Of rcd_surat_jalan)
        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No."
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama").Caption = "Nama Artikel"
        GridView1.Columns("qty").Caption = "Qty (Pcs)"
        'GridView1.Columns("kode_hargajual").Caption = ""
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("total").Caption = "Total (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("no").Width = 40
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("nama").Width = 120
        GridView1.Columns("qty").Width = 60
        'GridView1.Columns("kode_hargajual").Width = 20
        GridView1.Columns("harga").Width = 75
        GridView1.Columns("total").Width = 75
        GridView1.Columns("keterangan").Width = 300

        GridView1.Columns("kode_hargajual").Visible = False

        FormatColumnNumeric(GridView1.Columns("harga"))
        FormatColumnNumeric(GridView1.Columns("total"))

        ' enable/disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("keterangan").OptionsColumn.AllowEdit = True

        ' Create summary
        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("total"))

        tgl_surat.DateTime = Now
        no_surat.Text = getNomorUrut(C_SURAT_JALAN)
        no_do.Text = vbNullString
        no_so.Text = "---"

        lbl_alamat.Text = "---"
        lbl_kota.Text = "---"
        lbl_mall.Text = "---"
        lbl_nama.Text = "---"

    End Sub

    Sub loadData()
        Dim nomor As Integer = 1

        rcd_list.Clear()

        '# cek Nomor DO, apakah sudah dibuat surat jalan?
        Db.FlushCache()
        Db.Selects("no_do, status")
        Db.From("tbl_deliveryorder")
        Db.Where("WHERE no_do LIKE '%" & no_do.Text & "'")

        Dim rs As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rs.HasRows Then
            rs.Read()
            If rs.Item("status").ToString = "1" Then
                MsgBox("Nomor DO '" & rs.Item("no_do").ToString & "' sudah pernah dibuat surat jalan!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        '# Get Data
        Db.FlushCache()
        Db.Selects("a.no_so, b.kode_barangjadi, c.nama AS nama_barangjadi, b.qty, b.kode_hargajual, d.harga ")
        Db.Selects("a.kode_customer_child, f.sistem_jual, f.nama AS nama_customer, f.alamat, g.kota, f.mall")
        Db.From("tbl_deliveryorder a")
        Db.Join("tbl_deliveryorder_detail b", "b.no_do = a.no_do")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
        Db.Join("tbl_hargajual d", "d.kode_hargajual = b.kode_hargajual")
        Db.Join("tbl_customer_child e", "e.kode_customer_child = a.kode_customer_child")
        Db.Join("tbl_customer_parent f", "f.kode_customer_parent = e.kode_customer_parent")
        Db.Join("tbl_kota g", "g.kode_kota = f.kode_kota")
        Db.Where("WHERE a.no_do LIKE '%" & no_do.Text & "'")
        'Db.Where("a.status", "0")

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                While .Read
                    rcd_list.Add(New rcd_surat_jalan(nomor, _
                                                     .Item("kode_barangjadi").ToString, _
                                                     .Item("nama_barangjadi").ToString, _
                                                     .Item("qty").ToString, _
                                                     .Item("kode_hargajual").ToString, _
                                                     .Item("harga").ToString))

                    no_so.Text = .Item("no_so").ToString
                    kode_customer_child = .Item("kode_customer_child").ToString
                    sistem_jual = .Item("sistem_jual").ToString

                    lbl_alamat.Text = .Item("alamat").ToString
                    lbl_kota.Text = .Item("kota").ToString
                    lbl_mall.Text = .Item("mall").ToString
                    lbl_nama.Text = .Item("nama_customer").ToString

                    nomor += 1
                End While
            End With

            no_do.Text = Format(CInt(no_do.Text), "0000000")
        Else
            MsgBox("Tidak terdapat data dengan nomor DO '" & no_do.Text & "'", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub frm_surat_jalan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub no_do_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles no_do.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loadData()
        Else
            rcd_list.Clear()
            tgl_surat.DateTime = Now
            no_so.Text = "---"
            lbl_alamat.Text = "---"
            lbl_kota.Text = "---"
            lbl_mall.Text = "---"
            lbl_nama.Text = "---"
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim i As Integer
        Dim query As String = ""

        If rcd_list.Count <= 0 Then
            MsgBox("Tidak terdapat data yang akan disimpan!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim str() As String = kode_customer_child.Split(".")
        Dim kode_customer_parent As String = str(0)
        Dim kelompok As String = str(1)

        Connection.TRANS_START()

        '# simpan ke surat jalan
        '# insert to table tbl_suratjalan
        Db.FlushCache()
        Db.Insert("tbl_suratjalan")
        Db.SetField("no_surat", no_surat.Text)
        Db.SetField("tgl_surat", tgl_surat.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("no_do", no_do.Text)
        Db.SetField("no_so", no_so.Text)
        Db.SetField("kode_customer_child", kode_customer_child)
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        '# update status DO menjadi 1:sudah diproses
        Db.FlushCache()
        Db.Update("tbl_deliveryorder")
        Db.SetField("status", "1")
        Db.Where("no_do", no_do.Text)

        Connection.TRANS_ADD(Db.GetQueryString)

        '# insert ke surat jalan detail
        For i = 0 To rcd_list.Count - 1
            '# insert to table tbl_suratjalan_detail
            Db.FlushCache()
            Db.Insert("tbl_suratjalan_detail")
            Db.SetField("no_surat", no_surat.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.SetField("total", rcd_list.Item(i).total)
            Db.SetField("keterangan", rcd_list.Item(i).keterangan)

            Connection.TRANS_ADD(Db.GetQueryString)

            If sistem_jual = "1" Then ' konsinyasi
                '# insert ato update ke persediaan customer
                '  jika sudah ada update stok customer, jika belum ada insert ke table persediaan customer dan insert ke table histori harga jual customer
                '------------------------------------------
                query = ""
                query &= " IF EXISTS (SELECT * FROM tbl_persediaan_customer WHERE kode_customer_child = '" & kode_customer_child & "' AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "') "
                query &= "    UPDATE tbl_persediaan_customer "
                query &= "    SET stok_sekunder = stok_sekunder + " & rcd_list.Item(i).qty & ", stok_primer = stok_primer + " & rcd_list.Item(i).qty & " "
                query &= "    WHERE kode_customer_child = '" & kode_customer_child & "' AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "' "
                query &= " ELSE "
                query &= "   BEGIN "
                query &= "    INSERT INTO tbl_persediaan_customer ([kode_customer_child],[kode_barangjadi],[stok_sekunder],[stok_primer]) "
                query &= "    VALUES ('" & kode_customer_child & "', '" & rcd_list.Item(i).kode_barangjadi & "', '" & rcd_list.Item(i).qty & "', '" & rcd_list.Item(i).qty & "');"

                query &= "    INSERT INTO tbl_histori_hargacustomer ([tanggal],[kode_customer_parent],[kode_customer_child],[kelompok],[kode_barangjadi],[harga],[diskon]) "
                query &= "    VALUES ('" & tgl_surat.DateTime.ToString("yyyy-MM-dd 00:00:00") & "', '" & kode_customer_parent & "', '" & kode_customer_child & "', '" & kelompok & "','" & rcd_list.Item(i).kode_barangjadi & "', '" & rcd_list.Item(i).harga & "', '0'); "
                query &= "   END "
                query &= "; "

                Connection.TRANS_ADD(query)

                '# insert ke kartu stok
                Db.FlushCache()
                Db.Insert("tbl_kartustok_gudang")
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("tanggal", tgl_surat.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
                Db.SetField("referensi", "No. Surat Jalan : " & no_surat.Text)
                Db.SetField("deskripsi", "Kirim ke : " & lbl_nama.Text)
                Db.SetField("masuk", "0")
                Db.SetField("keluar", rcd_list.Item(i).qty)
                Connection.TRANS_ADD(Db.GetQueryString)

            End If
        Next

        '# jika jual putus maka langsung input invoice
        '-----------------------------------------------------------------------------------------------------
        If sistem_jual = "2" Then
            '# get nomor faktur
            Dim no_faktur As String = getNomorUrut(C_FAKTUR_KONSINYASI)

            frm_invoice_jualputus.Dispose()
            frm_invoice_jualputus.kode_customer_child = Me.kode_customer_child
            frm_invoice_jualputus.GridControl1.DataSource = Me.rcd_list
            frm_invoice_jualputus.no_faktur.Text = no_faktur
            frm_invoice_jualputus.no_suratjalan.Text = Me.no_surat.Text
            frm_invoice_jualputus.tgl_jatuhtempo.DateTime = DateAdd(DateInterval.Month, 3, Now)
            frm_invoice_jualputus.total.Text = Me.GridView1.Columns("total").Summary.Item(0).SummaryValue

            frm_invoice_jualputus.lbl_nama.Text = Me.lbl_nama.Text
            frm_invoice_jualputus.lbl_alamat.Text = Me.lbl_alamat.Text
            frm_invoice_jualputus.lbl_mall.Text = Me.lbl_mall.Text
            frm_invoice_jualputus.lbl_kota.Text = Me.lbl_kota.Text

            frm_invoice_jualputus.initComponent()
            frm_invoice_jualputus.ShowDialog(Me)
        End If
        '-----------------------------------------------------------------------------------------------------

        If Connection.TRANS_SUCCESS Then
            '# Print
            Dim rpt As New rpt_surat_jalan
            rpt.BindingSource1.DataSource = rcd_list
            rpt.no_surat.Text = no_surat.Text
            rpt.no_do.Text = no_do.Text
            rpt.tgl_surat.Text = tgl_surat.DateTime.ToString("dd/MM/yyyy")
            rpt.nama.Text = lbl_nama.Text
            rpt.alamat.Text = lbl_alamat.Text
            rpt.mall.Text = lbl_mall.Text
            rpt.kota.Text = lbl_kota.Text
            rpt.CreateDocument()

            '#Tambahkan Page Ke Report
            rpt_multi.Pages.AddRange(rpt.Pages)

            Dim fc As New FormReportControl
            fc.Text = IIf(sistem_jual = "1", "Print Surat Jalan", "Print Faktur dan Surat Jalan")
            fc.PrintControl1.PrintingSystem = rpt_multi.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub no_do_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_do.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        '# Print
        Dim rpt As New rpt_amplop
        
        rpt.lbl_nama_customer.Text = lbl_nama.Text
        rpt.lbl_alamat.Text = lbl_alamat.Text
        rpt.lbl_kota.Text = lbl_kota.Text
        
        rpt.CreateDocument()

        Dim fc As New FormReportControl
        fc.Text = "Print Amplop"
        fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
        fc.Height = 500
        fc.ShowDialog(Me)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

    End Sub
End Class