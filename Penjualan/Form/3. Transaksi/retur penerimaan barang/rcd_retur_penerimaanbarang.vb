Public Class rcd_retur_penerimaanbarang

    Dim mkode_barangjadi As String
    Dim mNama As String
    Dim mQty_terima As Integer
    Dim mHarga_beli As Integer
    Dim mQty As Integer
    Dim mValue_retur As Integer
    Dim mKeterangan As String

    Public Sub New(ByVal kode_barangjadi As String, ByVal nama As String, ByVal qty_terima As Integer, ByVal harga_beli As Integer)
        Me.mkode_barangjadi = kode_barangjadi
        Me.mNama = nama
        Me.mQty_terima = qty_terima
        Me.mHarga_beli = harga_beli
        Me.mQty = 0
        Me.mValue_retur = 0

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

    Public ReadOnly Property qty_terima() As Integer
        Get
            Return Me.mQty_terima
        End Get
    End Property

    Public ReadOnly Property harga_beli() As Integer
        Get
            Return Me.mHarga_beli
        End Get
    End Property

    Public Property qty() As Integer
        Get
            Return Me.mQty
        End Get
        Set(ByVal value As Integer)
            If value > Me.qty_terima Then
                MsgBox("Jumlah tidak boleh lebih besar dari jumlah yang diterima!", MsgBoxStyle.Exclamation)
                Me.mQty = 0
            Else
                Me.mQty = value
            End If

            Call sumary()
        End Set
    End Property

    Public ReadOnly Property value_retur() As Integer
        Get
            Return Me.mValue_retur
        End Get
    End Property


    Public Property keterangan() As String
        Get
            Return Me.mKeterangan
        End Get
        Set(ByVal value As String)
            Me.mKeterangan = value
        End Set
    End Property

    Sub sumary()
        Try
            Me.mValue_retur = Me.mQty * Me.mHarga_beli
        Catch ex As Exception

        End Try
    End Sub

End Class
