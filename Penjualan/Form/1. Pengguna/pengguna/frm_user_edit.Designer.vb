<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user_edit))
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_jabatan = New DevExpress.XtraEditors.TextEdit
        Me.look_levelAccess = New DevExpress.XtraEditors.LookUpEdit
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_namaLengkap = New DevExpress.XtraEditors.TextEdit
        Me.txt_confirmPassword = New DevExpress.XtraEditors.TextEdit
        Me.txt_password = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txt_username = New DevExpress.XtraEditors.TextEdit
        CType(Me.txt_jabatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.look_levelAccess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_namaLengkap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_confirmPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(10, 131)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 14)
        Me.LabelControl5.TabIndex = 36
        Me.LabelControl5.Text = "Jabatan"
        '
        'txt_jabatan
        '
        Me.txt_jabatan.EditValue = ""
        Me.txt_jabatan.Location = New System.Drawing.Point(114, 128)
        Me.txt_jabatan.Name = "txt_jabatan"
        Me.txt_jabatan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jabatan.Properties.Appearance.Options.UseFont = True
        Me.txt_jabatan.Size = New System.Drawing.Size(212, 21)
        Me.txt_jabatan.TabIndex = 35
        '
        'look_levelAccess
        '
        Me.look_levelAccess.Location = New System.Drawing.Point(114, 155)
        Me.look_levelAccess.Name = "look_levelAccess"
        Me.look_levelAccess.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.look_levelAccess.Properties.Appearance.Options.UseFont = True
        Me.look_levelAccess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.look_levelAccess.Size = New System.Drawing.Size(212, 21)
        Me.look_levelAccess.TabIndex = 34
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Image = CType(resources.GetObject("cmd_simpan.Image"), System.Drawing.Image)
        Me.cmd_simpan.Location = New System.Drawing.Point(223, 228)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(100, 33)
        Me.cmd_simpan.TabIndex = 33
        Me.cmd_simpan.Text = "Simpan"
        '
        'cmd_batal
        '
        Me.cmd_batal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_batal.Image = CType(resources.GetObject("cmd_batal.Image"), System.Drawing.Image)
        Me.cmd_batal.Location = New System.Drawing.Point(111, 228)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(100, 33)
        Me.cmd_batal.TabIndex = 32
        Me.cmd_batal.Text = "Batal"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(10, 158)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "Level Akses"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(10, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl3.TabIndex = 30
        Me.LabelControl3.Text = "Nama Lengkap"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 14)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "Confirm Password"
        '
        'txt_namaLengkap
        '
        Me.txt_namaLengkap.EditValue = ""
        Me.txt_namaLengkap.Location = New System.Drawing.Point(114, 101)
        Me.txt_namaLengkap.Name = "txt_namaLengkap"
        Me.txt_namaLengkap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaLengkap.Properties.Appearance.Options.UseFont = True
        Me.txt_namaLengkap.Size = New System.Drawing.Size(212, 21)
        Me.txt_namaLengkap.TabIndex = 28
        '
        'txt_confirmPassword
        '
        Me.txt_confirmPassword.EditValue = ""
        Me.txt_confirmPassword.Location = New System.Drawing.Point(114, 61)
        Me.txt_confirmPassword.Name = "txt_confirmPassword"
        Me.txt_confirmPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmPassword.Properties.Appearance.Options.UseFont = True
        Me.txt_confirmPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmPassword.Size = New System.Drawing.Size(212, 21)
        Me.txt_confirmPassword.TabIndex = 27
        '
        'txt_password
        '
        Me.txt_password.EditValue = ""
        Me.txt_password.Location = New System.Drawing.Point(114, 34)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(212, 21)
        Me.txt_password.TabIndex = 26
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "Password"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(10, 10)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl18.TabIndex = 24
        Me.LabelControl18.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.EditValue = ""
        Me.txt_username.Location = New System.Drawing.Point(114, 7)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Properties.Appearance.Options.UseFont = True
        Me.txt_username.Properties.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(212, 21)
        Me.txt_username.TabIndex = 23
        '
        'frm_user_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_jabatan)
        Me.Controls.Add(Me.look_levelAccess)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_namaLengkap)
        Me.Controls.Add(Me.txt_confirmPassword)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txt_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_user_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Edit User"
        CType(Me.txt_jabatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.look_levelAccess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_namaLengkap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_confirmPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_jabatan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents look_levelAccess As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_namaLengkap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_confirmPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_username As DevExpress.XtraEditors.TextEdit
End Class
