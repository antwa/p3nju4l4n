<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_supplier_barang_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_supplier_barang_list))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus_user = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit_user = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah_user = New DevExpress.XtraEditors.SimpleButton
        Me.gridcontrol1 = New DevExpress.XtraGrid.GridControl
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.gridcontrol1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(356, 312)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 26)
        Me.SimpleButton1.TabIndex = 32
        Me.SimpleButton1.Text = "Refresh"
        '
        'cmd_hapus_user
        '
        Me.cmd_hapus_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus_user.Image = CType(resources.GetObject("cmd_hapus_user.Image"), System.Drawing.Image)
        Me.cmd_hapus_user.Location = New System.Drawing.Point(677, 312)
        Me.cmd_hapus_user.Name = "cmd_hapus_user"
        Me.cmd_hapus_user.Size = New System.Drawing.Size(101, 26)
        Me.cmd_hapus_user.TabIndex = 31
        Me.cmd_hapus_user.Text = "Hapus"
        '
        'cmd_edit_user
        '
        Me.cmd_edit_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit_user.Image = CType(resources.GetObject("cmd_edit_user.Image"), System.Drawing.Image)
        Me.cmd_edit_user.Location = New System.Drawing.Point(570, 312)
        Me.cmd_edit_user.Name = "cmd_edit_user"
        Me.cmd_edit_user.Size = New System.Drawing.Size(101, 26)
        Me.cmd_edit_user.TabIndex = 30
        Me.cmd_edit_user.Text = "Edit"
        '
        'cmd_tambah_user
        '
        Me.cmd_tambah_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah_user.Image = CType(resources.GetObject("cmd_tambah_user.Image"), System.Drawing.Image)
        Me.cmd_tambah_user.Location = New System.Drawing.Point(463, 312)
        Me.cmd_tambah_user.Name = "cmd_tambah_user"
        Me.cmd_tambah_user.Size = New System.Drawing.Size(101, 26)
        Me.cmd_tambah_user.TabIndex = 29
        Me.cmd_tambah_user.Text = "Tambah"
        '
        'gridcontrol1
        '
        Me.gridcontrol1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridcontrol1.Location = New System.Drawing.Point(16, 23)
        Me.gridcontrol1.MainView = Me.gridview1
        Me.gridcontrol1.Name = "gridcontrol1"
        Me.gridcontrol1.Size = New System.Drawing.Size(762, 283)
        Me.gridcontrol1.TabIndex = 28
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
        'frm_supplier_barang_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 360)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmd_hapus_user)
        Me.Controls.Add(Me.cmd_edit_user)
        Me.Controls.Add(Me.cmd_tambah_user)
        Me.Controls.Add(Me.gridcontrol1)
        Me.Name = "frm_supplier_barang_list"
        Me.Text = "List Data Supplier Barang"
        CType(Me.gridcontrol1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcontrol1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
