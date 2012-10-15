﻿Public Class frm_surat_jalan 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_surat_jalan)

    Dim kode_customer As String

    Sub initComponent()
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
        Db.Selects("a.kode_customer, e.nama AS nama_customer, e.alamat, f.kota, e.mall")
        Db.From("tbl_deliveryorder a")
        Db.Join("tbl_deliveryorder_detail b", "b.no_do = a.no_do")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
        Db.Join("tbl_hargajual d", "d.kode_hargajual = b.kode_hargajual")
        Db.Join("tbl_customer e", "e.kode_customer = a.kode_customer")
        Db.Join("tbl_kota f", "f.kode_kota = e.kode_kota")
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
                    kode_customer = .Item("kode_customer").ToString

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
        'generateColumnGrid(GridView1)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim i As Integer
        Dim query As String = ""

        If rcd_list.Count <= 0 Then
            MsgBox("Tidak terdapat data yang akan disimpan!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Connection.TRANS_START()

        '# simpan ke surat jalan
        '# insert to table tbl_suratjalan
        Db.FlushCache()
        Db.Insert("tbl_suratjalan")
        Db.SetField("no_surat", no_surat.Text)
        Db.SetField("tgl_surat", tgl_surat.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
        Db.SetField("no_do", no_do.Text)
        Db.SetField("no_so", no_so.Text)
        Db.SetField("kode_customer", kode_customer)
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
            Db.SetField("ketarangan", rcd_list.Item(i).keterangan)

            Connection.TRANS_ADD(Db.GetQueryString)

            '# insert ato update ke persediaan customer
            '  jika sudah ada update, jika belum ada insert
            '------------------------------------------
            query = ""
            query &= " IF EXISTS (SELECT * FROM tbl_persediaan_customer WHERE kode_customer = '" & kode_customer & "' AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "') "
            query &= "    UPDATE tbl_persediaan_customer "
            query &= "    SET stok = stok + " & rcd_list.Item(i).qty & " "
            query &= "    WHERE kode_customer = '" & kode_customer & "' AND kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "' "
            query &= " ELSE "
            query &= "    INSERT INTO tbl_persediaan_customer ([kode_customer],[kode_barangjadi],[kode_jenis_harga],[kode_hargajual],[diskon],[stok]) "
            query &= "    VALUES ('" & kode_customer & "', '" & rcd_list.Item(i).kode_barangjadi & "', '1', '" & rcd_list.Item(i).kode_hargajual & "', '0', '" & rcd_list.Item(i).qty & "')"
            query &= "; "

            Connection.TRANS_ADD(query)

        Next

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub
End Class