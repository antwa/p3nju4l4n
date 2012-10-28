Public Class frm_barangjadi_add 

    Dim rcd_list As System.ComponentModel.BindingList(Of rcd_barangjadi_add)

    Sub initComponent()

        Load_Merk(kode_merk)
        no_urut.Text = getNomorUrut_Barang(getValueFromLookup(kode_merk))

        '# load size
        rcd_list = New System.ComponentModel.BindingList(Of rcd_barangjadi_add)
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_size")
        Db.OrderBy("size", cls_database.sorting.Ascending)

        Dim rc As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rc.HasRows Then
            With rc
                While rc.Read
                    rcd_list.Add(New rcd_barangjadi_add(.Item("kode_size").ToString, False, .Item("size").ToString))
                End While
            End With
        End If

        GridControl1.DataSource = rcd_list

        GridView1.Columns("kode_size").Visible = False
        GridView1.Columns("cheked").Caption = " "
        GridView1.Columns("size").Caption = "Size"

        GridView1.Columns("cheked").Width = 30
        GridView1.Columns("size").Width = 170

        GridView1.Columns("size").OptionsColumn.AllowEdit = False



        '# tahun produksi
        Dim tahun As Integer = CInt(DateAdd(DateInterval.Year, -3, Now).ToString("yyyy"))
        Dim i As Integer
        For i = tahun To tahun + 6
            tahun_produksi.Properties.Items.Add(i)
        Next
        tahun_produksi.Text = Now.ToString("yyyy")

        '# kategori barang
        Load_KategoriBarang(kode_kategori)

        '# bulan Produksi
        bulan_produksi.Properties.Items.Add("Januari")
        bulan_produksi.Properties.Items.Add("Februari")
        bulan_produksi.Properties.Items.Add("Maret")
        bulan_produksi.Properties.Items.Add("April")
        bulan_produksi.Properties.Items.Add("Mei")
        bulan_produksi.Properties.Items.Add("Juni")
        bulan_produksi.Properties.Items.Add("Juli")
        bulan_produksi.Properties.Items.Add("Agustus")
        bulan_produksi.Properties.Items.Add("September")
        bulan_produksi.Properties.Items.Add("Oktober")
        bulan_produksi.Properties.Items.Add("November")
        bulan_produksi.Properties.Items.Add("Desember")

        bulan_produksi.SelectedIndex = 0

    End Sub

    Sub PriviewKode()
        Try
            kode_artikel_priview.Text = getValueFromLookup(kode_merk) & "." & _
                                        no_urut.Text & "." & _
                                        "XX" & "." & _
                                        tahun_produksi.Text.Substring(2, 2) & "." & _
                                        getValueFromLookup(kode_kategori) & "." & _
                                        CStr(bulan_produksi.SelectedIndex + 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_barangjadi_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub kode_merk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_merk.EditValueChanged
        no_urut.Text = getNomorUrut_Barang(getValueFromLookup(kode_merk))
        Call Me.PriviewKode()
    End Sub

    Private Sub tahun_produksi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tahun_produksi.SelectedIndexChanged
        Call Me.PriviewKode()
    End Sub

    Private Sub kode_kategori_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_kategori.EditValueChanged
        Call Me.PriviewKode()
    End Sub

    Private Sub bulan_produksi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulan_produksi.SelectedIndexChanged
        Call Me.PriviewKode()
    End Sub

    Private Sub cmd_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_browse.Click
        With OpenFileDialog1
            .Filter = "Image File (PNG, BMP, JPG, JPEG)|*.png;*.bmp;*.jpg;*.jpeg|" & _
                        "All File|*.*"

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    lbl_filename.Text = .SafeFileName
                    pct_gambar.Image = Image.FromFile(.FileName)
                Catch ex As Exception

                End Try
            End If

        End With
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        pct_gambar.Image = Nothing
        lbl_filename.Text = "-"
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer

        '# Validasi

        'cek size, minimal harus ada size yg diseleksi
        Dim size As Integer = 0
        For i = 0 To rcd_list.Count - 1
            If rcd_list.Item(i).cheked = True Then
                size += 1
            End If
        Next
        If size = 0 Then
            MsgBox("Pilih size dengan benar. Minimal satu yang terceklis.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        Validation.clearRules()
        Validation.addRules(nama.Text, "Nama", "required")
        Validation.addRules(harga_pokok.EditValue, "Harga Pokok", "required|numeric")

        If Validation.isValid Then

            Connection.TRANS_START()

            '# operasi file image
            If lbl_filename.Text <> "-" Then
                With OpenFileDialog1
                    If .FileName <> vbNullString Then
                        My.Computer.FileSystem.CopyFile(.FileName, APP.PATH_IMG_BARANG & lbl_filename.Text, True)
                    End If
                End With
            End If

            Dim kode_barangjadi As String

            For i = 0 To rcd_list.Count - 1
                If rcd_list.Item(i).cheked = True Then
                    kode_barangjadi = getValueFromLookup(kode_merk) & "." & _
                                        no_urut.Text & "." & _
                                        rcd_list.Item(i).kode_size & "." & _
                                        tahun_produksi.Text.Substring(2, 2) & "." & _
                                        getValueFromLookup(kode_kategori) & "." & _
                                        CStr(bulan_produksi.SelectedIndex + 1)

                    '# insert to table tbl_barangjadi
                    Db.FlushCache()
                    Db.Insert("tbl_barangjadi")
                    Db.SetField("kode_barangjadi", kode_barangjadi)
                    Db.SetField("kode_merk", getValueFromLookup(kode_merk))
                    Db.SetField("nama", nama.Text)
                    Db.SetField("kode_kategori", getValueFromLookup(kode_kategori))
                    Db.SetField("harga_pokok", harga_pokok.EditValue)
                    Db.SetField("kode_size", rcd_list.Item(i).kode_size)
                    Db.SetField("gambar", lbl_filename.Text)
                    Db.SetField("keterangan", keterangan.Text)

                    Connection.TRANS_ADD(Db.GetQueryString)


                    '# Formula Harga
                    frm_barangjadi_add_formula.Dispose()
                    frm_barangjadi_add_formula.vkode_barangjadi = kode_barangjadi
                    frm_barangjadi_add_formula.vnama = nama.Text
                    frm_barangjadi_add_formula.ShowDialog(Me)


                    '# insert to Stok Gudang
                    '  insert to table tbl_persediaan_gudang
                    Db.FlushCache()
                    Db.Insert("tbl_persediaan_gudang")
                    Db.SetField("kode_barangjadi", kode_barangjadi)
                    Db.SetField("stok", "0")

                    Connection.TRANS_ADD(Db.GetQueryString)

                End If
            Next

            '# COMMITE TRANSAKSI
            If Connection.TRANS_SUCCESS Then
                MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")

                frm_barangjadi_list.loadData()
                Me.Close()
            Else
                MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation) ' transaksi gagal dan secara otomatis akan di rollback
            End If

        Else
            Validation.showMessage()
        End If

    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub
End Class