Public Class rcd_penerimaan_kas

    Dim mno As Integer
    Dim mreferensi As String
    Dim mtgl_terbit As Date
    Dim mtgl_jatuh_tempo As Date
    Dim mnominal As Double
    Dim mcheked As Boolean
    Dim mketerangan As String

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal no As Integer, _
        ByVal referensi As String, _
        ByVal tgl_terbit As Date, _
        ByVal tgl_jatuh_tempo As Date, _
        ByVal nominal As Double, _
        ByVal cheked As Boolean, _
        ByVal keterangan As String)

        Me.mno = no
        Me.mreferensi = referensi
        Me.mtgl_terbit = tgl_terbit
        Me.mtgl_jatuh_tempo = tgl_jatuh_tempo
        Me.mnominal = nominal
        Me.mcheked = cheked
        Me.mketerangan = keterangan
    End Sub

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
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

    Public Property tgl_terbit() As Date
        Get
            Return Me.mtgl_terbit
        End Get
        Set(ByVal value As Date)
            Me.mtgl_terbit = value
        End Set
    End Property

    Public Property tgl_jatuh_tempo() As Date
        Get
            Return Me.mtgl_jatuh_tempo
        End Get
        Set(ByVal value As Date)
            Me.mtgl_jatuh_tempo = value
        End Set
    End Property

    Public Property nominal() As Double
        Get
            Return Me.mnominal
        End Get
        Set(ByVal value As Double)
            Me.mnominal = value
        End Set
    End Property

    Public Property cheked() As Boolean
        Get
            Return Me.mcheked
        End Get
        Set(ByVal value As Boolean)
            Me.mcheked = value
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


End Class

