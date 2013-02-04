Public Class frm_wilayah_list 

    Public Sub LoadData_Provinsi()
        Db.FlushCache()
        Db.Selects("kode_provinsi, provinsi")
        Db.From("tbl_provinsi")
        Db.OrderBy("kode_provinsi")

        gridcontrol_provinsi.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        gridview_provinsi.Columns("kode_provinsi").Caption = "Kode Provinsi"
        gridview_provinsi.Columns("provinsi").Caption = "Provinsi"

    End Sub

    Public Sub LoadData_Kota()
        Db.FlushCache()
        Db.Selects("a.kode_kota, a.kota, b.provinsi")
        Db.From("tbl_kota a")
        Db.Join("tbl_provinsi b", "b.kode_provinsi = a.kode_provinsi")
        Db.OrderBy("a.kode_kota")

        gridcontrol_kota.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        gridview_kota.Columns(0).Caption = "Kode"
        gridview_kota.Columns(1).Caption = "Kota"
        gridview_kota.Columns(2).Caption = "Provinsi"

    End Sub

    Public Sub LoadData_Group()
        Db.FlushCache()
        Db.Selects("kode_grup, grup")
        Db.From("tbl_grup")
        Db.OrderBy("kode_grup")

        gridcontrol_group.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        gridview_group.Columns(0).Caption = "Kode Group"
        gridview_group.Columns(1).Caption = "Group"

    End Sub

    Public Sub LoadData_Zona()
        Db.FlushCache()
        Db.Selects("kode_zona, zona")
        Db.From("tbl_zona")
        Db.OrderBy("kode_zona")

        gridcontrol_zona.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        gridview_zona.Columns(0).Caption = "Kode Zona"
        gridview_zona.Columns(1).Caption = "Zona"
    End Sub

    Private Sub frm_wilayah_list_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Me.LoadData_Provinsi()
        Call Me.LoadData_Kota()
        Call Me.LoadData_Group()
        Call Me.LoadData_Zona()
    End Sub

    Private Sub cmd_prov_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_prov_add.Click
        frm_provinsi_add.Dispose()
        frm_provinsi_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_prov_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_prov_edit.Click
        Try
            Dim row As System.Data.DataRow = gridview_provinsi.GetDataRow(gridview_provinsi.FocusedRowHandle)
            frm_provinsi_edit.Dispose()
            frm_provinsi_edit.kode_provinsi = row("kode_provinsi")
            frm_provinsi_edit.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_prov_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_prov_delete.Click
        Try
            Dim row As System.Data.DataRow = gridview_provinsi.GetDataRow(gridview_provinsi.FocusedRowHandle)
            If MsgBox("Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_provinsi")
                Db.Where("kode_provinsi", row("kode_provinsi"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.LoadData_Provinsi()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_prov_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_prov_refresh.Click
        Call Me.LoadData_Provinsi()
    End Sub

    Private Sub cmd_kota_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_kota_add.Click
        frm_kota_add.Dispose()
        frm_kota_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_kota_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_kota_edit.Click
        Try
            Dim row As System.Data.DataRow = gridview_kota.GetDataRow(gridview_kota.FocusedRowHandle)
            frm_kota_edit.Dispose()
            frm_kota_edit.Kode_kota = row("kode_kota")
            frm_kota_edit.ShowDialog(Me)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub cmd_kota_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_kota_delete.Click
        Try
            Dim row As System.Data.DataRow = gridview_kota.GetDataRow(gridview_kota.FocusedRowHandle)
            If MsgBox("Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_kota")
                Db.Where("kode_kota", row("kode_kota"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.LoadData_Kota()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_kota_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_kota_refresh.Click
        Call Me.LoadData_Kota()
    End Sub

    Private Sub cmd_group_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_group_add.Click
        frm_group_add.Dispose()
        frm_group_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_group_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_group_edit.Click
        Try
            Dim row As System.Data.DataRow = gridview_group.GetDataRow(gridview_group.FocusedRowHandle)
            frm_group_edit.Dispose()
            frm_group_edit.Kode_group = row("kode_grup")
            frm_group_edit.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_group_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_group_delete.Click
        Try
            Dim row As System.Data.DataRow = gridview_group.GetDataRow(gridview_group.FocusedRowHandle)
            If MsgBox("Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_grup")
                Db.Where("kode_grup", row("kode_grup"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.LoadData_Group()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_group_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_group_refresh.Click
        Call Me.LoadData_Group()
    End Sub

    Private Sub cmd_zona_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_zona_add.Click
        frm_zona_add.Dispose()
        frm_zona_add.ShowDialog(Me)
    End Sub

    Private Sub cmd_zona_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_zona_edit.Click
        Try
            Dim row As System.Data.DataRow = gridview_zona.GetDataRow(gridview_zona.FocusedRowHandle)
            frm_zona_edit.Dispose()
            frm_zona_edit.kode_zona = row("kode_zona")
            frm_zona_edit.ShowDialog(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_zona_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_zona_hapus.Click
        Try
            Dim row As System.Data.DataRow = gridview_zona.GetDataRow(gridview_zona.FocusedRowHandle)
            If MsgBox("Apakah anda yakin akan menghapus data di atas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan") = MsgBoxResult.Yes Then

                Db.FlushCache()
                Db.Delete("tbl_zona")
                Db.Where("kode_zona", row("kode_zona"))

                If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                    MsgBox("Data berhasil dihapus dari database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                    Call Me.LoadData_Zona()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_zona_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_zona_refresh.Click
        Call Me.LoadData_Zona()
    End Sub
End Class