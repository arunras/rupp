Public Class frmProductCost

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmProductCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fd_id As String = FrmItems.txtFoodDrinkID.Text
        Dim str As String
        If fd_id.Trim = "" Then
            str = "SELECT I.ite_id, I.ite_name, T.typ_name, IM.imp_unit_price" _
                    & " FROM (tbl_import_details AS IM INNER JOIN tbl_items AS I ON IM.ite_id = I.ite_id) INNER JOIN tbl_types AS T ON IM.typ_id = T.typ_id;"
        Else
            str = "SELECT I.ite_id, I.ite_name, T.typ_name, IM.imp_unit_price" _
                    & " FROM (tbl_import_details AS IM INNER JOIN tbl_items AS I ON IM.ite_id = I.ite_id) INNER JOIN tbl_types AS T ON IM.typ_id = T.typ_id WHERE I.ite_id=" & fd_id
        End If
        _AddDataToListview(lvProduct, str)
    End Sub
End Class