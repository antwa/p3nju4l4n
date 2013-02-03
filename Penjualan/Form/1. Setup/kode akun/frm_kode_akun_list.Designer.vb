<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kode_akun_list
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
        Me.cmd_hapus = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_edit = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_tambah = New DevExpress.XtraEditors.SimpleButton
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_hapus
        '
        Me.cmd_hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_hapus.Location = New System.Drawing.Point(686, 249)
        Me.cmd_hapus.Name = "cmd_hapus"
        Me.cmd_hapus.Size = New System.Drawing.Size(113, 26)
        Me.cmd_hapus.TabIndex = 30
        Me.cmd_hapus.Text = "Hapus"
        '
        'cmd_edit
        '
        Me.cmd_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_edit.Location = New System.Drawing.Point(567, 249)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(113, 26)
        Me.cmd_edit.TabIndex = 29
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_tambah
        '
        Me.cmd_tambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_tambah.Location = New System.Drawing.Point(448, 249)
        Me.cmd_tambah.Name = "cmd_tambah"
        Me.cmd_tambah.Size = New System.Drawing.Size(113, 26)
        Me.cmd_tambah.TabIndex = 28
        Me.cmd_tambah.Text = "Tambah"
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Location = New System.Drawing.Point(12, 12)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsView.AutoWidth = False
        Me.TreeList1.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeList1.OptionsView.ShowPreview = True
        Me.TreeList1.Size = New System.Drawing.Size(787, 231)
        Me.TreeList1.TabIndex = 31
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(329, 249)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(113, 26)
        Me.SimpleButton1.TabIndex = 32
        Me.SimpleButton1.Text = "Refresh"
        '
        'frm_kode_akun_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 287)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.cmd_hapus)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_tambah)
        Me.Name = "frm_kode_akun_list"
        Me.Text = "Kode Akun"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_tambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
