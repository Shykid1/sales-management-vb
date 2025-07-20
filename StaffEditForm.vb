Public Class StaffEditForm
    Private _staff As Staff
    Public ReadOnly Property Staff As Staff
        Get
            Return _staff
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        _staff = New Staff()
    End Sub

    Public Sub New(existing As Staff)
        InitializeComponent()
        _staff = New Staff With {
            .Id = existing.Id,
            .Name = existing.Name,
            .Email = existing.Email,
            .Phone = existing.Phone,
            .Position = existing.Position,
            .HireDate = existing.HireDate,
            .CreatedDate = existing.CreatedDate
        }
        TxtName.Text = _staff.Name
        TxtEmail.Text = _staff.Email
        TxtPhone.Text = _staff.Phone
        TxtPosition.Text = _staff.Position
        DtpHireDate.Value = _staff.HireDate
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        _staff.Name = TxtName.Text
        _staff.Email = TxtEmail.Text
        _staff.Phone = TxtPhone.Text
        _staff.Position = TxtPosition.Text
        _staff.HireDate = DtpHireDate.Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
