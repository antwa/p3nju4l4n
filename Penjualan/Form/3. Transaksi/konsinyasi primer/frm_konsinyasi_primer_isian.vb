Public Class frm_konsinyasi_primer_isian 

    Public kode_barangjadi As String
    Public nama As String
    Public kode_customer As String

    Dim THarga As Integer
    Dim TDiskon As Integer

    Public Sub loadData()
        '# ambil harga yg ditetapkan
        Db.FlushCache()
        Db.Selects("TOP 1 a.kode_hargajual, b.harga, a.diskon")
        Db.From("tbl_histori_hargacustomer a")
        Db.Join("tbl_hargajual b", "b.kode_hargajual = a.kode_hargajual")
        Db.Where("a.kode_barangjadi", kode_barangjadi)
        Db.Where("a.kode_customer", kode_customer)
        Db.Where("a.tanggal", tgl_transaksi.DateTime.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
        Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
        
        If rc.HasRows Then
            rc.Read()
            harga.EditValue = rc.Item("harga").ToString
            diskon.Text = rc.Item("diskon").ToString

            THarga = rc.Item("harga").ToString
            TDiskon = rc.Item("diskon").ToString
        Else
            harga.EditValue = "0"
            diskon.Text = "0"

            THarga = 0
            TDiskon = 0
        End If
    End Sub

    Sub initComponent()
        tgl_transaksi.DateTime = Now
        lbl_kode_barangjadi.Text = kode_barangjadi
        lbl_nama.Text = nama

        qty.EditValue = "0"

        Call Me.loadData()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_konsinyasi_primer_isian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub tgl_transaksi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tgl_transaksi.EditValueChanged
        Call Me.loadData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        With frm_konsinyasi_primer
            .rcd_list.Add(New rcd_konsinyasi_primer(tgl_transaksi.DateTime, _
                                                    kode_barangjadi, _
                                                    nama, _
                                                    qty.EditValue, _
                                                    harga.EditValue, _
                                                    diskon.Text, _
                                                    THarga, _
                                                     TDiskon))
            Dim lastrow As Integer = .rcd_list.Count - 1

            '.rcd_list.Item(lastrow).sebelum_disc_acara = IIf(.sebelum_disc_acara.EditValue = "1", True, False)

            '.rcd_list.Item(lastrow).disc_acara = .disc_acara.Text
            '.rcd_list.Item(lastrow).disc_acara_kita = .disc_acara_kita.Text
            '.rcd_list.Item(lastrow).disc_acara_toko = .disc_acara_toko.Text

            '.rcd_list.Item(lastrow).margin_toko = .margin_toko.Text
            '.rcd_list.Item(lastrow).margin_konsumen = .margin_konsumen.Text

            .rcd_list.Item(lastrow).Sumary()
            .GridView1.RefreshData()
        End With

        Me.Close()
    End Sub
End Class