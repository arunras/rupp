Public Class frmMain

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Login.Show()
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btbNewSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbNewSale.Click
        LoadForm(FrmSales)
    End Sub

    Private Sub btnAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(FrmAttendances)
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        LoadForm(frmEmployee)
    End Sub

    Private Sub btnPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPosition.Click
        LoadForm(FrmPossition)
    End Sub

    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        LoadForm(frmSupplier)
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        LoadForm(FrmUser)
    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(FrmStocks)
    End Sub

    Private Sub btnImports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImports.Click
        LoadForm(frmImport)
    End Sub

    Private Sub btnItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItems.Click
        LoadForm(FrmItems)
    End Sub

    Private Sub btnSalaryExpense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalaryExpense.Click
        LoadForm(frmSalaryExpense)
    End Sub

    Private Sub btnCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(FrmCurrency)
    End Sub

    Private Sub btnProductCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductCost.Click
        LoadForm(frmProductCost)
    End Sub

    Private Sub btnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnType.Click
        LoadForm(frmType)
    End Sub
End Class
