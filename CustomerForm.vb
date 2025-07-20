Imports System.ComponentModel

Public Class CustomerForm
    Private ReadOnly _dataService As New DataService()
    Private _customers As BindingList(Of Customer)

    Public Sub New()
        InitializeComponent()
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()
        Dim list = _dataService.LoadData(Of Customer)()
        _customers = New BindingList(Of Customer)(list)
        DataGridView1.DataSource = _customers
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim dlg As New CustomerEditForm()
        If dlg.ShowDialog() = DialogResult.OK Then
            _customers.Add(dlg.Customer)
            _dataService.SaveData(_customers.ToList())
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim selected = CType(DataGridView1.CurrentRow.DataBoundItem, Customer)
        Dim dlg As New CustomerEditForm(selected)
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim idx = _customers.IndexOf(selected)
            _customers(idx) = dlg.Customer
            _dataService.SaveData(_customers.ToList())
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim selected = CType(DataGridView1.CurrentRow.DataBoundItem, Customer)
        If MessageBox.Show($"Delete customer '{selected.Name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _customers.Remove(selected)
            _dataService.SaveData(_customers.ToList())
        End If
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Dim exportType = MessageBox.Show("Export as CSV/Excel? (Yes for CSV, No for JSON)", "Export Type", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If exportType = DialogResult.Cancel Then Return
        Dim sfd As New SaveFileDialog()
        If exportType = DialogResult.Yes Then
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = $"Customers_{Date.Now:yyyyMMddHHmmss}.csv"
        Else
            sfd.Filter = "JSON Files (*.json)|*.json"
            sfd.FileName = $"Customers_{Date.Now:yyyyMMddHHmmss}.json"
        End If
        If sfd.ShowDialog() = DialogResult.OK Then
            If exportType = DialogResult.Yes Then
                CsvExportHelper.ExportListToCsv(_customers.ToList(), sfd.FileName)
            Else
                Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(_customers.ToList(), Newtonsoft.Json.Formatting.Indented)
                IO.File.WriteAllText(sfd.FileName, json)
            End If
            MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
