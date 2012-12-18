Public Class rcd_sales_order

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama As String
    Dim mqty As Integer
    Dim mkode_hargajual As Integer
    Dim mharga As Integer
    Dim mtotal As Integer
    Dim mketerangan As String = " "
    Dim mstok As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal no As Integer, ByVal kode_barangjadi As String, _
                   ByVal nama As String, _
                   ByVal kode_hargajual As Integer, _
                   ByVal harga As Integer, _
                   ByVal stok As Integer)

        mno = no
        mkode_barangjadi = kode_barangjadi
        mnama = nama
        mqty = 0
        mkode_hargajual = kode_hargajual
        mharga = harga
        mketerangan = vbNullString
        mstok = stok

        Call sumary()
    End Sub

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
        End Set
    End Property

    Public Property kode_barangjadi() As String
        Get
            Return mkode_barangjadi
        End Get
        Set(ByVal value As String)
            Me.mkode_barangjadi = value
        End Set
    End Property

    Public Property nama() As String
        Get
            Return mnama
        End Get
        Set(ByVal value As String)
            Me.mnama = value
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return mqty
        End Get
        Set(ByVal value As Integer)
            If value > mstok Then
                MsgBox("Stok tidak boleh lebih besar dari stok!", MsgBoxStyle.Exclamation)
                mqty = 0
            Else
                mqty = value
            End If

            Call sumary()
        End Set
    End Property

    Public Property kode_hargajual() As Integer
        Get
            Return mkode_hargajual
        End Get
        Set(ByVal value As Integer)
            mkode_hargajual = value
        End Set
    End Property

    Public Property harga() As Integer
        Get
            Return mharga
        End Get
        Set(ByVal value As Integer)
            mharga = value
            Call sumary()
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return mtotal
        End Get
        Set(ByVal value As Integer)
            Me.mtotal = value
        End Set
    End Property

    Public Property keterangan() As String
        Get
            Return mketerangan
        End Get
        Set(ByVal value As String)
            mketerangan = value
        End Set
    End Property

    Public Property stok() As Integer
        Get
            Return mstok
        End Get
        Set(ByVal value As Integer)
            Me.mstok = value
        End Set
    End Property

    Sub sumary()
        mtotal = mharga * mqty
    End Sub

End Class
