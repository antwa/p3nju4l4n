﻿Public Class frm_transaksi_popup_artkel

    Public parameter1 As String
    Public kode_customer_child As String
    Public kode_customer_parent As String

    Public txt_artikel As DevExpress.XtraEditors.TextEdit
    Public txt_stok As DevExpress.XtraEditors.TextEdit
    Public lbl_nama_artikel As DevExpress.XtraEditors.LabelControl
    
    Sub initGrid()

        If parameter1 = C_KONSINYASI_SEKUNDER Or parameter1 = C_KONSINYASI_PRIMER Then
            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, b.nama")
            Db.From("tbl_persediaan_customer a")
            Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
            Db.Where(" WHERE a.kode_customer_child LIKE '" & kode_customer_parent & "%'")
            Db.GroupBy("a.kode_barangjadi, b.nama")

            If txt_search.Text <> vbNullString Then
                Db.Where(" AND a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
            End If

            GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

            With GridView1
                .Columns("kode_barangjadi").Caption = "Kode Artikel"
                .Columns("nama").Caption = "Nama"
            End With

        ElseIf parameter1 = C_RETUR_JUAL_KONSINYASI Then

            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, b.nama, a.stok_sekunder as stok")
            Db.From("tbl_persediaan_customer a")
            Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
            Db.Where("a.kode_customer_child", kode_customer_child)
            Db.OrderBy("a.kode_barangjadi", cls_database.sorting.Ascending)

            If txt_search.Text <> vbNullString Then
                Db.Where(" AND a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
            End If

            'MsgBox(Db.GetQueryString)

            GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

            With GridView1
                .Columns("kode_barangjadi").Caption = "Kode Artikel"
                .Columns("nama").Caption = "Nama"
                .Columns("stok").Caption = "Stok"
            End With


        ElseIf parameter1 = C_KONSINYASI_PRIMER Then

            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, b.nama, c.jenis, a.stok_primer as stok")
            Db.From("tbl_persediaan_customer a")
            Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
            Db.Join("tbl_jenis_hargabarang c", "c.kode_jenis_harga = a.kode_jenis_harga")
            Db.Where("a.kode_customer_child", kode_customer_child)
            Db.OrderBy("a.kode_barangjadi", cls_database.sorting.Ascending)

            If txt_search.Text <> vbNullString Then
                Db.Where(" AND a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
            End If

            GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

            With GridView1
                .Columns("kode_barangjadi").Caption = "Kode Artikel"
                .Columns("nama").Caption = "Nama"
                .Columns("jenis").Caption = "Jenis"
                .Columns("stok").Caption = "Stok"
            End With

        ElseIf parameter1 = C_RETUR_FORMALITAS Then
            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, b.nama, a.stok_sekunder as stok")
            Db.From("tbl_persediaan_customer a")
            Db.Join("tbl_barangjadi b", "b.kode_barangjadi = a.kode_barangjadi")
            Db.Where("a.kode_customer_child", kode_customer_child)
            Db.OrderBy("a.kode_barangjadi", cls_database.sorting.Ascending)

            If txt_search.Text <> vbNullString Then
                Db.Where(" AND a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
            End If

            GridControl1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

            With GridView1
                .Columns("kode_barangjadi").Caption = "Kode Artikel"
                .Columns("nama").Caption = "Nama"
                .Columns("stok").Caption = "Stok"
            End With

        Else
            Db.FlushCache()
            Db.Selects("a.kode_barangjadi, a.nama, c.kategori, b.stok")
            Db.From("tbl_barangjadi a")
            Db.Join("tbl_persediaan_gudang b", "a.kode_barangjadi = b.kode_barangjadi")
            Db.Join("tbl_kategori_barang c", "a.kode_kategori = c.kode_kategori")
            Db.OrderBy("a.kode_barangjadi", cls_database.sorting.Ascending)

            If txt_search.Text <> vbNullString Then
                Db.Where(" AND a.kode_barangjadi LIKE '%" & txt_search.Text & "%'")
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

        If GridView1.RowCount <= 0 Then
            MsgBox("Tidak terdapat artikel!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

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

                    '# delete list row new item
                    .rcd_list.RemoveAt(.rcd_list.Count - 1)

                    '# insert to list
                    .rcd_list.Add(New rcd_penerimaanbarang(row("kode_barangjadi"), row("nama"), 0))

                    .rcd_list.Add(New rcd_penerimaanbarang)
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

                    '# delete list row new item
                    .rcd_list.RemoveAt(.rcd_list.Count - 1)

                    '# ambil harga
                    ' load harga
                    Db.FlushCache()
                    Db.Selects("kode_hargajual, kode_template_harga, harga")
                    Db.From("tbl_hargajual")
                    Db.Where("kode_barangjadi", row("kode_barangjadi"))
                    Db.Where("kode_template_harga", .kode_customer_parent.GetColumnValue("kode_template_harga"))

                    rcd = Connection.ExecuteToDataReader(Db.GetQueryString)

                    If rcd.HasRows Then
                        rcd.Read()
                        .rcd_list.Add(New rcd_sales_order(1, row("kode_barangjadi"), row("nama"), rcd.Item("kode_hargajual").ToString, rcd.Item("harga").ToString, row("stok")))
                    Else
                        .rcd_list.Add(New rcd_sales_order(1, row("kode_barangjadi"), row("nama"), 0, 0, row("stok")))
                    End If

                    .rcd_list.Add(New rcd_sales_order)
                    .GridView1.RefreshData()

                End With

            Case C_KONSINYASI_SEKUNDER                  '========================================================# 
                With frm_konsinyasi_sekunder
                    Dim RowItemNew As Integer = .rcd_list.Count - 1

                    '# get histori barang
                    Dim data() As String = getHargaFromHistori(.rcd_list.Item(RowItemNew).tgl_transaksi, _
                                                   kode_customer_parent, _
                                                   row("kode_barangjadi"))

                    If data(2) <> "0" Then
                        '# get Info barangjadi di persediaan customer
                        Dim data1() As String = getInfoBarangjadiInCustomer(kode_customer_parent & "." & data(2), data(4))

                        .rcd_list.Item(RowItemNew).kode_barangjadi = data1(0)
                        .rcd_list.Item(RowItemNew).nama = data1(1)
                        .rcd_list.Item(RowItemNew).stok = data1(2)

                        .rcd_list.Item(RowItemNew).harga = data(0)
                        .rcd_list.Item(RowItemNew).diskon = data(1)
                        .rcd_list.Item(RowItemNew).harga2 = data(0)
                        .rcd_list.Item(RowItemNew).diskon2 = data(1)

                        .rcd_list.Item(RowItemNew).kelompok = data(2)
                        .rcd_list.Item(RowItemNew).kelompok_desk = data(3)

                        '# refres data
                        .rcd_list.Add(New rcd_konsinyasi_sekunder)
                        Call .reIndex()
                        setFocusCell(.GridView1, RowItemNew, "qty")
                        GridView1.RefreshData()

                    Else
                        MsgBox("Tidak terdapat kode barang '" & row("kode_barangjadi") & "'", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End With

            Case C_KONSINYASI_PRIMER
                With frm_konsinyasi_primer
                    Dim RowItemNew As Integer = .rcd_list.Count - 1

                    '# get histori barang
                    Dim data() As String = getHargaFromHistori(.rcd_list.Item(RowItemNew).tgl_transaksi, _
                                                   kode_customer_parent, _
                                                   row("kode_barangjadi"))

                    If data(2) <> "0" Then
                        '# get Info barangjadi di persediaan customer
                        Dim data1() As String = getInfoBarangjadiInCustomer(kode_customer_parent & "." & data(2), data(4))

                        '# get margin
                        Dim margin() As String = getMarginCustomer(.rcd_list.Item(RowItemNew).tgl_transaksi, kode_customer_parent & "." & data(2))

                        .rcd_list.Item(RowItemNew).kode_barangjadi = data1(0)
                        .rcd_list.Item(RowItemNew).nama = data1(1)
                        .rcd_list.Item(RowItemNew).stok = data1(3)

                        .rcd_list.Item(RowItemNew).harga = data(0)
                        .rcd_list.Item(RowItemNew).diskon = data(1)
                        .rcd_list.Item(RowItemNew).harga2 = data(0)
                        .rcd_list.Item(RowItemNew).diskon2 = data(1)

                        .rcd_list.Item(RowItemNew).kelompok = data(2)
                        .rcd_list.Item(RowItemNew).kelompok_desk = data(3)

                        '# margin
                        .rcd_list.Item(RowItemNew).sebelum_disc_acara = margin(0)
                        .rcd_list.Item(RowItemNew).disc_acara = margin(1)
                        .rcd_list.Item(RowItemNew).disc_acara_kita = margin(2)
                        .rcd_list.Item(RowItemNew).disc_acara_toko = margin(3)
                        .rcd_list.Item(RowItemNew).margin_toko = margin(4)
                        .rcd_list.Item(RowItemNew).margin_konsumen = margin(5)

                        '# refres data
                        .rcd_list.Add(New rcd_konsinyasi_primer)
                        .reIndex()
                        setFocusCell(.GridView1, RowItemNew, "qty")
                        .GridView1.RefreshData()
                    Else
                        MsgBox("Tidak terdapat kode barang '" & row("kode_barangjadi") & "'", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End With
                
            Case C_RETUR_JUAL_KONSINYASI
                With frm_retur_jual_konsinyasi
                    '# cek list, takut ada yg sama (^-^)
                    For i = 0 To .rcd_list.Count - 1
                        If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                            MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                            Exit Sub
                        End If
                    Next

                    Dim RowItemNew As Integer = .rcd_list.Count - 1

                    '# insert to list
                    '.rcd_list.Add(New rcd_retur_jual_konsinyasi(1, row("kode_barangjadi"), row("nama"), row("stok"), 0, 0, 0, ""))
                    .rcd_list.Item(RowItemNew).kode_barangjadi = row("kode_barangjadi")
                    .rcd_list.Item(RowItemNew).nama = row("nama")
                    .rcd_list.Item(RowItemNew).stok = row("stok")

                    '# ambil harga yg ditetapkan
                    Db.FlushCache()
                    Db.Selects("TOP 1 a.harga, a.diskon")
                    Db.From("tbl_histori_hargacustomer a")
                    Db.Where("a.kode_barangjadi", row("kode_barangjadi"))
                    Db.Where("a.kode_customer_child", kode_customer_child)
                    Db.Where("a.tanggal", .tgl_retur.DateTime.ToString("yyyy-MM-dd HH:mm:ss"), "<=", "AND")
                    Db.OrderBy("a.tanggal", cls_database.sorting.Descending)

                    Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)
                    If rc.HasRows Then
                        rc.Read()
                        .rcd_list.Item(RowItemNew).harga = rc.Item("harga").ToString
                    Else
                        .rcd_list.Item(RowItemNew).harga = 0
                    End If

                    .rcd_list.Add(New rcd_retur_jual_konsinyasi)
                    .reIndex()
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
                    frm_retur_jual_putus_popup_faktur.kode_customer_child = kode_customer_child
                    frm_retur_jual_putus_popup_faktur.ShowDialog(Me)

                    If frm_retur_jual_putus_popup_faktur.Kembali = True Then Exit Sub

                End With

            Case C_RETUR_FORMALITAS
                With frm_retur_formalitas
                    '# cek list, takut ada yg sama (^-^)
                    For i = 0 To .rcd_list.Count - 1
                        If .rcd_list.Item(i).kode_barangjadi = row("kode_barangjadi") Then
                            MsgBox("Kode Atikel : " & row("kode_barangjadi") & " , sudah diinput. Ganti dengan yang lain", MsgBoxStyle.Exclamation, "Pesan")
                            Exit Sub
                        End If
                    Next

                    Dim lastRow As Integer = .rcd_list.Count - 1

                    '# delete list row new item
                    .rcd_list.RemoveAt(lastRow)

                    '# insert to list
                    .rcd_list.Add(New rcd_retur_formalitas())

                    .rcd_list.Item(lastRow).kode_barangjadi = row("kode_barangjadi")
                    .rcd_list.Item(lastRow).nama_barangjadi = row("nama")
                    .rcd_list.Item(lastRow).stok = row("stok")
                    .rcd_list.Item(lastRow).jml_retur = 0

                    '# refres data
                    .rcd_list.Add(New rcd_retur_formalitas)
                    Call .reIndex()
                    setFocusCell(.GridView1, lastRow, "jml_retur")
                    GridView1.RefreshData()

                End With

            Case C_GETARTIKEL
                txt_artikel.Text = row("kode_barangjadi")
                Try
                    lbl_nama_artikel.Text = row("nama")
                Catch ex As Exception

                End Try
                Try
                    txt_stok.Text = row("stok")
                Catch ex As Exception

                End Try

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