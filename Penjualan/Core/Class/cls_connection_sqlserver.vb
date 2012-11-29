Imports System.Data.SqlClient

Public Class cls_connection_sqlserver

    Public strConnection As String

    Public Cnt As SqlClient.SqlConnection
    Private Cmd As SqlClient.SqlCommand
    Public Read As SqlClient.SqlDataReader

    Private DA As New SqlClient.SqlDataAdapter
    Private DS As DataSet
    Private DT As DataTable

    Public Sub initConnection(ByVal StringConnection As String)
        strConnection = StringConnection
    End Sub

    Public Function openConnection() As Boolean
        'Server=myServerAddress;Database=myDataBase;User ID=myUsername;Password=myPassword;Trusted_Connection=False;
        strConnection = "Server=BANDUNG-B800F40\SQLEXPRESS;Database=penjualan;Trusted_Connection=True;"

        Try
            Cnt = New SqlClient.SqlConnection(strConnection)
            If Cnt.State <> ConnectionState.Closed Then
                Cnt.Close()
            End If

            Cnt.Open()

            Return True
        Catch ex As Exception
            MsgBox("openConnection Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
            Return False
        End Try

    End Function

    Public Sub closeConnection()
        If Not IsNothing(Cnt) Then
            Cnt.Close()
            Cnt = Nothing
        End If
    End Sub

    Public Function ExecuteToDataTable(ByVal Query As String) As DataTable
        ''@ Code dibawah ini sementara tidak dipakai
        'If openConnection() Then
        '    Try
        '        Cmd = New SqlClient.SqlCommand(Query, Me.Cnt)
        '        Cmd.CommandType = CommandType.Text
        '        DA = New SqlClient.SqlDataAdapter
        '        DA.SelectCommand = Cmd

        '        DS = New DataSet
        '        DA.Fill(DS)

        '        DT = DS.Tables(0)

        '        ' return
        '        ExecuteToDataTable = DT
        '    Catch ex As Exception
        '        MsgBox("ExecuteToDataTable Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
        '        ExecuteToDataTable = Nothing
        '    End Try
        'Else
        '    ExecuteToDataTable = Nothing
        'End If

        'DT = Nothing
        'DS = Nothing
        'DA = Nothing
        'Cmd = Nothing

        'closeConnection()

        If openConnection() Then
            Try

                Cmd = New SqlClient.SqlCommand(Query, Me.Cnt)
                Read = Cmd.ExecuteReader

                Dim DatTable As New DataTable
                DatTable.Load(Read)

                ExecuteToDataTable = DatTable

            Catch ex As Exception
                MsgBox("ExecuteToDataReader Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
                ExecuteToDataTable = Nothing
            End Try
        Else
            ExecuteToDataTable = Nothing
        End If

        Cmd = Nothing

        closeConnection()
    End Function

    Public Function ExecuteToDataReader(ByVal Query As String) As SqlClient.SqlDataReader
        If openConnection() Then
            Try

                Cmd = New SqlClient.SqlCommand(Query, Me.Cnt)
                Read = Cmd.ExecuteReader

                ExecuteToDataReader = Read

            Catch ex As Exception
                MsgBox("ExecuteToDataReader Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
                ExecuteToDataReader = Nothing
            End Try
        Else
            ExecuteToDataReader = Nothing
        End If

        Cmd = Nothing

        'closeConnection()

    End Function

    Public Function ExecuteNonQuery(ByVal Query As String) As Boolean
        If openConnection() Then
            Try

                Cmd = New SqlClient.SqlCommand(Query, Me.Cnt)
                Cmd.ExecuteNonQuery()
                ExecuteNonQuery = True

            Catch ex As Exception
                MsgBox("ExecuteNonQuery Failed...!!" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Failed")
                ExecuteNonQuery = False
            End Try
        Else
            ExecuteNonQuery = False
        End If

        Cmd = Nothing
        closeConnection()
    End Function


    '# Untuk Transaksi database
    '---------------------------------------------------------------------------------
    Dim TR_LIST As New ArrayList()
    Public TRANS_MESSAGE As String

    Public Sub TRANS_START()
        TR_LIST.Clear()
    End Sub

    Public Sub TRANS_ADD(ByVal Query As String)
        TR_LIST.Add(Query)
    End Sub

    Public Function TRANS_SUCCESS() As Boolean

        If openConnection() Then

            Dim command As SqlCommand = Cnt.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = Cnt.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection 
            ' to Command object for a pending local transaction.
            command.Connection = Cnt
            command.Transaction = transaction

            Try
                ' begin execute query from arraylist
                Dim i As Integer
                Dim coun As Integer = TR_LIST.Count - 1
                For i = 0 To coun
                    command.CommandText = TR_LIST.Item(i)
                    command.ExecuteNonQuery()
                Next

                ' Attempt to commit the transaction.
                transaction.Commit()

                TRANS_SUCCESS = True

            Catch ex As Exception
                'Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                'Console.WriteLine("  Message: {0}", ex.Message)
                TRANS_MESSAGE = ex.Message
                ' Attempt to roll back the transaction. 
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    TRANS_MESSAGE = ex2.Message
                End Try
                TRANS_SUCCESS = False
            End Try
        Else
            TRANS_SUCCESS = False
        End If

        Cmd = Nothing
        closeConnection()

    End Function

End Class
