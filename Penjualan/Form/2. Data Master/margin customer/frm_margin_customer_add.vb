Public Class frm_margin_customer_add 

    Dim Kalender As Cls_Calendar

    Private Sub frm_margin_customer_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_CustomerParent(kode_customer_parent, 1)

        Dim th_sekarang As Integer = Now.ToString("yyyy")
        Dim th_awal As Integer = th_sekarang - 3
        Dim th_akhir As Integer = th_sekarang + 3

        For i = th_awal To th_akhir
            cmb_tahun.Properties.Items.Add(i)
        Next
        cmb_tahun.SelectedItem = th_sekarang

        Kalender = New Cls_Calendar(PanelControl2)
        Kalender.CreateCalendar((cmb_bulan.SelectedIndex + 1), cmb_tahun.Text)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If Not Kalender.getCount > 0 Then
            MsgBox("Ceklis salah satu tanggal.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim vkode_customer_child As String = ""
        Dim Query As String = ""

        '# start transaksi
        Connection.TRANS_START()

        If getValueFromLookup(kode_customer_parent) = "-1" Then ' jika semua customer
            Dim row() As String = Kalender.getItem
            Dim count As Integer = row.Count - 1
            Dim cus As DataTable = Connection.ExecuteToDataTable("Select kode_customer_parent from tbl_customer_parent where sistem_jual = '1'")

            If cus.Rows.Count > 0 Then

                For x = 0 To cus.Rows.Count - 1
                    vkode_customer_child = cus.Rows(x).Item("kode_customer_parent") & "." & (cmb_tipecustomer.SelectedIndex + 1)

                    For i = 0 To count
                        Query = ""
                        Query &= " IF EXISTS (SELECT * FROM tbl_margin WHERE kode_customer_child = '" & vkode_customer_child & "' AND tanggal = '" & row(i) & "') "
                        Query &= "    UPDATE tbl_margin "
                        Query &= "    SET sebelum_disc_acara = '" & rdg_margin.EditValue & "', "
                        Query &= "        disc_acara = '" & disc_acara.EditValue & "', "
                        Query &= "        disc_acara_kita = '" & disc_acara_kita.EditValue & "', "
                        Query &= "        disc_acara_toko = '" & disc_acara_toko.EditValue & "', "
                        Query &= "        margin_toko = '" & margin_toko.EditValue & "', "
                        Query &= "        margin_konsumen = '" & margin_konsumen.EditValue & "' "
                        Query &= "    WHERE kode_customer_child = '" & vkode_customer_child & "' AND tanggal = '" & row(i) & "' "
                        Query &= " ELSE "
                        Query &= "   BEGIN "
                        Query &= "    INSERT INTO tbl_margin (tanggal, kode_customer_child, sebelum_disc_acara, disc_acara, disc_acara_kita, disc_acara_toko, margin_toko, margin_konsumen) "
                        Query &= "    VALUES ('" & row(i) & "', '" & vkode_customer_child & "', '" & rdg_margin.EditValue & "', '" & disc_acara.EditValue & "', '" & disc_acara_kita.EditValue & "', '" & disc_acara_toko.EditValue & "', '" & margin_toko.EditValue & "', '" & margin_konsumen.EditValue & "');"
                        Query &= "   END "
                        Query &= "; "

                        Connection.TRANS_ADD(Query)
                    Next

                Next

            Else
                MsgBox("Tidak ada data customer dalam database!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Else ' jika satu customer
            vkode_customer_child = getValueFromLookup(kode_customer_parent) & "." & (cmb_tipecustomer.SelectedIndex + 1)

            Dim row() As String = Kalender.getItem
            Dim count As Integer = row.Count - 1

            For i = 0 To count
                Query = ""
                Query &= " IF EXISTS (SELECT * FROM tbl_margin WHERE kode_customer_child = '" & vkode_customer_child & "' AND tanggal = '" & row(i) & "') "
                Query &= "    UPDATE tbl_margin "
                Query &= "    SET sebelum_disc_acara = '" & rdg_margin.EditValue & "', "
                Query &= "        disc_acara = '" & disc_acara.EditValue & "', "
                Query &= "        disc_acara_kita = '" & disc_acara_kita.EditValue & "', "
                Query &= "        disc_acara_toko = '" & disc_acara_toko.EditValue & "', "
                Query &= "        margin_toko = '" & margin_toko.EditValue & "', "
                Query &= "        margin_konsumen = '" & margin_konsumen.EditValue & "' "
                Query &= "    WHERE kode_customer_child = '" & vkode_customer_child & "' AND tanggal = '" & row(i) & "' "
                Query &= " ELSE "
                Query &= "   BEGIN "
                Query &= "    INSERT INTO tbl_margin (tanggal, kode_customer_child, sebelum_disc_acara, disc_acara, disc_acara_kita, disc_acara_toko, margin_toko, margin_konsumen) "
                Query &= "    VALUES ('" & row(i) & "', '" & vkode_customer_child & "', '" & rdg_margin.EditValue & "', '" & disc_acara.EditValue & "', '" & disc_acara_kita.EditValue & "', '" & disc_acara_toko.EditValue & "', '" & margin_toko.EditValue & "', '" & margin_konsumen.EditValue & "');"
                Query &= "   END "
                Query &= "; "

                Connection.TRANS_ADD(Query)
            Next

        End If

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
            Kalender.UnCheckAll()
            frm_margin_customer_list.loadData()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub cmb_bulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_bulan.SelectedIndexChanged
        Try
            Kalender.CreateCalendar((cmb_bulan.SelectedIndex + 1), cmb_tahun.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_tahun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tahun.SelectedIndexChanged
        Try
            Kalender.CreateCalendar((cmb_bulan.SelectedIndex + 1), cmb_tahun.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub disc_acara_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc_acara.EditValueChanged
        Try
            disc_acara_kita.Text = CInt(disc_acara.Text) \ 2
            disc_acara_toko.Text = CInt(disc_acara.Text) - CInt(disc_acara_kita.Text)
        Catch ex As Exception
            disc_acara_kita.Text = 0
            disc_acara_toko.Text = 0
        End Try
    End Sub

    Private Sub disc_acara_kita_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disc_acara_kita.EditValueChanged
        Try
            If CInt(disc_acara_kita.Text) > CInt(disc_acara.Text) Then
                'MsgBox("Disc acara tidak boleh lebih kecil", MsgBoxStyle.Exclamation)
                disc_acara_kita.Text = disc_acara.Text
            End If

            disc_acara_toko.Text = CInt(disc_acara.Text) - CInt(disc_acara_kita.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

End Class