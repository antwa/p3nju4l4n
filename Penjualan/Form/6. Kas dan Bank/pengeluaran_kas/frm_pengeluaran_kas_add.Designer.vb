<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pengeluaran_kas_add
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.no_transaksi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.no_akun_kas = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.kas_tersedia = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_pengeluaran_kas = New DevExpress.XtraEditors.DateEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.no_transaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_akun_kas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_pengeluaran_kas.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_pengeluaran_kas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'no_transaksi
        '
        Me.no_transaksi.EditValue = ""
        Me.no_transaksi.Enabled = False
        Me.no_transaksi.Location = New System.Drawing.Point(141, 13)
        Me.no_transaksi.Name = "no_transaksi"
        Me.no_transaksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_transaksi.Properties.Appearance.Options.UseFont = True
        Me.no_transaksi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.no_transaksi.Size = New System.Drawing.Size(306, 21)
        Me.no_transaksi.TabIndex = 29
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "No. Transaksi"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(13, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 14)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "No. Akun Kas"
        '
        'no_akun_kas
        '
        Me.no_akun_kas.Location = New System.Drawing.Point(141, 45)
        Me.no_akun_kas.Name = "no_akun_kas"
        Me.no_akun_kas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_akun_kas.Properties.Appearance.Options.UseFont = True
        Me.no_akun_kas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.no_akun_kas.Size = New System.Drawing.Size(306, 21)
        Me.no_akun_kas.TabIndex = 34
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(14, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Kas Tersedia"
        '
        'kas_tersedia
        '
        Me.kas_tersedia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kas_tersedia.Location = New System.Drawing.Point(141, 81)
        Me.kas_tersedia.Name = "kas_tersedia"
        Me.kas_tersedia.Size = New System.Drawing.Size(119, 14)
        Me.kas_tersedia.TabIndex = 36
        Me.kas_tersedia.Text = "Nilai Kas yang tersedia"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(14, 111)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl5.TabIndex = 37
        Me.LabelControl5.Text = "Tanggal"
        '
        'tgl_pengeluaran_kas
        '
        Me.tgl_pengeluaran_kas.EditValue = Nothing
        Me.tgl_pengeluaran_kas.Location = New System.Drawing.Point(141, 108)
        Me.tgl_pengeluaran_kas.Name = "tgl_pengeluaran_kas"
        Me.tgl_pengeluaran_kas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_pengeluaran_kas.Properties.Appearance.Options.UseFont = True
        Me.tgl_pengeluaran_kas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_pengeluaran_kas.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_pengeluaran_kas.Size = New System.Drawing.Size(231, 21)
        Me.tgl_pengeluaran_kas.TabIndex = 38
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_simpan.Appearance.Options.UseFont = True
        Me.cmd_simpan.Location = New System.Drawing.Point(13, 372)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(125, 26)
        Me.cmd_simpan.TabIndex = 54
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.Appearance.Options.UseFont = True
        Me.cmd_cancel.Location = New System.Drawing.Point(145, 372)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(113, 26)
        Me.cmd_cancel.TabIndex = 53
        Me.cmd_cancel.Text = "Batal"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(13, 149)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(696, 204)
        Me.GridControl1.TabIndex = 52
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
        'frm_pengeluaran_kas_add
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 427)
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
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_pengeluaran_kas_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengeluaran Kas Add"
        CType(Me.no_transaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_akun_kas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_pengeluaran_kas.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_pengeluaran_kas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents no_transaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents no_akun_kas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kas_tersedia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_pengeluaran_kas As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
