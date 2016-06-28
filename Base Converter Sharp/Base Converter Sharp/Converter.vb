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
        Dim TempDecimal As String
        If [In] = Base.Decimal Then
            TempDecimal = Value
        ElseIf [In] = Base.Unary Then
            TempDecimal = Value.Count.ToString
        Else
            For Chars As UInteger = 0 To Value.Count + 1
                Value = Value.Reverse

            Next
        End If
    End Function

    Public Shared Function ToValue(Character As Char) As Byte
        Select Case Character
            Case "0"c To "9"c
                Return AscW(Character)
            Case "A"c To "Z"c, "a"c To "z"c
                Return AscW(Character) - AscW("A"c) + If(Char.IsLower(Character), 10, 36)
            Case Else
                Throw New ArgumentOutOfRangeException("Character", "Character must be either 0 to 9, a to z or A to Z.")
        End Select
    End Function

    Private Sub UpdateOutput()
        Output.Text = Convert(InputBase.SelectedIndex + 1, Input.Text, OutputBase.SelectedIndex + 1)
    End Sub

    Private Sub Converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Base As Byte = 1 To 62
            InputBase.Items.Add([Enum].GetName(GetType(Base), Base) & " (Base " & Base & ")"c)
        Next
        OutputBase.Items.AddRange(InputBase.Items.Cast(Of String).ToArray)
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
