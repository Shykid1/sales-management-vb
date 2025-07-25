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
        Try
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.FileName = $"Staff_{DateTime.Now:yyyyMMddHHmmss}"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    Dim dt = ToDataTableFromGrid(DataGridView1)
                    If dt.Rows.Count > 0 Then
                        ExcelExportHelper.ExportDataTableToExcel(dt, saveFileDialog.FileName, "Staff")
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
                saveFileDialog.FileName = $"Staff_{DateTime.Now:yyyyMMddHHmmss}"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Cursor = Cursors.WaitCursor
                    Dim data = TryCast(DataGridView1.DataSource, System.ComponentModel.BindingList(Of Staff))
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
