Imports System.Text.Json

Public Class JsonExportHelper
    Public Shared Sub ExportListToJson(Of T)(list As List(Of T), filePath As String)
        If list Is Nothing OrElse list.Count = 0 Then Return
        Dim options As New JsonSerializerOptions With {
            .WriteIndented = True
        }
        Dim json = JsonSerializer.Serialize(list, options)
        IO.File.WriteAllText(filePath, json)
    End Sub
End Class
