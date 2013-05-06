<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_targetpenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_targetpenjualan))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.pc_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.pc_print = New DevExpress.XtraEditors.SimpleButton
        Me.pc_GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.pc_GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pc_tahun = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.pc_kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.chk_all_group = New DevExpress.XtraEditors.CheckEdit
        Me.chk_all_kota = New DevExpress.XtraEditors.CheckEdit
        Me.chk_all_provinsi = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.kode_group = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.kode_kota = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.kode_provinsi = New DevExpress.XtraEditors.LookUpEdit
        Me.pb_load = New DevExpress.XtraEditors.SimpleButton
        Me.pb_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.pb_print = New DevExpress.XtraEditors.SimpleButton
        Me.pb_GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.pb_GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pb_data_lalu = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.pb_tahun = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.pb_bulan = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.pc_GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_tahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.chk_all_group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_all_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_all_provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_data_lalu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_tahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_bulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(691, 402)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.pc_simpan)
        Me.XtraTabPage1.Controls.Add(Me.pc_print)
        Me.XtraTabPage1.Controls.Add(Me.pc_GridControl1)
        Me.XtraTabPage1.Controls.Add(Me.pc_tahun)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.pc_kode_customer_parent)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(684, 374)
        Me.XtraTabPage1.Text = "Per Customer"
        '
        'pc_simpan
        '
        Me.pc_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pc_simpan.Location = New System.Drawing.Point(579, 341)
        Me.pc_simpan.Name = "pc_simpan"
        Me.pc_simpan.Size = New System.Drawing.Size(97, 24)
        Me.pc_simpan.TabIndex = 48
        Me.pc_simpan.Text = "Simpan"
        '
        'pc_print
        '
        Me.pc_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pc_print.Location = New System.Drawing.Point(476, 341)
        Me.pc_print.Name = "pc_print"
        Me.pc_print.Size = New System.Drawing.Size(97, 24)
        Me.pc_print.TabIndex = 47
        Me.pc_print.Text = "Print"
        '
        'pc_GridControl1
        '
        Me.pc_GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pc_GridControl1.Location = New System.Drawing.Point(10, 70)
        Me.pc_GridControl1.MainView = Me.pc_GridView1
        Me.pc_GridControl1.Name = "pc_GridControl1"
        Me.pc_GridControl1.Size = New System.Drawing.Size(666, 265)
        Me.pc_GridControl1.TabIndex = 46
        Me.pc_GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.pc_GridView1})
        '
        'pc_GridView1
        '
        Me.pc_GridView1.GridControl = Me.pc_GridControl1
        Me.pc_GridView1.Name = "pc_GridView1"
        Me.pc_GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.pc_GridView1.OptionsCustomization.AllowFilter = False
        Me.pc_GridView1.OptionsCustomization.AllowGroup = False
        Me.pc_GridView1.OptionsCustomization.AllowSort = False
        Me.pc_GridView1.OptionsView.ColumnAutoWidth = False
        Me.pc_GridView1.OptionsView.ShowFooter = True
        Me.pc_GridView1.OptionsView.ShowGroupPanel = False
        '
        'pc_tahun
        '
        Me.pc_tahun.Location = New System.Drawing.Point(82, 43)
        Me.pc_tahun.Name = "pc_tahun"
        Me.pc_tahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pc_tahun.Properties.Appearance.Options.UseFont = True
        Me.pc_tahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pc_tahun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.pc_tahun.Size = New System.Drawing.Size(92, 21)
        Me.pc_tahun.TabIndex = 45
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Tahun"
        '
        'pc_kode_customer_parent
        '
        Me.pc_kode_customer_parent.Location = New System.Drawing.Point(82, 16)
        Me.pc_kode_customer_parent.Name = "pc_kode_customer_parent"
        Me.pc_kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pc_kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.pc_kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pc_kode_customer_parent.Size = New System.Drawing.Size(262, 21)
        Me.pc_kode_customer_parent.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(10, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 42
        Me.LabelControl6.Text = "Customer"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.chk_all_group)
        Me.XtraTabPage2.Controls.Add(Me.chk_all_kota)
        Me.XtraTabPage2.Controls.Add(Me.chk_all_provinsi)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.kode_group)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.kode_kota)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.kode_provinsi)
        Me.XtraTabPage2.Controls.Add(Me.pb_load)
        Me.XtraTabPage2.Controls.Add(Me.pb_simpan)
        Me.XtraTabPage2.Controls.Add(Me.pb_print)
        Me.XtraTabPage2.Controls.Add(Me.pb_GridControl1)
        Me.XtraTabPage2.Controls.Add(Me.pb_data_lalu)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.pb_tahun)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.pb_bulan)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(684, 374)
        Me.XtraTabPage2.Text = "Per Bulan"
        '
        'chk_all_group
        '
        Me.chk_all_group.EditValue = True
        Me.chk_all_group.Location = New System.Drawing.Point(529, 70)
        Me.chk_all_group.Name = "chk_all_group"
        Me.chk_all_group.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all_group.Properties.Appearance.Options.UseFont = True
        Me.chk_all_group.Properties.Caption = "Semua"
        Me.chk_all_group.Size = New System.Drawing.Size(83, 19)
        Me.chk_all_group.TabIndex = 64
        '
        'chk_all_kota
        '
        Me.chk_all_kota.EditValue = True
        Me.chk_all_kota.Location = New System.Drawing.Point(529, 43)
        Me.chk_all_kota.Name = "chk_all_kota"
        Me.chk_all_kota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all_kota.Properties.Appearance.Options.UseFont = True
        Me.chk_all_kota.Properties.Caption = "Semua"
        Me.chk_all_kota.Size = New System.Drawing.Size(83, 19)
        Me.chk_all_kota.TabIndex = 63
        '
        'chk_all_provinsi
        '
        Me.chk_all_provinsi.EditValue = True
        Me.chk_all_provinsi.Location = New System.Drawing.Point(529, 18)
        Me.chk_all_provinsi.Name = "chk_all_provinsi"
        Me.chk_all_provinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all_provinsi.Properties.Appearance.Options.UseFont = True
        Me.chk_all_provinsi.Properties.Caption = "Semua"
        Me.chk_all_provinsi.Size = New System.Drawing.Size(83, 19)
        Me.chk_all_provinsi.TabIndex = 62
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(301, 71)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl8.TabIndex = 61
        Me.LabelControl8.Text = "Group"
        '
        'kode_group
        '
        Me.kode_group.Enabled = False
        Me.kode_group.Location = New System.Drawing.Point(356, 68)
        Me.kode_group.Name = "kode_group"
        Me.kode_group.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_group.Properties.Appearance.Options.UseFont = True
        Me.kode_group.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_group.Size = New System.Drawing.Size(167, 21)
        Me.kode_group.TabIndex = 60
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(301, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(25, 14)
        Me.LabelControl7.TabIndex = 59
        Me.LabelControl7.Text = "Kota"
        '
        'kode_kota
        '
        Me.kode_kota.Enabled = False
        Me.kode_kota.Location = New System.Drawing.Point(356, 43)
        Me.kode_kota.Name = "kode_kota"
        Me.kode_kota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_kota.Properties.Appearance.Options.UseFont = True
        Me.kode_kota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_kota.Size = New System.Drawing.Size(167, 21)
        Me.kode_kota.TabIndex = 58
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(301, 21)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl5.TabIndex = 57
        Me.LabelControl5.Text = "Provinsi"
        '
        'kode_provinsi
        '
        Me.kode_provinsi.Enabled = False
        Me.kode_provinsi.Location = New System.Drawing.Point(356, 18)
        Me.kode_provinsi.Name = "kode_provinsi"
        Me.kode_provinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_provinsi.Properties.Appearance.Options.UseFont = True
        Me.kode_provinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_provinsi.Size = New System.Drawing.Size(167, 21)
        Me.kode_provinsi.TabIndex = 56
        '
        'pb_load
        '
        Me.pb_load.Location = New System.Drawing.Point(96, 98)
        Me.pb_load.Name = "pb_load"
        Me.pb_load.Size = New System.Drawing.Size(97, 24)
        Me.pb_load.TabIndex = 55
        Me.pb_load.Text = "Load"
        '
        'pb_simpan
        '
        Me.pb_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_simpan.Location = New System.Drawing.Point(579, 341)
        Me.pb_simpan.Name = "pb_simpan"
        Me.pb_simpan.Size = New System.Drawing.Size(97, 24)
        Me.pb_simpan.TabIndex = 54
        Me.pb_simpan.Text = "Simpan"
        '
        'pb_print
        '
        Me.pb_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_print.Location = New System.Drawing.Point(476, 341)
        Me.pb_print.Name = "pb_print"
        Me.pb_print.Size = New System.Drawing.Size(97, 24)
        Me.pb_print.TabIndex = 53
        Me.pb_print.Text = "Print"
        '
        'pb_GridControl1
        '
        Me.pb_GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_GridControl1.Location = New System.Drawing.Point(10, 128)
        Me.pb_GridControl1.MainView = Me.pb_GridView1
        Me.pb_GridControl1.Name = "pb_GridControl1"
        Me.pb_GridControl1.Size = New System.Drawing.Size(666, 207)
        Me.pb_GridControl1.TabIndex = 52
        Me.pb_GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.pb_GridView1})
        '
        'pb_GridView1
        '
        Me.pb_GridView1.GridControl = Me.pb_GridControl1
        Me.pb_GridView1.Name = "pb_GridView1"
        Me.pb_GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.pb_GridView1.OptionsCustomization.AllowFilter = False
        Me.pb_GridView1.OptionsCustomization.AllowGroup = False
        Me.pb_GridView1.OptionsCustomization.AllowSort = False
        Me.pb_GridView1.OptionsView.ColumnAutoWidth = False
        Me.pb_GridView1.OptionsView.ShowFooter = True
        Me.pb_GridView1.OptionsView.ShowGroupPanel = False
        '
        'pb_data_lalu
        '
        Me.pb_data_lalu.EditValue = 1
        Me.pb_data_lalu.Location = New System.Drawing.Point(96, 70)
        Me.pb_data_lalu.Name = "pb_data_lalu"
        Me.pb_data_lalu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_data_lalu.Properties.Appearance.Options.UseFont = True
        Me.pb_data_lalu.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Primer"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Sekunder")})
        Me.pb_data_lalu.Size = New System.Drawing.Size(170, 22)
        Me.pb_data_lalu.TabIndex = 51
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(10, 73)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(70, 14)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Data Bln Lalu"
        '
        'pb_tahun
        '
        Me.pb_tahun.Location = New System.Drawing.Point(96, 43)
        Me.pb_tahun.Name = "pb_tahun"
        Me.pb_tahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_tahun.Properties.Appearance.Options.UseFont = True
        Me.pb_tahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pb_tahun.Size = New System.Drawing.Size(104, 21)
        Me.pb_tahun.TabIndex = 49
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(10, 46)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl3.TabIndex = 48
        Me.LabelControl3.Text = "Tahun"
        '
        'pb_bulan
        '
        Me.pb_bulan.Location = New System.Drawing.Point(96, 18)
        Me.pb_bulan.Name = "pb_bulan"
        Me.pb_bulan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_bulan.Properties.Appearance.Options.UseFont = True
        Me.pb_bulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pb_bulan.Size = New System.Drawing.Size(170, 21)
        Me.pb_bulan.TabIndex = 47
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 14)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Bulan"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.pc_GridControl1
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink1.RtfReportHeader = resources.GetString("PrintableComponentLink1.RtfReportHeader")
        '
        'PrintableComponentLink2
        '
        Me.PrintableComponentLink2.Component = Me.pb_GridControl1
        '
        '
        '
        Me.PrintableComponentLink2.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink2.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink2.PrintingSystemBase = Me.PrintingSystem1
        Me.PrintableComponentLink2.RtfReportHeader = resources.GetString("PrintableComponentLink2.RtfReportHeader")
        '
        'frm_targetpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 402)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frm_targetpenjualan"
        Me.Text = "Input Target Penjualan"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.pc_GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_tahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.chk_all_group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_all_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_all_provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_data_lalu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_tahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_bulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pc_kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pc_tahun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pc_GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents pc_GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pc_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pc_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pb_bulan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pb_tahun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pb_data_lalu As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents pb_GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents pb_GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pb_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pb_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pb_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_provinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_group As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_kota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chk_all_group As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_all_kota As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_all_provinsi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintableComponentLink2 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
