Public Class frm_user_add 

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim kd_access As String = look_levelAccess.Properties.GetKeyValueByDisplayText(look_levelAccess.Text)

        '# cek username di database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_user")
        Db.Where("username", txt_username.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat Username pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        ' validation
        Validation.clearRules()
        Validation.addRules(txt_username.Text, "Username", "required|username|length[3-20]")
        Validation.addRules(txt_password.Text, "Password", "required|password|matches[Password Confirm]")
        Validation.addRules(txt_confirmPassword.Text, "Password Confirm", "required")
        Validation.addRules(txt_namaLengkap.Text, "Nama Lengkap", "required|alpha|length[1-50]")
        Validation.addRules(txt_jabatan.Text, "Jabatan", "required")

        If Validation.isValid() Then

            '# proses insert
            Db.FlushCache()
            Db.Insert("sys_user")
            Db.SetField("username", txt_username.Text)
            Db.SetField("password", txt_password.Text)
            Db.SetField("kode_level", kd_access)
            Db.SetField("nama_lengkap", txt_namaLengkap.Text)
            Db.SetField("jabatan", txt_jabatan.Text)

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                frm_user_list.InitGrid()

                Me.Close()
            End If

        Else
            Validation.showMessage()
        End If

    End Sub

    Private Sub frm_user_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' init look level
        ' level
        Db.FlushCache()
        Db.Selects("kode_level, nama_level")
        Db.From("sys_level")

        look_levelAccess.Properties.HotTrackItems = False
        look_levelAccess.Properties.DisplayMember = "nama_level"
        look_levelAccess.Properties.ValueMember = "kode_level"
        look_levelAccess.Properties.PopupWidth = 250
        look_levelAccess.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        look_levelAccess.Properties.PopulateColumns()
        look_levelAccess.Properties.Columns(0).Caption = "Kode Level"
        look_levelAccess.Properties.Columns(1).Caption = "Nama Level"

        look_levelAccess.ItemIndex = 0
        'look_levelAccess.EditValue = "PRG"

    End Sub
End Class