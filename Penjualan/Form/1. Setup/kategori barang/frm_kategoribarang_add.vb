﻿Public Class frm_kategoribarang_add 

    Private Sub cmd_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_batal.Click
        Me.Close()
    End Sub

    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

        '# Cek kode
        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_kategori_barang")
        Db.Where("kode_kategori", txt_kode.Text)
        If Connection.HasRows(Db.GetQueryString) Then
            MsgBox("Kode " & txt_kode.Text & ", Sudah terdaftar didalam database!" & vbCrLf & "Ganti dengan yang lain.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '#validation
        Validation.clearRules()
        Validation.addRules(txt_kode.Text, "Kode", "required|length[2-2]")
        Validation.addRules(txt_kategori.Text, "Kategori", "required|length[1-50]")
        If Not Validation.isValid Then
            Validation.showMessage()
            Exit Sub
        End If

        '# insert to table tbl_kategori_barang
        Db.FlushCache()
        Db.Insert("tbl_kategori_barang")
        Db.SetField("kode_kategori", txt_kode.Text)
        Db.SetField("kategori", txt_kategori.Text)

        If Connection.ExecuteNonQuery(Db.GetQueryString) Then
            frm_kategoribarang_list.loadData()
            Me.Close()
        End If
    End Sub

End Class