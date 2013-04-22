Public Class frm_margin_customer_delete 

    Private Sub frm_margin_customer_delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl_dari.DateTime = frm_margin_customer_list.tgl_dari.DateTime
        tgl_sampai.DateTime = frm_margin_customer_list.tgl_sampai.DateTime
        tipe_customer.SelectedIndex = frm_margin_customer_list.tipe_customer.SelectedIndex
        Load_CustomerParent(kode_customer_parent, "1")
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click

        If MsgBox("Apakah anda yakin akan menghapus data diatas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Db.FlushCache()
            Db.Delete("tbl_margin")
            Db.Where_BetweenDate("tanggal", tgl_dari.DateTime, tgl_sampai.DateTime)
            If getValueFromLookup(kode_customer_parent) = "-1" Then
                Db.Where(" AND kode_customer_child LIKE '%." & (tipe_customer.SelectedIndex + 1) & "'")
            Else
                Db.Where("kode_customer_child", getValueFromLookup(kode_customer_parent) & (tipe_customer.SelectedIndex + 1))
            End If

            If Connection.ExecuteNonQuery(Db.GetQueryString) Then
                MsgBox("Data berhasil dieksekusi.", MsgBoxStyle.Information)
                frm_margin_customer_list.loadData()
                Me.Close()
            End If

        End If

    End Sub
End Class