<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user_list))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmd_hapus_user = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit_user = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah_user = New DevExpress.XtraEditors.SimpleButton
        Me.grid_user = New DevExpress.XtraGrid.GridControl
        Me.GridV_user = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus_level = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit_level = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah_level = New DevExpress.XtraEditors.SimpleButton
        Me.grid_level = New DevExpress.XtraGrid.GridControl
        Me.GridV_level = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grid_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grid_level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.cmd_hapus_user)
        Me.GroupControl1.Controls.Add(Me.cmd_edit_user)
        Me.GroupControl1.Controls.Add(Me.cmd_tambah_user)
        Me.GroupControl1.Controls.Add(Me.grid_user)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(680, 213)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "LIST USER"
        '
        'cmd_hapus_user
        '
        Me.cmd_hapus_user.Image = CType(resources.GetObject("cmd_hapus_user.Image"), System.Drawing.Image)
        Me.cmd_hapus_user.Location = New System.Drawing.Point(273, 34)
        Me.cmd_hapus_user.Name = "cmd_hapus_user"
        Me.cmd_hapus_user.Size = New System.Drawing.Size(128, 26)
        Me.cmd_hapus_user.TabIndex = 4
        Me.cmd_hapus_user.Text = "Hapus User"
        '
        'cmd_edit_user
        '
        Me.cmd_edit_user.Image = CType(resources.GetObject("cmd_edit_user.Image"), System.Drawing.Image)
        Me.cmd_edit_user.Location = New System.Drawing.Point(139, 34)
        Me.cmd_edit_user.Name = "cmd_edit_user"
        Me.cmd_edit_user.Size = New System.Drawing.Size(128, 26)
        Me.cmd_edit_user.TabIndex = 3
        Me.cmd_edit_user.Text = "Edit User"
        '
        'cmd_tambah_user
        '
        Me.cmd_tambah_user.Image = CType(resources.GetObject("cmd_tambah_user.Image"), System.Drawing.Image)
        Me.cmd_tambah_user.Location = New System.Drawing.Point(5, 34)
        Me.cmd_tambah_user.Name = "cmd_tambah_user"
        Me.cmd_tambah_user.Size = New System.Drawing.Size(128, 26)
        Me.cmd_tambah_user.TabIndex = 2
        Me.cmd_tambah_user.Text = "Tambah User"
        '
        'grid_user
        '
        Me.grid_user.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_user.Location = New System.Drawing.Point(5, 66)
        Me.grid_user.MainView = Me.GridV_user
        Me.grid_user.Name = "grid_user"
        Me.grid_user.Size = New System.Drawing.Size(670, 142)
        Me.grid_user.TabIndex = 1
        Me.grid_user.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_user})
        '
        'GridV_user
        '
        Me.GridV_user.GridControl = Me.grid_user
        Me.GridV_user.Name = "GridV_user"
        Me.GridV_user.OptionsBehavior.Editable = False
        Me.GridV_user.OptionsCustomization.AllowColumnMoving = False
        Me.GridV_user.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridV_user.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.cmd_hapus_level)
        Me.GroupControl2.Controls.Add(Me.cmd_edit_level)
        Me.GroupControl2.Controls.Add(Me.cmd_tambah_level)
        Me.GroupControl2.Controls.Add(Me.grid_level)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 231)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(680, 242)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "LEVEL AKSES"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(414, 38)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(77, 21)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "get Row"
        Me.SimpleButton1.Visible = False
        '
        'cmd_hapus_level
        '
        Me.cmd_hapus_level.Image = CType(resources.GetObject("cmd_hapus_level.Image"), System.Drawing.Image)
        Me.cmd_hapus_level.Location = New System.Drawing.Point(273, 34)
        Me.cmd_hapus_level.Name = "cmd_hapus_level"
        Me.cmd_hapus_level.Size = New System.Drawing.Size(128, 26)
        Me.cmd_hapus_level.TabIndex = 4
        Me.cmd_hapus_level.Text = "Hapus Level"
        '
        'cmd_edit_level
        '
        Me.cmd_edit_level.Image = CType(resources.GetObject("cmd_edit_level.Image"), System.Drawing.Image)
        Me.cmd_edit_level.Location = New System.Drawing.Point(139, 34)
        Me.cmd_edit_level.Name = "cmd_edit_level"
        Me.cmd_edit_level.Size = New System.Drawing.Size(128, 26)
        Me.cmd_edit_level.TabIndex = 3
        Me.cmd_edit_level.Text = "Edit Level"
        '
        'cmd_tambah_level
        '
        Me.cmd_tambah_level.Image = CType(resources.GetObject("cmd_tambah_level.Image"), System.Drawing.Image)
        Me.cmd_tambah_level.Location = New System.Drawing.Point(5, 34)
        Me.cmd_tambah_level.Name = "cmd_tambah_level"
        Me.cmd_tambah_level.Size = New System.Drawing.Size(128, 26)
        Me.cmd_tambah_level.TabIndex = 2
        Me.cmd_tambah_level.Text = "Tambah Level"
        '
        'grid_level
        '
        Me.grid_level.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_level.Location = New System.Drawing.Point(5, 66)
        Me.grid_level.MainView = Me.GridV_level
        Me.grid_level.Name = "grid_level"
        Me.grid_level.Size = New System.Drawing.Size(670, 171)
        Me.grid_level.TabIndex = 1
        Me.grid_level.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_level})
        '
        'GridV_level
        '
        Me.GridV_level.GridControl = Me.grid_level
        Me.GridV_level.Name = "GridV_level"
        Me.GridV_level.OptionsBehavior.Editable = False
        Me.GridV_level.OptionsCustomization.AllowColumnMoving = False
        Me.GridV_level.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridV_level.OptionsView.ShowGroupPanel = False
        '
        'frm_user_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 479)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_user_list"
        Me.Text = "User & Level Akses"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grid_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grid_level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid_user As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_user As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_hapus_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmd_hapus_level As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit_level As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah_level As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_level As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_level As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
