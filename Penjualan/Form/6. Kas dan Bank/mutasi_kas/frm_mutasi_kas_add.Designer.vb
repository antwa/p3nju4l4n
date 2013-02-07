<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mutasi_kas_tambah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.tgl_pengeluaran_kas = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.kas_tersedia = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.no_akun_kas = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.no_transaksi = New DevExpress.XtraEditors.TextEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.tgl_pengeluaran_kas.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_pengeluaran_kas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_akun_kas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_transaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tgl_pengeluaran_kas
        '
        Me.tgl_pengeluaran_kas.EditValue = Nothing
        Me.tgl_pengeluaran_kas.Location = New System.Drawing.Point(160, 108)
        Me.tgl_pengeluaran_kas.Name = "tgl_pengeluaran_kas"
        Me.tgl_pengeluaran_kas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_pengeluaran_kas.Properties.Appearance.Options.UseFont = True
        Me.tgl_pengeluaran_kas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_pengeluaran_kas.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_pengeluaran_kas.Size = New System.Drawing.Size(269, 21)
        Me.tgl_pengeluaran_kas.TabIndex = 62
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(13, 111)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl5.TabIndex = 61
        Me.LabelControl5.Text = "Tanggal"
        '
        'kas_tersedia
        '
        Me.kas_tersedia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kas_tersedia.Location = New System.Drawing.Point(160, 88)
        Me.kas_tersedia.Name = "kas_tersedia"
        Me.kas_tersedia.Size = New System.Drawing.Size(119, 14)
        Me.kas_tersedia.TabIndex = 60
        Me.kas_tersedia.Text = "Nilai Kas yang tersedia"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(13, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl3.TabIndex = 59
        Me.LabelControl3.Text = "Kas Tersedia"
        '
        'no_akun_kas
        '
        Me.no_akun_kas.Location = New System.Drawing.Point(161, 52)
        Me.no_akun_kas.Name = "no_akun_kas"
        Me.no_akun_kas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_akun_kas.Properties.Appearance.Options.UseFont = True
        Me.no_akun_kas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.no_akun_kas.Size = New System.Drawing.Size(357, 21)
        Me.no_akun_kas.TabIndex = 58
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 14)
        Me.LabelControl2.TabIndex = 57
        Me.LabelControl2.Text = "No. Akun Kas"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl1.TabIndex = 56
        Me.LabelControl1.Text = "No. Transaksi"
        '
        'no_transaksi
        '
        Me.no_transaksi.EditValue = ""
        Me.no_transaksi.Enabled = False
        Me.no_transaksi.Location = New System.Drawing.Point(161, 17)
        Me.no_transaksi.Name = "no_transaksi"
        Me.no_transaksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_transaksi.Properties.Appearance.Options.UseFont = True
        Me.no_transaksi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.no_transaksi.Size = New System.Drawing.Size(357, 21)
        Me.no_transaksi.TabIndex = 55
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.Appearance.Options.UseFont = True
        Me.cmd_simpan.Location = New System.Drawing.Point(8, 449)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(146, 28)
        Me.cmd_simpan.TabIndex = 74
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.Appearance.Options.UseFont = True
        Me.cmd_cancel.Location = New System.Drawing.Point(160, 449)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(132, 28)
        Me.cmd_cancel.TabIndex = 73
        Me.cmd_cancel.Text = "Batal"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(8, 144)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(860, 289)
        Me.GridControl1.TabIndex = 72
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'frm_mutasi_kas_tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 480)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.tgl_pengeluaran_kas)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.kas_tersedia)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.no_akun_kas)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.no_transaksi)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Name = "frm_mutasi_kas_tambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_mutasi_kas_tambah"
        CType(Me.tgl_pengeluaran_kas.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_pengeluaran_kas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_akun_kas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_transaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tgl_pengeluaran_kas As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kas_tersedia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents no_akun_kas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents no_transaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
