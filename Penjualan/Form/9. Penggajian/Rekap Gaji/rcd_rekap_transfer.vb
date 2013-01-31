Public Class rcd_rekap_transfer

    Dim mno As Integer
    Dim mnama_toko As String
    Dim mnama_spg As String
    Dim mtotal As Integer
    Dim mnama_bank As String
    Dim mno_rekening As String
    Dim matas_nama As String
    Dim mtgl_transfer As String

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal no As Integer, _
        ByVal nama_toko As String, _
        ByVal nama_spg As String, _
        ByVal total As Integer, _
        ByVal nama_bank As String, _
        ByVal no_rekening As String, _
        ByVal atas_nama As String, _
        ByVal tgl_transfer As String)

        Me.mno = no
        Me.mnama_toko = nama_toko
        Me.mnama_spg = nama_spg
        Me.mtotal = total
        Me.mnama_bank = nama_bank
        Me.mno_rekening = no_rekening
        Me.matas_nama = atas_nama
        Me.mtgl_transfer = tgl_transfer
    End Sub

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
        End Set
    End Property

    Public Property nama_toko() As String
        Get
            Return Me.mnama_toko
        End Get
        Set(ByVal value As String)
            Me.mnama_toko = value
        End Set
    End Property

    Public Property nama_spg() As String
        Get
            Return Me.mnama_spg
        End Get
        Set(ByVal value As String)
            Me.mnama_spg = value
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

    Public Property nama_bank() As String
        Get
            Return Me.mnama_bank
        End Get
        Set(ByVal value As String)
            Me.mnama_bank = value
        End Set
    End Property

    Public Property no_rekening() As String
        Get
            Return Me.mno_rekening
        End Get
        Set(ByVal value As String)
            Me.mno_rekening = value
        End Set
    End Property

    Public Property atas_nama() As String
        Get
            Return Me.matas_nama
        End Get
        Set(ByVal value As String)
            Me.matas_nama = value
        End Set
    End Property

    Public Property tgl_transfer() As String
        Get
            Return Me.mtgl_transfer
        End Get
        Set(ByVal value As String)
            Me.mtgl_transfer = value
        End Set
    End Property


End Class

