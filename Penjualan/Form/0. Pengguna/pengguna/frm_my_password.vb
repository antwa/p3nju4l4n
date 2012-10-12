Public Class frm_my_password 

    Dim oldPassword As String

	
    Public Sub initData()
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_user")
        Db.Where("username", Auth.Username)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read

                .Read()
                txt_username.Text = .Item("username").ToString
                oldPassword = .Item("password").ToString

            End With
        End If

    End Sub

    Private Sub frm_my_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initData()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_old_password.Text, "Password Lama", "required|password")
        Validation.addRules(txt_new_password.Text, "Password Baru", "required|password")
        Validation.addRules(txt_new_password_confirm.Text, "Ulangi Password", "required|matches[Password Baru]")

        If Validation.isValid Then

            '# cek password lama
            If txt_old_password.Text <> oldPassword Then
                MsgBox("Maaf, Kata sandi lama yang anda masukan salah!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Pesan")
                Exit Sub

            Else
                Db.FlushCache()
                Db.Update("sys_user")
                Db.SetField("password", txt_new_password.Text)
                Db.Where("username", txt_username.Text)

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Perubahan kata sandi berhasil disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Me.Close()
                End If

            End If

        Else
            Validation.showMessage()
        End If

    End Sub
End Class