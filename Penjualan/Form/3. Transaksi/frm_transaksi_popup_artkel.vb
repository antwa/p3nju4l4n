Public Class frm_transaksi_popup_artkel

    Public parameter1 As String
    
    Sub initGrid()

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
    End Sub

    Sub addArtikel()
        Dim i As Integer = 0
        Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

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
                    .GridControl1.Refresh()
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