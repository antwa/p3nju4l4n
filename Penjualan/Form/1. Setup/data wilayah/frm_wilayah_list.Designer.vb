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
        Me.grid_list1 = New DevExpress.XtraGrid.GridControl
        Me.GridV_kota = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grid_list2 = New DevExpress.XtraGrid.GridControl
        Me.GridV_zona = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grid_list4 = New DevExpress.XtraGrid.GridControl
        Me.GridV_provinsi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grid_list3 = New DevExpress.XtraGrid.GridControl
        Me.GridV_group = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grid_list1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_kota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_list2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_list4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_provinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_list3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridV_group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_list1
        '
        Me.grid_list1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_list1.Location = New System.Drawing.Point(240, 57)
        Me.grid_list1.MainView = Me.GridV_kota
        Me.grid_list1.Name = "grid_list1"
        Me.grid_list1.Size = New System.Drawing.Size(286, 278)
        Me.grid_list1.TabIndex = 31
        Me.grid_list1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_kota})
        '
        'GridV_kota
        '
        Me.GridV_kota.GridControl = Me.grid_list1
        Me.GridV_kota.Name = "GridV_kota"
        Me.GridV_kota.OptionsCustomization.AllowColumnMoving = False
        Me.GridV_kota.OptionsCustomization.AllowFilter = False
        Me.GridV_kota.OptionsCustomization.AllowGroup = False
        Me.GridV_kota.OptionsCustomization.AllowRowSizing = True
        Me.GridV_kota.OptionsCustomization.AllowSort = False
        Me.GridV_kota.OptionsView.ShowGroupPanel = False
        '
        'grid_list2
        '
        Me.grid_list2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_list2.Location = New System.Drawing.Point(760, 57)
        Me.grid_list2.MainView = Me.GridV_zona
        Me.grid_list2.Name = "grid_list2"
        Me.grid_list2.Size = New System.Drawing.Size(222, 278)
        Me.grid_list2.TabIndex = 32
        Me.grid_list2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_zona})
        '
        'GridV_zona
        '
        Me.GridV_zona.GridControl = Me.grid_list2
        Me.GridV_zona.Name = "GridV_zona"
        Me.GridV_zona.OptionsView.ShowGroupPanel = False
        '
        'grid_list4
        '
        Me.grid_list4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_list4.Location = New System.Drawing.Point(12, 57)
        Me.grid_list4.MainView = Me.GridV_provinsi
        Me.grid_list4.Name = "grid_list4"
        Me.grid_list4.Size = New System.Drawing.Size(222, 278)
        Me.grid_list4.TabIndex = 34
        Me.grid_list4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_provinsi})
        '
        'GridV_provinsi
        '
        Me.GridV_provinsi.GridControl = Me.grid_list4
        Me.GridV_provinsi.Name = "GridV_provinsi"
        Me.GridV_provinsi.OptionsView.ShowGroupPanel = False
        '
        'grid_list3
        '
        Me.grid_list3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_list3.Location = New System.Drawing.Point(532, 57)
        Me.grid_list3.MainView = Me.GridV_group
        Me.grid_list3.Name = "grid_list3"
        Me.grid_list3.Size = New System.Drawing.Size(222, 278)
        Me.grid_list3.TabIndex = 35
        Me.grid_list3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridV_group})
        '
        'GridV_group
        '
        Me.GridV_group.GridControl = Me.grid_list3
        Me.GridV_group.Name = "GridV_group"
        Me.GridV_group.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(222, 54)
        Me.GroupControl1.TabIndex = 36
        Me.GroupControl1.Text = "Wilyah / Provinsi"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(117, 24)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Edit"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 24)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Tambah"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Controls.Add(Me.SimpleButton3)
        Me.GroupControl2.Controls.Add(Me.SimpleButton4)
        Me.GroupControl2.Location = New System.Drawing.Point(240, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(286, 54)
        Me.GroupControl2.TabIndex = 37
        Me.GroupControl2.Text = "Kota"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(150, 24)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "Edit"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(38, 24)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton4.TabIndex = 2
        Me.SimpleButton4.Text = "Tambah"
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Controls.Add(Me.SimpleButton5)
        Me.GroupControl3.Controls.Add(Me.SimpleButton6)
        Me.GroupControl3.Location = New System.Drawing.Point(532, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(222, 54)
        Me.GroupControl3.TabIndex = 38
        Me.GroupControl3.Text = "Group"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(117, 23)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Text = "Edit"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(5, 23)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton6.TabIndex = 2
        Me.SimpleButton6.Text = "Tambah"
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Controls.Add(Me.SimpleButton7)
        Me.GroupControl4.Controls.Add(Me.SimpleButton8)
        Me.GroupControl4.Location = New System.Drawing.Point(760, 3)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(222, 54)
        Me.GroupControl4.TabIndex = 39
        Me.GroupControl4.Text = "Zona"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(117, 23)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton7.TabIndex = 3
        Me.SimpleButton7.Text = "Edit"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Location = New System.Drawing.Point(5, 23)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(100, 28)
        Me.SimpleButton8.TabIndex = 2
        Me.SimpleButton8.Text = "Tambah"
        '
        'frm_wilayah_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 340)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grid_list3)
        Me.Controls.Add(Me.grid_list4)
        Me.Controls.Add(Me.grid_list2)
        Me.Controls.Add(Me.grid_list1)
        Me.Name = "frm_wilayah_list"
        Me.Text = "frm_wilayah_list"
        CType(Me.grid_list1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_kota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_list2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_list4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_provinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_list3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridV_group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_list1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_kota As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_list2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_zona As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_list4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_provinsi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_list3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridV_group As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
End Class
