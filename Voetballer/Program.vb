Imports System
Class voetballer
    Private strNaam As String
    Private intLeeftijd As Integer
    Private strPositie As String
    Private intTrefZekerheid As Integer
    Private intSchopMoeillijkheid As Integer
    Public Sub New(naam As String, leeftijd As Integer, positie As String)
        Me.strNaam = naam
        Me.intLeeftijd = leeftijd
        Me.strPositie = positie
        Me.intTrefZekerheid = Int(100 * Rnd()) + 1
        Me.intSchopMoeillijkheid = Int(100 * Rnd()) + 1
    End Sub
    Public Sub PrintInfo()
        Console.WriteLine("Naam: " & strNaam)
        Console.WriteLine("Leeftijd: " & intLeeftijd)
        Console.WriteLine("Positie: " & strPositie)
        Console.WriteLine("Trefzekerheid: " & intTrefZekerheid & "%")
        Console.WriteLine("Schop_Moeilijkheid:" & intSchopMoeillijkheid & "%")
    End Sub
    Public Sub GeefStrafSchop()
        If intTrefZekerheid > intSchopMoeillijkheid Then
            Console.WriteLine("Binnen!")
        Else
            Console.WriteLine("Mislukt")
        End If
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Randomize()
        Dim Voetballer1 As New voetballer("Lionel Messi", 36, "Aanvaller")
        Voetballer1.PrintInfo()
        Voetballer1.GeefStrafSchop()
    End Sub
End Module
