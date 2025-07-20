Public Class SaleItemForm
    Private _saleItem As SaleItem
    Public ReadOnly Property SaleItem As SaleItem
        Get
            Return _saleItem
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        _saleItem = New SaleItem()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If String.IsNullOrWhiteSpace(TxtProductName.Text) OrElse Not Integer.TryParse(TxtQuantity.Text, Nothing) OrElse Not Decimal.TryParse(TxtUnitPrice.Text, Nothing) Then
            MessageBox.Show("Please enter valid product name, quantity, and unit price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        _saleItem.ProductName = TxtProductName.Text
        _saleItem.Quantity = Integer.Parse(TxtQuantity.Text)
        _saleItem.UnitPrice = Decimal.Parse(TxtUnitPrice.Text)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
