Public Class rcd_barangjadi_edit_formula

    Dim mkode_hargajual As Integer
    Dim mkode_template_harga As Integer
    Dim mnama_harga As String
    Dim mharga As Integer

    Public Sub New( _
        ByVal kode_hargajual As Integer, _
        ByVal kode_template_harga As Integer, _
        ByVal nama_harga As String, _
        ByVal harga As Integer)

        Me.mkode_hargajual = kode_hargajual
        Me.mkode_template_harga = kode_template_harga
        Me.mnama_harga = nama_harga
        Me.mharga = harga
    End Sub

    Public Property kode_hargajual() As Integer
        Get
            Return Me.mkode_hargajual
        End Get
        Set(ByVal value As Integer)
            Me.mkode_hargajual = value
        End Set
    End Property

    Public Property kode_template_harga() As Integer
        Get
            Return Me.mkode_template_harga
        End Get
        Set(ByVal value As Integer)
            Me.mkode_template_harga = value
        End Set
    End Property

    Public Property nama_harga() As String
        Get
            Return Me.mnama_harga
        End Get
        Set(ByVal value As String)
            Me.mnama_harga = value
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


End Class

