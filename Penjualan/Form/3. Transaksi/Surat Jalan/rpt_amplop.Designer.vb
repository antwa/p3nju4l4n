<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_amplop
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.lbl_nama_customer = New DevExpress.XtraReports.UI.XRLabel
        Me.lbl_alamat = New DevExpress.XtraReports.UI.XRLabel
        Me.lbl_kota = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl_kota, Me.lbl_alamat, Me.lbl_nama_customer})
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 99.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 83.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lbl_nama_customer
        '
        Me.lbl_nama_customer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama_customer.LocationFloat = New DevExpress.Utils.PointFloat(319.7917!, 0.0!)
        Me.lbl_nama_customer.Name = "lbl_nama_customer"
        Me.lbl_nama_customer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.lbl_nama_customer.SizeF = New System.Drawing.SizeF(349.2083!, 18.75!)
        Me.lbl_nama_customer.StylePriority.UseFont = False
        Me.lbl_nama_customer.Text = "lbl_nama_customer"
        '
        'lbl_alamat
        '
        Me.lbl_alamat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamat.LocationFloat = New DevExpress.Utils.PointFloat(319.7917!, 21.75!)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_alamat.SizeF = New System.Drawing.SizeF(349.2083!, 18.75!)
        Me.lbl_alamat.StylePriority.UseFont = False
        Me.lbl_alamat.Text = "XrLabel1"
        '
        'lbl_kota
        '
        Me.lbl_kota.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kota.LocationFloat = New DevExpress.Utils.PointFloat(319.7917!, 43.5!)
        Me.lbl_kota.Name = "lbl_kota"
        Me.lbl_kota.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_kota.SizeF = New System.Drawing.SizeF(349.2083!, 18.75!)
        Me.lbl_kota.StylePriority.UseFont = False
        Me.lbl_kota.Text = "XrLabel1"
        '
        'rpt_amplop
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(100, 58, 99, 83)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "11.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents lbl_alamat As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl_nama_customer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl_kota As DevExpress.XtraReports.UI.XRLabel
End Class
