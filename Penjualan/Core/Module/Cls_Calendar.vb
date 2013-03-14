Public Class Cls_Calendar

    Dim nday(42) As DevExpress.XtraEditors.CheckEdit
    Dim nNameDay(7) As Label
    Dim garis As New PictureBox
    Dim mBulan As Integer
    Dim mTahun As Integer

    Public Sub New(ByRef panel As DevExpress.XtraEditors.PanelControl)

        ' instanisasi
        For i = 0 To 41
            nday(i) = New DevExpress.XtraEditors.CheckEdit
            nday(i).BackColor = Color.White
            nday(i).BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
            nday(i).Checked = False
            nday(i).Font = New Font("Tahoma", 9, FontStyle.Regular)
            nday(i).Text = vbNullString
            nday(i).ForeColor = Color.Black
            nday(i).Width = 41
            nday(i).Height = 23
            nday(i).Visible = True
        Next
        nday(0).ForeColor = Color.Red
        nday(7).ForeColor = Color.Red
        nday(14).ForeColor = Color.Red
        nday(21).ForeColor = Color.Red
        nday(28).ForeColor = Color.Red
        nday(35).ForeColor = Color.Red



        Dim curday As Integer = 0
        Dim NX As Integer = 0
        Dim NY As Integer = 0

        ' Create Header
        NX = 8
        For i = 0 To 6
            nNameDay(i) = New Label
            nNameDay(i).BackColor = Color.White
            nNameDay(i).BorderStyle = BorderStyle.FixedSingle
            nNameDay(i).Font = New Font("Tahoma", 9, FontStyle.Bold)
            nNameDay(i).ForeColor = Color.Black
            nNameDay(i).TextAlign = ContentAlignment.MiddleCenter
            nNameDay(i).Width = 41
            nNameDay(i).Height = 23
            nNameDay(i).Visible = True
            nNameDay(i).Location = New Point(NX, 9)

            panel.Controls.Add(nNameDay(i))

            NX += 46
        Next
        nNameDay(0).ForeColor = Color.Red
        nNameDay(0).Text = "Ming"
        nNameDay(1).Text = "Sen"
        nNameDay(2).Text = "Sel"
        nNameDay(3).Text = "Rab"
        nNameDay(4).Text = "Kam"
        nNameDay(5).Text = "Jum"
        nNameDay(6).Text = "Sab"

        ' create garis
        garis.BackColor = Color.Gainsboro
        garis.Location = New Point(6, 36)
        garis.Width = 324
        garis.Height = 2

        panel.Controls.Add(garis)

        ' create day
        NY = 43
        For y = 0 To 5
            NX = 8
            For x = 0 To 6
                nday(curday).Location = New Point(NX, NY)
                nday(curday).Text = curday
                panel.Controls.Add(nday(curday))

                NX += 46
                curday += 1
            Next
            NY += 28
        Next


        panel.Width = 336
        panel.Height = 215
    End Sub

    Public Sub CreateCalendar(ByVal bulan As Integer, ByVal tahun As Integer)
        Dim tmpDate As Date = "1/" & bulan & "/" & tahun
        Dim HariPertama As Integer = tmpDate.DayOfWeek
        Dim Jumlahhari As Integer = System.DateTime.DaysInMonth(tahun, bulan)

        For i = 0 To 41
            nday(i).Visible = False
            nday(i).Checked = False
            nday(i).Text = vbNullString
        Next

        Dim count As Integer = HariPertama + Jumlahhari
        Dim x As Integer = 1

        For i = HariPertama To count - 1
            nday(i).Text = x
            nday(i).Visible = True
            x += 1
        Next

        Me.mBulan = bulan
        Me.mTahun = tahun

    End Sub

    Public Function getCount() As Integer
        Dim count As Integer = 0
        For i = 0 To 41
            If nday(i).Checked = True Then
                count += 1
            End If
        Next

        Return count
    End Function

    Public Function getItem() As String()
        Dim mylist As New List(Of String)

        For i = 0 To 41
            If nday(i).Checked = True Then
                mylist.Add(CStr(Me.mTahun) & "-" & Format(Me.mBulan, "00") & "-" & Format(CInt(nday(i).Text), "00"))
            End If
        Next

        Return mylist.ToArray
    End Function

    Public Sub UnCheckAll()
        For i = 0 To 41
            nday(i).Checked = False
        Next
    End Sub

End Class
