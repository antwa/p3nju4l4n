Public Class frm_delivery_order_banyak 

    Public sistem_jual As Integer

    Public rcd_detail As System.ComponentModel.BindingList(Of rcd_delivery_order_banyak)
    Public rcd_master As New DataTable

    Sub loadData()

        Dim i As Integer

        'get nomor
        Dim no_do As String = getNomorUrut(C_DELIVERY_ORDER)

        rcd_detail = New System.ComponentModel.BindingList(Of rcd_delivery_order_banyak)
        rcd_master.Columns.Add("no_do", GetType(String))
        'rcd_master.Columns.Add("tgl_do", GetType(Date))
        rcd_master.Columns.Add("no_so", GetType(String))
        rcd_master.Columns.Add("sistem_jual", GetType(String))
        rcd_master.Columns.Add("kode_customer", GetType(String))

        ' input ke record master dan detail
        With frm_delivery_order.rcd_list
            For i = 0 To .Count - 1
                If .Item(i).cek = True Then

                    '# input ke master
                    rcd_master.Rows.Add(New Object() {no_do, .Item(i).no_so, sistem_jual, .Item(i).kode_customer})

                    '# input ke detail
                    Db.FlushCache()
                    Db.Selects("a.kode_customer, d.nama AS nama_customer, a.sistem_jual, b.kode_barangjadi, b.qty, e.stok, b.terkirim, b.kode_hargajual, c.harga")
                    Db.From("tbl_salesorder a")
                    Db.Join("tbl_salesorder_detail b", "b.no_so = a.no_so")
                    Db.Join("tbl_hargajual c", "c.kode_hargajual = b.kode_hargajual")
                    Db.Join("tbl_customer d", "d.kode_customer = a.kode_customer")
                    Db.Join("tbl_persediaan_gudang e", "e.kode_barangjadi = b.kode_barangjadi")

                    Db.Where("a.no_so", .Item(i).no_so)
                    Db.Where("a.status", "0")

                    Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

                    If rcd.HasRows Then
                        While rcd.Read
                            rcd_detail.Add(New rcd_delivery_order_banyak(.Item(i).no_so, no_do, _
                                                                     rcd.Item("kode_customer").ToString, rcd.Item("nama_customer").ToString, rcd.Item("kode_barangjadi").ToString, _
                                                                     rcd.Item("qty").ToString, _
                                                                     rcd.Item("qty").ToString, _
                                                                      CInt(rcd.Item("stok").ToString), _
                                                                     rcd.Item("kode_hargajual").ToString, _
                                                                     rcd.Item("harga").ToString, _
                                                                     "", _
                                                                     rcd.Item("terkirim").ToString _
                                                                     ))

                        End While
                    End If

                    '# increment no DO
                    Dim tNo_DO As Integer = CInt(no_do) + 1
                    no_do = Format(CInt(tNo_DO), "0000000")

                End If
            Next
        End With

        GridControl1.DataSource = rcd_detail

        GridView1.Columns("no_so").Caption = "No. SO"
        GridView1.Columns("no_do").Caption = "No. DO"
        GridView1.Columns("kode_customer").Caption = "Kode Customer"
        GridView1.Columns("nama").Caption = "Nama"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("jml_so").Caption = "Jml SO"
        GridView1.Columns("jml_do").Caption = "Jml DO"
        'GridView1.Columns("stok").Caption = ""
        'GridView1.Columns("kode_hargajual").Caption = ""
        GridView1.Columns("harga").Caption = "Harga (Rp.)"
        GridView1.Columns("keterangan").Caption = "Keterangan"
        'GridView1.Columns("terkirim").Caption = ""

        GridView1.Columns("no_so").Width = 50
        GridView1.Columns("no_do").Width = 75
        GridView1.Columns("kode_customer").Width = 90
        GridView1.Columns("nama").Width = 100
        GridView1.Columns("kode_barangjadi").Width = 100
        GridView1.Columns("jml_so").Width = 45
        GridView1.Columns("jml_do").Width = 45
        'GridView1.Columns("stok").Width = 32
        'GridView1.Columns("kode_hargajual").Width = 86
        GridView1.Columns("harga").Width = 75
        GridView1.Columns("keterangan").Width = 90
        'GridView1.Columns("terkirim").Width = 47

        FormatColumnNumeric(GridView1.Columns("harga"))

        GridView1.Columns("stok").Visible = False
        GridView1.Columns("kode_hargajual").Visible = False
        GridView1.Columns("terkirim").Visible = False
        
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("jml_do").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("keterangan").OptionsColumn.AllowEdit = True

        GridView1.Columns("no_so").GroupIndex = 0
        GridView1.ExpandAllGroups()

    End Sub

    Sub initComponent()
        tgl_do.DateTime = Now
    End Sub

    Private Sub frm_delivery_order_banyak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
        Call loadData()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer
        Dim x As Integer
        Dim query As String

        Connection.TRANS_START()

        '# insert ke master
        For i = 0 To rcd_master.Rows.Count - 1
            '# insert to table tbl_deliveryorder
            Db.FlushCache()
            Db.Insert("tbl_deliveryorder")
            Db.SetField("no_do", rcd_master.Rows(i).Item("no_do"))
            Db.SetField("tgl_do", tgl_do.DateTime)
            Db.SetField("no_so", rcd_master.Rows(i).Item("no_so"))
            Db.SetField("sistem_jual", sistem_jual)
            Db.SetField("kode_customer", rcd_master.Rows(i).Item("kode_customer"))
            Db.SetField("username", Auth.Username)
            Db.SetField("status", "0")

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update status SO
            Db.FlushCache()
            Db.Update("tbl_salesorder")
            Db.SetField("status", "1")
            Db.Where("no_so", rcd_master.Rows(i).Item("no_so"))

            Connection.TRANS_ADD(Db.GetQueryString)
        Next

        '# insert ke detail
        For i = 0 To rcd_detail.Count - 1
            '# insert to table tbl_deliveryorder_detail
            Db.FlushCache()
            Db.Insert("tbl_deliveryorder_detail")
            Db.SetField("no_do", rcd_detail.Item(i).no_do)
            Db.SetField("kode_barangjadi", rcd_detail.Item(i).kode_barangjadi)
            Db.SetField("qty", rcd_detail.Item(i).jml_do)
            Db.SetField("kode_hargajual", rcd_detail.Item(i).kode_hargajual)
            Db.SetField("total", (rcd_detail.Item(i).jml_do * rcd_detail.Item(i).harga))
            Db.SetField("keterangan", rcd_detail.Item(i).keterangan)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# update field terkirim di tbl_so_detail
            query = ""
            query &= " UPDATE tbl_salesorder_detail "
            query &= " SET terkirim = terkirim + " & rcd_detail.Item(i).jml_do & " "
            query &= " WHERE no_so = '" & rcd_detail.Item(i).no_so & "' AND kode_barangjadi = '" & rcd_detail.Item(i).kode_barangjadi & "'"

            Connection.TRANS_ADD(query)

            '# update stok gudang
            query = ""
            query &= " UPDATE tbl_persediaan_gudang "
            query &= " SET stok = stok - " & rcd_detail.Item(i).jml_do & " "
            query &= " WHERE kode_barangjadi = '" & rcd_detail.Item(i).kode_barangjadi & "'"

            Connection.TRANS_ADD(query)
        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then

            '#PRINT
            Dim rpt_multi As New DevExpress.XtraReports.UI.XtraReport
            Dim rcd_tmp As System.ComponentModel.BindingList(Of rcd_delivery_order_banyak)

            '# ambil data dari rcd detail berdasarkan no do
            '  lalu masukan kedalam databinding
            For i = 0 To rcd_master.Rows.Count - 1
                rcd_tmp = New System.ComponentModel.BindingList(Of rcd_delivery_order_banyak)
                For x = 0 To rcd_detail.Count - 1
                    If rcd_master.Rows(i).Item("no_do") = rcd_detail.Item(x).no_do Then
                        rcd_tmp.Add(rcd_detail.Item(x))
                    End If
                Next

                '# buat page print
                'ambil informasi customer
                Db.FlushCache()
                Db.Selects("a.nama, b.kota, a.mall, a.alamat")
                Db.From("tbl_customer a")
                Db.Join("tbl_kota b", "b.kode_kota = a.kode_kota")
                Db.Where("a.kode_customer", rcd_master.Rows(i).Item("kode_customer"))

                Dim rcustomer As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
                rcustomer.Read()

                Dim rpt As New rpt_delivery_order_banyak
                rpt.BindingSource1.DataSource = rcd_tmp
                rpt.no_do.Text = "Nomor : " & rcd_master.Rows(i).Item("no_do")
                rpt.tgl_do.Text = tgl_do.DateTime.ToString("dd/MM/yyy")
                rpt.no_so.Text = rcd_master.Rows(i).Item("no_so")

                rpt.nama.Text = rcustomer.Item("nama").ToString
                rpt.alamat.Text = rcustomer.Item("alamat").ToString
                rpt.mall.Text = rcustomer.Item("mall").ToString
                rpt.kota.Text = rcustomer.Item("kota").ToString
                rpt.CreateDocument()

                rpt_multi.Pages.AddRange(rpt.Pages)

            Next

            Dim fc As New FormReportControl
            fc.Text = "Print Delivery Order N"
            fc.PrintControl1.PrintingSystem = rpt_multi.PrintingSystem
            fc.Height = 600
            fc.ShowDialog(Me)

            frm_delivery_order.loadData()
            Me.Close()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub

End Class