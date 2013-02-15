Public Class frm_delivery_order 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_delivery_order)

    Sub initComponent()

        tgl_dari.DateTime = DateAdd(DateInterval.Month, -1, Now)
        tgl_sampai.DateTime = Now

        Load_Customer(kode_customer, sistem_jual.EditValue)

    End Sub

    '#------------------------- Tujuan
    Private Sub chk_all_provinsi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_provinsi.CheckedChanged
        If chk_all_provinsi.Checked = False Then
            Load_Provinsi(kode_provinsi)
        End If
        kode_provinsi.Enabled = Not chk_all_provinsi.Checked
        chk_all_kota.Checked = chk_all_provinsi.Checked
    End Sub

    Private Sub kode_provinsi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_provinsi.EditValueChanged
        Load_Kota(kode_kota, getValueFromLookup(kode_provinsi))
    End Sub

    Private Sub chk_all_kota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_kota.CheckedChanged
        kode_kota.Enabled = Not chk_all_kota.Checked
    End Sub

    Private Sub chk_all_group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_group.CheckedChanged
        If chk_all_group.Checked = False Then
            Load_Grup(kode_group)
        End If
        kode_group.Enabled = Not chk_all_group.Checked
    End Sub

    Private Sub rdo_tujuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_tujuan.SelectedIndexChanged
        Select Case rdo_tujuan.EditValue
            Case 0
                kode_provinsi.Enabled = False
                chk_all_provinsi.Enabled = False
                kode_kota.Enabled = False
                chk_all_kota.Enabled = False
                kode_group.Enabled = False
                chk_all_group.Enabled = False
                kode_customer.Enabled = False
            Case 1
                kode_provinsi.Enabled = Not chk_all_provinsi.Checked
                chk_all_provinsi.Enabled = True
                kode_kota.Enabled = Not chk_all_kota.Checked
                chk_all_kota.Enabled = True
                kode_group.Enabled = Not chk_all_group.Checked
                chk_all_group.Enabled = True
                kode_customer.Enabled = False
            Case 2
                kode_provinsi.Enabled = False
                chk_all_provinsi.Enabled = False
                kode_kota.Enabled = False
                chk_all_kota.Enabled = False
                kode_group.Enabled = False
                chk_all_group.Enabled = False
                kode_customer.Enabled = True
        End Select

    End Sub
    '#--------------------------------

    Public Sub loadData()
        Dim i As Integer

        rcd_list = New System.ComponentModel.BindingList(Of rcd_delivery_order)

        Db.FlushCache()
        Db.Selects("a.tgl_so, a.no_so, a.kode_customer, b.nama, a.total_qty, a.total_value, b.prioritas")
        Db.From("tbl_salesorder a")
        Db.Join("tbl_customer b", "b.kode_customer = a.kode_customer")
        Db.Join("tbl_kota c", "c.kode_kota = b.kode_kota")
        'Db.Where(" WHERE (a.status = '0' OR a.status = '3') ")
        Db.Where(" WHERE (a.status = '0') ")
        Db.Where("a.sistem_jual", sistem_jual.EditValue)

        Db.Where_BetweenDate("a.tgl_so", tgl_dari.DateTime, tgl_sampai.DateTime)

        If rdo_tujuan.EditValue = 1 Then
            If chk_all_provinsi.Checked = False Then
                Db.Where("c.kode_provinsi", getValueFromLookup(kode_provinsi))
            End If

            If chk_all_kota.Checked = False Then
                Db.Where("b.kode_kota", getValueFromLookup(kode_kota))
            End If

            If chk_all_group.Checked = False Then
                Db.Where("b.kode_grup", getValueFromLookup(kode_group))
            End If
        ElseIf rdo_tujuan.EditValue = 2 Then
            Db.Where("a.kode_customer", getValueFromLookup(kode_customer))
        End If

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        'MsgBox(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                While .Read
                    rcd_list.Add(New rcd_delivery_order(.Item("tgl_so").ToString, _
                                                        .Item("no_so").ToString, _
                                                        .Item("kode_customer").ToString, _
                                                        .Item("nama").ToString, _
                                                        .Item("total_qty").ToString, _
                                                        .Item("total_value").ToString, _
                                                        .Item("prioritas").ToString, _
                                                        False))
                End While
            End With
        End If

        ' insert to grid
        GridControl1.DataSource = rcd_list

        GridView1.Columns(0).Caption = "Tanggal SO"
        GridView1.Columns(1).Caption = "Nomor SO"
        GridView1.Columns(2).Caption = "Kode Customer"
        GridView1.Columns(3).Caption = "Nama Customer"
        GridView1.Columns(4).Caption = "Total Qty"
        GridView1.Columns(5).Caption = "Total Value (Rp.)"
        GridView1.Columns(6).Caption = "Prioritas"
        GridView1.Columns(7).Caption = " "

        FormatColumnNumeric(GridView1.Columns(5))

        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item(7).OptionsColumn.AllowEdit = True

    End Sub

    Private Sub frm_delivery_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initComponent()
        Call loadData()
    End Sub

    Private Sub sistem_jual_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sistem_jual.SelectedIndexChanged
        Load_Customer(kode_customer, sistem_jual.EditValue)
    End Sub

    Private Sub cmd_input_satu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_input_satu.Click
        Try
            Dim i As Integer = 0
            Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            frm_delivery_order_satu.Dispose()
            frm_delivery_order_satu.p_no_so = rcd_list.Item(GridView1.FocusedRowHandle).no_so
            frm_delivery_order_satu.ShowDialog(Me)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_detail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_detail.Click
        Try
            Dim i As Integer = 0
            Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            frm_delivery_order_detail.p_no_so = rcd_list.Item(GridView1.FocusedRowHandle).no_so
            frm_delivery_order_detail.ShowDialog(Me)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        cmd_detail_Click(sender, e)
    End Sub

    Private Sub cmd_input_n_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_input_n.Click
        Try
            frm_delivery_order_banyak.Dispose()
            frm_delivery_order_banyak.sistem_jual = sistem_jual.EditValue
            frm_delivery_order_banyak.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_cancel_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel_do.Click
        Try
            Dim row As Integer = GridView1.FocusedRowHandle
            If MsgBox("No SO : " & rcd_list.Item(row).no_so & vbCrLf & vbCrLf & "Apakah akan menghapus No SO diatas?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cancel SO") = MsgBoxResult.Yes Then
                Db.FlushCache()
                Db.Update("tbl_salesorder")
                Db.SetField("status", "2")
                Db.Where("no_so", rcd_list.Item(row).no_so)

                If Connection.ExecuteNonQuery(Db.GetQueryString) = True Then
                    MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
                    Call Me.loadData()
                Else
                    MsgBox("Data gagal dihapus", MsgBoxStyle.Exclamation)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call Me.loadData()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cek_uncek.CheckedChanged
        Try
            Dim i As Integer
            For i = 0 To rcd_list.Count - 1
                rcd_list.Item(i).cek = chk_cek_uncek.Checked
            Next
            GridView1.RefreshData()
        Catch ex As Exception

        End Try
    End Sub
End Class