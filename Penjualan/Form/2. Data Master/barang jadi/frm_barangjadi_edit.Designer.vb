<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_barangjadi_edit
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
        Me.txt_kode_barangjadi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lbl_filename = New DevExpress.XtraEditors.LabelControl
        Me.cmd_clear = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_browse = New DevExpress.XtraEditors.SimpleButton
        Me.pct_gambar = New DevExpress.XtraEditors.PictureEdit
        Me.nama = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.harga_pokok = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.keterangan = New DevExpress.XtraEditors.MemoEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.txt_kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.pct_gambar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.harga_pokok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_kode_barangjadi
        '
        Me.txt_kode_barangjadi.Location = New System.Drawing.Point(495, 12)
        Me.txt_kode_barangjadi.Name = "txt_kode_barangjadi"
        Me.txt_kode_barangjadi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode_barangjadi.Properties.Appearance.Options.UseFont = True
        Me.txt_kode_barangjadi.Properties.ReadOnly = True
        Me.txt_kode_barangjadi.Size = New System.Drawing.Size(193, 21)
        Me.txt_kode_barangjadi.TabIndex = 57
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(409, 15)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl7.TabIndex = 56
        Me.LabelControl7.Text = "Kode Artikel"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbl_filename)
        Me.GroupControl2.Controls.Add(Me.cmd_clear)
        Me.GroupControl2.Controls.Add(Me.cmd_browse)
        Me.GroupControl2.Controls.Add(Me.pct_gambar)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(376, 332)
        Me.GroupControl2.TabIndex = 58
        Me.GroupControl2.Text = "Gambar"
        '
        'lbl_filename
        '
        Me.lbl_filename.Location = New System.Drawing.Point(154, 308)
        Me.lbl_filename.Name = "lbl_filename"
        Me.lbl_filename.Size = New System.Drawing.Size(4, 13)
        Me.lbl_filename.TabIndex = 61
        Me.lbl_filename.Text = "-"
        Me.lbl_filename.Visible = False
        '
        'cmd_clear
        '
        Me.cmd_clear.Location = New System.Drawing.Point(274, 308)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(97, 19)
        Me.cmd_clear.TabIndex = 60
        Me.cmd_clear.Text = "Clear"
        '
        'cmd_browse
        '
        Me.cmd_browse.Location = New System.Drawing.Point(4, 308)
        Me.cmd_browse.Name = "cmd_browse"
        Me.cmd_browse.Size = New System.Drawing.Size(97, 19)
        Me.cmd_browse.TabIndex = 59
        Me.cmd_browse.Text = "Browse"
        '
        'pct_gambar
        '
        Me.pct_gambar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_gambar.Location = New System.Drawing.Point(2, 22)
        Me.pct_gambar.Name = "pct_gambar"
        Me.pct_gambar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pct_gambar.Size = New System.Drawing.Size(372, 280)
        Me.pct_gambar.TabIndex = 10
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(495, 84)
        Me.nama.Name = "nama"
        Me.nama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Properties.Appearance.Options.UseFont = True
        Me.nama.Size = New System.Drawing.Size(274, 21)
        Me.nama.TabIndex = 57
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(409, 87)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl8.TabIndex = 56
        Me.LabelControl8.Text = "Nama"
        '
        'harga_pokok
        '
        Me.harga_pokok.Location = New System.Drawing.Point(495, 111)
        Me.harga_pokok.Name = "harga_pokok"
        Me.harga_pokok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga_pokok.Properties.Appearance.Options.UseFont = True
        Me.harga_pokok.Properties.Appearance.Options.UseTextOptions = True
        Me.harga_pokok.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.harga_pokok.Properties.Mask.EditMask = "n0"
        Me.harga_pokok.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.harga_pokok.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.harga_pokok.Size = New System.Drawing.Size(133, 21)
        Me.harga_pokok.TabIndex = 60
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(409, 114)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl9.TabIndex = 59
        Me.LabelControl9.Text = "Harga Pokok"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(409, 140)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl11.TabIndex = 63
        Me.LabelControl11.Text = "Keterangan"
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(495, 138)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(274, 102)
        Me.keterangan.TabIndex = 64
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(569, 320)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 66
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(672, 320)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 65
        Me.cmd_cancel.Text = "Cancel"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_barangjadi_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 356)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.harga_pokok)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.txt_kode_barangjadi)
        Me.Controls.Add(Me.LabelControl7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_barangjadi_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Barang Jadi"
        CType(Me.txt_kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.pct_gambar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.harga_pokok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_kode_barangjadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pct_gambar As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents nama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents harga_pokok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents keterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_filename As DevExpress.XtraEditors.LabelControl
End Class
