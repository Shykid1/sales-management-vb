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
        Dim exportType = MessageBox.Show("Export as CSV/Excel? (Yes for CSV, No for JSON)", "Export Type", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If exportType = DialogResult.Cancel Then Return
        Dim sfd As New SaveFileDialog()
        If exportType = DialogResult.Yes Then
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = $"SalesReport_{Date.Now:yyyyMMddHHmmss}.csv"
        Else
            sfd.Filter = "JSON Files (*.json)|*.json"
            sfd.FileName = $"SalesReport_{Date.Now:yyyyMMddHHmmss}.json"
        End If
        If sfd.ShowDialog() = DialogResult.OK Then
            If exportType = DialogResult.Yes Then
                CsvExportHelper.ExportListToCsv(_filteredSales.ToList(), sfd.FileName)
            Else
                Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(_filteredSales.ToList(), Newtonsoft.Json.Formatting.Indented)
                IO.File.WriteAllText(sfd.FileName, json)
            End If
            MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
