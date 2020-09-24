Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BarCode
    Public Class Code128
        Public Function Encode(ByVal StringToEncode As String) As String
            Dim ind As Integer = 1
            Dim checksum As Integer = 0
            Dim mini As Integer
            Dim dummy As Integer
            Dim tableB As Boolean
            Dim Result As String
            Dim StringToEncodeLength As Integer
            Result = ""
            StringToEncodeLength = StringToEncode.Length
            If (StringToEncodeLength = 0) Then
                'Niente da codificare
                Return Result
            Else
                For ind = 0 To StringToEncodeLength - 1
                    If (Asc(StringToEncode(ind)) < 32) Or (Asc(StringToEncode(ind)) > 126) Then
                        'Stringa Invalida
                        Return Result
                    End If
                Next
            End If
            tableB = True
            ind = 0
            While (ind < StringToEncodeLength)
                If (tableB = True) Then
                    If ((ind = 0) Or ((ind + 3) = (StringToEncodeLength - 1))) Then
                        mini = 4
                    Else
                        mini = 6
                    End If
                    mini = mini - 1
                    If ((ind + mini) <= StringToEncodeLength - 1) Then
                        While mini >= 0
                            If ((Asc(StringToEncode(ind + mini)) < 48) Or (Asc(StringToEncode(ind + mini)) > 57)) Then
                                Exit While
                            End If
                            mini = mini - 1
                        End While
                    End If
                    If (mini < 0) Then
                        If (ind = 0) Then
                            Result = Chr(205)
                        Else
                            Result = Result + Chr(199)
                        End If
                        tableB = False
                    Else
                        If (ind = 0) Then
                            Result = Chr(204)
                        End If
                    End If
                End If
                If (tableB = False) Then
                    mini = 2
                    mini = mini - 1
                    If (ind + mini < StringToEncodeLength) Then
                        While (mini >= 0)
                            If ((Asc(StringToEncode(ind + mini)) < 48) Or (Asc(StringToEncode(ind)) > 57)) Then
                                Exit While
                            End If
                            mini = mini - 1
                        End While
                    End If
                    If (mini < 0) Then
                        dummy = Int32.Parse(StringToEncode.Substring(ind, 2))
                        If (dummy < 95) Then
                            dummy = dummy + 32
                        Else
                            dummy = dummy + 100
                        End If
                        Result = Result + Chr(dummy)
                        ind = ind + 2
                    Else
                        Result = Result + Chr(200)
                        tableB = True
                    End If
                End If
                If (tableB = True) Then
                    Result = Result + StringToEncode(ind)
                    ind = ind + 1
                End If
            End While
            For ind = 0 To Result.Length - 1
                dummy = Asc(Result(ind))
                If (dummy < 127) Then
                    dummy = dummy - 32
                Else
                    dummy = dummy - 100
                End If
                If (ind = 0) Then
                    checksum = dummy
                End If
                Math.DivRem((checksum + (ind) * dummy), 103, checksum)
            Next
            If (checksum < 95) Then
                checksum = checksum + 32
            Else
                checksum = checksum + 100
            End If
            Result = Result + Chr(checksum) + Chr(206)
            Return Result
        End Function
    End Class

    Public Class Ean13
        Public Function Encode(ByVal StringToEncode As String) As String
            Dim i As Integer
            Dim first As Integer
            Dim checksum As Integer = 0
            Dim Result As String = ""
            Dim tableA As Boolean
            StringToEncode = StringToEncode.PadRight(12, "0")
            StringToEncode = StringToEncode.Substring(0, 12)
            For i = 1 To 11 Step 2
                checksum += Convert.ToInt32(StringToEncode.Substring(i, 1))
            Next
            checksum *= 3
            For i = 0 To 11 Step 2
                checksum += Convert.ToInt32(StringToEncode.Substring(i, 1))
            Next
            Math.DivRem(checksum, 10, i)
            Math.DivRem((10 - i), 10, i)
            StringToEncode += i.ToString
            Result = StringToEncode.Substring(0, 1) + Chr(65 + Convert.ToInt32(StringToEncode.Substring(1, 1)))
            first = Convert.ToInt32(StringToEncode.Substring(0, 1))
            For i = 2 To 6
                tableA = False
                Select Case i
                    Case 2
                        If (first >= 0 And first <= 3) Then
                            tableA = True
                        End If
                        Exit Select
                    Case 3
                        If (first = 0 Or first = 4 Or first = 7 Or first = 8) Then
                            tableA = True
                        End If
                        Exit Select
                    Case 4
                        If (first = 0 Or first = 1 Or first = 4 Or first = 5 Or first = 9) Then
                            tableA = True
                        End If
                        Exit Select
                    Case 5
                        If (first = 0 Or first = 2 Or first = 5 Or first = 6 Or first = 7) Then
                            tableA = True
                        End If
                        Exit Select
                    Case 6
                        If (first = 0 Or first = 3 Or first = 6 Or first = 8 Or first = 9) Then
                            tableA = True
                        End If
                End Select

                If (tableA) Then
                    Result += Chr(65 + Convert.ToInt32(StringToEncode.Substring(i, 1)))
                Else
                    Result += Chr(75 + Convert.ToInt32(StringToEncode.Substring(i, 1)))
                End If
            Next
            Result += "*"
            For i = 7 To 12
                Result += Chr(97 + Convert.ToInt32(StringToEncode.Substring(i, 1)))
            Next
            Result += "+"
            Return Result
        End Function

        Public Function EncodeAddOn(ByVal chaine As String) As String
            Dim i As Integer
            Dim checksum As Integer
            Dim tableA As Boolean
            Dim AddOn As String = ""
            If chaine.Length = 2 Or chaine.Length = 5 Then
                If (chaine.Length = 2) Then
                    Math.DivRem((10 + Convert.ToInt32(chaine)), 4, checksum)
                Else
                    For i = 0 To 4
                        checksum += Convert.ToInt32(chaine.Substring(i, 1))
                    Next
                    Math.DivRem((checksum * 3 + Convert.ToInt32(chaine.Substring(1, 1)) * 9 + Convert.ToInt32(chaine.Substring(3, 1)) * 9), 10, checksum)
                End If
                AddOn = "["
                For i = 0 To chaine.Length - 1
                    tableA = False
                    Select Case i
                        Case 0
                            If ((checksum >= 4 And checksum <= 9) Or checksum = 10 Or checksum = 11) Then
                                tableA = True
                            End If
                            Exit Select
                        Case 1
                            If (checksum = 1 Or checksum = 2 Or checksum = 3 Or checksum = 5 Or checksum = 6 _
                             Or checksum = 9 Or checksum = 10 Or checksum = 12) Then
                                tableA = True
                            End If
                            Exit Select
                        Case 2
                            If (checksum = 0 Or checksum = 2 Or checksum = 3 Or checksum = 6 _
                             Or checksum = 7 Or checksum = 8) Then
                                tableA = True
                            End If
                            Exit Select
                        Case 3
                            If (checksum = 0 Or checksum = 1 Or checksum = 3 Or checksum = 4 _
                             Or checksum = 8 Or checksum = 9) Then
                                tableA = True
                            End If
                            Exit Select
                        Case 4
                            If (checksum = 0 Or checksum = 1 Or checksum = 2 Or checksum = 4 _
                             Or checksum = 5 Or checksum = 7) Then
                                tableA = True
                            End If
                            Exit Select
                    End Select
                Next
                If (tableA) Then
                    AddOn += Chr(65 + Convert.ToInt32(chaine.Substring(i, 1)))
                Else
                    AddOn += Chr(75 + Convert.ToInt32(chaine.Substring(i, 1)))
                End If
                If ((chaine.Length = 2 And i = 0) Or (chaine.Length = 5 And i < 4)) Then
                    AddOn += Chr(92)
                End If
            End If
            Return AddOn
        End Function

    End Class

End Namespace


