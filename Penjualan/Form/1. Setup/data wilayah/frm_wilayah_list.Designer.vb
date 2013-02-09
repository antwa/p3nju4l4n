<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_wilayah_list
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.gridcontrol_provinsi = New DevExpress.XtraGrid.GridControl
        Me.gridview_provinsi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmd_prov_refresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_prov_delete = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_prov_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_prov_add = New DevExpress.XtraEditors.SimpleButton
        Me.gridcontrol_group = New DevExpress.XtraGrid.GridControl
        Me.gridview_group = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.cmd_group_refresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_group_delete = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_group_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_group_add = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.gridcontrol_kota = New DevExpress.XtraGrid.GridControl
        Me.gridview_kota = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmd_kota_refresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_kota_delete = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_kota_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_kota_add = New DevExpress.XtraEditors.SimpleButton
        Me.gridcontrol_zona = New DevExpress.XtraGrid.GridControl
        Me.gridview_zona = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.cmd_zona_refresh = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_zona_hapus = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_zona_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_zona_add = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.gridcontrol_provinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_provinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridcontrol_group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.gridcontrol_kota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_kota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gridcontrol_zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(724, 453)
        Me.SplitContainer1.SplitterDistance = 353
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridcontrol_provinsi)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gridcontrol_group)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainer2.Size = New System.Drawing.Size(353, 453)
        Me.SplitContainer2.SplitterDistance = 233
        Me.SplitContainer2.TabIndex = 0
        '
        'gridcontrol_provinsi
        '
        Me.gridcontrol_provinsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridcontrol_provinsi.Location = New System.Drawing.Point(0, 50)
        Me.gridcontrol_provinsi.MainView = Me.gridview_provinsi
        Me.gridcontrol_provinsi.Name = "gridcontrol_provinsi"
        Me.gridcontrol_provinsi.Size = New System.Drawing.Size(353, 183)
        Me.gridcontrol_provinsi.TabIndex = 31
        Me.gridcontrol_provinsi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_provinsi})
        '
        'gridview_provinsi
        '
        Me.gridview_provinsi.GridControl = Me.gridcontrol_provinsi
        Me.gridview_provinsi.Name = "gridview_provinsi"
        Me.gridview_provinsi.OptionsBehavior.Editable = False
        Me.gridview_provinsi.OptionsCustomization.AllowColumnMoving = False
        Me.gridview_provinsi.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gridview_provinsi.OptionsView.ShowGroupPanel = False
        Me.gridview_provinsi.OptionsView.ShowIndicator = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmd_prov_refresh)
        Me.GroupControl1.Controls.Add(Me.cmd_prov_delete)
        Me.GroupControl1.Controls.Add(Me.cmd_prov_edit)
        Me.GroupControl1.Controls.Add(Me.cmd_prov_add)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(353, 50)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Wilayah / Provinsi"
        '
        'cmd_prov_refresh
        '
        Me.cmd_prov_refresh.Location = New System.Drawing.Point(261, 25)
        Me.cmd_prov_refresh.Name = "cmd_prov_refresh"
        Me.cmd_prov_refresh.Size = New System.Drawing.Size(77, 22)
        Me.cmd_prov_refresh.TabIndex = 3
        Me.cmd_prov_refresh.Text = "Refresh"
        '
        'cmd_prov_delete
        '
        Me.cmd_prov_delete.Location = New System.Drawing.Point(178, 25)
        Me.cmd_prov_delete.Name = "cmd_prov_delete"
        Me.cmd_prov_delete.Size = New System.Drawing.Size(77, 22)
        Me.cmd_prov_delete.TabIndex = 2
        Me.cmd_prov_delete.Text = "Hapus"
        '
        'cmd_prov_edit
        '
        Me.cmd_prov_edit.Location = New System.Drawing.Point(95, 25)
        Me.cmd_prov_edit.Name = "cmd_prov_edit"
        Me.cmd_prov_edit.Size = New System.Drawing.Size(77, 22)
        Me.cmd_prov_edit.TabIndex = 1
        Me.cmd_prov_edit.Text = "Edit"
        '
        'cmd_prov_add
        '
        Me.cmd_prov_add.Location = New System.Drawing.Point(12, 25)
        Me.cmd_prov_add.Name = "cmd_prov_add"
        Me.cmd_prov_add.Size = New System.Drawing.Size(77, 22)
        Me.cmd_prov_add.TabIndex = 0
        Me.cmd_prov_add.Text = "Tambah"
        '
        'gridcontrol_group
        '
        Me.gridcontrol_group.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridcontrol_group.Location = New System.Drawing.Point(0, 50)
        Me.gridcontrol_group.MainView = Me.gridview_group
        Me.gridcontrol_group.Name = "gridcontrol_group"
        Me.gridcontrol_group.Size = New System.Drawing.Size(353, 166)
        Me.gridcontrol_group.TabIndex = 33
        Me.gridcontrol_group.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_group})
        '
        'gridview_group
        '
        Me.gridview_group.GridControl = Me.gridcontrol_group
        Me.gridview_group.Name = "gridview_group"
        Me.gridview_group.OptionsBehavior.Editable = False
        Me.gridview_group.OptionsCustomization.AllowColumnMoving = False
        Me.gridview_group.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gridview_group.OptionsView.ShowGroupPanel = False
        Me.gridview_group.OptionsView.ShowIndicator = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cmd_group_refresh)
        Me.GroupControl3.Controls.Add(Me.cmd_group_delete)
        Me.GroupControl3.Controls.Add(Me.cmd_group_edit)
        Me.GroupControl3.Controls.Add(Me.cmd_group_add)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(353, 50)
        Me.GroupControl3.TabIndex = 32
        Me.GroupControl3.Text = "Group"
        '
        'cmd_group_refresh
        '
        Me.cmd_group_refresh.Location = New System.Drawing.Point(261, 25)
        Me.cmd_group_refresh.Name = "cmd_group_refresh"
        Me.cmd_group_refresh.Size = New System.Drawing.Size(77, 22)
        Me.cmd_group_refresh.TabIndex = 3
        Me.cmd_group_refresh.Text = "Refresh"
        '
        'cmd_group_delete
        '
        Me.cmd_group_delete.Location = New System.Drawing.Point(178, 25)
        Me.cmd_group_delete.Name = "cmd_group_delete"
        Me.cmd_group_delete.Size = New System.Drawing.Size(77, 22)
        Me.cmd_group_delete.TabIndex = 2
        Me.cmd_group_delete.Text = "Hapus"
        '
        'cmd_group_edit
        '
        Me.cmd_group_edit.Location = New System.Drawing.Point(95, 25)
        Me.cmd_group_edit.Name = "cmd_group_edit"
        Me.cmd_group_edit.Size = New System.Drawing.Size(77, 22)
        Me.cmd_group_edit.TabIndex = 1
        Me.cmd_group_edit.Text = "Edit"
        '
        'cmd_group_add
        '
        Me.cmd_group_add.Location = New System.Drawing.Point(12, 25)
        Me.cmd_group_add.Name = "cmd_group_add"
        Me.cmd_group_add.Size = New System.Drawing.Size(77, 22)
        Me.cmd_group_add.TabIndex = 0
        Me.cmd_group_add.Text = "Tambah"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.gridcontrol_kota)
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupControl2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.gridcontrol_zona)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupControl4)
        Me.SplitContainer3.Size = New System.Drawing.Size(367, 453)
        Me.SplitContainer3.SplitterDistance = 233
        Me.SplitContainer3.TabIndex = 0
        '
        'gridcontrol_kota
        '
        Me.gridcontrol_kota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridcontrol_kota.Location = New System.Drawing.Point(0, 50)
        Me.gridcontrol_kota.MainView = Me.gridview_kota
        Me.gridcontrol_kota.Name = "gridcontrol_kota"
        Me.gridcontrol_kota.Size = New System.Drawing.Size(367, 183)
        Me.gridcontrol_kota.TabIndex = 33
        Me.gridcontrol_kota.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_kota})
        '
        'gridview_kota
        '
        Me.gridview_kota.GridControl = Me.gridcontrol_kota
        Me.gridview_kota.Name = "gridview_kota"
        Me.gridview_kota.OptionsBehavior.Editable = False
        Me.gridview_kota.OptionsCustomization.AllowColumnMoving = False
        Me.gridview_kota.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gridview_kota.OptionsView.ShowGroupPanel = False
        Me.gridview_kota.OptionsView.ShowIndicator = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmd_kota_refresh)
        Me.GroupControl2.Controls.Add(Me.cmd_kota_delete)
        Me.GroupControl2.Controls.Add(Me.cmd_kota_edit)
        Me.GroupControl2.Controls.Add(Me.cmd_kota_add)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(367, 50)
        Me.GroupControl2.TabIndex = 32
        Me.GroupControl2.Text = "Kota"
        '
        'cmd_kota_refresh
        '
        Me.cmd_kota_refresh.Location = New System.Drawing.Point(261, 25)
        Me.cmd_kota_refresh.Name = "cmd_kota_refresh"
        Me.cmd_kota_refresh.Size = New System.Drawing.Size(77, 22)
        Me.cmd_kota_refresh.TabIndex = 3
        Me.cmd_kota_refresh.Text = "Refresh"
        '
        'cmd_kota_delete
        '
        Me.cmd_kota_delete.Location = New System.Drawing.Point(178, 25)
        Me.cmd_kota_delete.Name = "cmd_kota_delete"
        Me.cmd_kota_delete.Size = New System.Drawing.Size(77, 22)
        Me.cmd_kota_delete.TabIndex = 2
        Me.cmd_kota_delete.Text = "Hapus"
        '
        'cmd_kota_edit
        '
        Me.cmd_kota_edit.Location = New System.Drawing.Point(95, 25)
        Me.cmd_kota_edit.Name = "cmd_kota_edit"
        Me.cmd_kota_edit.Size = New System.Drawing.Size(77, 22)
        Me.cmd_kota_edit.TabIndex = 1
        Me.cmd_kota_edit.Text = "Edit"
        '
        'cmd_kota_add
        '
        Me.cmd_kota_add.Location = New System.Drawing.Point(12, 25)
        Me.cmd_kota_add.Name = "cmd_kota_add"
        Me.cmd_kota_add.Size = New System.Drawing.Size(77, 22)
        Me.cmd_kota_add.TabIndex = 0
        Me.cmd_kota_add.Text = "Tambah"
        '
        'gridcontrol_zona
        '
        Me.gridcontrol_zona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridcontrol_zona.Location = New System.Drawing.Point(0, 50)
        Me.gridcontrol_zona.MainView = Me.gridview_zona
        Me.gridcontrol_zona.Name = "gridcontrol_zona"
        Me.gridcontrol_zona.Size = New System.Drawing.Size(367, 166)
        Me.gridcontrol_zona.TabIndex = 33
        Me.gridcontrol_zona.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_zona})
        '
        'gridview_zona
        '
        Me.gridview_zona.GridControl = Me.gridcontrol_zona
        Me.gridview_zona.Name = "gridview_zona"
        Me.gridview_zona.OptionsBehavior.Editable = False
        Me.gridview_zona.OptionsCustomization.AllowColumnMoving = False
        Me.gridview_zona.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gridview_zona.OptionsView.ShowGroupPanel = False
        Me.gridview_zona.OptionsView.ShowIndicator = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cmd_zona_refresh)
        Me.GroupControl4.Controls.Add(Me.cmd_zona_hapus)
        Me.GroupControl4.Controls.Add(Me.cmd_zona_edit)
        Me.GroupControl4.Controls.Add(Me.cmd_zona_add)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(367, 50)
        Me.GroupControl4.TabIndex = 32
        Me.GroupControl4.Text = "Zona"
        '
        'cmd_zona_refresh
        '
        Me.cmd_zona_refresh.Location = New System.Drawing.Point(261, 25)
        Me.cmd_zona_refresh.Name = "cmd_zona_refresh"
        Me.cmd_zona_refresh.Size = New System.Drawing.Size(77, 22)
        Me.cmd_zona_refresh.TabIndex = 3
        Me.cmd_zona_refresh.Text = "Refresh"
        '
        'cmd_zona_hapus
        '
        Me.cmd_zona_hapus.Location = New System.Drawing.Point(178, 25)
        Me.cmd_zona_hapus.Name = "cmd_zona_hapus"
        Me.cmd_zona_hapus.Size = New System.Drawing.Size(77, 22)
        Me.cmd_zona_hapus.TabIndex = 2
        Me.cmd_zona_hapus.Text = "Hapus"
        '
        'cmd_zona_edit
        '
        Me.cmd_zona_edit.Location = New System.Drawing.Point(95, 25)
        Me.cmd_zona_edit.Name = "cmd_zona_edit"
        Me.cmd_zona_edit.Size = New System.Drawing.Size(77, 22)
        Me.cmd_zona_edit.TabIndex = 1
        Me.cmd_zona_edit.Text = "Edit"
        '
        'cmd_zona_add
        '
        Me.cmd_zona_add.Location = New System.Drawing.Point(12, 25)
        Me.cmd_zona_add.Name = "cmd_zona_add"
        Me.cmd_zona_add.Size = New System.Drawing.Size(77, 22)
        Me.cmd_zona_add.TabIndex = 0
        Me.cmd_zona_add.Text = "Tambah"
        '
        'frm_wilayah_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 453)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_wilayah_list"
        Me.Text = "Wilayah"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.gridcontrol_provinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_provinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gridcontrol_group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.gridcontrol_kota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_kota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gridcontrol_zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmd_prov_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_prov_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_prov_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcontrol_provinsi As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_provinsi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_prov_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcontrol_group As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_group As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmd_group_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_group_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_group_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_group_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcontrol_kota As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_kota As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmd_kota_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_kota_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_kota_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_kota_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridcontrol_zona As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_zona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmd_zona_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_zona_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_zona_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_zona_add As DevExpress.XtraEditors.SimpleButton
End Class
