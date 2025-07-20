Imports System.ComponentModel

Public Class SalesForm
    Private ReadOnly _dataService As New DataService()
    Private _items As BindingList(Of SaleItem)
    Private _customers As List(Of Customer)
    Private _staff As List(Of Staff)

    Public Sub New()
        InitializeComponent()
        _items = New BindingList(Of SaleItem)()
        DataGridView1.DataSource = _items
        LoadCustomers()
        LoadStaff()
        UpdateTotal()
    End Sub

    Private Sub LoadCustomers()
        _customers = _dataService.LoadData(Of Customer)()
        ComboBoxCustomer.DataSource = _customers
        ComboBoxCustomer.DisplayMember = "Name"
        ComboBoxCustomer.ValueMember = "Id"
    End Sub

    Private Sub LoadStaff()
        _staff = _dataService.LoadData(Of Staff)()
        ComboBoxStaff.DataSource = _staff
        ComboBoxStaff.DisplayMember = "Name"
        ComboBoxStaff.ValueMember = "Id"
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        Dim itemForm As New SaleItemForm()
        If itemForm.ShowDialog() = DialogResult.OK Then
            _items.Add(itemForm.SaleItem)
            UpdateTotal()
        End If
    End Sub

    Private Sub BtnRemoveItem_Click(sender As Object, e As EventArgs) Handles BtnRemoveItem.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            _items.RemoveAt(DataGridView1.CurrentRow.Index)
            UpdateTotal()
        End If
    End Sub

    Private Sub UpdateTotal()
        LabelTotal.Text = $"Total: {_items.Sum(Function(i) i.Total):C2}"
    End Sub

    Private Sub BtnSaveSale_Click(sender As Object, e As EventArgs) Handles BtnSaveSale.Click
        If ComboBoxCustomer.SelectedItem Is Nothing OrElse ComboBoxStaff.SelectedItem Is Nothing OrElse _items.Count = 0 Then
            MessageBox.Show("Please select customer, staff, and add at least one item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim sale As New Sale With {
            .CustomerId = CType(ComboBoxCustomer.SelectedItem, Customer).Id,
            .StaffId = CType(ComboBoxStaff.SelectedItem, Staff).Id,
            .Items = _items.ToList()
        }
        Dim sales = _dataService.LoadData(Of Sale)()
        sales.Add(sale)
        _dataService.SaveData(sales)
        MessageBox.Show("Sale saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Dim exportType = MessageBox.Show("Export as CSV/Excel? (Yes for CSV, No for JSON)", "Export Type", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If exportType = DialogResult.Cancel Then Return
        Dim sfd As New SaveFileDialog()
        If exportType = DialogResult.Yes Then
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = $"Sale_{Date.Now:yyyyMMddHHmmss}.csv"
        Else
            sfd.Filter = "JSON Files (*.json)|*.json"
            sfd.FileName = $"Sale_{Date.Now:yyyyMMddHHmmss}.json"
        End If
        If sfd.ShowDialog() = DialogResult.OK Then
            If exportType = DialogResult.Yes Then
                CsvExportHelper.ExportListToCsv(_items.ToList(), sfd.FileName)
            Else
                Dim sale As New Sale With {
                    .CustomerId = CType(ComboBoxCustomer.SelectedItem, Customer).Id,
                    .StaffId = CType(ComboBoxStaff.SelectedItem, Staff).Id,
                    .Items = _items.ToList()
                }
                Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(sale, Newtonsoft.Json.Formatting.Indented)
                IO.File.WriteAllText(sfd.FileName, json)
            End If
            MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
