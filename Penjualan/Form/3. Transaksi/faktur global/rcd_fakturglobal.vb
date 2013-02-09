Public Class rcd_fakturglobal

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama_barangjadi As String
    Dim mqty As Integer
    Dim mharga As Double
    Dim mtotal As Double

    Public Sub New( _
        ByVal no As Integer, _
        ByVal kode_barangjadi As String, _
        ByVal nama_barangjadi As String, _
        ByVal qty As Integer, _
        ByVal harga As Double)

        Me.mno = no
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama_barangjadi = nama_barangjadi
        Me.mqty = qty
        Me.mharga = harga

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

    Public Property nama_barangjadi() As String
        Get
            Return Me.mnama_barangjadi
        End Get
        Set(ByVal value As String)
            Me.mnama_barangjadi = value
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

    Public Property harga() As Double
        Get
            Return Me.mharga
        End Get
        Set(ByVal value As Double)
            Me.mharga = value
        End Set
    End Property

    Public Property total() As Double
        Get
            Return Me.mtotal
        End Get
        Set(ByVal value As Double)
            Me.mtotal = value
        End Set
    End Property

    Public Sub sumary()
        Try
            Me.mtotal = Me.mqty * Me.mharga
        Catch ex As Exception

        End Try
    End Sub

End Class

