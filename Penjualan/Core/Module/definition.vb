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

End Module
