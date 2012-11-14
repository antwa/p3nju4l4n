Public Class frm_transaksi_popup_artkel

    Public parameter1 As String
    Public kode_customer As String
    
    Sub initGrid()

        If parameter1 = C_KONSINYASI_SEKUNDER Or parameter1 = C_KONSINYASI_PRIMER Or _
           parameter1 = C_RETUR_JUAL_KONSINYASI Then

            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, b.nama, c.jenis, a.stok")
            Db.From("tbl_persediaan_customer a")
            Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
            Db.Join("tbl_jenis_hargabarang c", "c.kode_jenis_harga = a.kode_jenis_harga")
            Db.Where("a.kode_customer", kode_customer)

            If txt_search.Text <> vbNullString Then
                Db.Where("WHERE a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
            End If

            GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

            With GridView1
                .Columns("kode_barangjadi").Caption = "Kode Artikel"
                .Columns("nama").Caption = "Nama"
                .Columns("jenis").Caption = "Jenis"
                .Columns("stok").Caption = "Stok"
            End With

        Else
            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, a.nama, c.kategori, b.stok")
            Db.From("tbl_barangjadi a")
            Db.Join("tbl_persediaan_gudang b", "a.kode_barangjadi = b.kode_barangjadi")
            Db.Join("tbl_kategori_barang c", "a.kode_kategori = c.kode_kategori")

            If txt_search.Text <> vbNullString Then
                Db.Where("WHERE a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
            End If

            GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

            With GridView1
                .Columns("kode_barangjadi").Caption = "Kode Artikel"
                .Columns("nama").Caption = "Nama"
                .Columns("kategori").Caption = "Kategori"
                .Columns("stok").Caption = "Stok"
            End With
        End If

    End Sub

    Sub addArtikel()
        Dim i As Integer = 0
        Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim rcd As SqlClient.SqlDataReader

        Select Case parameter1

            Case C_PENERIMAAN_BARANG                    '========================================================# 
                With frm_penerimaanbarang
                    '# cek list, takut ada yg sama (^-^)
                    For i = 0 To .rcd_list.Count - 1
                        If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                            MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                            Exit Sub
                        End If
                    Next

                    '# insert to list
                    .rcd_list.Add(New rcd_penerimaanbarang(row("kode_barangjadi"), row("nama"), 0))
                    .GridView1.RefreshData()
                End With

            Case C_SALES_ORDER                          '========================================================# 
                With frm_sales_order
                    '# cek list, takut ada yg sama (^-^)
                    For i = 0 To .rcd_list.Count - 1
                        If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                            MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                            Exit Sub
                        End If
                    Next

                    '# ambil harga
                    ' load harga
                    Db.FlushCache()
                    Db.Selects("kode_hargajual, kode_template_harga, harga")
                    Db.From("tbl_hargajual")
                    Db.Where("kode_barangjadi", row("kode_barangjadi"))
                    Db.Where("kode_template_harga", .kode_customer.GetColumnValue("kode_template_harga"))

                    rcd = Connection.ExecuteToDataReader(Db.GetQueryString)

                    If rcd.HasRows Then
                        rcd.Read()
                        .rcd_list.Add(New rcd_sales_order(row("kode_barangjadi"), row("nama"), rcd.Item("kode_hargajual").ToString, rcd.Item("harga").ToString, row("stok")))
                    Else
                        .rcd_list.Add(New rcd_sales_order(row("kode_barangjadi"), row("nama"), 0, 0, row("stok")))
                    End If

                    .GridView1.RefreshData()

                End With

            Case C_KONSINYASI_SEKUNDER                  '========================================================# 
                With frm_konsinyasi_sekunder
                    '# cek list, takut ada yg sama (^-^)
                    For i = 0 To .rcd_list.Count - 1
                        If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                            MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                            Exit Sub
                        End If
                    Next

                    '# insert to list
                    .rcd_list.Add(New rcd_konsinyasi_sekunder(1, row("kode_barangjadi"), _
                                                              row("nama"), _
                                                              row("stok"), _
                                                              0, _
                                                              0, _
                                                              0))
                    '# ambil harga yg ditetapkan
                    Db.FlushCache()
                    Db.Selects("TOP 1 a.harga, a.diskon")
                    Db.From("tbl_histori_hargacustomer a")
                    Db.Where("a.kode_barangjadi", row("kode_barangjadi"))
                    Db.Where("a.kode_customer", kode_customer)
                    Db.Where("a.tanggal", .tgl_transaksi.DateTime.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
                    Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

                    Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
                    Dim lastrow As Integer = .rcd_list.Count - 1

                    If rc.HasRows Then
                        rc.Read()
                        .rcd_list.Item(lastrow).harga = rc.Item("harga").ToString
                        .rcd_list.Item(lastrow).diskon = rc.Item("diskon").ToString

                        '.rcd_list.Item(lastrow).kode_hargajual2 = rc.Item("kode_hargajual").ToString
                        .rcd_list.Item(lastrow).harga2 = rc.Item("harga").ToString
                        .rcd_list.Item(lastrow).diskon2 = rc.Item("diskon").ToString
                    Else
                        .rcd_list.Item(lastrow).harga = 0
                        .rcd_list.Item(lastrow).diskon = 0

                        '.rcd_list.Item(lastrow).kode_hargajual2 = rc.Item("kode_hargajual").ToString
                        .rcd_list.Item(lastrow).harga2 = 0
                        .rcd_list.Item(lastrow).diskon2 = 0
                    End If

                    .GridView1.RefreshData()
                End With

            Case C_KONSINYASI_PRIMER
                With frm_konsinyasi_primer
                    .rcd_list.Add(New rcd_konsinyasi_primer(.tgl_terbit.DateTime, _
                                                    row("kode_barangjadi"), _
                                                    row("nama"), _
                                                    0, _
                                                    0, _
                                                    0, _
                                                    0, _
                                                    0))

                    '# ambil harga yg ditetapkan
                    Db.FlushCache()
                    Db.Selects("TOP 1 a.harga, a.diskon")
                    Db.From("tbl_histori_hargacustomer a")
                    Db.Where("a.kode_barangjadi", row("kode_barangjadi"))
                    Db.Where("a.kode_customer", kode_customer)
                    Db.Where("a.tanggal", .tgl_terbit.DateTime.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
                    Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

                    Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
                    Dim lastrow As Integer = .rcd_list.Count - 1

                    If rc.HasRows Then
                        rc.Read()
                        .rcd_list.Item(lastrow).harga = rc.Item("harga").ToString
                        .rcd_list.Item(lastrow).diskon = rc.Item("diskon").ToString

                        '.rcd_list.Item(lastrow).kode_hargajual2 = rc.Item("kode_hargajual").ToString
                        .rcd_list.Item(lastrow).harga2 = rc.Item("harga").ToString
                        .rcd_list.Item(lastrow).diskon2 = rc.Item("diskon").ToString
                    Else
                        .rcd_list.Item(lastrow).harga = 0
                        .rcd_list.Item(lastrow).diskon = 0

                        '.rcd_list.Item(lastrow).kode_hargajual2 = rc.Item("kode_hargajual").ToString
                        .rcd_list.Item(lastrow).harga2 = 0
                        .rcd_list.Item(lastrow).diskon2 = 0
                    End If

                    .rcd_list.Item(lastrow).sebelum_disc_acara = IIf(.sebelum_disc_acara.EditValue = "1", True, False)

                    .rcd_list.Item(lastrow).disc_acara = .disc_acara.Text
                    .rcd_list.Item(lastrow).disc_acara_kita = .disc_acara_kita.Text
                    .rcd_list.Item(lastrow).disc_acara_toko = .disc_acara_toko.Text

                    .rcd_list.Item(lastrow).margin_toko = .margin_toko.Text
                    .rcd_list.Item(lastrow).margin_konsumen = .margin_konsumen.Text

                    .rcd_list.Item(lastrow).Sumary()
                    .GridView1.RefreshData()
                End With

                'frm_konsinyasi_primer_isian.Dispose()
                'frm_konsinyasi_primer_isian.kode_barangjadi = row("kode_barangjadi")
                'frm_konsinyasi_primer_isian.nama = row("nama")
                'frm_konsinyasi_primer_isian.kode_customer = kode_customer
                'frm_konsinyasi_primer_isian.ShowDialog(Me)

            Case C_RETUR_JUAL_KONSINYASI
                With frm_retur_jual_konsinyasi
                    '# cek list, takut ada yg sama (^-^)
                    For i = 0 To .rcd_list.Count - 1
                        If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                            MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                            Exit Sub
                        End If
                    Next

                    '# insert to list
                    .rcd_list.Add(New rcd_retur_jual_konsinyasi(1, row("kode_barangjadi"), row("nama"), row("stok"), 0, 0, 0, ""))
                    '# ambil harga yg ditetapkan
                    Db.FlushCache()
                    Db.Selects("TOP 1 a.harga, a.diskon")
                    Db.From("tbl_histori_hargacustomer a")
                    Db.Where("a.kode_barangjadi", row("kode_barangjadi"))
                    Db.Where("a.kode_customer", kode_customer)
                    Db.Where("a.tanggal", .tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
                    Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

                    Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
                    Dim lastrow As Integer = .rcd_list.Count - 1

                    If rc.HasRows Then
                        rc.Read()
                        .rcd_list.Item(lastrow).harga = rc.Item("harga").ToString
                    Else
                        .rcd_list.Item(lastrow).harga = 0
                    End If

                    .GridView1.RefreshData()
                End With

            Case C_RETUR_JUAL_PUTUS
                With frm_retur_jual_putus
                    '# cek list, takut ada yg sama (^-^)
                    'For i = 0 To .rcd_list.Count - 1
                    '    If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                    '        MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                    '        Exit Sub
                    '    End If
                    'Next

                    frm_retur_jual_putus_popup_faktur.Dispose()
                    frm_retur_jual_putus_popup_faktur.kode_barangjadi = row("kode_barangjadi")
                    frm_retur_jual_putus_popup_faktur.kode_customer = kode_customer
                    frm_retur_jual_putus_popup_faktur.ShowDialog(Me)

                    If frm_retur_jual_putus_popup_faktur.Kembali = True Then Exit Sub

                End With

        End Select

        Me.Close()
    End Sub

    Private Sub frm_transaksi_popup_artkel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initGrid()
    End Sub


    Private Sub Cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_cari.Click
        Call initGrid()
    End Sub

    Private Sub txt_search_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.EditValueChanged

    End Sub

    Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_search.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Call initGrid()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        Call addArtikel()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Call addArtikel()
    End Sub
End Class