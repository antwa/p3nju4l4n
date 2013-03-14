Public Class rcd_margin_customer

    Dim mid As Integer
    Dim mtanggal As datetime
    Dim mkode_customer_child As String
    Dim mnama_customer As String
    Dim msebelum_disc_acara As String
    Dim mdisc_acara As Integer
    Dim mdisc_acara_kita As Integer
    Dim mdisc_acara_toko As Integer
    Dim mmargin_toko As Integer
    Dim mmargin_konsumen As Integer

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal id As Integer, _
        ByVal tanggal As DateTime, _
        ByVal kode_customer_child As String, _
        ByVal nama_customer As String, _
        ByVal sebelum_disc_acara As String, _
        ByVal disc_acara As Integer, _
        ByVal disc_acara_kita As Integer, _
        ByVal disc_acara_toko As Integer, _
        ByVal margin_toko As Integer, _
        ByVal margin_konsumen As Integer)

        Me.mid = id
        Me.mtanggal = tanggal
        Me.mkode_customer_child = kode_customer_child
        Me.mnama_customer = nama_customer
        Me.msebelum_disc_acara = sebelum_disc_acara
        Me.mdisc_acara = disc_acara
        Me.mdisc_acara_kita = disc_acara_kita
        Me.mdisc_acara_toko = disc_acara_toko
        Me.mmargin_toko = margin_toko
        Me.mmargin_konsumen = margin_konsumen
    End Sub

    Public Property id() As Integer
        Get
            Return Me.mid
        End Get
        Set(ByVal value As Integer)
            Me.mid = value
        End Set
    End Property

    Public Property tanggal() As DateTime
        Get
            Return Me.mtanggal
        End Get
        Set(ByVal value As DateTime)
            Me.mtanggal = value
        End Set
    End Property

    Public Property kode_customer_child() As String
        Get
            Return Me.mkode_customer_child
        End Get
        Set(ByVal value As String)
            Me.mkode_customer_child = value
        End Set
    End Property

    Public Property nama_customer() As String
        Get
            Return Me.mnama_customer
        End Get
        Set(ByVal value As String)
            Me.mnama_customer = value
        End Set
    End Property

    Public Property sebelum_disc_acara() As String
        Get
            Return Me.msebelum_disc_acara
        End Get
        Set(ByVal value As String)
            Me.msebelum_disc_acara = value
        End Set
    End Property

    Public Property disc_acara() As Integer
        Get
            Return Me.mdisc_acara
        End Get
        Set(ByVal value As Integer)
            Me.mdisc_acara = value
            Try
                mdisc_acara_kita = mdisc_acara / 2
                mdisc_acara_toko = mdisc_acara - mdisc_acara_kita
            Catch ex As Exception

            End Try

        End Set
    End Property

    Public Property disc_acara_kita() As Integer
        Get
            Return Me.mdisc_acara_kita
        End Get
        Set(ByVal value As Integer)
            Me.mdisc_acara_kita = value
            Try
                If mdisc_acara_kita > mdisc_acara Then
                    'MsgBox("Disc acara tidak boleh lebih kecil", MsgBoxStyle.Exclamation)
                    mdisc_acara_kita = mdisc_acara
                End If

                mdisc_acara_toko = mdisc_acara - mdisc_acara_kita

            Catch ex As Exception

            End Try

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

    Public Property margin_toko() As Integer
        Get
            Return Me.mmargin_toko
        End Get
        Set(ByVal value As Integer)
            Me.mmargin_toko = value
        End Set
    End Property

    Public Property margin_konsumen() As Integer
        Get
            Return Me.mmargin_konsumen
        End Get
        Set(ByVal value As Integer)
            Me.mmargin_konsumen = value
        End Set
    End Property


End Class

