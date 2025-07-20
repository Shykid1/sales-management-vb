Public Class CustomerEditForm
    Private _customer As Customer
    Public ReadOnly Property Customer As Customer
        Get
            Return _customer
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        _customer = New Customer()
    End Sub

    Public Sub New(existing As Customer)
        InitializeComponent()
        _customer = New Customer With {
            .Id = existing.Id,
            .Name = existing.Name,
            .Email = existing.Email,
            .Phone = existing.Phone,
            .Address = existing.Address,
            .CreatedDate = existing.CreatedDate
        }
        TxtName.Text = _customer.Name
        TxtEmail.Text = _customer.Email
        TxtPhone.Text = _customer.Phone
        TxtAddress.Text = _customer.Address
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        _customer.Name = TxtName.Text
        _customer.Email = TxtEmail.Text
        _customer.Phone = TxtPhone.Text
        _customer.Address = TxtAddress.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
