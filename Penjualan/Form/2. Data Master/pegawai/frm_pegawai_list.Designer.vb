<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pegawai_list
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus_user = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit_user = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah_user = New DevExpress.XtraEditors.SimpleButton
        Me.gridcontrol1 = New DevExpress.XtraGrid.GridControl
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.search = New DevExpress.XtraEditors.TextEdit
        Me.cmd_cari = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gridcontrol1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(299, 304)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 26)
        Me.SimpleButton1.TabIndex = 22
        Me.SimpleButton1.Text = "Refresh"
        '
        'cmd_hapus_user
        '
        Me.cmd_hapus_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus_user.Location = New System.Drawing.Point(620, 304)
        Me.cmd_hapus_user.Name = "cmd_hapus_user"
        Me.cmd_hapus_user.Size = New System.Drawing.Size(101, 26)
        Me.cmd_hapus_user.TabIndex = 21
        Me.cmd_hapus_user.Text = "Hapus"
        '
        'cmd_edit_user
        '
        Me.cmd_edit_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit_user.Location = New System.Drawing.Point(513, 304)
        Me.cmd_edit_user.Name = "cmd_edit_user"
        Me.cmd_edit_user.Size = New System.Drawing.Size(101, 26)
        Me.cmd_edit_user.TabIndex = 20
        Me.cmd_edit_user.Text = "Edit"
        '
        'cmd_tambah_user
        '
        Me.cmd_tambah_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah_user.Location = New System.Drawing.Point(406, 304)
        Me.cmd_tambah_user.Name = "cmd_tambah_user"
        Me.cmd_tambah_user.Size = New System.Drawing.Size(101, 26)
        Me.cmd_tambah_user.TabIndex = 19
        Me.cmd_tambah_user.Text = "Tambah"
        '
        'gridcontrol1
        '
        Me.gridcontrol1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridcontrol1.Location = New System.Drawing.Point(12, 44)
        Me.gridcontrol1.MainView = Me.gridview1
        Me.gridcontrol1.Name = "gridcontrol1"
        Me.gridcontrol1.Size = New System.Drawing.Size(707, 250)
        Me.gridcontrol1.TabIndex = 18
        Me.gridcontrol1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.gridcontrol1
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsCustomization.AllowColumnMoving = False
        Me.gridview1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridview1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "Nama"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(60, 18)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(145, 20)
        Me.search.TabIndex = 32
        '
        'cmd_cari
        '
        Me.cmd_cari.Location = New System.Drawing.Point(227, 12)
        Me.cmd_cari.Name = "cmd_cari"
        Me.cmd_cari.Size = New System.Drawing.Size(80, 26)
        Me.cmd_cari.TabIndex = 31
        Me.cmd_cari.Text = "Cari"
        '
        'frm_pegawai_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 342)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.cmd_cari)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmd_hapus_user)
        Me.Controls.Add(Me.cmd_edit_user)
        Me.Controls.Add(Me.cmd_tambah_user)
        Me.Controls.Add(Me.gridcontrol1)
        Me.Name = "frm_pegawai_list"
        Me.Text = "List Data  Pegawai"
        CType(Me.gridcontrol1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcontrol1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_cari As DevExpress.XtraEditors.SimpleButton
End Class
