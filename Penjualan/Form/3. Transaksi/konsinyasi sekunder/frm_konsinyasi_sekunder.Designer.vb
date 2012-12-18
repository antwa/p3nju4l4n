<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_konsinyasi_sekunder
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
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_hapus_baris = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cari_artikel = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(471, 280)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 44
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(574, 280)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 43
        Me.cmd_cancel.Text = "Cancel"
        '
        'cmd_hapus_baris
        '
        Me.cmd_hapus_baris.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus_baris.Location = New System.Drawing.Point(121, 280)
        Me.cmd_hapus_baris.Name = "cmd_hapus_baris"
        Me.cmd_hapus_baris.Size = New System.Drawing.Size(97, 24)
        Me.cmd_hapus_baris.TabIndex = 42
        Me.cmd_hapus_baris.Text = "Hapus"
        '
        'cmd_cari_artikel
        '
        Me.cmd_cari_artikel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_cari_artikel.Location = New System.Drawing.Point(12, 280)
        Me.cmd_cari_artikel.Name = "cmd_cari_artikel"
        Me.cmd_cari_artikel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cari_artikel.TabIndex = 41
        Me.cmd_cari_artikel.Text = "Cari Artikel"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 36)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(659, 238)
        Me.GridControl1.TabIndex = 40
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowBandMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(80, 9)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(262, 21)
        Me.kode_customer.TabIndex = 46
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 45
        Me.LabelControl6.Text = "Customer"
        '
        'frm_konsinyasi_sekunder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 316)
        Me.Controls.Add(Me.kode_customer)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_hapus_baris)
        Me.Controls.Add(Me.cmd_cari_artikel)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_konsinyasi_sekunder"
        Me.Text = "Input Konsinyasi Sekunder"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_hapus_baris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cari_artikel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
