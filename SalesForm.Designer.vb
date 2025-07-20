<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxCustomer = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStaff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.BtnRemoveItem = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.BtnSaveSale = New System.Windows.Forms.Button()
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
        Me.ComboBoxCustomer.Size = New System.Drawing.Size(250, 23)
        Me.ComboBoxCustomer.TabIndex = 0
        ' 
        ' ComboBoxStaff
        ' 
        Me.ComboBoxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStaff.FormattingEnabled = True
        Me.ComboBoxStaff.Location = New System.Drawing.Point(120, 60)
        Me.ComboBoxStaff.Name = "ComboBoxStaff"
        Me.ComboBoxStaff.Size = New System.Drawing.Size(250, 23)
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
        Me.Label2.Location = New System.Drawing.Point(30, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Staff:"
        ' 
        ' DataGridView1
        ' 
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(600, 250)
        Me.DataGridView1.TabIndex = 4
        ' 
        ' BtnAddItem
        ' 
        Me.BtnAddItem.Location = New System.Drawing.Point(650, 100)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(100, 30)
        Me.BtnAddItem.TabIndex = 5
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveItem
        ' 
        Me.BtnRemoveItem.Location = New System.Drawing.Point(650, 140)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(100, 30)
        Me.BtnRemoveItem.TabIndex = 6
        Me.BtnRemoveItem.Text = "Remove Item"
        Me.BtnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' LabelTotal
        ' 
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotal.Location = New System.Drawing.Point(30, 370)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(61, 21)
        Me.LabelTotal.TabIndex = 7
        Me.LabelTotal.Text = "Total: "
        ' 
        ' BtnSaveSale
        ' 
        Me.BtnSaveSale.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnSaveSale.ForeColor = System.Drawing.Color.White
        Me.BtnSaveSale.Location = New System.Drawing.Point(650, 320)
        Me.BtnSaveSale.Name = "BtnSaveSale"
        Me.BtnSaveSale.Size = New System.Drawing.Size(100, 40)
        Me.BtnSaveSale.TabIndex = 8
        Me.BtnSaveSale.Text = "Save Sale"
        Me.BtnSaveSale.UseVisualStyleBackColor = False
        ' 
        ' BtnExport
        ' 
        Me.BtnExport.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnExport.ForeColor = System.Drawing.Color.White
        Me.BtnExport.Location = New System.Drawing.Point(650, 370)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(100, 40)
        Me.BtnExport.TabIndex = 9
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = False
        ' 
        ' SalesForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.BtnSaveSale)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.BtnRemoveItem)
        Me.Controls.Add(Me.BtnAddItem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxStaff)
        Me.Controls.Add(Me.ComboBoxCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Entry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents ComboBoxCustomer As ComboBox
    Friend WithEvents ComboBoxStaff As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents BtnRemoveItem As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents BtnSaveSale As Button
    Friend WithEvents BtnExport As Button
End Class
