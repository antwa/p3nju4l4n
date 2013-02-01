<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kategoribarang_list
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
        Me.cmd_hapus = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txt_cari = New DevExpress.XtraEditors.TextEdit
        Me.grid_list = New DevExpress.XtraGrid.GridControl
        Me.GridV_list = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txt_cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_hapus
        '
        Me.cmd_hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus.Location = New System.Drawing.Point(500, 301)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(128, 26)
        Me.cmd_hapus.TabIndex = 20
        Me.cmd_hapus.Text = "Hapus Kategori"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Location = New System.Drawing.Point(366, 301)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(128, 26)
        Me.cmd_edit.TabIndex = 19
        Me.cmd_edit.Text = "Edit Kategori"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Location = New System.Drawing.Point(232, 301)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(128, 26)
        Me.cmd_tambah.TabIndex = 18
        Me.cmd_tambah.Text = "Tambah Kategori"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(230, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 21
        Me.SimpleButton1.Text = "Cari"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(70, 12)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(150, 20)
        Me.txt_cari.TabIndex = 22
        '
        'grid_list
        '
        Me.grid_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_list.Location = New System.Drawing.Point(12, 44)
        Me.grid_list.MainView = Me.GridV_list
        Me.grid_list.Name = "grid_list"
        Me.grid_list.Size = New System.Drawing.Size(616, 251)
        Me.grid_list.TabIndex = 23
        Me.grid_list.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_list})
        '
        'GridV_list
        '
        Me.GridV_list.GridControl = Me.grid_list
        Me.GridV_list.Name = "GridV_list"
        Me.GridV_list.OptionsBehavior.Editable = False
        Me.GridV_list.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 24
        Me.LabelControl1.Text = "Kategori"
        '
        'frm_kategoribarang_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 336)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_list)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmd_hapus)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Name = "frm_kategoribarang_list"
        Me.Text = "Kategori Barang"
        CType(Me.txt_cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_list As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_list As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
