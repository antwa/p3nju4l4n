Public Class rcd_histori_harga_add

    Dim mkode_customer As String
    Dim mnama_custumer As String
    Dim mchecked As Boolean

    Public Sub New( _
        ByVal kode_customer As String, _
        ByVal nama_custumer As String, _
        ByVal checked As Boolean)

        Me.mkode_customer = kode_customer
        Me.mnama_custumer = nama_custumer
        Me.mchecked = checked
    End Sub

    Public Property kode_customer() As String
        Get
            Return Me.mkode_customer
        End Get
        Set(ByVal value As String)
            Me.mkode_customer = value
        End Set
    End Property

    Public Property nama_custumer() As String
        Get
            Return Me.mnama_custumer
        End Get
        Set(ByVal value As String)
            Me.mnama_custumer = value
        End Set
    End Property

    Public Property checked() As Boolean
        Get
            Return Me.mchecked
        End Get
        Set(ByVal value As Boolean)
            Me.mchecked = value
        End Set
    End Property


End Class

