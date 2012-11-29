<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_jenisharga_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_jenisharga_list))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.grid_list = New DevExpress.XtraGrid.GridControl
        Me.GridV_list = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txt_cari = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "Kode"
        '
        'grid_list
        '
        Me.grid_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_list.Location = New System.Drawing.Point(15, 48)
        Me.grid_list.MainView = Me.GridV_list
        Me.grid_list.Name = "grid_list"
        Me.grid_list.Size = New System.Drawing.Size(590, 278)
        Me.grid_list.TabIndex = 30
        Me.grid_list.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_list})
        '
        'GridV_list
        '
        Me.GridV_list.GridControl = Me.grid_list
        Me.GridV_list.Name = "GridV_list"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(56, 15)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(150, 20)
        Me.txt_cari.TabIndex = 29
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(222, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Text = "Cari"
        '
        'cmd_hapus
        '
        Me.cmd_hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus.Image = CType(resources.GetObject("cmd_hapus.Image"), System.Drawing.Image)
        Me.cmd_hapus.Location = New System.Drawing.Point(478, 340)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(128, 26)
        Me.cmd_hapus.TabIndex = 27
        Me.cmd_hapus.Text = "Hapus Jenis Harga"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Image = CType(resources.GetObject("cmd_edit.Image"), System.Drawing.Image)
        Me.cmd_edit.Location = New System.Drawing.Point(344, 340)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(128, 26)
        Me.cmd_edit.TabIndex = 26
        Me.cmd_edit.Text = "Edit Jenis Harga"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Image = CType(resources.GetObject("cmd_tambah.Image"), System.Drawing.Image)
        Me.cmd_tambah.Location = New System.Drawing.Point(210, 340)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(128, 26)
        Me.cmd_tambah.TabIndex = 25
        Me.cmd_tambah.Text = "Tambah Jenis Harga"
        '
        'frm_jenisharga_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 378)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_list)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmd_hapus)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Name = "frm_jenisharga_list"
        Me.Text = "frm_jenisharga_list"
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_list As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_list As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
End Class
