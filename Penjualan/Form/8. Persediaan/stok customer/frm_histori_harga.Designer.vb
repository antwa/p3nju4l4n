<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_histori_harga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_histori_harga))
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_dari = New DevExpress.XtraEditors.DateEdit
        Me.tgl_sampai = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_add = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_export = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.chk_semua_customer = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(84, 12)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(223, 21)
        Me.kode_customer.TabIndex = 65
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(13, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl2.TabIndex = 64
        Me.LabelControl2.Text = "Customer"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl1.TabIndex = 66
        Me.LabelControl1.Text = "Tanggal"
        '
        'tgl_dari
        '
        Me.tgl_dari.EditValue = Nothing
        Me.tgl_dari.Location = New System.Drawing.Point(84, 39)
        Me.tgl_dari.Name = "tgl_dari"
        Me.tgl_dari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_dari.Properties.Appearance.Options.UseFont = True
        Me.tgl_dari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_dari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_dari.Size = New System.Drawing.Size(129, 21)
        Me.tgl_dari.TabIndex = 67
        '
        'tgl_sampai
        '
        Me.tgl_sampai.EditValue = Nothing
        Me.tgl_sampai.Location = New System.Drawing.Point(245, 39)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_sampai.Properties.Appearance.Options.UseFont = True
        Me.tgl_sampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_sampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_sampai.Size = New System.Drawing.Size(129, 21)
        Me.tgl_sampai.TabIndex = 68
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(219, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 14)
        Me.LabelControl3.TabIndex = 69
        Me.LabelControl3.Text = "s.d."
        '
        'cmd_add
        '
        Me.cmd_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_add.Location = New System.Drawing.Point(12, 330)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(97, 24)
        Me.cmd_add.TabIndex = 73
        Me.cmd_add.Text = "Tambah Harga"
        '
        'cmd_export
        '
        Me.cmd_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_export.Location = New System.Drawing.Point(510, 330)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(97, 24)
        Me.cmd_export.TabIndex = 72
        Me.cmd_export.Text = "Export Ke Excel"
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(613, 330)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(97, 24)
        Me.cmd_print.TabIndex = 71
        Me.cmd_print.Text = "Print"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(13, 110)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(697, 214)
        Me.GridControl1.TabIndex = 70
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
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'chk_semua_customer
        '
        Me.chk_semua_customer.Location = New System.Drawing.Point(313, 13)
        Me.chk_semua_customer.Name = "chk_semua_customer"
        Me.chk_semua_customer.Properties.Caption = "Semua"
        Me.chk_semua_customer.Size = New System.Drawing.Size(61, 19)
        Me.chk_semua_customer.TabIndex = 74
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 80)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(97, 24)
        Me.SimpleButton1.TabIndex = 75
        Me.SimpleButton1.Text = "Load Data"
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
        'frm_histori_harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 366)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.chk_semua_customer)
        Me.Controls.Add(Me.cmd_add)
        Me.Controls.Add(Me.cmd_export)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tgl_sampai)
        Me.Controls.Add(Me.tgl_dari)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.kode_customer)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "frm_histori_harga"
        Me.Text = "Harga Barang Customer"
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_semua_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_dari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tgl_sampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chk_semua_customer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
