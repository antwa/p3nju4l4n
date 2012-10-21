Public Class rcd_barangjadi_add

    Dim mkode_size As Integer
    Dim mcheked As Boolean
    Dim msize As String

    Public Sub New( _
        ByVal kode_size As Integer, _
        ByVal cheked As Boolean, _
        ByVal size As String)

        Me.mkode_size = kode_size
        Me.mcheked = cheked
        Me.msize = size
    End Sub

    Public ReadOnly Property kode_size() As Integer
        Get
            Return Me.mkode_size
        End Get
    End Property

    Public Property cheked() As Boolean
        Get
            Return Me.mcheked
        End Get
        Set(ByVal value As Boolean)
            Me.mcheked = value
        End Set
    End Property

    Public ReadOnly Property size() As String
        Get
            Return Me.msize
        End Get
    End Property


End Class

