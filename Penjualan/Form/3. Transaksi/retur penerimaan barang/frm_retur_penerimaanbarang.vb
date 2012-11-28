Public Class frm_retur_penerimaanbarang 

    Public rcd_list As New System.ComponentModel.BindingList(Of rcd_retur_penerimaanbarang)

    Sub initComponent()
        ' inisialisasi componen

        nomor_retur.EditValue = getNomorUrut(C_RETUR_PENERIMAAN_BARANG)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_retur_penerimaanbarang)

        GridControl1.DataSource = rcd_list
        GridView1.Columns.Item(0).Caption = "Kode Artikel"
        GridView1.Columns.Item(1).Caption = "Nama Artikel"
        GridView1.Columns.Item(2).Caption = "Jml Terima"
        GridView1.Columns.Item(3).Caption = "Harga Beli (Rp.)"
        GridView1.Columns.Item(4).Caption = "Jml Retur"
        GridView1.Columns.Item(5).Caption = "Value Retur (Rp.)"
        GridView1.Columns.Item(6).Caption = "Keterangan"

        GridView1.Columns.Item(0).Width = 100
        GridView1.Columns.Item(1).Width = 200
        GridView1.Columns.Item(3).Width = 150
        GridView1.Columns.Item(5).Width = 150
        GridView1.Columns.Item(6).Width = 300

        GridView1.Columns.Item(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.Item(3).DisplayFormat.FormatString = "#,##0"

        GridView1.Columns.Item(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.Item(5).DisplayFormat.FormatString = "#,##0"

        tanggal.DateTime = Now

        nomor_terima.EditValue = vbNullString

    End Sub

    Private Sub frm_retur_penerimaanbarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub nomor_terima_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nomor_terima.EditValueChanged

    End Sub

    Private Sub nomor_terima_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nomor_terima.GotFocus
        SendKeys.Send("{HOME}+{END}")
    End Sub

    Private Sub nomor_terima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nomor_terima.KeyPress
        If Asc(e.KeyChar) = 13 Then

            rcd_list.Clear()

            Db.FlushCache()
            Db.Selects("a.nomor_terima, a.tanggal, b.kode_barangjadi, c.nama, b.qty, c.harga_pokok, a.kode_supplier_barang, d.nama as nama_supplier")
            Db.From("tbl_penerimaanbarang a")
            Db.Join("tbl_penerimaanbarang_detail b", "b.nomor_terima = a.nomor_terima")
            Db.Join("tbl_barangjadi c", "c.kode_barangjadi = b.kode_barangjadi")
            Db.Join("tbl_supplier_barang d", "d.kode_supplier_barang = a.kode_supplier_barang")
            Db.Where("WHERE a.nomor_terima LIKE '%" & nomor_terima.Text & "'")

            Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

            If rcd.HasRows Then
                With rcd
                    While .Read()
                        rcd_list.Add(New rcd_retur_penerimaanbarang(.Item("kode_barangjadi").ToString, _
                                                                    .Item("nama"), _
                                                                    .Item("qty").ToString, _
                                                                    .Item("harga_pokok").ToString))

                        Dim tgl As Date = .Item("tanggal").ToString
                        lbl_tanggal_terima.Text = tgl.ToString("dd/MM/yyy")
                        lbl_kode_supplier.Text = .Item("kode_supplier_barang").ToString
                        lbl_nama_supplier.Text = .Item("nama_supplier").ToString
                    End While
                End With

                nomor_terima.Text = Format(CInt(nomor_terima.Text), "0000000")
            Else
                MsgBox("Tidak Terdapat Nomor Penerimaan '" & nomor_terima.Text & "'", MsgBoxStyle.Exclamation)
            End If

        End If
    End Sub

    Private Sub cmd_hapus_baris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_hapus_baris.Click
        Dim row As Integer = GridView1.FocusedRowHandle
        Try
            rcd_list.RemoveAt(row)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount = 0 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# cek nomor
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_retur_penerimaanbarang")
        Db.Where("nomor_retur", nomor_retur.EditValue)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# validation
        Validation.clearRules()
        Validation.addRules(nomor_terima.Text, "No. Surat Jalan", "required")

        If Validation.isValid Then
            '# START TRANSAKSI
            Connection.TRANS_START()

            '# insert to table tbl_retur_penerimaanbarang
            Db.FlushCache()
            Db.Insert("tbl_retur_penerimaanbarang")
            Db.SetField("nomor_retur", nomor_retur.Text)
            Db.SetField("tanggal", tanggal.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Db.SetField("kode_supplier_barang", lbl_kode_supplier.Text)
            Db.SetField("nomor_terima", nomor_terima.Text)
            Db.SetField("username", Auth.Username)

            Connection.TRANS_ADD(Db.GetQueryString)

            For i = 0 To rcd_list.Count - 1
                '# insert to table tbl_retur_penerimaanbarang_detail
                Db.FlushCache()
                Db.Insert("tbl_retur_penerimaanbarang_detail")
                Db.SetField("nomor_retur", nomor_retur.Text)
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("qty_retur", rcd_list.Item(i).qty)
                Db.SetField("value_retur", rcd_list.Item(i).value_retur)
                Db.SetField("ketarangan", rcd_list.Item(i).keterangan)

                Connection.TRANS_ADD(Db.GetQueryString)

                '# update persediaan gudang
                Db.Query(" UPDATE tbl_persediaan_gudang set stok = stok - " & rcd_list.Item(i).qty & _
                         " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'")
                Connection.TRANS_ADD(Db.GetQueryString)

                '# insert ke kartu stok
                Db.FlushCache()
                Db.Insert("tbl_kartustok_gudang")
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("tanggal", tanggal.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
                Db.SetField("referensi", "No. Retur : " & nomor_retur.Text)
                Db.SetField("deskripsi", "Retur Penerimaan barang : " & nomor_terima.Text)
                Db.SetField("masuk", "0")
                Db.SetField("keluar", rcd_list.Item(i).qty)
                Connection.TRANS_ADD(Db.GetQueryString)

            Next

            '# COMMITE TRANSAKSI
            If Connection.TRANS_SUCCESS Then
                'MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                Dim rpt As New rpt_retur_penerimaanbarang
                rpt.BindingSource1.DataSource = rcd_list
                rpt.nomor_retur.Text = "Nomor : " & nomor_retur.Text
                rpt.tanggal.Text = tanggal.DateTime.ToString("dd/MM/yyy")
                rpt.lbl_nama_supplier.Text = lbl_nama_supplier.Text
                rpt.nomor_terima.Text = nomor_terima.Text
                rpt.lbl_tanggal_terima.Text = lbl_tanggal_terima.Text
                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Bukti Retur Barang"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.Height = 600
                fc.ShowDialog(Me)

                Call initComponent()
            Else
                MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation) ' transaksi gagal dan secara otomatis akan di rollback
            End If

        Else
            Validation.showMessage()
        End If

    End Sub
End Class