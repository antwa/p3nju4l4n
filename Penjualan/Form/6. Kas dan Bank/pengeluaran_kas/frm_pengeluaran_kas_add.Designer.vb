﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pengeluaran_kas_add
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.keterangan = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.akun_debet = New DevExpress.XtraEditors.LookUpEdit
        Me.tanggal = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.id_jurnal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.lookup_kode = New DevExpress.XtraEditors.LookUpEdit
        Me.rdo_transakasi = New DevExpress.XtraEditors.RadioGroup
        Me.lbl_customer = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.akun_potongan = New DevExpress.XtraEditors.LookUpEdit
        Me.total_bersih = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.potongan = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.jumlah = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.akun_kredit = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.akun_debet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id_jurnal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lookup_kode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdo_transakasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.akun_potongan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.total_bersih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.potongan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jumlah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.akun_kredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.keterangan)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.akun_debet)
        Me.GroupControl1.Controls.Add(Me.tanggal)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.id_jurnal)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(711, 142)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "GroupControl1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Keterangan"
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(148, 84)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.Properties.Appearance.Options.UseFont = True
        Me.keterangan.Size = New System.Drawing.Size(322, 52)
        Me.keterangan.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(130, 14)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Akun Debet (Kode Kas)"
        '
        'akun_debet
        '
        Me.akun_debet.Location = New System.Drawing.Point(148, 36)
        Me.akun_debet.Name = "akun_debet"
        Me.akun_debet.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.akun_debet.Properties.Appearance.Options.UseFont = True
        Me.akun_debet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.akun_debet.Size = New System.Drawing.Size(320, 21)
        Me.akun_debet.TabIndex = 4
        '
        'tanggal
        '
        Me.tanggal.EditValue = Nothing
        Me.tanggal.Location = New System.Drawing.Point(148, 60)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Properties.Appearance.Options.UseFont = True
        Me.tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tanggal.Size = New System.Drawing.Size(135, 21)
        Me.tanggal.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Tanggal"
        '
        'id_jurnal
        '
        Me.id_jurnal.Location = New System.Drawing.Point(148, 12)
        Me.id_jurnal.Name = "id_jurnal"
        Me.id_jurnal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_jurnal.Properties.Appearance.Options.UseFont = True
        Me.id_jurnal.Properties.ReadOnly = True
        Me.id_jurnal.Size = New System.Drawing.Size(135, 21)
        Me.id_jurnal.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "No. Jurnal"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmd_load)
        Me.PanelControl1.Controls.Add(Me.lookup_kode)
        Me.PanelControl1.Controls.Add(Me.rdo_transakasi)
        Me.PanelControl1.Controls.Add(Me.lbl_customer)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 142)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(711, 64)
        Me.PanelControl1.TabIndex = 3
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(384, 37)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(84, 23)
        Me.cmd_load.TabIndex = 10
        Me.cmd_load.Text = "Load"
        '
        'lookup_kode
        '
        Me.lookup_kode.Location = New System.Drawing.Point(65, 37)
        Me.lookup_kode.Name = "lookup_kode"
        Me.lookup_kode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lookup_kode.Properties.Appearance.Options.UseFont = True
        Me.lookup_kode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookup_kode.Size = New System.Drawing.Size(310, 21)
        Me.lookup_kode.TabIndex = 9
        '
        'rdo_transakasi
        '
        Me.rdo_transakasi.EditValue = "barang jadi"
        Me.rdo_transakasi.Location = New System.Drawing.Point(5, 6)
        Me.rdo_transakasi.Name = "rdo_transakasi"
        Me.rdo_transakasi.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("bahan baku", "Bahan Baku"), New DevExpress.XtraEditors.Controls.RadioGroupItem("barang jadi", "Barang Jadi"), New DevExpress.XtraEditors.Controls.RadioGroupItem("aksesoris", "Aksesoris"), New DevExpress.XtraEditors.Controls.RadioGroupItem("lain lain", "Lain-Lain")})
        Me.rdo_transakasi.Size = New System.Drawing.Size(465, 25)
        Me.rdo_transakasi.TabIndex = 1
        '
        'lbl_customer
        '
        Me.lbl_customer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(7, 40)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(52, 14)
        Me.lbl_customer.TabIndex = 8
        Me.lbl_customer.Text = "Customer"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 206)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(711, 158)
        Me.GridControl1.TabIndex = 17
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.akun_potongan)
        Me.GroupControl2.Controls.Add(Me.total_bersih)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.potongan)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.jumlah)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.cmd_simpan)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.akun_kredit)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 364)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(711, 143)
        Me.GroupControl2.TabIndex = 16
        Me.GroupControl2.Text = "GroupControl2"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(85, 14)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "Akun Potongan"
        '
        'akun_potongan
        '
        Me.akun_potongan.Location = New System.Drawing.Point(148, 61)
        Me.akun_potongan.Name = "akun_potongan"
        Me.akun_potongan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.akun_potongan.Properties.Appearance.Options.UseFont = True
        Me.akun_potongan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.akun_potongan.Size = New System.Drawing.Size(320, 21)
        Me.akun_potongan.TabIndex = 18
        '
        'total_bersih
        '
        Me.total_bersih.Location = New System.Drawing.Point(148, 115)
        Me.total_bersih.Name = "total_bersih"
        Me.total_bersih.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_bersih.Properties.Appearance.Options.UseFont = True
        Me.total_bersih.Properties.Appearance.Options.UseTextOptions = True
        Me.total_bersih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.total_bersih.Properties.Mask.EditMask = "n0"
        Me.total_bersih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.total_bersih.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.total_bersih.Properties.ReadOnly = True
        Me.total_bersih.Size = New System.Drawing.Size(160, 21)
        Me.total_bersih.TabIndex = 17
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(12, 118)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(96, 14)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Total Bersih (Rp.)"
        '
        'potongan
        '
        Me.potongan.Location = New System.Drawing.Point(148, 88)
        Me.potongan.Name = "potongan"
        Me.potongan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.potongan.Properties.Appearance.Options.UseFont = True
        Me.potongan.Properties.Appearance.Options.UseTextOptions = True
        Me.potongan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.potongan.Properties.Mask.EditMask = "n0"
        Me.potongan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.potongan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.potongan.Size = New System.Drawing.Size(160, 21)
        Me.potongan.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(85, 14)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Potongan (Rp.)"
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(148, 34)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Properties.Appearance.Options.UseFont = True
        Me.jumlah.Properties.Appearance.Options.UseTextOptions = True
        Me.jumlah.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlah.Properties.Mask.EditMask = "n0"
        Me.jumlah.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.jumlah.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.jumlah.Properties.ReadOnly = True
        Me.jumlah.Size = New System.Drawing.Size(160, 21)
        Me.jumlah.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Total (Rp.)"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(599, 111)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(100, 27)
        Me.cmd_simpan.TabIndex = 11
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 9)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Akun Kredit"
        '
        'akun_kredit
        '
        Me.akun_kredit.Location = New System.Drawing.Point(148, 6)
        Me.akun_kredit.Name = "akun_kredit"
        Me.akun_kredit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.akun_kredit.Properties.Appearance.Options.UseFont = True
        Me.akun_kredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.akun_kredit.Size = New System.Drawing.Size(320, 21)
        Me.akun_kredit.TabIndex = 6
        '
        'frm_pengeluaran_kas_add
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 507)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_pengeluaran_kas_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengeluaran Kas"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.akun_debet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id_jurnal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.lookup_kode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdo_transakasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.akun_potongan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.total_bersih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.potongan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jumlah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.akun_kredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents keterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents akun_debet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id_jurnal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lookup_kode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rdo_transakasi As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lbl_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents akun_potongan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents total_bersih As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents potongan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents jumlah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents akun_kredit As DevExpress.XtraEditors.LookUpEdit
End Class
