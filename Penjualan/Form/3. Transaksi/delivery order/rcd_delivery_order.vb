Public Class rcd_delivery_order

    Dim mtgl_so As Date
    Dim mno_so As String
    Dim mkode_customer As String
    Dim mnama As String
    Dim mtotal_qty As Integer
    Dim mtotal_value As Integer
    Dim mprioritas As Integer
    Dim mcek As Boolean

    Public Sub New( _
        ByVal tgl_so As Date, _
        ByVal no_so As String, _
        ByVal kode_customer As String, _
        ByVal nama As String, _
        ByVal total_qty As Integer, _
        ByVal total_value As Integer, _
        ByVal prioritas As Integer, _
        ByVal cek As Boolean)

        Me.mtgl_so = tgl_so
        Me.mno_so = no_so
        Me.mkode_customer = kode_customer
        Me.mnama = nama
        Me.mtotal_qty = total_qty
        Me.mtotal_value = total_value
        Me.mprioritas = prioritas
        Me.mcek = cek
    End Sub

    Public ReadOnly Property tgl_so() As Date
        Get
            Return Me.mtgl_so
        End Get
    End Property

    Public ReadOnly Property no_so() As String
        Get
            Return Me.mno_so
        End Get
    End Property

    Public ReadOnly Property kode_customer() As String
        Get
            Return Me.mkode_customer
        End Get
    End Property

    Public ReadOnly Property nama() As String
        Get
            Return Me.mnama
        End Get
    End Property

    Public ReadOnly Property total_qty() As Integer
        Get
            Return Me.mtotal_qty
        End Get
    End Property

    Public ReadOnly Property total_value() As Integer
        Get
            Return Me.mtotal_value
        End Get
    End Property

    Public ReadOnly Property prioritas() As Integer
        Get
            Return Me.mprioritas
        End Get
    End Property

    Public Property cek() As Boolean
        Get
            Return Me.mcek
        End Get
        Set(ByVal value As Boolean)
            Me.mcek = value
        End Set
    End Property


End Class

