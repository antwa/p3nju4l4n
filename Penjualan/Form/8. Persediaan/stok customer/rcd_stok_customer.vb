Public Class rcd_stok_customer

    Dim mid As Integer
    Dim mkode_customer As String
    Dim mnama_customer As String
    Dim mkode_barangjadi As String
    Dim mnama_barangjadi As String
    Dim mstok_sekunder As Integer
    Dim mstok_primier As Integer
    Dim mkode_jenis_barang As Integer

    Public Sub New( _
        ByVal id As Integer, _
        ByVal kode_customer As String, _
        ByVal nama_customer As String, _
        ByVal kode_barangjadi As String, _
        ByVal nama_barangjadi As String, _
        ByVal stok_sekunder As Integer, _
        ByVal stok_primier As Integer, _
        ByVal kode_jenis_barang As Integer)

        Me.mid = id
        Me.mkode_customer = kode_customer
        Me.mnama_customer = nama_customer
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama_barangjadi = nama_barangjadi
        Me.mstok_sekunder = stok_sekunder
        Me.mstok_primier = stok_primier
        Me.mkode_jenis_barang = kode_jenis_barang
    End Sub

    Public Property id() As Integer
        Get
            Return Me.mid
        End Get
        Set(ByVal value As Integer)
            Me.mid = value
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

    Public Property kode_barangjadi() As String
        Get
            Return Me.mkode_barangjadi
        End Get
        Set(ByVal value As String)
            Me.mkode_barangjadi = value
        End Set
    End Property

    Public Property nama_barangjadi() As String
        Get
            Return Me.mnama_barangjadi
        End Get
        Set(ByVal value As String)
            Me.mnama_barangjadi = value
        End Set
    End Property

    Public Property stok_sekunder() As Integer
        Get
            Return Me.mstok_sekunder
        End Get
        Set(ByVal value As Integer)
            Me.mstok_sekunder = value
        End Set
    End Property

    Public Property stok_primier() As Integer
        Get
            Return Me.mstok_primier
        End Get
        Set(ByVal value As Integer)
            Me.mstok_primier = value
        End Set
    End Property

    Public Property kode_jenis_barang() As Integer
        Get
            Return Me.mkode_jenis_barang
        End Get
        Set(ByVal value As Integer)
            Me.mkode_jenis_barang = value
        End Set
    End Property


End Class

