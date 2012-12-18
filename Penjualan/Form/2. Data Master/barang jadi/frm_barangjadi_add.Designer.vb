<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_barangjadi_add
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
        Me.kode_merk = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.bulan_produksi = New DevExpress.XtraEditors.ComboBoxEdit
        Me.tahun_produksi = New DevExpress.XtraEditors.ComboBoxEdit
        Me.kode_kategori = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_urut = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_artikel_priview = New DevExpress.XtraEditors.TextEdit
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
        CType(Me.kode_merk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.bulan_produksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tahun_produksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_kategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_urut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_artikel_priview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.pct_gambar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.harga_pokok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kode_merk
        '
        Me.kode_merk.Location = New System.Drawing.Point(105, 25)
        Me.kode_merk.Name = "kode_merk"
        Me.kode_merk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_merk.Properties.Appearance.Options.UseFont = True
        Me.kode_merk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_merk.Size = New System.Drawing.Size(167, 21)
        Me.kode_merk.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl6.TabIndex = 44
        Me.LabelControl6.Text = "Kode Merk"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.bulan_produksi)
        Me.GroupControl1.Controls.Add(Me.tahun_produksi)
        Me.GroupControl1.Controls.Add(Me.kode_kategori)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.no_urut)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.kode_merk)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(363, 473)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Artikel"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 448)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 14)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Bulan Produksi"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 394)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 14)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "Tahun Produksi"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(21, 14)
        Me.LabelControl3.TabIndex = 53
        Me.LabelControl3.Text = "Size"
        '
        'bulan_produksi
        '
        Me.bulan_produksi.Location = New System.Drawing.Point(105, 445)
        Me.bulan_produksi.Name = "bulan_produksi"
        Me.bulan_produksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bulan_produksi.Properties.Appearance.Options.UseFont = True
        Me.bulan_produksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.bulan_produksi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.bulan_produksi.Size = New System.Drawing.Size(121, 21)
        Me.bulan_produksi.TabIndex = 3
        '
        'tahun_produksi
        '
        Me.tahun_produksi.Location = New System.Drawing.Point(105, 391)
        Me.tahun_produksi.Name = "tahun_produksi"
        Me.tahun_produksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tahun_produksi.Properties.Appearance.Options.UseFont = True
        Me.tahun_produksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tahun_produksi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tahun_produksi.Size = New System.Drawing.Size(121, 21)
        Me.tahun_produksi.TabIndex = 1
        '
        'kode_kategori
        '
        Me.kode_kategori.Location = New System.Drawing.Point(105, 418)
        Me.kode_kategori.Name = "kode_kategori"
        Me.kode_kategori.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_kategori.Properties.Appearance.Options.UseFont = True
        Me.kode_kategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_kategori.Size = New System.Drawing.Size(156, 21)
        Me.kode_kategori.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 421)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl2.TabIndex = 49
        Me.LabelControl2.Text = "Kategori Barang"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(105, 79)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(253, 307)
        Me.GridControl1.TabIndex = 48
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'no_urut
        '
        Me.no_urut.Location = New System.Drawing.Point(105, 52)
        Me.no_urut.Name = "no_urut"
        Me.no_urut.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_urut.Properties.Appearance.Options.UseFont = True
        Me.no_urut.Properties.ReadOnly = True
        Me.no_urut.Size = New System.Drawing.Size(82, 21)
        Me.no_urut.TabIndex = 47
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 14)
        Me.LabelControl1.TabIndex = 46
        Me.LabelControl1.Text = "No. Urut"
        '
        'kode_artikel_priview
        '
        Me.kode_artikel_priview.Location = New System.Drawing.Point(503, 12)
        Me.kode_artikel_priview.Name = "kode_artikel_priview"
        Me.kode_artikel_priview.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_artikel_priview.Properties.Appearance.Options.UseFont = True
        Me.kode_artikel_priview.Properties.ReadOnly = True
        Me.kode_artikel_priview.Size = New System.Drawing.Size(193, 21)
        Me.kode_artikel_priview.TabIndex = 57
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(389, 15)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(108, 14)
        Me.LabelControl7.TabIndex = 56
        Me.LabelControl7.Text = "Priview Kode Artikel"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbl_filename)
        Me.GroupControl2.Controls.Add(Me.cmd_clear)
        Me.GroupControl2.Controls.Add(Me.cmd_browse)
        Me.GroupControl2.Controls.Add(Me.pct_gambar)
        Me.GroupControl2.Location = New System.Drawing.Point(389, 40)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(360, 245)
        Me.GroupControl2.TabIndex = 58
        Me.GroupControl2.Text = "Gambar"
        '
        'lbl_filename
        '
        Me.lbl_filename.Location = New System.Drawing.Point(160, 221)
        Me.lbl_filename.Name = "lbl_filename"
        Me.lbl_filename.Size = New System.Drawing.Size(4, 13)
        Me.lbl_filename.TabIndex = 61
        Me.lbl_filename.Text = "-"
        Me.lbl_filename.Visible = False
        '
        'cmd_clear
        '
        Me.cmd_clear.Location = New System.Drawing.Point(258, 221)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(97, 19)
        Me.cmd_clear.TabIndex = 60
        Me.cmd_clear.Text = "Clear"
        '
        'cmd_browse
        '
        Me.cmd_browse.Location = New System.Drawing.Point(5, 221)
        Me.cmd_browse.Name = "cmd_browse"
        Me.cmd_browse.Size = New System.Drawing.Size(97, 19)
        Me.cmd_browse.TabIndex = 4
        Me.cmd_browse.Text = "Browse"
        '
        'pct_gambar
        '
        Me.pct_gambar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_gambar.Location = New System.Drawing.Point(2, 22)
        Me.pct_gambar.Name = "pct_gambar"
        Me.pct_gambar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pct_gambar.Size = New System.Drawing.Size(356, 193)
        Me.pct_gambar.TabIndex = 10
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(475, 291)
        Me.nama.Name = "nama"
        Me.nama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Properties.Appearance.Options.UseFont = True
        Me.nama.Size = New System.Drawing.Size(274, 21)
        Me.nama.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(389, 294)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl8.TabIndex = 56
        Me.LabelControl8.Text = "Nama"
        '
        'harga_pokok
        '
        Me.harga_pokok.Location = New System.Drawing.Point(475, 318)
        Me.harga_pokok.Name = "harga_pokok"
        Me.harga_pokok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga_pokok.Properties.Appearance.Options.UseFont = True
        Me.harga_pokok.Size = New System.Drawing.Size(133, 21)
        Me.harga_pokok.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(389, 321)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl9.TabIndex = 59
        Me.LabelControl9.Text = "Harga Pokok"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(389, 347)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl11.TabIndex = 63
        Me.LabelControl11.Text = "Keterangan"
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(475, 345)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(274, 102)
        Me.keterangan.TabIndex = 7
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(549, 461)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 8
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(652, 461)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 9
        Me.cmd_cancel.Text = "Cancel"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_barangjadi_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 497)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.harga_pokok)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.kode_artikel_priview)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_barangjadi_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Barang Jadi"
        CType(Me.kode_merk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.bulan_produksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tahun_produksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_kategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_urut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_artikel_priview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents kode_merk As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents no_urut As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bulan_produksi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tahun_produksi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents kode_kategori As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_artikel_priview As DevExpress.XtraEditors.TextEdit
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
