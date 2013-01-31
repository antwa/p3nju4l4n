Public Class frm_input_gaji_spg 

    Dim Data_insentif As New DataTable
    Dim Data_potongan As New DataTable

    Sub initComponent()

        'Load customer
        Load_Customer(kode_customer, "1")

        'load pegawai
        Load_SPG(id_pegawai, getValueFromLookup(kode_customer))

        Call Me.getInformasiSPG()

        ' lainnya
        cmb_bulan.Properties.Items.Add("Januari")
        cmb_bulan.Properties.Items.Add("Februari")
        cmb_bulan.Properties.Items.Add("Maret")
        cmb_bulan.Properties.Items.Add("April")
        cmb_bulan.Properties.Items.Add("Mei")
        cmb_bulan.Properties.Items.Add("Juni")
        cmb_bulan.Properties.Items.Add("Juli")
        cmb_bulan.Properties.Items.Add("Agustus")
        cmb_bulan.Properties.Items.Add("September")
        cmb_bulan.Properties.Items.Add("Oktober")
        cmb_bulan.Properties.Items.Add("Nopember")
        cmb_bulan.Properties.Items.Add("Desember")

        cmb_bulan.SelectedItem = Now.ToString("MMMM")

        cmb_tahun.Properties.Items.Add(CInt(Now.ToString("yyyy") - 1))
        cmb_tahun.Properties.Items.Add(Now.ToString("yyyy"))
        cmb_tahun.Properties.Items.Add(CInt(Now.ToString("yyyy") + 1))

        cmb_tahun.SelectedItem = Now.ToString("yyyy")

        tgl_input.DateTime = Now

        Data_insentif.Columns.Add("Keterangan", GetType(String))
        Data_insentif.Columns.Add("Jumlah", GetType(Integer))

        Data_potongan.Columns.Add("Keterangan", GetType(String))
        Data_potongan.Columns.Add("Jumlah", GetType(Integer))

        GridControl1.DataSource = Data_insentif
        GridControl2.DataSource = Data_potongan

        GridView1.Columns(1).Caption = "Jumlah (Rp.)"
        GridView1.Columns(0).Width = 250
        GridView1.Columns(1).Width = 100
        FormatColumnNumeric(GridView1.Columns(1))

        GridView2.Columns(1).Caption = "Jumlah (Rp.)"
        GridView2.Columns(0).Width = 250
        GridView2.Columns(1).Width = 100
        FormatColumnNumeric(GridView2.Columns(1))

    End Sub

    Sub getInformasiSPG()

        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_pegawai")
        Db.Where("id_pegawai", getValueFromLookup(id_pegawai))

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            Try
                rcd.Read()
                gaji_pokok.Text = rcd.Item("gaji_pokok").ToString
                p_hadir.Text = rcd.Item("premi_harian").ToString
                p_lembur1.Text = rcd.Item("lembur_jam").ToString
                p_lembur2.Text = rcd.Item("lembur_haribesar").ToString
            Catch ex As Exception

            End Try
        End If

        Call Me.Sumary()
    End Sub

    Sub Sumary()
        Try
            Dim i As Integer

            total_hadir.Text = CDbl(j_hadir.Text) * CDbl(p_hadir.Text)
            total_lembur1.Text = CDbl(j_lembur1.Text) * CDbl(p_lembur1.Text)
            total_lembur2.Text = CDbl(j_lembur2.Text) * CDbl(p_lembur2.Text)
            total_bonus.Text = CDbl(j_bonus.Text) * CDbl(p_bonus.Text)

            ' total insentif
            Dim t_insentif As Double = 0
            For i = 0 To Data_insentif.Rows.Count - 1
                t_insentif += Data_insentif.Rows(i).Item(1)
            Next
            total_insentif.Text = CStr(t_insentif)

            ' total potongan
            Dim t_potongan As Double = 0
            For i = 0 To Data_potongan.Rows.Count - 1
                t_potongan += Data_potongan.Rows(i).Item(1)
            Next
            total_potongan.Text = CStr(t_potongan)


            ' grand total
            Dim total1 As Double = CDbl(total_hadir.EditValue) + CDbl(total_lembur1.EditValue) + CDbl(total_lembur2.EditValue) + CDbl(total_bonus.EditValue) + CDbl(total_pengembalian_jaminan.EditValue) + CDbl(total_insentif.EditValue)
            Dim total2 As Double = CDbl(total_potongan_jaminan.EditValue) + CDbl(total_potongan.EditValue) + CDbl(total_salah_bayar.EditValue)

            grand_total.Text = total1 - total2
        Catch ex As Exception

        End Try
    End Sub

    Sub ClearForm()
        j_hadir.EditValue = 0
        j_lembur1.EditValue = 0
        j_lembur2.EditValue = 0
        j_bonus.EditValue = 0
        p_bonus.EditValue = 0
        total_pengembalian_jaminan.EditValue = 0
        total_potongan_jaminan.EditValue = 0

        Data_insentif.Clear()
        Data_potongan.Clear()

    End Sub

    Private Sub frm_input_gaji_spg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub

    Private Sub kode_customer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_customer.EditValueChanged
        Load_SPG(id_pegawai, getValueFromLookup(kode_customer))
    End Sub

    Private Sub chk_semua_customer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_semua_customer.CheckedChanged
        If chk_semua_customer.Checked Then
            kode_customer.Enabled = False
            Load_SPG(id_pegawai)
        Else
            kode_customer.Enabled = True
            Load_SPG(id_pegawai, getValueFromLookup(kode_customer))
        End If
    End Sub

    Private Sub id_pegawai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_pegawai.EditValueChanged
        getInformasiSPG()
    End Sub

    Private Sub j_hadir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles j_hadir.EditValueChanged
        Call Me.Sumary()
    End Sub

    Private Sub j_lembur1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles j_lembur1.EditValueChanged
        Call Me.Sumary()
    End Sub

    Private Sub j_lembur2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles j_lembur2.EditValueChanged
        Call Me.Sumary()
    End Sub

    Private Sub j_bonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles j_bonus.EditValueChanged
        Call Me.Sumary()
    End Sub

    Private Sub p_bonus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_bonus.EditValueChanged
        Call Me.Sumary()
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# Cek Periode
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_penggajian")
        Db.Where("id_pegawai", getValueFromLookup(id_pegawai))
        Db.Where("periode", cmb_bulan.Text & " " & cmb_tahun.Text)

        Dim rcd1 As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd1.HasRows Then
            MsgBox("Data dengan nama " & id_pegawai.Text & " Periode " & cmb_bulan.Text & " " & cmb_tahun.Text & ", Sudah terdapat dalam database!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        '# get nomor urut
        Dim i As Integer
        Dim no_slipgaji As String = getNomorUrut(C_SLIP_GAJI)

        Connection.TRANS_START()

        '# insert to table tbl_penggajian
        Db.FlushCache()
        Db.Insert("tbl_penggajian")
        Db.SetField("no_slipgaji", no_slipgaji)
        Db.SetField("id_pegawai", getValueFromLookup(id_pegawai))
        Db.SetField("tgl_input", tgl_input.DateTime)
        Db.SetField("periode", cmb_bulan.Text & " " & cmb_tahun.Text)
        Db.SetField("j_hadir", j_hadir.EditValue)
        Db.SetField("p_hadir", p_hadir.EditValue)
        Db.SetField("j_lembur1", j_lembur1.EditValue)
        Db.SetField("p_lembur1", p_lembur1.EditValue)
        Db.SetField("j_lembur2", j_lembur2.EditValue)
        Db.SetField("p_lembur2", p_lembur2.EditValue)
        Db.SetField("j_bonus", j_bonus.EditValue)
        Db.SetField("p_bonus", p_bonus.EditValue)
        Db.SetField("total_potongan", total_potongan.EditValue)
        Db.SetField("total_insentif", total_insentif.EditValue)
        Db.SetField("total_utang", "0")
        Db.SetField("pengembalian_jaminan", total_pengembalian_jaminan.EditValue)
        Db.SetField("jaminan_kerja", total_potongan_jaminan.EditValue)
        Db.SetField("grand_total", grand_total.EditValue)
        Db.SetField("tgl_transfer", "Belum")
        Db.SetField("username", Auth.Username)
        Db.SetField("status", "0")

        Connection.TRANS_ADD(Db.GetQueryString)

        '## insert ke detail

        '@ Insentif
        For i = 0 To Data_insentif.Rows.Count - 1
            '# insert to table tbl_penggajian_detail
            Db.FlushCache()
            Db.Insert("tbl_penggajian_detail")
            Db.SetField("no_slipgaji", no_slipgaji)
            Db.SetField("keterangan", Data_insentif.Rows(i).Item(0))
            Db.SetField("jumlah", Data_insentif.Rows(i).Item(1))
            Db.SetField("tipe", "i")

            Connection.TRANS_ADD(Db.GetQueryString)
        Next

        '@ Potongan
        For i = 0 To Data_potongan.Rows.Count - 1
            '# insert to table tbl_penggajian_detail
            Db.FlushCache()
            Db.Insert("tbl_penggajian_detail")
            Db.SetField("no_slipgaji", no_slipgaji)
            Db.SetField("keterangan", Data_potongan.Rows(i).Item(0))
            Db.SetField("jumlah", Data_potongan.Rows(i).Item(1))
            Db.SetField("tipe", "p")

            Connection.TRANS_ADD(Db.GetQueryString)
        Next

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data Berhasil Disimpan.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sukses")
            Call Me.ClearForm()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Call Me.Sumary()
    End Sub

    Private Sub GridView2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
        Call Me.Sumary()
    End Sub

    Private Sub total_potongan_jaminan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_potongan_jaminan.EditValueChanged
        Call Me.Sumary()
    End Sub

    Private Sub total_pengembalian_jaminan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total_pengembalian_jaminan.EditValueChanged
        Call Me.Sumary()
    End Sub
End Class