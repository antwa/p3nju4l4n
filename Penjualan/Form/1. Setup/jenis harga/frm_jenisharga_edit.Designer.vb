﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_jenisharga_edit
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
        Me.txt_jenis = New DevExpress.XtraEditors.TextEdit
        Me.txt_kode = New DevExpress.XtraEditors.TextEdit
        Me.cmd_batal = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txt_jenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_jenis
        '
        Me.txt_jenis.Location = New System.Drawing.Point(123, 59)
        Me.txt_jenis.Name = "txt_jenis"
        Me.txt_jenis.Size = New System.Drawing.Size(137, 20)
        Me.txt_jenis.TabIndex = 25
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(123, 25)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(137, 20)
        Me.txt_kode.TabIndex = 24
        '
        'cmd_batal
        '
        Me.cmd_batal.Location = New System.Drawing.Point(162, 96)
        Me.cmd_batal.Name = "cmd_batal"
        Me.cmd_batal.Size = New System.Drawing.Size(98, 25)
        Me.cmd_batal.TabIndex = 23
        Me.cmd_batal.Text = "Batal"
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Location = New System.Drawing.Point(33, 96)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(98, 25)
        Me.cmd_simpan.TabIndex = 22
        Me.cmd_simpan.Text = "Simpan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Harga"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(33, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Kode Harga"
        '
        'frm_jenisharga_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 147)
        Me.Controls.Add(Me.txt_jenis)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.cmd_batal)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_jenisharga_edit"
        Me.Text = "frm_jenisharga_edit"
        CType(Me.txt_jenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_jenis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_batal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
