Imports System
Imports System.ComponentModel.Design
Imports System.Runtime
Imports System.Security.Cryptography.X509Certificates

Public Class Bestelling
    Protected strKlantNaam As String
    Protected dblTotaalBedrag As Double
    Public intVerzendKosten As Integer

    Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
        Me.strKlantNaam = strKlantNaam
        Me.dblTotaalBedrag = dblTotaalBedrag
    End Sub
    Public Overridable Function ToonBestelDetails()
        Console.WriteLine("Klant met naam: " & strKlantNaam)
        Console.WriteLine("Totaal bedrag van bestelling: " & dblTotaalBedrag)
    End Function

    Public Overridable Function BerekenVerzendkosten() As Integer
        intVerzendKosten = 5
        Return intVerzendKosten
    End Function
End Class

Public Class SnelleLevering
    Inherits Bestelling
    Protected dblSpoedToeslag As Double

    Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
        MyBase.New(strKlantNaam, dblTotaalBedrag)
        Me.strKlantNaam = strKlantNaam
        Me.dblTotaalBedrag = dblTotaalBedrag
        dblSpoedToeslag = 10
    End Sub

    Public Overrides Function BerekenVerzendkosten() As Integer
        Return 5 + dblSpoedToeslag
    End Function
End Class

Public Class InternationaleBestelling
    Inherits Bestelling
    Protected strLand As String

    Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, strLand As String)
        MyBase.New(strKlantNaam, dblTotaalBedrag)
        Me.strLand = strLand
        Me.strKlantNaam = strKlantNaam
        Me.dblTotaalBedrag = dblTotaalBedrag
    End Sub

    'berekent de douane kosten'
    Public Function BerekenDouaneKosten() As Double
        Return dblTotaalBedrag * 0.1
    End Function

    Public Overrides Function BerekenVerzendkosten() As Integer
        Return 5 + intVerzendKosten
    End Function
End Class


Public Class Verzending
    Protected strVerzendType As String


    Public Sub New(strVerzendType As String)
        Me.strVerzendType = strVerzendType
    End Sub

    Public Overridable Function BerekenVerzendkosten()
        Return 3
    End Function
End Class

Public Class PakketVerzending
    Inherits Verzending
    Protected strPakketGrootte As String

    Public Sub New(strPakketGrootte As String, strVerzendtype As String)
        MyBase.New(strVerzendtype)
        Me.strPakketGrootte = strPakketGrootte
        Me.strVerzendType = strVerzendtype
    End Sub

    Public Overrides Function BerekenVerzendkosten()
        If strPakketGrootte = "klein" Then
            Return 3
        End If
        If strPakketGrootte = "middelgroot" Then
            Return 5
        End If
        If strPakketGrootte = "groot" Then
            Return 8
        End If
    End Function


End Class

Public Class LuchtPost
    Inherits Verzending
    Protected dblLuchtTarief As Double
    Public Sub New(strVerzendType As String)
        MyBase.New(strVerzendType)
        Me.dblLuchtTarief = 15
        Me.strVerzendType = strVerzendType
    End Sub

    Public Overrides Function BerekenVerzendkosten()
        Return dblLuchtTarief + 5 + 10
    End Function

End Class
Module Program
    Sub Main(args As String())
        Dim objJansen As New SnelleLevering("Jansen", 100)
        objJansen.ToonBestelDetails()
        Console.WriteLine("Totale verzendkosten van bestelling: " & objJansen.BerekenVerzendkosten())

        Dim objMartinez As New InternationaleBestelling("Martinez", 200, "Frankrijk")
        objMartinez.ToonBestelDetails()
        Console.WriteLine("Totale verzendkosten van bestelling: " & objMartinez.BerekenVerzendkosten())

        Dim objMid As New PakketVerzending("middelgroot", "Pakket")
        Console.WriteLine("Verzendkosten voor pakket met grootte: middelgroot is : " & objMid.BerekenVerzendkosten)

        Dim objLucht As New LuchtPost("Luchtpost")
        Console.WriteLine("Verzendkosten voor luchtpakket zijn: " & objLucht.BerekenVerzendkosten)
    End Sub
End Module