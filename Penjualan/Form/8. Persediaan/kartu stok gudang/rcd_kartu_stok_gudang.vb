Public Class rcd_kartu_stok_gudang

    Dim mno As Integer
    Dim mtanggal As Date
    Dim mreferensi As String
    Dim mdeskripsi As String
    Dim mmasuk As Integer
    Dim mkeluar As Integer
    Dim msaldo As Integer

    Public Sub New( _
        ByVal no As Integer, _
        ByVal tanggal As Date, _
        ByVal referensi As String, _
        ByVal deskripsi As String, _
        ByVal masuk As Integer, _
        ByVal keluar As Integer, _
        ByVal saldo As Integer)

        Me.mno = no
        Me.mtanggal = tanggal
        Me.mreferensi = referensi
        Me.mdeskripsi = deskripsi
        Me.mmasuk = masuk
        Me.mkeluar = keluar
        Me.msaldo = saldo
    End Sub

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
        End Set
    End Property

    Public Property tanggal() As Date
        Get
            Return Me.mtanggal
        End Get
        Set(ByVal value As Date)
            Me.mtanggal = value
        End Set
    End Property

    Public Property referensi() As String
        Get
            Return Me.mreferensi
        End Get
        Set(ByVal value As String)
            Me.mreferensi = value
        End Set
    End Property

    Public Property deskripsi() As String
        Get
            Return Me.mdeskripsi
        End Get
        Set(ByVal value As String)
            Me.mdeskripsi = value
        End Set
    End Property

    Public Property masuk() As Integer
        Get
            Return Me.mmasuk
        End Get
        Set(ByVal value As Integer)
            Me.mmasuk = value
        End Set
    End Property

    Public Property keluar() As Integer
        Get
            Return Me.mkeluar
        End Get
        Set(ByVal value As Integer)
            Me.mkeluar = value
        End Set
    End Property

    Public Property saldo() As Integer
        Get
            Return Me.msaldo
        End Get
        Set(ByVal value As Integer)
            Me.msaldo = value
        End Set
    End Property


End Class

