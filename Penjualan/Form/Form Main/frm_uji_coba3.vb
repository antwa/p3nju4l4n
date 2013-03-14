Public Class frm_uji_coba3 
    Dim xx As Cls_Calendar

    Private Sub frm_uji_coba3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim xx As New DevExpress.XtraEditors.SimpleButton
        'xx.Text = "yanto"
        'xx.Width = 30
        'xx.Height = 20
        'xx.Location = New Point(10, 10)
        'xx.Visible = True

        'PanelControl1.Controls.Add(xx)

        Dim hari_pertama As Date = "1/8/2013"

        'MsgBox(System.DateTime.DaysInMonth(2013, 2))

        xx = New Cls_Calendar(PanelControl2)
        xx.CreateCalendar(2, 2013)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        xx.CreateCalendar(TextEdit1.Text, TextEdit2.Text)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim item() As String = xx.getItem()

        For i = 0 To item.Count - 1
            MsgBox(item(i))
        Next

    End Sub
End Class