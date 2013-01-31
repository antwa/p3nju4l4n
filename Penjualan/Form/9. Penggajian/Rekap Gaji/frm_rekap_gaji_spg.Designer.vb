<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rekap_gaji_spg
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nama_bank = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.rdo_status = New DevExpress.XtraEditors.RadioGroup
        Me.rdo_berdasarkan = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ComboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit5 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.chk_semua_customer = New DevExpress.XtraEditors.CheckEdit
        Me.cmb_tahun = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmb_bulan = New DevExpress.XtraEditors.ComboBoxEdit
        Me.chk_check = New DevExpress.XtraEditors.CheckEdit
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nama_bank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdo_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdo_berdasarkan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_tahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_bulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(13, 136)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(722, 196)
        Me.GridControl1.TabIndex = 33
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
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(455, 38)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(200, 21)
        Me.kode_customer.TabIndex = 46
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(352, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 14)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "Kode Customer"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 14)
        Me.LabelControl4.TabIndex = 55
        Me.LabelControl4.Text = "Periode"
        '
        'txt_nama_bank
        '
        Me.txt_nama_bank.EditValue = ""
        Me.txt_nama_bank.Location = New System.Drawing.Point(87, 34)
        Me.txt_nama_bank.Name = "txt_nama_bank"
        Me.txt_nama_bank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_bank.Properties.Appearance.Options.UseFont = True
        Me.txt_nama_bank.Size = New System.Drawing.Size(132, 21)
        Me.txt_nama_bank.TabIndex = 73
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl17.TabIndex = 72
        Me.LabelControl17.Text = "Nama Bank"
        '
        'rdo_status
        '
        Me.rdo_status.Location = New System.Drawing.Point(87, 61)
        Me.rdo_status.Name = "rdo_status"
        Me.rdo_status.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_status.Properties.Appearance.Options.UseFont = True
        Me.rdo_status.Size = New System.Drawing.Size(217, 22)
        Me.rdo_status.TabIndex = 74
        '
        'rdo_berdasarkan
        '
        Me.rdo_berdasarkan.Location = New System.Drawing.Point(352, 9)
        Me.rdo_berdasarkan.Name = "rdo_berdasarkan"
        Me.rdo_berdasarkan.Size = New System.Drawing.Size(303, 22)
        Me.rdo_berdasarkan.TabIndex = 75
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl2.TabIndex = 76
        Me.LabelControl2.Text = "Status"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(352, 66)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 14)
        Me.LabelControl3.TabIndex = 77
        Me.LabelControl3.Text = "Wilayah"
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(455, 63)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit3.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEdit3.TabIndex = 78
        '
        'ComboBoxEdit4
        '
        Me.ComboBoxEdit4.Location = New System.Drawing.Point(455, 86)
        Me.ComboBoxEdit4.Name = "ComboBoxEdit4"
        Me.ComboBoxEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit4.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit4.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEdit4.TabIndex = 80
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(352, 89)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(25, 14)
        Me.LabelControl5.TabIndex = 79
        Me.LabelControl5.Text = "Kota"
        '
        'ComboBoxEdit5
        '
        Me.ComboBoxEdit5.Location = New System.Drawing.Point(455, 109)
        Me.ComboBoxEdit5.Name = "ComboBoxEdit5"
        Me.ComboBoxEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit5.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit5.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEdit5.TabIndex = 82
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(352, 112)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl6.TabIndex = 81
        Me.LabelControl6.Text = "Group"
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(198, 103)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(106, 27)
        Me.cmd_load.TabIndex = 99
        Me.cmd_load.Text = "Load"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 375)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(106, 23)
        Me.SimpleButton2.TabIndex = 100
        Me.SimpleButton2.Text = "Export Ke Excel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(124, 375)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(106, 23)
        Me.SimpleButton3.TabIndex = 101
        Me.SimpleButton3.Text = "Print Slip Gaji"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Location = New System.Drawing.Point(629, 375)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(106, 23)
        Me.SimpleButton4.TabIndex = 102
        Me.SimpleButton4.Text = "Print"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(517, 375)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(106, 23)
        Me.SimpleButton1.TabIndex = 103
        Me.SimpleButton1.Text = "Print Lap Transfer"
        '
        'chk_semua_customer
        '
        Me.chk_semua_customer.Location = New System.Drawing.Point(661, 39)
        Me.chk_semua_customer.Name = "chk_semua_customer"
        Me.chk_semua_customer.Properties.Caption = "Semua"
        Me.chk_semua_customer.Size = New System.Drawing.Size(74, 19)
        Me.chk_semua_customer.TabIndex = 104
        '
        'cmb_tahun
        '
        Me.cmb_tahun.Location = New System.Drawing.Point(225, 7)
        Me.cmb_tahun.Name = "cmb_tahun"
        Me.cmb_tahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tahun.Properties.Appearance.Options.UseFont = True
        Me.cmb_tahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_tahun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_tahun.Size = New System.Drawing.Size(79, 21)
        Me.cmb_tahun.TabIndex = 106
        '
        'cmb_bulan
        '
        Me.cmb_bulan.Location = New System.Drawing.Point(87, 7)
        Me.cmb_bulan.Name = "cmb_bulan"
        Me.cmb_bulan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bulan.Properties.Appearance.Options.UseFont = True
        Me.cmb_bulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_bulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmb_bulan.Size = New System.Drawing.Size(132, 21)
        Me.cmb_bulan.TabIndex = 105
        '
        'chk_check
        '
        Me.chk_check.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_check.Location = New System.Drawing.Point(601, 338)
        Me.chk_check.Name = "chk_check"
        Me.chk_check.Properties.Caption = "Check All / Uncheck All"
        Me.chk_check.Size = New System.Drawing.Size(134, 19)
        Me.chk_check.TabIndex = 107
        '
        'frm_rekap_gaji_spg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 410)
        Me.Controls.Add(Me.chk_check)
        Me.Controls.Add(Me.cmb_tahun)
        Me.Controls.Add(Me.cmb_bulan)
        Me.Controls.Add(Me.chk_semua_customer)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.cmd_load)
        Me.Controls.Add(Me.ComboBoxEdit5)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.ComboBoxEdit4)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.ComboBoxEdit3)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.rdo_berdasarkan)
        Me.Controls.Add(Me.rdo_status)
        Me.Controls.Add(Me.txt_nama_bank)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.kode_customer)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_rekap_gaji_spg"
        Me.Text = "Rekap Gaji SPG"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nama_bank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdo_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdo_berdasarkan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_tahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_bulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nama_bank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdo_status As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rdo_berdasarkan As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit5 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_semua_customer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmb_tahun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmb_bulan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chk_check As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
End Class
