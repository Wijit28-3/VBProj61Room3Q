Public Class frmLap4
    Dim today As Date = Date.Now
    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblData.Text = FormatDateTime(today, DateFormat.ShortDate)
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblData.Text = FormatDateTime(today, DateFormat.GeneralDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblData.Text = FormatDateTime(today, DateFormat.LongDate)
    End Sub

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click

        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07


        Dim salary As Double
        Dim sale As Double
        Dim allIncome As Double
        Dim allowance As Double        Dim tex As Double

        salary = Val(txtSalary.Text) * 12
        sale = Val(txtSale.Text) * decR_BONUS
        allIncome = Val(salary + sale)
        allowance = Val(allIncome * decR_ALLOW)
        tex = Val(allIncome - allowance) * decR_TAX

        lblYearSalary.Text = FormatNumber(salary, 2)
        lblBonus.Text = FormatNumber(sale, 2)
        lblAllIncome.Text = FormatNumber(allIncome, 2)
        lblAllowance.Text = FormatNumber(allowance, 2)
        lblTax.Text = tex

    End Sub

    Private Sub frmLap4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblData.Text = FormatDateTime(today, DateFormat.GeneralDate)
    End Sub
End Class