﻿Public Class frm_invoice_jualputus 

    Public kode_customer_child As String

    Public Sub initComponent()
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
        GridView1.Columns.Item("keterangan").Visible = False

        ' sumary
        ' Create summary
        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("total"))

    End Sub

    Sub sumary()
        Try
            Dim subtotal As Integer = Me.GridView1.Columns("total").Summary.Item(0).SummaryValue
            total.Text = subtotal - (CInt(diskon.EditValue) + CInt(lebih_bayar.EditValue))
        Catch ex As Exception
            total.Text = "0"
        End Try
    End Sub

    Private Sub frm_invoice_jualputus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub diskon_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diskon.EditValueChanged, lebih_bayar.EditValueChanged
        Call Me.sumary()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim kode_customer_parent As String = kode_customer_child.Split(".")(0)
        Dim tgl_terbit As DateTime = Now
        Dim i As Integer

        '# insert to table tbl_fakturkonsinyasi
        Db.FlushCache()
        Db.Insert("tbl_fakturkonsinyasi")
        Db.SetField("no_faktur", no_faktur.Text)
        Db.SetField("tgl_terbit", tgl_terbit)
        Db.SetField("tgl_jatuhtempo", tgl_jatuhtempo.DateTime)
        Db.SetField("kode_customer_parent", kode_customer_parent)
        'Db.SetField("margin_toko", "0")
        'Db.SetField("margin_konsumen", "0")
        Db.SetField("total_qty", GridView1.Columns("qty").Summary.Item(0).SummaryValue)
        Db.SetField("total_bruto", GridView1.Columns("total").Summary.Item(0).SummaryValue)
        Db.SetField("total_margin", "0")
        Db.SetField("total_acara", "0")
        Db.SetField("total_toko", "0")
        Db.SetField("total_netto", GridView1.Columns("total").Summary.Item(0).SummaryValue)
        Db.SetField("potongan_deskripsi", "Lebih Bayar")
        Db.SetField("potongan_harga", lebih_bayar.EditValue)
        Db.SetField("potongan_diskon", diskon.EditValue)
        Db.SetField("total", total.EditValue)
        Db.SetField("status", "0")
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)


        '# insert ke surat jalan detail
        With frm_surat_jalan
            For i = 0 To .rcd_list.Count - 1

                '# insert to table tbl_fakturkonsinyasi_detail
                Db.FlushCache()
                Db.Insert("tbl_fakturkonsinyasi_detail")
                Db.SetField("no_faktur", no_faktur.Text)
                Db.SetField("tgl_konsinyasi", tgl_terbit)
                Db.SetField("no_penjualan", no_suratjalan.Text)
                'Db.SetField("disc_acara_kita", "0")
                'Db.SetField("disc_acara_toko", "0")
                Db.SetField("qty", .rcd_list.Item(i).qty)
                Db.SetField("bruto", .rcd_list.Item(i).total)
                Db.SetField("margin", "0")
                Db.SetField("acara", "0")
                Db.SetField("toko", "0")
                Db.SetField("netto", .rcd_list.Item(i).total)

                Connection.TRANS_ADD(Db.GetQueryString)

                '# insert ke kartu stok
                Db.FlushCache()
                Db.Insert("tbl_kartustok_gudang")
                Db.SetField("kode_barangjadi", .rcd_list.Item(i).kode_barangjadi)
                Db.SetField("tanggal", frm_surat_jalan.tgl_surat.DateTime)
                Db.SetField("referensi", "No. Surat Jalan : " & frm_surat_jalan.no_surat.Text)
                Db.SetField("deskripsi", "Kirim ke : " & lbl_nama.Text)
                Db.SetField("masuk", "0")
                Db.SetField("keluar", .rcd_list.Item(i).qty)
                Connection.TRANS_ADD(Db.GetQueryString)

            Next

            '# Print
            Dim rpt As New rpt_invoice
            rpt.BindingSource1.DataSource = .rcd_list
            rpt.no_faktur.Text = no_faktur.Text
            rpt.no_suratjalan.Text = no_suratjalan.Text
            rpt.tgl_surat.Text = .tgl_surat.DateTime.ToString("dd/MM/yyyy")
            rpt.nama.Text = lbl_nama.Text
            rpt.alamat.Text = lbl_alamat.Text
            rpt.mall.Text = lbl_mall.Text
            rpt.kota.Text = lbl_kota.Text

            rpt.lbl_subtotal.Text = Me.GridView1.Columns("total").Summary.Item(0).SummaryValue
            rpt.lbl_lebihbayar.Text = lebih_bayar.Text
            rpt.lbl_diskon.Text = diskon.Text
            rpt.lbl_total.Text = total.Text

            rpt.CreateDocument()

            '#Tambahkan Page Ke Report
            .rpt_multi.Pages.AddRange(rpt.Pages)

        End With
        
        Me.Close()
    End Sub
End Class