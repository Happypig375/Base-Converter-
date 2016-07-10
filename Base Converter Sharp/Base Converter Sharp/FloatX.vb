Public Class FloatX
    Implements ICloneable
    Public Property Number As IntX
    Public Property Exponent As Integer
#Region "Initializers"
    Sub New()
        Number = New IntX
        Exponent = New Integer
    End Sub
    Sub New(value As Integer)
        Number = New IntX(value)
        Exponent = New Integer
    End Sub
    Sub New(value As UInteger)
        Number = New IntX(value)
        Exponent = New Integer
    End Sub
    Sub New(value As Long)
        Number = New IntX(value)
        Exponent = New Integer
    End Sub
    Sub New(value As ULong)
        Number = New IntX(value)
        Exponent = New Integer
    End Sub
    Sub New(value As IntX)
        Number = New IntX(value)
        Exponent = New Integer
    End Sub
    Sub New(value As FloatX)
        Number = New IntX(value.Number)
        Exponent = value.Exponent
    End Sub
    Sub New(value As IntX, exponent As Integer)
        Number = New IntX(value)
        Me.Exponent = exponent
    End Sub
#End Region
    Public Shared Operator +(Num1 As FloatX, Num2 As FloatX)
        EqualifyExponents(Num1, Num2)
        Return New FloatX(Num1.Number + Num2.Number, Num1.Exponent)
    End Operator
    Public Shared Function IsNumeric(value As Object) As Boolean
        Return TypeOf value Is Byte OrElse
               TypeOf value Is Int16 OrElse
               TypeOf value Is Int32 OrElse
               TypeOf value Is Int64 OrElse
               TypeOf value Is SByte OrElse
               TypeOf value Is UInt16 OrElse
               TypeOf value Is UInt32 OrElse
               TypeOf value Is UInt64 OrElse
               TypeOf value Is IntX OrElse
               TypeOf value Is Decimal OrElse
               TypeOf value Is Double OrElse
               TypeOf value Is Single OrElse
               TypeOf value Is FloatX
    End Function
    Function Clone() As Object Implements ICloneable.Clone
        Return New FloatX(Me)
    End Function
    Sub Normalize()
        Number.Normalize()
        While Number Mod 10 = 0
            Exponent += 1
            Number /= 10
        End While
    End Sub
    Shared Sub EqualifyExponents(ByRef Num1 As FloatX, ByRef Num2 As FloatX)
        If Max(Num1.Exponent, Num2.Exponent) = Num1.Exponent Then
            Num1.Number *= 10 * (New IntX(Num1.Exponent) - Num2.Exponent)
            Num1.Exponent = Num2.Exponent
        Else
            Num2.Number *= 10 * (New IntX(Num2.Exponent) - Num1.Exponent)
            Num2.Exponent = Num1.Exponent
        End If
    End Sub
    Shared Function Parse(Input As String) As FloatX
        If Input.Contains("."c) Then
            Throw New NotImplementedException
        Else
            Return New FloatX(IntX.Parse(Input))
        End If
    End Function
End Class
