<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pengeluaran_kas_list
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
        Me.cmd_cari = New DevExpress.XtraEditors.SimpleButton
        Me.search = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_refresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_cari
        '
        Me.cmd_cari.Location = New System.Drawing.Point(341, 8)
        Me.cmd_cari.Name = "cmd_cari"
        Me.cmd_cari.Size = New System.Drawing.Size(80, 21)
        Me.cmd_cari.TabIndex = 74
        Me.cmd_cari.Text = "Cari"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(172, 10)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(154, 19)
        Me.search.TabIndex = 73
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(123, 14)
        Me.LabelControl1.TabIndex = 72
        Me.LabelControl1.Text = "Jurnal ID / Keterangan"
        '
        'cmd_refresh
        '
        Me.cmd_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_refresh.Location = New System.Drawing.Point(656, 304)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(95, 26)
        Me.cmd_refresh.TabIndex = 80
        Me.cmd_refresh.Text = "Refresh"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Location = New System.Drawing.Point(541, 304)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(95, 26)
        Me.cmd_tambah.TabIndex = 79
        Me.cmd_tambah.Text = "Tambah"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 45)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(739, 250)
        Me.GridControl1.TabIndex = 78
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'frm_pengeluaran_kas_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 340)
        Me.Controls.Add(Me.cmd_refresh)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cmd_cari)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_pengeluaran_kas_list"
        Me.Text = "Penerimaan Kas"
        CType(Me.search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cari As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
