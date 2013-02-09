Imports DevExpress.XtraEditors.Repository

Public Class frm_userlevel_edit

    Private emptyEditor As RepositoryItemButtonEdit
    Public db_list As New System.ComponentModel.BindingList(Of rcd_level)

    Sub initGrid()
        '# init repositori gridcontrol
        emptyEditor = New RepositoryItemButtonEdit()
        emptyEditor.Buttons.Clear()
        emptyEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        grid_level.RepositoryItems.Add(emptyEditor)

        grid_level.DataSource = db_list

        GridV_level.Columns("KdMenu").Visible = False
        GridV_level.Columns("NamaMenu").Caption = "Nama Menu"
        'GridV_level.Columns("Access").Caption = ""
        'GridV_level.Columns("Insert").Caption = ""
        'GridV_level.Columns("Update").Caption = ""
        'GridV_level.Columns("Delete").Caption = ""
        GridV_level.Columns("View").Visible = False
        GridV_level.Columns("Groups").Caption = "Bagian"
        GridV_level.Columns("Aksi_cell").Visible = False

        'GridV_level.Columns("KdMenu").Width = 75
        GridV_level.Columns("NamaMenu").Width = 250
        GridV_level.Columns("Access").Width = 50
        GridV_level.Columns("Insert").Width = 50
        GridV_level.Columns("Update").Width = 50
        GridV_level.Columns("Delete").Width = 50
        GridV_level.Columns("View").Width = 50
        GridV_level.Columns("Groups").Width = 75
        'GridV_level.Columns("Aksi_cell").Width = 75

        '# enable
        GridV_level.Columns.Item("NamaMenu").OptionsColumn.AllowEdit = False

        ' Atur warna cell
        GridV_level.Columns.Item("Access").AppearanceCell.BackColor = Color.GreenYellow
        GridV_level.Columns.Item("Insert").AppearanceCell.BackColor = Color.LightCyan
        GridV_level.Columns.Item("Update").AppearanceCell.BackColor = Color.LightCyan
        GridV_level.Columns.Item("Delete").AppearanceCell.BackColor = Color.LightCyan
        'GridV_level.Columns.Item("").AppearanceCell.BackColor = Color.LightCyan

        GridV_level.Columns("Groups").GroupIndex = 0

        GridV_level.ExpandAllGroups()


    End Sub

    Public Sub initData(ByVal kd_level As String, ByVal nama_level As String)
        Dim arrAuth(5) As Boolean

        ' temp auth
        Dim tmpAuth As New cls_authentication

        '# ambil level berdasarkan kd level dan masukan ke temp auth
        Db.FlushCache()
        Db.Selects("a.kode_level, b.kode_menu, c.nama_menu, c.form, b._access, b._insert, b._update, b._delete, b._view")
        Db.From("sys_level a")
        Db.Join("sys_level_detail b", "a.kode_level = b.kode_level")
        Db.Join("sys_menu c", "b.kode_menu = c.kode_menu")
        Db.Where("a.kode_level", kd_level)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                While .Read
                    tmpAuth.addAuth(.Item("kode_menu").ToString, .Item("nama_menu").ToString, .Item("form").ToString, CBool(.Item("_access").ToString), CBool(.Item("_insert").ToString), CBool(.Item("_update").ToString), CBool(.Item("_delete").ToString), CBool(.Item("_view").ToString))
                End While
            End With
        End If

        '# ambil menu yg di table
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_menu")

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            '# input to db list
            With Connection.Read
                While .Read
                    arrAuth = tmpAuth.getAllAuth(.Item("kode_menu").ToString)
                    db_list.Add(New rcd_level(.Item("kode_menu").ToString, .Item("nama_menu").ToString, arrAuth(0), arrAuth(1), arrAuth(2), arrAuth(3), arrAuth(4), .Item("group"), .Item("aksi")))
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
            Db.Update("sys_level")
            Db.SetField("nama_level", txt_nama_level.Text)
            Db.Where("kode_level", txt_kd_level.Text)

            Connection.ExecuteNonQuery(Db.GetQueryString)

            '# insert to table useraccess detail
            '  pertama delete dulu semua row pro_useraccess_detail berdasarkan kd_access
            '  lalu masukan auth yg baru
            Db.FlushCache()
            Db.Delete("sys_level_detail")
            Db.Where("kode_level", txt_kd_level.Text)

            Connection.ExecuteNonQuery(Db.GetQueryString)

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

    Private Sub frm_userlevel_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub GridV_level_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GridV_level.CustomRowCellEdit
        If e.Column.FieldName = "Access" Then
            If db_list.Item(e.RowHandle).Aksi_cell.Substring(0, 1) = "0" Then
                e.RepositoryItem = emptyEditor
            End If

        ElseIf e.Column.FieldName = "Insert" Then
            If db_list.Item(e.RowHandle).Aksi_cell.Substring(1, 1) = "0" Then
                e.RepositoryItem = emptyEditor
            End If

        ElseIf e.Column.FieldName = "Update" Then
            If db_list.Item(e.RowHandle).Aksi_cell.Substring(2, 1) = "0" Then
                e.RepositoryItem = emptyEditor
            End If

        ElseIf e.Column.FieldName = "Delete" Then
            If db_list.Item(e.RowHandle).Aksi_cell.Substring(3, 1) = "0" Then
                e.RepositoryItem = emptyEditor
            End If

        ElseIf e.Column.FieldName = "View" Then
            If db_list.Item(e.RowHandle).Aksi_cell.Substring(4, 1) = "0" Then
                e.RepositoryItem = emptyEditor
            End If

        End If
    End Sub

End Class