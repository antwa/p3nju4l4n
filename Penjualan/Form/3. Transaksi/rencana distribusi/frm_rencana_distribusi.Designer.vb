<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rencana_distribusi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rencana_distribusi))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tanggal = New DevExpress.XtraEditors.DateEdit
        Me.no_rencana = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_load_customer = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cari = New DevExpress.XtraEditors.SimpleButton
        Me.kode_barangjadi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_qty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_tambah_kelist = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.a = New DevExpress.XtraEditors.SimpleButton
        Me.keterangan = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.stok = New DevExpress.XtraEditors.TextEdit
        Me.lbl_nama_artikel = New DevExpress.XtraEditors.LabelControl
        Me.cmd_load_artikel = New DevExpress.XtraEditors.SimpleButton
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_rencana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(224, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl3.TabIndex = 36
        Me.LabelControl3.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.EditValue = Nothing
        Me.tanggal.Location = New System.Drawing.Point(273, 12)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Properties.Appearance.Options.UseFont = True
        Me.tanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tanggal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tanggal.Size = New System.Drawing.Size(147, 21)
        Me.tanggal.TabIndex = 35
        '
        'no_rencana
        '
        Me.no_rencana.Location = New System.Drawing.Point(83, 12)
        Me.no_rencana.Name = "no_rencana"
        Me.no_rencana.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_rencana.Properties.Appearance.Options.UseFont = True
        Me.no_rencana.Properties.ReadOnly = True
        Me.no_rencana.Size = New System.Drawing.Size(122, 21)
        Me.no_rencana.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(11, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 14)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "Nomor"
        '
        'cmd_load_customer
        '
        Me.cmd_load_customer.Location = New System.Drawing.Point(426, 9)
        Me.cmd_load_customer.Name = "cmd_load_customer"
        Me.cmd_load_customer.Size = New System.Drawing.Size(108, 24)
        Me.cmd_load_customer.TabIndex = 46
        Me.cmd_load_customer.Text = "Load Customer"
        '
        'cmd_cari
        '
        Me.cmd_cari.Location = New System.Drawing.Point(224, 52)
        Me.cmd_cari.Name = "cmd_cari"
        Me.cmd_cari.Size = New System.Drawing.Size(39, 21)
        Me.cmd_cari.TabIndex = 50
        Me.cmd_cari.Text = "..."
        '
        'kode_barangjadi
        '
        Me.kode_barangjadi.Location = New System.Drawing.Point(83, 52)
        Me.kode_barangjadi.Name = "kode_barangjadi"
        Me.kode_barangjadi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_barangjadi.Properties.Appearance.Options.UseFont = True
        Me.kode_barangjadi.Size = New System.Drawing.Size(135, 21)
        Me.kode_barangjadi.TabIndex = 49
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(11, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Kode Artikel"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(318, 52)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Properties.Appearance.Options.UseFont = True
        Me.txt_qty.Size = New System.Drawing.Size(61, 21)
        Me.txt_qty.TabIndex = 51
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(275, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 14)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Jumlah"
        '
        'cmd_tambah_kelist
        '
        Me.cmd_tambah_kelist.Location = New System.Drawing.Point(397, 52)
        Me.cmd_tambah_kelist.Name = "cmd_tambah_kelist"
        Me.cmd_tambah_kelist.Size = New System.Drawing.Size(96, 24)
        Me.cmd_tambah_kelist.TabIndex = 47
        Me.cmd_tambah_kelist.Text = "Tambah Ke List"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 79)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(720, 289)
        Me.GridControl1.TabIndex = 53
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
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'a
        '
        Me.a.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a.Location = New System.Drawing.Point(635, 374)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(97, 24)
        Me.a.TabIndex = 54
        Me.a.Text = "Save && Print"
        '
        'keterangan
        '
        Me.keterangan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keterangan.Location = New System.Drawing.Point(85, 377)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.Properties.Appearance.Options.UseFont = True
        Me.keterangan.Size = New System.Drawing.Size(488, 21)
        Me.keterangan.TabIndex = 55
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(16, 380)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl5.TabIndex = 56
        Me.LabelControl5.Text = "Keterangan"
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(510, 55)
        Me.stok.Name = "stok"
        Me.stok.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stok.Properties.Appearance.Options.UseBackColor = True
        Me.stok.Properties.Appearance.Options.UseFont = True
        Me.stok.Size = New System.Drawing.Size(44, 21)
        Me.stok.TabIndex = 57
        Me.stok.Visible = False
        '
        'lbl_nama_artikel
        '
        Me.lbl_nama_artikel.Location = New System.Drawing.Point(565, 55)
        Me.lbl_nama_artikel.Name = "lbl_nama_artikel"
        Me.lbl_nama_artikel.Size = New System.Drawing.Size(77, 13)
        Me.lbl_nama_artikel.TabIndex = 58
        Me.lbl_nama_artikel.Text = "lbl_nama_artikel"
        Me.lbl_nama_artikel.Visible = False
        '
        'cmd_load_artikel
        '
        Me.cmd_load_artikel.Location = New System.Drawing.Point(540, 9)
        Me.cmd_load_artikel.Name = "cmd_load_artikel"
        Me.cmd_load_artikel.Size = New System.Drawing.Size(108, 24)
        Me.cmd_load_artikel.TabIndex = 59
        Me.cmd_load_artikel.Text = "Load Artikel"
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
        '
        'frm_rencana_distribusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 410)
        Me.Controls.Add(Me.cmd_load_artikel)
        Me.Controls.Add(Me.lbl_nama_artikel)
        Me.Controls.Add(Me.no_rencana)
        Me.Controls.Add(Me.cmd_load_customer)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cmd_tambah_kelist)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.cmd_cari)
        Me.Controls.Add(Me.kode_barangjadi)
        Me.Controls.Add(Me.LabelControl4)
        Me.Name = "frm_rencana_distribusi"
        Me.Text = "Input Rencana Distribusi"
        CType(Me.tanggal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_rencana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_barangjadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents no_rencana As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_load_customer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents kode_barangjadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_tambah_kelist As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents a As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents keterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_nama_artikel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_load_artikel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
