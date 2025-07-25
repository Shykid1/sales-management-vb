Imports System.ComponentModel

Public Class ReportsForm
    Private ReadOnly _dataService As New DataService()
    Private _sales As List(Of Sale)
    Private _customers As List(Of Customer)
    Private _staff As List(Of Staff)
    Private _filteredSales As BindingList(Of Sale)

    Public Sub New()
        InitializeComponent()
        LoadData()
        AddHandler ComboBoxCustomer.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler ComboBoxStaff.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler DtpFrom.ValueChanged, AddressOf ApplyFilters
        AddHandler DtpTo.ValueChanged, AddressOf ApplyFilters
        AddHandler BtnExportJson.Click, AddressOf BtnExportJson_Click
        ApplyFilters()
    End Sub

    Private Sub LoadData()
        _sales = _dataService.LoadData(Of Sale)()
        _customers = _dataService.LoadData(Of Customer)()
        _staff = _dataService.LoadData(Of Staff)()
        ComboBoxCustomer.Items.Clear()
        ComboBoxCustomer.Items.Add("All")
        ComboBoxCustomer.Items.AddRange(_customers.Select(Function(c) c.Name).ToArray())
        ComboBoxCustomer.SelectedIndex = 0
        ComboBoxStaff.Items.Clear()
        ComboBoxStaff.Items.Add("All")
        ComboBoxStaff.Items.AddRange(_staff.Select(Function(s) s.Name).ToArray())
        ComboBoxStaff.SelectedIndex = 0
        DtpFrom.Value = Date.Today.AddMonths(-1)
        DtpTo.Value = Date.Today
    End Sub

    Private Function SaleMatchesFilters(s As Sale) As Boolean
        Dim customerMatch As Boolean = (ComboBoxCustomer.SelectedIndex = 0)
        If Not customerMatch Then
            Dim cust = _customers.FirstOrDefault(Function(c) c.Id = s.CustomerId)
            If cust IsNot Nothing Then
                customerMatch = (cust.Name = ComboBoxCustomer.SelectedItem.ToString())
            Else
                customerMatch = False
            End If
        End If
        Dim staffMatch As Boolean = (ComboBoxStaff.SelectedIndex = 0)
        If Not staffMatch Then
            Dim st = _staff.FirstOrDefault(Function(stf) stf.Id = s.StaffId)
            If st IsNot Nothing Then
                staffMatch = (st.Name = ComboBoxStaff.SelectedItem.ToString())
            Else
                staffMatch = False
            End If
        End If
        Dim dateMatch As Boolean = (s.SaleDate.Date >= DtpFrom.Value.Date AndAlso s.SaleDate.Date <= DtpTo.Value.Date)
        Return customerMatch AndAlso staffMatch AndAlso dateMatch
    End Function

    Private Sub ApplyFilters()
        Dim filtered As New List(Of Sale)
        For Each s In _sales
            If SaleMatchesFilters(s) Then
                filtered.Add(s)
            End If
        Next
        _filteredSales = New BindingList(Of Sale)(filtered)
        DataGridView1.DataSource = _filteredSales
        UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        LabelTotalSales.Text = $"Total Sales: {_filteredSales.Count}"
        LabelTotalAmount.Text = $"Total Amount: {_filteredSales.Sum(Function(s) s.TotalAmount):C2}"
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Try
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.FileName = $"SalesReport_{DateTime.Now:yyyyMMddHHmmss}"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    Dim dt = ToDataTableFromGrid(DataGridView1)
                    If dt.Rows.Count > 0 Then
                        ExcelExportHelper.ExportDataTableToExcel(dt, saveFileDialog.FileName, "Sales Report")
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
                saveFileDialog.FileName = $"SalesReport_{DateTime.Now:yyyyMMddHHmmss}"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    Dim data = TryCast(DataGridView1.DataSource, System.ComponentModel.BindingList(Of Sale))
                    If data IsNot Nothing Then
                        JsonExportHelper.ExportListToJson(data.ToList(), saveFileDialog.FileName)
                        MessageBox.Show("JSON export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class
