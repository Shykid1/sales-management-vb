Imports System.Text

Public Class CsvExportHelper
    Public Shared Sub ExportListToCsv(Of T)(list As List(Of T), filePath As String)
        If list Is Nothing OrElse list.Count = 0 Then Return
        Dim sb As New StringBuilder()
        Dim props = GetType(T).GetProperties()
        sb.AppendLine(String.Join(",", props.Select(Function(p) $"""{p.Name}""")))
        For Each item In list
            Dim values = props.Select(Function(p) $"""{(If(p.GetValue(item, Nothing), ""))}""")
            sb.AppendLine(String.Join(",", values))
        Next
        IO.File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8)
    End Sub
End Class
