Public Class rcd_konsinyasi_sekunder
    Dim xtotal As Integer

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama As String
    Dim mstok As Integer
    Dim mqty As Integer
    Dim mkode_hargajual As Integer
    Dim mharga As Integer
    Dim mdiskon As Integer
    Dim mtotal As Integer
    Dim mkode_hargajual2 As Integer
    Dim mharga2 As Integer
    Dim mdiskon2 As Integer
    Dim mbeban_spg As Integer
    Dim mketerangan As String

    Public Sub New( _
        ByVal no As Integer, _
        ByVal kode_barangjadi As String, _
        ByVal nama As String, _
        ByVal stok As Integer, _
        ByVal kode_hargajual As Integer, _
        ByVal harga As Integer, _
        ByVal diskon As Integer)

        Me.mno = no
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama = nama
        Me.mstok = stok
        Me.mqty = 0
        Me.mkode_hargajual = kode_hargajual
        Me.mharga = harga
        Me.mdiskon = diskon

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

    Public ReadOnly Property kode_barangjadi() As String
        Get
            Return Me.mkode_barangjadi
        End Get
    End Property

    Public ReadOnly Property nama() As String
        Get
            Return Me.mnama
        End Get
    End Property

    Public ReadOnly Property stok() As Integer
        Get
            Return Me.mstok
        End Get
    End Property

    Public Property qty() As Integer
        Get
            Return Me.mqty
        End Get
        Set(ByVal value As Integer)
            If value > Me.stok Then
                MsgBox("Qty tidak boleh lebih dari stok!", MsgBoxStyle.Exclamation)
            End If

            Me.mqty = value

            Call sumary()
        End Set
    End Property

    Public ReadOnly Property kode_hargajual() As Integer
        Get
            Return Me.mkode_hargajual
        End Get
    End Property

    Public Property harga() As Integer
        Get
            Return Me.mharga
        End Get
        Set(ByVal value As Integer)
            Me.mharga = value
            Call sumary()
        End Set
    End Property

    Public Property diskon() As Integer
        Get
            Return Me.mdiskon
        End Get
        Set(ByVal value As Integer)
            Me.mdiskon = value
            Call sumary()
        End Set
    End Property

    Public ReadOnly Property total() As Integer
        Get
            Return Me.mtotal
        End Get
    End Property

    Public Property kode_hargajual2() As Integer
        Get
            Return Me.mkode_hargajual2
        End Get
        Set(ByVal value As Integer)
            Me.mkode_hargajual2 = value
        End Set
    End Property

    Public Property harga2() As Integer
        Get
            Return Me.mharga2
        End Get
        Set(ByVal value As Integer)
            Me.mharga2 = value
        End Set
    End Property

    Public Property diskon2() As Integer
        Get
            Return Me.mdiskon2
        End Get
        Set(ByVal value As Integer)
            Me.mdiskon2 = value
        End Set
    End Property

    Public Property beban_spg() As Integer
        Get
            Return Me.mbeban_spg
        End Get
        Set(ByVal value As Integer)
            Me.mbeban_spg = value
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

    Sub sumary()
        'If mdiskon > 0 Then
        xtotal = (Me.mqty * Me.mharga)
        Me.mtotal = xtotal - (xtotal * (Me.mdiskon / 100))
        'Else
        '    Me.mtotal = (Me.mqty * Me.mharga) '* (Me.diskon / 100)
        'End If
    End Sub

End Class

