<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(600, 300)
        Me.DataGridView1.TabIndex = 0
        ' 
        ' BtnAdd
        ' 
        Me.BtnAdd.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.BtnAdd.Cursor = Cursors.Hand
        Me.BtnAdd.Location = New System.Drawing.Point(650, 30)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 35)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        Me.BtnEdit.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.BtnEdit.Cursor = Cursors.Hand
        Me.BtnEdit.Location = New System.Drawing.Point(650, 80)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(100, 35)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        Me.BtnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.BtnDelete.Cursor = Cursors.Hand
        Me.BtnDelete.Location = New System.Drawing.Point(650, 130)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 35)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnExport
        ' 
        Me.BtnExport.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnExport.FlatAppearance.BorderSize = 0
        Me.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExport.ForeColor = System.Drawing.Color.White
        Me.BtnExport.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.BtnExport.Cursor = Cursors.Hand
        Me.BtnExport.Location = New System.Drawing.Point(650, 180)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(100, 35)
        Me.BtnExport.TabIndex = 4
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = False
        ' 
        ' StaffForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Staff Management"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        ' Set consistent font for the form
        Me.Font = New Font("Segoe UI", 10.0!)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnExport As Button
End Class
