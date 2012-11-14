Public Class rcd_retur_jual_putus

    Dim mno As Integer
    Dim mno_faktur As String
    Dim mkode_barangjadi As String
    Dim mharga As Integer
    Dim mjml_retur As Integer
    Dim mtotal As Integer
    Dim mketerangan As String

    Public Sub New( _
        ByVal no As Integer, _
        ByVal no_faktur As String, _
        ByVal kode_barangjadi As String, _
        ByVal harga As Integer, _
        ByVal jml_retur As Integer, _
        ByVal total As Integer, _
        ByVal keterangan As String)

        Me.mno = no
        Me.mno_faktur = no_faktur
        Me.mkode_barangjadi = kode_barangjadi
        Me.mharga = harga
        Me.mjml_retur = jml_retur
        Me.mtotal = total
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

    Public Property no_faktur() As String
        Get
            Return Me.mno_faktur
        End Get
        Set(ByVal value As String)
            Me.mno_faktur = value
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

    Public Property harga() As Integer
        Get
            Return Me.mharga
        End Get
        Set(ByVal value As Integer)
            Me.mharga = value
        End Set
    End Property

    Public Property jml_retur() As Integer
        Get
            Return Me.mjml_retur
        End Get
        Set(ByVal value As Integer)
            Me.mjml_retur = value

            Call Me.sumary()
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

    Public Property keterangan() As String
        Get
            Return Me.mketerangan
        End Get
        Set(ByVal value As String)
            Me.mketerangan = value
        End Set
    End Property

    Public Sub sumary()
        Try
            total = mjml_retur * mharga
        Catch ex As Exception

        End Try
    End Sub

End Class

