Public Class FormLogin2


    Private Sub cmd_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_login.Click

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_username.Text, "Username", "required|username|length[1-20]")
        Validation.addRules(txt_password.Text, "Password", "required|password")

        '# cek validasi
        If Validation.isValid Then

            '# create query
            Db.FlushCache()
            Db.Selects("a.username, a.kode_level, a.nama_lengkap, a.jabatan, b.nama_level")
            Db.From("sys_user a")
            Db.Join("sys_level b", "a.kode_level = b.kode_level")
            Db.Where("a.username", txt_username.Text)
            Db.Where("a.password", txt_password.Text, "=", "AND")

            ' put to datareader
            Dim dr As SqlClient.SqlDataReader
            dr = Connection.ExecuteToDataReader(Db.GetQueryString)

            '# cek row
            If dr.HasRows Then

                'init Auth
                Auth = New cls_authentication

                dr.Read()
                Auth.Username = dr.Item("username").ToString
                Auth.KdLevel = dr.Item("kode_level").ToString
                Auth.Nama = dr.Item("nama_lengkap").ToString
                Auth.Jabatan = dr.Item("jabatan").ToString
                Auth.NamaAkses = dr.Item("nama_level").ToString

                '# ambil auth form
                Db.FlushCache()
                Db.Selects("a.username, b.kode_level, d.kode_menu, d.nama_menu, d.form, c._access, c._insert, c._update, c._delete, c._view")
                Db.From("sys_user a")
                Db.Join("sys_level b", "a.kode_level = b.kode_level")
                Db.Join("sys_level_detail c", "b.kode_level = c.kode_level")
                Db.Join("sys_menu d", "c.kode_menu = d.kode_menu")
                Db.Where("a.username", txt_username.Text)

                ' put to datareader
                dr = Connection.ExecuteToDataReader(Db.GetQueryString)

                While dr.Read
                    Auth.addAuth(dr.Item("kode_menu").ToString, dr.Item("nama_menu").ToString, dr.Item("form").ToString, CBool(dr.Item("_access").ToString), CBool(dr.Item("_insert").ToString), CBool(dr.Item("_update").ToString), CBool(dr.Item("_delete").ToString), CBool(dr.Item("_view").ToString))
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

        Me.Text = "Aplikasi Penjualan Versi " & APP.Version

    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cmd_login_Click(sender, e)
        End If
    End Sub
End Class