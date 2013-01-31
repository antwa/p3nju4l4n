Public Class rcd_rekap_gaji

    Dim mno As Integer
    Dim mtgl_input As datetime
    Dim mnama_toko As String
    Dim mnama_spg As String
    Dim mt_hadir As Integer
    Dim mt_lembur As Integer
    Dim mt_hari_besar As Integer
    Dim mt_bonus As Integer
    Dim mt_insentif As Integer
    Dim mt_pengembalian_jaminan As Integer
    Dim mt_potongan As Integer
    Dim mt_jaminan_kerja As Integer
    Dim mt_total As Integer

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal no As Integer, _
        ByVal tgl_input As datetime, _
        ByVal nama_toko As String, _
        ByVal nama_spg As String, _
        ByVal t_hadir As Integer, _
        ByVal t_lembur As Integer, _
        ByVal t_hari_besar As Integer, _
        ByVal t_bonus As Integer, _
        ByVal t_insentif As Integer, _
        ByVal t_pengembalian_jaminan As Integer, _
        ByVal t_potongan As Integer, _
        ByVal t_jaminan_kerja As Integer, _
        ByVal t_total As Integer)

        Me.mno = no
        Me.mtgl_input = tgl_input
        Me.mnama_toko = nama_toko
        Me.mnama_spg = nama_spg
        Me.mt_hadir = t_hadir
        Me.mt_lembur = t_lembur
        Me.mt_hari_besar = t_hari_besar
        Me.mt_bonus = t_bonus
        Me.mt_insentif = t_insentif
        Me.mt_pengembalian_jaminan = t_pengembalian_jaminan
        Me.mt_potongan = t_potongan
        Me.mt_jaminan_kerja = t_jaminan_kerja
        Me.mt_total = t_total
    End Sub

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
        End Set
    End Property

    Public Property tgl_input() As datetime
        Get
            Return Me.mtgl_input
        End Get
        Set(ByVal value As datetime)
            Me.mtgl_input = value
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

    Public Property t_hadir() As Integer
        Get
            Return Me.mt_hadir
        End Get
        Set(ByVal value As Integer)
            Me.mt_hadir = value
        End Set
    End Property

    Public Property t_lembur() As Integer
        Get
            Return Me.mt_lembur
        End Get
        Set(ByVal value As Integer)
            Me.mt_lembur = value
        End Set
    End Property

    Public Property t_hari_besar() As Integer
        Get
            Return Me.mt_hari_besar
        End Get
        Set(ByVal value As Integer)
            Me.mt_hari_besar = value
        End Set
    End Property

    Public Property t_bonus() As Integer
        Get
            Return Me.mt_bonus
        End Get
        Set(ByVal value As Integer)
            Me.mt_bonus = value
        End Set
    End Property

    Public Property t_insentif() As Integer
        Get
            Return Me.mt_insentif
        End Get
        Set(ByVal value As Integer)
            Me.mt_insentif = value
        End Set
    End Property

    Public Property t_pengembalian_jaminan() As Integer
        Get
            Return Me.mt_pengembalian_jaminan
        End Get
        Set(ByVal value As Integer)
            Me.mt_pengembalian_jaminan = value
        End Set
    End Property

    Public Property t_potongan() As Integer
        Get
            Return Me.mt_potongan
        End Get
        Set(ByVal value As Integer)
            Me.mt_potongan = value
        End Set
    End Property

    Public Property t_jaminan_kerja() As Integer
        Get
            Return Me.mt_jaminan_kerja
        End Get
        Set(ByVal value As Integer)
            Me.mt_jaminan_kerja = value
        End Set
    End Property

    Public Property t_total() As Integer
        Get
            Return Me.mt_total
        End Get
        Set(ByVal value As Integer)
            Me.mt_total = value
        End Set
    End Property


End Class

