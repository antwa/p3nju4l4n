Public Class frm_userlevel_edit

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

    Public Sub initData(ByVal kd_level As String, ByVal nama_level As String)
        Dim arrAuth(5) As Boolean

        ' temp auth
        Dim tmpAuth As New cls_authentication

        '# ambil level berdasarkan kd level dan masukan ke temp auth
        Db.FlushCache()
        Db.Selects("PRO_USER_LEVEL.USL_KDLEVEL, PRO_USER_LEVEL_DETAIL.USM_KDMENU, PRO_USER_MENU.USM_NAME, PRO_USER_MENU.USM_FORM, PRO_USER_LEVEL_DETAIL.USLD_A, PRO_USER_LEVEL_DETAIL.USLD_I, PRO_USER_LEVEL_DETAIL.USLD_U, PRO_USER_LEVEL_DETAIL.USLD_D, PRO_USER_LEVEL_DETAIL.USLD_V")
        Db.From("PRO_USER_LEVEL")
        Db.Join("PRO_USER_LEVEL_DETAIL", "PRO_USER_LEVEL.USL_KDLEVEL = PRO_USER_LEVEL_DETAIL.USL_KDLEVEL")
        Db.Join("PRO_USER_MENU", "PRO_USER_LEVEL_DETAIL.USM_KDMENU = PRO_USER_MENU.USM_KDMENU")
        Db.Where("PRO_USER_LEVEL.USL_KDLEVEL", kd_level)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                While .Read
                    tmpAuth.addAuth(.Item("USM_KDMENU").ToString, .Item("USM_NAME").ToString, .Item("USM_FORM").ToString, CBool(.Item("USLD_A").ToString), CBool(.Item("USLD_I").ToString), CBool(.Item("USLD_U").ToString), CBool(.Item("USLD_D").ToString), CBool(.Item("USLD_V").ToString))
                End While
            End With
        End If

        '# ambil menu yg di table
        Db.FlushCache()
        Db.Selects("*")
        Db.From("PRO_USER_MENU")

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            '# input to db list
            With Connection.Read
                While .Read
                    arrAuth = tmpAuth.getAllAuth(.Item("USM_KDMENU").ToString)
                    db_list.Add(New rcd_level(.Item("USM_KDMENU").ToString, .Item("USM_NAME").ToString, arrAuth(0), arrAuth(1), arrAuth(2), arrAuth(3), arrAuth(4), .Item("USM_GROUP")))
                End While
            End With
        End If

        txt_kd_level.Text = kd_level
        txt_nama_level.Text = nama_level

        Call initGrid()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        ' kamus
        Dim i As Integer

        ' validation
        Validation.clearRules()
        Validation.addRules(txt_nama_level.Text, "Nama Level", "required|length[2-30]")

        ' run validation
        If Validation.isValid Then

            '# update to table useraccess
            Db.FlushCache()
            Db.Update("PRO_USER_LEVEL")
            Db.SetField("USL_NAMA", txt_nama_level.Text)
            Db.Where("USL_KDLEVEL", txt_kd_level.Text)

            Connection.ExecuteNonQuery(Db.GetQueryString)

            '# insert to table useraccess detail
            '  pertama delete dulu semua row pro_useraccess_detail berdasarkan kd_access
            '  lalu masukan auth yg baru
            Db.FlushCache()
            Db.Delete("PRO_USER_LEVEL_DETAIL")
            Db.Where("USL_KDLEVEL", txt_kd_level.Text)

            Connection.ExecuteNonQuery(Db.GetQueryString)

            For i = 0 To db_list.Count - 1
                Db.FlushCache()
                Db.Insert("PRO_USER_LEVEL_DETAIL")
                Db.SetField("USL_KDLEVEL", txt_kd_level.Text)
                Db.SetField("USM_KDMENU", db_list.Item(i).KdMenu)
                Db.SetField("USLD_A", IIf(db_list.Item(i).Access = True, "1", "0"))
                Db.SetField("USLD_I", IIf(db_list.Item(i).Insert = True, "1", "0"))
                Db.SetField("USLD_U", IIf(db_list.Item(i).Update = True, "1", "0"))
                Db.SetField("USLD_D", IIf(db_list.Item(i).Delete = True, "1", "0"))
                Db.SetField("USLD_V", IIf(db_list.Item(i).View = True, "1", "0"))

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

    Private Sub frm_userlevel_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class