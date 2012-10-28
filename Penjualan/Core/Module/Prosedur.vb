Module Prosedur


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

End Module
