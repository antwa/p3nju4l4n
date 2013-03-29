Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frm_barangjadi_add_formula

    Public vkode_barangjadi As String
    Public vnama As String

    Public rcd_list As New DataTable

    Private Sub frm_barangjadi_add_formula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kode_barangjadi.Text = vkode_barangjadi
        lbl_nama.Text = vnama

        rcd_list = New DataTable
        rcd_list.Columns.Add("kode_template_harga", GetType(String))
        rcd_list.Columns.Add("nama_harga", GetType(String))
        rcd_list.Columns.Add("harga", GetType(Integer))

        '# load template harga jual
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_template_hargajual")
        Db.OrderBy("kode_template_harga", cls_database.sorting.Ascending)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                While rcd.Read
                    rcd_list.Rows.Add(New Object() {.Item("kode_template_harga").ToString, .Item("nama_harga").ToString, 0})
                End While
            End With
        End If


        GridControl1.DataSource = rcd_list

        GridView1.Columns("kode_template_harga").Caption = "No."
        GridView1.Columns("nama_harga").Caption = "Nama Harga"
        GridView1.Columns("harga").Caption = "Harga (Rp.)"

        GridView1.Columns("kode_template_harga").Width = 50
        GridView1.Columns("nama_harga").Width = 250
        GridView1.Columns("harga").Width = 100

        GridView1.Columns("kode_template_harga").OptionsColumn.AllowEdit = False
        GridView1.Columns("nama_harga").OptionsColumn.AllowEdit = False

        FormatColumnNumeric(GridView1.Columns("harga"))

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim i As Integer

        '#Validation
        If rcd_list.Rows.Count = 0 Then
            MsgBox("Data harga tidak boleh kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        For i = 0 To rcd_list.Rows.Count - 1

            '# insert to table tbl_hargajual
            Db.FlushCache()
            Db.Insert("tbl_hargajual")
            Db.SetField("kode_barangjadi", kode_barangjadi.Text)
            Db.SetField("kode_template_harga", GridView1.GetDataRow(i).Item("kode_template_harga"))
            Db.SetField("harga", GridView1.GetDataRow(i).Item("harga"))

            Connection.TRANS_ADD(Db.GetQueryString)

        Next

        Me.Close()
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