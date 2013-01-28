Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_keluar_barang

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_keluar_barang)

    Sub initComponent()
        ' inisialisasi componen
        no_keluar.Text = vbNullString
        keterangan.Text = vbNullString
        tgl_terbit.DateTime = Now

        rcd_list = New System.ComponentModel.BindingList(Of rcd_keluar_barang)

        GridControl1.DataSource = rcd_list

        GridView1.Columns("no").Caption = "No"
        GridView1.Columns("kode_barangjadi").Caption = "Kode Artikel"
        GridView1.Columns("nama_barang").Caption = "Nama Artikel"
        GridView1.Columns("qty").Caption = "Qty (pcs)"
        GridView1.Columns("harga_pokok").Caption = "Harga Pokok (Rp.)"
        GridView1.Columns("total").Caption = "Total (Rp.)"

        GridView1.Columns("no").Width = 35
        GridView1.Columns("kode_barangjadi").Width = 110
        GridView1.Columns("nama_barang").Width = 155
        GridView1.Columns("qty").Width = 65
        GridView1.Columns("harga_pokok").Width = 100
        GridView1.Columns("total").Width = 100

        ' enable/disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("qty").OptionsColumn.AllowEdit = True

        ' format cell
        FormatColumnNumeric(GridView1.Columns("harga_pokok"))
        FormatColumnNumeric(GridView1.Columns("total"))

    End Sub

    Sub loadData()
        Dim nomor As Integer = 1

        rcd_list.Clear()

        '# cek nomor memo
        Db.FlushCache()
        Db.Selects("no_keluar, status")
        Db.From("tbl_keluar_barangjadi")
        Db.Where("WHERE no_keluar LIKE '%" & no_keluar.Text & "'")

        Dim rs As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rs.HasRows Then
            rs.Read()
            If rs.Item("status").ToString = "1" Then
                MsgBox("Nomor memo '" & rs.Item("no_keluar").ToString & "' sudah dibuat surat jalan!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Else
            MsgBox("Tidak terdapat data dengan nomor memo '" & no_keluar.Text & "'", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '# Get Data
        Db.FlushCache()
        Db.Selects("a.no_keluar, a.tgl_terbit, a.keterangan, b.kode_barangjadi, c.nama, b.qty, b.harga_pokok")
        Db.From("tbl_keluar_barangjadi a")
        Db.Join("tbl_keluar_barangjadi_detail b", "b.no_keluar = a.no_keluar")
        Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
        Db.Where("WHERE a.no_keluar LIKE '%" & no_keluar.Text & "'")

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        If dt.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1

                rcd_list.Add(New rcd_keluar_barang(i + 1, dt.Rows(i).Item("kode_barangjadi"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("qty"), dt.Rows(i).Item("harga_pokok")))

                keterangan.Text = dt.Rows(i).Item("keterangan").ToString
                tgl_terbit.DateTime = dt.Rows(i).Item("tgl_terbit")
            Next
        End If

        no_keluar.Text = Format(CInt(no_keluar.Text), "0000000")
       
    End Sub

    Sub reIndex()
        Try
            Dim i As Integer
            For i = 0 To rcd_list.Count - 2
                rcd_list.Item(i).no = i + 1
            Next

            GridView1.RefreshData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_keluar_barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim i As Integer

        If keterangan.Text = vbNullString Then
            MsgBox("Field Keterangan harus diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        '# START TRANSAKSI
        Connection.TRANS_START()

        '# insert to table tbl_keluar_barangjadi
        Db.FlushCache()
        Db.Update("tbl_keluar_barangjadi")
        Db.SetField("status", "1")
        Db.SetField("keterangan", keterangan.Text)
        Db.Where("no_keluar", no_keluar.Text)

        Connection.TRANS_ADD(Db.GetQueryString)

        For i = 0 To rcd_list.Count - 1
            If rcd_list.Item(i).qty = 0 Then
                Db.FlushCache()
                Db.Delete("tbl_keluar_barangjadi_detail")
                Db.Where("no_keluar", no_keluar.Text)
                Db.Where("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Connection.TRANS_ADD(Db.GetQueryString)
            Else
                '# update persediaan gudang
                Db.Query(" UPDATE tbl_persediaan_gudang set stok = stok - " & rcd_list.Item(i).qty & _
                         " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'")
                Connection.TRANS_ADD(Db.GetQueryString)

                '# insert ke kartu stok
                Db.FlushCache()
                Db.Insert("tbl_kartustok_gudang")
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("tanggal", tgl_terbit.DateTime)
                Db.SetField("referensi", "No. Memo : " & no_keluar.EditValue)
                Db.SetField("deskripsi", keterangan.Text)
                Db.SetField("masuk", "0")
                Db.SetField("keluar", rcd_list.Item(i).qty)
                Connection.TRANS_ADD(Db.GetQueryString)
            End If
        Next

        '# COMMITE TRANSAKSI
        If Connection.TRANS_SUCCESS Then

            If chk_cetak_harga.Checked Then
                Dim rpt As New rpt_keluar_barang_harga
                rpt.BindingSource1.DataSource = rcd_list
                rpt.lbl_nomor.Text = "Nomor : " & no_keluar.Text
                rpt.lbl_tanggal.Text = tgl_terbit.Text
                rpt.lbl_keterangan.Text = keterangan.Text
                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Surat Jalan Pengeluaran Barang"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.Height = 600
                fc.ShowDialog(Me)
            Else
                Dim rpt As New rpt_keluar_barang_non_harga
                rpt.BindingSource1.DataSource = rcd_list
                rpt.lbl_nomor.Text = "Nomor : " & no_keluar.Text
                rpt.lbl_tanggal.Text = tgl_terbit.Text
                rpt.lbl_keterangan.Text = keterangan.Text
                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Surat Jalan Pengeluaran Barang"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.Height = 600
                fc.ShowDialog(Me)
            End If

            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub

    Private Sub no_keluar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles no_keluar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loadData()
        Else
            rcd_list.Clear()
            tgl_terbit.DateTime = Now
            keterangan.Text = vbNullString
        End If
    End Sub

    Private Sub no_keluar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_keluar.EditValueChanged

    End Sub
End Class