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

    'Public Sub Load_Customer(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, ByVal sistem_jual As Integer)
    '    'init lookup
    '    Db.FlushCache()
    '    Db.Selects("a.kode_customer, a.nama, a.kode_template_harga")
    '    Db.From("tbl_customer a")
    '    Db.Where("a.sistem_jual", sistem_jual)

    '    lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
    '    lookup.Properties.DisplayMember = "nama"
    '    lookup.Properties.ValueMember = "kode_customer"
    '    lookup.Properties.PopulateColumns()

    '    lookup.Properties.Columns(0).Caption = "Kode"
    '    lookup.Properties.Columns(1).Caption = "Nama"
    '    lookup.Properties.Columns(0).Width = 50
    '    lookup.Properties.Columns(1).Width = 100

    '    lookup.Properties.Columns("kode_template_harga").Visible = False

    '    lookup.ItemIndex = 0
    'End Sub

    Public Sub Load_CustomerParent(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, ByVal sistem_jual As Integer)
        'init datatable
        Dim dt As New DataTable
        dt.Columns.Add("kode_customer_parent", GetType(String))
        dt.Columns.Add("nama", GetType(String))
        dt.Columns.Add("kode_template_harga", GetType(Integer))

        dt.Rows.Add(New Object() {"-1", "Semua Customer", "0"})

        'query
        Db.FlushCache()
        Db.Selects("a.kode_customer_parent, a.nama, a.kode_template_harga")
        Db.From("tbl_customer_parent a")
        Db.Where("a.sistem_jual", sistem_jual)

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If r.Rows.Count > 0 Then
            Dim count As Integer = r.Rows.Count - 1
            For i = 0 To count
                dt.Rows.Add(New Object() {r.Rows(i).Item("kode_customer_parent"), r.Rows(i).Item("nama"), r.Rows(i).Item("kode_template_harga")})
            Next
        End If

        ' init lookup
        lookup.Properties.DataSource = dt
        lookup.Properties.DisplayMember = "nama"
        lookup.Properties.ValueMember = "kode_customer_parent"
        lookup.Properties.PopulateColumns()

        lookup.Properties.Columns("kode_customer_parent").Caption = "Kode"
        lookup.Properties.Columns("nama").Caption = "Nama"

        lookup.Properties.Columns("kode_customer_parent").Width = 40
        lookup.Properties.Columns("nama").Width = 130

        lookup.Properties.Columns("kode_template_harga").Visible = False

        lookup.Properties.PopupWidth = 400

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_CustomerFull(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, ByVal sistem_jual As Integer)
        'init lookup
        Db.FlushCache()
        Db.Selects("a.kode_customer_parent, b.kode_customer_child, a.nama, b.deskripsi ,a.kode_template_harga")
        Db.From("tbl_customer_parent a")
        Db.Join("tbl_customer_child b", "b.kode_customer_parent = a.kode_customer_parent")
        Db.Where("a.sistem_jual", sistem_jual)

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.DisplayMember = "nama"
        lookup.Properties.ValueMember = "kode_customer_child"
        lookup.Properties.PopulateColumns()

        lookup.Properties.Columns("kode_customer_child").Caption = "Kode"
        lookup.Properties.Columns("nama").Caption = "Nama"
        lookup.Properties.Columns("deskripsi").Caption = "Tipe"

        lookup.Properties.Columns("kode_customer_child").Width = 40
        lookup.Properties.Columns("nama").Width = 130
        lookup.Properties.Columns("deskripsi").Width = 30

        lookup.Properties.Columns("kode_customer_parent").Visible = False
        lookup.Properties.Columns("kode_template_harga").Visible = False


        lookup.Properties.PopupWidth = 400

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_SPG(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, Optional ByVal kode_customer As String = vbNullString)
        Dim i As Integer
        If kode_customer <> vbNullString Then
            'init lookup
            Db.FlushCache()
            Db.Selects("a.id_pegawai, a.nama")
            Db.From("tbl_pegawai a")
            Db.Where("a.[group]", "2")
            Db.Where("a.kode_customer_parent", kode_customer)

            lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
            lookup.Properties.DisplayMember = "nama"
            lookup.Properties.ValueMember = "id_pegawai"
            lookup.Properties.PopulateColumns()

            lookup.Properties.Columns(0).Caption = "Kode"
            lookup.Properties.Columns(1).Caption = "Nama SPG"

            lookup.Properties.Columns(1).Width = 100

            For i = 0 To lookup.Properties.Columns.Count - 1
                lookup.Properties.Columns(i).Visible = False
            Next
            lookup.Properties.Columns("nama").Visible = True

        Else '# ambil semua SPG
            'init lookup
            Db.FlushCache()
            Db.Selects("a.id_pegawai, b.nama AS nama_customer, a.nama")
            Db.From("tbl_pegawai a")
            Db.Join("tbl_customer_parent b", "b.kode_customer_parent = a.kode_customer_parent")
            Db.Where("a.[group]", "2")

            lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
            lookup.Properties.DisplayMember = "nama"
            lookup.Properties.ValueMember = "id_pegawai"
            lookup.Properties.PopulateColumns()

            lookup.Properties.Columns(0).Caption = "Kode"
            lookup.Properties.Columns(1).Caption = "Nama Customer"
            lookup.Properties.Columns(2).Caption = "Nama SPG"

            lookup.Properties.Columns(1).Width = 100
            lookup.Properties.Columns(2).Width = 130

            For i = 0 To lookup.Properties.Columns.Count - 1
                lookup.Properties.Columns(i).Visible = False
            Next
            lookup.Properties.Columns("nama").Visible = True
            lookup.Properties.Columns("nama_customer").Visible = True

        End If

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
        ' init datatable
        Dim dt As New DataTable
        dt.Columns.Add("kode_kategori", GetType(String))
        dt.Columns.Add("kategori", GetType(String))

        dt.Rows.Add(New Object() {"-1", "Semua Kategori"})

        'query
        Db.FlushCache()
        Db.Selects("a.kode_kategori, a.kategori")
        Db.From("tbl_kategori_barang a")
        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        'add to dt
        If r.Rows.Count > 0 Then
            Dim count As Integer = r.Rows.Count - 1
            For i = 0 To count
                dt.Rows.Add(New Object() {r.Rows(i).Item("kode_kategori"), r.Rows(i).Item("kategori")})
            Next
        End If

        'init lookup
        lookup.Properties.DataSource = dt
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

        Dim dt As New DataTable
        dt.Columns.Add("kode_provinsi", GetType(String))
        dt.Columns.Add("provinsi", GetType(String))

        dt.Rows.Add(New Object() {"-1", "Semua Provinsi"})

        Db.FlushCache()
        Db.Selects("a.kode_provinsi, a.provinsi")
        Db.From("tbl_provinsi a")

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If r.Rows.Count > 0 Then
            Dim count As Integer = r.Rows.Count - 1
            For i = 0 To count
                dt.Rows.Add(New Object() {r.Rows(i).Item("kode_provinsi"), r.Rows(i).Item("provinsi")})
            Next
        End If

        lookup.Properties.DataSource = dt
        lookup.Properties.DisplayMember = "provinsi"
        lookup.Properties.ValueMember = "kode_provinsi"

        lookup.Properties.PopulateColumns()

        'MsgBox(lookup.Properties.Columns.Count)
        lookup.Properties.Columns("kode_provinsi").Caption = "Kode"
        lookup.Properties.Columns(1).Caption = "Provinsi"

        lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100

        lookup.ItemIndex = 0
    End Sub

    'Public Sub Load_Status(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
    '    'init lookup
    '    Db.FlushCache()
    '    Db.Selects("a.kode_status, a.status")
    '    Db.From("tbl_status a")


    '    lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
    '    lookup.Properties.DisplayMember = "status"
    '    lookup.Properties.ValueMember = "kode_status"
    '    lookup.Properties.PopulateColumns()
    '    lookup.Properties.Columns(0).Caption = "Kode"
    '    lookup.Properties.Columns(1).Caption = "Status"
    '    lookup.Properties.Columns(0).Width = 20
    '    lookup.Properties.Columns(1).Width = 100
    '    lookup.ItemIndex = 0
    'End Sub

    Public Sub Load_Kota(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, Optional ByVal kode_provinsi As String = vbNullString)

        Dim dt As New DataTable
        dt.Columns.Add("kode_kota", GetType(String))
        dt.Columns.Add("kota", GetType(String))
        dt.Columns.Add("provinsi", GetType(String))

        dt.Rows.Add(New Object() {"-1", "Semua Kota", "-"})

        Db.FlushCache()
        Db.Selects("a.kode_kota, a.kota, b.provinsi")
        Db.From("tbl_kota a")
        Db.Join("tbl_provinsi b", "b.kode_provinsi = a.kode_provinsi")

        If kode_provinsi <> vbNullString Then
            Db.Where("a.kode_provinsi", kode_provinsi)
        End If

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If r.Rows.Count > 0 Then
            Dim count As Integer = r.Rows.Count - 1
            For i = 0 To count
                dt.Rows.Add(New Object() {r.Rows(i).Item("kode_kota"), r.Rows(i).Item("kota"), r.Rows(i).Item("provinsi")})
            Next
        End If

        lookup.Properties.DataSource = dt
        lookup.Properties.DisplayMember = "kota"
        lookup.Properties.ValueMember = "kode_kota"

        lookup.Properties.PopulateColumns()

        lookup.Properties.Columns(0).Caption = "Kode Kota"
        lookup.Properties.Columns(1).Caption = "Kota"
        lookup.Properties.Columns(2).Caption = "Provinsi"

        lookup.Properties.Columns(0).Visible = False

        lookup.Properties.Columns(1).Width = 75
        lookup.Properties.Columns(2).Width = 45

        lookup.Properties.PopupWidth = 250

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

        lookup.Properties.Columns(0).Visible = False
        lookup.Properties.Columns(1).Caption = "zona"

        'lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_TemplateHarga(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        'init lookup
        Db.FlushCache()

        Db.Selects("a.kode_template_harga, a.nama_harga")
        Db.From("tbl_template_hargajual a")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        lookup.Properties.DisplayMember = "nama_harga"
        lookup.Properties.ValueMember = "kode_template_harga"

        lookup.Properties.PopulateColumns()

        lookup.Properties.Columns(0).Visible = False
        lookup.Properties.Columns(1).Caption = "Harga Jual"

        'lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_Grup(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        ' init datatable
        Dim dt As New DataTable
        dt.Columns.Add("kode_grup", GetType(String))
        dt.Columns.Add("grup", GetType(String))

        dt.Rows.Add(New Object() {"-1", "Semua Group"})

        Db.FlushCache()
        Db.Selects("a.kode_grup, a.grup")
        Db.From("tbl_grup a")

        Dim r As DataTable = Connection.ExecuteToDataTable(Db.GetQueryString)

        If r.Rows.Count > 0 Then
            Dim count As Integer = r.Rows.Count - 1
            For i = 0 To count
                dt.Rows.Add(New Object() {r.Rows(i).Item("kode_grup"), r.Rows(i).Item("grup")})
            Next
        End If

        lookup.Properties.DataSource = dt

        lookup.Properties.DisplayMember = "grup"
        lookup.Properties.ValueMember = "kode_grup"

        lookup.Properties.PopulateColumns()

        lookup.Properties.Columns(0).Visible = False
        lookup.Properties.Columns(1).Caption = "Group"

        'lookup.Properties.Columns(0).Width = 20
        lookup.Properties.Columns(1).Width = 100

        lookup.ItemIndex = 0
    End Sub



    '#----------------- UNTUK AKUNTANSI
    Public Sub Load_akun_master(ByRef lookup As DevExpress.XtraEditors.LookUpEdit)
        Db.FlushCache()
        Db.Selects("kode_akun, nama_akun, kelompok")
        Db.From("tbl_akun")
        Db.Where("kode_parent", "0")
        Db.OrderBy("kode_akun")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.PopulateColumns()
        lookup.Properties.DisplayMember = "nama_akun"
        lookup.Properties.ValueMember = "kelompok"

        lookup.Properties.Columns("kode_akun").Caption = "Kode"
        lookup.Properties.Columns("nama_akun").Caption = "Nama Akun"
        lookup.Properties.Columns("kelompok").Visible = False

        lookup.Properties.Columns("kode_akun").Width = 75
        lookup.Properties.Columns("nama_akun").Width = 150

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_akun_header_byKelompok(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, ByVal kelompok As Integer)
        Db.FlushCache()
        Db.Selects("kode_akun, nama_akun, kelompok")
        Db.From("tbl_akun")
        Db.Where("kelompok", kelompok)
        Db.Where("tipe", "H")
        Db.OrderBy("kode_akun")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)
        lookup.Properties.PopulateColumns()
        lookup.Properties.DisplayMember = "kode_akun"
        lookup.Properties.ValueMember = "kode_akun"

        lookup.Properties.Columns("kode_akun").Caption = "Kode"
        lookup.Properties.Columns("nama_akun").Caption = "Nama Akun"
        lookup.Properties.Columns("kelompok").Visible = False

        lookup.Properties.Columns("kode_akun").Width = 75
        lookup.Properties.Columns("nama_akun").Width = 150

        lookup.ItemIndex = 0
    End Sub

    Public Sub Load_akun_detail_byKelompok(ByRef lookup As DevExpress.XtraEditors.LookUpEdit, ByVal kelompok As Integer, Optional ByVal kode_akun As String = "")
        Db.FlushCache()
        Db.Selects("kode_akun, nama_akun, kelompok")
        Db.From("tbl_akun")
        Db.Where("kelompok", kelompok)
        Db.Where("tipe", "D")
        If kode_akun <> "" Then
            Db.Where(" AND kode_akun LIKE '" & kode_akun & "%'")
        End If

        Db.OrderBy("kode_akun")

        lookup.Properties.DataSource = Connection.ExecuteToDataTable(Db.GetQueryString)

        lookup.Properties.PopulateColumns()

        lookup.Properties.DisplayMember = "nama_akun"
        lookup.Properties.ValueMember = "kode_akun"

        lookup.Properties.Columns("kode_akun").Caption = "Kode"
        lookup.Properties.Columns("nama_akun").Caption = "Nama Akun"
        lookup.Properties.Columns("kelompok").Visible = False

        lookup.Properties.Columns("kode_akun").Width = 75
        lookup.Properties.Columns("nama_akun").Width = 150

        lookup.ItemIndex = 0
    End Sub

    '#--------------- END UNTUK AKUNTANSI


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
