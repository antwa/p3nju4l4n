Public Class frm_group_edit 

    Public kode_group As String

    Public Sub PopulateField()

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_grup")
        Db.Where("kode_grup", Me.kode_group)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_group.Text = .Item("kode_grup").ToString
                txt_group.Text = .Item("grup").ToString

            End With
        End If

    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# validation
        Validation.clearRules()
        Validation.addRules(txt_group.Text, "Group", "required|length[1-20]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_group
        Db.FlushCache()
        Db.Update("tbl_grup")
        Db.SetField("grup", txt_group.Text)
        Db.Where("kode_grup", txt_kode_group.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Group()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub frm_group_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.PopulateField()
    End Sub

    Private Sub frm_group_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class