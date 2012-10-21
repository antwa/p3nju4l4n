<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_barangjadi_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_barangjadi_list))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_refresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_formula = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.search = New DevExpress.XtraEditors.TextEdit
        Me.cmd_cari = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 35)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(692, 250)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'cmd_refresh
        '
        Me.cmd_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_refresh.Image = CType(resources.GetObject("cmd_refresh.Image"), System.Drawing.Image)
        Me.cmd_refresh.Location = New System.Drawing.Point(306, 291)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(95, 26)
        Me.cmd_refresh.TabIndex = 20
        Me.cmd_refresh.Text = "Refresh"
        '
        'cmd_hapus
        '
        Me.cmd_hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus.Image = CType(resources.GetObject("cmd_hapus.Image"), System.Drawing.Image)
        Me.cmd_hapus.Location = New System.Drawing.Point(609, 291)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(95, 26)
        Me.cmd_hapus.TabIndex = 19
        Me.cmd_hapus.Text = "Hapus"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Image = CType(resources.GetObject("cmd_edit.Image"), System.Drawing.Image)
        Me.cmd_edit.Location = New System.Drawing.Point(508, 291)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(95, 26)
        Me.cmd_edit.TabIndex = 18
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Image = CType(resources.GetObject("cmd_tambah.Image"), System.Drawing.Image)
        Me.cmd_tambah.Location = New System.Drawing.Point(407, 291)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(95, 26)
        Me.cmd_tambah.TabIndex = 17
        Me.cmd_tambah.Text = "Tambah"
        '
        'cmd_formula
        '
        Me.cmd_formula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_formula.Location = New System.Drawing.Point(12, 291)
        Me.cmd_formula.Name = "cmd_formula"
        Me.cmd_formula.Size = New System.Drawing.Size(123, 26)
        Me.cmd_formula.TabIndex = 65
        Me.cmd_formula.Text = "Formula Harga Jual"
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(141, 291)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(100, 26)
        Me.cmd_print.TabIndex = 64
        Me.cmd_print.Text = "Print"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl1.TabIndex = 66
        Me.LabelControl1.Text = "Kode"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(87, 9)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(154, 20)
        Me.search.TabIndex = 67
        '
        'cmd_cari
        '
        Me.cmd_cari.Location = New System.Drawing.Point(247, 8)
        Me.cmd_cari.Name = "cmd_cari"
        Me.cmd_cari.Size = New System.Drawing.Size(80, 21)
        Me.cmd_cari.TabIndex = 68
        Me.cmd_cari.Text = "Cari"
        '
        'frm_barangjadi_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 329)
        Me.Controls.Add(Me.cmd_cari)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmd_formula)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.cmd_refresh)
        Me.Controls.Add(Me.cmd_hapus)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_barangjadi_list"
        Me.Text = "List Barang Jadi"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_formula As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_cari As DevExpress.XtraEditors.SimpleButton
End Class
