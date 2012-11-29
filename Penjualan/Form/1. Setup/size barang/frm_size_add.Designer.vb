<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_size_add
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kode_size = New DevExpress.XtraEditors.TextEdit
        Me.txt_size = New DevExpress.XtraEditors.TextEdit
        CType(Me.txt_kode_size.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_size.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(161, 90)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 25)
        Me.cmd_batal.TabIndex = 11
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(32, 90)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 25)
        Me.cmd_simpan.TabIndex = 10
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Size"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(32, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Kode Size"
        '
        'txt_kode_size
        '
        Me.txt_kode_size.Location = New System.Drawing.Point(122, 19)
        Me.txt_kode_size.Name = "txt_kode_size"
        Me.txt_kode_size.Size = New System.Drawing.Size(137, 20)
        Me.txt_kode_size.TabIndex = 12
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(122, 53)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(137, 20)
        Me.txt_size.TabIndex = 13
        '
        'frm_size_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 147)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_kode_size)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_size_add"
        Me.Text = "frm_size_add"
        CType(Me.txt_kode_size.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_size.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kode_size As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_size As DevExpress.XtraEditors.TextEdit
End Class
