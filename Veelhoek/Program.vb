Imports System
Public Class Veelhoek
    Protected intAantalZijden As Integer
    Protected dblLengteZijde As Double
    Public Sub New(intAantalZijden As Integer, dblLengteZijde As Double)
        Me.intAantalZijden = intAantalZijden
        Me.dblLengteZijde = dblLengteZijde
    End Sub
End Class

Public Class Vierkant
    Inherits Veelhoek
    Public Sub New(dblLengteZijde As Double)
        MyBase.New(4, dblLengteZijde)
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
