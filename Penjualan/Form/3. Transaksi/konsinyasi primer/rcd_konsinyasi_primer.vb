Public Class rcd_konsinyasi_primer

    Dim mno As Integer
    Dim mtgl_transaksi As DateTime = Now
    Dim mkelompok As Integer
    Dim mkelompok_desk As String
    Dim mkode_barangjadi As String
    Dim mnama As String
    Dim mstok As Integer
    Dim mqty As Integer = 0
    Dim mharga As Integer = 0
    Dim mdiskon As Integer = 0
    Dim mtotal As Integer = 0
    Dim mharga2 As Integer = 0
    Dim mdiskon2 As Integer = 0
    Dim mbruto As Integer = 0
    Dim mmargin As Integer = 0
    Dim macara As Integer = 0
    Dim mtoko As Integer = 0
    Dim mnetto As Integer = 0
    Dim msebelum_disc_acara As Boolean
    Dim mdisc_acara As Integer = 0
    Dim mdisc_acara_kita As Integer = 0
    Dim mdisc_acara_toko As Integer = 0
    Dim mmargin_toko As Integer = 0
    Dim mmargin_konsumen As Integer = 0

    Dim xtotal As Integer

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal tgl_transaksi As Date, _
        ByVal kode_barangjadi As String, _
        ByVal nama As String, _
        ByVal qty As Integer, _
        ByVal harga As Integer, _
        ByVal diskon As Integer, _
        ByVal harga2 As Integer, _
        ByVal diskon2 As Integer)

        Me.mtgl_transaksi = tgl_transaksi
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama = nama
        Me.mqty = qty
        Me.mharga = harga
        Me.mdiskon = diskon
        Me.mharga2 = harga2
        Me.mdiskon2 = diskon2

        'Call Sumary()
    End Sub

    Public Property no() As Integer
        Get
            Return Me.mno
        End Get
        Set(ByVal value As Integer)
            Me.mno = value
        End Set
    End Property

    Public Property tgl_transaksi() As Date
        Get
            Return Me.mtgl_transaksi
        End Get
        Set(ByVal value As Date)
            Me.mtgl_transaksi = value
        End Set
    End Property

    Public Property kelompok() As Integer
        Get
            Return Me.mkelompok
        End Get
        Set(ByVal value As Integer)
            Me.mkelompok = value
        End Set
    End Property

    Public Property kelompok_desk() As String
        Get
            Return Me.mkelompok_desk
        End Get
        Set(ByVal value As String)
            Me.mkelompok_desk = value
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

    Public Property nama() As String
        Get
            Return Me.mnama
        End Get
        Set(ByVal value As String)
            Me.mnama = value
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
            Me.mqty = value

            Call Sumary()
        End Set
    End Property

    Public Property harga() As Integer
        Get
            Return Me.mharga
        End Get
        Set(ByVal value As Integer)
            Me.mharga = value

            Call Sumary()
        End Set
    End Property

    Public Property diskon() As Integer
        Get
            Return Me.mdiskon
        End Get
        Set(ByVal value As Integer)
            Me.mdiskon = value

            Call Sumary()
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

    Public Property sebelum_disc_acara() As Boolean
        Get
            Return Me.msebelum_disc_acara
        End Get
        Set(ByVal value As Boolean)
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
            Call Sumary()
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
            Call Sumary()
        End Set
    End Property

    Public Property disc_acara_toko() As Integer
        Get
            Return Me.mdisc_acara_toko
        End Get
        Set(ByVal value As Integer)
            Me.mdisc_acara_toko = value
            Call Sumary()
        End Set
    End Property

    Public Property margin_toko() As Integer
        Get
            Return Me.mmargin_toko
        End Get
        Set(ByVal value As Integer)
            Me.mmargin_toko = value
            Call Sumary()
        End Set
    End Property

    Public Property margin_konsumen() As Integer
        Get
            Return Me.mmargin_konsumen
        End Get
        Set(ByVal value As Integer)
            Me.mmargin_konsumen = value
            Call Sumary()
        End Set
    End Property

    Public Sub Sumary()
        Try
            'If mdiskon > 0 Then
            xtotal = (Me.mqty * Me.mharga)
            Me.mtotal = xtotal - (xtotal * (Me.mdiskon / 100))
            'Else
            '    Me.mtotal = (Me.mqty * Me.mharga) '* (Me.diskon / 100)
            'End If

            mbruto = mtotal '* mqty

            macara = (mdisc_acara / 100) * mbruto

            If msebelum_disc_acara = True Then
                mmargin = mbruto * (mmargin_toko / 100)
            Else
                mmargin = (mbruto - macara) * (mmargin_toko / 100)
            End If

            mtoko = mbruto * (mdisc_acara_toko / 100)
            mnetto = mbruto - mmargin - mtoko

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

End Class

