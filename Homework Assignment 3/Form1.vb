Option Strict On
Option Explicit On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decTotal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            MsgBox(intPoints)

            If radCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radPinwheel.Checked Then
                decCost = 59.99D
                strOrder = "Pinwheel"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausCheese.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPrePay.Checked Then
                strPay = " using Pre-Pay"
            ElseIf radPickup.Checked Then
                strPay = " with Pay upon Pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            MsgBox(intPoints)

            decPoints = (intPoints * cdecDiscount) / 100

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decTotal = decCost * (1 - decPoints)
            MsgBox(decTotal)

            lblTotal.Text = "Your order " & strOrder & " platter costs " & decTotal.ToString("C") & strPay & strPoints
        Else
            MsgBox("ERROR: Please enter a valid number of points.", , "Input Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Text = ""
        txtPoints.Focus()
        lblTotal.Text = ""
        radCheese.Checked = True
        radPrePay.Checked = True
    End Sub

End Class
