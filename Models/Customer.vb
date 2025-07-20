Public Class Customer
    Public Property Id As String
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property Address As String
    Public Property CreatedDate As Date

    Public Sub New()
        Id = Guid.NewGuid().ToString()
        CreatedDate = Date.Now
    End Sub
End Class