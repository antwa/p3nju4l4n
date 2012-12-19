Public Class frm_histori_harga_add 

    Dim rcd_list As New System.ComponentModel.BindingList(Of rcd_histori_harga_add)

    Sub initComponent()
        Load_Customer(kode_customer, 1)
        tanggal.DateTime = Now
    End Sub

    Sub loadData()
        rcd_list.Clear()

        Db.FlushCache()
        Db.Selects("a.kode_customer, b.nama")
        Db.From("tbl_persediaan_customer a")
        Db.Join("tbl_customer b", "b.kode_customer = a.kode_customer")
        Db.Where("a.kode_barangjadi", kode_barangjadi.Text)
        If Not chk_semua_customer.Checked Then
            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
        End If

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        If dt.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1
                rcd_list.Add(New rcd_histori_harga_add(dt.Rows(i).Item("kode_customer").ToString, dt.Rows(i).Item("nama").ToString, True))
            Next
        End If

        GridControl1.DataSource = rcd_list

        GridView1.Columns("kode_customer").Caption = "Kode Customer"
        GridView1.Columns("nama_custumer").Caption = "Nama Customer"
        GridView1.Columns("checked").Caption = " "

        GridView1.Columns("kode_customer").Width = 110
        GridView1.Columns("nama_custumer").Width = 155
        GridView1.Columns("checked").Width = 50

        'Enable/Disable editable cell
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("checked").OptionsColumn.AllowEdit = True


    End Sub

    Private Sub frm_histori_harga_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
    End Sub

    Private Sub chk_semua_customer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_semua_customer.CheckedChanged
        kode_customer.Enabled = Not chk_semua_customer.Checked
    End Sub

    Private Sub Cmd_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_cari.Click
        frm_transaksi_popup_artkel.Dispose()
        frm_transaksi_popup_artkel.parameter1 = C_GETARTIKEL
        frm_transaksi_popup_artkel.txt_artikel = kode_barangjadi
        frm_transaksi_popup_artkel.lbl_nama_artikel = lbl_nama_artikel
        frm_transaksi_popup_artkel.ShowDialog(Me)
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call loadData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer
        Dim query As String

        '# Validasi

        Connection.TRANS_START()

        For i = 0 To rcd_list.Count - 1
            If rcd_list.Item(i).checked Then
                query = ""
                query &= "IF EXISTS (SELECT * FROM tbl_histori_hargacustomer WHERE kode_customer = '" & rcd_list(i).kode_customer & "' AND kode_barangjadi = '" & kode_barangjadi.Text & "' AND CONVERT(varchar, tanggal, 111) = '" & tanggal.DateTime.ToString("yyyy/MM/dd") & "') "
                query &= "	BEGIN "
                query &= "		UPDATE tbl_histori_hargacustomer "
                query &= "		SET harga = " & harga.EditValue & ", diskon = " & diskon.EditValue & " "
                query &= "		WHERE kode_customer = '" & rcd_list(i).kode_customer & "' AND kode_barangjadi = '" & kode_barangjadi.Text & "' "
                query &= "      AND CONVERT(varchar, tanggal, 111) = '" & tanggal.DateTime.ToString("yyyy/MM/dd") & "' "
                query &= "	END "
                query &= "ELSE "
                query &= "	BEGIN "
                query &= "		INSERT INTO tbl_histori_hargacustomer (tanggal, kode_customer, kode_barangjadi, harga, diskon) "
                query &= "		VALUES "
                query &= "		('" & tanggal.DateTime.ToString("yyyy-MM-dd") & " 00:00:00', '" & rcd_list(i).kode_customer & "', '" & kode_barangjadi.Text & "', " & harga.EditValue & ", " & diskon.EditValue & ") "
                query &= "  END "

                Connection.TRANS_ADD(query)

            End If
        Next

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            'frm_histori_harga.loadData()
            frm_histori_harga.Focus()
            Me.Close()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub chk_check_uncheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_check_uncheck.CheckedChanged
        Dim i As Integer
        For i = 0 To rcd_list.Count - 1
            rcd_list.Item(i).checked = chk_check_uncheck.Checked
        Next

        GridView1.RefreshData()
    End Sub
End Class