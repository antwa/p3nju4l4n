Public Class rcd_delivery_order_banyak

    Dim mno_so As String
    Dim mno_do As String
    Dim mkode_customer_child As String
    Dim mnama As String
    Dim mkode_barangjadi As String
    Dim mjml_so As Integer
    Dim mjml_do As Integer
    Dim mstok As Integer
    Dim mkode_hargajual As String
    Dim mharga As Integer
    Dim mketerangan As String
    Dim mterkirim As Integer

    Public Sub New( _
        ByVal no_so As String, _
        ByVal no_do As String, _
        ByVal kode_customer_child As String, _
        ByVal nama As String, _
        ByVal kode_barangjadi As String, _
        ByVal jml_so As Integer, _
        ByVal jml_do As Integer, _
        ByVal stok As Integer, _
        ByVal kode_hargajual As Integer, _
        ByVal harga As Integer, _
        ByVal keterangan As String, _
        ByVal terkirim As Integer)

        Me.mno_so = no_so
        Me.mno_do = no_do
        Me.mkode_customer_child = kode_customer_child
        Me.mnama = nama
        Me.mkode_barangjadi = kode_barangjadi
        Me.mjml_so = jml_so
        Me.mjml_do = jml_do
        Me.mstok = stok
        Me.mkode_hargajual = kode_hargajual
        Me.mharga = harga
        Me.mketerangan = keterangan
        Me.mterkirim = terkirim
    End Sub

    Public Property no_so() As String
        Get
            Return Me.mno_so
        End Get
        Set(ByVal value As String)
            Me.mno_so = value
        End Set
    End Property

    Public Property no_do() As String
        Get
            Return Me.mno_do
        End Get
        Set(ByVal value As String)
            Me.mno_do = value
        End Set
    End Property

    Public Property kode_customer_child() As String
        Get
            Return Me.mkode_customer_child
        End Get
        Set(ByVal value As String)
            Me.mkode_customer_child = value
        End Set
    End Property

    Public Property nama() As String
        Get
            Return Me.mnama
        End Get
        Set(ByVal value As String)
            Me.mnama = value
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

    Public Property jml_so() As Integer
        Get
            Return Me.mjml_so
        End Get
        Set(ByVal value As Integer)
            Me.mjml_so = value
        End Set
    End Property

    Public Property jml_do() As Integer
        Get
            Return Me.mjml_do
        End Get
        Set(ByVal value As Integer)
            Me.mjml_do = value
        End Set
    End Property

    Public Property stok() As Integer
        Get
            Return Me.mstok
        End Get
        Set(ByVal value As Integer)
            Me.mstok = value
        End Set
    End Property


    Public Property kode_hargajual() As String
        Get
            Return Me.mkode_hargajual
        End Get
        Set(ByVal value As String)
            Me.mkode_hargajual = value
        End Set
    End Property

    Public Property harga() As Integer
        Get
            Return Me.mharga
        End Get
        Set(ByVal value As Integer)
            Me.mharga = value
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

    Public Property terkirim() As Integer
        Get
            Return Me.mterkirim
        End Get
        Set(ByVal value As Integer)
            Me.mterkirim = value
        End Set
    End Property

End Class

