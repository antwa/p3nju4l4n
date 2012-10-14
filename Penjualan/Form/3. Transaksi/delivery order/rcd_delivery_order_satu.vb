Public Class rcd_delivery_order_satu

    Dim mkode_barangjadi As String
    Dim mqty_so As Integer
    Dim mqty_do As Integer
    Dim mstok As Integer
    Dim mkode_hargajual As Integer
    Dim mharga As Integer
    Dim mketerangan As String
    Dim mTerkirim As Integer

    Public Sub New( _
        ByVal kode_barangjadi As String, _
        ByVal qty_so As Integer, _
        ByVal qty_do As Integer, _
        ByVal stok As Integer, _
        ByVal kode_hargajual As Integer, _
        ByVal harga As Integer, _
        ByVal terkirim As Integer)

        Me.mkode_barangjadi = kode_barangjadi
        Me.mqty_so = qty_so
        Me.mqty_do = qty_do
        Me.mstok = stok
        Me.mkode_hargajual = kode_hargajual
        Me.mharga = harga
        Me.mTerkirim = terkirim
        Me.mketerangan = vbNullString
    End Sub

    Public ReadOnly Property kode_barangjadi() As String
        Get
            Return Me.mkode_barangjadi
        End Get
    End Property

    Public ReadOnly Property qty_so() As Integer
        Get
            Return Me.mqty_so
        End Get
    End Property

    Public Property qty_do() As Integer
        Get
            Return Me.mqty_do
        End Get
        Set(ByVal value As Integer)
            Me.mqty_do = value
        End Set
    End Property

    Public ReadOnly Property stok() As Integer
        Get
            Return Me.mstok
        End Get
    End Property

    Public ReadOnly Property kode_hargajual() As Integer
        Get
            Return Me.mkode_hargajual
        End Get
    End Property

    Public ReadOnly Property harga() As Integer
        Get
            Return Me.mharga
        End Get
    End Property

    Public Property keterangan() As String
        Get
            Return Me.mketerangan
        End Get
        Set(ByVal value As String)
            Me.mketerangan = value
        End Set
    End Property

    Public ReadOnly Property terkirim() As Integer
        Get
            Return Me.mTerkirim
        End Get
    End Property

End Class

