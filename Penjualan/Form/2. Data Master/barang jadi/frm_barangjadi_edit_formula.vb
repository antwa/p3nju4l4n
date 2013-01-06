Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frm_barangjadi_edit_formula

    Dim rcd_list As System.ComponentModel.BindingList(Of rcd_barangjadi_edit_formula)

    Public Sub initData(ByVal kode_barangjadi As String, ByVal nama As String)

        rcd_list = New System.ComponentModel.BindingList(Of rcd_barangjadi_edit_formula)

        Me.kode_barangjadi.Text = kode_barangjadi
        Me.lbl_nama.Text = nama

        '# get data harga
        Db.FlushCache()
        Db.Selects("a.kode_hargajual, a.kode_template_harga, b.nama_harga, a.harga")
        Db.From("tbl_hargajual a")
        Db.Join("tbl_template_hargajual b", "b.kode_template_harga = a.kode_template_harga")
        Db.Where("kode_barangjadi", kode_barangjadi)
        Db.OrderBy("a.kode_hargajual", cls_database.sorting.Ascending)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                While .Read
                    rcd_list.Add(New rcd_barangjadi_edit_formula(.Item("kode_hargajual").ToString, .Item("kode_template_harga").ToString, .Item("nama_harga").ToString, .Item("harga").ToString))
                End While
            End With
        End If

        GridControl1.DataSource = rcd_list

        'GridView1.Columns("kode_hargajual").Caption = "Kode"
        GridView1.Columns("kode_template_harga").Caption = "No."
        GridView1.Columns("nama_harga").Caption = "Nama Harga"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"

        GridView1.Columns("kode_hargajual").Width = 45
        GridView1.Columns("kode_template_harga").Width = "45"
        GridView1.Columns("nama_harga").Width = 200
        GridView1.Columns("harga").Width = 100

        FormatColumnNumeric(GridView1.Columns("harga"))

        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns.Item("harga").OptionsColumn.AllowEdit = True

        GridView1.Columns("kode_hargajual").Visible = False

    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        Dim i As Integer

        Connection.TRANS_START()

        For i = 0 To rcd_list.Count - 1
            '# Update table tbl_hargajual
            Db.FlushCache()
            Db.Update("tbl_hargajual")
            Db.SetField("harga", rcd_list.Item(i).harga)
            Db.Where("kode_hargajual", rcd_list.Item(i).kode_hargajual)

            Connection.TRANS_ADD(Db.GetQueryString)

        Next

        If Connection.TRANS_SUCCESS Then
            MsgBox("Data berhasil diperbaharui", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox(Connection.TRANS_MESSAGE, MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub GridControl1_EditorKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.EditorKeyPress
        Dim grid As GridControl = CType(sender, GridControl)
        GridView1_KeyPress(grid.FocusedView, e)
    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
        Dim view As GridView = CType(sender, GridView)
        Dim row As Integer = view.FocusedRowHandle

        If Asc(e.KeyChar) = 13 Then
            Select Case view.FocusedColumn.FieldName
                Case "harga"
                    If row < GridView1.RowCount - 1 Then
                        setFocusCell(GridView1, row + 1, "harga")
                    Else
                        setFocusCell(GridView1, 0, "harga")
                    End If
            End Select
        End If
    End Sub



End Class