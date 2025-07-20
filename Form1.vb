Public Class Form1
    Private ReadOnly _dataService As New DataService()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the data service and load initial data
        InitializeApplication()
        UpdateDashboard()
    End Sub

    Private Sub InitializeApplication()
        Try
            ' Load initial data to verify everything is working
            Dim customers = _dataService.LoadData(Of Customer)()
            Dim staff = _dataService.LoadData(Of Staff)()
            Dim sales = _dataService.LoadData(Of Sale)()

            ToolStripStatusLabel1.Text = "Application initialized successfully"
        Catch ex As Exception
            MessageBox.Show("Error initializing application: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateDashboard()
        Dim customers = _dataService.LoadData(Of Customer)()
        Dim staff = _dataService.LoadData(Of Staff)()
        Dim sales = _dataService.LoadData(Of Sale)()

        LabelTotalSales.Text = $"Total Sales: {sales.Count}"
        LabelTotalCustomers.Text = $"Total Customers: {customers.Count}"
        LabelTotalStaff.Text = $"Total Staff: {staff.Count}"

        ' Show 10 most recent sales
        Dim recent = sales.OrderByDescending(Function(s) s.SaleDate).Take(10).Select(Function(s) New With {
            .Date = s.SaleDate.ToString("yyyy-MM-dd HH:mm"),
            .Customer = customers.FirstOrDefault(Function(c) c.Id = s.CustomerId)?.Name,
            .Staff = staff.FirstOrDefault(Function(st) st.Id = s.StaffId)?.Name,
            .Total = s.TotalAmount
        }).ToList()

        DataGridViewRecentSales.DataSource = recent
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Using frm As New SalesForm()
            If frm.ShowDialog(Me) = DialogResult.OK Then
                UpdateDashboard()
            End If
        End Using
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Using frm As New CustomerForm()
            frm.ShowDialog(Me)
            UpdateDashboard()
        End Using
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Using frm As New StaffForm()
            frm.ShowDialog(Me)
            UpdateDashboard()
        End Using
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Using frm As New ReportsForm()
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub BtnNewSale_Click(sender As Object, e As EventArgs) Handles BtnNewSale.Click
        SalesToolStripMenuItem.PerformClick()
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        CustomersToolStripMenuItem.PerformClick()
    End Sub

    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles BtnAddStaff.Click
        StaffToolStripMenuItem.PerformClick()
    End Sub

    Private Sub BtnViewReports_Click(sender As Object, e As EventArgs) Handles BtnViewReports.Click
        ReportsToolStripMenuItem.PerformClick()
    End Sub
End Class
