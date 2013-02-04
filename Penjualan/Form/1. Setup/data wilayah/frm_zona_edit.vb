Public Class frm_zona_edit 

    Public kode_zona As String

    Public Sub PopulateField()

        ' get data from database
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_zona")
        Db.Where("kode_zona", Me.kode_zona)

        Connection.ExecuteToDataReader(Db.GetQueryString)

        If Connection.Read.HasRows Then
            With Connection.Read
                .Read()

                txt_kode_zona.Text = .Item("kode_zona").ToString
                txt_zona.Text = .Item("zona").ToString

            End With
        End If

    End Sub

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# Validasi
        Validation.clearRules()
        Validation.addRules(txt_zona.Text, "Zona", "required|length[1-50]")

        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# Update table tbl_zona
        Db.FlushCache()
        Db.Update("tbl_zona")
        Db.SetField("zona", txt_zona.Text)
        Db.Where("kode_zona", txt_kode_zona.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_wilayah_list.LoadData_Zona()
            Me.Close()
        End If
    End Sub

    Private Sub frm_zona_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_zona_edit_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Me.PopulateField()
    End Sub
End Class