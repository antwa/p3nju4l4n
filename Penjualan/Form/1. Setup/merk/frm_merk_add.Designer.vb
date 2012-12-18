<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_merk_add
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
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_merk = New DevExpress.XtraEditors.TextEdit
        CType(Me.txt_merk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(166, 67)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 25)
        Me.cmd_batal.TabIndex = 11
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(37, 67)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 25)
        Me.cmd_simpan.TabIndex = 10
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Merk"
        '
        'txt_merk
        '
        Me.txt_merk.Location = New System.Drawing.Point(121, 12)
        Me.txt_merk.Name = "txt_merk"
        Me.txt_merk.Size = New System.Drawing.Size(143, 20)
        Me.txt_merk.TabIndex = 13
        '
        'frm_merk_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 113)
        Me.Controls.Add(Me.txt_merk)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_merk_add"
        Me.Text = "Tambah Merk"
        CType(Me.txt_merk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_merk As DevExpress.XtraEditors.TextEdit
End Class
