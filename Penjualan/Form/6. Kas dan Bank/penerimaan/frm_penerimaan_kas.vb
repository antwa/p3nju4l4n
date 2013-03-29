Public Class frm_penerimaan_kas 

    Dim rcd_list As New System.ComponentModel.BindingList(Of rcd_penerimaan_kas)
    Dim rcd_lainnya As New DataTable

    Sub initComponent()

        ' clear list
        rcd_list.Clear()
        rcd_lainnya.Clear()

        rdo_transakasi.SelectedIndex = 1

        ' load nomor jurnal
        id_jurnal.Text = getNomorJurnal(C_PENERIMAAN_KAS)
        Load_akun_detail_byKelompok(akun_debet, 1)
        tanggal.DateTime = Now
        keterangan.Text = ""
        Load_CustomerParent(lookup_kode, 1)
        jumlah.Text = "0"
        Load_akun_detail_byKelompok(akun_kredit, 4)

        Load_akun_detail_byKelompok(akun_potongan, 4, "4-200")


    End Sub

    Sub LoadData_Barangjadi()
        rcd_list.Clear()
        GridView1.Columns.Clear()

        Db.FlushCache()
        Db.Selects("no_faktur AS referensi, tgl_terbit, tgl_jatuhtempo, total")
        Db.From("tbl_fakturkonsinyasi")
        Db.Where("kode_customer_parent", getValueFromLookup(lookup_kode))
        Db.Where("status", "0")

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If dt.Rows.Count > 0 Then
            Dim i As Integer
            Dim count As Integer = dt.Rows.Count - 1

            For i = 0 To count
                rcd_list.Add(New rcd_penerimaan_kas)

                rcd_list.Item(i).no = i + 1
                rcd_list.Item(i).referensi = dt.Rows(i).Item("referensi")
                rcd_list.Item(i).tgl_terbit = dt.Rows(i).Item("tgl_terbit")
                rcd_list.Item(i).tgl_jatuh_tempo = dt.Rows(i).Item("tgl_jatuhtempo")
                rcd_list.Item(i).nominal = dt.Rows(i).Item("total")
                rcd_list.Item(i).cheked = False
                rcd_list.Item(i).keterangan = ""

            Next

        End If

        GridControl1.DataSource = rcd_list
        GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None

        GridView1.PopulateColumns()

        'Format
        GridView1.Columns("no").Caption = "No"
        GridView1.Columns("referensi").Caption = "Referensi"
        GridView1.Columns("tgl_terbit").Caption = "Tgl Terbit"
        GridView1.Columns("tgl_jatuh_tempo").Caption = "Tgl Jth Tempo"
        GridView1.Columns("nominal").Caption = "Nominal (Rp.)"
        GridView1.Columns("cheked").Caption = "-"
        GridView1.Columns("keterangan").Caption = "Keterangan"

        GridView1.Columns("no").Width = 30
        GridView1.Columns("referensi").Width = 75
        GridView1.Columns("tgl_terbit").Width = 85
        GridView1.Columns("tgl_jatuh_tempo").Width = 85
        GridView1.Columns("nominal").Width = 80
        GridView1.Columns("cheked").Width = 30
        GridView1.Columns("keterangan").Width = 245

        FormatColumnNumeric(GridView1.Columns("nominal"))

        ' desable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns("cheked").OptionsColumn.AllowEdit = True

    End Sub

    Sub SaveData_Barangjadi()
        Dim getIdJunal As String
        Dim arrGetIdJurnal() As String
        Dim getIdJurnalPotongan As String

        '# validation
        If Not rcd_list.Count > 0 Then
            MsgBox("Tidak ada data yang akan disimpan", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim i As Integer

        '# begin transaksi
        Connection.TRANS_START()

        '# insert to table tbl_jurnal
        Db.FlushCache()
        Db.Insert("tbl_jurnal")
        Db.SetField("id_jurnal", id_jurnal.Text)
        Db.SetField("id_jurnal_parent", "")
        Db.SetField("tanggal", tanggal.DateTime)
        Db.SetField("jumlah", jumlah.EditValue)
        Db.SetField("keterangan", keterangan.Text)
        Db.SetField("username", Auth.Username)
        Connection.TRANS_ADD(Db.GetQueryString)

        ''# insert to table tbl_penerimaan_kas
        'Db.FlushCache()
        'Db.Insert("tbl_penerimaan_kas")
        'Db.SetField("id_jurnal", id_jurnal.Text)
        'Db.SetField("jumlah", jumlah.Text)
        'Db.SetField("tanggal", tanggal.DateTime)
        'Db.SetField("username", Auth.Username)

        '# insert to table tbl_jurnal_detail
        Db.FlushCache()
        Db.Insert("tbl_jurnal_detail")
        Db.SetField("id_jurnal", id_jurnal.Text)
        Db.SetField("kode_akun", getValueFromLookup(akun_debet))
        Db.SetField("referensi", "")
        Db.SetField("debet", jumlah.EditValue)
        Db.SetField("kredit", "0")
        Db.SetField("keterangan", "")
        Connection.TRANS_ADD(Db.GetQueryString)



        For i = 0 To rcd_list.Count - 1

            '# cek value checklist
            If rcd_list.Item(i).cheked = True Then

                '# insert to table tbl_jurnal_detail
                Db.FlushCache()
                Db.Insert("tbl_jurnal_detail")
                Db.SetField("id_jurnal", id_jurnal.Text)
                Db.SetField("kode_akun", getValueFromLookup(akun_kredit))
                Db.SetField("referensi", rcd_list.Item(i).referensi)
                Db.SetField("debet", "0")
                Db.SetField("kredit", rcd_list(i).nominal)
                Db.SetField("keterangan", rcd_list(i).keterangan)
                Connection.TRANS_ADD(Db.GetQueryString)

                '# update faktur
                '# Update table tbl_fakturkonsi
                Db.FlushCache()
                Db.Update("tbl_fakturkonsinyasi")
                Db.SetField("status", "1")
                Db.Where("no_faktur", rcd_list.Item(i).referensi)
                Connection.TRANS_ADD(Db.GetQueryString)
            End If

        Next

        getIdJunal = id_jurnal.Text
        arrGetIdJurnal = getIdJunal.Split("/")
        getIdJurnalPotongan = arrGetIdJurnal(0) & "/" & arrGetIdJurnal(1) & "/" & Format((arrGetIdJurnal(2) + 1), "000")

        '#insert to table tbl_jurnal
        Db.FlushCache()
        Db.Insert("tbl_jurnal")
        Db.SetField("id_jurnal", getIdJurnalPotongan)
        Db.SetField("id_jurnal_parent", "")
        Db.SetField("tanggal", tanggal.DateTime)
        Db.SetField("jumlah", jumlah.EditValue)
        Db.SetField("keterangan", keterangan.Text)
        Db.SetField("username", Auth.Username)
        Connection.TRANS_ADD(Db.GetQueryString)

        '# insert to table tbl_jurnal_detail
        Db.FlushCache()
        Db.Insert("tbl_jurnal_detail")
        Db.SetField("id_jurnal", getIdJurnalPotongan)
        Db.SetField("kode_akun", getValueFromLookup(akun_debet))
        Db.SetField("debet", "0")
        Db.SetField("kredit", potongan.EditValue)
        Connection.TRANS_ADD(Db.GetQueryString)


        '# insert to table tbl_jurnal_detail
        Db.FlushCache()
        Db.Insert("tbl_jurnal_detail")
        Db.SetField("id_jurnal", getIdJurnalPotongan)
        Db.SetField("kode_akun", getValueFromLookup(akun_potongan))
        Db.SetField("debet", potongan.EditValue)
        Db.SetField("kredit", "0")
        Connection.TRANS_ADD(Db.GetQueryString)

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan")
            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If


    End Sub

    Sub SaveData_lainlain()
        Dim getIdJunal As String
        Dim arrGetIdJurnal() As String
        Dim getIdJurnalPotongan As String

        '# validation
        If Not rcd_list.Count > 0 Then
            MsgBox("Tidak ada data yang akan disimpan", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim i As Integer

        '# begin transaksi
        Connection.TRANS_START()

        '# insert to table tbl_jurnal
        Db.FlushCache()
        Db.Insert("tbl_jurnal")
        Db.SetField("id_jurnal", id_jurnal.Text)
        Db.SetField("id_jurnal_parent", "")
        Db.SetField("tanggal", tanggal.DateTime)
        Db.SetField("jumlah", jumlah.EditValue)
        Db.SetField("keterangan", keterangan.Text)
        Db.SetField("username", Auth.Username)
        Connection.TRANS_ADD(Db.GetQueryString)

        ''# insert to table tbl_penerimaan_kas
        'Db.FlushCache()
        'Db.Insert("tbl_penerimaan_kas")
        'Db.SetField("id_jurnal", id_jurnal.Text)
        'Db.SetField("jumlah", jumlah.Text)
        'Db.SetField("tanggal", tanggal.DateTime)
        'Db.SetField("username", Auth.Username)

        '# insert to table tbl_jurnal_detail
        Db.FlushCache()
        Db.Insert("tbl_jurnal_detail")
        Db.SetField("id_jurnal", id_jurnal.Text)
        Db.SetField("kode_akun", getValueFromLookup(akun_debet))
        Db.SetField("referensi", "")
        Db.SetField("debet", jumlah.EditValue)
        Db.SetField("kredit", "0")
        Db.SetField("keterangan", "")
        Connection.TRANS_ADD(Db.GetQueryString)



        For i = 0 To rcd_list.Count - 1

            '# cek value checklist
            If rcd_list.Item(i).cheked = True Then

                '# insert to table tbl_jurnal_detail
                Db.FlushCache()
                Db.Insert("tbl_jurnal_detail")
                Db.SetField("id_jurnal", id_jurnal.Text)
                Db.SetField("kode_akun", getValueFromLookup(akun_kredit))
                Db.SetField("referensi", rcd_list.Item(i).referensi)
                Db.SetField("debet", "0")
                Db.SetField("kredit", rcd_list(i).nominal)
                Db.SetField("keterangan", rcd_list(i).keterangan)
                Connection.TRANS_ADD(Db.GetQueryString)

                '# update faktur
                '# Update table tbl_fakturkonsi
                Db.FlushCache()
                Db.Update("tbl_fakturkonsinyasi")
                Db.SetField("status", "1")
                Db.Where("no_faktur", rcd_list.Item(i).referensi)
                Connection.TRANS_ADD(Db.GetQueryString)
            End If

        Next

        getIdJunal = id_jurnal.Text
        arrGetIdJurnal = getIdJunal.Split("/")
        getIdJurnalPotongan = arrGetIdJurnal(0) & "/" & arrGetIdJurnal(1) & "/" & Format((arrGetIdJurnal(2) + 1), "000")

        '#insert to table tbl_jurnal
        Db.FlushCache()
        Db.Insert("tbl_jurnal")
        Db.SetField("id_jurnal", getIdJurnalPotongan)
        Db.SetField("id_jurnal_parent", "")
        Db.SetField("tanggal", tanggal.DateTime)
        Db.SetField("jumlah", jumlah.EditValue)
        Db.SetField("keterangan", keterangan.Text)
        Db.SetField("username", Auth.Username)
        Connection.TRANS_ADD(Db.GetQueryString)

        '# insert to table tbl_jurnal_detail
        Db.FlushCache()
        Db.Insert("tbl_jurnal_detail")
        Db.SetField("id_jurnal", getIdJurnalPotongan)
        Db.SetField("kode_akun", getValueFromLookup(akun_debet))
        Db.SetField("debet", "0")
        Db.SetField("kredit", potongan.EditValue)
        Connection.TRANS_ADD(Db.GetQueryString)


        '# insert to table tbl_jurnal_detail
        Db.FlushCache()
        Db.Insert("tbl_jurnal_detail")
        Db.SetField("id_jurnal", getIdJurnalPotongan)
        Db.SetField("kode_akun", getValueFromLookup(akun_potongan))
        Db.SetField("debet", potongan.EditValue)
        Db.SetField("kredit", "0")
        Connection.TRANS_ADD(Db.GetQueryString)

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan")
            Call initComponent()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If


    End Sub

    Sub LoadData_Lainnya()
        rcd_lainnya.Clear()
        GridView1.Columns.Clear()

        ' list penerimaan lainnya
        rcd_lainnya.Columns.Clear()
        rcd_lainnya.Columns.Add("keterangan", GetType(String))
        rcd_lainnya.Columns.Add("nominal", GetType(Integer))

        GridControl1.DataSource = rcd_lainnya
        GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom

        'Format
        GridView1.PopulateColumns()
        GridView1.Columns("keterangan").Caption = "Uraian"
        GridView1.Columns("nominal").Caption = "Nominal (Rp.)"

        GridView1.Columns("keterangan").Width = 350
        GridView1.Columns("nominal").Width = 125

        FormatColumnNumeric(GridView1.Columns("nominal"))
    End Sub

    Private Sub frm_penerimaan_kas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Me.initComponent()
    End Sub

    Private Sub rdo_transakasi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_transakasi.SelectedIndexChanged
        ' clear list
        rcd_list.Clear()

        Select Case rdo_transakasi.EditValue

            Case "barang jadi"
                lbl_customer.Visible = True
                lookup_kode.Visible = True
                cmd_load.Visible = True
                Load_Customer(lookup_kode, 1)

            Case "lain-lain"
                lbl_customer.Visible = False
                lookup_kode.Visible = False
                cmd_load.Visible = False
                LoadData_Lainnya()

        End Select
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Select Case rdo_transakasi.EditValue

            Case "barang jadi"
                Call Me.LoadData_Barangjadi()

        End Select
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Select Case rdo_transakasi.EditValue

            Case "bahan baku"
                MsgBox("Belum berfungsi")
            Case "barang jadi"
                Call SaveData_Barangjadi()

            Case "aksesoris"
                MsgBox("Belum berfungsi")
            Case "lain-lain"
                Call SaveData_lainlain()
        End Select

    End Sub


    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim i As Integer
        Dim total As Double = 0

        'Try

        'Catch ex As Exception

        'End Try

        Select Case rdo_transakasi.EditValue

            Case "barang jadi"
                For i = 0 To rcd_list.Count - 1
                    If rcd_list.Item(i).cheked = True Then
                        total += rcd_list.Item(i).nominal
                    End If
                Next

            Case "lain lain"
                For i = 0 To rcd_lainnya.Rows.Count - 1
                    total += rcd_lainnya.Rows(i).Item("nominal")
                Next

        End Select

        Me.jumlah.Text = total

    End Sub



   
    Private Sub potongan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles potongan.EditValueChanged
        total_bersih.Text = CInt(jumlah.Text) - CInt(potongan.Text)

    End Sub
End Class