Public Class Sale
    Public Property Id As String
    Public Property CustomerId As String
    Public Property StaffId As String
    Public Property Items As List(Of SaleItem)
    Public Property SaleDate As Date
    Public Property TotalAmount As Decimal
        Get
            Return Items.Sum(Function(i) i.Total)
        End Get
        Private Set(value As Decimal)
        End Set
    End Property

    Public Sub New()
        Id = Guid.NewGuid().ToString()
        SaleDate = Date.Now
        Items = New List(Of SaleItem)
    End Sub
End Class