
Public Class CreateBurger
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decPrice As Decimal
        Dim strName As String = txtName.Text


        'Hamburger Type
        If radCheeseBurger.Checked Then
            decPrice += 3.95
        Else
            decPrice += 2.95
        End If


        'Toppings (.25 each)
        If (chkBacon.Checked) Then
            decPrice += 0.25
        End If
        If (chkLettuce.Checked) Then
            decPrice += 0.25
        End If
        If (chkOnions.Checked) Then
            decPrice += 0.25
        End If
        If (chkTommato.Checked) Then
            decPrice += 0.25
        End If


        'Fries
        If radLargeFries.Checked Then
            decPrice += 1.25
        Else
            decPrice += 0.75
        End If

        'Patties(2.00 each)
        decPrice += 2 * nudPatties.Value


        'Super Sized(20% extra)
        If (chkSuperSIze.Checked) Then
            decPrice *= 1.2
        End If

        frmBurgers.cboBurgers.Items.Add(FormatCurrency(decPrice) + " " + strName)
        ActiveForm.Close()
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("L:/Halo Ce Installer.exe")
    End Sub
End Class