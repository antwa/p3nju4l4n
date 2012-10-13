Module Prosedur

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

End Module
