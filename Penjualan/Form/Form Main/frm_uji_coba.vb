Public Class frm_uji_coba 

    Private Sub frm_uji_coba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'DB.FlushCache()
        'DB.Selects("*")
        'DB.From("mahasiswa")

        '' init lookpup
        'lkp_jurusan.Properties.DataSource = Connection.ExecuteToDataTable(DB.GetQueryString)


    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Db.FlushCache()
        Db.Selects("PRO_PO_RETUR_TERIMA.PORT_NOMOR AS NoSurat, Convert(varchar, PRO_PO_RETUR_TERIMA.PORT_TANGGALSURAT, 103) AS Tanggal, PRO_SUPPLIER.SUP_NAMA AS Supplier, PRO_PO_RETUR_TERIMA_DETAIL.CMT_KODE AS WS, PRO_PO_RETUR_TERIMA_DETAIL.PORTDETAIL_JUMLAH AS Jumlah, PRO_CMT.AP_KODE AS Artikel")
        Db.From("PRO_PO_RETUR_TERIMA")
        Db.Join("PRO_PO_RETUR_TERIMA_DETAIL", "PRO_PO_RETUR_TERIMA.PORT_NOMOR = PRO_PO_RETUR_TERIMA_DETAIL.PORT_NOMOR")
        Db.Join("PRO_CMT", "PRO_PO_RETUR_TERIMA_DETAIL.CMT_KODE = PRO_CMT.CMT_KODE")
        Db.Join("PRO_SUPPLIER", "PRO_PO_RETUR_TERIMA.SUP_KODE = PRO_SUPPLIER.SUP_KODE")
        Db.Where("PRO_CMT.AP_KODE", "CMT001")


        My.Computer.Clipboard.SetText(Db.GetQueryString)
        MsgBox(Db.GetQueryString)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        ' Mulai Transasksi
        Connection.TRANS_START()

        ' Tambah Transaksi Query
        Connection.TRANS_ADD("insert into table1 (nim, nama) VALUES ('003', 'yanto 03')")
        Connection.TRANS_ADD("insert into table1 (nim, nama) VALUES ('004', 'yanto 04')")

        ' Eksekusi Transaksi
        If Connection.TRANS_SUCCESS Then
            MsgBox("success")
        Else
            MsgBox(Connection.TRANS_MESSAGE) ' transaksi gagal dan secara otomatis akan di rollback
        End If

    End Sub

    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub
End Class