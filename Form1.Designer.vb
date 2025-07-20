Imports FontAwesome.Sharp
Imports System.Drawing

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
        ToolStrip1 = New ToolStrip()
        ToolStripButtonNewSale = New IconToolStripButton()
        ToolStripButtonAddCustomer = New IconToolStripButton()
        ToolStripButtonAddStaff = New IconToolStripButton()
        ToolStripButtonViewReports = New IconToolStripButton()
        ToolStripButtonTheme = New IconToolStripButton()
        StatusStrip1.SuspendLayout()
        PanelDashboard.SuspendLayout()
        CType(DataGridViewRecentSales, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        LabelTotalSales.Location = New Point(80, 20)
        LabelTotalSales.Name = "LabelTotalSales"
        LabelTotalSales.Size = New Size(120, 25)
        LabelTotalSales.TabIndex = 0
        LabelTotalSales.Text = "Total Sales: 0"
        ' 
        ' LabelTotalCustomers
        ' 
        LabelTotalCustomers.AutoSize = True
        LabelTotalCustomers.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        LabelTotalCustomers.Location = New Point(340, 20)
        LabelTotalCustomers.Name = "LabelTotalCustomers"
        LabelTotalCustomers.Size = New Size(170, 25)
        LabelTotalCustomers.TabIndex = 1
        LabelTotalCustomers.Text = "Total Customers: 0"
        ' 
        ' LabelTotalStaff
        ' 
        LabelTotalStaff.AutoSize = True
        LabelTotalStaff.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        LabelTotalStaff.Location = New Point(650, 20)
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
        BtnNewSale.Location = New Point(80, 70)
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
        BtnAddCustomer.Location = New Point(270, 70)
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
        BtnAddStaff.Location = New Point(460, 70)
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
        BtnViewReports.Location = New Point(650, 70)
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
        LabelRecentSales.Location = New Point(30, 130)
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
        DataGridViewRecentSales.Location = New Point(30, 160)
        DataGridViewRecentSales.Name = "DataGridViewRecentSales"
        DataGridViewRecentSales.ReadOnly = True
        DataGridViewRecentSales.RowTemplate.Height = 25
        DataGridViewRecentSales.Size = New Size(900, 380)
        DataGridViewRecentSales.TabIndex = 8
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = Color.WhiteSmoke
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.RenderMode = ToolStripRenderMode.System
        ToolStrip1.Padding = New Padding(8, 4, 0, 4)
        ToolStrip1.ImageScalingSize = New Size(28, 28)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButtonNewSale, ToolStripButtonAddCustomer, ToolStripButtonAddStaff, ToolStripButtonViewReports, ToolStripButtonTheme})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1024, 32)
        ToolStrip1.TabIndex = 10
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButtonNewSale
        ' 
        ToolStripButtonNewSale.AutoSize = False
        ToolStripButtonNewSale.Width = 36
        ToolStripButtonNewSale.Height = 36
        ToolStripButtonNewSale.Margin = New Padding(2, 0, 2, 0)
        ToolStripButtonNewSale.BackColor = Color.Transparent
        ToolStripButtonNewSale.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonNewSale.IconChar = IconChar.ShoppingCart
        ToolStripButtonNewSale.IconColor = Color.MediumSeaGreen
        ToolStripButtonNewSale.IconSize = 24
        ToolStripButtonNewSale.ToolTipText = "New Sale"
        ToolStripButtonNewSale.Name = "ToolStripButtonNewSale"
        ToolStripButtonNewSale.Size = New Size(28, 29)
        ' 
        ' ToolStripButtonAddCustomer
        ' 
        ToolStripButtonAddCustomer.AutoSize = False
        ToolStripButtonAddCustomer.Width = 36
        ToolStripButtonAddCustomer.Height = 36
        ToolStripButtonAddCustomer.Margin = New Padding(2, 0, 2, 0)
        ToolStripButtonAddCustomer.BackColor = Color.Transparent
        ToolStripButtonAddCustomer.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonAddCustomer.IconChar = IconChar.UserPlus
        ToolStripButtonAddCustomer.IconColor = Color.SteelBlue
        ToolStripButtonAddCustomer.IconSize = 24
        ToolStripButtonAddCustomer.ToolTipText = "Add Customer"
        ToolStripButtonAddCustomer.Name = "ToolStripButtonAddCustomer"
        ToolStripButtonAddCustomer.Size = New Size(28, 29)
        ' 
        ' ToolStripButtonAddStaff
        ' 
        ToolStripButtonAddStaff.AutoSize = False
        ToolStripButtonAddStaff.Width = 36
        ToolStripButtonAddStaff.Height = 36
        ToolStripButtonAddStaff.Margin = New Padding(2, 0, 2, 0)
        ToolStripButtonAddStaff.BackColor = Color.Transparent
        ToolStripButtonAddStaff.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonAddStaff.IconChar = IconChar.UserTie
        ToolStripButtonAddStaff.IconColor = Color.DarkOrange
        ToolStripButtonAddStaff.IconSize = 24
        ToolStripButtonAddStaff.ToolTipText = "Add Staff"
        ToolStripButtonAddStaff.Name = "ToolStripButtonAddStaff"
        ToolStripButtonAddStaff.Size = New Size(28, 29)
        ' 
        ' ToolStripButtonViewReports
        ' 
        ToolStripButtonViewReports.AutoSize = False
        ToolStripButtonViewReports.Width = 36
        ToolStripButtonViewReports.Height = 36
        ToolStripButtonViewReports.Margin = New Padding(2, 0, 2, 0)
        ToolStripButtonViewReports.BackColor = Color.Transparent
        ToolStripButtonViewReports.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonViewReports.IconChar = IconChar.ChartBar
        ToolStripButtonViewReports.IconColor = Color.MediumPurple
        ToolStripButtonViewReports.IconSize = 24
        ToolStripButtonViewReports.ToolTipText = "View Reports"
        ToolStripButtonViewReports.Name = "ToolStripButtonViewReports"
        ToolStripButtonViewReports.Size = New Size(28, 29)
        ' 
        ' ToolStripButtonTheme
        ' 
        ToolStripButtonTheme.AutoSize = False
        ToolStripButtonTheme.Width = 36
        ToolStripButtonTheme.Height = 36
        ToolStripButtonTheme.Margin = New Padding(2, 0, 2, 0)
        ToolStripButtonTheme.BackColor = Color.Transparent
        ToolStripButtonTheme.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButtonTheme.IconChar = IconChar.Moon
        ToolStripButtonTheme.IconColor = Color.DimGray
        ToolStripButtonTheme.IconSize = 24
        ToolStripButtonTheme.ToolTipText = "Toggle Light/Dark Mode"
        ToolStripButtonTheme.Name = "ToolStripButtonTheme"
        ToolStripButtonTheme.Size = New Size(28, 29)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 661)
        Controls.Add(ToolStrip1)
        Controls.Add(PanelDashboard)
        Controls.Add(StatusStrip1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales Management System"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PanelDashboard.ResumeLayout(False)
        PanelDashboard.PerformLayout()
        CType(DataGridViewRecentSales, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
        ' Modernize dashboard buttons
        BtnNewSale.FlatStyle = FlatStyle.Flat
        BtnNewSale.FlatAppearance.BorderSize = 0
        BtnNewSale.Padding = New Padding(0, 6, 0, 6)
        BtnNewSale.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        BtnNewSale.Cursor = Cursors.Hand
        BtnNewSale.TabStop = False
        BtnAddCustomer.FlatStyle = FlatStyle.Flat
        BtnAddCustomer.FlatAppearance.BorderSize = 0
        BtnAddCustomer.Padding = New Padding(0, 6, 0, 6)
        BtnAddCustomer.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        BtnAddCustomer.Cursor = Cursors.Hand
        BtnAddCustomer.TabStop = False
        BtnAddStaff.FlatStyle = FlatStyle.Flat
        BtnAddStaff.FlatAppearance.BorderSize = 0
        BtnAddStaff.Padding = New Padding(0, 6, 0, 6)
        BtnAddStaff.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        BtnAddStaff.Cursor = Cursors.Hand
        BtnAddStaff.TabStop = False
        BtnViewReports.FlatStyle = FlatStyle.Flat
        BtnViewReports.FlatAppearance.BorderSize = 0
        BtnViewReports.Padding = New Padding(0, 6, 0, 6)
        BtnViewReports.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        BtnViewReports.Cursor = Cursors.Hand
        BtnViewReports.TabStop = False
        ' Center dashboard stats and buttons
        LabelTotalSales.Location = New Point(80, 20)
        LabelTotalCustomers.Location = New Point(340, 20)
        LabelTotalStaff.Location = New Point(650, 20)
        BtnNewSale.Location = New Point(80, 70)
        BtnAddCustomer.Location = New Point(270, 70)
        BtnAddStaff.Location = New Point(460, 70)
        BtnViewReports.Location = New Point(650, 70)
        ' Add more vertical spacing
        LabelRecentSales.Location = New Point(30, 130)
        DataGridViewRecentSales.Location = New Point(30, 160)
        ' Subtle shadow/border for dashboard panel
        PanelDashboard.BorderStyle = BorderStyle.Fixed3D
        ' Remove DataGridView border for cleaner look
        DataGridViewRecentSales.BorderStyle = BorderStyle.None
        ' Set consistent font for the form
        Me.Font = New Font("Segoe UI", 10.0!)
        ' Modernize StatusStrip
        StatusStrip1.BackColor = Color.WhiteSmoke
        StatusStrip1.Font = New Font("Segoe UI", 10.0!)
        ToolStripStatusLabel1.ForeColor = Color.DimGray
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
    End Sub

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
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonNewSale As IconToolStripButton
    Friend WithEvents ToolStripButtonAddCustomer As IconToolStripButton
    Friend WithEvents ToolStripButtonAddStaff As IconToolStripButton
    Friend WithEvents ToolStripButtonViewReports As IconToolStripButton
    Friend WithEvents ToolStripButtonTheme As IconToolStripButton
End Class
