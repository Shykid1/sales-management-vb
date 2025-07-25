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
        Using itemForm As New SaleItemForm()
            If itemForm.ShowDialog() = DialogResult.OK Then
                _items.Add(itemForm.SaleItem)
                UpdateTotal()
            End If
        End Using
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
            .CustomerId = DirectCast(ComboBoxCustomer.SelectedItem, Customer).Id,
            .StaffId = DirectCast(ComboBoxStaff.SelectedItem, Staff).Id,
            .Items = _items.ToList()
        }

        Dim sales = _dataService.LoadData(Of Sale)()
        sales.Add(sale)
        _dataService.SaveData(sales)
        MessageBox.Show("Sale saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Try
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.FileName = $"SaleItems_{DateTime.Now:yyyyMMddHHmmss}"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    Dim dt = ToDataTableFromGrid(DataGridView1)
                    If dt.Rows.Count > 0 Then
                        ExcelExportHelper.ExportDataTableToExcel(dt, saveFileDialog.FileName, "Sale Items")
                        MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ToDataTableFromGrid(dgv As DataGridView) As DataTable
        Dim dt As New DataTable()
        For Each col As DataGridViewColumn In dgv.Columns
            dt.Columns.Add(col.HeaderText)
        Next
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim values(row.Cells.Count - 1) As Object
                For i = 0 To row.Cells.Count - 1
                    values(i) = row.Cells(i).Value
                Next
                dt.Rows.Add(values)
            End If
        Next
        Return dt
    End Function

    Private Sub BtnExportJson_Click(sender As Object, e As EventArgs)
        Try
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.FileName = $"SaleItems_{DateTime.Now:yyyyMMddHHmmss}"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    JsonExportHelper.ExportListToJson(_items.ToList(), saveFileDialog.FileName)
                    MessageBox.Show("JSON export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class
