Public Class cls_authentication

    ' kamus data
    Dim _username As String
    Dim _kdAccess As String
    Dim _nama As String
    Dim _jabatan As String
    Dim _namaAkses As String

    Dim i As Integer

    Public rcdAuth As System.ComponentModel.BindingList(Of cls_rcd_auth)


    ' New
    Public Sub New()
        rcdAuth = New System.ComponentModel.BindingList(Of cls_rcd_auth)
    End Sub


    '# Properties
    '--------------------------------------------------------------------------
    Public Property Username() As String
        Get
            Return Me._username
        End Get
        Set(ByVal value As String)
            Me._username = value
        End Set
    End Property

    Public Property KdLevel() As String
        Get
            Return Me._kdAccess
        End Get
        Set(ByVal value As String)
            Me._kdAccess = value
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

    Public Property NamaAkses() As String
        Get
            Return Me._namaAkses
        End Get
        Set(ByVal value As String)
            Me._namaAkses = value
        End Set
    End Property

    '--------------------------------------------------------------------------
    '# END Properties



    Public Sub addAuth(ByVal kdMenu As String, ByVal NamaMenu As String, ByVal formName As String, _
                        Optional ByVal Access As Boolean = False, _
                        Optional ByVal Insert As Boolean = False, _
                        Optional ByVal Update As Boolean = False, _
                        Optional ByVal Delete As Boolean = False, _
                        Optional ByVal View As Boolean = False)

        rcdAuth.Add(New cls_rcd_auth(kdMenu, NamaMenu, formName, Access, Insert, Update, Delete, View))
    End Sub

    Public Function getAllAuth(ByVal kd_menu As String) As Boolean()
        Dim tAuth(5) As Boolean
        For Me.i = 0 To rcdAuth.Count - 1
            If rcdAuth.Item(i).KdMenu = kd_menu Then
                tAuth(0) = rcdAuth.Item(i).Access
                tAuth(1) = rcdAuth.Item(i).Insert
                tAuth(2) = rcdAuth.Item(i).Update
                tAuth(3) = rcdAuth.Item(i).Delete
                tAuth(4) = rcdAuth.Item(i).View
                Return tAuth
            End If
        Next

        Return tAuth
    End Function

    Public Function canAccess(ByVal formName As String) As Boolean
        For Me.i = 0 To rcdAuth.Count - 1
            If rcdAuth.Item(i).FormName = formName Then
                Return rcdAuth.Item(i).Access
            End If
        Next

        Return False
    End Function

    Public Function canInsert(ByVal formName As String) As Boolean
        For Me.i = 0 To rcdAuth.Count - 1
            If rcdAuth.Item(i).FormName = formName Then
                Return rcdAuth.Item(i).Insert
            End If
        Next

        Return False
    End Function

    Public Function canUpdate(ByVal formName As String) As Boolean
        For Me.i = 0 To rcdAuth.Count - 1
            If rcdAuth.Item(i).FormName = formName Then
                Return rcdAuth.Item(i).Update
            End If
        Next

        Return False
    End Function

    Public Function canDelete(ByVal formName As String) As Boolean
        For Me.i = 0 To rcdAuth.Count - 1
            If rcdAuth.Item(i).FormName = formName Then
                Return rcdAuth.Item(i).Delete
            End If
        Next

        Return False
    End Function

    Public Function canView(ByVal formName As String) As Boolean
        For Me.i = 0 To rcdAuth.Count - 1
            If rcdAuth.Item(i).FormName = formName Then
                Return rcdAuth.Item(i).View
            End If
        Next

        Return False
    End Function

End Class




Public Class cls_rcd_auth

    Dim _kdmenu As String
    Dim _nama As String
    Dim _formname As String
    Dim _access As Boolean
    Dim _insert As Boolean
    Dim _update As Boolean
    Dim _delete As Boolean
    Dim _view As Boolean

    Public Sub New(ByVal kdMenu As String, ByVal NamaMenu As String, ByVal formName As String, _
                   ByVal Access As Boolean, _
                   ByVal Insert As Boolean, ByVal Update As Boolean, ByVal Delete As Boolean, ByVal View As Boolean)

        Me._kdmenu = kdMenu
        Me._nama = NamaMenu
        Me._formname = formName
        Me._access = Access
        Me._insert = Insert
        Me._update = Update
        Me._delete = Delete
        Me._view = View
    End Sub

    Public Property KdMenu() As String
        Get
            Return Me._kdmenu
        End Get
        Set(ByVal Value As String)
            Me._kdmenu = Value
        End Set
    End Property

    Public Property NamaMenu() As String
        Get
            Return Me._nama
        End Get
        Set(ByVal value As String)
            Me._nama = value
        End Set
    End Property

    Public Property FormName() As String
        Get
            Return Me._formname
        End Get
        Set(ByVal value As String)
            Me._formname = value
        End Set
    End Property

    Public Property Access() As Boolean
        Get
            Return Me._access
        End Get
        Set(ByVal value As Boolean)
            Me._access = value
        End Set
    End Property

    Public Property Insert() As Boolean
        Get
            Return Me._insert
        End Get
        Set(ByVal value As Boolean)
            Me._insert = value
        End Set
    End Property

    Public Property Update() As Boolean
        Get
            Return Me._update
        End Get
        Set(ByVal value As Boolean)
            Me._update = value
        End Set
    End Property

    Public Property Delete() As Boolean
        Get
            Return Me._delete
        End Get
        Set(ByVal value As Boolean)
            Me._delete = value
        End Set
    End Property

    Public Property View() As Boolean
        Get
            Return Me._view
        End Get
        Set(ByVal value As Boolean)
            Me._view = value
        End Set
    End Property

End Class

