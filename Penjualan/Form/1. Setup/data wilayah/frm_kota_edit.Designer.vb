<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kota_edit
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
        Me.lkp_kode_provinsi = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kode = New DevExpress.XtraEditors.TextEdit
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kota = New DevExpress.XtraEditors.TextEdit
        CType(Me.lkp_kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lkp_kode_provinsi
        '
        Me.lkp_kode_provinsi.Location = New System.Drawing.Point(92, 68)
        Me.lkp_kode_provinsi.Name = "lkp_kode_provinsi"
        Me.lkp_kode_provinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkp_kode_provinsi.Properties.Appearance.Options.UseFont = True
        Me.lkp_kode_provinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkp_kode_provinsi.Size = New System.Drawing.Size(73, 21)
        Me.lkp_kode_provinsi.TabIndex = 66
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 65
        Me.LabelControl3.Text = "Kode Provinsi"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 64
        Me.LabelControl1.Text = "Kode Kota"
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(92, 9)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(73, 20)
        Me.txt_kode.TabIndex = 63
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(193, 101)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(76, 25)
        Me.cmd_batal.TabIndex = 62
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(92, 101)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(73, 25)
        Me.cmd_simpan.TabIndex = 61
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl2.TabIndex = 60
        Me.LabelControl2.Text = "Kota"
        '
        'txt_kota
        '
        Me.txt_kota.Location = New System.Drawing.Point(93, 39)
        Me.txt_kota.Name = "txt_kota"
        Me.txt_kota.Size = New System.Drawing.Size(176, 20)
        Me.txt_kota.TabIndex = 59
        '
        'frm_kota_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 138)
        Me.Controls.Add(Me.lkp_kode_provinsi)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_kota)
        Me.Name = "frm_kota_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_kota_edit"
        CType(Me.lkp_kode_provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lkp_kode_provinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kota As DevExpress.XtraEditors.TextEdit
End Class
