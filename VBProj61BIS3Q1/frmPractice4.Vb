
Public Class frmPractice4
    Const decDISCOUNT_RATE As Double = 0.05
    Dim strId, strName As String
    Dim intAmount As Integer
    Dim dblprice, dblotal, dblDicount, dbNet As Double


    Private Sub frmPractice4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strId = "P001"
        strName = "Computer"
        dblprice = 55000

        lblProId.Text = strId
        lblProName.Text = strName
        lblProPrice.Text = dblprice
    End Sub

    Private Sub txtProAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProAmount.TextChanged


        lblProTotal.Text = Val(txtProAmount.Text) * dblprice
        radProCash.Checked = True
        Call radProCash_CheckedChanged(sender, e)


    End Sub

    Private Sub radProCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radProCash.CheckedChanged
        dblDicount = Val(lblProTotal.Text) * decDISCOUNT_RATE
        lblProNet.Text = Val(lblProTotal.Text) - dblDicount

    End Sub

    Private Sub radProCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radProCredit.CheckedChanged
        lblProNet.Text = lblProTotal.Text
    End Sub
End Class