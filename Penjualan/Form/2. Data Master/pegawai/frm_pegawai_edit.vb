Imports DevExpress.XtraEditors.Controls

Public Class frm_pegawai_edit
    Sub initControl()
        Load_Customer(lkp_kode_costumer, 1)
        Load_Jabatan(lkp_jabatan)

        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("1", "SPG"))
        rdg_group_pegawai.Properties.Items.Add(New RadioGroupItem("2", "Pegawai"))


        rdg_jk.Properties.Items.Add(New RadioGroupItem("1", "Laki - Laki"))
        rdg_jk.Properties.Items.Add(New RadioGroupItem("2", "Perempuan"))
    End Sub

    Public Sub initData(ByVal nik As String)




        Db.FlushCache()
        Db.Selects("*")
        Db.From("tbl_pegawai")
        'Db.Join("PRO_AKSESORIS_DETAIL", "PRO_AKSESORIS.AKS_KODE = PRO_AKSESORIS_DETAIL.AKS_KODE")
        Db.Where("nik", nik)

        Dim rcd As SqlClient.SqlDataReader = Connection.ExecuteToDataReader(Db.GetQueryString)

        If rcd.HasRows Then
            With rcd
                .Read()
                txt_nik.Text = nik
                txt_noktp.Text = .Item("no_ktp").ToString
                txt_nama_pegawai.Text = .Item("nama").ToString
                txt_alamat.EditValue = .Item("alamat").ToString
                txt_kota.Text = .Item("kota").ToString
                rdg_group_pegawai.EditValue = .Item("group").ToString
                lkp_kode_costumer.EditValue = .Item("kode_customer").ToString

                rdg_jk.EditValue = .Item("jk").ToString
                dte_tgl_masuk.EditValue = .Item("tgl_masuk").ToString

            End With
        End If

    End Sub
    Private Sub cmd_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_simpan.Click

    End Sub

    Private Sub frm_pegawai_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initControl()
    End Sub
End Class