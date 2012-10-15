Public Class frm_delivery_order 

    Public rcd_list As System.ComponentModel.BindingList(Of rcd_delivery_order)

    Sub initComponent()

        tgl_dari.DateTime = DateAdd(DateInterval.Month, -1, Now)
        tgl_sampai.DateTime = Now

        Load_Customer(kode_customer, sistem_jual.EditValue)

    End Sub

    Public Sub loadData()
        Dim i As Integer

        rcd_list = New System.ComponentModel.BindingList(Of rcd_delivery_order)

        Db.FlushCache()
        Db.Selects("a.tgl_so, a.no_so, a.kode_customer, b.nama, a.total_qty, a.total_value, b.prioritas")
        Db.From("tbl_salesorder a")
        Db.Join("tbl_customer b", "b.kode_customer = a.kode_customer")
        Db.Where(" WHERE (a.status = '0' OR a.status = '3') ")
        Db.Where("a.sistem_jual", sistem_jual.EditValue)

        Db.Where_BetweenDate("a.tgl_so", tgl_dari.DateTime.ToString("yyyy-MM-dd"), tgl_sampai.DateTime.ToString("yyyy-MM-dd"))

        If rd_tujuan.EditValue = 2 Then
            Db.Where("a.kode_customer", kode_customer.Properties.GetKeyValueByDisplayText(kode_customer.Text))
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

    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call loadData()
    End Sub

    Private Sub cmd_input_satu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_input_satu.Click
        Try
            Dim i As Integer = 0
            Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

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
End Class