<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffEditForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtPosition = New System.Windows.Forms.TextBox()
        Me.DtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Position:"
        ' 
        ' Label5
        ' 
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hire Date:"
        ' 
        ' TxtName
        ' 
        Me.TxtName.Location = New System.Drawing.Point(90, 17)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(220, 23)
        Me.TxtName.TabIndex = 5
        ' 
        ' TxtEmail
        ' 
        Me.TxtEmail.Location = New System.Drawing.Point(90, 57)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(220, 23)
        Me.TxtEmail.TabIndex = 6
        ' 
        ' TxtPhone
        ' 
        Me.TxtPhone.Location = New System.Drawing.Point(90, 97)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(220, 23)
        Me.TxtPhone.TabIndex = 7
        ' 
        ' TxtPosition
        ' 
        Me.TxtPosition.Location = New System.Drawing.Point(90, 137)
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.Size = New System.Drawing.Size(220, 23)
        Me.TxtPosition.TabIndex = 8
        ' 
        ' DtpHireDate
        ' 
        Me.DtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpHireDate.Location = New System.Drawing.Point(90, 177)
        Me.DtpHireDate.Name = "DtpHireDate"
        Me.DtpHireDate.Size = New System.Drawing.Size(220, 23)
        Me.DtpHireDate.TabIndex = 9
        ' 
        ' BtnOK
        ' 
        Me.BtnOK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Location = New System.Drawing.Point(90, 220)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 30)
        Me.BtnOK.TabIndex = 10
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        Me.BtnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(220, 220)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 30)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' StaffEditForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 270)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.DtpHireDate)
        Me.Controls.Add(Me.TxtPosition)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StaffEditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Staff Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtPosition As TextBox
    Friend WithEvents DtpHireDate As DateTimePicker
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
End Class
