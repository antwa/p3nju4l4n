Public Class rcd_user
    Dim _username As String
    Dim _kd_akses As String
    Dim _nama As String
    Dim _jabatan As String

    Public Sub New(ByVal username As String, ByVal kd_akses As String, ByVal nama As String, ByVal jabatan As String)
        Me._username = username
        Me._kd_akses = kd_akses
        Me._nama = nama
        Me._jabatan = jabatan
    End Sub

    Public Property Username() As String
        Get
            Return Me._username
        End Get
        Set(ByVal value As String)
            Me._username = value
        End Set
    End Property

    Public Property Kd_Akses() As String
        Get
            Return Me._kd_akses
        End Get
        Set(ByVal value As String)
            Me._kd_akses = value
        End Set
    End Property

    Public Property Nama() As String
        Get
            Return Me._nama
        End Get
        Set(ByVal value As String)
            Me._nama = value
        End Set
    End Property

    Public Property Jabatan() As String
        Get
            Return Me._jabatan
        End Get
        Set(ByVal value As String)
            Me._jabatan = value
        End Set
    End Property


End Class
