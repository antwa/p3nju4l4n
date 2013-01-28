Public Class frm_delivery_order_satu 

    Public p_no_so As String

    Dim kode_customer As String
    Dim sistem_jual As Integer

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_delivery_order_satu)

    Sub loadData()

        'get nomor
        no_do.Text = getNomorUrut(C_DELIVERY_ORDER)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_delivery_order_satu)

        Db.FlushCache()
        Db.Selects("a.kode_customer, d.nama AS nama_customer, d.alamat, d.mall, f.kota, a.sistem_jual, b.kode_barangjadi, b.qty, e.stok, b.terkirim, b.kode_hargajual, c.harga")
        Db.From("tbl_salesorder a")
        Db.Join("tbl_salesorder_detail b", "b.no_so = a.no_so")
        Db.Join("tbl_hargajual c", "c.kode_hargajual = b.kode_hargajual")
        Db.Join("tbl_customer d", "d.kode_customer = a.kode_customer")
        Db.Join("tbl_persediaan_gudang e", "e.kode_barangjadi = b.kode_barangjadi")
        Db.Join("tbl_kota f", "f.kode_kota = d.kode_kota")

        Db.Where("a.no_so", p_no_so)

        Db.Where(" AND b.qty <> b.terkirim")

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                While .Read
                    rcd_list.Add(New rcd_delivery_order_satu(.Item("kode_barangjadi").ToString, _
                                                             .Item("qty").ToString, _
                                                             (CInt(.Item("qty").ToString) - CInt(.Item("terkirim").ToString)), _
                                                             .Item("stok").ToString, _
                                                             .Item("kode_hargajual").ToString, _
                                                             .Item("harga").ToString, _
                                                             .Item("terkirim").ToString))

                    lbl_nama.Text = .Item("nama_customer").ToString
                    lbl_alamat.Text = .Item("alamat").ToString
                    lbl_mall.Text = .Item("mall").ToString
                    lbl_kota.Text = .Item("kota").ToString

                    kode_customer = .Item("kode_customer").ToString
                    sistem_jual = .Item("sistem_jual").ToString

                End While

                no_so.Text = p_no_so
            End With
        End If

        GridControl1.DataSource = rcd_list

        GridView1.Columns(0).Caption = "Kode Artikel"
        GridView1.Columns(1).Caption = "Jml SO (Pcs)"
        GridView1.Columns(2).Caption = "Jml DO (Pcs)"
        GridView1.Columns(3).Caption = "Stok"
        'GridView1.Columns(4).Caption = "kd harga jual"
        GridView1.Columns(5).Caption = "Harga (Rp.)"
        GridView1.Columns(6).Caption = "Keterangan"
        GridView1.Columns(7).Caption = "Terkirim"

        FormatColumnNumeric(GridView1.Columns(5))

        GridView1.Columns(0).Width = 100
        'GridView1.Columns(1).Width = 0
        'GridView1.Columns(2).Width = 0
        GridView1.Columns(3).Width = 50
        'GridView1.Columns(4).Width = 0
        GridView1.Columns(5).Width = 100
        GridView1.Columns(6).Width = 200
        GridView1.Columns(7).Width = 50

        GridView1.Columns(4).Visible = False

        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item(2).OptionsColumn.AllowEdit = True
        GridView1.Columns.Item(6).OptionsColumn.AllowEdit = True

    End Sub

    Sub initComponent()
        tgl_do.DateTime = Now
    End Sub

    Private Sub frm_delivery_order_satu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
        Call loadData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer
        Dim tersisa As Boolean = False
        Dim query As String = ""

        '# cek qty do dan stok
        For i = 0 To rcd_list.Count - 1
            If rcd_list.Item(i).qty_do > rcd_list.Item(i).stok Then
                MsgBox("Kode Artiekl : " & rcd_list.Item(i).kode_barangjadi & vbCrLf & "Jumlah DO lebih besar dari stok", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If rcd_list.Item(i).qty_do > (rcd_list.Item(i).qty_so - rcd_list.Item(i).terkirim) Then
                MsgBox("Kode Artiekl : " & rcd_list.Item(i).kode_barangjadi & vbCrLf & "Jumlah DO tidak boleh lebih dari sisa jumlah SO", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Next

        '# cek apakah DO akan ada sisa
        For i = 0 To rcd_list.Count - 1
            If rcd_list.Item(i).qty_do < (rcd_list.Item(i).qty_so - rcd_list.Item(i).terkirim) Then
                tersisa = True
            End If
        Next

        Connection.TRANS_START()

        '# insert to table tbl_deliveryorder
        Db.FlushCache()
        Db.Insert("tbl_deliveryorder")
        Db.SetField("no_do", no_do.Text)
        Db.SetField("tgl_do", tgl_do.DateTime)
        Db.SetField("no_so", no_so.Text)
        Db.SetField("sistem_jual", sistem_jual)
        Db.SetField("kode_customer", kode_customer)
        Db.SetField("username", Auth.Username)
        Db.SetField("status", "0")

        Connection.TRANS_ADD(Db.GetQueryString)

        '# update status SO
        Db.FlushCache()
        Db.Update("tbl_salesorder")
        Db.SetField("status", IIf(tersisa = True, "3", "1"))
        Db.Where("no_so", no_so.Text)

        Connection.TRANS_ADD(Db.GetQueryString)


        For i = 0 To rcd_list.Count - 1
            '# insert to table tbl_deliveryorder_detail
            Db.FlushCache()
            Db.Insert("tbl_deliveryorder_detail")
            Db.SetField("no_do", no_do.Text)
            Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_list.Item(i).qty_do)
            Db.SetField("kode_hargajual", rcd_list.Item(i).kode_hargajual)
            Db.SetField("total", (rcd_list.Item(i).qty_do + rcd_list.Item(i).harga))
            Db.SetField("keterangan", rcd_list.Item(i).keterangan)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update field terkirim di tbl_so_detail
            query = ""
            query &= " UPDATE tbl_salesorder_detail "
            query &= " SET terkirim = terkirim + " & rcd_list.Item(i).qty_do & " "
            query &= " WHERE no_so = '" & no_so.Text & "' AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'"

            Connection.TRANS_ADD(query)

            '# update stok gudang
            query = ""
            query &= " UPDATE tbl_persediaan_gudang "
            query &= " SET stok = stok - " & rcd_list.Item(i).qty_do & " "
            query &= " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'"

            Connection.TRANS_ADD(query)

        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then
            '# Print
            'ambil informasi customer
            Db.FlushCache()
            Db.Selects("a.nama, b.kota, a.mall, a.alamat")
            Db.From("tbl_customer a")
            Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
            Db.Where("a.kode_customer", kode_customer)

            Dim rcustomer As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
            rcustomer.Read()

            Dim rpt As New rpt_delivery_order_satu
            rpt.BindingSource1.DataSource = rcd_list
            rpt.no_do.Text = "Nomor : " & no_do.Text
            rpt.tgl_do.Text = tgl_do.DateTime.ToString("dd/MM/yyy")
            rpt.no_so.Text = no_so.Text

            rpt.nama.Text = rcustomer.Item("nama").ToString
            rpt.alamat.Text = rcustomer.Item("alamat").ToString
            rpt.mall.Text = rcustomer.Item("mall").ToString
            rpt.kota.Text = rcustomer.Item("kota").ToString
            rpt.CreateDocument()

            Dim fc As New FormReportControl
            fc.Text = "Print Delivery Order"
            fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            frm_delivery_order.loadData()
            Me.Close()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If
        
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub
End Class