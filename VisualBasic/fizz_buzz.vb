' FizzBuzz program  using Visual Basic
' Author: @gayatripalkar

Sub Main()
 
    For i = 1 To 100
        If i Mod 15 = 0 Then
            Console.WriteLine("FizzBuzz")
        ElseIf i Mod 5 = 0 Then
            Console.WriteLine("Buzz")
        ElseIf i Mod 3 = 0 Then
            Console.WriteLine("Fizz")
        Else
            Console.WriteLine(i)
        End If
    Next
 
End Sub
