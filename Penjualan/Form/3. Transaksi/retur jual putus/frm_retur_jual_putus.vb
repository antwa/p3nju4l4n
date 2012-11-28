Public Class frm_retur_jual_putus 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_retur_jual_putus)

    Sub initComponent()
        'load nomor
        no_retur.Text = getNomorUrut(C_RETUR_JUAL_PUTUS)
        tgl_retur.DateTime = Now
        Load_Customer(kode_customer, 2)
        Call CustomerDetail()

        rcd_list = New System.ComponentModel.BindingList(Of rcd_retur_jual_putus)

        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No"
        GridView1.Columns("no_faktur").Caption = "No. Faktur"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("jml_retur").Caption = "Jml Retur"
        GridView1.Columns("total").Caption = "Total (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("no").Width = 45
        GridView1.Columns("no_faktur").Width = 100
        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("harga").Width = 90
        GridView1.Columns("jml_retur").Width = 75
        GridView1.Columns("total").Width = 90
        GridView1.Columns("keterangan").Width = 250

        FormatColumnNumeric(GridView1.Columns("harga"))
        FormatColumnNumeric(GridView1.Columns("total"))

        ' enable/disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("jml_retur").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("keterangan").OptionsColumn.AllowEdit = True

        ' Create summary
        GridView1.Columns("jml_retur").Summary.Clear()
        GridView1.Columns("jml_retur").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "jml_retur", "{0:n0}")

        GridView1.Columns("total").Summary.Clear()
        GridView1.Columns("total").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total", "{0:n0}")

    End Sub

    Sub CustomerDetail()
        Db.FlushCache()
        Db.Selects("a.kode_customer, a.nama, a.alamat, b.kota, a.mall")
        Db.From("tbl_customer a")
        Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
        Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        rcd.Read()

        lbl_nama.Text = rcd.Item("nama").ToString
        lbl_alamat.Text = rcd.Item("alamat").ToString
        lbl_mall.Text = rcd.Item("mall").ToString
        lbl_kota.Text = rcd.Item("kota").ToString

    End Sub

    Sub reIndex()
        Try
            If rcd_list.Count > 0 Then
                tgl_retur.Properties.ReadOnly = True
                kode_customer.Properties.ReadOnly = True
            Else
                tgl_retur.Properties.ReadOnly = False
                kode_customer.Properties.ReadOnly = False
            End If

            Dim i As Integer
            For i = 1 To rcd_list.Count
                rcd_list.Item(i).no = i
            Next
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub frm_retur_jual_putus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Try
            rcd_list.RemoveAt(row)
            Call Me.reIndex()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer.EditValueChanged
        Call Me.CustomerDetail()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_RETUR_JUAL_PUTUS
        frm_transaksi_popup_artkel.kode_customer = getValueFromLookup(kode_customer)
        frm_transaksi_popup_artkel.ShowDialog(Me)
        Call Me.reIndex()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer
        Dim query As String

        'Cek Grid
        If rcd_list.Count <= 0 Then
            MsgBox("Isi data yang akan diretur!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        For i = 0 To rcd_list.Count - 1
            If rcd_list.Item(i).jml_retur <= 0 Then
                MsgBox("Jumlah Retur tidak boleh Nol!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        Connection.TRANS_START()
        '# insert to table tbl_retur_jualputus
        Db.FlushCache()
        Db.Insert("tbl_retur_jualputus")
        Db.SetField("no_retur", no_retur.Text)
        Db.SetField("tgl_retur", tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("kode_customer", getValueFromLookup(kode_customer))
        Db.SetField("total_qty", GridView1.Columns("jml_retur").Summary(0).SummaryValue)
        Db.SetField("total", GridView1.Columns("total").Summary(0).SummaryValue)
        Db.SetField("username", Auth.Username)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 1

            '# insert to table tbl_retur_jualputus_detail
            Db.FlushCache()
            Db.Insert("tbl_retur_jualputus_detail")
            Db.SetField("no_retur", no_retur.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("no_faktur", rcd_list.Item(i).no_faktur)
            Db.SetField("qty", rcd_list.Item(i).jml_retur)
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.SetField("total", rcd_list.Item(i).total)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# menambah stok gudang
            query = ""
            query &= " UPDATE tbl_persediaan_gudang "
            query &= " SET stok = stok + " & rcd_list.Item(i).jml_retur & " "
            query &= " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'"
            Connection.TRANS_ADD(query)

            '# insert ke kartu stok
            Db.FlushCache()
            Db.Insert("tbl_kartustok_gudang")
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("tanggal", tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Db.SetField("referensi", "No. Retur : " & no_retur.Text)
            Db.SetField("deskripsi", "Retur dari " & lbl_nama.Text)
            Db.SetField("masuk", rcd_list.Item(i).jml_retur)
            Db.SetField("keluar", "0")
            Connection.TRANS_ADD(Db.GetQueryString)

        Next


        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            'Dim rpt As New rpt_retur_penerimaanbarang
            'rpt.BindingSource1.DataSource = rcd_list
            'rpt.nomor_retur.Text = "Nomor : " & nomor_retur.Text
            'rpt.tanggal.Text = tanggal.DateTime.ToString("dd/MM/yyy")
            'rpt.lbl_nama_supplier.Text = lbl_nama_supplier.Text
            'rpt.nomor_terima.Text = nomor_terima.Text
            'rpt.lbl_tanggal_terima.Text = lbl_tanggal_terima.Text
            'rpt.CreateDocument()

            'Dim fc As New FormReportControl
            'fc.Text = "Print Bukti Retur Barang"
            'fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            'fc.Height = 600
            'fc.ShowDialog(Me)

            Call initComponent()
            Call reIndex()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub

End Class