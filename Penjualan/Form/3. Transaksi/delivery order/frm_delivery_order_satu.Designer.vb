<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_delivery_order_satu
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.no_so = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_do = New DevExpress.XtraEditors.DateEdit
        Me.no_do = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lbl_kota = New DevExpress.XtraEditors.LabelControl
        Me.lbl_mall = New DevExpress.XtraEditors.LabelControl
        Me.lbl_alamat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_nama = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tgl_do.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_do.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_do.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 146)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(710, 254)
        Me.GridControl1.TabIndex = 32
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.no_so)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.tgl_do)
        Me.GroupControl1.Controls.Add(Me.no_do)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(266, 108)
        Me.GroupControl1.TabIndex = 33
        '
        'no_so
        '
        Me.no_so.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_so.Location = New System.Drawing.Point(79, 79)
        Me.no_so.Name = "no_so"
        Me.no_so.Size = New System.Drawing.Size(56, 14)
        Me.no_so.TabIndex = 34
        Me.no_so.Text = "Nomor SO"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nomor SO"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(6, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl3.TabIndex = 32
        Me.LabelControl3.Text = "Tanggal"
        '
        'tgl_do
        '
        Me.tgl_do.EditValue = Nothing
        Me.tgl_do.Location = New System.Drawing.Point(79, 52)
        Me.tgl_do.Name = "tgl_do"
        Me.tgl_do.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_do.Properties.Appearance.Options.UseFont = True
        Me.tgl_do.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_do.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_do.Size = New System.Drawing.Size(167, 21)
        Me.tgl_do.TabIndex = 31
        '
        'no_do
        '
        Me.no_do.Location = New System.Drawing.Point(79, 25)
        Me.no_do.Name = "no_do"
        Me.no_do.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_do.Properties.Appearance.Options.UseFont = True
        Me.no_do.Properties.ReadOnly = True
        Me.no_do.Size = New System.Drawing.Size(167, 21)
        Me.no_do.TabIndex = 30
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Nomor DO"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.lbl_kota)
        Me.GroupControl2.Controls.Add(Me.lbl_mall)
        Me.GroupControl2.Controls.Add(Me.lbl_alamat)
        Me.GroupControl2.Controls.Add(Me.lbl_nama)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(284, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(438, 108)
        Me.GroupControl2.TabIndex = 34
        '
        'lbl_kota
        '
        Me.lbl_kota.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kota.Location = New System.Drawing.Point(44, 88)
        Me.lbl_kota.Name = "lbl_kota"
        Me.lbl_kota.Size = New System.Drawing.Size(25, 14)
        Me.lbl_kota.TabIndex = 34
        Me.lbl_kota.Text = "Kota"
        '
        'lbl_mall
        '
        Me.lbl_mall.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mall.Location = New System.Drawing.Point(44, 68)
        Me.lbl_mall.Name = "lbl_mall"
        Me.lbl_mall.Size = New System.Drawing.Size(20, 14)
        Me.lbl_mall.TabIndex = 33
        Me.lbl_mall.Text = "mall"
        '
        'lbl_alamat
        '
        Me.lbl_alamat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamat.Location = New System.Drawing.Point(44, 48)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Size = New System.Drawing.Size(35, 14)
        Me.lbl_alamat.TabIndex = 32
        Me.lbl_alamat.Text = "alamat"
        '
        'lbl_nama
        '
        Me.lbl_nama.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(44, 28)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(86, 14)
        Me.lbl_nama.TabIndex = 31
        Me.lbl_nama.Text = "Nama Customer"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "Kpd : "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 126)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 14)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "Detail Barang"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(512, 406)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(107, 24)
        Me.cmd_simpan.TabIndex = 37
        Me.cmd_simpan.Text = "Save && Print"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(625, 406)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 36
        Me.cmd_cancel.Text = "Cancel"
        '
        'frm_delivery_order_satu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 442)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_delivery_order_satu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Satu DO"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tgl_do.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_do.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_do.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents no_do As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents no_so As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_do As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kota As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_mall As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_alamat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_nama As DevExpress.XtraEditors.LabelControl
End Class
