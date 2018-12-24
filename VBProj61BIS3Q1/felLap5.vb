Public Class felLap5


    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        price = Val(txtPrice.Text)
        Unit = Val(txtUnit.Text)

        Total = price * Unit
        lblTotal.Text = Total

    End Sub


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click



        If Total >= 10000 Then
            Discount = Total * 15 / 100
        ElseIf Total < 10000 Then
            Discount = Total * 10 / 100
        ElseIf Total < 5000 Then
            Discount = Total * 5 / 100
        ElseIf Total < 1000 Then
            Discount = 0
        Else

        End If
        If radMember.Checked = True Then
            If radPaid.Checked = True Then
                lblDiscount.Text = Discount
                Net = Total - Discount
                lblPaid.Text = Net
                lblCredit.Text = 0
            End If
            If radCredit.Checked = True Then
                lblDiscount.Text = lblTotal.Text
                lblCredit.Text = lblTotal.Text
                lblPaid.Text = lblTotal.Text
                lblDiscount.Text = 0
            End If
        End If
        If radOthe.Checked = True Then
            If radPaid.Checked = True Then
                lblDiscount.Text = 0
                lblPaid.Text = Total
                lblCredit.Text = 0
            ElseIf radCredit.Checked = False Then


            End If
        End If


        If (price = 0) Then
            MessageBox.Show("กรุณาป้อนข้อมลู")
        ElseIf (Unit = 0) Then
            MessageBox.Show("กรุณาป้อนข้อมลู")
        End If


    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        gpbPaid.Enabled = True
        radPaid.Checked = True
        radCredit.Checked = False



    End Sub

    Private Sub gpbPaid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpbPaid.Enter

    End Sub

    Private Sub radOthe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOthe.CheckedChanged
        radPaid.Checked = True
        gpbPaid.Enabled = False

    End Sub
End Class