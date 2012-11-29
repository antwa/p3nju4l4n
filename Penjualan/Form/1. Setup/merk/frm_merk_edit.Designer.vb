<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_merk_edit
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
        Me.txt_merk = New DevExpress.XtraEditors.TextEdit
        Me.txt_kode_merk = New DevExpress.XtraEditors.TextEdit
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txt_merk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kode_merk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_merk
        '
        Me.txt_merk.Location = New System.Drawing.Point(121, 55)
        Me.txt_merk.Name = "txt_merk"
        Me.txt_merk.Size = New System.Drawing.Size(143, 20)
        Me.txt_merk.TabIndex = 19
        '
        'txt_kode_merk
        '
        Me.txt_kode_merk.Location = New System.Drawing.Point(120, 21)
        Me.txt_kode_merk.Name = "txt_kode_merk"
        Me.txt_kode_merk.Size = New System.Drawing.Size(145, 20)
        Me.txt_kode_merk.TabIndex = 18
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(167, 92)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 25)
        Me.cmd_batal.TabIndex = 17
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(38, 92)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 25)
        Me.cmd_simpan.TabIndex = 16
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Merk"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(23, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Kode Merk"
        '
        'frm_merk_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 147)
        Me.Controls.Add(Me.txt_merk)
        Me.Controls.Add(Me.txt_kode_merk)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_merk_edit"
        Me.Text = "frm_merk_edit"
        CType(Me.txt_merk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kode_merk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_merk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kode_merk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
