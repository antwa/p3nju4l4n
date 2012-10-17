Public Class rcd_faktur_konsinyasi

    Dim mtgl_terbit As Date
    Dim mno_penjualan As String
    Dim mqty As Integer
    Dim mbruto As Integer
    Dim mmargin As Integer
    Dim macara As Integer
    Dim mtoko As Integer
    Dim mnetto As Integer
    Dim mdisc_acara_kita As Integer
    Dim mdisc_acara_toko As Integer

    Public Sub New( _
        ByVal tgl_terbit As Date, _
        ByVal no_penjualan As String, _
        ByVal qty As Integer, _
        ByVal bruto As Integer, _
        ByVal margin As Integer, _
        ByVal acara As Integer, _
        ByVal toko As Integer, _
        ByVal netto As Integer, _
        ByVal disc_acara_kita As Integer, _
        ByVal disc_acara_toko As Integer)

        Me.mtgl_terbit = tgl_terbit
        Me.mno_penjualan = no_penjualan
        Me.mqty = qty
        Me.mbruto = bruto
        Me.mmargin = margin
        Me.macara = acara
        Me.mtoko = toko
        Me.mnetto = netto
        Me.mdisc_acara_kita = disc_acara_kita
        Me.mdisc_acara_toko = disc_acara_toko
    End Sub

    Public Property tgl_terbit() As Date
        Get
            Return Me.mtgl_terbit
        End Get
        Set(ByVal value As Date)
            Me.mtgl_terbit = value
        End Set
    End Property

    Public Property no_penjualan() As String
        Get
            Return Me.mno_penjualan
        End Get
        Set(ByVal value As String)
            Me.mno_penjualan = value
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return Me.mqty
        End Get
        Set(ByVal value As Integer)
            Me.mqty = value
        End Set
    End Property

    Public Property bruto() As Integer
        Get
            Return Me.mbruto
        End Get
        Set(ByVal value As Integer)
            Me.mbruto = value
        End Set
    End Property

    Public Property margin() As Integer
        Get
            Return Me.mmargin
        End Get
        Set(ByVal value As Integer)
            Me.mmargin = value
        End Set
    End Property

    Public Property acara() As Integer
        Get
            Return Me.macara
        End Get
        Set(ByVal value As Integer)
            Me.macara = value
        End Set
    End Property

    Public Property toko() As Integer
        Get
            Return Me.mtoko
        End Get
        Set(ByVal value As Integer)
            Me.mtoko = value
        End Set
    End Property

    Public Property netto() As Integer
        Get
            Return Me.mnetto
        End Get
        Set(ByVal value As Integer)
            Me.mnetto = value
        End Set
    End Property

    Public Property disc_acara_kita() As Integer
        Get
            Return Me.mdisc_acara_kita
        End Get
        Set(ByVal value As Integer)
            Me.mdisc_acara_kita = value
        End Set
    End Property

    Public Property disc_acara_toko() As Integer
        Get
            Return Me.mdisc_acara_toko
        End Get
        Set(ByVal value As Integer)
            Me.mdisc_acara_toko = value
        End Set
    End Property


End Class

