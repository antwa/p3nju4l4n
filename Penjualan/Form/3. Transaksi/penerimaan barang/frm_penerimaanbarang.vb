Public Class frm_penerimaanbarang

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_penerimaanbarang)

    Sub initComponent()
        ' inisialisasi componen

        nomor_terima.EditValue = getNomorUrut(C_PENERIMAAN_BARANG)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_penerimaanbarang)

        GridControl1.DataSource = rcd_list
        GridView1.Columns.Item(0).Caption = "Kode Artikel"
        GridView1.Columns.Item(1).Caption = "Nama Artikel"
        GridView1.Columns.Item(2).Caption = "Qty (Pcs)"
        GridView1.Columns.Item(3).Caption = "Keterangan"

        GridView1.Columns.Item(0).Width = 100
        GridView1.Columns.Item(1).Width = 200
        GridView1.Columns.Item(3).Width = 300

        GridView1.Columns.Item(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.Item(2).DisplayFormat.FormatString = "#,##0"

        tanggal.DateTime = Now
        Load_SupplierBarang(kode_supplier_barang)
        no_suratjalan.EditValue = vbNullString

    End Sub

    Private Sub frm_penerimaanbarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
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

    Private Sub cmd_cari_artikel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cari_artikel.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_PENERIMAAN_BARANG
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim vkode_supplier As String = kode_supplier_barang.Properties.GetKeyValueByDisplayText(kode_supplier_barang.Text)
        Dim i As Integer

        '# Cek Grid
        If GridView1.RowCount = 0 Then
            MsgBox("Masukan Artikel Terlebih Dulu", MsgBoxStyle.Critical, "Artikel Belum Diisi")
            Exit Sub
        End If

        '# cek nomor
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_penerimaanbarang")
        Db.Where("nomor_terima", nomor_terima.EditValue)
        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        If rc.HasRows Then
            MsgBox("Sudah terdapat Nomor pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        '# validation
        Validation.clearRules()
        Validation.addRules(no_suratjalan.Text, "No. Surat Jalan", "required")

        If Validation.isValid Then
            '# START TRANSAKSI
            Connection.TRANS_START()

            '# insert to table tbl_penerimaanbarang
            Db.FlushCache()
            Db.Insert("tbl_penerimaanbarang")
            Db.SetField("nomor_terima", nomor_terima.EditValue)
            Db.SetField("tanggal", tanggal.DateTime.ToString("yyyy-MM-dd HH:mm:ss"))
            Db.SetField("kode_supplier_barang", vkode_supplier)
            Db.SetField("no_suratjalan", no_suratjalan.EditValue)
            Db.SetField("username", Auth.Username)

            Connection.TRANS_ADD(Db.GetQueryString)

            For i = 0 To rcd_list.Count - 1
                '# insert to table tbl_penerimaanbarang_detail
                Db.FlushCache()
                Db.Insert("tbl_penerimaanbarang_detail")
                Db.SetField("nomor_terima", nomor_terima.EditValue)
                Db.SetField("kode_barangjadi", rcd_list.Item(i).kode_barangjadi)
                Db.SetField("qty", rcd_list.Item(i).qty)
                Db.SetField("ketarangan", rcd_list.Item(i).keterangan)

                Connection.TRANS_ADD(Db.GetQueryString)

                '# update persediaan gudang
                Db.Query(" UPDATE tbl_persediaan_gudang set stok = stok + " & rcd_list.Item(i).qty & _
                         " WHERE kode_barangjadi = '" & rcd_list.Item(i).kode_barangjadi & "'")
                Connection.TRANS_ADD(Db.GetQueryString)
            Next

            '# COMMITE TRANSAKSI
            If Connection.TRANS_SUCCESS Then
                'MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")

                Dim rpt As New rpt_penerimaanbarang
                rpt.BindingSource1.DataSource = rcd_list
                rpt.nomor_terima.Text = "Nomor : " & nomor_terima.Text
                rpt.tanggal.Text = tanggal.DateTime.ToString("dd/MM/yyy")
                rpt.kode_supplier_barang.Text = kode_supplier_barang.Text
                rpt.no_suratjalan.Text = no_suratjalan.Text
                rpt.CreateDocument()

                Dim fc As New FormReportControl
                fc.Text = "Print Bukti Penerimaan Barang"
                fc.PrintControl1.PrintingSystem = rpt.PrintingSystem
                fc.Height = 600
                fc.ShowDialog(Me)

                Call initComponent()
            Else
                MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
            End If

        Else
            Validation.showMessage()
        End If

    End Sub
End Class