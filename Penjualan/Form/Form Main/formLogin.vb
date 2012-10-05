Public Class formLogin 

    Private Sub cmd_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_login.Click

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_username.Text, "Username", "required|username|length[5-20]")
        Validation.addRules(txt_password.Text, "Password", "required|password")

        '# cek validasi
        If Validation.isValid Then

            '# create query
            Db.FlushCache()
            Db.Selects("PRO_USER.US_USERNAME, PRO_USER.USL_KDLEVEL, PRO_USER.US_NAMALENGKAP, PRO_USER.US_JABATAN, PRO_USER_LEVEL.USL_NAMA")
            Db.From("PRO_USER")
            Db.Join("PRO_USER_LEVEL", "PRO_USER.USL_KDLEVEL = PRO_USER_LEVEL.USL_KDLEVEL")
            Db.Where("PRO_USER.US_USERNAME", txt_username.Text)
            Db.Where("PRO_USER.US_PASSWORD", txt_password.Text, "=", "AND")

            ' put to datareader
            Dim dr As SqlClient.SqlDataReader
            dr = Connection.ExecuteToDataReader(Db.GetQueryString)

            '# cek row
            If dr.HasRows Then

                'init Auth
                Auth = New cls_authentication

                dr.Read()
                Auth.Username = dr.Item("US_USERNAME").ToString
                Auth.KdLevel = dr.Item("USL_KDLEVEL").ToString
                Auth.Nama = dr.Item("US_NAMALENGKAP").ToString
                Auth.Jabatan = dr.Item("US_JABATAN").ToString
                Auth.NamaAkses = dr.Item("USL_NAMA").ToString

                '# ambil auth form
                Db.FlushCache()
                Db.Selects("PRO_USER.US_USERNAME, PRO_USER_LEVEL.USL_KDLEVEL, PRO_USER_MENU.USM_KDMENU, PRO_USER_MENU.USM_NAME, PRO_USER_MENU.USM_FORM, PRO_USER_LEVEL_DETAIL.USLD_A, PRO_USER_LEVEL_DETAIL.USLD_I, PRO_USER_LEVEL_DETAIL.USLD_U, PRO_USER_LEVEL_DETAIL.USLD_D, PRO_USER_LEVEL_DETAIL.USLD_V")
                Db.From("PRO_USER")
                Db.Join("PRO_USER_LEVEL", "PRO_USER.USL_KDLEVEL = PRO_USER_LEVEL.USL_KDLEVEL")
                Db.Join("PRO_USER_LEVEL_DETAIL", "PRO_USER_LEVEL.USL_KDLEVEL = PRO_USER_LEVEL_DETAIL.USL_KDLEVEL")
                Db.Join("PRO_USER_MENU", "PRO_USER_LEVEL_DETAIL.USM_KDMENU = PRO_USER_MENU.USM_KDMENU")
                Db.Where("PRO_USER.US_USERNAME", txt_username.Text)

                ' put to datareader
                dr = Connection.ExecuteToDataReader(Db.GetQueryString)

                While dr.Read
                    Auth.addAuth(dr.Item("USM_KDMENU").ToString, dr.Item("USM_NAME").ToString, dr.Item("USM_FORM").ToString, CBool(dr.Item("USLD_A").ToString), CBool(dr.Item("USLD_I").ToString), CBool(dr.Item("USLD_U").ToString), CBool(dr.Item("USLD_D").ToString), CBool(dr.Item("USLD_V").ToString))
                End While

                formMDI.Show()
                Me.Close()
            Else
                MsgBox("Login Gagal...." & vbCrLf & "Pastikan Username dan Password diisi dengan benar!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Login")
            End If

        Else
            Validation.showMessage()
        End If
    End Sub

    Private Sub formLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_username.Focus()
    End Sub

    Private Sub formLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' load init aplikasi
        Call init_aplikasi()

        Me.Text = "Aplikasi Produksi Versi " & APP.Version

    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cmd_login_Click(sender, e)
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'Db.FlushCache()
        'Db.Selects("Convert(varchar, CK_TANGGAL, 111) AS Tanggal")
        'Db.From("PRO_CUTTING_KELUAR")

        'Connection.ExecuteToDataReader(Db.GetQueryString)

        'If Connection.Read.HasRows Then
        '    Connection.Read.Read()
        '    MsgBox(Connection.Read.Item("Tanggal").ToString)
        'End If

        'Dim dt1 As Date = "12/08/2012"
        'Dim dt2 As Date = "06/09/2012"

        'If dt1 < dt2 Then
        '    MsgBox("kecil")
        'End If

        frm_uji_coba.Show()

    End Sub

End Class