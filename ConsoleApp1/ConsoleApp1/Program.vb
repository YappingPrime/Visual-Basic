Imports System
Imports System.Data.SqlTypes

Module Program

    Class Draak
        Public strNaam As String
        Public strOrigiin As String
        Public strGender As String
        Public intAge As Integer
        Public strClassification As String

        Public Sub New(strNaam As String, strOrigin As String, strGender As String, intAge As Integer, strClassification As String)
            Me.strNaam = strNaam
            Me.strOrigiin = strOrigin
            Me.strGender = strGender
            Me.intAge = intAge
            Me.strClassification = strClassification
        End Sub

    End Class

    Sub Main()
        Console.WriteLine("Hello Westoros!")
        Dim objDraak As New Draak("Drogon", "Game of Thrones", "Male", 7, "Dragon")
        Console.WriteLine("Draak: {0}, Origin: {1}, Gender: {2}, Age: {3}, Classification: {4}", objDraak.strNaam, objDraak.strOrigiin, objDraak.strGender, objDraak.intAge, objDraak.strClassification)
        Dim objDraak2 As New Draak("Viserion", "Game of Thrones", "Male", 6, "Dragon, Wight")
        Console.WriteLine("Draak: {0}, Origin: {1}, Gender: {2}, Age: {3}, Classification: {4}", objDraak2.strNaam, objDraak2.strOrigiin, objDraak2.strGender, objDraak2.intAge, objDraak2.strClassification)
        Dim objDraak3 As New Draak("Rhaegal", "Game of Thrones", "Male", 7, "Dragon")
        Console.WriteLine("Draak: {0}, Origin: {1}, Gender: {2}, Age: {3}, Classification: {4}", objDraak3.strNaam, objDraak3.strOrigiin, objDraak3.strGender, objDraak3.intAge, objDraak3.strClassification)

    End Sub
End Module
