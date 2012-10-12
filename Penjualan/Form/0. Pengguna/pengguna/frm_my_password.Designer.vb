<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_my_password
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
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txt_username = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_old_password = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_new_password = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_new_password_confirm = New DevExpress.XtraEditors.TextEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_old_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_new_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_new_password_confirm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl18.TabIndex = 11
        Me.LabelControl18.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.EditValue = ""
        Me.txt_username.Enabled = False
        Me.txt_username.Location = New System.Drawing.Point(123, 12)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Properties.Appearance.Options.UseFont = True
        Me.txt_username.Properties.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(147, 21)
        Me.txt_username.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(89, 14)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Kata Sandi Lama"
        '
        'txt_old_password
        '
        Me.txt_old_password.EditValue = ""
        Me.txt_old_password.Location = New System.Drawing.Point(123, 39)
        Me.txt_old_password.Name = "txt_old_password"
        Me.txt_old_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_old_password.Properties.Appearance.Options.UseFont = True
        Me.txt_old_password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_old_password.Size = New System.Drawing.Size(203, 21)
        Me.txt_old_password.TabIndex = 12
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 84)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 14)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Kata Sandi Baru"
        '
        'txt_new_password
        '
        Me.txt_new_password.EditValue = ""
        Me.txt_new_password.Location = New System.Drawing.Point(123, 81)
        Me.txt_new_password.Name = "txt_new_password"
        Me.txt_new_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_password.Properties.Appearance.Options.UseFont = True
        Me.txt_new_password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_new_password.Size = New System.Drawing.Size(203, 21)
        Me.txt_new_password.TabIndex = 14
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(10, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(93, 14)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Ulangi Kata Sandi"
        '
        'txt_new_password_confirm
        '
        Me.txt_new_password_confirm.EditValue = ""
        Me.txt_new_password_confirm.Location = New System.Drawing.Point(123, 108)
        Me.txt_new_password_confirm.Name = "txt_new_password_confirm"
        Me.txt_new_password_confirm.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_password_confirm.Properties.Appearance.Options.UseFont = True
        Me.txt_new_password_confirm.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_new_password_confirm.Size = New System.Drawing.Size(203, 21)
        Me.txt_new_password_confirm.TabIndex = 16
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(228, 169)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 25)
        Me.cmd_simpan.TabIndex = 18
        Me.cmd_simpan.Text = "Simpan"
        '
        'frm_my_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 206)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_new_password_confirm)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_new_password)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_old_password)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txt_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_my_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ganti Kata Sandi-Ku"
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_old_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_new_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_new_password_confirm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_old_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_new_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_new_password_confirm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
End Class
