Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbCommand
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data.OleDb.OleDbDataAdapter
Module mod_Rest

#Region "Declaration"
    Public MTip As New ToolTip
#End Region
    'caught number of employee for add family
    'Public frmID As Integer


    'Public ledit As String
    'Public ladd As String
    'Public Language As String
    'Dim GetStrConn As String
    Public userPermision As String
    Public Con As New OleDb.OleDbConnection
    Public com As New OleDb.OleDbCommand
    'Public OldLanguage As String
    'it is used to call in main form
    'Public Sub LoadForm(ByVal frm As Form)

    '    'frm.MdiParent = frmmain
    '    frm.FormBorderStyle = FormBorderStyle.None
    '    'frm.FormBorderStyle = FormBorderStyle.FixedSingle
    '    For Each ctrl As Control In frm.Controls
    '        ctrl.Anchor = AnchorStyles.None
    '    Next
    '    frm.Show()
    '    frm.Dock = DockStyle.Fill
    '    'For Each tl As ToolStripItem In frmmain.lstForm.Items
    '    '    If tl.Name = frm.Name.Substring(3) Then
    '    '        tl.Visible = True
    '    '        If frm.Text <> "" Then
    '    '            tl.Text = frm.Text
    '    '        Else
    '    '            tl.Text = tl.Name
    '    '        End If
    '    '        Exit For
    '    '    End If
    '    'Next
    'End Sub

    'it is used to call in each form when it is closing
    'Public Sub CloseForm(ByVal frm As Form)
    '    frm.Close()
    '    'For Each tl As ToolStripItem In frmmain.lstForm.Items
    '    '    If tl.Name = frm.Name.Substring(3) Then
    '    '        tl.Visible = False
    '    '        Exit For
    '    '    End If
    '    'Next

    'End Sub
    Sub _FillCombobox(ByVal cbo As ComboBox, ByVal sqlStatement As String)
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader(sqlStatement)
        Do While dr.Read
            cbo.Items.Add(Trim(dr.Item(0).ToString))
        Loop
    End Sub
    Sub _FillCombobox(ByVal sqlStatement As String, ByVal ParamArray cbo() As ComboBox)
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader(sqlStatement)
        If dr.HasRows Then
            While dr.Read
                For i As Integer = 0 To cbo.GetUpperBound(0)
                    cbo(i).Items.Add(Trim(dr(i).ToString))
                Next
            End While
        End If
    End Sub

    Public Sub _AutoFillRecordDg(ByVal dg As DataGridView, ByVal sqlStatement As String, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim dr As OleDb.OleDbDataReader
        Dim i As Integer
        dr = _SQLReader(sqlStatement)
        Dim grdrow As New DataGridViewRow()
        grdrow = dg.Rows(e.RowIndex)
        If dr.HasRows Then
            For i = 0 To dr.FieldCount - 1
                grdrow.Cells(i).Value = dr.Item(i)
            Next i
        Else
            grdrow.Cells(e.ColumnIndex).Value = Nothing
            For i = 0 To dg.ColumnCount - 1
                dg.Item(i, e.RowIndex).Value = Nothing
            Next
            dg.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Public Sub _AddRecordDg(ByVal dg As DataGridView, ByVal sqlStatement As String)
        dg.Rows.Clear()
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader(sqlStatement)
        Do While dr.Read
            Dim grdrow As New DataGridViewRow()
            grdrow.CreateCells(dg)
            For i As Integer = 0 To dr.FieldCount - 1
                grdrow.Cells(i).Value = dr.Item(i)
            Next i
            dg.Rows.Add(grdrow)
        Loop
    End Sub

    Public Sub _LoadDataFromTableToDataGrid(ByVal dg As DataGridView, ByVal sqlStatment As String)
        Dim dr As OleDb.OleDbDataReader
        Dim j As Integer = 0
        dr = _SQLReader(sqlStatment)
        If Not dr.HasRows Then
            Exit Sub
        End If
        While dr.Read
            j = j + 1
            Dim grdrow As New DataGridViewRow()
            grdrow.CreateCells(dg)
            grdrow.Cells(0).Value = j
            For i As Integer = 1 To dg.ColumnCount - 1
                grdrow.Cells(i).Value = dr.Item(i - 1)
            Next i
            dg.Rows.Add(grdrow)
        End While
    End Sub

    Public Sub _AddDataToListview(ByVal ListView As ListView, ByVal Sql As String)
        Dim li As ListViewItem
        Dim DataReader As OleDb.OleDbDataReader
        DataReader = _SQLReader(Sql)
        Try
            ListView.Items.Clear()
            If DataReader.HasRows Then
                While DataReader.Read = True
                    li = ListView.Items.Add(DataReader(0))
                    For i As Byte = 1 To ListView.Columns.Count - 1
                        li.SubItems.Add(Trim(IIf(Microsoft.VisualBasic.IsDBNull(DataReader(i)) = True, "", DataReader(i))))
                    Next
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If Not DataReader Is Nothing Then DataReader.Close()
    End Sub

    Function _isDuplicate(ByVal tb As String, ByVal field As String, ByVal value As String) As Boolean
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader("SELECT " & field & " FROM " & tb & " WHERE " & field & "=" & _sqlField(value))
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    Function _isDuplicate(ByVal tb As String, ByVal field As String, ByVal value As String, ByVal fieldKey As String, ByVal keyvalue As String) As Boolean
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader("SELECT " & field & " FROM " & tb & " WHERE " & field & "=" & _sqlField(value) & " AND " & fieldKey & "=" & keyvalue)
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub _NumberOnly(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByVal msg As Boolean)
        If e.KeyChar = "." Or e.KeyChar = " " Or e.KeyChar = "-" Or e.KeyChar = vbBack Then
            Exit Sub
        End If
        If Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
            If msg Then MsgBox("Number Only!", MsgBoxStyle.Critical, "Invalid Data")
        End If
    End Sub

    Sub _CharacterOnly(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByVal msg As Boolean)
        If Char.IsDigit(e.KeyChar) = True Then
            e.Handled = True
            If msg Then MsgBox("Character Only", MsgBoxStyle.Critical, "Invalid Data")
        End If
    End Sub
    Function _AutoID(ByVal TableName As String, ByVal field As String) As Long
        Dim id As Long
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader("SELECT MAX(" & field & ") from " & TableName)

        If dr.HasRows Then
            While dr.Read
                id = Val(dr(0).ToString) + 1
            End While
        Else
            id = 1
        End If
        Return id


    End Function


    Function _SQLReader(ByVal sql As String) As OleDb.OleDbDataReader
        If Con.State = ConnectionState.Closed Then
            _OpenConnection()
        End If
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim dr As OleDb.OleDbDataReader
            With cmd
                .CommandType = Data.CommandType.Text
                .CommandText = sql
                .Connection = Con
                dr = .ExecuteReader
            End With
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Function toNumber(ByVal st As Object) As Double
        If st = Nothing Then
            Return 0
        Else : Return Val(st)
        End If
    End Function
    Sub _SQLExecute(ByVal SQL As String)
        Try
            If Con.State = ConnectionState.Closed Then
                _OpenConnection()
            End If
            Dim cmd As New OleDb.OleDbCommand
            com.CommandText = SQL
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function _sqlField(ByVal fil As String) As String
        Dim f As String
        If fil = "" Then
            f = "'NA'"
        Else
            f = "'" & fil & "'"
        End If
        Return f
    End Function

    Function _toInt(ByVal st As Object) As Integer
        If st = Nothing Then
            Return 0
        Else : Return CInt(st)
        End If
    End Function

    Public Sub _OpenConnection()
        Dim GetStrConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\resaurant.accdb;Persist Security Info=True"
        If Con.State = ConnectionState.Open Then
            Exit Sub
        End If
        If GetStrConn <> "" Then
            Try
                Con.ConnectionString = GetStrConn
                Con.Open()
                com.Connection = Con
            Catch ex As Exception
                MsgBox(ex.Message)
                'Connections.Show()
            End Try
        Else
            'Connections.Show()
        End If
    End Sub

    Public Sub _SetListColorOfRow(ByVal LV As ListView)
        Dim BackColor As Color
        Dim TextColor As Color
        For i As Integer = 0 To LV.Items.Count - 1
            If i Mod 2 Then
                BackColor = Color.White
                TextColor = Color.Black
            Else
                BackColor = Color.AliceBlue
                TextColor = Color.Black
            End If
            LV.Items(i).BackColor = BackColor
            LV.Items(i).ForeColor = TextColor
        Next
    End Sub

    Sub _txtClear(ByVal frm As Control)
        Dim con As Control
        For Each con In frm.Controls
            If TypeOf con Is TextBox Or TypeOf con Is ComboBox Then
                con.Text = ""
            ElseIf con.HasChildren = True Then
                _txtClear(con)
            End If
        Next
    End Sub

    'Sub _LoadItemToCombobox(ByVal cbo As ComboBox, ByVal sql As String)

    '    Dim DataReader As OleDb.OleDbDataReader
    '    DataReader = _SQLReader(sql)
    '    Try
    '        cbo.Items.Clear()
    '        While DataReader.Read = True
    '            cbo.Items.Add(DataReader(0))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    If Not DataReader Is Nothing Then DataReader.Close()
    'End Sub



    ' insert data to listview not related to database
    Sub _AddDataToListView(ByVal lv As ListView, ByVal ParamArray dataField() As String)
        Dim lvi As ListViewItem = lv.Items.Add(dataField(0))
        For i As Integer = 1 To dataField.GetUpperBound(0)
            lvi.SubItems.Add(dataField(i))
        Next
    End Sub

    ' update data in listview not related to databse yet
    Sub _UpdateDataInListView(ByVal lv As ListView, ByVal ParamArray dataField() As String)
        Dim index As Integer = _SelectedIndexOfListView(lv)
        If index > -1 Then
            With lv
                For j As Integer = 0 To dataField.GetUpperBound(0)
                    .Items(index).SubItems(j).Text = dataField(j)
                Next
            End With
        End If

    End Sub

    ' function to return the index of seleted row in listview
    Function _SelectedIndexOfListView(ByVal lv As ListView) As Integer
        With lv
            For i As Integer = 0 To .Items.Count - 1
                If .Items(i).Selected Then
                    Return i
                End If
            Next
        End With
        Return -1
    End Function

    ' sub procedure coparing typing in cbo and its values
    Sub _CompareTextInComboToItList(ByVal cbo As ComboBox)
        Dim str As String = cbo.Text
        Dim right As Boolean = False

        For i As Integer = 0 To cbo.Items.Count - 1
            If str.ToUpper = cbo.Items(i).ToString.ToUpper Then
                right = True
                Exit For
            Else
                right = False
            End If
        Next
        If Not right Then
            cbo.Text = ""
            cbo.Focus()
        End If
    End Sub

    ' delete record from listview
    Sub _DeleteListViewItem(ByVal lv As ListView)
        For i As Integer = 0 To lv.Items.Count - 1
            Dim index As Integer = _SelectedIndexOfListView(lv)
            If index > -1 Then
                lv.Items(index).Remove()
                lv.Refresh()
            End If
        Next
    End Sub

    'check null
    Function _CheckNull(ByVal frm As Form) As Boolean
        Dim c As Control
        For Each c In frm.Controls
            If TypeOf c Is TextBox Then
                If c.Text.Trim = "" Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    'function to clear selection of the ListView, i.e. no value selected
    Sub _ClearSelectedIndexOfListView(ByVal lv As ListView)
        With lv
            For i As Integer = 0 To .Items.Count - 1
                If .Items(i).Selected Then
                    .Items(i).Selected = False
                End If
            Next
        End With
    End Sub

    Function _CheckRecord(ByVal tbl As String) As Boolean

        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader("SELECT * FROM " & tbl)
        Return dr.HasRows
        dr.Close()
    End Function

    Function _ReplaceSpace(ByVal str As String) As String

        For i As Integer = 0 To str.Length
            If str(i) = " " Then str = ""
        Next
        Return str

    End Function

    Function _sqlFillLIKE(ByVal field As String) As String
        Return "'%" & field & "%'"
    End Function


#Region "Run Function"

    Sub UpdateItem(ByVal tblName As String, ByVal SetUpdateFields As String, ByVal CondField As String)
        ExecuteSQL("UPDATE " & tblName & " SET " & SetUpdateFields & " WHERE " & CondField)
    End Sub

    Function Field(ByVal fil As String) As String
        Dim f As String
        If fil = "" Then
            f = "'NA'"
        Else
            f = "'" & fil & "'"
        End If
        Return f
    End Function

    Public Sub SetListColor(ByVal LV As ListView)
        Dim BackColor As Color
        Dim TextColor As Color
        For i As Integer = 0 To LV.Items.Count - 1
            If i Mod 2 Then
                BackColor = Color.White
                TextColor = Color.Black
            Else
                BackColor = Color.AliceBlue
                TextColor = Color.Black
            End If
            LV.Items(i).BackColor = BackColor
            LV.Items(i).ForeColor = TextColor
        Next
    End Sub

    Sub Clear(ByVal frm As Control)
        Dim con As Control
        For Each con In frm.Controls
            If TypeOf con Is TextBox Or TypeOf con Is ComboBox Then
                con.Text = ""
            ElseIf con.HasChildren = True Then
                Clear(con)
            End If
        Next
    End Sub

    Sub LoadItemToCombobox(ByVal cbo As ComboBox, ByVal sql As String)
        'Dim rst As ADODB.Recordset
        'rst = Cn.Execute(sqlStatement)
        'Do While Not rst.EOF
        '    cbo.Items.Add(rst(0).Value)
        '    rst.MoveNext()
        'Loop
        'rst.Close()
        Dim DataReader As OleDb.OleDbDataReader
        DataReader = _SQLReader(sql)
        Try
            cbo.Items.Clear()
            While DataReader.Read = True
                cbo.Items.Add(DataReader(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If Not DataReader Is Nothing Then DataReader.Close()
    End Sub

    Sub runDeleteItem(ByVal listName As ListView, ByVal tbl As String, ByVal Dwhere As String)
        Dim i As Integer, str As String
        Dim strMsg As String
        If listName.Items.Count < 0 Then
            MsgBox("No Items")
            Exit Sub
        End If
        If listName.SelectedItems.Count > 0 Then
            For i = 0 To listName.Items.Count - 1
                If listName.Items(i).Selected = True Then
                    Exit For
                End If
            Next
            strMsg = MessageBox.Show("Do you want to delete?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If strMsg = Windows.Forms.DialogResult.Yes Then
                str = "DELETE  FROM " & tbl & " WHERE " & Dwhere & " =" & Val(listName.Items(i).SubItems(0).Text)
                ExecuteSQL(str)
                'listName.Items.RemoveAt(i)
                'Call AddToListview(listName, "Select * From " & tbl & "")
            End If
        Else
            MsgBox("Please Select Item first!", MsgBoxStyle.Exclamation, "Not yet seleted")
        End If
    End Sub

    Sub ExecuteSQL(ByVal SQL As String)
        If Con.State = ConnectionState.Closed Then
            _OpenConnection()
        End If
        Dim cmd As New OleDb.OleDbCommand
        com.CommandText = SQL
        com.ExecuteNonQuery()
    End Sub

    'it is used to call in main form
    Public Sub LoadForm(ByVal frm As Form)
        frm.MdiParent = frmMain
        frm.FormBorderStyle = FormBorderStyle.None
        For Each ctrl As Control In frm.Controls
            ctrl.Anchor = AnchorStyles.None
        Next
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Sub FadeForm(ByVal FadeForm As Form, ByVal NumberOfSteps As Byte)
        Dim StepVal As Double = Convert.ToDouble(100.0F / NumberOfSteps)
        Dim dOpacity As Double = 100.0F
        Dim b As Byte = 0
        For b = 0 To NumberOfSteps
            FadeForm.Opacity = dOpacity / 100
            FadeForm.Refresh()
            dOpacity -= StepVal
        Next
    End Sub

    Public Sub MsgToolTip(ByVal Title As String, ByVal Message As String, ByVal Icon As System.Windows.Forms.ToolTipIcon, ByVal Cont As Object, ByVal Duration As Integer)
        Dim x As Integer
        x = Cont.GetPositionFromCharIndex(Cont.Text.Length - 1).X + 20
        MTip.Hide(Cont)

        MTip.IsBalloon = True 'display as balloon
        MTip.ToolTipTitle = Title 'set the title to the balloon
        MTip.ToolTipIcon = Icon 'set the icon to display
        MTip.BackColor = Color.BlanchedAlmond
        MTip.Show(Message, Cont, x, Cont.Height - Cont.Height / 3, Duration) ' the pointer will be point to the bottom
        My.Application.DoEvents()
        MTip.Show(Message, Cont, x, Cont.Height - Cont.Height / 3, Duration) 'the pointer will be point to the top

    End Sub

#End Region

End Module


