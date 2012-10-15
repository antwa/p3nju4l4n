Public Class rcd_surat_jalan

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama As String
    Dim mqty As Integer
    Dim mkode_hargajual As Integer
    Dim mharga As Integer
    Dim mtotal As Integer
    Dim mketerangan As String

    Public Sub New( _
        ByVal no As Integer, _
        ByVal kode_barangjadi As String, _
        ByVal nama As String, _
        ByVal qty As Integer, _
        ByVal kode_hargajual As Integer, _
        ByVal harga As Integer)

        Me.mno = no
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama = nama
        Me.mqty = qty
        Me.mkode_hargajual = kode_hargajual
        Me.mharga = harga
        Me.mketerangan = vbNullString

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

    Public ReadOnly Property qty() As Integer
        Get
            Return Me.mqty
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

    Public ReadOnly Property total() As Integer
        Get
            Return Me.mtotal
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

    Sub sumary()
        Me.mtotal = Me.mqty * Me.mharga
    End Sub

End Class

