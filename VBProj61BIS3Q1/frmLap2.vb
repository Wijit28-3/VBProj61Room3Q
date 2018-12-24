Public Class frmLap2

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim product_vg As Integer 'ตัวแปลสินค้า
        Dim product_fg As Integer
        Dim sall As Integer     'ตัวแปลยอดขาย
        Dim total1 As Integer
        Dim total2 As Integer
        Dim com1 As Integer

        product_vg = txtsalaryVG.Text
        product_fg = txtsalaryFG.Text

        sall = product_fg + product_vg
        labtotal.Text = sall

        total1 = product_vg * 0.05
        total2 = product_fg * 0.1

        com1 = total1 + total2
        labcomtotal.Text = com1


    End Sub
End Class