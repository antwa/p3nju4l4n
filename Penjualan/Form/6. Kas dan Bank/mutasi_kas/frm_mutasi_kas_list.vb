Public Class frm_mutasi_kas 

    Private Sub frm_mutasi_kas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_tambah.Click
        frm_pengeluaran_kas_add.Dispose()
        frm_pengeluaran_kas_add.ShowDialog(Me)
    End Sub
End Class