<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fakturglobal
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
        Me.no_faktur = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.kode_customer = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_dari = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_sampai = New DevExpress.XtraEditors.DateEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmd_simpan = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_load = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_reset = New DevExpress.XtraEditors.SimpleButton
        Me.cmd_print_amplop_polos = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.tgl_terbit = New DevExpress.XtraEditors.DateEdit
        Me.cmd_print_amplop = New DevExpress.XtraEditors.SimpleButton
        CType(Me.no_faktur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'no_faktur
        '
        Me.no_faktur.Location = New System.Drawing.Point(100, 12)
        Me.no_faktur.Name = "no_faktur"
        Me.no_faktur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_faktur.Properties.Appearance.Options.UseFont = True
        Me.no_faktur.Properties.ReadOnly = True
        Me.no_faktur.Size = New System.Drawing.Size(121, 21)
        Me.no_faktur.TabIndex = 40
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl1.TabIndex = 39
        Me.LabelControl1.Text = "No. Faktur"
        '
        'kode_customer
        '
        Me.kode_customer.Location = New System.Drawing.Point(100, 66)
        Me.kode_customer.Name = "kode_customer"
        Me.kode_customer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kode_customer.Properties.Appearance.Options.UseFont = True
        Me.kode_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kode_customer.Size = New System.Drawing.Size(268, 21)
        Me.kode_customer.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 69)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl6.TabIndex = 42
        Me.LabelControl6.Text = "Customer"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl3.TabIndex = 45
        Me.LabelControl3.Text = "Tanggal"
        '
        'tgl_dari
        '
        Me.tgl_dari.EditValue = Nothing
        Me.tgl_dari.Location = New System.Drawing.Point(100, 93)
        Me.tgl_dari.Name = "tgl_dari"
        Me.tgl_dari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_dari.Properties.Appearance.Options.UseFont = True
        Me.tgl_dari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_dari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_dari.Size = New System.Drawing.Size(121, 21)
        Me.tgl_dari.TabIndex = 44
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(224, 96)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(17, 14)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "s/d"
        '
        'tgl_sampai
        '
        Me.tgl_sampai.EditValue = Nothing
        Me.tgl_sampai.Location = New System.Drawing.Point(247, 93)
        Me.tgl_sampai.Name = "tgl_sampai"
        Me.tgl_sampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_sampai.Properties.Appearance.Options.UseFont = True
        Me.tgl_sampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_sampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_sampai.Size = New System.Drawing.Size(121, 21)
        Me.tgl_sampai.TabIndex = 47
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 150)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(632, 180)
        Me.GridControl1.TabIndex = 48
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmd_simpan
        '
        Me.cmd_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_simpan.Location = New System.Drawing.Point(529, 336)
        Me.cmd_simpan.Name = "cmd_simpan"
        Me.cmd_simpan.Size = New System.Drawing.Size(115, 24)
        Me.cmd_simpan.TabIndex = 49
        Me.cmd_simpan.Text = "Simpan && Print"
        '
        'cmd_load
        '
        Me.cmd_load.Location = New System.Drawing.Point(100, 120)
        Me.cmd_load.Name = "cmd_load"
        Me.cmd_load.Size = New System.Drawing.Size(92, 24)
        Me.cmd_load.TabIndex = 50
        Me.cmd_load.Text = "Load"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(198, 120)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(92, 24)
        Me.cmd_reset.TabIndex = 51
        Me.cmd_reset.Text = "Reset"
        '
        'cmd_print_amplop_polos
        '
        Me.cmd_print_amplop_polos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_print_amplop_polos.Location = New System.Drawing.Point(133, 336)
        Me.cmd_print_amplop_polos.Name = "cmd_print_amplop_polos"
        Me.cmd_print_amplop_polos.Size = New System.Drawing.Size(115, 24)
        Me.cmd_print_amplop_polos.TabIndex = 52
        Me.cmd_print_amplop_polos.Text = "Print Amplop Polos"
        Me.cmd_print_amplop_polos.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 14)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "Tanggal Terbit"
        '
        'tgl_terbit
        '
        Me.tgl_terbit.EditValue = Nothing
        Me.tgl_terbit.Location = New System.Drawing.Point(100, 39)
        Me.tgl_terbit.Name = "tgl_terbit"
        Me.tgl_terbit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_terbit.Properties.Appearance.Options.UseFont = True
        Me.tgl_terbit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tgl_terbit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tgl_terbit.Size = New System.Drawing.Size(121, 21)
        Me.tgl_terbit.TabIndex = 53
        '
        'cmd_print_amplop
        '
        Me.cmd_print_amplop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_print_amplop.Location = New System.Drawing.Point(12, 336)
        Me.cmd_print_amplop.Name = "cmd_print_amplop"
        Me.cmd_print_amplop.Size = New System.Drawing.Size(115, 24)
        Me.cmd_print_amplop.TabIndex = 55
        Me.cmd_print_amplop.Text = "Print Amplop"
        '
        'frm_fakturglobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 372)
        Me.Controls.Add(Me.cmd_print_amplop)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.tgl_terbit)
        Me.Controls.Add(Me.cmd_print_amplop_polos)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_load)
        Me.Controls.Add(Me.cmd_simpan)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.tgl_sampai)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tgl_dari)
        Me.Controls.Add(Me.kode_customer)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.no_faktur)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_fakturglobal"
        Me.Text = "Faktur Global"
        CType(Me.no_faktur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kode_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_dari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_sampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tgl_terbit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents no_faktur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kode_customer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_dari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_sampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmd_simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_load As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_reset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_print_amplop_polos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tgl_terbit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmd_print_amplop As DevExpress.XtraEditors.SimpleButton
End Class
