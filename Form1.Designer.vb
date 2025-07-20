<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SalesToolStripMenuItem = New ToolStripMenuItem()
        CustomersToolStripMenuItem = New ToolStripMenuItem()
        StaffToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        PanelDashboard = New Panel()
        LabelTotalSales = New Label()
        LabelTotalCustomers = New Label()
        LabelTotalStaff = New Label()
        BtnNewSale = New Button()
        BtnAddCustomer = New Button()
        BtnAddStaff = New Button()
        BtnViewReports = New Button()
        LabelRecentSales = New Label()
        DataGridViewRecentSales = New DataGridView()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PanelDashboard.SuspendLayout()
        CType(DataGridViewRecentSales, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1024, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SalesToolStripMenuItem, CustomersToolStripMenuItem, StaffToolStripMenuItem, ReportsToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' SalesToolStripMenuItem
        ' 
        SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        SalesToolStripMenuItem.Size = New Size(180, 22)
        SalesToolStripMenuItem.Text = "&Sales"
        ' 
        ' CustomersToolStripMenuItem
        ' 
        CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        CustomersToolStripMenuItem.Size = New Size(180, 22)
        CustomersToolStripMenuItem.Text = "&Customers"
        ' 
        ' StaffToolStripMenuItem
        ' 
        StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        StaffToolStripMenuItem.Size = New Size(180, 22)
        StaffToolStripMenuItem.Text = "S&taff"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(180, 22)
        ReportsToolStripMenuItem.Text = "&Reports"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 639)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1024, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(39, 17)
        ToolStripStatusLabel1.Text = "Ready"
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.BackColor = Color.WhiteSmoke
        PanelDashboard.BorderStyle = BorderStyle.FixedSingle
        PanelDashboard.Controls.Add(LabelTotalSales)
        PanelDashboard.Controls.Add(LabelTotalCustomers)
        PanelDashboard.Controls.Add(LabelTotalStaff)
        PanelDashboard.Controls.Add(BtnNewSale)
        PanelDashboard.Controls.Add(BtnAddCustomer)
        PanelDashboard.Controls.Add(BtnAddStaff)
        PanelDashboard.Controls.Add(BtnViewReports)
        PanelDashboard.Controls.Add(LabelRecentSales)
        PanelDashboard.Controls.Add(DataGridViewRecentSales)
        PanelDashboard.Location = New Point(20, 40)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(980, 570)
        PanelDashboard.TabIndex = 2
        ' 
        ' LabelTotalSales
        ' 
        LabelTotalSales.AutoSize = True
        LabelTotalSales.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        LabelTotalSales.Location = New Point(30, 20)
        LabelTotalSales.Name = "LabelTotalSales"
        LabelTotalSales.Size = New Size(120, 25)
        LabelTotalSales.TabIndex = 0
        LabelTotalSales.Text = "Total Sales: 0"
        ' 
        ' LabelTotalCustomers
        ' 
        LabelTotalCustomers.AutoSize = True
        LabelTotalCustomers.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        LabelTotalCustomers.Location = New Point(220, 20)
        LabelTotalCustomers.Name = "LabelTotalCustomers"
        LabelTotalCustomers.Size = New Size(170, 25)
        LabelTotalCustomers.TabIndex = 1
        LabelTotalCustomers.Text = "Total Customers: 0"
        ' 
        ' LabelTotalStaff
        ' 
        LabelTotalStaff.AutoSize = True
        LabelTotalStaff.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        LabelTotalStaff.Location = New Point(470, 20)
        LabelTotalStaff.Name = "LabelTotalStaff"
        LabelTotalStaff.Size = New Size(130, 25)
        LabelTotalStaff.TabIndex = 2
        LabelTotalStaff.Text = "Total Staff: 0"
        ' 
        ' BtnNewSale
        ' 
        BtnNewSale.BackColor = Color.MediumSeaGreen
        BtnNewSale.ForeColor = Color.White
        BtnNewSale.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        BtnNewSale.Location = New Point(30, 60)
        BtnNewSale.Name = "BtnNewSale"
        BtnNewSale.Size = New Size(140, 40)
        BtnNewSale.TabIndex = 3
        BtnNewSale.Text = "New Sale"
        BtnNewSale.UseVisualStyleBackColor = False
        ' 
        ' BtnAddCustomer
        ' 
        BtnAddCustomer.BackColor = Color.SteelBlue
        BtnAddCustomer.ForeColor = Color.White
        BtnAddCustomer.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        BtnAddCustomer.Location = New Point(190, 60)
        BtnAddCustomer.Name = "BtnAddCustomer"
        BtnAddCustomer.Size = New Size(140, 40)
        BtnAddCustomer.TabIndex = 4
        BtnAddCustomer.Text = "Add Customer"
        BtnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' BtnAddStaff
        ' 
        BtnAddStaff.BackColor = Color.DarkOrange
        BtnAddStaff.ForeColor = Color.White
        BtnAddStaff.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        BtnAddStaff.Location = New Point(350, 60)
        BtnAddStaff.Name = "BtnAddStaff"
        BtnAddStaff.Size = New Size(140, 40)
        BtnAddStaff.TabIndex = 5
        BtnAddStaff.Text = "Add Staff"
        BtnAddStaff.UseVisualStyleBackColor = False
        ' 
        ' BtnViewReports
        ' 
        BtnViewReports.BackColor = Color.MediumPurple
        BtnViewReports.ForeColor = Color.White
        BtnViewReports.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        BtnViewReports.Location = New Point(510, 60)
        BtnViewReports.Name = "BtnViewReports"
        BtnViewReports.Size = New Size(140, 40)
        BtnViewReports.TabIndex = 6
        BtnViewReports.Text = "View Reports"
        BtnViewReports.UseVisualStyleBackColor = False
        ' 
        ' LabelRecentSales
        ' 
        LabelRecentSales.AutoSize = True
        LabelRecentSales.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        LabelRecentSales.Location = New Point(30, 120)
        LabelRecentSales.Name = "LabelRecentSales"
        LabelRecentSales.Size = New Size(110, 21)
        LabelRecentSales.TabIndex = 7
        LabelRecentSales.Text = "Recent Sales"
        ' 
        ' DataGridViewRecentSales
        ' 
        DataGridViewRecentSales.AllowUserToAddRows = False
        DataGridViewRecentSales.AllowUserToDeleteRows = False
        DataGridViewRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRecentSales.Location = New Point(30, 150)
        DataGridViewRecentSales.Name = "DataGridViewRecentSales"
        DataGridViewRecentSales.ReadOnly = True
        DataGridViewRecentSales.RowTemplate.Height = 25
        DataGridViewRecentSales.Size = New Size(900, 380)
        DataGridViewRecentSales.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 661)
        Controls.Add(PanelDashboard)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales Management System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PanelDashboard.ResumeLayout(False)
        PanelDashboard.PerformLayout()
        CType(DataGridViewRecentSales, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents LabelTotalSales As Label
    Friend WithEvents LabelTotalCustomers As Label
    Friend WithEvents LabelTotalStaff As Label
    Friend WithEvents BtnNewSale As Button
    Friend WithEvents BtnAddCustomer As Button
    Friend WithEvents BtnAddStaff As Button
    Friend WithEvents BtnViewReports As Button
    Friend WithEvents LabelRecentSales As Label
    Friend WithEvents DataGridViewRecentSales As DataGridView
End Class
