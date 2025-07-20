Imports System.ComponentModel

Public Class StaffForm
    Private ReadOnly _dataService As New DataService()
    Private _staffList As BindingList(Of Staff)

    Public Sub New()
        InitializeComponent()
        LoadStaff()
    End Sub

    Private Sub LoadStaff()
        Dim list = _dataService.LoadData(Of Staff)()
        _staffList = New BindingList(Of Staff)(list)
        DataGridView1.DataSource = _staffList
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim dlg As New StaffEditForm()
        If dlg.ShowDialog() = DialogResult.OK Then
            _staffList.Add(dlg.Staff)
            _dataService.SaveData(_staffList.ToList())
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim selected = CType(DataGridView1.CurrentRow.DataBoundItem, Staff)
        Dim dlg As New StaffEditForm(selected)
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim idx = _staffList.IndexOf(selected)
            _staffList(idx) = dlg.Staff
            _dataService.SaveData(_staffList.ToList())
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim selected = CType(DataGridView1.CurrentRow.DataBoundItem, Staff)
        If MessageBox.Show($"Delete staff '{selected.Name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _staffList.Remove(selected)
            _dataService.SaveData(_staffList.ToList())
        End If
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Dim exportType = MessageBox.Show("Export as CSV/Excel? (Yes for CSV, No for JSON)", "Export Type", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If exportType = DialogResult.Cancel Then Return
        Dim sfd As New SaveFileDialog()
        If exportType = DialogResult.Yes Then
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = $"Staff_{Date.Now:yyyyMMddHHmmss}.csv"
        Else
            sfd.Filter = "JSON Files (*.json)|*.json"
            sfd.FileName = $"Staff_{Date.Now:yyyyMMddHHmmss}.json"
        End If
        If sfd.ShowDialog() = DialogResult.OK Then
            If exportType = DialogResult.Yes Then
                CsvExportHelper.ExportListToCsv(_staffList.ToList(), sfd.FileName)
            Else
                Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(_staffList.ToList(), Newtonsoft.Json.Formatting.Indented)
                IO.File.WriteAllText(sfd.FileName, json)
            End If
            MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
