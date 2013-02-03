Imports DevExpress.XtraTreeList.Nodes

Public Class frm_uji_coba2

    Private Sub frm_uji_coba2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim data As New DataTable
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("PARENT_ID", GetType(String))
        data.Columns.Add("NAMA", GetType(String))

        data.Rows.Add(New Object() {"1", "0", "Aktiva"})
        data.Rows.Add(New Object() {"11", "1", "Aktiva Lancar"})
        data.Rows.Add(New Object() {"12", "1", "Aktiva Tetap"})
        data.Rows.Add(New Object() {"111", "11", "Kas dan Bank"})
        data.Rows.Add(New Object() {"121", "12", "Bangunan"})

        data.Rows.Add(New Object() {"2", "0", "Kewajiban"})
        data.Rows.Add(New Object() {"21", "2", "Kewajiban Lancar"})
        data.Rows.Add(New Object() {"22", "2", "Kewajiban Tidak Lancar"})

        TreeList1.DataSource = data
        TreeList1.KeyFieldName = "ID"
        TreeList1.ParentFieldName = "PARENT_ID"
        TreeList1.PopulateColumns()
        TreeList1.Columns("NAMA").Visible = True
        TreeList1.ExpandAll()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim i As Integer
        ' init multi report
        Dim rpt_multi As New DevExpress.XtraReports.UI.XtraReport

        For i = 1 To 5
            Dim rpt As New rpt_retur_penerimaanbarang
            'rpt.BindingSource1.DataSource = rcd_list
            rpt.nomor_retur.Text = "Nomor : " & i
            rpt.tanggal.Text = "tan-" & i
            rpt.lbl_nama_supplier.Text = "Supplier " & i
            rpt.nomor_terima.Text = "no terima " & i
            rpt.lbl_tanggal_terima.Text = "tan-" & i
            rpt.CreateDocument() 'create doc

            rpt_multi.Pages.AddRange(rpt.Pages)
        Next

        Dim fc As New FormReportControl
        fc.Text = "Print Bukti Retur Barang"
        fc.PrintControl1.PrintingSystem = rpt_multi.PrintingSystem
        fc.Height = 600
        fc.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'Dim dt As New DataTable
        'dt.Columns.Add("kode", GetType(String))
        'dt.Columns.Add("qty", GetType(Integer))

        'dt.Rows.Add(New Object() {"K001", 2})
        'dt.Rows.Add(New Object() {"K001", 3})
        'dt.Rows.Add(New Object() {"K002", 1})
        'dt.Rows.Add(New Object() {"K003", 8})

        'Dim qry = From x In dt Group x By x.Item("kode") Into pGroup = Group Select x.Item("kode"), qty = pGroup.Sum(Function(x) x)

        'For Each xx In qry
        '    MsgBox("Kode : " & xx.kode.ToString & vbCrLf & "Qty : " & xx.qty.ToString, MsgBoxStyle.Information)
        'Next
    End Sub
End Class