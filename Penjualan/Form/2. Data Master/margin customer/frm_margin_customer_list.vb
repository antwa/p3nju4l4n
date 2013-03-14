Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_margin_customer_list

    Public rcd_list As New System.ComponentModel.BindingList(Of rcd_margin_customer)
    Dim repo_sebelum_margin As New RepositoryItemGridLookUpEdit

    Sub initComponent()

        tgl_dari.DateTime = DateAdd(DateInterval.Month, -1, Now)
        tgl_sampai.DateTime = Now

        Load_CustomerParent(kode_customer_parent, 1)


        GridControl1.DataSource = rcd_list

        'GridView1.Columns("id").Caption = ""
        GridView1.Columns("tanggal").Caption = "Tanggal"
        GridView1.Columns("kode_customer_child").Caption = "Kode Customer"
        GridView1.Columns("nama_customer").Caption = "Nama Customer"
        GridView1.Columns("sebelum_disc_acara").Caption = "Margin Acara"
        GridView1.Columns("disc_acara").Caption = "Disc Acara"
        GridView1.Columns("disc_acara_kita").Caption = "Disc Kita"
        GridView1.Columns("disc_acara_toko").Caption = "Disc Toko"
        GridView1.Columns("margin_toko").Caption = "Margin Toko"
        GridView1.Columns("margin_konsumen").Caption = "Margin Kons"

        GridView1.Columns("id").Visible = False
        GridView1.Columns("tanggal").Width = 80
        GridView1.Columns("kode_customer_child").Width = 110
        GridView1.Columns("nama_customer").Width = 135
        GridView1.Columns("sebelum_disc_acara").Width = 85
        GridView1.Columns("disc_acara").Width = 85
        GridView1.Columns("disc_acara_kita").Width = 70
        GridView1.Columns("disc_acara_toko").Width = 70
        GridView1.Columns("margin_toko").Width = 70
        GridView1.Columns("margin_konsumen").Width = 70

        ' enable/disable
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("sebelum_disc_acara").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("disc_acara").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("disc_acara_kita").OptionsColumn.AllowEdit = True
        ''GridView1.Columns.Item("disc_acara_toko").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("margin_toko").OptionsColumn.AllowEdit = True
        GridView1.Columns.Item("margin_konsumen").OptionsColumn.AllowEdit = True


        ' Init Repositori
        Dim tmp_data As New DataTable
        tmp_data.Columns.Add("kode", GetType(String))
        tmp_data.Columns.Add("desc", GetType(String))
        tmp_data.Rows.Add(New Object() {"1", "Sebelum"})
        tmp_data.Rows.Add(New Object() {"0", "Setelah"})

        repo_sebelum_margin.DataSource = tmp_data
        repo_sebelum_margin.PopulateViewColumns()
        repo_sebelum_margin.ValueMember = "kode"
        repo_sebelum_margin.DisplayMember = "desc"
        repo_sebelum_margin.PopupFormSize = New Size(150, 30)
        repo_sebelum_margin.View.Columns.Item("kode").Visible = False
        repo_sebelum_margin.View.OptionsCustomization.AllowFilter = False
        repo_sebelum_margin.View.OptionsCustomization.AllowSort = False
        repo_sebelum_margin.View.OptionsCustomization.AllowColumnMoving = False

        GridView1.Columns("sebelum_disc_acara").ColumnEdit = repo_sebelum_margin
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
                kode_customer_parent.Enabled = False
                tipe_customer.Enabled = False
            Case 1
                kode_provinsi.Enabled = Not chk_all_provinsi.Checked
                chk_all_provinsi.Enabled = True
                kode_kota.Enabled = Not chk_all_kota.Checked
                chk_all_kota.Enabled = True
                kode_group.Enabled = Not chk_all_group.Checked
                chk_all_group.Enabled = True
                kode_customer_parent.Enabled = False
                tipe_customer.Enabled = False
            Case 2
                kode_provinsi.Enabled = False
                chk_all_provinsi.Enabled = False
                kode_kota.Enabled = False
                chk_all_kota.Enabled = False
                kode_group.Enabled = False
                chk_all_group.Enabled = False
                kode_customer_parent.Enabled = True
                tipe_customer.Enabled = True
        End Select

    End Sub
    '#-------------------------------- end tujuan

    Public Sub loadData()

        rcd_list.Clear()

        Db.FlushCache()
        Db.Selects("a.id, a.tanggal, a.kode_customer_child, c.nama AS nama_customer, a.sebelum_disc_acara, a.disc_acara, a.disc_acara_kita, a.disc_acara_toko, a.margin_toko, a.margin_konsumen")
        Db.From("tbl_margin a")
        Db.Join("tbl_customer_child b", "b.kode_customer_child = a.kode_customer_child")
        Db.Join("tbl_customer_parent c", "c.kode_customer_parent = b.kode_customer_parent")
        Db.Join("tbl_kota d", "d.kode_kota = c.kode_kota")

        If rdo_tujuan.EditValue = 1 Then
            If chk_all_provinsi.Checked = False Then
                Db.Where("d.kode_provinsi", getValueFromLookup(kode_provinsi))
            End If

            If chk_all_kota.Checked = False Then
                Db.Where("c.kode_kota", getValueFromLookup(kode_kota))
            End If

            If chk_all_group.Checked = False Then
                Db.Where("c.kode_grup", getValueFromLookup(kode_group))
            End If
        ElseIf rdo_tujuan.EditValue = 2 Then
            Db.Where("a.kode_customer_child", getValueFromLookup(kode_customer_parent) & "." & (tipe_customer.SelectedIndex + 1))
        End If

        Db.Where_BetweenDate("a.tanggal", tgl_dari.DateTime, tgl_sampai.DateTime)

        Db.OrderBy("a.kode_customer_child", cls_database.sorting.Ascending)
        Db.OrderBy("a.tanggal", cls_database.sorting.Ascending)

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If r.Rows.Count > 0 Then
            With r
                Dim count As Integer = .Rows.Count - 1
                For i = 0 To count
                    rcd_list.Add(New rcd_margin_customer)
                    rcd_list.Item(i).id = .Rows(i).Item("id")
                    rcd_list.Item(i).tanggal = .Rows(i).Item("tanggal")
                    rcd_list.Item(i).kode_customer_child = .Rows(i).Item("kode_customer_child")
                    rcd_list.Item(i).nama_customer = .Rows(i).Item("nama_customer")
                    rcd_list.Item(i).sebelum_disc_acara = .Rows(i).Item("sebelum_disc_acara")
                    rcd_list.Item(i).disc_acara = .Rows(i).Item("disc_acara")
                    rcd_list.Item(i).disc_acara_kita = .Rows(i).Item("disc_acara_kita")
                    rcd_list.Item(i).disc_acara_toko = .Rows(i).Item("disc_acara_toko")
                    rcd_list.Item(i).margin_toko = .Rows(i).Item("margin_toko")
                    rcd_list.Item(i).margin_konsumen = .Rows(i).Item("margin_konsumen")
                Next
            End With

            GridView1.RefreshData()
        End If

    End Sub


    Private Sub frm_margin_customer_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.initComponent()
    End Sub


    Private Sub cmd_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_load.Click
        Call Me.loadData()
    End Sub

    Private Sub cmd_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_excel.Click
        With SaveFileDialog1
            .Filter = "Exel File 2007 (*.Xlsx)|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXlsx(.FileName)
            End If
        End With
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        '# Create Header
        Dim StrHeader As String = PrintableComponentLink1.RtfReportHeader
        StrHeader = StrHeader.Replace("$tgl_dari", tgl_dari.Text)
        StrHeader = StrHeader.Replace("$tgl_sampai", tgl_sampai.Text)
        ' set header and create document print
        PrintableComponentLink1.RtfReportHeader = StrHeader
        PrintableComponentLink1.Landscape = True
        PrintableComponentLink1.PaperKind = Printing.PaperKind.A4
        PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(50, 50, 75, 50)
        PrintableComponentLink1.CreateDocument()
        ' set printable to form report control
        Dim fc As New FormReportControl
        fc.Text = "Print Laporan Margin Customer"
        fc.PrintControl1.PrintingSystem = PrintableComponentLink1.PrintingSystem
        fc.MdiParent = formMDI
        fc.Show()
    End Sub

    Private Sub cmd_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click

        If Not rcd_list.Count > 0 Then
            MsgBox("Tidak ada data untuk diedit.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        cmd_edit.Enabled = False
        cmd_simpan.Enabled = True
        GridView1.OptionsBehavior.Editable = True
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Connection.TRANS_START()

        Dim count As Integer = rcd_list.Count - 1
        For i = 0 To count
            '# Update table tbl_margin
            Db.FlushCache()
            Db.Update("tbl_margin")
            'Db.SetField("tanggal", )
            'Db.SetField("kode_customer_child", )
            Db.SetField("sebelum_disc_acara", rcd_list.Item(i).sebelum_disc_acara)
            Db.SetField("disc_acara", rcd_list.Item(i).disc_acara)
            Db.SetField("disc_acara_kita", rcd_list.Item(i).disc_acara_kita)
            Db.SetField("disc_acara_toko", rcd_list.Item(i).disc_acara_toko)
            Db.SetField("margin_toko", rcd_list.Item(i).margin_toko)
            Db.SetField("margin_konsumen", rcd_list.Item(i).margin_konsumen)
            Db.Where("id", rcd_list.Item(i).id)
            Connection.TRANS_ADD(Db.GetQueryString)
        Next

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data telah berhasil disimpan.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")

            cmd_edit.Enabled = True
            cmd_simpan.Enabled = False
            GridView1.OptionsBehavior.Editable = False

            'Me.loadData()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_margin_customer_add.Dispose()
        frm_margin_customer_add.ShowDialog(Me)
    End Sub

    Private Sub GridView1_CellMerge(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs) Handles GridView1.CellMerge
        If (e.Column.FieldName = "kode_customer_child") Or _
           (e.Column.FieldName = "nama_customer") Then

            Dim view As GridView = CType(sender, GridView)
            Dim val1 As String = view.GetRowCellValue(e.RowHandle1, e.Column)
            Dim val2 As String = view.GetRowCellValue(e.RowHandle2, e.Column)
            e.Merge = (val1 = val2)
            e.Handled = True
        Else
            e.Merge = False
            e.Handled = True
        End If
    End Sub
End Class