<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_histori_harga_add
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
        Me.chk_semua_customer = New DevExpress.XtraEditors.CheckEdit
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.Cmd_cari = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_barangjadi = New DevExpress.XtraEditors.TextEdit
        Me.lbl_nama_artikel = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.tanggal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.harga = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.diskon = New DevExpress.XtraEditors.TextEdit
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.chk_check_uncheck = New DevExpress.XtraEditors.CheckEdit
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.harga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_check_uncheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_semua_customer
        '
        Me.chk_semua_customer.Location = New System.Drawing.Point(479, 34)
        Me.chk_semua_customer.Name = "chk_semua_customer"
        Me.chk_semua_customer.Properties.Caption = "Semua"
        Me.chk_semua_customer.Size = New System.Drawing.Size(61, 19)
        Me.chk_semua_customer.TabIndex = 77
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(250, 32)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(223, 21)
        Me.kode_customer.TabIndex = 76
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(250, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl2.TabIndex = 75
        Me.LabelControl2.Text = "Customer"
        '
        'Cmd_cari
        '
        Me.Cmd_cari.Location = New System.Drawing.Point(162, 31)
        Me.Cmd_cari.Name = "Cmd_cari"
        Me.Cmd_cari.Size = New System.Drawing.Size(54, 22)
        Me.Cmd_cari.TabIndex = 80
        Me.Cmd_cari.Text = "Cari"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl1.TabIndex = 79
        Me.LabelControl1.Text = "Kode Artikel"
        '
        'kode_barangjadi
        '
        Me.kode_barangjadi.EditValue = ""
        Me.kode_barangjadi.Location = New System.Drawing.Point(12, 32)
        Me.kode_barangjadi.Name = "kode_barangjadi"
        Me.kode_barangjadi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_barangjadi.Properties.Appearance.Options.UseFont = True
        Me.kode_barangjadi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.kode_barangjadi.Size = New System.Drawing.Size(144, 21)
        Me.kode_barangjadi.TabIndex = 78
        '
        'lbl_nama_artikel
        '
        Me.lbl_nama_artikel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama_artikel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_nama_artikel.Location = New System.Drawing.Point(12, 59)
        Me.lbl_nama_artikel.Name = "lbl_nama_artikel"
        Me.lbl_nama_artikel.Size = New System.Drawing.Size(240, 14)
        Me.lbl_nama_artikel.TabIndex = 81
        Me.lbl_nama_artikel.Text = "-"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 109)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(747, 234)
        Me.GridControl1.TabIndex = 82
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
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(662, 404)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 83
        Me.cmd_simpan.Text = "Simpan"
        '
        'tanggal
        '
        Me.tanggal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tanggal.EditValue = Nothing
        Me.tanggal.Location = New System.Drawing.Point(12, 369)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Properties.Appearance.Options.UseFont = True
        Me.tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tanggal.Size = New System.Drawing.Size(129, 21)
        Me.tanggal.TabIndex = 85
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 349)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl4.TabIndex = 84
        Me.LabelControl4.Text = "Tanggal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 396)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 2)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'harga
        '
        Me.harga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.harga.EditValue = ""
        Me.harga.Location = New System.Drawing.Point(162, 369)
        Me.harga.Name = "harga"
        Me.harga.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Properties.Appearance.Options.UseFont = True
        Me.harga.Properties.Appearance.Options.UseTextOptions = True
        Me.harga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.harga.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.harga.Properties.Mask.EditMask = "n0"
        Me.harga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.harga.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.harga.Size = New System.Drawing.Size(144, 21)
        Me.harga.TabIndex = 87
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(162, 349)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl5.TabIndex = 88
        Me.LabelControl5.Text = "Harga (Rp.)"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(329, 349)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl6.TabIndex = 90
        Me.LabelControl6.Text = "Diskon (%)"
        '
        'diskon
        '
        Me.diskon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.diskon.EditValue = ""
        Me.diskon.Location = New System.Drawing.Point(329, 369)
        Me.diskon.Name = "diskon"
        Me.diskon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskon.Properties.Appearance.Options.UseFont = True
        Me.diskon.Properties.Appearance.Options.UseTextOptions = True
        Me.diskon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.diskon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.diskon.Properties.Mask.EditMask = "n0"
        Me.diskon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.diskon.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.diskon.Size = New System.Drawing.Size(63, 21)
        Me.diskon.TabIndex = 89
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(12, 79)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(97, 24)
        Me.cmd_load.TabIndex = 91
        Me.cmd_load.Text = "Load Data"
        '
        'chk_check_uncheck
        '
        Me.chk_check_uncheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_check_uncheck.Location = New System.Drawing.Point(647, 349)
        Me.chk_check_uncheck.Name = "chk_check_uncheck"
        Me.chk_check_uncheck.Properties.Caption = "Check/Uncheck All"
        Me.chk_check_uncheck.Size = New System.Drawing.Size(112, 19)
        Me.chk_check_uncheck.TabIndex = 92
        '
        'frm_histori_harga_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 440)
        Me.Controls.Add(Me.chk_check_uncheck)
        Me.Controls.Add(Me.cmd_load)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.lbl_nama_artikel)
        Me.Controls.Add(Me.Cmd_cari)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.kode_barangjadi)
        Me.Controls.Add(Me.chk_semua_customer)
        Me.Controls.Add(Me.kode_customer)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "frm_histori_harga_add"
        Me.Text = "Tambah Harga Customer"
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.harga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_check_uncheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_semua_customer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Cmd_cari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_barangjadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_nama_artikel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents harga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents diskon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_check_uncheck As DevExpress.XtraEditors.CheckEdit
End Class
