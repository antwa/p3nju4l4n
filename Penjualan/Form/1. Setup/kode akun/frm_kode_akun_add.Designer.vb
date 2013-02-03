<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kode_akun_add
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.rdg_tipe_akun = New DevExpress.XtraEditors.RadioGroup
        Me.lkp_kelompok = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lkp_posisi = New DevExpress.XtraEditors.LookUpEdit
        Me.lbl_nama_posisi_akun = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kode_akun1 = New DevExpress.XtraEditors.TextEdit
        Me.txt_kode_akun2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nama_akun = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txt_deskripsi = New DevExpress.XtraEditors.MemoEdit
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.rdg_tipe_akun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkp_kelompok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkp_posisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kode_akun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kode_akun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nama_akun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_deskripsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(44, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Tipe Akun :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(44, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Kelompok :"
        '
        'rdg_tipe_akun
        '
        Me.rdg_tipe_akun.EditValue = "D"
        Me.rdg_tipe_akun.Location = New System.Drawing.Point(114, 7)
        Me.rdg_tipe_akun.Name = "rdg_tipe_akun"
        Me.rdg_tipe_akun.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.rdg_tipe_akun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg_tipe_akun.Properties.Appearance.Options.UseBackColor = True
        Me.rdg_tipe_akun.Properties.Appearance.Options.UseFont = True
        Me.rdg_tipe_akun.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("H", "Header (Akun tidak dapat diposting)"), New DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Detail (Akun dapat diposting)")})
        Me.rdg_tipe_akun.Size = New System.Drawing.Size(275, 46)
        Me.rdg_tipe_akun.TabIndex = 12
        '
        'lkp_kelompok
        '
        Me.lkp_kelompok.Location = New System.Drawing.Point(114, 64)
        Me.lkp_kelompok.Name = "lkp_kelompok"
        Me.lkp_kelompok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkp_kelompok.Properties.Appearance.Options.UseFont = True
        Me.lkp_kelompok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkp_kelompok.Size = New System.Drawing.Size(155, 21)
        Me.lkp_kelompok.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(19, 94)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Posisi Dibawah :"
        '
        'lkp_posisi
        '
        Me.lkp_posisi.Location = New System.Drawing.Point(114, 91)
        Me.lkp_posisi.Name = "lkp_posisi"
        Me.lkp_posisi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkp_posisi.Properties.Appearance.Options.UseFont = True
        Me.lkp_posisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkp_posisi.Size = New System.Drawing.Size(155, 21)
        Me.lkp_posisi.TabIndex = 15
        '
        'lbl_nama_posisi_akun
        '
        Me.lbl_nama_posisi_akun.Location = New System.Drawing.Point(275, 94)
        Me.lbl_nama_posisi_akun.Name = "lbl_nama_posisi_akun"
        Me.lbl_nama_posisi_akun.Size = New System.Drawing.Size(4, 13)
        Me.lbl_nama_posisi_akun.TabIndex = 16
        Me.lbl_nama_posisi_akun.Text = "-"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(37, 121)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Kode Akun :"
        '
        'txt_kode_akun1
        '
        Me.txt_kode_akun1.EditValue = "-"
        Me.txt_kode_akun1.Location = New System.Drawing.Point(114, 118)
        Me.txt_kode_akun1.Name = "txt_kode_akun1"
        Me.txt_kode_akun1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode_akun1.Properties.Appearance.Options.UseFont = True
        Me.txt_kode_akun1.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_kode_akun1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_kode_akun1.Properties.ReadOnly = True
        Me.txt_kode_akun1.Size = New System.Drawing.Size(44, 21)
        Me.txt_kode_akun1.TabIndex = 18
        '
        'txt_kode_akun2
        '
        Me.txt_kode_akun2.Location = New System.Drawing.Point(175, 118)
        Me.txt_kode_akun2.Name = "txt_kode_akun2"
        Me.txt_kode_akun2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode_akun2.Properties.Appearance.Options.UseFont = True
        Me.txt_kode_akun2.Properties.MaxLength = 4
        Me.txt_kode_akun2.Size = New System.Drawing.Size(94, 21)
        Me.txt_kode_akun2.TabIndex = 19
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(165, 121)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(4, 14)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "-"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(35, 148)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 14)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "Nama Akun :"
        '
        'txt_nama_akun
        '
        Me.txt_nama_akun.Location = New System.Drawing.Point(114, 145)
        Me.txt_nama_akun.Name = "txt_nama_akun"
        Me.txt_nama_akun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_akun.Properties.Appearance.Options.UseFont = True
        Me.txt_nama_akun.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nama_akun.Size = New System.Drawing.Size(338, 21)
        Me.txt_nama_akun.TabIndex = 22
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(51, 174)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "Deskripsi :"
        '
        'txt_deskripsi
        '
        Me.txt_deskripsi.Location = New System.Drawing.Point(114, 172)
        Me.txt_deskripsi.Name = "txt_deskripsi"
        Me.txt_deskripsi.Size = New System.Drawing.Size(275, 64)
        Me.txt_deskripsi.TabIndex = 24
        '
        'cmd_batal
        '
        Me.cmd_batal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_batal.Location = New System.Drawing.Point(359, 274)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(93, 27)
        Me.cmd_batal.TabIndex = 25
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(260, 274)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(93, 27)
        Me.cmd_simpan.TabIndex = 26
        Me.cmd_simpan.Text = "Simpan"
        '
        'frm_kode_akun_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 313)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.txt_deskripsi)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_nama_akun)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_kode_akun2)
        Me.Controls.Add(Me.txt_kode_akun1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lbl_nama_posisi_akun)
        Me.Controls.Add(Me.lkp_posisi)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lkp_kelompok)
        Me.Controls.Add(Me.rdg_tipe_akun)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_kode_akun_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Kode Akun"
        CType(Me.rdg_tipe_akun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkp_kelompok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkp_posisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kode_akun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kode_akun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nama_akun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_deskripsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdg_tipe_akun As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lkp_kelompok As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkp_posisi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbl_nama_posisi_akun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kode_akun1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kode_akun2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nama_akun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_deskripsi As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
End Class
