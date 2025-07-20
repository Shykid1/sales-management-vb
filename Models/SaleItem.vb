Public Class SaleItem
    Public Property Id As String
    Public Property ProductName As String
    Public Property Quantity As Integer
    Public Property UnitPrice As Decimal
    Public Property Total As Decimal
        Get
            Return Quantity * UnitPrice
        End Get
        Private Set(value As Decimal)
        End Set
    End Property

    Public Sub New()
        Id = Guid.NewGuid().ToString()
    End Sub
End Class