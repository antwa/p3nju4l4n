<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_zona_add
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
        Me.txt_zona = New DevExpress.XtraEditors.TextEdit
        CType(Me.txt_zona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(174, 54)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 25)
        Me.cmd_batal.TabIndex = 19
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(73, 54)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(95, 25)
        Me.cmd_simpan.TabIndex = 18
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Zona"
        '
        'txt_zona
        '
        Me.txt_zona.Location = New System.Drawing.Point(73, 12)
        Me.txt_zona.Name = "txt_zona"
        Me.txt_zona.Size = New System.Drawing.Size(199, 20)
        Me.txt_zona.TabIndex = 16
        '
        'frm_zona_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 88)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_zona)
        Me.Name = "frm_zona_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_zona_add"
        CType(Me.txt_zona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_zona As DevExpress.XtraEditors.TextEdit
End Class
