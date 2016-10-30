'Name:    Super Size
'Purpose: Order Burgers
'Cretaed: 10/30/16
Public Class frmBurgers
    Dim decTotal As Decimal
    Dim decTax As Decimal
    Const decTAXRATE As Decimal = 0.07

    Private Sub frmBurgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvBurgers.Columns.Add("Item", 200, HorizontalAlignment.Left)
        lsvBurgers.Columns.Add("Price", 50, HorizontalAlignment.Left)
        lsvBurgers.Columns.Add("Order Number", 90, HorizontalAlignment.Left)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Static intOrder As Integer
        intOrder += 1
        Dim Order(2) As String
        Dim strOrder As ListViewItem
        Order(0) = cboBurgers.Text
        Order(1) = FormatCurrency(GetPrice()).ToString()
        Order(2) = intOrder.ToString()
        strOrder = New ListViewItem(Order)
        lsvBurgers.Items.Add(strOrder)
        decTotal += FormatCurrency(GetPrice())

    End Sub

    Function GetPrice()
        Dim intPrice As String = Nothing
        If IsNumeric(cboBurgers.Text(5)) Then
            For i = 0 To 4
                intPrice += cboBurgers.Text(i)
            Next
            Return intPrice
        Else
            For i = 0 To 3
                intPrice += cboBurgers.Text(i)
            Next
            Return intPrice
        End If
    End Function

    Private Sub lsvBurgers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lsvBurgers.MouseDoubleClick
        Dim intIndex As Integer = lsvBurgers.FocusedItem.Index
        lsvBurgers.Items.RemoveAt(intIndex)
    End Sub

    Private Sub btnRep_Click(sender As Object, e As EventArgs) Handles btnRep.Click
        Dim frmRecipet As New Form
        frmRecipet = Reciept
        frmRecipet.Show()
        Reciept.RichTextBox1.Text += vbCrLf
        For Each item As ListViewItem In Me.lsvBurgers.Items
            If Reciept.RichTextBox1.Text(0) = "$" Then
                Reciept.RichTextBox1.Text += vbCrLf + item.Text
            Else
                Reciept.RichTextBox1.Text += vbCrLf + "$" + item.Text
            End If
        Next

        Reciept.RichTextBox1.Text += "---------------------------------------------------------------"
        Reciept.RichTextBox1.Text += vbCrLf + "Total: " + FormatCurrency(decTotal)
        Reciept.RichTextBox1.Text += vbCrLf + "Tax: " + FormatCurrency(decTotal * decTAXRATE)
        Reciept.RichTextBox1.Text += vbCrLf + "Grand Total: " + FormatCurrency(decTotal + (decTotal * decTAXRATE))

        Reciept.RichTextBox1.Text += vbCrLf + "---------------------------------------------------------------"
        Reciept.RichTextBox1.Text += vbCrLf + "Date: " + Today
        Reciept.RichTextBox1.Text += vbCrLf + "Thanks Come again!"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        Dim Create As New Form
        Create = CreateBurger
        Create.Show()
    End Sub
End Class
