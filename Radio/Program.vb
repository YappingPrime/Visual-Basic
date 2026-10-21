Imports System
Imports random
Module Program

    Class Radio
        Private song1 As String = "Quebec van Drake"
        Private song2 As String = "Suit & Tie van Justin Timberlake en Jay-Z"
        Private song3 As String = "Someone Like You van Adele"

        Public Function F_randomize() As String
            Dim random As New Random()
            Dim index As Integer = random.Next(3)
            Select Case index
                Case 0
                    Return song1
                Case 1
                    Return song2
                Case 2
                    Return song3
            End Select
        End Function
        Private Function SpeelLiedjeRadio() As String
            Return F_randomize()
        End Function
        Public Function SpeelLiedje() As String
            Return SpeelLiedjeRadio()

        End Function
    End Class

    Sub Main()
        Console.WriteLine("Ik wil een liedje afspelen...")
        Dim radio As New Radio
        Console.WriteLine(radio.SpeelLiedje())
        Console.WriteLine("Press any key to continue...")
    End Sub
End Module