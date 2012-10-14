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

End Module
