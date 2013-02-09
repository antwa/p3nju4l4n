<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userlevel_add
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
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kd_level = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nama_level = New DevExpress.XtraEditors.TextEdit
        Me.grid_level = New DevExpress.XtraGrid.GridControl
        Me.GridV_level = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txt_kd_level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nama_level.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(13, 15)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl18.TabIndex = 11
        Me.LabelControl18.Text = "Kode Level"
        '
        'txt_kd_level
        '
        Me.txt_kd_level.EditValue = ""
        Me.txt_kd_level.Location = New System.Drawing.Point(91, 12)
        Me.txt_kd_level.Name = "txt_kd_level"
        Me.txt_kd_level.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kd_level.Properties.Appearance.Options.UseFont = True
        Me.txt_kd_level.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_kd_level.Size = New System.Drawing.Size(83, 21)
        Me.txt_kd_level.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 14)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Nama Level"
        '
        'txt_nama_level
        '
        Me.txt_nama_level.EditValue = ""
        Me.txt_nama_level.Location = New System.Drawing.Point(91, 39)
        Me.txt_nama_level.Name = "txt_nama_level"
        Me.txt_nama_level.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_level.Properties.Appearance.Options.UseFont = True
        Me.txt_nama_level.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nama_level.Size = New System.Drawing.Size(212, 21)
        Me.txt_nama_level.TabIndex = 12
        '
        'grid_level
        '
        Me.grid_level.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_level.Location = New System.Drawing.Point(12, 66)
        Me.grid_level.MainView = Me.GridV_level
        Me.grid_level.Name = "grid_level"
        Me.grid_level.Size = New System.Drawing.Size(610, 224)
        Me.grid_level.TabIndex = 14
        Me.grid_level.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_level})
        '
        'GridV_level
        '
        Me.GridV_level.GridControl = Me.grid_level
        Me.GridV_level.Name = "GridV_level"
        Me.GridV_level.OptionsCustomization.AllowColumnMoving = False
        Me.GridV_level.OptionsCustomization.AllowFilter = False
        Me.GridV_level.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridV_level.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridV_level.OptionsView.ColumnAutoWidth = False
        Me.GridV_level.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridV_level.OptionsView.ShowGroupPanel = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(416, 296)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(100, 25)
        Me.cmd_simpan.TabIndex = 21
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_batal
        '
        Me.cmd_batal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_batal.Location = New System.Drawing.Point(522, 296)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(100, 25)
        Me.cmd_batal.TabIndex = 20
        Me.cmd_batal.Text = "Batal"
        '
        'frm_userlevel_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 333)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.grid_level)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_nama_level)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txt_kd_level)
        Me.Name = "frm_userlevel_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah User Level"
        CType(Me.txt_kd_level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nama_level.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kd_level As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nama_level As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_level As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_level As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
End Class
