Module Fungsi

    Public Function getNomorUrut(ByVal param As String) As String
        Dim rcd As SqlClient.SqlDataReader
        Dim nomor As Integer

        Db.FlushCache()

        Select Case param

            Case C_PENERIMAAN_BARANG            '=======================================================================
                Db.Selects("TOP 1 nomor_terima AS nomor")
                Db.From("tbl_penerimaanbarang")
                Db.OrderBy("nomor_terima", cls_database.sorting.Descending)

            Case C_RETUR_PENERIMAAN_BARANG      '=======================================================================
                Db.Selects("TOP 1 nomor_retur AS nomor")
                Db.From("tbl_retur_penerimaanbarang")
                Db.OrderBy("nomor_retur", cls_database.sorting.Descending)

            Case C_SALES_ORDER                  '=======================================================================
                Db.Selects("TOP 1 no_so AS nomor")
                Db.From("tbl_salesorder")
                Db.OrderBy("no_so", cls_database.sorting.Descending)

            Case C_DELIVERY_ORDER               '=======================================================================
                Db.Selects("TOP 1 no_do AS nomor")
                Db.From("tbl_deliveryorder")
                Db.OrderBy("no_do", cls_database.sorting.Descending)

            Case C_SURAT_JALAN                  '=======================================================================
                Db.Selects("TOP 1 no_surat AS nomor")
                Db.From("tbl_suratjalan")
                Db.OrderBy("no_surat", cls_database.sorting.Descending)

            Case C_KONSINYASI_PRIMER            '=======================================================================
                Db.Selects("TOP 1 no_penjualan AS nomor")
                Db.From("tbl_konsinyasiprimer")
                Db.OrderBy("no_penjualan", cls_database.sorting.Descending)

            Case C_FAKTUR_KONSINYASI            '=======================================================================
                Db.Selects("TOP 1 no_faktur AS nomor")
                Db.From("tbl_fakturkonsinyasi")
                Db.OrderBy("no_faktur", cls_database.sorting.Descending)

            Case C_RETUR_JUAL_KONSINYASI
                Db.Selects("TOP 1 no_retur AS nomor")
                Db.From("tbl_retur_konsinyasi")
                Db.OrderBy("no_retur", cls_database.sorting.Descending)

            Case C_RETUR_JUAL_PUTUS
                Db.Selects("TOP 1 no_retur AS nomor")
                Db.From("tbl_retur_jualputus")
                Db.OrderBy("no_retur", cls_database.sorting.Descending)

            Case C_RENCANA_DISTRIBUSI
                Db.Selects("TOP 1 no_rencana AS nomor")
                Db.From("tbl_rencana_distribusi")
                Db.OrderBy("no_rencana", cls_database.sorting.Descending)

            Case C_KELUAR_BARANG
                Db.Selects("TOP 1 no_keluar AS nomor")
                Db.From("tbl_keluar_barangjadi")
                Db.OrderBy("no_keluar", cls_database.sorting.Descending)

            Case C_SLIP_GAJI
                Db.Selects("TOP 1 no_slipgaji AS nomor")
                Db.From("tbl_penggajian")
                Db.OrderBy("no_slipgaji", cls_database.sorting.Descending)

            Case C_FAKTUR_GLOBAL
                Db.Selects("TOP 1 no_faktur AS nomor")
                Db.From("tbl_fakturglobal")
                Db.OrderBy("no_faktur", cls_database.sorting.Descending)

            Case C_RETUR_FORMALITAS
                Db.Selects("TOP 1 no_retur AS nomor")
                Db.From("tbl_retur_formalitas")
                Db.OrderBy("no_retur", cls_database.sorting.Descending)

            Case Else

        End Select


        rcd = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            rcd.Read()
            nomor = CInt(rcd.Item("nomor").ToString) + 1
            Return Format(CInt(nomor), "0000000")
        Else
            Return Format(CInt(1), "0000000")
        End If

    End Function

    Public Function getNomorJurnal(ByVal param As Integer) As String

        Dim rcd As SqlClient.SqlDataReader

        ' untuk pengkodean
        Dim kode_awal As String = vbNullString
        Dim tanggal As String = Now.ToString("yy") & Now.ToString("MM") & "/"
        Dim nomor As Integer

        Db.FlushCache()

        Select Case param

            Case C_PENERIMAAN_KAS
                kode_awal = "AR/"
                Db.Selects("TOP 1 id_jurnal AS nomor")
                Db.From("tbl_jurnal")
                Db.Where("WHERE id_jurnal LIKE '" & kode_awal & tanggal & "%'")
                Db.OrderBy("id_jurnal", cls_database.sorting.Descending)

        End Select

        rcd = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            rcd.Read()
            nomor = CInt(rcd.Item("nomor").ToString.Substring(8))
            nomor += 1
        Else
            nomor = 1
        End If

        Return kode_awal & tanggal & Format(nomor, "000")

    End Function

    Public Function getNomorUrut_Barang(ByVal kode_merk As String) As String
        Dim rcd As SqlClient.SqlDataReader
        Dim nomor As Integer

        Db.FlushCache()

        Db.Selects("TOP 1 kode_barangjadi AS nomor")
        Db.From("tbl_barangjadi")
        Db.Where("kode_merk", kode_merk)
        Db.OrderBy("kode_barangjadi", cls_database.sorting.Descending)

        rcd = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            rcd.Read()
            nomor = CInt(rcd.Item("nomor").ToString.Substring(2, 3)) + 1
            Return Format(CInt(nomor), "000")
        Else
            Return Format(CInt(1), "000")
        End If

    End Function

    Public Function getValueFromLookup(ByVal lookup As DevExpress.XtraEditors.LookUpEdit) As String
        Return lookup.Properties.GetKeyValueByDisplayText(lookup.Text)
    End Function

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", "satu", "dua", "tiga", "empat", "lima", _
        "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " trilyun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function

    Public Function getNamaCustomer(ByVal kode_customer As String) As String
        Db.FlushCache()
        Db.Selects("nama")
        Db.From("tbl_customer")
        Db.Where("kode_customer", kode_customer)

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("nama")
        Else
            Return vbNullString
        End If

    End Function


    ' retur array => {harga, diskon, kelompok, kelompok_desk, kode_barangjadi}
    Public Function getHargaFromHistori(ByVal tanggal As DateTime, ByVal kode_customer_parent As String, ByVal kode_barangjadi As String) As String()
        Dim str(5) As String

        If kode_barangjadi = "" Then
            str(0) = "0"
            str(1) = "0"
            str(2) = "0"
            str(3) = "Null"
            str(4) = "Null"
            Return str
        End If

        '# ambil harga yg ditetapkan
        Db.FlushCache()
        Db.Selects("TOP 1 a.harga, a.diskon, a.kelompok, a.kode_barangjadi")
        Db.From("tbl_histori_hargacustomer a")
        Db.Where("a.kode_customer_parent", kode_customer_parent)
        Db.Where("a.tanggal", tanggal.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
        'Db.Where("a.kode_barangjadi", kode_barangjadi)
        Db.Where(" AND a.kode_barangjadi LIKE '" & kode_barangjadi & "%'")
        Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

        Dim dt2 As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        If dt2.Rows.Count > 0 Then
            str(0) = dt2.Rows(0).Item("harga").ToString
            str(1) = dt2.Rows(0).Item("diskon").ToString
            str(2) = dt2.Rows(0).Item("kelompok").ToString
            Select Case dt2.Rows(0).Item("kelompok").ToString
                Case "1" : str(3) = "Normal"
                Case "2" : str(3) = "Obral"
                Case "3" : str(3) = "SP"
                Case "4" : str(3) = "Putus"
            End Select
            str(4) = dt2.Rows(0).Item("kode_barangjadi").ToString
        Else
            str(0) = "0"
            str(1) = "0"
            str(2) = "0"
            str(3) = "Null"
            str(4) = "Null"
        End If

        Return str
    End Function

    ' return array => {kode_barangjadi, nama, stok sekunder, stok primer}
    Public Function getInfoBarangjadiInCustomer(ByVal kode_customer_child As String, ByVal kode_barangjadi As String) As String()
        Dim str(4) As String

        '# get barang jadi
        Db.FlushCache()
        Db.Selects("a.kode_barangjadi, b.nama, a.stok_sekunder, a.stok_primer")
        Db.From("tbl_persediaan_customer a")
        Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
        Db.Where("a.kode_customer_child", kode_customer_child)
        Db.Where("a.kode_barangjadi", kode_barangjadi)

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If dt.Rows.Count > 0 Then
            str(0) = dt.Rows(0).Item("kode_barangjadi").ToString
            str(1) = dt.Rows(0).Item("nama").ToString
            str(2) = dt.Rows(0).Item("stok_sekunder").ToString
            str(3) = dt.Rows(0).Item("stok_primer").ToString
        Else
            str(0) = "0"
            str(1) = "0"
            str(2) = "0"
            str(3) = "0"
        End If

        Return str
    End Function

    ' return arrar => {sebelum_disc_acara, disc_acara, disc_acara_kita, disc_acara_toko, margin_toko, margin_konsumen}
    Public Function getMarginCustomer(ByVal tanggal As DateTime, ByVal kode_customer_child As String) As String()
        Dim str(6) As String

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_margin")
        Db.Where("tanggal", tanggal.ToString("yyyy-MM-dd"))
        Db.Where("kode_customer_child", kode_customer_child)

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If dt.Rows.Count > 0 Then
            str(0) = dt.Rows(0).Item("sebelum_disc_acara").ToString
            str(1) = dt.Rows(0).Item("disc_acara").ToString
            str(2) = dt.Rows(0).Item("disc_acara_kita").ToString
            str(3) = dt.Rows(0).Item("disc_acara_toko").ToString
            str(4) = dt.Rows(0).Item("margin_toko").ToString
            str(5) = dt.Rows(0).Item("margin_konsumen").ToString
        Else
            str(0) = "1"
            str(1) = "0"
            str(2) = "0"
            str(3) = "0"
            str(4) = "0"
            str(5) = "0"
        End If

        Return str
    End Function


End Module
