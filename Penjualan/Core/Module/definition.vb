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
    Public Const C_PENERIMAAN_BARANG As String = "Penerimaan Barang Jadi"
    Public Const C_RETUR_PENERIMAAN_BARANG As String = "Retur Penerimaan Barang"

End Module
