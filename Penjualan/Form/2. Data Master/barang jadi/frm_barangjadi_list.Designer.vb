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
        Me.cmd_export = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridControl1.Size = New System.Drawing.Size(694, 262)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'cmd_refresh
        '
        Me.cmd_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_refresh.Image = CType(resources.GetObject("cmd_refresh.Image"), System.Drawing.Image)
        Me.cmd_refresh.Location = New System.Drawing.Point(308, 303)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(95, 26)
        Me.cmd_refresh.TabIndex = 20
        Me.cmd_refresh.Text = "Refresh"
        '
        'cmd_hapus
        '
        Me.cmd_hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus.Image = CType(resources.GetObject("cmd_hapus.Image"), System.Drawing.Image)
        Me.cmd_hapus.Location = New System.Drawing.Point(611, 303)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(95, 26)
        Me.cmd_hapus.TabIndex = 19
        Me.cmd_hapus.Text = "Hapus"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Image = CType(resources.GetObject("cmd_edit.Image"), System.Drawing.Image)
        Me.cmd_edit.Location = New System.Drawing.Point(510, 303)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(95, 26)
        Me.cmd_edit.TabIndex = 18
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Image = CType(resources.GetObject("cmd_tambah.Image"), System.Drawing.Image)
        Me.cmd_tambah.Location = New System.Drawing.Point(409, 303)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(95, 26)
        Me.cmd_tambah.TabIndex = 17
        Me.cmd_tambah.Text = "Tambah"
        '
        'cmd_export
        '
        Me.cmd_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_export.Location = New System.Drawing.Point(12, 303)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(102, 26)
        Me.cmd_export.TabIndex = 65
        Me.cmd_export.Text = "Export To Exel"
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(120, 303)
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
        Me.LabelControl1.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl1.TabIndex = 66
        Me.LabelControl1.Text = "Kode Barang"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(87, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(154, 20)
        Me.TextEdit1.TabIndex = 67
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(247, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 21)
        Me.SimpleButton1.TabIndex = 68
        Me.SimpleButton1.Text = "Cari"
        '
        'frm_barangjadi_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 341)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmd_export)
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
