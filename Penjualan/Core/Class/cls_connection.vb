'Imports System.Data
'Imports Oracle.DataAccess.Client

Public Class cls_connection

    'Public strConnection As String

    'Public Cnt As OracleConnection
    'Private Cmd As OracleCommand
    'Public Read As OracleDataReader

    'Private DA As New OracleDataAdapter
    'Private DS As DataSet
    'Private DT As DataTable

    'Public Sub initConnection(ByVal StringConnection As String)
    '    strConnection = StringConnection
    'End Sub

    'Private Function openConnection() As Boolean
    '    strConnection = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.2.5)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=yanto;Password=yanto;"

    '    Try
    '        Cnt = New OracleConnection(strConnection)
    '        If Cnt.State <> ConnectionState.Closed Then
    '            Cnt.Close()
    '        End If
    '        Cnt.Open()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox("openConnection Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
    '        Return False
    '    End Try

    'End Function

    'Public Sub closeConnection()
    '    If Not IsNothing(Cnt) Then
    '        Cnt.Close()
    '        Cnt = Nothing
    '    End If
    'End Sub

    'Public Function ExecuteToDataTable(ByVal Query As String) As DataTable

    '    If openConnection() Then
    '        Try
    '            Cmd = New OracleCommand(Query, Me.Cnt)
    '            Cmd.CommandType = CommandType.Text
    '            DA = New OracleDataAdapter
    '            DA.SelectCommand = cmd

    '            DS = New DataSet
    '            DA.Fill(DS)

    '            DT = DS.Tables(0)

    '            ' return
    '            ExecuteToDataTable = DT
    '        Catch ex As Exception
    '            MsgBox("ExecuteToDataTable Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
    '            ExecuteToDataTable = Nothing
    '        End Try
    '    Else
    '        ExecuteToDataTable = Nothing
    '    End If

    '    DT = Nothing
    '    DS = Nothing
    '    DA = Nothing
    '    cmd = Nothing

    '    closeConnection()

    'End Function

    'Public Function ExecuteToDataReader(ByVal Query As String) As OracleDataReader

    '    If openConnection() Then
    '        Try

    '            Cmd = New OracleCommand(Query, Me.Cnt)
    '            Read = Cmd.ExecuteReader

    '            ExecuteToDataReader = Read

    '        Catch ex As Exception
    '            MsgBox("ExecuteToDataReader Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
    '            ExecuteToDataReader = Nothing
    '        End Try
    '    Else
    '        ExecuteToDataReader = Nothing
    '    End If

    '    cmd = Nothing

    '    'closeConnection()

    'End Function

    'Public Function ExecuteNonQuery(ByVal Query As String) As Boolean
    '    If openConnection() Then
    '        Try

    '            Cmd = New OracleCommand(Query, Me.Cnt)
    '            Cmd.ExecuteNonQuery()
    '            ExecuteNonQuery = True

    '        Catch ex As Exception
    '            MsgBox("ExecuteNonQuery Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
    '            ExecuteNonQuery = False
    '        End Try
    '    Else
    '        ExecuteNonQuery = False
    '    End If

    '    Cmd = Nothing
    '    closeConnection()
    'End Function

End Class
