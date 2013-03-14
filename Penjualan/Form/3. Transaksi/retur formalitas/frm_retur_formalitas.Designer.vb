<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_retur_formalitas
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
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus_baris = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cari_artikel = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_retur = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_retur = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.sumber = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.tujuan = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cmd_load_all_artikel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_retur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_retur.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_retur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(507, 340)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 46
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(610, 340)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 45
        Me.cmd_cancel.Text = "Cancel"
        '
        'cmd_hapus_baris
        '
        Me.cmd_hapus_baris.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus_baris.Location = New System.Drawing.Point(115, 340)
        Me.cmd_hapus_baris.Name = "cmd_hapus_baris"
        Me.cmd_hapus_baris.Size = New System.Drawing.Size(97, 24)
        Me.cmd_hapus_baris.TabIndex = 44
        Me.cmd_hapus_baris.Text = "Hapus"
        '
        'cmd_cari_artikel
        '
        Me.cmd_cari_artikel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_cari_artikel.Location = New System.Drawing.Point(12, 340)
        Me.cmd_cari_artikel.Name = "cmd_cari_artikel"
        Me.cmd_cari_artikel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cari_artikel.TabIndex = 43
        Me.cmd_cari_artikel.Text = "Cari Artikel"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 117)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(695, 217)
        Me.GridControl1.TabIndex = 42
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
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'no_retur
        '
        Me.no_retur.Location = New System.Drawing.Point(89, 9)
        Me.no_retur.Name = "no_retur"
        Me.no_retur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_retur.Properties.Appearance.Options.UseFont = True
        Me.no_retur.Properties.ReadOnly = True
        Me.no_retur.Size = New System.Drawing.Size(120, 21)
        Me.no_retur.TabIndex = 41
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 14)
        Me.LabelControl1.TabIndex = 40
        Me.LabelControl1.Text = "Nomor Retur"
        '
        'kode_customer_parent
        '
        Me.kode_customer_parent.Location = New System.Drawing.Point(89, 63)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(262, 21)
        Me.kode_customer_parent.TabIndex = 39
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 66)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Customer"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "Tanggal"
        '
        'tgl_retur
        '
        Me.tgl_retur.EditValue = Nothing
        Me.tgl_retur.Location = New System.Drawing.Point(89, 36)
        Me.tgl_retur.Name = "tgl_retur"
        Me.tgl_retur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_retur.Properties.Appearance.Options.UseFont = True
        Me.tgl_retur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_retur.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_retur.Size = New System.Drawing.Size(120, 21)
        Me.tgl_retur.TabIndex = 36
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 93)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl2.TabIndex = 47
        Me.LabelControl2.Text = "Retur Dari"
        '
        'sumber
        '
        Me.sumber.EditValue = "NORMAL"
        Me.sumber.Location = New System.Drawing.Point(89, 90)
        Me.sumber.Name = "sumber"
        Me.sumber.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumber.Properties.Appearance.Options.UseFont = True
        Me.sumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sumber.Properties.Items.AddRange(New Object() {"NORMAL", "OBRAL", "SP"})
        Me.sumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sumber.Size = New System.Drawing.Size(88, 21)
        Me.sumber.TabIndex = 48
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(183, 93)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(14, 14)
        Me.LabelControl5.TabIndex = 49
        Me.LabelControl5.Text = "Ke"
        '
        'tujuan
        '
        Me.tujuan.EditValue = "OBRAL"
        Me.tujuan.Location = New System.Drawing.Point(203, 90)
        Me.tujuan.Name = "tujuan"
        Me.tujuan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tujuan.Properties.Appearance.Options.UseFont = True
        Me.tujuan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tujuan.Properties.Items.AddRange(New Object() {"NORMAL", "OBRAL", "SP"})
        Me.tujuan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tujuan.Size = New System.Drawing.Size(88, 21)
        Me.tujuan.TabIndex = 50
        '
        'cmd_load_all_artikel
        '
        Me.cmd_load_all_artikel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_load_all_artikel.Location = New System.Drawing.Point(218, 340)
        Me.cmd_load_all_artikel.Name = "cmd_load_all_artikel"
        Me.cmd_load_all_artikel.Size = New System.Drawing.Size(115, 24)
        Me.cmd_load_all_artikel.TabIndex = 51
        Me.cmd_load_all_artikel.Text = "Ambil Semua Artikel"
        '
        'frm_retur_formalitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 376)
        Me.Controls.Add(Me.cmd_load_all_artikel)
        Me.Controls.Add(Me.tujuan)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.sumber)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_hapus_baris)
        Me.Controls.Add(Me.cmd_cari_artikel)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.no_retur)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.kode_customer_parent)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tgl_retur)
        Me.Name = "frm_retur_formalitas"
        Me.Text = "Retur Formalitas"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_retur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_retur.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_retur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus_baris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cari_artikel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents no_retur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_retur As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sumber As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tujuan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmd_load_all_artikel As DevExpress.XtraEditors.SimpleButton
End Class
