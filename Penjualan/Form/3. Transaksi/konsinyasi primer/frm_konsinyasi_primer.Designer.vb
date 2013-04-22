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
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_terbit = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_kota = New DevExpress.XtraEditors.LabelControl
        Me.lbl_mall = New DevExpress.XtraEditors.LabelControl
        Me.lbl_alamat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_nama = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_hapus_baris = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cari_artikel = New DevExpress.XtraEditors.SimpleButton
        Me.keterangan = New DevExpress.XtraEditors.MemoEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_penjualan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 92)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(824, 209)
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
        'kode_customer_parent
        '
        Me.kode_customer_parent.Location = New System.Drawing.Point(93, 33)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(271, 21)
        Me.kode_customer_parent.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 42
        Me.LabelControl6.Text = "Customer"
        '
        'tgl_terbit
        '
        Me.tgl_terbit.EditValue = Nothing
        Me.tgl_terbit.Location = New System.Drawing.Point(93, 57)
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
        Me.LabelControl2.Location = New System.Drawing.Point(12, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Tgl Terbit"
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
        Me.Controls.Add(Me.lbl_kota)
        Me.Controls.Add(Me.lbl_mall)
        Me.Controls.Add(Me.lbl_alamat)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.tgl_terbit)
        Me.Controls.Add(Me.kode_customer_parent)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.no_penjualan)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_konsinyasi_primer"
        Me.Text = "Input Konsinyasi Primer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_penjualan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents no_penjualan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_terbit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kota As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_mall As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_alamat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_nama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_hapus_baris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cari_artikel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents keterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
