Imports System

Class Salamander
    Protected intAantalPoten As Integer
    Protected intStaartLengteInCm As Integer
    Protected dblLongCapaciteitInLiter As Double

    Public Sub New()
        intAantalPoten = 4
        intStaartLengteInCm = 6
        dblLongCapaciteitInLiter = 0.5
    End Sub

    Public Function GeefAantalPoten() As Integer
        Return intAantalPoten
    End Function

    Public Function GeefLongCapaciteit() As Double
        Return dblLongCapaciteitInLiter
    End Function

    Public Function GeefStaartLengte() As Integer
        Return intStaartLengteInCm
    End Function

End Class

Class Tijger
    Inherits Salamander
    Protected strHaarKleur As String
    Public Sub New()
        MyBase.New()
        dblLongCapaciteitInLiter = 2
        strHaarKleur = "Zwart"

    End Sub

    Public Function GeefHaarKleur() As String
        Return strHaarKleur
    End Function
End Class

Class Mens
    Inherits Tijger
    Protected intAantalBenen As Integer
    Protected intAantalArmen As Integer

    Public Sub New()
        intAantalPoten = 0
        intStaartLengteInCm = 0
        dblLongCapaciteitInLiter = 7.0
        intAantalBenen = 2
        intAantalArmen = 2
    End Sub

    Public Function GeefAantalArmenEnBenen() As String
        Return "Aantal armen:" & intAantalArmen & " en aantal benen:" & intAantalBenen
    End Function
End Class
Module Program
    Sub Main(args As String())
        Dim objsalamander As New Salamander()
        Dim objtijger As New Tijger()
        Dim objmens As New Mens()
        Console.WriteLine("Salamander heeft zoveel poten: " & objsalamander.GeefAantalPoten())
        Console.WriteLine("Tijger heeft zoveel poten: " & objtijger.GeefAantalPoten())
        Console.WriteLine("Mens heeft zoveel poten: " & objmens.GeefAantalPoten())

        Console.WriteLine("De tijger heeft deze kleur van haar: " & objtijger.GeefHaarKleur())
        Console.WriteLine("De mens heeft deze kleur van haar: " & objmens.GeefHaarKleur())

        Console.WriteLine("De salamander heeft een longcapaciteit van (in liter): " & objsalamander.GeefLongCapaciteit())
        Console.WriteLine("De tijger heeft een longcapaciteit van (in liter): " & objtijger.GeefLongCapaciteit())
        Console.WriteLine("De mens heeft een longcapaciteit van (in liter): " & objmens.GeefLongCapaciteit())

    End Sub
End Module
