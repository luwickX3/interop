Imports Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
        Dim Libro = ExcelApp.Workbooks.Add

        Libro.Sheets(1).Cells(1, 1) = "hola mundo"
        Libro.SaveAs(Filename:="C:\Users\Rodrigo Alexis\Escritorio\Test.xlsx")

        ExcelApp.Quit()

        Libro = Nothing
        ExcelApp = Nothing
    End Sub
End Class
