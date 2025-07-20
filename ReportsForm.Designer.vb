<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxCustomer = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStaff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelTotalSales = New System.Windows.Forms.Label()
        Me.LabelTotalAmount = New System.Windows.Forms.Label()
        Me.BtnExport = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' ComboBoxCustomer
        ' 
        Me.ComboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCustomer.FormattingEnabled = True
        Me.ComboBoxCustomer.Location = New System.Drawing.Point(120, 20)
        Me.ComboBoxCustomer.Name = "ComboBoxCustomer"
        Me.ComboBoxCustomer.Size = New System.Drawing.Size(200, 23)
        Me.ComboBoxCustomer.TabIndex = 0
        ' 
        ' ComboBoxStaff
        ' 
        Me.ComboBoxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStaff.FormattingEnabled = True
        Me.ComboBoxStaff.Location = New System.Drawing.Point(420, 20)
        Me.ComboBoxStaff.Name = "ComboBoxStaff"
        Me.ComboBoxStaff.Size = New System.Drawing.Size(200, 23)
        Me.ComboBoxStaff.TabIndex = 1
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer:"
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Staff:"
        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(650, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From:"
        ' 
        ' Label4
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(850, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To:"
        ' 
        ' DtpFrom
        ' 
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFrom.Location = New System.Drawing.Point(700, 20)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(120, 23)
        Me.DtpFrom.TabIndex = 6
        ' 
        ' DtpTo
        ' 
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTo.Location = New System.Drawing.Point(880, 20)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(120, 23)
        Me.DtpTo.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(970, 350)
        Me.DataGridView1.TabIndex = 8
        ' 
        ' LabelTotalSales
        ' 
        Me.LabelTotalSales.AutoSize = True
        Me.LabelTotalSales.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalSales.Location = New System.Drawing.Point(30, 430)
        Me.LabelTotalSales.Name = "LabelTotalSales"
        Me.LabelTotalSales.Size = New System.Drawing.Size(90, 19)
        Me.LabelTotalSales.TabIndex = 9
        Me.LabelTotalSales.Text = "Total Sales:"
        ' 
        ' LabelTotalAmount
        ' 
        Me.LabelTotalAmount.AutoSize = True
        Me.LabelTotalAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalAmount.Location = New System.Drawing.Point(200, 430)
        Me.LabelTotalAmount.Name = "LabelTotalAmount"
        Me.LabelTotalAmount.Size = New System.Drawing.Size(108, 19)
        Me.LabelTotalAmount.TabIndex = 10
        Me.LabelTotalAmount.Text = "Total Amount:"
        ' 
        ' BtnExport
        ' 
        Me.BtnExport.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnExport.FlatAppearance.BorderSize = 0
        Me.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExport.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExport.ForeColor = System.Drawing.Color.White
        Me.BtnExport.Location = New System.Drawing.Point(900, 420)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(100, 35)
        Me.BtnExport.TabIndex = 11
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = False
        ' 
        ' ReportsForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 480)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.LabelTotalAmount)
        Me.Controls.Add(Me.LabelTotalSales)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxStaff)
        Me.Controls.Add(Me.ComboBoxCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
        ' Modernize buttons and DataGridView for ReportsForm
        BtnExport.FlatStyle = FlatStyle.Flat
        BtnExport.FlatAppearance.BorderSize = 0
        BtnExport.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        BtnExport.Cursor = Cursors.Hand
        ' DataGridView modern look
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.GridColor = Color.Gainsboro
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 10.0!)
        DataGridView1.RowHeadersVisible = False
        ' Set consistent font for the form
        Me.Font = New Font("Segoe UI", 10.0!)
    End Sub

    Friend WithEvents ComboBoxCustomer As ComboBox
    Friend WithEvents ComboBoxStaff As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents DtpTo As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelTotalSales As Label
    Friend WithEvents LabelTotalAmount As Label
    Friend WithEvents BtnExport As Button
End Class
