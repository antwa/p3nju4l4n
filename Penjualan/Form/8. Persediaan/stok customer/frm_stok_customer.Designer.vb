<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stok_customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_customer))
        Me.chk_semua_artikel = New DevExpress.XtraEditors.CheckEdit
        Me.stok = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_cari = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_excel = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.chk_semua_customer = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.lbl_nama_artikel = New DevExpress.XtraEditors.LabelControl
        Me.kode_barangjadi = New DevExpress.XtraEditors.TextEdit
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chk_semua_jenisharga = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_jenis_harga = New DevExpress.XtraEditors.LookUpEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.chk_semua_artikel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chk_semua_jenisharga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_jenis_harga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_semua_artikel
        '
        Me.chk_semua_artikel.Location = New System.Drawing.Point(343, 27)
        Me.chk_semua_artikel.Name = "chk_semua_artikel"
        Me.chk_semua_artikel.Properties.Caption = "Semua"
        Me.chk_semua_artikel.Size = New System.Drawing.Size(59, 19)
        Me.chk_semua_artikel.TabIndex = 37
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(86, 26)
        Me.stok.Name = "stok"
        Me.stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stok.Properties.Appearance.Options.UseFont = True
        Me.stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.stok.Size = New System.Drawing.Size(172, 21)
        Me.stok.TabIndex = 36
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(12, 131)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(88, 24)
        Me.cmd_load.TabIndex = 43
        Me.cmd_load.Text = "Load"
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(687, 397)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(97, 24)
        Me.cmd_print.TabIndex = 48
        Me.cmd_print.Text = "Print"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(16, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 14)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "Stok"
        '
        'cmd_cari
        '
        Me.cmd_cari.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_cari.Location = New System.Drawing.Point(258, 25)
        Me.cmd_cari.Name = "cmd_cari"
        Me.cmd_cari.Size = New System.Drawing.Size(79, 21)
        Me.cmd_cari.TabIndex = 34
        Me.cmd_cari.Text = "Cari Artikel"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(16, 59)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl5.TabIndex = 31
        Me.LabelControl5.Text = "Nama Artikel"
        '
        'cmd_excel
        '
        Me.cmd_excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_excel.Location = New System.Drawing.Point(12, 397)
        Me.cmd_excel.Name = "cmd_excel"
        Me.cmd_excel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_excel.TabIndex = 47
        Me.cmd_excel.Text = "Export Ke Excel"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 161)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(772, 230)
        Me.GridControl1.TabIndex = 46
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
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(16, 28)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "Kode Artikel"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.chk_semua_customer)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.kode_customer)
        Me.GroupControl2.Controls.Add(Me.chk_semua_artikel)
        Me.GroupControl2.Controls.Add(Me.cmd_cari)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.lbl_nama_artikel)
        Me.GroupControl2.Controls.Add(Me.kode_barangjadi)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(413, 113)
        Me.GroupControl2.TabIndex = 45
        '
        'chk_semua_customer
        '
        Me.chk_semua_customer.Location = New System.Drawing.Point(343, 80)
        Me.chk_semua_customer.Name = "chk_semua_customer"
        Me.chk_semua_customer.Properties.Caption = "Semua"
        Me.chk_semua_customer.Size = New System.Drawing.Size(59, 19)
        Me.chk_semua_customer.TabIndex = 79
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(16, 82)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 78
        Me.LabelControl6.Text = "Customer"
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(103, 79)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(234, 21)
        Me.kode_customer.TabIndex = 77
        '
        'lbl_nama_artikel
        '
        Me.lbl_nama_artikel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama_artikel.Location = New System.Drawing.Point(103, 59)
        Me.lbl_nama_artikel.Name = "lbl_nama_artikel"
        Me.lbl_nama_artikel.Size = New System.Drawing.Size(12, 14)
        Me.lbl_nama_artikel.TabIndex = 30
        Me.lbl_nama_artikel.Text = "---"
        '
        'kode_barangjadi
        '
        Me.kode_barangjadi.Location = New System.Drawing.Point(103, 25)
        Me.kode_barangjadi.Name = "kode_barangjadi"
        Me.kode_barangjadi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_barangjadi.Properties.Appearance.Options.UseFont = True
        Me.kode_barangjadi.Size = New System.Drawing.Size(149, 21)
        Me.kode_barangjadi.TabIndex = 29
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Location = New System.Drawing.Point(115, 397)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(105, 24)
        Me.cmd_edit.TabIndex = 49
        Me.cmd_edit.Text = "Edit Jenis Barang"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.chk_semua_jenisharga)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.kode_jenis_harga)
        Me.GroupControl1.Controls.Add(Me.stok)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(431, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(353, 113)
        Me.GroupControl1.TabIndex = 80
        '
        'chk_semua_jenisharga
        '
        Me.chk_semua_jenisharga.Location = New System.Drawing.Point(264, 57)
        Me.chk_semua_jenisharga.Name = "chk_semua_jenisharga"
        Me.chk_semua_jenisharga.Properties.Caption = "Semua"
        Me.chk_semua_jenisharga.Size = New System.Drawing.Size(59, 19)
        Me.chk_semua_jenisharga.TabIndex = 79
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl1.TabIndex = 78
        Me.LabelControl1.Text = "Jenis Harga"
        '
        'kode_jenis_harga
        '
        Me.kode_jenis_harga.Location = New System.Drawing.Point(86, 56)
        Me.kode_jenis_harga.Name = "kode_jenis_harga"
        Me.kode_jenis_harga.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_jenis_harga.Properties.Appearance.Options.UseFont = True
        Me.kode_jenis_harga.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_jenis_harga.Size = New System.Drawing.Size(172, 21)
        Me.kode_jenis_harga.TabIndex = 77
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Enabled = False
        Me.cmd_simpan.Location = New System.Drawing.Point(226, 397)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(66, 24)
        Me.cmd_simpan.TabIndex = 81
        Me.cmd_simpan.Text = "Simpan"
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
        Me.PrintableComponentLink1.RtfReportHeader = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Times New R" & _
            "oman;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\qc\b\f0\fs24 LAPORAN STOK CUSTOMER\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frm_stok_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 433)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_load)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.cmd_excel)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "frm_stok_customer"
        Me.Text = "Stok Customer"
        CType(Me.chk_semua_artikel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.chk_semua_jenisharga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_jenis_harga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_semua_artikel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_cari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_excel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_nama_artikel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_barangjadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chk_semua_customer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chk_semua_jenisharga As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_jenis_harga As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
