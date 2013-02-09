Imports DevExpress.XtraEditors.Repository

Public Class frm_userlevel_add

    Private emptyEditor As RepositoryItemButtonEdit
    Public db_list As New System.ComponentModel.BindingList(Of rcd_level)

    Sub initGrid()

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

    Private Sub frm_userlevel_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '# init repositori gridcontrol
        emptyEditor = New RepositoryItemButtonEdit()
        emptyEditor.Buttons.Clear()
        emptyEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        grid_level.RepositoryItems.Add(emptyEditor)

        ' init Grid
        Db.FlushCache()
        Db.Selects("*")
        Db.From("sys_menu")

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            ' insert to databinding
            With Connection.Read
                While .Read
                    db_list.Add(New rcd_level(.Item("kode_menu").ToString, .Item("nama_menu").ToString, True, True, True, True, True, .Item("group"), .Item("aksi")))
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

            '# transaksi
            Connection.TRANS_START()

            '# insert to table useraccess
            Db.FlushCache()
            Db.Insert("sys_level")
            Db.SetField("kode_level", txt_kd_level.Text)
            Db.SetField("nama_level", txt_nama_level.Text)

            Connection.TRANS_ADD(Db.GetQueryString)

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

                Connection.TRANS_ADD(Db.GetQueryString)
            Next

            If Connection.TRANS_SUCCESS Then
                frm_user_list.InitGrid()
                Me.Close()
            End If

        Else
            Validation.showMessage()
        End If
    End Sub


    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
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