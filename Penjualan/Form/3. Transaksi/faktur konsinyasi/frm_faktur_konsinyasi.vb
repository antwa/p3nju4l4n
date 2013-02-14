Public Class frm_faktur_konsinyasi 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_faktur_konsinyasi)

    Public Sub initComponent()

        no_faktur.Text = getNomorUrut(C_FAKTUR_KONSINYASI)
        tgl_terbit.DateTime = Now
        Load_Customer(kode_customer, 1)
        tgl_jatuhtempo.DateTime = DateAdd(DateInterval.Month, 1, Now)

        tgl_dari.DateTime = DateAdd(DateInterval.Day, -30, Now)
        tgl_sampai.DateTime = Now

        txt_total_netto.EditValue = "0"
        txt_total.EditValue = "0"

        potongan_deskripsi.Text = "Potongan"
        potongan_harga.EditValue = "0"

        rcd_list = New System.ComponentModel.BindingList(Of rcd_faktur_konsinyasi)
        GridControl1.DataSource = rcd_list

        GridView1.Columns("tgl_terbit").Caption = "Tanggal"
        GridView1.Columns("no_penjualan").Caption = "No. Penjualan"
        GridView1.Columns("qty").Caption = "Qty (Pcs)"
        GridView1.Columns("bruto").Caption = "Bruto (Rp.)"
        GridView1.Columns("margin").Caption = "Margin (Rp.)"
        GridView1.Columns("acara").Caption = "Acara (Rp.)"
        GridView1.Columns("toko").Caption = "Toko (Rp.)"
        GridView1.Columns("netto").Caption = "Netto (Rp.)"
        GridView1.Columns("disc_acara_kita").Caption = "Kita"
        GridView1.Columns("disc_acara_toko").Caption = "Toko"

        GridView1.Columns("tgl_terbit").Width = 85
        GridView1.Columns("no_penjualan").Width = 90
        GridView1.Columns("qty").Width = 60
        GridView1.Columns("bruto").Width = 80
        GridView1.Columns("margin").Width = 80
        GridView1.Columns("acara").Width = 80
        GridView1.Columns("toko").Width = 80
        GridView1.Columns("netto").Width = 80
        GridView1.Columns("disc_acara_kita").Width = 55
        GridView1.Columns("disc_acara_toko").Width = 55

        FormatColumnNumeric(GridView1.Columns("bruto"))
        FormatColumnNumeric(GridView1.Columns("margin"))
        FormatColumnNumeric(GridView1.Columns("acara"))
        FormatColumnNumeric(GridView1.Columns("toko"))
        FormatColumnNumeric(GridView1.Columns("netto"))

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next

        ' Create summary
        CreateColumnSummary(GridView1.Columns("qty"))
        CreateColumnSummary(GridView1.Columns("bruto"))
        CreateColumnSummary(GridView1.Columns("margin"))
        CreateColumnSummary(GridView1.Columns("acara"))
        CreateColumnSummary(GridView1.Columns("toko"))
        CreateColumnSummary(GridView1.Columns("netto"))

        '# Create Band
        Dim BArtikel As New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Dim BAcara As New DevExpress.XtraGrid.Views.BandedGrid.GridBand

        With BArtikel
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = " "
        End With
        With BAcara
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .Caption = "Disc Acara"
        End With

        GridView1.Bands.Clear()
        GridView1.Bands.Add(BArtikel)
        GridView1.Bands.Add(BAcara)

        '#  atur aparance
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next

        '# add column to band
        ' Artikel
        BArtikel.Columns.Add(GridView1.Columns("tgl_terbit"))
        BArtikel.Columns.Add(GridView1.Columns("no_penjualan"))
        BArtikel.Columns.Add(GridView1.Columns("qty"))
        BArtikel.Columns.Add(GridView1.Columns("bruto"))
        BArtikel.Columns.Add(GridView1.Columns("margin"))
        BArtikel.Columns.Add(GridView1.Columns("acara"))
        BArtikel.Columns.Add(GridView1.Columns("toko"))
        BArtikel.Columns.Add(GridView1.Columns("netto"))

        BAcara.Columns.Add(GridView1.Columns("disc_acara_kita"))
        BAcara.Columns.Add(GridView1.Columns("disc_acara_toko"))


    End Sub

    Sub loadData()
        rcd_list.Clear()

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_konsinyasiprimer")
        Db.Where("kode_customer", kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text))
        Db.Where("status", "0") ' statusnya yg belum dibuat faktur
        Db.Where_BetweenDate("tgl_terbit", tgl_dari.DateTime, tgl_sampai.DateTime)
        Db.OrderBy("no_penjualan", cls_database.sorting.Ascending)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rcd.HasRows Then
            With rcd
                While .Read
                    rcd_list.Add(New rcd_faktur_konsinyasi(.Item("tgl_terbit").ToString, _
                                                           .Item("no_penjualan").ToString, _
                                                           .Item("total_qty").ToString, _
                                                           .Item("total_bruto").ToString, _
                                                           .Item("total_margin").ToString, _
                                                           .Item("total_acara").ToString, _
                                                           .Item("total_toko").ToString, _
                                                           .Item("total_netto").ToString, _
                                                           .Item("disc_acara_kita").ToString, _
                                                           .Item("disc_acara_toko").ToString))
                End While
            End With

            Try
                GridView1.RefreshData()

                txt_total_netto.EditValue = GridView1.Columns("netto").Summary.Item(0).SummaryValue
                txt_total.EditValue = CInt(txt_total_netto.EditValue) - CInt(potongan_harga.EditValue)
            Catch ex As Exception

            End Try
        Else
            MsgBox("tidak terdapat data!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub frm_faktur_konsinyasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        loadData()
    End Sub

    Private Sub potongan_harga_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles potongan_harga.EditValueChanged
        Try
            txt_total_netto.EditValue = GridView1.Columns("netto").Summary.Item(0).SummaryValue
            txt_total.EditValue = CInt(txt_total_netto.EditValue) - CInt(potongan_harga.EditValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim vkode_customer As String = kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text)
        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount = 0 Then
            MsgBox("Masukan No Penjualan Terlebih Dulu", MsgBoxStyle.Critical, "Belum Diisi")
            Exit Sub
        End If

        '# cek nomor penjualan
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_fakturkonsinyasi")
        Db.Where("no_faktur", no_faktur.Text)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# Begin Transaction
        Connection.TRANS_START()

        '# insert to table tbl_fakturkonsinyasi
        Db.FlushCache()
        Db.Insert("tbl_fakturkonsinyasi")
        Db.SetField("no_faktur", no_faktur.Text)
        Db.SetField("tgl_terbit", tgl_terbit.DateTime)
        Db.SetField("tgl_jatuhtempo", tgl_jatuhtempo.DateTime)
        Db.SetField("kode_customer", vkode_customer)
        'Db.SetField("margin_toko", )
        'Db.SetField("margin_konsumen", )
        Db.SetField("total_qty", GridView1.Columns("qty").Summary.Item(0).SummaryValue)
        Db.SetField("total_bruto", GridView1.Columns("bruto").Summary.Item(0).SummaryValue)
        Db.SetField("total_margin", GridView1.Columns("margin").Summary.Item(0).SummaryValue)
        Db.SetField("total_acara", GridView1.Columns("acara").Summary.Item(0).SummaryValue)
        Db.SetField("total_toko", GridView1.Columns("toko").Summary.Item(0).SummaryValue)
        Db.SetField("total_netto", GridView1.Columns("netto").Summary.Item(0).SummaryValue)
        Db.SetField("potongan_deskripsi", potongan_deskripsi.Text)
        Db.SetField("potongan_harga", potongan_harga.EditValue)
        Db.SetField("total", txt_total.EditValue)
        Db.SetField("status", "0")
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 1
            '# insert to table tbl_fakturkonsinyasi_detail
            Db.FlushCache()
            Db.Insert("tbl_fakturkonsinyasi_detail")
            Db.SetField("no_faktur", no_faktur.Text)
            Db.SetField("tgl_konsinyasi", rcd_list.Item(i).tgl_terbit)
            Db.SetField("no_penjualan", rcd_list.Item(i).no_penjualan)
            Db.SetField("disc_acara_kita", rcd_list.Item(i).disc_acara_kita)
            Db.SetField("disc_acara_toko", rcd_list.Item(i).disc_acara_toko)
            Db.SetField("qty", rcd_list.Item(i).qty)
            Db.SetField("bruto", rcd_list.Item(i).bruto)
            Db.SetField("margin", rcd_list.Item(i).margin)
            Db.SetField("acara", rcd_list.Item(i).acara)
            Db.SetField("toko", rcd_list.Item(i).toko)
            Db.SetField("netto", rcd_list.Item(i).netto)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update status tbl_konsinyasi primer
            Db.FlushCache()
            Db.Update("tbl_konsinyasiprimer")
            Db.SetField("status", "1")
            Db.Where("no_penjualan", rcd_list.Item(i).no_penjualan)

            Connection.TRANS_ADD(Db.GetQueryString)

        Next


        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            'MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")

            '# Print
            Dim rpt As New rpt_faktur_konsinyasi_primer
            rpt.BindingSource1.DataSource = rcd_list
            rpt.lbl_kode_customer.Text = getValueFromLookup(kode_customer)
            rpt.lbl_nama_customer.Text = kode_customer.Text
            rpt.lbl_no_faktur.Text = no_faktur.Text
            rpt.lbl_potongan.Text = potongan_deskripsi.Text & " : " & potongan_harga.EditValue
            rpt.lbl_tanggal_terbit.Text = tgl_terbit.Text
            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Faktur Konsinyasi"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)


            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If


    End Sub

End Class