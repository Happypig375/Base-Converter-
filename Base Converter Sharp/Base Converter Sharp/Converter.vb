Public Class Converter

    Public Enum Base As Byte
        Unary = 1
        Binary
        Ternary
        Quaternary
        Quinary
        Senary
        Septnary
        Octal
        Nonary
        [Decimal]
        Undecimal
        Duodecimal
        Tridecimal
        Tetradecimal
        Pentadecimal
        Hexadecimal
        Septendecimal
        Octodecimal
        Nonadecimal
        Vigesimal
        Unovigesimal
        Duovigesimal
        Triovigesimal
        Quadrovigesimal
        Pentavigesimal
        Hexavigesimal
        Heptovigesimal
        Octovigesimal
        Novovigesimal
        Trigesimal
        Unotrigesimal
        Duotrigesimal
        Triotrigesimal
        Quadrotrigesimal
        Pentatrigesimal
        Hexatrigesimal
        Heptotrigesimal
        Octotrigesimal
        Novotrigesimal
        Quadragesimal
        Unoquadragesimal
        Duoquadragesimal
        Trioquadragesimal
        Quadroquadragesimal
        Pentaquadragesimal
        Hexaquadragesimal
        Heptoquadragesimal
        Octoquadragesimal
        Novoquadragesimal
        Quinquagesimal
        Unoquinquagesimal
        Duoquinquagesimal
        Trioquinquagesimal
        Quadroquinquagesimal
        Pentaquinquagesimal
        Hexaquinquagesimal
        Heptoquinquagesimal
        Octoquinquagesimal
        Novoquinquagesimal
        Sexagesimal
        Unosexagesimal
        Duosexagesimal
    End Enum

    Public Shared Function Convert([In] As Base, Value As String, Optional Out As Base = Base.Decimal) As String
#If False Then
        Array.ForEach(Value.ToCharArray, Sub(c As Char) If Not Char.IsLetterOrDigit(
        c) Then Throw New ArgumentException("Value", "The string contains nonalphanumeric characters."))
        Dim TempDecimal As IntX
        If [In] = Base.Decimal Then
            TempDecimal = Value
        ElseIf [In] = Base.Unary Then
            TempDecimal = Value.Count.ToString
        Else
            Value = Value.Reverse
            For Each Character As Char In Value
                Add(TempDecimal, Val(Character) * [In] ^ Value.IndexOf(Character))
                ' Still undone
                ' Working on here
            Next
        End If
#End If
        Dim Temp As IntX = IntX.Parse(Value, [In])
    End Function

    Public Shared Function ToValue(Character As Char) As Byte
        Select Case Character
            Case "0"c To "9"c
                Return Val(Character)
            Case "A"c To "Z"c, "a"c To "z"c
                Return AscW(Character) + If(Char.IsUpper(Character), 10 - AscW("A"c), 37 - AscW("a"c))
            Case Else
                Throw New ArgumentOutOfRangeException("Character", Character, "Character must be either 0 to 9, a to z or A to Z.")
        End Select
    End Function

    Public Shared Function ToChar(Value As Byte) As Char
        Select Case Value
            Case 0 To 9
                Return Value.ToString
            Case 10 To 62
                Return ChrW(Value - If(Value <= 36, 10 - AscW("A"c), 37 - AscW("a"c)))
            Case Else
                Throw New ArgumentOutOfRangeException("Value", Value, "Value must be between 0 to 62.")
        End Select
    End Function

    Public Shared Sub Add(ByRef Subject As String, Value As String)
        Array.ForEach(Subject.ToCharArray, Sub(c As Char) If Not Char.IsDigit(
        c) Then Throw New ArgumentException("The string contains nonnumeric characters.", "Value"))
        Array.ForEach(Value.ToCharArray, Sub(c As Char) If Not Char.IsDigit(
        c) Then Throw New ArgumentException("The string contains nonnumeric characters.", "Value"))
        Subject = Subject.Reverse
        Value = Value.Reverse
        For Each Digit As Char In Value

        Next
    End Sub

    Private Function Add(x As Integer, y As Integer) As Integer
        ' Iterate till there is no carry  
        While y <> 0
            ' carry now contains common set bits of x and y
            Dim carry As Integer = x And y

            ' Sum of bits of x and y where at least one of the bits is not set
            x = x Xor y

            ' Carry is shifted by one so that adding it to x gives the required sum
            y = carry << 1
        End While
        Return x
    End Function

    Private Sub UpdateOutput()
        'Output.Text = Convert(InputBase.SelectedIndex + 1, Input.Text, OutputBase.SelectedIndex + 1)
    End Sub

    Private Sub Converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Base As Byte = 1 To 62
            InputBase.Items.Add([Enum].GetName(GetType(Base), Base) & " (Base " & Base & ")"c)
        Next
        OutputBase.Items.AddRange(InputBase.Items.Cast(Of String).ToArray)
        ToChar(ToValue("a"))
        End
    End Sub

    Private Sub InputBase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InputBase.SelectedIndexChanged
        UpdateOutput()
    End Sub

    Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged
        UpdateOutput()
    End Sub

    Private Sub OutputBase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputBase.SelectedIndexChanged
        UpdateOutput()
    End Sub
End Class
