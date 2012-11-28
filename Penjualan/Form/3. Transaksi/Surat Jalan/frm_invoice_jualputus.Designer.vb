<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_jualputus
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.no_suratjalan = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_jatuhtempo = New DevExpress.XtraEditors.DateEdit
        Me.no_faktur = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lbl_kota = New DevExpress.XtraEditors.LabelControl
        Me.lbl_mall = New DevExpress.XtraEditors.LabelControl
        Me.lbl_alamat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_nama = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.diskon = New DevExpress.XtraEditors.TextEdit
        Me.lebih_bayar = New DevExpress.XtraEditors.TextEdit
        Me.total = New DevExpress.XtraEditors.TextEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.no_suratjalan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_jatuhtempo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_jatuhtempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_faktur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.diskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lebih_bayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 120)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(669, 175)
        Me.GridControl1.TabIndex = 42
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.no_suratjalan)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.tgl_jatuhtempo)
        Me.GroupControl1.Controls.Add(Me.no_faktur)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 108)
        Me.GroupControl1.TabIndex = 43
        '
        'no_suratjalan
        '
        Me.no_suratjalan.Location = New System.Drawing.Point(118, 52)
        Me.no_suratjalan.Name = "no_suratjalan"
        Me.no_suratjalan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_suratjalan.Properties.Appearance.Options.UseFont = True
        Me.no_suratjalan.Properties.ReadOnly = True
        Me.no_suratjalan.Size = New System.Drawing.Size(140, 21)
        Me.no_suratjalan.TabIndex = 45
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 14)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Tgl Jatuh Tempo"
        '
        'tgl_jatuhtempo
        '
        Me.tgl_jatuhtempo.EditValue = Nothing
        Me.tgl_jatuhtempo.Location = New System.Drawing.Point(118, 79)
        Me.tgl_jatuhtempo.Name = "tgl_jatuhtempo"
        Me.tgl_jatuhtempo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_jatuhtempo.Properties.Appearance.Options.UseFont = True
        Me.tgl_jatuhtempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_jatuhtempo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_jatuhtempo.Size = New System.Drawing.Size(140, 21)
        Me.tgl_jatuhtempo.TabIndex = 43
        '
        'no_faktur
        '
        Me.no_faktur.Location = New System.Drawing.Point(118, 25)
        Me.no_faktur.Name = "no_faktur"
        Me.no_faktur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_faktur.Properties.Appearance.Options.UseFont = True
        Me.no_faktur.Properties.ReadOnly = True
        Me.no_faktur.Size = New System.Drawing.Size(140, 21)
        Me.no_faktur.TabIndex = 42
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 14)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "No. Surat Jalan"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl3.TabIndex = 32
        Me.LabelControl3.Text = "No. Faktur"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.lbl_kota)
        Me.GroupControl2.Controls.Add(Me.lbl_mall)
        Me.GroupControl2.Controls.Add(Me.lbl_alamat)
        Me.GroupControl2.Controls.Add(Me.lbl_nama)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(284, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(397, 108)
        Me.GroupControl2.TabIndex = 44
        '
        'lbl_kota
        '
        Me.lbl_kota.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kota.Location = New System.Drawing.Point(44, 88)
        Me.lbl_kota.Name = "lbl_kota"
        Me.lbl_kota.Size = New System.Drawing.Size(25, 14)
        Me.lbl_kota.TabIndex = 34
        Me.lbl_kota.Text = "Kota"
        '
        'lbl_mall
        '
        Me.lbl_mall.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mall.Location = New System.Drawing.Point(44, 68)
        Me.lbl_mall.Name = "lbl_mall"
        Me.lbl_mall.Size = New System.Drawing.Size(20, 14)
        Me.lbl_mall.TabIndex = 33
        Me.lbl_mall.Text = "mall"
        '
        'lbl_alamat
        '
        Me.lbl_alamat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamat.Location = New System.Drawing.Point(44, 48)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Size = New System.Drawing.Size(35, 14)
        Me.lbl_alamat.TabIndex = 32
        Me.lbl_alamat.Text = "alamat"
        '
        'lbl_nama
        '
        Me.lbl_nama.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(44, 28)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(86, 14)
        Me.lbl_nama.TabIndex = 31
        Me.lbl_nama.Text = "Nama Customer"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "Kpd : "
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(584, 398)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 49
        Me.cmd_simpan.Text = "Simpan"
        '
        'diskon
        '
        Me.diskon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diskon.EditValue = "0"
        Me.diskon.Location = New System.Drawing.Point(541, 301)
        Me.diskon.Name = "diskon"
        Me.diskon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskon.Properties.Appearance.Options.UseFont = True
        Me.diskon.Properties.Appearance.Options.UseTextOptions = True
        Me.diskon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.diskon.Size = New System.Drawing.Size(140, 21)
        Me.diskon.TabIndex = 50
        '
        'lebih_bayar
        '
        Me.lebih_bayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lebih_bayar.EditValue = "0"
        Me.lebih_bayar.Location = New System.Drawing.Point(541, 328)
        Me.lebih_bayar.Name = "lebih_bayar"
        Me.lebih_bayar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lebih_bayar.Properties.Appearance.Options.UseFont = True
        Me.lebih_bayar.Properties.Appearance.Options.UseTextOptions = True
        Me.lebih_bayar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lebih_bayar.Size = New System.Drawing.Size(140, 21)
        Me.lebih_bayar.TabIndex = 51
        '
        'total
        '
        Me.total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total.EditValue = "0"
        Me.total.Location = New System.Drawing.Point(541, 355)
        Me.total.Name = "total"
        Me.total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Properties.Appearance.Options.UseFont = True
        Me.total.Properties.Appearance.Options.UseTextOptions = True
        Me.total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.total.Properties.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(140, 21)
        Me.total.TabIndex = 52
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.Location = New System.Drawing.Point(-1, 386)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Size = New System.Drawing.Size(699, 1)
        Me.PictureEdit1.TabIndex = 53
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(441, 304)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 14)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "Diskon (Rp.)"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(441, 331)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 14)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Lebih Bayar"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(441, 358)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(31, 14)
        Me.LabelControl7.TabIndex = 56
        Me.LabelControl7.Text = "Total"
        '
        'frm_invoice_jualputus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.lebih_bayar)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_invoice_jualputus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Invoice Penjualan Putus"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.no_suratjalan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_jatuhtempo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_jatuhtempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_faktur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.diskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lebih_bayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_kota As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_mall As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_alamat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_nama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents no_faktur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tgl_jatuhtempo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents diskon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lebih_bayar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents no_suratjalan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
