Public Class Reciept
    Private Sub Reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GenReciept(Total As Decimal)
        RichTextBox1.Text += "Total: " + Total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font, Brushes.Black, 100, 100)

    End Sub
End Class