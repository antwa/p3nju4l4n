Module Helper

    ' Merubah tanggal format indonesia [dd/mm/yyyy] ke MySQL [yyyy-mm-dd]
    Public Function DateSafe(ByVal value As String) As String
        Dim tmp() As String = value.Split("/")
        Return tmp(2) & "-" & tmp(1) & "-" & tmp(0)
    End Function

    Public Sub FormatColumnNumeric(ByRef column As DevExpress.XtraGrid.Columns.GridColumn)
        column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        column.DisplayFormat.FormatString = "#,##0"
    End Sub

    Public Sub FormatColumnAccounting(ByRef column As DevExpress.XtraGrid.Columns.GridColumn)
        column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        column.DisplayFormat.FormatString = "#,##0;(#,##0);-"
    End Sub

End Module
