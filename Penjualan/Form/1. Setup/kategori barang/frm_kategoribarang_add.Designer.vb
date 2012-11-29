<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kategoribarang_add
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
        Me.txt_kode_kategori = New DevExpress.XtraEditors.TextEdit
        Me.txt_kategori = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txt_kode_kategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_kode_kategori
        '
        Me.txt_kode_kategori.Location = New System.Drawing.Point(131, 21)
        Me.txt_kode_kategori.Name = "txt_kode_kategori"
        Me.txt_kode_kategori.Size = New System.Drawing.Size(141, 20)
        Me.txt_kode_kategori.TabIndex = 0
        '
        'txt_kategori
        '
        Me.txt_kategori.Location = New System.Drawing.Point(131, 56)
        Me.txt_kategori.Name = "txt_kategori"
        Me.txt_kategori.Size = New System.Drawing.Size(141, 20)
        Me.txt_kategori.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Kode Kategori"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Kategori"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(30, 93)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 25)
        Me.cmd_simpan.TabIndex = 4
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(159, 93)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 25)
        Me.cmd_batal.TabIndex = 5
        Me.cmd_batal.Text = "Batal"
        '
        'frm_kategoribarang_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 145)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_kategori)
        Me.Controls.Add(Me.txt_kode_kategori)
        Me.Name = "frm_kategoribarang_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Kategori Barang"
        CType(Me.txt_kode_kategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_kode_kategori As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kategori As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
End Class
