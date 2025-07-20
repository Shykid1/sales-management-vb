Imports System.IO
Imports Newtonsoft.Json

Public Class DataService
    Private ReadOnly _baseDirectory As String

    Public Sub New()
        _baseDirectory = Path.Combine(Application.StartupPath, "Data")
        If Not Directory.Exists(_baseDirectory) Then
            Directory.CreateDirectory(_baseDirectory)
        End If
    End Sub

    Private Function GetFilePath(Of T)() As String
        Return Path.Combine(_baseDirectory, $"{GetType(T).Name}s.json")
    End Function

    Public Function LoadData(Of T)() As List(Of T)
        Dim filePath = GetFilePath(Of T)()
        If Not File.Exists(filePath) Then
            Return New List(Of T)
        End If

        Dim jsonData = File.ReadAllText(filePath)
        Return JsonConvert.DeserializeObject(Of List(Of T))(jsonData)
    End Function

    Public Sub SaveData(Of T)(data As List(Of T))
        Dim filePath = GetFilePath(Of T)()
        Dim jsonData = JsonConvert.SerializeObject(data, Formatting.Indented)
        File.WriteAllText(filePath, jsonData)
    End Sub

    Public Sub SaveItem(Of T)(item As T)
        Dim items = LoadData(Of T)()
        items.Add(item)
        SaveData(items)
    End Sub
End Class