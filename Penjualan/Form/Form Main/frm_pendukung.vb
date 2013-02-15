Public Class frm_pendukung 

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_menu")
        Db.OrderBy("[group]")

        Dim dt As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)
        Dim i As Integer
        Dim str As String = ""

        For i = 0 To dt.Rows.Count - 1
            str &= "CM_" & dt.Rows(i).Item("form") & ".Enabled = Auth.canAccess(" & dt.Rows(i).Item("form") & ".Name)" & vbCrLf
        Next

        My.Computer.Clipboard.SetText(str)
        MsgBox("data berhasil disalin")

    End Sub


    Private Sub frm_pendukung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call init_aplikasi()
    End Sub
End Class