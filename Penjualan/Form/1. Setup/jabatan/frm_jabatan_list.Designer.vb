<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_jabatan_list
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
        Me.grid_list = New DevExpress.XtraGrid.GridControl
        Me.GridV_list = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_hapus = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_list
        '
        Me.grid_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_list.Location = New System.Drawing.Point(11, 12)
        Me.grid_list.MainView = Me.GridV_list
        Me.grid_list.Name = "grid_list"
        Me.grid_list.Size = New System.Drawing.Size(693, 300)
        Me.grid_list.TabIndex = 30
        Me.grid_list.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_list})
        '
        'GridV_list
        '
        Me.GridV_list.GridControl = Me.grid_list
        Me.GridV_list.Name = "GridV_list"
        Me.GridV_list.OptionsBehavior.Editable = False
        Me.GridV_list.OptionsView.ColumnAutoWidth = False
        Me.GridV_list.OptionsView.ShowGroupPanel = False
        '
        'cmd_hapus
        '
        Me.cmd_hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus.Location = New System.Drawing.Point(576, 318)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(128, 26)
        Me.cmd_hapus.TabIndex = 27
        Me.cmd_hapus.Text = "Hapus"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Location = New System.Drawing.Point(442, 318)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(128, 26)
        Me.cmd_edit.TabIndex = 26
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Location = New System.Drawing.Point(308, 318)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(128, 26)
        Me.cmd_tambah.TabIndex = 25
        Me.cmd_tambah.Text = "Tambah"
        '
        'frm_jabatan_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 356)
        Me.Controls.Add(Me.grid_list)
        Me.Controls.Add(Me.cmd_hapus)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Name = "frm_jabatan_list"
        Me.Text = "Jabatan"
        CType(Me.grid_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_list As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_list As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
End Class
