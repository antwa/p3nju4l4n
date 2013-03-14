Public Class rcd_retur_formalitas

    Dim mno As Integer
    Dim mkode_barangjadi As String
    Dim mnama_barangjadi As String
    Dim mstok As Integer
    Dim mjml_retur As Integer
    Dim msisa As Integer

    Public Sub New()

    End Sub

    Public Sub New( _
        ByVal no As Integer, _
        ByVal kode_barangjadi As String, _
        ByVal nama_barangjadi As String, _
        ByVal stok As Integer, _
        ByVal jml_retur As Integer, _
        ByVal sisa As Integer)

        Me.mno = no
        Me.mkode_barangjadi = kode_barangjadi
        Me.mnama_barangjadi = nama_barangjadi
        Me.mstok = stok
        Me.mjml_retur = jml_retur
        Me.msisa = sisa
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

    Public Property stok() As Integer
        Get
            Return Me.mstok
        End Get
        Set(ByVal value As Integer)
            Me.mstok = value
        End Set
    End Property

    Public Property jml_retur() As Integer
        Get
            Return Me.mjml_retur
        End Get
        Set(ByVal value As Integer)
            If value > Me.mstok Then
                MsgBox("Jumlah retur tidak boleh lebih dari stok!", MsgBoxStyle.Exclamation, "Pesan")
                Me.mjml_retur = 0
            Else
                Me.mjml_retur = value
            End If

            Call Me.sumary()
        End Set
    End Property

    Public Property sisa() As Integer
        Get
            Return Me.msisa
        End Get
        Set(ByVal value As Integer)
            Me.msisa = value
        End Set
    End Property


    Public Sub sumary()
        Try
            Me.msisa = Me.mstok - Me.mjml_retur
        Catch ex As Exception
            Me.msisa = 0
        End Try
    End Sub

End Class

