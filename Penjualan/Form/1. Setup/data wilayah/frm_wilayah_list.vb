Public Class frm_wilayah_list 

    Public Sub InitGrid4()
        Db.FlushCache()
        Db.Selects("kode_provinsi, provinsi")
        Db.From("tbl_provinsi")

        grid_list4.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

    End Sub

    Public Sub InitGrid1()
        Db.FlushCache()
        Db.Selects("kode_kota, kota, kode_provinsi")
        Db.From("tbl_kota")

        grid_list1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
    End Sub

    Public Sub InitGrid3()
        Db.FlushCache()
        Db.Selects("kode_grup, grup")
        Db.From("tbl_grup")

        grid_list3.DataSource = Connection.ExecuteToDataReader(Db.GetQueryString)
    End Sub

    Public Sub InitGrid2()
        Db.FlushCache()
        Db.Selects("kode_zona, zona")
        Db.From("tbl_zona")

        grid_list2.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
    End Sub

    Public Sub loadData()
        Db.FlushCache()
        Db.Selects("kode_provinsi, provinsi")
        Db.From("tbl_provinsi")

        Db.OrderBy("kode_provinsi", cls_database.sorting.Ascending)

        grid_list4.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_provinsi.Columns("kode_provinsi").Caption = "Kode"
        GridV_provinsi.Columns("provinsi").Caption = "Provinsi"

        GridV_provinsi.Columns("kode_provinsi").Width = 40
        GridV_provinsi.Columns("provinsi").Width = 120
        '------------------------------------------------
        Db.FlushCache()
        Db.Selects("kode_kota, kota, kode_provinsi")
        Db.From("tbl_kota")

        Db.OrderBy("kode_kota", cls_database.sorting.Ascending)

        grid_list1.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_kota.Columns("kode_kota").Caption = "Kode Kota"
        GridV_kota.Columns("kota").Caption = "Kota"
        GridV_kota.Columns("kode_provinsi").Caption = "Kode Provinsi"

        GridV_kota.Columns("kode_kota").Width = 40
        GridV_kota.Columns("kota").Width = 120
        GridV_kota.Columns("kode_provinsi").Width = 40
        '-------------------------------------------------
        Db.FlushCache()
        Db.Selects("kode_grup, grup")
        Db.From("tbl_grup")

        Db.OrderBy("kode_grup", cls_database.sorting.Ascending)

        grid_list3.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_group.Columns("kode_grup").Caption = "Kode"
        GridV_group.Columns("grup").Caption = "Group"

        GridV_group.Columns("kode_grup").Width = 40
        GridV_group.Columns("grup").Width = 120
        '-------------------------------------------------
        Db.FlushCache()
        Db.Selects("kode_zona, zona")
        Db.From("tbl_zona")

        Db.OrderBy("kode_zona", cls_database.sorting.Ascending)

        grid_list2.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        GridV_zona.Columns("kode_zona").Caption = "Kode Zona"
        GridV_zona.Columns("zona").Caption = "Zona"

        GridV_zona.Columns("kode_zona").Width = 40
        GridV_zona.Columns("zona").Width = 120
    End Sub

    Private Sub frm_wilayah_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitGrid1()
        Call InitGrid2()
        Call InitGrid3()
        Call InitGrid4()

        Call Me.loadData()
    End Sub

    Private Sub grid_list1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_list1.Click

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frm_provinsi_add.Dispose()
        frm_provinsi_add.ShowDialog(Me)
    End Sub

   
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim row As System.Data.DataRow = GridV_provinsi.GetDataRow(GridV_provinsi.FocusedRowHandle)
        frm_provinsi_edit.Dispose()
        frm_provinsi_edit.initData(row("kode_provinsi"))
        frm_provinsi_edit.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        frm_kota_add.Dispose()
        frm_kota_add.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim row As System.Data.DataRow = GridV_kota.GetDataRow(GridV_kota.FocusedRowHandle)
        frm_kota_edit.Dispose()
        frm_kota_edit.initData(row("kode_kota"))
        frm_kota_edit.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        frm_group_add.Dispose()
        frm_group_add.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Dim row As System.Data.DataRow = GridV_group.GetDataRow(GridV_group.FocusedRowHandle)
        frm_group_edit.Dispose()
        frm_group_edit.initData(row("kode_grup"))
        frm_group_edit.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        frm_zona_add.Dispose()
        frm_zona_add.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Dim row As System.Data.DataRow = GridV_zona.GetDataRow(GridV_zona.FocusedRowHandle)
        frm_zona_edit.Dispose()
        frm_zona_edit.initData(row("kode_zona"))
        frm_zona_edit.ShowDialog(Me)
    End Sub
End Class