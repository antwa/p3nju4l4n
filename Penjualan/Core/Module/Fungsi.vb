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

    Public Function getNamacustomer(ByVal kode_customer As String) As String
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

End Module
