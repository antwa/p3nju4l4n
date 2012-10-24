<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_supplier_barang_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_supplier_barang_edit))
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_plafon_debet = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_jatuh_tempobayar = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_telp2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kota = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_fax = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txt_telp1 = New DevExpress.XtraEditors.TextEdit
        Me.txt_alamat = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_noktp = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nik = New DevExpress.XtraEditors.TextEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_plafon_debet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_jatuh_tempobayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telp2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telp1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_alamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_noktp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Image = CType(resources.GetObject("cmd_simpan.Image"), System.Drawing.Image)
        Me.cmd_simpan.Location = New System.Drawing.Point(484, 379)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 26)
        Me.cmd_simpan.TabIndex = 43
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_batal
        '
        Me.cmd_batal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_batal.Image = CType(resources.GetObject("cmd_batal.Image"), System.Drawing.Image)
        Me.cmd_batal.Location = New System.Drawing.Point(367, 379)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 26)
        Me.cmd_batal.TabIndex = 44
        Me.cmd_batal.Text = "Batal"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_plafon_debet)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_jatuh_tempobayar)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_telp2)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.txt_kota)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txt_fax)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txt_telp1)
        Me.GroupControl1.Controls.Add(Me.txt_alamat)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_noktp)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.txt_nik)
        Me.GroupControl1.Location = New System.Drawing.Point(53, 22)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(529, 339)
        Me.GroupControl1.TabIndex = 42
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(26, 305)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 14)
        Me.LabelControl5.TabIndex = 60
        Me.LabelControl5.Text = "Plafon Debet"
        '
        'txt_plafon_debet
        '
        Me.txt_plafon_debet.EditValue = ""
        Me.txt_plafon_debet.Location = New System.Drawing.Point(160, 298)
        Me.txt_plafon_debet.Name = "txt_plafon_debet"
        Me.txt_plafon_debet.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_plafon_debet.Properties.Appearance.Options.UseFont = True
        Me.txt_plafon_debet.Size = New System.Drawing.Size(164, 21)
        Me.txt_plafon_debet.TabIndex = 59
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(26, 278)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(106, 14)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "Jatuh Tempo Bayar"
        '
        'txt_jatuh_tempobayar
        '
        Me.txt_jatuh_tempobayar.EditValue = ""
        Me.txt_jatuh_tempobayar.Location = New System.Drawing.Point(160, 271)
        Me.txt_jatuh_tempobayar.Name = "txt_jatuh_tempobayar"
        Me.txt_jatuh_tempobayar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jatuh_tempobayar.Properties.Appearance.Options.UseFont = True
        Me.txt_jatuh_tempobayar.Size = New System.Drawing.Size(69, 21)
        Me.txt_jatuh_tempobayar.TabIndex = 57
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(26, 224)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl1.TabIndex = 56
        Me.LabelControl1.Text = "Telepon 2"
        '
        'txt_telp2
        '
        Me.txt_telp2.EditValue = ""
        Me.txt_telp2.Location = New System.Drawing.Point(161, 217)
        Me.txt_telp2.Name = "txt_telp2"
        Me.txt_telp2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telp2.Properties.Appearance.Options.UseFont = True
        Me.txt_telp2.Size = New System.Drawing.Size(164, 21)
        Me.txt_telp2.TabIndex = 55
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(26, 166)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(25, 14)
        Me.LabelControl15.TabIndex = 54
        Me.LabelControl15.Text = "Kota"
        '
        'txt_kota
        '
        Me.txt_kota.EditValue = ""
        Me.txt_kota.Location = New System.Drawing.Point(160, 163)
        Me.txt_kota.Name = "txt_kota"
        Me.txt_kota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kota.Properties.Appearance.Options.UseFont = True
        Me.txt_kota.Size = New System.Drawing.Size(147, 21)
        Me.txt_kota.TabIndex = 53
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(26, 251)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl8.TabIndex = 52
        Me.LabelControl8.Text = "Fax"
        '
        'txt_fax
        '
        Me.txt_fax.EditValue = ""
        Me.txt_fax.Location = New System.Drawing.Point(160, 244)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax.Properties.Appearance.Options.UseFont = True
        Me.txt_fax.Size = New System.Drawing.Size(134, 21)
        Me.txt_fax.TabIndex = 50
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(26, 197)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl9.TabIndex = 51
        Me.LabelControl9.Text = "Telepon 1"
        '
        'txt_telp1
        '
        Me.txt_telp1.EditValue = ""
        Me.txt_telp1.Location = New System.Drawing.Point(160, 190)
        Me.txt_telp1.Name = "txt_telp1"
        Me.txt_telp1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telp1.Properties.Appearance.Options.UseFont = True
        Me.txt_telp1.Size = New System.Drawing.Size(164, 21)
        Me.txt_telp1.TabIndex = 49
        '
        'txt_alamat
        '
        Me.txt_alamat.EditValue = ""
        Me.txt_alamat.Location = New System.Drawing.Point(160, 89)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamat.Properties.Appearance.Options.UseFont = True
        Me.txt_alamat.Size = New System.Drawing.Size(256, 68)
        Me.txt_alamat.TabIndex = 42
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(26, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 14)
        Me.LabelControl3.TabIndex = 41
        Me.LabelControl3.Text = "Alamat"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(26, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Nama"
        '
        'txt_noktp
        '
        Me.txt_noktp.EditValue = ""
        Me.txt_noktp.Location = New System.Drawing.Point(161, 62)
        Me.txt_noktp.Name = "txt_noktp"
        Me.txt_noktp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noktp.Properties.Appearance.Options.UseFont = True
        Me.txt_noktp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_noktp.Size = New System.Drawing.Size(190, 21)
        Me.txt_noktp.TabIndex = 35
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(26, 38)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(116, 14)
        Me.LabelControl18.TabIndex = 34
        Me.LabelControl18.Text = "Kode Supplier Barang"
        '
        'txt_nik
        '
        Me.txt_nik.EditValue = ""
        Me.txt_nik.Location = New System.Drawing.Point(161, 35)
        Me.txt_nik.Name = "txt_nik"
        Me.txt_nik.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nik.Properties.Appearance.Options.UseFont = True
        Me.txt_nik.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nik.Size = New System.Drawing.Size(163, 21)
        Me.txt_nik.TabIndex = 33
        '
        'frm_supplier_barang_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 428)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_supplier_barang_edit"
        Me.Text = "Form Supplier Barang Edit"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_plafon_debet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_jatuh_tempobayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telp2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telp1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_alamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_noktp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_plafon_debet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_jatuh_tempobayar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_telp2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_telp1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_alamat As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_noktp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nik As DevExpress.XtraEditors.TextEdit
End Class
