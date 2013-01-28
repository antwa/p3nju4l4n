Public Class rcd_memo_pengeluaran

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama_barang As String
    Dim mstok As Integer
    Dim mqty As Integer = 0
    Dim mharga_pokok As Integer

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal no As Integer, _
        ByVal kode_barangjadi As String, _
        ByVal nama_barang As String, _
        ByVal stok As Integer, _
        ByVal harga_pokok As Integer)

        Me.mno = no
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama_barang = nama_barang
        Me.mstok = stok
        Me.mharga_pokok = harga_pokok
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
            Return Me.mkode_barangjadi
        End Get
        Set(ByVal value As String)
            Me.mkode_barangjadi = value
        End Set
    End Property

    Public Property nama_barang() As String
        Get
            Return Me.mnama_barang
        End Get
        Set(ByVal value As String)
            Me.mnama_barang = value
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

    Public Property qty() As Integer
        Get
            Return Me.mqty
        End Get
        Set(ByVal value As Integer)
            If value > Me.mstok Then
                Me.mqty = 0
                MsgBox("Qty tidak boleh lebih dari stok gudang!", MsgBoxStyle.Exclamation)
            Else
                Me.mqty = value
            End If
        End Set
    End Property

    Public Property harga_pokok() As Integer
        Get
            Return Me.mharga_pokok
        End Get
        Set(ByVal value As Integer)
            Me.mharga_pokok = value
        End Set
    End Property


End Class

