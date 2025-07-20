Public Class Form1
    Private ReadOnly _dataService As New DataService()
    Private isDarkMode As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the data service and load initial data
        InitializeApplication()
        UpdateDashboard()
        ' Wire up ToolStrip button click events
        AddHandler ToolStripButtonNewSale.Click, AddressOf BtnNewSale_Click
        AddHandler ToolStripButtonAddCustomer.Click, AddressOf BtnAddCustomer_Click
        AddHandler ToolStripButtonAddStaff.Click, AddressOf BtnAddStaff_Click
        AddHandler ToolStripButtonViewReports.Click, AddressOf BtnViewReports_Click
        AddHandler ToolStripButtonTheme.Click, AddressOf ToggleTheme
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

    Private Sub BtnNewSale_Click(sender As Object, e As EventArgs) Handles BtnNewSale.Click
        ' Open SalesForm
        Using frm As New SalesForm()
            If frm.ShowDialog(Me) = DialogResult.OK Then
                UpdateDashboard()
            End If
        End Using
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        Using frm As New CustomerForm()
            frm.ShowDialog(Me)
            UpdateDashboard()
        End Using
    End Sub

    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles BtnAddStaff.Click
        Using frm As New StaffForm()
            frm.ShowDialog(Me)
            UpdateDashboard()
        End Using
    End Sub

    Private Sub BtnViewReports_Click(sender As Object, e As EventArgs) Handles BtnViewReports.Click
        Using frm As New ReportsForm()
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub ToggleTheme(sender As Object, e As EventArgs)
        isDarkMode = Not isDarkMode
        If isDarkMode Then
            ' Dark mode colors
            Me.BackColor = Color.FromArgb(32, 32, 32)
            PanelDashboard.BackColor = Color.FromArgb(40, 40, 40)
            LabelTotalSales.ForeColor = Color.White
            LabelTotalCustomers.ForeColor = Color.White
            LabelTotalStaff.ForeColor = Color.White
            LabelRecentSales.ForeColor = Color.White
            DataGridViewRecentSales.BackgroundColor = Color.FromArgb(40, 40, 40)
            DataGridViewRecentSales.DefaultCellStyle.BackColor = Color.FromArgb(55, 55, 55)
            DataGridViewRecentSales.DefaultCellStyle.ForeColor = Color.White
            DataGridViewRecentSales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32)
            DataGridViewRecentSales.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            DataGridViewRecentSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
            DataGridViewRecentSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            ToolStrip1.BackColor = Color.FromArgb(32, 32, 32)
            StatusStrip1.BackColor = Color.FromArgb(32, 32, 32)
            ToolStripStatusLabel1.ForeColor = Color.Gainsboro
            BtnNewSale.BackColor = Color.FromArgb(34, 139, 34)
            BtnAddCustomer.BackColor = Color.FromArgb(70, 130, 180)
            BtnAddStaff.BackColor = Color.FromArgb(255, 140, 0)
            BtnViewReports.BackColor = Color.FromArgb(138, 43, 226)
            BtnNewSale.ForeColor = Color.White
            BtnAddCustomer.ForeColor = Color.White
            BtnAddStaff.ForeColor = Color.White
            BtnViewReports.ForeColor = Color.White
            ToolStripButtonTheme.IconChar = FontAwesome.Sharp.IconChar.Sun
            ToolStripButtonTheme.IconColor = Color.Gold
        Else
            ' Light mode colors
            Me.BackColor = Color.White
            PanelDashboard.BackColor = Color.WhiteSmoke
            LabelTotalSales.ForeColor = Color.Black
            LabelTotalCustomers.ForeColor = Color.Black
            LabelTotalStaff.ForeColor = Color.Black
            LabelRecentSales.ForeColor = Color.Black
            DataGridViewRecentSales.BackgroundColor = Color.White
            DataGridViewRecentSales.DefaultCellStyle.BackColor = Color.WhiteSmoke
            DataGridViewRecentSales.DefaultCellStyle.ForeColor = Color.Black
            DataGridViewRecentSales.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            DataGridViewRecentSales.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            DataGridViewRecentSales.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro
            DataGridViewRecentSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            ToolStrip1.BackColor = Color.WhiteSmoke
            StatusStrip1.BackColor = Color.WhiteSmoke
            ToolStripStatusLabel1.ForeColor = Color.DimGray
            BtnNewSale.BackColor = Color.MediumSeaGreen
            BtnAddCustomer.BackColor = Color.SteelBlue
            BtnAddStaff.BackColor = Color.DarkOrange
            BtnViewReports.BackColor = Color.MediumPurple
            BtnNewSale.ForeColor = Color.White
            BtnAddCustomer.ForeColor = Color.White
            BtnAddStaff.ForeColor = Color.White
            BtnViewReports.ForeColor = Color.White
            ToolStripButtonTheme.IconChar = FontAwesome.Sharp.IconChar.Moon
            ToolStripButtonTheme.IconColor = Color.DimGray
        End If
    End Sub
End Class
