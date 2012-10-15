Module definition


    ' struktur
    Public Structure STRUK_APP
        Dim Version As String
        Dim PATH_APP As String          ' C:\Program File\produksi\
    End Structure

    Public APP As STRUK_APP
   
    ' class
    Public Validation As New cls_validation
    Public Connection As New cls_connection_sqlserver
    Public Db As New cls_database

    Public Auth As cls_authentication

    ' constanta
    Public Const C_PENERIMAAN_BARANG As Integer = 1 ' Penerimaan barang jadi
    Public Const C_RETUR_PENERIMAAN_BARANG As Integer = 2 ' retur penerimaan barang jadi
    Public Const C_SALES_ORDER As Integer = 3 ' sales order
    Public Const C_DELIVERY_ORDER As Integer = 4 ' delivery order
    Public Const C_SURAT_JALAN As Integer = 5 ' Surat Jalan

End Module
