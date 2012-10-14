Public Class rcd_penerimaanbarang

    Dim mkode_barangjadi As String
    Dim mNama As String
    Dim mQty As Integer
    Dim mKeterangan As String

    Public Sub New( _
                    ByVal kode_barangjadi As String, _
                    ByVal nama As String, _
                    ByVal qty As Integer _
                    )

        Me.mkode_barangjadi = kode_barangjadi
        Me.mNama = nama
        Me.mQty = qty
    End Sub

    Public ReadOnly Property kode_barangjadi() As String
        Get
            Return Me.mkode_barangjadi
        End Get
    End Property

    Public ReadOnly Property nama() As String
        Get
            Return Me.mNama
        End Get
    End Property

    Public Property qty() As Integer
        Get
            Return Me.mQty
        End Get
        Set(ByVal value As Integer)
            Me.mQty = value
        End Set
    End Property

    Public Property keterangan() As String
        Get
            Return Me.mKeterangan
        End Get
        Set(ByVal value As String)
            Me.mKeterangan = value
        End Set
    End Property

End Class
