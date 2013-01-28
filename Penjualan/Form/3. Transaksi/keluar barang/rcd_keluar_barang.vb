Public Class rcd_keluar_barang

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama_barang As String
    Dim mqty As Integer = 0
    Dim mharga_pokok As Integer
    Dim mtotal As Integer

    Public Sub New()
        Call Me.sumary()
    End Sub

    Public Sub New( _
        ByVal no As Integer, _
        ByVal kode_barangjadi As String, _
        ByVal nama_barang As String, _
        ByVal qty As Integer, _
        ByVal harga_pokok As Integer)

        Me.mno = no
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama_barang = nama_barang
        Me.mqty = qty
        Me.mharga_pokok = harga_pokok

        Call Me.sumary()
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

    Public Property qty() As Integer
        Get
            Return Me.mqty
        End Get
        Set(ByVal value As Integer)
           
            Me.mqty = value

            Call sumary()
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

    Public Property total() As Integer
        Get
            Return Me.mtotal
        End Get
        Set(ByVal value As Integer)
            Me.mtotal = value
        End Set
    End Property

    Sub sumary()
        Try
            mtotal = mqty * mharga_pokok
        Catch ex As Exception

        End Try
    End Sub

End Class

