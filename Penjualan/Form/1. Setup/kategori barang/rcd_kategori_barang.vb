Public Class rcd_kategori_barang


    Dim mkode As String
    Dim mkategori As String

    Public Sub New(ByVal kode As String, ByVal kategori As String)

        Me.mkode = kode
        Me.mkategori = kategori
    End Sub

    Public ReadOnly Property kode() As String
        Get
            Return Me.mkode
        End Get
    End Property

    Public ReadOnly Property kategori() As String
        Get
            Return Me.mkategori
        End Get
    End Property


End Class



