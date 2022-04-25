Public Class FizzBuzzValue

	Public Property Value As Integer
	Public Property Result As String

End Class

Public Class FizzBuzz

	Private Results As List(Of FizzBuzzValue)

	Public Sub New(ByVal Str As String)

		Dim Temp As String() = Str.Split(",")
		Dim Value As FizzBuzzValue

		Results = New List(Of FizzBuzzValue)()
		For Index As Integer = 0 To Temp.Length - 1

			Value = New FizzBuzzValue()
			Value.Value = Temp(Index)
			Results.Add(Value)

		Next

	End Sub

	Public Function ToString() As String

		Dim Temp As String = ""

		For Index = 0 To Results.Count - 1

			Temp = Temp + Results(Index).Value.ToString() + " " + Results(Index).Result.ToString() + vbCrLf

		Next
		Return Temp

	End Function

	Public Function Calculate() As String

		Dim Temp As String

		For Index As Integer = 0 To Results.Count - 1

			If (Results(Index).Value Mod 3 = 0 AndAlso Results(Index).Value Mod 5 = 0) Then

				Temp = "FizzBuzz"

			ElseIf (Results(Index).Value Mod 3 = 0) Then

				Temp = "Fizz"

			ElseIf (Results(Index).Value Mod 5 = 0) Then

				Temp = "Buzz"

			Else

				Temp = ""

			End If
			Results(Index).Result = Temp

		Next

		Return ToString()

	End Function

End Class

Module Module1

	Sub Main()

		Try

			Dim Temp As String
			Dim FizzBuzz As FizzBuzz

			Console.WriteLine("Please input number sequence separated by comma.")
			Temp = Console.ReadLine()

			FizzBuzz = New FizzBuzz(Temp)
			Console.WriteLine(FizzBuzz.Calculate())

			Console.WriteLine("Press any keys to continue...")
			Temp = Console.Read()

		Catch ex As Exception

			Console.WriteLine(ex.Message)

		End Try

	End Sub

End Module
