Imports System.Text
Imports ClosedXML.Excel
Imports System.Data

Public Class ExcelExportHelper
    Public Shared Sub ExportToExcel(Of T)(list As List(Of T), filePath As String, Optional sheetName As String = "Sheet1")
        If list Is Nothing OrElse list.Count = 0 Then Return
        Using workbook = New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add(sheetName)
            Dim props = GetType(T).GetProperties()
            Dim headers = props.Select(Function(p) GetDisplayName(p.Name)).ToList()
            For col = 0 To headers.Count - 1
                worksheet.Cell(1, col + 1).Value = headers(col)
            Next
            For row = 0 To list.Count - 1
                Dim item = list(row)
                For col = 0 To props.Count - 1
                    Dim value = props(col).GetValue(item, Nothing)
                    Dim cell = worksheet.Cell(row + 2, col + 1)
                    If TypeOf value Is DateTime Then
                        cell.Value = DirectCast(value, DateTime)
                        cell.Style.DateFormat.Format = "yyyy-MM-dd HH:mm:ss"
                    ElseIf TypeOf value Is Decimal OrElse TypeOf value Is Double Then
                        cell.Value = value
                        cell.Style.NumberFormat.Format = "#,##0.00"
                    Else
                        cell.Value = If(value, "")
                    End If
                Next
            Next
            Dim headerRow = worksheet.Range(1, 1, 1, headers.Count)
            headerRow.Style.Font.Bold = True
            headerRow.Style.Fill.BackgroundColor = XLColor.LightGray
            headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
            worksheet.Columns().AdjustToContents()
            worksheet.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            worksheet.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin
            worksheet.SheetView.FreezeRows(1)
            workbook.SaveAs(filePath)
        End Using
    End Sub

    Public Shared Sub ExportDataTableToExcel(dt As DataTable, filePath As String, Optional sheetName As String = "Sheet1")
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Return
        Using workbook = New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add(dt, sheetName)
            worksheet.Columns().AdjustToContents()
            worksheet.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin
            worksheet.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin
            worksheet.SheetView.FreezeRows(1)
            workbook.SaveAs(filePath)
        End Using
    End Sub

    Private Shared Function GetDisplayName(propertyName As String) As String
        Select Case propertyName
            Case "Id"
                Return "ID"
            Case "CustomerId"
                Return "Customer ID"
            Case "StaffId"
                Return "Staff ID"
            Case "TotalAmount"
                Return "Total Amount"
            Case "SaleDate"
                Return "Sale Date"
            Case Else
                Return System.Text.RegularExpressions.Regex.Replace(propertyName, "([A-Z])", " $1").Trim()
        End Select
    End Function
End Class
