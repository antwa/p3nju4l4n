Imports System.Text.RegularExpressions

Public Class cls_validation

    Private Message As String
    Private strField As String

    Public ctrRules As System.ComponentModel.BindingList(Of cls_validation_rules)

    Public Sub showMessage()
        MsgBox("Field " & strField & ", " & Me.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validasi")
    End Sub

    Public Sub clearRules()
        If Not IsNothing(ctrRules) Then
            ctrRules = Nothing
        End If
        ctrRules = New System.ComponentModel.BindingList(Of cls_validation_rules)
    End Sub

    Public Sub addRules(ByVal value As String, ByVal fieldName As String, ByVal rules As String)
        ctrRules.Add(New cls_validation_rules(value, fieldName, rules))
    End Sub

    Public Function isValid() As Boolean
        Dim i As Integer
        For i = 0 To ctrRules.Count - 1
            If Not Valid(ctrRules.Item(i).value, ctrRules.Item(i).rules) Then
                strField = ctrRules.Item(i).fieldName
                Return False
            End If
        Next

        Return True

    End Function


    Private Function Valid(ByVal strParam As String, ByVal strRule As String) As Boolean

        strRule = strRule.ToLower

        Dim i As Integer
        Dim arules() As String = strRule.Split("|")
        Dim rules As String = vbNullString
        Dim rulesLength As Integer = arules.Length - 1

        For i = 0 To rulesLength

            rules = arules(i)

            If rules = "required" Then
                If isRequired(strParam) = False Then
                    Me.Message = "harus diisi."
                    Return False
                End If
            ElseIf rules.IndexOf("length") <> -1 Then
                Dim vLength As String = Me.getLength(rules)
                If isLength(strParam, vLength) = False Then
                    Me.Message = "Panjang karakter yang harus diisi antara " & vLength
                    Return False
                End If
            ElseIf rules = "email" Then
                If isEmail(strParam) = False Then
                    Me.Message = "Karakter yang diisi tidak sesuai dengan E-Mail"
                    Return False
                End If
            ElseIf rules = "numeric" Then
                If isNumeric(strParam) = False Then
                    Me.Message = "Karakter yang diisi harus angka"
                    Return False
                End If
            ElseIf rules = "alpha" Then
                If isAlpha(strParam) = False Then
                    Me.Message = "Karakter yang diisi harus karakter alpabet"
                    Return False
                End If
            ElseIf rules = "alphanumeric" Then
                If isAlphaNumeric(strParam) = False Then
                    Me.Message = "Karakter yang diisi harus karakter alpabet dan angka"
                    Return False
                End If
            ElseIf rules = "password" Then
                If isPassword(strParam) = False Then
                    Me.Message = "Karakter yang diisi harus karakter a-z, A-Z, atau 0-9"
                    Return False
                End If
            ElseIf rules = "username" Then
                If isUsername(strParam) = False Then
                    Me.Message = "Karakter yang diisi harus karakter a-z, A-Z, 0-9 atau ""_"""
                    Return False
                End If
            ElseIf rules.IndexOf("matches") <> -1 Then
                Dim matchesField As String = getMatchesField(rules)
                If isMatches(strParam, matchesField) = False Then
                    Me.Message = "Nilai yang diisi tidak sama dengan field " & matchesField
                    Return False
                End If
            Else
                Me.Message = "[Error Rules]"
                Return False
            End If
        Next

        Return True

    End Function


    Private Function isRequired(ByVal strParam As String) As Boolean
        Try
            If strParam.Length > 0 Or strParam <> vbNullString Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function isEmail(ByVal strParam As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(strParam, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isNumeric(ByVal strParam As String) As Boolean
        Dim pattern As String = "^[\d,.]*$"
        Dim numericMatch As Match = Regex.Match(strParam, pattern)

        If numericMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function isAlpha(ByVal strParam As String) As Boolean
        Dim pattern As String = "^[a-zA-Z\s-_.]*$"
        Dim alphaMatch As Match = Regex.Match(strParam, pattern)

        If alphaMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function isAlphaNumeric(ByVal strParam As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9]*$"
        Dim alphaNumericMatch As Match = Regex.Match(strParam, pattern)

        If alphaNumericMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function isLength(ByVal strParam As String, ByVal strLength As String) As Boolean
        Dim vLength() As String = strLength.Split("-")
        Dim pLength As Integer = strParam.Length

        If (pLength >= CInt(vLength(0))) And (pLength <= CInt(vLength(1))) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function getLength(ByVal strParam As String) As String
        Dim start As Integer = strParam.IndexOf("[")
        Dim finish As Integer = strParam.IndexOf("]")

        Return strParam.Substring((start + 1), (finish - start) - 1)

    End Function

    Private Function isUsername(ByVal strParam As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9_]*$"
        Dim userNameMatch As Match = Regex.Match(strParam, pattern)

        If userNameMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isPassword(ByVal strParam As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9]*$"
        Dim passwordMatch As Match = Regex.Match(strParam, pattern)

        If passwordMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isMatches(ByVal strParam As String, ByVal matchesField As String) As Boolean
        Dim i As Integer
        Dim strValue As String = vbNullString

        For i = 0 To ctrRules.Count - 1
            If ctrRules.Item(i).fieldName.ToLower = matchesField Then
                strValue = ctrRules.Item(i).value
                Exit For
            End If
        Next

        If strParam <> strValue Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function getMatchesField(ByVal strParam As String) As String
        Dim start As Integer = strParam.IndexOf("[")
        Dim finish As Integer = strParam.IndexOf("]")

        Return strParam.Substring((start + 1), (finish - start) - 1)
    End Function

End Class



Public Class cls_validation_rules

    Dim _Value As String
    Dim _fieldName As String
    Dim _rules As String

    Public Sub New(ByVal strValue As String, ByVal fieldName As String, ByVal rules As String)
        Me._Value = strValue
        Me._fieldName = fieldName
        Me._rules = rules
    End Sub

    Public Property value() As String
        Get
            Return Me._Value
        End Get
        Set(ByVal Value As String)
            Me._Value = Value
        End Set
    End Property

    Public Property fieldName() As String
        Get
            Return Me._fieldName
        End Get
        Set(ByVal Value As String)
            Me._fieldName = Value
        End Set
    End Property

    Public Property rules() As String
        Get
            Return Me._rules
        End Get
        Set(ByVal Value As String)
            Me._rules = Value
        End Set
    End Property

End Class
