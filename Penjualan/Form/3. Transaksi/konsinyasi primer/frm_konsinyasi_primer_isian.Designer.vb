<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_konsinyasi_primer_isian
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_transaksi = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_kode_barangjadi = New DevExpress.XtraEditors.LabelControl
        Me.lbl_nama = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.harga = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.diskon = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.qty = New DevExpress.XtraEditors.TextEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_cancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.tgl_transaksi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_transaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.harga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 14)
        Me.LabelControl2.TabIndex = 47
        Me.LabelControl2.Text = "Tanggal Transaksi"
        '
        'tgl_transaksi
        '
        Me.tgl_transaksi.EditValue = Nothing
        Me.tgl_transaksi.Location = New System.Drawing.Point(127, 12)
        Me.tgl_transaksi.Name = "tgl_transaksi"
        Me.tgl_transaksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_transaksi.Properties.Appearance.Options.UseFont = True
        Me.tgl_transaksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_transaksi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_transaksi.Size = New System.Drawing.Size(132, 21)
        Me.tgl_transaksi.TabIndex = 46
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl1.TabIndex = 48
        Me.LabelControl1.Text = "Kode Artikel"
        '
        'lbl_kode_barangjadi
        '
        Me.lbl_kode_barangjadi.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kode_barangjadi.Location = New System.Drawing.Point(127, 39)
        Me.lbl_kode_barangjadi.Name = "lbl_kode_barangjadi"
        Me.lbl_kode_barangjadi.Size = New System.Drawing.Size(12, 14)
        Me.lbl_kode_barangjadi.TabIndex = 49
        Me.lbl_kode_barangjadi.Text = "---"
        '
        'lbl_nama
        '
        Me.lbl_nama.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(127, 59)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(12, 14)
        Me.lbl_nama.TabIndex = 51
        Me.lbl_nama.Text = "---"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 59)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl5.TabIndex = 50
        Me.LabelControl5.Text = "Nama"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 82)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl6.TabIndex = 53
        Me.LabelControl6.Text = "Harga (Rp.)"
        '
        'harga
        '
        Me.harga.EditValue = ""
        Me.harga.Location = New System.Drawing.Point(127, 79)
        Me.harga.Name = "harga"
        Me.harga.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Properties.Appearance.Options.UseFont = True
        Me.harga.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.harga.Size = New System.Drawing.Size(132, 21)
        Me.harga.TabIndex = 52
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(12, 109)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl7.TabIndex = 55
        Me.LabelControl7.Text = "Diskon (%)"
        '
        'diskon
        '
        Me.diskon.EditValue = ""
        Me.diskon.Location = New System.Drawing.Point(127, 106)
        Me.diskon.Name = "diskon"
        Me.diskon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskon.Properties.Appearance.Options.UseFont = True
        Me.diskon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.diskon.Size = New System.Drawing.Size(44, 21)
        Me.diskon.TabIndex = 54
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(12, 136)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl8.TabIndex = 57
        Me.LabelControl8.Text = "Jumlah Jual"
        '
        'qty
        '
        Me.qty.EditValue = ""
        Me.qty.Location = New System.Drawing.Point(127, 133)
        Me.qty.Name = "qty"
        Me.qty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.Properties.Appearance.Options.UseFont = True
        Me.qty.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.qty.Size = New System.Drawing.Size(80, 21)
        Me.qty.TabIndex = 56
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(210, 192)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(97, 24)
        Me.cmd_simpan.TabIndex = 75
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_cancel.Location = New System.Drawing.Point(313, 192)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(97, 24)
        Me.cmd_cancel.TabIndex = 76
        Me.cmd_cancel.Text = "Cancel"
        '
        'frm_konsinyasi_primer_isian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.lbl_kode_barangjadi)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.tgl_transaksi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_konsinyasi_primer_isian"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.tgl_transaksi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_transaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.harga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_transaksi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kode_barangjadi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_nama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents harga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents diskon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_cancel As DevExpress.XtraEditors.SimpleButton
End Class
