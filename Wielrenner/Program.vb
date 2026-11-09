Imports System

Class Wielrenner
    Protected strNaam As String
    Protected intLeeftijd As Integer
    Protected strPloeg As String

    Public Sub toonNaam()
        Console.WriteLine("Naam: " & strNaam)
    End Sub

    Public Sub toonLeeftijd()
        Console.WriteLine("Leeftijd: " & intLeeftijd)
    End Sub

End Class

Class ProfWielrenner
    Inherits Wielrenner
    Private intAantalOverwinningen As Integer
    Private dblSalaris As Double

    Public Sub New(strNaam As String, intLeeftijd As Integer, strPloeg As String, intAantalOverwinningen As Integer, dblSalaris As Double)
        Me.strNaam = strNaam
        Me.intLeeftijd = intLeeftijd
        Me.strPloeg = strPloeg
        Me.intAantalOverwinningen = intAantalOverwinningen
        Me.dblSalaris = dblSalaris
    End Sub

    Public Sub toonAantalOverwinningen()
        Console.WriteLine("Aantal overwinningen: " & intAantalOverwinningen)
    End Sub
End Class

Class AmateurWielrenner
    Inherits Wielrenner
    Private intAantaldeelnames As Integer
    Private intAantalOverwinningen As Integer
    Public Sub New(strNaam As String, intLeeftijd As Integer, strPloeg As String, intAantalOverwinningen As Integer, intAantaldeelnames As Integer)
        Me.strNaam = strNaam
        Me.intLeeftijd = intLeeftijd
        Me.strPloeg = strPloeg
        Me.intAantalOverwinningen = intAantalOverwinningen
        Me.intAantaldeelnames = intAantaldeelnames
    End Sub

    Public Sub toonAantalOverwinningen()
        Console.WriteLine("Aantal overwinningen: " & intAantalOverwinningen)
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Dim profWielrenner As New ProfWielrenner("Jan", 28, "Red Bull", 10, 50000)
        profWielrenner.toonNaam()
        profWielrenner.toonLeeftijd()
        profWielrenner.toonAantalOverwinningen()
        Dim amateurWielrenner As New AmateurWielrenner("Piet", 22, "Alpecin", 5, 20)
        amateurWielrenner.toonNaam()
        amateurWielrenner.toonLeeftijd()
        amateurWielrenner.toonAantalOverwinningen()
    End Sub
End Module
