Imports System
Public Class Speler
    Protected strNaam As String

    Public Sub New(strNaam As String)
        Me.strNaam = strNaam
    End Sub
    Public Overridable Function TrapBal() As String
        Return "De speler " & strNaam & " trapt de bal."
    End Function

End Class

Public Class Verdediger
    Inherits Speler
    Public Sub New(strNaam As String)
        MyBase.New(strNaam)
    End Sub
    Public Overrides Function TrapBal() As String
        If Int(100 * Rnd()) >= 50 Then
            Return "De verdediger " & strNaam & " geeft een goede pas."
        Else
            Return "De verdediger " & strNaam & " geeft een slechte pas."
        End If
    End Function
End Class

Public Class Aanvaller
    Inherits Speler
    Public Sub New(strNaam As String)
        MyBase.New(strNaam)
    End Sub
    Public Overrides Function TrapBal() As String
        If Int(100 * Rnd()) < 30 Then
            Return "De aanvaller " & strNaam & " scoort een doelpunt!"
        Else
            Return "De aanvaller " & strNaam & " mist het doel."
        End If
    End Function
End Class
Module Program
    Sub Main(args As String())
        Dim verdediger1 As New Verdediger("Pieter")
        Dim aanvaller1 As New Aanvaller("Joris")
        Console.WriteLine(verdediger1.TrapBal())
        Console.WriteLine(aanvaller1.TrapBal())
    End Sub
End Module
