Public Class rcd_level
    Dim kd_menu As String
    Dim nama_menu As String
    Dim a As Boolean
    Dim i As Boolean
    Dim u As Boolean
    Dim d As Boolean
    Dim v As Boolean
    Dim group As String
    Dim aksi As String


    Public Sub New(ByVal kd_menu As String, ByVal nama_menu As String, ByVal a As Boolean, ByVal i As Boolean, ByVal u As Boolean, ByVal d As Boolean, ByVal v As Boolean, ByVal group As String, ByVal aksi As String)
        Me.kd_menu = kd_menu
        Me.nama_menu = nama_menu
        Me.a = a
        Me.i = i
        Me.u = u
        Me.d = d
        Me.v = v
        Me.group = group
        Me.aksi = aksi
    End Sub

    Public ReadOnly Property KdMenu() As String
        Get
            Return Me.kd_menu
        End Get
    End Property

    Public ReadOnly Property NamaMenu() As String
        Get
            Return Me.nama_menu
        End Get
    End Property

    Public Property Access() As Boolean
        Get
            Return Me.a
        End Get
        Set(ByVal value As Boolean)
            Me.a = value

            Me.i = value
            Me.u = value
            Me.d = value
            Me.v = value
        End Set
    End Property

    Public Property Insert() As Boolean
        Get
            Return Me.i
        End Get
        Set(ByVal value As Boolean)
            If Me.a = False Then
                Me.i = False
            Else
                Me.i = value
            End If
        End Set
    End Property

    Public Property Update() As Boolean
        Get
            Return Me.u
        End Get
        Set(ByVal value As Boolean)
            If Me.a = False Then
                Me.u = False
            Else
                Me.u = value
            End If
        End Set
    End Property

    Public Property Delete() As Boolean
        Get
            Return Me.d
        End Get
        Set(ByVal value As Boolean)
            If Me.a = False Then
                Me.d = False
            Else
                Me.d = value
            End If
        End Set
    End Property

    Public Property View() As Boolean
        Get
            Return Me.v
        End Get
        Set(ByVal value As Boolean)
            If Me.a = False Then
                Me.v = False
            Else
                Me.v = value
            End If
        End Set
    End Property

    Public Property Groups() As String
        Get
            Return Me.group
        End Get
        Set(ByVal value As String)
            Me.group = value
        End Set
    End Property

    Public Property Aksi_cell() As String
        Get
            Return Me.aksi
        End Get
        Set(ByVal value As String)
            Me.aksi = value
        End Set
    End Property

End Class
