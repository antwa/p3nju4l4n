Public Class frm_barangjadi_edit 

    Dim changePicture As Boolean = False

    Public Sub initData(ByVal kode_barangjadi As String)
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_barangjadi")
        Db.Where("kode_barangjadi", kode_barangjadi)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        With rcd
            .Read()
            txt_kode_barangjadi.Text = .Item("kode_barangjadi").ToString
            nama.Text = .Item("nama").ToString
            harga_pokok.Text = .Item("harga_pokok").ToString
            keterangan.Text = .Item("keterangan").ToString

            If .Item("gambar").ToString <> "-" Then
                If My.Computer.FileSystem.FileExists(APP.PATH_IMG_BARANG & .Item("gambar").ToString) Then
                    lbl_filename.Text = .Item("gambar").ToString
                    pct_gambar.Image = Image.FromFile(APP.PATH_IMG_BARANG & .Item("gambar").ToString)
                End If
            End If

        End With

    End Sub

    Private Sub cmd_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_browse.Click
        With OpenFileDialog1
            .Filter = "Image File (PNG, BMP, JPG, JPEG)|*.png;*.bmp;*.jpg;*.jpeg|" & _
                        "All File|*.*"

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    lbl_filename.Text = .SafeFileName
                    pct_gambar.Image = Image.FromFile(.FileName)
                    changePicture = True
                Catch ex As Exception

                End Try
            End If

        End With
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        pct_gambar.Image = Nothing
        lbl_filename.Text = "-"
        changePicture = True
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click
        
        Validation.clearRules()
        Validation.addRules(nama.Text, "Nama", "required")
        Validation.addRules(harga_pokok.EditValue, "Harga Pokok", "required|numeric")

        If Validation.isValid Then

            If changePicture = True Then
                '# operasi file image
                If lbl_filename.Text <> "-" Then
                    With OpenFileDialog1
                        If .FileName <> vbNullString Then
                            My.Computer.FileSystem.CopyFile(.FileName, APP.PATH_IMG_BARANG & lbl_filename.Text, True)
                        End If
                    End With
                End If
            End If

            '# Update table tbl_barangjadi
            Db.FlushCache()
            Db.Update("tbl_barangjadi")
            Db.SetField("nama", nama.Text)
            Db.SetField("harga_pokok", harga_pokok.EditValue)
            Db.SetField("gambar", lbl_filename.Text)
            Db.SetField("keterangan", keterangan.Text)
            Db.Where("kode_barangjadi", txt_kode_barangjadi.Text)

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                MsgBox("Data berhasil diperbaharui.", MsgBoxStyle.Information)
                frm_barangjadi_list.loadData()
                Me.Close()
            Else
                MsgBox("Data gagal disimpan!", MsgBoxStyle.Exclamation)
            End If

        Else
            Validation.showMessage()
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub
End Class