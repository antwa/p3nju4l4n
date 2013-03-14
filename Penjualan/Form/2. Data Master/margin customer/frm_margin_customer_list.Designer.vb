<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_margin_customer_list
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_margin_customer_list))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.tipe_customer = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.rdo_tujuan = New DevExpress.XtraEditors.RadioGroup
        Me.chk_all_group = New DevExpress.XtraEditors.CheckEdit
        Me.chk_all_kota = New DevExpress.XtraEditors.CheckEdit
        Me.chk_all_provinsi = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.kode_group = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.kode_kota = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.kode_provinsi = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_dari = New DevExpress.XtraEditors.DateEdit
        Me.tgl_sampai = New DevExpress.XtraEditors.DateEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_excel = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.tipe_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdo_tujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_all_group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_all_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_all_provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.tipe_customer)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.kode_customer_parent)
        Me.GroupControl2.Controls.Add(Me.rdo_tujuan)
        Me.GroupControl2.Controls.Add(Me.chk_all_group)
        Me.GroupControl2.Controls.Add(Me.chk_all_kota)
        Me.GroupControl2.Controls.Add(Me.chk_all_provinsi)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.kode_group)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.kode_kota)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.kode_provinsi)
        Me.GroupControl2.Location = New System.Drawing.Point(269, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(517, 142)
        Me.GroupControl2.TabIndex = 41
        '
        'tipe_customer
        '
        Me.tipe_customer.EditValue = "Normal"
        Me.tipe_customer.Enabled = False
        Me.tipe_customer.Location = New System.Drawing.Point(413, 108)
        Me.tipe_customer.Name = "tipe_customer"
        Me.tipe_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tipe_customer.Properties.Items.AddRange(New Object() {"Normal", "Obral", "SP"})
        Me.tipe_customer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tipe_customer.Size = New System.Drawing.Size(93, 20)
        Me.tipe_customer.TabIndex = 77
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(214, 94)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 75
        Me.LabelControl6.Text = "Customer"
        '
        'kode_customer_parent
        '
        Me.kode_customer_parent.Enabled = False
        Me.kode_customer_parent.Location = New System.Drawing.Point(214, 108)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(193, 20)
        Me.kode_customer_parent.TabIndex = 76
        '
        'rdo_tujuan
        '
        Me.rdo_tujuan.EditValue = 0
        Me.rdo_tujuan.Location = New System.Drawing.Point(10, 25)
        Me.rdo_tujuan.Name = "rdo_tujuan"
        Me.rdo_tujuan.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Semua"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Wilayah"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Customer")})
        Me.rdo_tujuan.Size = New System.Drawing.Size(397, 21)
        Me.rdo_tujuan.TabIndex = 74
        '
        'chk_all_group
        '
        Me.chk_all_group.EditValue = True
        Me.chk_all_group.Enabled = False
        Me.chk_all_group.Location = New System.Drawing.Point(331, 69)
        Me.chk_all_group.Name = "chk_all_group"
        Me.chk_all_group.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all_group.Properties.Appearance.Options.UseFont = True
        Me.chk_all_group.Properties.Caption = "Semua"
        Me.chk_all_group.Size = New System.Drawing.Size(57, 19)
        Me.chk_all_group.TabIndex = 73
        '
        'chk_all_kota
        '
        Me.chk_all_kota.EditValue = True
        Me.chk_all_kota.Enabled = False
        Me.chk_all_kota.Location = New System.Drawing.Point(148, 108)
        Me.chk_all_kota.Name = "chk_all_kota"
        Me.chk_all_kota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all_kota.Properties.Appearance.Options.UseFont = True
        Me.chk_all_kota.Properties.Caption = "Semua"
        Me.chk_all_kota.Size = New System.Drawing.Size(57, 19)
        Me.chk_all_kota.TabIndex = 72
        '
        'chk_all_provinsi
        '
        Me.chk_all_provinsi.EditValue = True
        Me.chk_all_provinsi.Enabled = False
        Me.chk_all_provinsi.Location = New System.Drawing.Point(148, 68)
        Me.chk_all_provinsi.Name = "chk_all_provinsi"
        Me.chk_all_provinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all_provinsi.Properties.Appearance.Options.UseFont = True
        Me.chk_all_provinsi.Properties.Caption = "Semua"
        Me.chk_all_provinsi.Size = New System.Drawing.Size(57, 19)
        Me.chk_all_provinsi.TabIndex = 71
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(214, 53)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl8.TabIndex = 70
        Me.LabelControl8.Text = "Group"
        '
        'kode_group
        '
        Me.kode_group.Enabled = False
        Me.kode_group.Location = New System.Drawing.Point(214, 68)
        Me.kode_group.Name = "kode_group"
        Me.kode_group.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_group.Properties.Appearance.Options.UseFont = True
        Me.kode_group.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_group.Size = New System.Drawing.Size(111, 20)
        Me.kode_group.TabIndex = 69
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(10, 92)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl7.TabIndex = 68
        Me.LabelControl7.Text = "Kota"
        '
        'kode_kota
        '
        Me.kode_kota.Enabled = False
        Me.kode_kota.Location = New System.Drawing.Point(10, 107)
        Me.kode_kota.Name = "kode_kota"
        Me.kode_kota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_kota.Properties.Appearance.Options.UseFont = True
        Me.kode_kota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_kota.Size = New System.Drawing.Size(132, 20)
        Me.kode_kota.TabIndex = 67
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(10, 52)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 66
        Me.LabelControl5.Text = "Provinsi"
        '
        'kode_provinsi
        '
        Me.kode_provinsi.Enabled = False
        Me.kode_provinsi.Location = New System.Drawing.Point(10, 66)
        Me.kode_provinsi.Name = "kode_provinsi"
        Me.kode_provinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_provinsi.Properties.Appearance.Options.UseFont = True
        Me.kode_provinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_provinsi.Size = New System.Drawing.Size(132, 20)
        Me.kode_provinsi.TabIndex = 65
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmd_load)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.tgl_dari)
        Me.GroupControl1.Controls.Add(Me.tgl_sampai)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(251, 142)
        Me.GroupControl1.TabIndex = 40
        Me.GroupControl1.Text = "Tanggal Terbit"
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(136, 103)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(96, 25)
        Me.cmd_load.TabIndex = 37
        Me.cmd_load.Text = "Load"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 14)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Dari"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl1.TabIndex = 28
        Me.LabelControl1.Text = "Sampai"
        '
        'tgl_dari
        '
        Me.tgl_dari.EditValue = Nothing
        Me.tgl_dari.Location = New System.Drawing.Point(77, 25)
        Me.tgl_dari.Name = "tgl_dari"
        Me.tgl_dari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_dari.Properties.Appearance.Options.UseFont = True
        Me.tgl_dari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_dari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_dari.Size = New System.Drawing.Size(155, 21)
        Me.tgl_dari.TabIndex = 25
        '
        'tgl_sampai
        '
        Me.tgl_sampai.EditValue = Nothing
        Me.tgl_sampai.Location = New System.Drawing.Point(77, 52)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_sampai.Properties.Appearance.Options.UseFont = True
        Me.tgl_sampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_sampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_sampai.Size = New System.Drawing.Size(155, 21)
        Me.tgl_sampai.TabIndex = 27
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 160)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(772, 214)
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
        Me.GridView1.OptionsView.AllowCellMerge = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Location = New System.Drawing.Point(12, 380)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(81, 24)
        Me.cmd_tambah.TabIndex = 43
        Me.cmd_tambah.Text = "Tambah"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Location = New System.Drawing.Point(99, 380)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(81, 24)
        Me.cmd_edit.TabIndex = 44
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Enabled = False
        Me.cmd_simpan.Location = New System.Drawing.Point(186, 380)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(81, 24)
        Me.cmd_simpan.TabIndex = 45
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_excel
        '
        Me.cmd_excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_excel.Location = New System.Drawing.Point(679, 380)
        Me.cmd_excel.Name = "cmd_excel"
        Me.cmd_excel.Size = New System.Drawing.Size(105, 24)
        Me.cmd_excel.TabIndex = 46
        Me.cmd_excel.Text = "Export Ke Excel"
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(568, 380)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(105, 24)
        Me.cmd_print.TabIndex = 47
        Me.cmd_print.Text = "Print"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GridControl1
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink1.RtfReportHeader = resources.GetString("PrintableComponentLink1.RtfReportHeader")
        '
        'frm_margin_customer_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 416)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.cmd_excel)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.MinimumSize = New System.Drawing.Size(812, 454)
        Me.Name = "frm_margin_customer_list"
        Me.Text = "Margin Customer"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.tipe_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdo_tujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_all_group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_all_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_all_provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rdo_tujuan As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents chk_all_group As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_all_kota As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_all_provinsi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_group As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_kota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_provinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_dari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tgl_sampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tipe_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_excel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
