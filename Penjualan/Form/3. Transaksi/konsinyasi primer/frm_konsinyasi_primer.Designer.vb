<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_konsinyasi_primer
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.no_penjualan = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_terbit = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.sebelum_disc_acara = New DevExpress.XtraEditors.RadioGroup
        Me.lbl_kota = New DevExpress.XtraEditors.LabelControl
        Me.lbl_mall = New DevExpress.XtraEditors.LabelControl
        Me.lbl_alamat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_nama = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.disc_acara = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.disc_acara_kita = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.disc_acara_toko = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.margin_toko = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.margin_konsumen = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_hapus_baris = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cari_artikel = New DevExpress.XtraEditors.SimpleButton
        Me.keterangan = New DevExpress.XtraEditors.MemoEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_penjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sebelum_disc_acara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disc_acara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disc_acara_kita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disc_acara_toko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.margin_toko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.margin_konsumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 129)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(824, 172)
        Me.GridControl1.TabIndex = 36
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowBandMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        '
        'no_penjualan
        '
        Me.no_penjualan.Location = New System.Drawing.Point(93, 9)
        Me.no_penjualan.Name = "no_penjualan"
        Me.no_penjualan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_penjualan.Properties.Appearance.Options.UseFont = True
        Me.no_penjualan.Properties.ReadOnly = True
        Me.no_penjualan.Size = New System.Drawing.Size(167, 21)
        Me.no_penjualan.TabIndex = 38
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 14)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "No. Penjualan"
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(93, 36)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(271, 21)
        Me.kode_customer.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 39)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 42
        Me.LabelControl6.Text = "Customer"
        '
        'tgl_terbit
        '
        Me.tgl_terbit.EditValue = Nothing
        Me.tgl_terbit.Location = New System.Drawing.Point(93, 63)
        Me.tgl_terbit.Name = "tgl_terbit"
        Me.tgl_terbit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_terbit.Properties.Appearance.Options.UseFont = True
        Me.tgl_terbit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_terbit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_terbit.Size = New System.Drawing.Size(132, 21)
        Me.tgl_terbit.TabIndex = 44
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Tanggal"
        '
        'sebelum_disc_acara
        '
        Me.sebelum_disc_acara.AutoSizeInLayoutControl = True
        Me.sebelum_disc_acara.EditValue = 1
        Me.sebelum_disc_acara.Location = New System.Drawing.Point(12, 100)
        Me.sebelum_disc_acara.Name = "sebelum_disc_acara"
        Me.sebelum_disc_acara.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sebelum_disc_acara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sebelum_disc_acara.Properties.Appearance.Options.UseBackColor = True
        Me.sebelum_disc_acara.Properties.Appearance.Options.UseFont = True
        Me.sebelum_disc_acara.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sebelum_disc_acara.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Margin Sebelum Disc Acara"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Margin Setelah Disc Acara")})
        Me.sebelum_disc_acara.Size = New System.Drawing.Size(386, 23)
        Me.sebelum_disc_acara.TabIndex = 48
        '
        'lbl_kota
        '
        Me.lbl_kota.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kota.Location = New System.Drawing.Point(447, 72)
        Me.lbl_kota.Name = "lbl_kota"
        Me.lbl_kota.Size = New System.Drawing.Size(25, 14)
        Me.lbl_kota.TabIndex = 53
        Me.lbl_kota.Text = "Kota"
        '
        'lbl_mall
        '
        Me.lbl_mall.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mall.Location = New System.Drawing.Point(447, 52)
        Me.lbl_mall.Name = "lbl_mall"
        Me.lbl_mall.Size = New System.Drawing.Size(20, 14)
        Me.lbl_mall.TabIndex = 52
        Me.lbl_mall.Text = "mall"
        '
        'lbl_alamat
        '
        Me.lbl_alamat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamat.Location = New System.Drawing.Point(447, 32)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Size = New System.Drawing.Size(35, 14)
        Me.lbl_alamat.TabIndex = 51
        Me.lbl_alamat.Text = "alamat"
        '
        'lbl_nama
        '
        Me.lbl_nama.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(447, 12)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(86, 14)
        Me.lbl_nama.TabIndex = 50
        Me.lbl_nama.Text = "Nama Customer"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(408, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl4.TabIndex = 49
        Me.LabelControl4.Text = "Kpd : "
        '
        'disc_acara
        '
        Me.disc_acara.EditValue = "10"
        Me.disc_acara.Location = New System.Drawing.Point(481, 102)
        Me.disc_acara.Name = "disc_acara"
        Me.disc_acara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_acara.Properties.Appearance.Options.UseFont = True
        Me.disc_acara.Properties.Appearance.Options.UseTextOptions = True
        Me.disc_acara.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.disc_acara.Size = New System.Drawing.Size(42, 21)
        Me.disc_acara.TabIndex = 54
        Me.disc_acara.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(408, 105)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 14)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Disc Acara : "
        Me.LabelControl5.Visible = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(529, 105)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl7.TabIndex = 56
        Me.LabelControl7.Text = "% => Kita"
        Me.LabelControl7.Visible = False
        '
        'disc_acara_kita
        '
        Me.disc_acara_kita.EditValue = "5"
        Me.disc_acara_kita.Location = New System.Drawing.Point(593, 102)
        Me.disc_acara_kita.Name = "disc_acara_kita"
        Me.disc_acara_kita.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_acara_kita.Properties.Appearance.Options.UseFont = True
        Me.disc_acara_kita.Properties.Appearance.Options.UseTextOptions = True
        Me.disc_acara_kita.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.disc_acara_kita.Size = New System.Drawing.Size(42, 21)
        Me.disc_acara_kita.TabIndex = 57
        Me.disc_acara_kita.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(641, 105)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl8.TabIndex = 58
        Me.LabelControl8.Text = "% ; Toko"
        Me.LabelControl8.Visible = False
        '
        'disc_acara_toko
        '
        Me.disc_acara_toko.EditValue = "5"
        Me.disc_acara_toko.Location = New System.Drawing.Point(699, 102)
        Me.disc_acara_toko.Name = "disc_acara_toko"
        Me.disc_acara_toko.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_acara_toko.Properties.Appearance.Options.UseFont = True
        Me.disc_acara_toko.Properties.Appearance.Options.UseTextOptions = True
        Me.disc_acara_toko.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.disc_acara_toko.Properties.ReadOnly = True
        Me.disc_acara_toko.Size = New System.Drawing.Size(42, 21)
        Me.disc_acara_toko.TabIndex = 59
        Me.disc_acara_toko.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(747, 105)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(16, 14)
        Me.LabelControl9.TabIndex = 60
        Me.LabelControl9.Text = "% "
        Me.LabelControl9.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(696, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 14)
        Me.LabelControl3.TabIndex = 62
        Me.LabelControl3.Text = "Margin Toko : "
        Me.LabelControl3.Visible = False
        '
        'margin_toko
        '
        Me.margin_toko.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.margin_toko.Location = New System.Drawing.Point(781, 29)
        Me.margin_toko.Name = "margin_toko"
        Me.margin_toko.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margin_toko.Properties.Appearance.Options.UseFont = True
        Me.margin_toko.Properties.Appearance.Options.UseTextOptions = True
        Me.margin_toko.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.margin_toko.Size = New System.Drawing.Size(42, 21)
        Me.margin_toko.TabIndex = 61
        Me.margin_toko.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(829, 32)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(16, 14)
        Me.LabelControl11.TabIndex = 65
        Me.LabelControl11.Text = "% "
        Me.LabelControl11.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(829, 59)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(16, 14)
        Me.LabelControl10.TabIndex = 68
        Me.LabelControl10.Text = "% "
        Me.LabelControl10.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(667, 59)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(108, 14)
        Me.LabelControl12.TabIndex = 67
        Me.LabelControl12.Text = "Margin Konsumen : "
        Me.LabelControl12.Visible = False
        '
        'margin_konsumen
        '
        Me.margin_konsumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.margin_konsumen.Location = New System.Drawing.Point(781, 56)
        Me.margin_konsumen.Name = "margin_konsumen"
        Me.margin_konsumen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margin_konsumen.Properties.Appearance.Options.UseFont = True
        Me.margin_konsumen.Properties.Appearance.Options.UseTextOptions = True
        Me.margin_konsumen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.margin_konsumen.Size = New System.Drawing.Size(42, 21)
        Me.margin_konsumen.TabIndex = 66
        Me.margin_konsumen.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(12, 337)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl13.TabIndex = 69
        Me.LabelControl13.Text = "Keterangan"
        '
        'cmd_hapus_baris
        '
        Me.cmd_hapus_baris.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus_baris.Location = New System.Drawing.Point(121, 307)
        Me.cmd_hapus_baris.Name = "cmd_hapus_baris"
        Me.cmd_hapus_baris.Size = New System.Drawing.Size(97, 24)
        Me.cmd_hapus_baris.TabIndex = 71
        Me.cmd_hapus_baris.Text = "Hapus"
        '
        'cmd_cari_artikel
        '
        Me.cmd_cari_artikel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_cari_artikel.Location = New System.Drawing.Point(12, 307)
        Me.cmd_cari_artikel.Name = "cmd_cari_artikel"
        Me.cmd_cari_artikel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cari_artikel.TabIndex = 70
        Me.cmd_cari_artikel.Text = "Cari Artikel"
        '
        'keterangan
        '
        Me.keterangan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.keterangan.Location = New System.Drawing.Point(12, 357)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(463, 46)
        Me.keterangan.TabIndex = 72
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(636, 379)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 74
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(739, 379)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 73
        Me.cmd_cancel.Text = "Cancel"
        '
        'frm_konsinyasi_primer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 415)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.cmd_hapus_baris)
        Me.Controls.Add(Me.cmd_cari_artikel)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.margin_konsumen)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.margin_toko)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.disc_acara_toko)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.disc_acara_kita)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.disc_acara)
        Me.Controls.Add(Me.lbl_kota)
        Me.Controls.Add(Me.lbl_mall)
        Me.Controls.Add(Me.lbl_alamat)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.sebelum_disc_acara)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.tgl_terbit)
        Me.Controls.Add(Me.kode_customer)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.no_penjualan)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_konsinyasi_primer"
        Me.Text = "Input Konsinyasi Primer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_penjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sebelum_disc_acara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disc_acara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disc_acara_kita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disc_acara_toko.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.margin_toko.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.margin_konsumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents no_penjualan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_terbit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sebelum_disc_acara As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lbl_kota As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_mall As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_alamat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_nama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents disc_acara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents disc_acara_kita As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents disc_acara_toko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents margin_toko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents margin_konsumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_hapus_baris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cari_artikel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents keterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
