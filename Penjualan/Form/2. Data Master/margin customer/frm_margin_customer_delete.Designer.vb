<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_margin_customer_delete
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
        Me.cmd_print = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_dari = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer_parent = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_sampai = New DevExpress.XtraEditors.DateEdit
        Me.tipe_customer = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipe_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_print
        '
        Me.cmd_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_print.Location = New System.Drawing.Point(257, 119)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(105, 24)
        Me.cmd_print.TabIndex = 48
        Me.cmd_print.Text = "Proses"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl3.TabIndex = 49
        Me.LabelControl3.Text = "Tanggal"
        '
        'tgl_dari
        '
        Me.tgl_dari.EditValue = Nothing
        Me.tgl_dari.Location = New System.Drawing.Point(73, 9)
        Me.tgl_dari.Name = "tgl_dari"
        Me.tgl_dari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_dari.Properties.Appearance.Options.UseFont = True
        Me.tgl_dari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_dari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_dari.Size = New System.Drawing.Size(120, 21)
        Me.tgl_dari.TabIndex = 50
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl1.TabIndex = 51
        Me.LabelControl1.Text = "Customer"
        '
        'kode_customer_parent
        '
        Me.kode_customer_parent.Location = New System.Drawing.Point(73, 40)
        Me.kode_customer_parent.Name = "kode_customer_parent"
        Me.kode_customer_parent.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer_parent.Properties.Appearance.Options.UseFont = True
        Me.kode_customer_parent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer_parent.Size = New System.Drawing.Size(290, 21)
        Me.kode_customer_parent.TabIndex = 52
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(199, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl2.TabIndex = 53
        Me.LabelControl2.Text = "Sampai"
        '
        'tgl_sampai
        '
        Me.tgl_sampai.EditValue = Nothing
        Me.tgl_sampai.Location = New System.Drawing.Point(243, 9)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_sampai.Properties.Appearance.Options.UseFont = True
        Me.tgl_sampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_sampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_sampai.Size = New System.Drawing.Size(120, 21)
        Me.tgl_sampai.TabIndex = 54
        '
        'tipe_customer
        '
        Me.tipe_customer.EditValue = "Normal"
        Me.tipe_customer.Location = New System.Drawing.Point(73, 67)
        Me.tipe_customer.Name = "tipe_customer"
        Me.tipe_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tipe_customer.Properties.Appearance.Options.UseFont = True
        Me.tipe_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tipe_customer.Properties.Items.AddRange(New Object() {"Normal", "Obral", "SP"})
        Me.tipe_customer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.tipe_customer.Size = New System.Drawing.Size(93, 21)
        Me.tipe_customer.TabIndex = 78
        '
        'frm_margin_customer_delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 155)
        Me.Controls.Add(Me.tipe_customer)
        Me.Controls.Add(Me.tgl_sampai)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.kode_customer_parent)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tgl_dari)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmd_print)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_margin_customer_delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Margin Customer"
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer_parent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipe_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_dari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer_parent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_sampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tipe_customer As DevExpress.XtraEditors.ComboBoxEdit
End Class
