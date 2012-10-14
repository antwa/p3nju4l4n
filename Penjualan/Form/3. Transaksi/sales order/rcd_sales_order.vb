Public Class rcd_sales_order

    Dim mkode_barangjadi As String
    Dim mnama As String
    Dim mqty As Integer
    Dim mkode_hargajual As Integer
    Dim mharga As Integer
    Dim mtotal As Integer
    Dim mketerangan As String
    Dim mstok As Integer

    Public Sub New(ByVal kode_barangjadi As String, _
                   ByVal nama As String, _
                   ByVal kode_hargajual As Integer, _
                   ByVal harga As Integer, _
                   ByVal stok As Integer)

        mkode_barangjadi = kode_barangjadi
        mnama = nama
        mqty = 0
        mkode_hargajual = kode_hargajual
        mharga = harga
        mketerangan = vbNullString
        mstok = stok

        Call sumary()
    End Sub

    Public ReadOnly Property kode_barangjadi() As String
        Get
            Return mkode_barangjadi
        End Get
    End Property

    Public ReadOnly Property nama() As String
        Get
            Return mnama
        End Get
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

    Public ReadOnly Property kode_hargajual() As Integer
        Get
            Return mkode_hargajual
        End Get
    End Property

    Public ReadOnly Property harga() As Integer
        Get
            Return mharga
        End Get
    End Property

    Public ReadOnly Property total() As Integer
        Get
            Return mtotal
        End Get
    End Property

    Public Property keterangan() As String
        Get
            Return mketerangan
        End Get
        Set(ByVal value As String)
            mketerangan = value
        End Set
    End Property

    Public ReadOnly Property stok() As Integer
        Get
            Return mstok
        End Get
    End Property

    Sub sumary()
        mtotal = mharga * mqty
    End Sub

End Class
