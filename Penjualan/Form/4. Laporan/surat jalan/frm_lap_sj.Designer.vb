<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lap_sj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lap_sj))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sistem_jual = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_sampai = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_dari = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.rdo_tujuan = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.kode_group = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.kode_kota = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.kode_provinsi = New DevExpress.XtraEditors.LookUpEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_export = New DevExpress.XtraEditors.SimpleButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sistem_jual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdo_tujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sistem_jual)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.tgl_sampai)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.tgl_dari)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(194, 135)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Tanggal"
        '
        'sistem_jual
        '
        Me.sistem_jual.EditValue = 1
        Me.sistem_jual.Location = New System.Drawing.Point(78, 76)
        Me.sistem_jual.Name = "sistem_jual"
        Me.sistem_jual.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sistem_jual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sistem_jual.Properties.Appearance.Options.UseBackColor = True
        Me.sistem_jual.Properties.Appearance.Options.UseFont = True
        Me.sistem_jual.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Konsinyasi"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Putus")})
        Me.sistem_jual.Size = New System.Drawing.Size(104, 51)
        Me.sistem_jual.TabIndex = 75
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(8, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "Sistem Jual"
        '
        'tgl_sampai
        '
        Me.tgl_sampai.EditValue = Nothing
        Me.tgl_sampai.Location = New System.Drawing.Point(78, 52)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_sampai.Properties.Appearance.Options.UseFont = True
        Me.tgl_sampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_sampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_sampai.Size = New System.Drawing.Size(104, 21)
        Me.tgl_sampai.TabIndex = 28
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(8, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Sampai"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(8, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 14)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Dari"
        '
        'tgl_dari
        '
        Me.tgl_dari.EditValue = Nothing
        Me.tgl_dari.Location = New System.Drawing.Point(78, 25)
        Me.tgl_dari.Name = "tgl_dari"
        Me.tgl_dari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_dari.Properties.Appearance.Options.UseFont = True
        Me.tgl_dari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_dari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_dari.Size = New System.Drawing.Size(104, 21)
        Me.tgl_dari.TabIndex = 25
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.kode_customer_parent)
        Me.GroupControl2.Controls.Add(Me.rdo_tujuan)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.kode_group)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.kode_kota)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.kode_provinsi)
        Me.GroupControl2.Location = New System.Drawing.Point(212, 5)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(570, 135)
        Me.GroupControl2.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(166, 92)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 75
        Me.LabelControl6.Text = "Customer"
        '
        'kode_customer_parent
        '
        Me.kode_customer_parent.Enabled = False
        Me.kode_customer_parent.Location = New System.Drawing.Point(166, 106)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(241, 20)
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
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(166, 51)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl8.TabIndex = 70
        Me.LabelControl8.Text = "Group"
        '
        'kode_group
        '
        Me.kode_group.Enabled = False
        Me.kode_group.Location = New System.Drawing.Point(166, 66)
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
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 176)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(770, 205)
        Me.GridControl1.TabIndex = 33
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(12, 146)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(102, 24)
        Me.cmd_load.TabIndex = 45
        Me.cmd_load.Text = "Load"
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(680, 388)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(102, 24)
        Me.cmd_print.TabIndex = 46
        Me.cmd_print.Text = "Print"
        '
        'cmd_export
        '
        Me.cmd_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_export.Location = New System.Drawing.Point(572, 388)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(102, 24)
        Me.cmd_export.TabIndex = 47
        Me.cmd_export.Text = "Export Ke Excel"
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
            "oman;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\qc\b\f0\fs28 LAPORAN SURAT JALAN\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\b0\fs22 $tan" & _
            "ggal\fs16\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\fs20\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frm_lap_sj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 424)
        Me.Controls.Add(Me.cmd_export)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.cmd_load)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.MinimumSize = New System.Drawing.Size(810, 462)
        Me.Name = "frm_lap_sj"
        Me.Text = "Laporan Surat Jalan"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sistem_jual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdo_tujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tgl_sampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_dari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_group As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_kota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_provinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rdo_tujuan As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sistem_jual As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
End Class
