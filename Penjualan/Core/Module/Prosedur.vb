﻿Module Prosedur

    '# untuk prosedur load master detail
    Public Structure STR_MASTERDETAIL
        Dim Tbl_Master As String
        Dim Tbl_Detail As String
        Dim Query_Master As String
        Dim Query_Detail As String
        Dim Key_Master As String
        Dim Key_Detail As String
    End Structure

    ' Prosedur generateColumnGrid ini tidak penting, abaikan saja (tapi jangan dihapus)
    Public Sub generateColumnGrid(ByVal col As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim i As Integer
        Dim str As String = ""

        '# caption
        For i = 0 To col.Columns.Count - 1
            str &= col.Name & ".Columns(""" & col.Columns(i).FieldName & """).Caption = """"" & vbCrLf
        Next
        str &= vbCrLf

        '# width
        For i = 0 To col.Columns.Count - 1
            str &= col.Name & ".Columns(""" & col.Columns(i).FieldName & """).Width = " & col.Columns(i).Width & vbCrLf
        Next
        str &= vbCrLf

        My.Computer.Clipboard.SetText(str)
        MsgBox("data sudah di salin ke clipboard....")

    End Sub

    Public Sub setFocusCell(ByVal Gridview1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView, ByVal Row As Integer, ByVal Column As String)
        Gridview1.FocusedRowHandle = Row
        'Gridview1.FocusedColumn = Gridview1.VisibleColumns(Column)
        Gridview1.FocusedColumn = Gridview1.Columns(Column)
        Gridview1.ShowEditor()
    End Sub

    Public Sub setFocusCell(ByVal Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Row As Integer, ByVal Column As String)
        Gridview1.FocusedRowHandle = Row
        'Gridview1.FocusedColumn = Gridview1.VisibleColumns(Column)
        Gridview1.FocusedColumn = Gridview1.Columns(Column)
        Gridview1.ShowEditor()
    End Sub

    Public Sub Load_SupplierBarang(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_supplier_barang, a.nama")
        Db.From("tbl_supplier_barang a")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "nama"
        lookup.Properties.ValueMember = "kode_supplier_barang"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Nama"
        lookup.Properties.Columns(0).Width = 50
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Customer(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, ByVal sistem_jual As Integer)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_customer, a.nama, a.kode_template_harga")
        Db.From("tbl_customer a")
        Db.Where("a.sistem_jual", sistem_jual)

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "nama"
        lookup.Properties.ValueMember = "kode_customer"
        lookup.Properties.PopulateColumns()

        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Nama"
        lookup.Properties.Columns(0).Width = 50
        lookup.Properties.Columns(1).Width = 100

        lookup.Properties.Columns("kode_template_harga").Visible = False

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Merk(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_merk, a.merk")
        Db.From("tbl_merk a")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "merk"
        lookup.Properties.ValueMember = "kode_merk"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Nama"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_KategoriBarang(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_kategori, a.kategori")
        Db.From("tbl_kategori_barang a")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "kategori"
        lookup.Properties.ValueMember = "kode_kategori"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Kategori"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Jabatan(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_jabatan, a.nama_jabatan")
        Db.From("tbl_jabatan a")


        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "nama_jabatan"
        lookup.Properties.ValueMember = "kode_jabatan"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Jabatan"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Provinsi(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_provinsi, a.provinsi")
        Db.From("tbl_provinsi a")


        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "provinsi"
        lookup.Properties.ValueMember = "kode_provinsi"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Provinsi"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Status(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_status, a.status")
        Db.From("tbl_status a")


        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "status"
        lookup.Properties.ValueMember = "kode_status"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Status"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Kota(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_kota, a.kota, a.kode_provinsi")
        Db.From("tbl_kota a")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "kota"
        lookup.Properties.ValueMember = "kode_kota"
        lookup.Properties.ValueMember = "kode_provinsi"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode Kota"
        lookup.Properties.Columns(1).Caption = "Kota"
        lookup.Properties.Columns(2).Caption = "Kode Provinsi"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.Properties.Columns(2).Width = 20
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Zona(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_zona, a.zona")
        Db.From("tbl_zona a")


        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "zona"
        lookup.Properties.ValueMember = "kode_zona"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Zona"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Harga(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_jenis_harga, a.jenis")
        Db.From("tbl_jenis_hargabarang a")


        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "jenis"
        lookup.Properties.ValueMember = "kode_jenis_harga"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Harga"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Grup(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_grup, a.grup")
        Db.From("tbl_grup a")


        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "grup"
        lookup.Properties.ValueMember = "kode_grup"
        lookup.Properties.PopulateColumns()
        lookup.Properties.Columns(0).Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Group"
        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100
        lookup.ItemIndex = 0
    End Sub

    Public Sub Create_MasterDetail(ByRef GridControl1 As DevExpress.XtraGrid.GridControl, ByVal Opsi As STR_MASTERDETAIL)
        Dim Cmd As SqlClient.SqlCommand
        Dim DA As New SqlClient.SqlDataAdapter
        Dim DS As DataSet

        '# Open Connection
        Connection.openConnection()

        Cmd = New SqlClient.SqlCommand(Opsi.Query_Master, Connection.Cnt)
        DA = New SqlClient.SqlDataAdapter
        DA.SelectCommand = Cmd

        DS = New DataSet

        DA.Fill(DS, Opsi.Tbl_Master)

        Cmd.CommandText = Opsi.Query_Detail
        DA.SelectCommand = Cmd

        DA.Fill(DS, Opsi.Tbl_Detail)

        'DT = DS.Tables(0)

        DS.Relations.Add("Detail View" & Opsi.Tbl_Master, DS.Tables(Opsi.Tbl_Master).Columns(Opsi.Key_Master), DS.Tables(Opsi.Tbl_Detail).Columns(Opsi.Key_Detail))

        GridControl1.DataMember = Opsi.Tbl_Master
        GridControl1.DataSource = DS

        '# Close Connection
        Connection.closeConnection()
    End Sub

End Module
