Imports System

Public Class Dier
    Protected strKleur As String

    Public Sub New(strKleur As String)
        Me.strKleur = strKleur
    End Sub
    Public Function eet() As String
        Return "Het dier eet"
    End Function

    Public Function slaap() As String
        Return "Het dier slaapt"
    End Function
End Class

Public Class Hond
    Inherits Dier
    Protected strBaasje As String

    Public Sub New(strKleur As String)
        MyBase.New(strKleur)
    End Sub
    Public Function Geefeigenaar() As String
        Return strBaasje
    End Function

    Public Sub Zeteigenaar(baasje As String)
        Me.strBaasje = baasje
    End Sub

    Public Function blaf() As String
        Return "De hond blaft"
    End Function

    Public Sub printInfo()
        Console.WriteLine("Kleur: " & strKleur)
        Console.WriteLine("Baasje: " & strBaasje)
    End Sub
End Class

Public Class Leeuw
    Inherits Dier
    Protected strJungleNaam As String

    Public Sub New(strKleur As String)
        MyBase.New(strKleur)
    End Sub
    Public Function GeefJungle()
        Return strJungleNaam
    End Function

    Public Sub ZetJungle(jungleNaam As String)
        Me.strJungleNaam = jungleNaam
    End Sub
    Public Function brul() As String
        Return "De leeuw brult"
    End Function

    Public Sub printInfo()
        Console.WriteLine("Kleur: " & strKleur)
        Console.WriteLine("Jungle: " & strJungleNaam)
    End Sub


End Class

Module Program
    Sub main(args As String())
        Dim mijnHond As New Hond("Bruin")
        mijnHond.Zeteigenaar("Jan")
        mijnHond.printInfo()
        Console.WriteLine(mijnHond.blaf())
        Console.WriteLine(mijnHond.eet())
        Console.WriteLine(mijnHond.slaap())
        Dim mijnLeeuw As New leeuw("Goud")
        mijnLeeuw.ZetJungle("Afrikaanse Savanne")
        mijnLeeuw.printInfo()
        Console.WriteLine(mijnLeeuw.brul())
        Console.WriteLine(mijnLeeuw.eet())
        Console.WriteLine(mijnLeeuw.slaap())
    End Sub

End Module