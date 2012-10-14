Public Class cls_database

    Enum sorting
        No
        Ascending
        Descending
    End Enum

    Enum typejoin
        INNER
        LEFT
        RIGHT
    End Enum



    Dim operasi As String
    Dim str_select As String
    Dim str_insert As String
    Dim str_update As String
    Dim str_delete As String
    Dim str_from As String
    Dim str_where As String
    Dim str_join As String
    Dim str_group_by As String
    Dim str_order_by As String
    Dim str_limit As String
    Dim str_set_field As String
    Dim str_insert_field As String
    Dim str_insert_value As String
    Dim str_query As String

    Public Sub Selects(ByVal field As String)
        operasi = "select"

        If Len(str_select) <= 0 Then
            str_select = "SELECT " & field
        Else
            str_select = str_select & ", " & field

        End If

    End Sub

    Public Sub Insert(ByVal table As String)
        operasi = "insert"

        str_insert = "INSERT INTO " & table & " "

    End Sub

    Public Sub Update(ByVal table As String)
        operasi = "update"

        str_update = "UPDATE " & table & " "

    End Sub

    Public Sub Delete(ByVal table As String)
        operasi = "delete"

        str_delete = "DELETE FROM " & table & " "

    End Sub

    ' -------------------------------------------------------------

    Public Sub From(ByVal table As String)
        str_from = " FROM " & table

    End Sub

    Public Sub Join(ByVal table As String, ByVal value As String, Optional ByVal typeJoin As typejoin = typejoin.INNER)
        If typeJoin = cls_database.typejoin.INNER Then
            str_join &= "INNER JOIN " & table & " ON " & value & " "
        ElseIf typeJoin = cls_database.typejoin.LEFT Then
            str_join &= "LEFT JOIN " & table & " ON " & value & " "
        ElseIf typeJoin = cls_database.typejoin.RIGHT Then
            str_join &= "RIGHT JOIN " & table & " ON " & value & " "
        End If
    End Sub

    Public Sub Where(ByVal field As String, _
                     ByVal value As String, _
                     Optional ByVal op_decision As String = "=", _
                     Optional ByVal op_logic As String = "AND")

        value = Replace(value, "'", "''", , , vbTextCompare)

        If Len(str_where) <= 0 Then
            str_where = "WHERE " & field & " " & op_decision & " '" & value & "'"
        Else
            str_where &= " " & op_logic & " " & field & " " & op_decision & " '" & value & "'"

        End If

    End Sub

    Public Sub Where(ByVal statment As String)
        str_where &= " " & statment & " "
    End Sub

    Public Sub Where_Between(ByVal field As String, _
                     ByVal value1 As String, _
                     ByVal value2 As String, _
                     Optional ByVal op_logic As String = "AND")

        value1 = Replace(value1, "'", "''", , , vbTextCompare)
        value2 = Replace(value2, "'", "''", , , vbTextCompare)

        If Len(str_where) <= 0 Then
            'str_where = "WHERE " & field & " BETWEEN convert(datetime,'" & value1 & "',103) AND convert(datetime,'" & value2 & "',103)"
            str_where = "WHERE " & field & " BETWEEN '" & value1 & "' AND '" & value2 & "'"
        Else
            'str_where &= " " & op_logic & " " & field & " BETWEEN convert(datetime,'" & value1 & "',103) AND convert(datetime,'" & value2 & "',103)"
            str_where &= " " & op_logic & " " & field & " BETWEEN '" & value1 & "' AND '" & value2 & "'"
        End If

    End Sub

    Public Sub Where_BetweenDate(ByVal field As String, _
                     ByVal value1 As String, _
                     ByVal value2 As String, _
                     Optional ByVal op_logic As String = "AND")

        value1 = Replace(value1, "'", "''", , , vbTextCompare)
        value2 = Replace(value2, "'", "''", , , vbTextCompare)

        If Len(str_where) <= 0 Then
            'str_where = "WHERE " & field & " BETWEEN convert(datetime,'" & value1 & "',103) AND convert(datetime,'" & value2 & "',103)"
            str_where = "WHERE " & field & " BETWEEN '" & value1 & " 00:00:00" & "' AND '" & value2 & " 23:59:59" & "'"
        Else
            'str_where &= " " & op_logic & " " & field & " BETWEEN convert(datetime,'" & value1 & "',103) AND convert(datetime,'" & value2 & "',103)"
            str_where &= " " & op_logic & " " & field & " BETWEEN '" & value1 & " 00:00:00" & "' AND '" & value2 & " 23:59:59" & "'"
        End If

    End Sub

    Public Sub Where_NotBetween(ByVal field As String, _
                     ByVal value1 As String, _
                     ByVal value2 As String, _
                     Optional ByVal op_logic As String = "AND")

        value1 = Replace(value1, "'", "''", , , vbTextCompare)
        value2 = Replace(value2, "'", "''", , , vbTextCompare)

        If Len(str_where) <= 0 Then
            str_where = "WHERE " & field & " NOT BETWEEN convert(datetime,'" & value1 & "',103) AND convert(datetime,'" & value2 & "',103)"
        Else
            str_where &= " " & op_logic & " " & field & " NOT BETWEEN convert(datetime,'" & value1 & "',103) AND convert(datetime,'" & value2 & "',103)"

        End If

    End Sub


    Public Sub GroupBy(ByVal field As String)

        If Len(str_group_by) <= 0 Then
            str_group_by = "GROUP BY " & field
        Else
            str_group_by &= ", " & field
        End If

    End Sub

    Public Sub OrderBy(ByVal field As String, Optional ByVal sort As sorting = sorting.No)

        If Len(str_order_by) <= 0 Then
            If sort = sorting.No Then
                str_order_by = "ORDER BY " & field
            ElseIf sort = sorting.Ascending Then
                str_order_by = "ORDER BY " & field & " ASC"
            Else
                str_order_by = "ORDER BY " & field & " DESC"
            End If

        Else

            If sort = sorting.No Then
                str_order_by &= ", " & field
            ElseIf sort = sorting.Ascending Then
                str_order_by &= ", " & field & " ASC"
            Else
                str_order_by &= ", " & field & " DESC"
            End If

        End If

    End Sub

    Public Sub Limit(ByVal perPage As Integer, ByVal offset As Integer)
        str_limit = "LIMIT " & offset & ", " & perPage

    End Sub

    Public Sub SetField(ByVal field As String, ByVal value As String)

        value = Replace(value, "'", "''", , , vbTextCompare)

        If operasi = "insert" Then
            If Len(str_insert_field) <= 0 Then
                str_insert_field &= field
                str_insert_value &= "'" & value & "'"
            
            Else
                str_insert_field &= ", " & field
                    str_insert_value &= ", " & "'" & value & "'"
            End If
        Else
            If Len(str_set_field) <= 0 Then
                str_set_field = "SET " & field & " = '" & value & "'"
                
            Else
                str_set_field = str_set_field & ", " & field & " = '" & value & "'"

            End If
        End If

    End Sub

    Public Sub FlushCache()
        operasi = vbNullString

        str_select = vbNullString
        str_insert = vbNullString
        str_update = vbNullString
        str_delete = vbNullString

        str_from = vbNullString
        str_where = vbNullString
        str_join = vbNullString
        str_group_by = vbNullString
        str_order_by = vbNullString
        str_limit = vbNullString

        str_set_field = vbNullString

        str_insert_field = vbNullString
        str_insert_value = vbNullString

        str_query = vbNullString

    End Sub

    Public Sub Query(ByVal strQuery As String)
        operasi = "query"

        str_query = strQuery

    End Sub

    Public Function GetQueryString() As String


        Dim tmp_generate As String

        tmp_generate = vbNullString

        If operasi = "select" Then
            tmp_generate = str_select
            tmp_generate &= " " & str_from
            tmp_generate &= " " & str_join
            tmp_generate &= " " & str_where
            tmp_generate &= " " & str_group_by
            tmp_generate &= " " & str_order_by
            tmp_generate &= " " & str_limit

        ElseIf operasi = "insert" Then
            tmp_generate = str_insert
            tmp_generate &= "(" & str_insert_field & ") VALUES (" & str_insert_value & ")"

        ElseIf operasi = "update" Then
            tmp_generate = str_update
            tmp_generate = tmp_generate & " " & str_set_field
            tmp_generate = tmp_generate & " " & str_where

        ElseIf operasi = "delete" Then
            tmp_generate = str_delete
            tmp_generate = tmp_generate & " " & str_where

        ElseIf operasi = "query" Then
            tmp_generate = str_query

        End If

        GetQueryString = tmp_generate.Trim & ";"

    End Function

End Class
