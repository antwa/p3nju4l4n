Public Class rcd_targetpenjualan_perbulan

    Dim mid As Integer = 0
    Dim mno As Integer
    Dim mkode_customer As String
    Dim mnama_customer As String
    Dim mjml_pcs_lalu As Integer
    Dim mjml_rupiah_lalu As Double
    Dim mpersentase As Integer
    Dim mjml_pcs As Integer
    Dim mjml_rupiah As Double
    Dim mketerangan As String

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal id As Integer, _
        ByVal no As Integer, _
        ByVal kode_customer As String, _
        ByVal nama_customer As String, _
        ByVal jml_pcs_lalu As Integer, _
        ByVal jml_rupiah_lalu As Double, _
        ByVal persentase As Integer, _
        ByVal jml_pcs As Integer, _
        ByVal jml_rupiah As Double, _
        ByVal keterangan As String)

        Me.mid = id
        Me.mno = no
        Me.mkode_customer = kode_customer
        Me.mnama_customer = nama_customer
        Me.mjml_pcs_lalu = jml_pcs_lalu
        Me.mjml_rupiah_lalu = jml_rupiah_lalu
        Me.mpersentase = persentase
        Me.mjml_pcs = jml_pcs
        Me.mjml_rupiah = jml_rupiah
        Me.mketerangan = keterangan
    End Sub

    Public Property id() As Integer
        Get
            Return Me.mid
        End Get
        Set(ByVal value As Integer)
            Me.mid = value
        End Set
    End Property

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
        End Set
    End Property

    Public Property kode_customer() As String
        Get
            Return Me.mkode_customer
        End Get
        Set(ByVal value As String)
            Me.mkode_customer = value
        End Set
    End Property

    Public Property nama_customer() As String
        Get
            Return Me.mnama_customer
        End Get
        Set(ByVal value As String)
            Me.mnama_customer = value
        End Set
    End Property

    Public Property jml_pcs_lalu() As Integer
        Get
            Return Me.mjml_pcs_lalu
        End Get
        Set(ByVal value As Integer)
            Me.mjml_pcs_lalu = value
        End Set
    End Property

    Public Property jml_rupiah_lalu() As Double
        Get
            Return Me.mjml_rupiah_lalu
        End Get
        Set(ByVal value As Double)
            Me.mjml_rupiah_lalu = value
        End Set
    End Property

    Public Property persentase() As Integer
        Get
            Return Me.mpersentase
        End Get
        Set(ByVal value As Integer)
            Me.mpersentase = value
        End Set
    End Property

    Public Property jml_pcs() As Integer
        Get
            Return Me.mjml_pcs
        End Get
        Set(ByVal value As Integer)
            Me.mjml_pcs = value
        End Set
    End Property

    Public Property jml_rupiah() As Double
        Get
            Return Me.mjml_rupiah
        End Get
        Set(ByVal value As Double)
            Me.mjml_rupiah = value
        End Set
    End Property

    Public Property keterangan() As String
        Get
            Return Me.mketerangan
        End Get
        Set(ByVal value As String)
            Me.mketerangan = value
        End Set
    End Property


End Class

