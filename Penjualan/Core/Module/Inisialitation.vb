Module Inisialitation

    Public Sub init_aplikasi()

        APP.Version = "2.0"

        APP.PATH_APP = My.Application.Info.DirectoryPath.ToString & "\"

        '# cek direktori, jika tidak ada maka buat directori baru
        'If My.Computer.FileSystem.DirectoryExists(APP.PATH_AKSESORIS) = False Then
        '    My.Computer.FileSystem.CreateDirectory(APP.PATH_AKSESORIS)
        'End If

        '# load connection string
        If My.Computer.FileSystem.FileExists(APP.PATH_APP & "connection.set") Then
            Dim strConect As String = My.Computer.FileSystem.ReadAllText(APP.PATH_APP & "connection.set")
            Connection.initConnection(strConect)
        Else
            MsgBox("Tidak ada pengaturan ke Database!" & vbCrLf & vbCrLf & "Lakukan pengaturan ke database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Psean")
        End If

    End Sub

End Module
