Public Class frm_userlevel_add

    Public db_list As New System.ComponentModel.BindingList(Of rcd_level)

    Sub initGrid()
        grid_level.DataSource = db_list
        GridV_level.Columns(0).Visible = False
        GridV_level.Columns(1).Width = 250
        GridV_level.Columns(2).Width = 50
        GridV_level.Columns(3).Width = 50
        GridV_level.Columns(4).Width = 50
        GridV_level.Columns(5).Width = 50
        GridV_level.Columns(6).Width = 50

        GridV_level.Columns(7).Caption = "Bagian"
        GridV_level.Columns(7).GroupIndex = 0
        GridV_level.ExpandAllGroups()

        GridV_level.Columns(6).Visible = False

    End Sub

    Private Sub frm_userlevel_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' init Grid
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_menu")

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            ' insert to databinding
            With Connection.Read
                While .Read
                    db_list.Add(New rcd_level(.Item("kode_menu").ToString, .Item("nama_menu").ToString, True, True, True, True, True, .Item("group")))
                End While
            End With
            Call initGrid()
        End If

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        ' kamus
        Dim i As Integer

        ' validation
        Validation.clearRules()
        Validation.addRules(txt_kd_level.Text, "Kode Level", "required|alphanumeric|length[2-10]")
        Validation.addRules(txt_nama_level.Text, "Nama Level", "required|length[2-30]")

        'cek kd access
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_level")
        Db.Where("kode_level", txt_kd_level.Text)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            MsgBox("Sudah terdapat Kode Level pada database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.OkOnly, "Pesan")
            Exit Sub
        End If

        ' run validation
        If Validation.isValid Then

            '# insert to table useraccess
            Db.FlushCache()
            Db.Insert("sys_level")
            Db.SetField("kode_level", txt_kd_level.Text)
            Db.SetField("nama_level", txt_nama_level.Text)

            Connection.ExecuteNonQuery(Db.GetQueryString)

            '# insert to table useraccess detail
            For i = 0 To db_list.Count - 1
                Db.FlushCache()
                Db.Insert("sys_level_detail")
                Db.SetField("kode_level", txt_kd_level.Text)
                Db.SetField("kode_menu", db_list.Item(i).KdMenu)
                Db.SetField("_access", IIf(db_list.Item(i).Access = True, "1", "0"))
                Db.SetField("_insert", IIf(db_list.Item(i).Insert = True, "1", "0"))
                Db.SetField("_update", IIf(db_list.Item(i).Update = True, "1", "0"))
                Db.SetField("_delete", IIf(db_list.Item(i).Delete = True, "1", "0"))
                Db.SetField("_view", IIf(db_list.Item(i).View = True, "1", "0"))

                Connection.ExecuteNonQuery(Db.GetQueryString)
            Next

            frm_user_list.InitGrid()
            Me.Close()

        Else
            Validation.showMessage()
        End If
    End Sub


    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub
End Class