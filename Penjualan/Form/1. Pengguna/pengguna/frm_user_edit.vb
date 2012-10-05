Public Class frm_user_edit 

    Private Sub initLookup()
        ' init look level
        ' level
        Db.FlushCache()
        Db.Selects("USL_KDLEVEL, USL_NAMA")
        Db.From("PRO_USER_LEVEL")

        look_levelAccess.Properties.HotTrackItems = False
        look_levelAccess.Properties.DisplayMember = "USL_NAMA"
        look_levelAccess.Properties.ValueMember = "USL_KDLEVEL"
        look_levelAccess.Properties.PopupWidth = 250
        look_levelAccess.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        look_levelAccess.Properties.PopulateColumns()
        look_levelAccess.Properties.Columns(0).Caption = "Kode Level"
        look_levelAccess.Properties.Columns(1).Caption = "Nama Level"

        'look_levelAccess.ItemIndex = 0
        'look_levelAccess.EditValue = "PRG"
    End Sub

    Public Sub initData(ByVal username As String)

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("PRO_USER")
        Db.Where("US_USERNAME", username)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_username.Text = .Item("US_USERNAME").ToString
                txt_password.Text = .Item("US_PASSWORD").ToString
                txt_confirmPassword.Text = .Item("US_PASSWORD").ToString
                txt_namaLengkap.Text = .Item("US_NAMALENGKAP").ToString
                txt_jabatan.Text = .Item("US_JABATAN").ToString

                look_levelAccess.EditValue = .Item("USL_KDLEVEL").ToString
            End With
        End If

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        Dim kd_access As String = look_levelAccess.Properties.GetKeyValueByDisplayText(look_levelAccess.Text)

        Validation.clearRules()
        Validation.addRules(txt_username.Text, "Username", "required|username|length[3-20]")
        Validation.addRules(txt_password.Text, "Password", "required|password|matches[Password Confirm]")
        Validation.addRules(txt_confirmPassword.Text, "Password Confirm", "required")
        Validation.addRules(txt_namaLengkap.Text, "Nama Lengkap", "required|alpha|length[1-50]")
        Validation.addRules(txt_jabatan.Text, "Jabatan", "required")

        If Validation.isValid() Then

            '# proses update
            Db.FlushCache()
            Db.Update("PRO_USER")
            Db.SetField("US_USERNAME", txt_username.Text)
            Db.SetField("US_PASSWORD", txt_password.Text)
            Db.SetField("USL_KDLEVEL", kd_access)
            Db.SetField("US_NAMALENGKAP", txt_namaLengkap.Text)
            Db.SetField("US_JABATAN", txt_jabatan.Text)
            Db.Where("US_USERNAME", txt_username.Text)

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                frm_user_list.InitGrid()
                Me.Close()
            End If

        Else
            Validation.showMessage()
        End If

    End Sub

    Private Sub frm_user_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initLookup()
    End Sub
End Class