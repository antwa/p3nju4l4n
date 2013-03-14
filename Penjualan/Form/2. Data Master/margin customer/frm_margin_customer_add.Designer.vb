<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_margin_customer_add
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
        Me.cmb_tipecustomer = New DevExpress.XtraEditors.ComboBoxEdit
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.rdg_margin = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.margin_toko = New DevExpress.XtraEditors.TextEdit
        Me.margin_konsumen = New DevExpress.XtraEditors.TextEdit
        Me.disc_acara = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.chk_semua_customer = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.disc_acara_kita = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.disc_acara_toko = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.cmb_bulan = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.cmb_tahun = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmb_tipecustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdg_margin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.margin_toko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.margin_konsumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disc_acara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disc_acara_kita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disc_acara_toko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_bulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_tahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.disc_acara_toko)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.disc_acara_kita)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.chk_semua_customer)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.disc_acara)
        Me.GroupControl1.Controls.Add(Me.margin_konsumen)
        Me.GroupControl1.Controls.Add(Me.margin_toko)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.rdg_margin)
        Me.GroupControl1.Controls.Add(Me.cmb_tipecustomer)
        Me.GroupControl1.Controls.Add(Me.kode_customer_parent)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(356, 275)
        Me.GroupControl1.TabIndex = 0
        '
        'cmb_tipecustomer
        '
        Me.cmb_tipecustomer.EditValue = "Normal"
        Me.cmb_tipecustomer.Location = New System.Drawing.Point(83, 49)
        Me.cmb_tipecustomer.Name = "cmb_tipecustomer"
        Me.cmb_tipecustomer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipecustomer.Properties.Appearance.Options.UseFont = True
        Me.cmb_tipecustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_tipecustomer.Properties.Items.AddRange(New Object() {"Normal", "Obral", "SP"})
        Me.cmb_tipecustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_tipecustomer.Size = New System.Drawing.Size(90, 21)
        Me.cmb_tipecustomer.TabIndex = 50
        '
        'kode_customer_parent
        '
        Me.kode_customer_parent.Location = New System.Drawing.Point(83, 25)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(201, 21)
        Me.kode_customer_parent.TabIndex = 49
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(7, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 48
        Me.LabelControl6.Text = "Customer"
        '
        'rdg_margin
        '
        Me.rdg_margin.EditValue = 1
        Me.rdg_margin.Location = New System.Drawing.Point(83, 73)
        Me.rdg_margin.Name = "rdg_margin"
        Me.rdg_margin.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Sebelum Disc Acara"), New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Setelah Disc Acara")})
        Me.rdg_margin.Size = New System.Drawing.Size(184, 49)
        Me.rdg_margin.TabIndex = 51
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 76)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "Margin"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(7, 129)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 14)
        Me.LabelControl2.TabIndex = 53
        Me.LabelControl2.Text = "Margin Toko"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(7, 153)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Konsumen"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(7, 180)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl4.TabIndex = 55
        Me.LabelControl4.Text = "Disc Acara"
        '
        'margin_toko
        '
        Me.margin_toko.EditValue = 0
        Me.margin_toko.Location = New System.Drawing.Point(83, 126)
        Me.margin_toko.Name = "margin_toko"
        Me.margin_toko.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margin_toko.Properties.Appearance.Options.UseFont = True
        Me.margin_toko.Properties.Appearance.Options.UseTextOptions = True
        Me.margin_toko.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.margin_toko.Size = New System.Drawing.Size(47, 21)
        Me.margin_toko.TabIndex = 56
        '
        'margin_konsumen
        '
        Me.margin_konsumen.EditValue = 0
        Me.margin_konsumen.Location = New System.Drawing.Point(83, 150)
        Me.margin_konsumen.Name = "margin_konsumen"
        Me.margin_konsumen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margin_konsumen.Properties.Appearance.Options.UseFont = True
        Me.margin_konsumen.Properties.Appearance.Options.UseTextOptions = True
        Me.margin_konsumen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.margin_konsumen.Size = New System.Drawing.Size(47, 21)
        Me.margin_konsumen.TabIndex = 57
        '
        'disc_acara
        '
        Me.disc_acara.EditValue = 0
        Me.disc_acara.Location = New System.Drawing.Point(83, 177)
        Me.disc_acara.Name = "disc_acara"
        Me.disc_acara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_acara.Properties.Appearance.Options.UseFont = True
        Me.disc_acara.Properties.Appearance.Options.UseTextOptions = True
        Me.disc_acara.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.disc_acara.Size = New System.Drawing.Size(47, 21)
        Me.disc_acara.TabIndex = 58
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(136, 129)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(12, 14)
        Me.LabelControl5.TabIndex = 59
        Me.LabelControl5.Text = "%"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(136, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(12, 14)
        Me.LabelControl7.TabIndex = 60
        Me.LabelControl7.Text = "%"
        '
        'chk_semua_customer
        '
        Me.chk_semua_customer.Location = New System.Drawing.Point(290, 26)
        Me.chk_semua_customer.Name = "chk_semua_customer"
        Me.chk_semua_customer.Properties.Caption = "Semua"
        Me.chk_semua_customer.Size = New System.Drawing.Size(61, 19)
        Me.chk_semua_customer.TabIndex = 61
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(136, 180)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl8.TabIndex = 62
        Me.LabelControl8.Text = "% => Kita"
        '
        'disc_acara_kita
        '
        Me.disc_acara_kita.EditValue = 0
        Me.disc_acara_kita.Location = New System.Drawing.Point(200, 177)
        Me.disc_acara_kita.Name = "disc_acara_kita"
        Me.disc_acara_kita.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_acara_kita.Properties.Appearance.Options.UseFont = True
        Me.disc_acara_kita.Properties.Appearance.Options.UseTextOptions = True
        Me.disc_acara_kita.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.disc_acara_kita.Size = New System.Drawing.Size(32, 21)
        Me.disc_acara_kita.TabIndex = 63
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(238, 180)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(48, 14)
        Me.LabelControl9.TabIndex = 64
        Me.LabelControl9.Text = "%; Toko"
        '
        'disc_acara_toko
        '
        Me.disc_acara_toko.EditValue = 0
        Me.disc_acara_toko.Location = New System.Drawing.Point(292, 177)
        Me.disc_acara_toko.Name = "disc_acara_toko"
        Me.disc_acara_toko.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disc_acara_toko.Properties.Appearance.Options.UseFont = True
        Me.disc_acara_toko.Properties.Appearance.Options.UseTextOptions = True
        Me.disc_acara_toko.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.disc_acara_toko.Properties.ReadOnly = True
        Me.disc_acara_toko.Size = New System.Drawing.Size(32, 21)
        Me.disc_acara_toko.TabIndex = 65
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(330, 180)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(12, 14)
        Me.LabelControl10.TabIndex = 66
        Me.LabelControl10.Text = "%"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmb_tahun)
        Me.GroupControl2.Controls.Add(Me.cmb_bulan)
        Me.GroupControl2.Controls.Add(Me.PanelControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(362, 5)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(346, 275)
        Me.GroupControl2.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(5, 51)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(336, 215)
        Me.PanelControl2.TabIndex = 2
        '
        'cmb_bulan
        '
        Me.cmb_bulan.EditValue = "Januari"
        Me.cmb_bulan.Location = New System.Drawing.Point(5, 25)
        Me.cmb_bulan.Name = "cmb_bulan"
        Me.cmb_bulan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bulan.Properties.Appearance.Options.UseFont = True
        Me.cmb_bulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_bulan.Properties.Items.AddRange(New Object() {"Januari", "Pebruari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "Nopember", "Desember"})
        Me.cmb_bulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_bulan.Size = New System.Drawing.Size(109, 21)
        Me.cmb_bulan.TabIndex = 51
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(506, 290)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 25)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Simpan"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(610, 290)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(98, 25)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Keluar"
        '
        'cmb_tahun
        '
        Me.cmb_tahun.EditValue = "Normal"
        Me.cmb_tahun.Location = New System.Drawing.Point(120, 25)
        Me.cmb_tahun.Name = "cmb_tahun"
        Me.cmb_tahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tahun.Properties.Appearance.Options.UseFont = True
        Me.cmb_tahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_tahun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_tahun.Size = New System.Drawing.Size(78, 21)
        Me.cmb_tahun.TabIndex = 52
        '
        'frm_margin_customer_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 327)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 355)
        Me.Name = "frm_margin_customer_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Margin Customer"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmb_tipecustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdg_margin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.margin_toko.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.margin_konsumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disc_acara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disc_acara_kita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disc_acara_toko.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_bulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_tahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmb_tipecustomer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdg_margin As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents margin_toko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents margin_konsumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents disc_acara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_semua_customer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents disc_acara_kita As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents disc_acara_toko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmb_bulan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmb_tahun As DevExpress.XtraEditors.ComboBoxEdit
End Class
