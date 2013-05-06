<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_faktur_konsinyasi
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
        Me.no_faktur = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_terbit = New DevExpress.XtraEditors.DateEdit
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_jatuhtempo = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_dari = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_sampai = New DevExpress.XtraEditors.DateEdit
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        Me.txt_total_netto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.potongan_harga = New DevExpress.XtraEditors.TextEdit
        Me.txt_total = New DevExpress.XtraEditors.TextEdit
        Me.potongan_deskripsi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_faktur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_jatuhtempo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_jatuhtempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_netto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potongan_harga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potongan_deskripsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 195)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(739, 148)
        Me.GridControl1.TabIndex = 37
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
        'no_faktur
        '
        Me.no_faktur.Location = New System.Drawing.Point(119, 35)
        Me.no_faktur.Name = "no_faktur"
        Me.no_faktur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_faktur.Properties.Appearance.Options.UseFont = True
        Me.no_faktur.Properties.ReadOnly = True
        Me.no_faktur.Size = New System.Drawing.Size(167, 21)
        Me.no_faktur.TabIndex = 40
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(19, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl1.TabIndex = 39
        Me.LabelControl1.Text = "No. Faktur"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(19, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl2.TabIndex = 47
        Me.LabelControl2.Text = "Tgl Terbit"
        '
        'tgl_terbit
        '
        Me.tgl_terbit.EditValue = Nothing
        Me.tgl_terbit.Location = New System.Drawing.Point(119, 62)
        Me.tgl_terbit.Name = "tgl_terbit"
        Me.tgl_terbit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_terbit.Properties.Appearance.Options.UseFont = True
        Me.tgl_terbit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_terbit.Properties.ReadOnly = True
        Me.tgl_terbit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_terbit.Size = New System.Drawing.Size(132, 21)
        Me.tgl_terbit.TabIndex = 46
        '
        'kode_customer_parent
        '
        Me.kode_customer_parent.Location = New System.Drawing.Point(119, 89)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(271, 21)
        Me.kode_customer_parent.TabIndex = 49
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(19, 92)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 48
        Me.LabelControl6.Text = "Customer"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(19, 119)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 14)
        Me.LabelControl3.TabIndex = 51
        Me.LabelControl3.Text = "Tgl Jatuh Tempo"
        '
        'tgl_jatuhtempo
        '
        Me.tgl_jatuhtempo.EditValue = Nothing
        Me.tgl_jatuhtempo.Location = New System.Drawing.Point(119, 116)
        Me.tgl_jatuhtempo.Name = "tgl_jatuhtempo"
        Me.tgl_jatuhtempo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_jatuhtempo.Properties.Appearance.Options.UseFont = True
        Me.tgl_jatuhtempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_jatuhtempo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_jatuhtempo.Size = New System.Drawing.Size(132, 21)
        Me.tgl_jatuhtempo.TabIndex = 50
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.no_faktur)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.tgl_jatuhtempo)
        Me.GroupControl1.Controls.Add(Me.tgl_terbit)
        Me.GroupControl1.Controls.Add(Me.kode_customer_parent)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(739, 147)
        Me.GroupControl1.TabIndex = 52
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 170)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(205, 14)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Data penjualan konsinyasi dari tanggal"
        '
        'tgl_dari
        '
        Me.tgl_dari.EditValue = Nothing
        Me.tgl_dari.Location = New System.Drawing.Point(223, 167)
        Me.tgl_dari.Name = "tgl_dari"
        Me.tgl_dari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_dari.Properties.Appearance.Options.UseFont = True
        Me.tgl_dari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_dari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_dari.Size = New System.Drawing.Size(132, 21)
        Me.tgl_dari.TabIndex = 54
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(361, 170)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(20, 14)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "s.d."
        '
        'tgl_sampai
        '
        Me.tgl_sampai.EditValue = Nothing
        Me.tgl_sampai.Location = New System.Drawing.Point(387, 167)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_sampai.Properties.Appearance.Options.UseFont = True
        Me.tgl_sampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_sampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_sampai.Size = New System.Drawing.Size(132, 21)
        Me.tgl_sampai.TabIndex = 56
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(525, 165)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(97, 24)
        Me.cmd_load.TabIndex = 72
        Me.cmd_load.Text = "Load"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(551, 400)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 76
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(654, 400)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 75
        Me.cmd_cancel.Text = "Cancel"
        '
        'txt_total_netto
        '
        Me.txt_total_netto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_netto.Location = New System.Drawing.Point(402, 349)
        Me.txt_total_netto.Name = "txt_total_netto"
        Me.txt_total_netto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_netto.Properties.Appearance.Options.UseFont = True
        Me.txt_total_netto.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total_netto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total_netto.Properties.Mask.EditMask = "n0"
        Me.txt_total_netto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_netto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_netto.Properties.ReadOnly = True
        Me.txt_total_netto.Size = New System.Drawing.Size(127, 21)
        Me.txt_total_netto.TabIndex = 78
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(332, 352)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl7.TabIndex = 77
        Me.LabelControl7.Text = "Total Netto"
        '
        'potongan_harga
        '
        Me.potongan_harga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.potongan_harga.Location = New System.Drawing.Point(402, 376)
        Me.potongan_harga.Name = "potongan_harga"
        Me.potongan_harga.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.potongan_harga.Properties.Appearance.Options.UseFont = True
        Me.potongan_harga.Properties.Appearance.Options.UseTextOptions = True
        Me.potongan_harga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.potongan_harga.Properties.Mask.EditMask = "n0"
        Me.potongan_harga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.potongan_harga.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.potongan_harga.Size = New System.Drawing.Size(127, 21)
        Me.potongan_harga.TabIndex = 79
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total.Location = New System.Drawing.Point(402, 403)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Properties.Appearance.Options.UseFont = True
        Me.txt_total.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total.Properties.Mask.EditMask = "n0"
        Me.txt_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total.Properties.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(127, 21)
        Me.txt_total.TabIndex = 80
        '
        'potongan_deskripsi
        '
        Me.potongan_deskripsi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.potongan_deskripsi.Location = New System.Drawing.Point(213, 376)
        Me.potongan_deskripsi.Name = "potongan_deskripsi"
        Me.potongan_deskripsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.potongan_deskripsi.Properties.Appearance.Options.UseFont = True
        Me.potongan_deskripsi.Size = New System.Drawing.Size(182, 21)
        Me.potongan_deskripsi.TabIndex = 81
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(364, 406)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(31, 14)
        Me.LabelControl8.TabIndex = 82
        Me.LabelControl8.Text = "Total"
        '
        'frm_faktur_konsinyasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 436)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.potongan_deskripsi)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.potongan_harga)
        Me.Controls.Add(Me.txt_total_netto)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_load)
        Me.Controls.Add(Me.tgl_sampai)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.tgl_dari)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_faktur_konsinyasi"
        Me.Text = "Faktur Jual Konsinyasi"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_faktur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_jatuhtempo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_jatuhtempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_netto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potongan_harga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potongan_deskripsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents no_faktur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_terbit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_jatuhtempo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_dari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_sampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_total_netto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents potongan_harga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents potongan_deskripsi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
