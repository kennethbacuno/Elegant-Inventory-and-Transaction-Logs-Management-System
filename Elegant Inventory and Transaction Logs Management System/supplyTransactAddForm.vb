
Public Class supplyTransactAddForm
    Dim query As String
    Dim empId As String
    Dim suppId As String
    Dim supplyTransactID As Integer

    Public Sub RemoveUserControl()
        Dim controlsToRemove As New List(Of Control)

        For Each control As Control In Me.Controls
            If TypeOf control Is UserControl Then
                controlsToRemove.Add(control)
            End If
        Next

        For Each control As Control In controlsToRemove
            Me.Controls.Remove(control)
            control.Dispose()

        Next
    End Sub

    Private Sub supplyTransactAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSupplierName()
        loadEmployeeName()
        loadProductInfo()
        LoadTotal()
        btnDelete.Enabled = False
    End Sub

    Public Sub loadSupplierName()
        query = "select SupplierID, LastName, GivenName from supplier"
        readQuery(query)
        Try
            While cmdReader.Read
                tableSupplierName.Rows.Add(cmdReader.Item("SupplierID"), cmdReader.Item("LastName"), cmdReader.Item("GivenName"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub loadEmployeeName()
        query = "select EmployeeID, LastName, GivenName from employee"
        readQuery(query)
        Try
            While cmdReader.Read
                tableEmployeeName.Rows.Add(cmdReader.Item("EmployeeID"), cmdReader.Item("LastName"), cmdReader.Item("GivenName"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub loadProductInfo()
        query = "select * from product"
        readQuery(query)
        Try
            While cmdReader.Read
                cmbxProduct.Items.Add(cmdReader.Item("ProductName"))
                cmbxGroup.Items.Add(cmdReader.Item("ProductGroup"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnViewEmployee_Click(sender As Object, e As EventArgs) Handles btnViewEmployee.Click
        Dim ucEmployeeInfo As New relatedEmployeeInfo()
        Dim x As Integer = (Me.Width - ucEmployeeInfo.Width) \ 2
        Dim y As Integer = (Me.Height - ucEmployeeInfo.Height) \ 2
        ucEmployeeInfo.Location = New Point(x, y)
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = False
        Next
        RemoveUserControl()
        ucEmployeeInfo.passedEmployee = tableEmployeeName.CurrentRow.Cells(0).Value.ToString
        Me.Controls.Add(ucEmployeeInfo)
        ucEmployeeInfo.BringToFront()
        AddHandler ucEmployeeInfo.Disposed, AddressOf EmpInfoDisposed
    End Sub

    Private Sub btnViewSupplier_Click(sender As Object, e As EventArgs) Handles btnViewSupplier.Click
        Dim ucSupplierInfo As New relatedSuppInfo()
        Dim x As Integer = (Me.Width - ucSupplierInfo.Width) \ 2
        Dim y As Integer = (Me.Height - ucSupplierInfo.Height) \ 2
        ucSupplierInfo.Location = New Point(x, y)
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = False
        Next
        RemoveUserControl()
        ucSupplierInfo.passedEmployee = tableSupplierName.CurrentRow.Cells(0).Value.ToString
        Me.Controls.Add(ucSupplierInfo)
        ucSupplierInfo.BringToFront()
        AddHandler ucSupplierInfo.Disposed, AddressOf SuppInfoDisposed
    End Sub

    Private Sub tableEmployeeName_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableEmployeeName.CellClick
        btnViewEmployee.Enabled = True
    End Sub

    Private Sub tableSupplierName_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableSupplierName.CellClick
        btnViewSupplier.Enabled = True
    End Sub

    Private Sub EmpInfoDisposed(sender As Object, e As EventArgs)
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub SuppInfoDisposed(sender As Object, e As EventArgs)
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
        Clear()
    End Sub

    Public Sub Add()
        tableSupplyInclusion.Rows.Add(cmbxProduct.Text, cmbxGroup.Text, txtQty.Text, txtPrice.Text, (CInt(txtQty.Text) * CDec(txtPrice.Text).ToString))
        Clear()
        LoadTotal()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Public Sub Clear()
        txtQty.Clear()
        txtPrice.Clear()
        cmbxProduct.SelectedItem = Nothing
        cmbxGroup.SelectedItem = Nothing
    End Sub

    Private Sub tableSupplyInclusion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableSupplyInclusion.CellClick
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tableSupplyInclusion.Rows.Remove(tableSupplyInclusion.CurrentRow)
        btnDelete.Enabled = False
        LoadTotal()
    End Sub

    Public Sub LoadTotal()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In tableSupplyInclusion.Rows
            If Not row.Cells(4).Value Is Nothing AndAlso Not IsDBNull(row.Cells(4).Value) Then
                total += row.Cells(4).Value
            End If
        Next
        txtTotal.Text = total.ToString
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveTransact()
    End Sub

    Public Sub SaveTransact()
        If MessageBox.Show("Do you want to save this supply transaction?", "SUPPLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                query = "INSERT INTO `supplytransactions`(`SupplyID`, `SupplierID`, `EmployeeID`, `SupplyDate`, `TotalCost`) VALUES ('','" & tableSupplierName.CurrentRow.Cells(0).Value.ToString & "','" & tableEmployeeName.CurrentRow.Cells(0).Value.ToString & "','" & dtpickerSupply.Value.ToString("yyyy-MM-dd") & "','" & txtTotal.Text & "')"
                readQuery(query)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                query = "select SupplyID from supplytransactions"
                readQuery(query)
                While cmdReader.Read
                    supplyTransactID = CInt(cmdReader.Item("SupplyID"))
                End While
            Catch ex As Exception

            End Try

            For Each row As DataGridViewRow In tableSupplyInclusion.Rows
                Try
                    query = "INSERT INTO `suppy_invoice` (`SupplyID`, `ProductName`, `ProductGroup`,`Quantity`, `Cost`, `Total`) VALUES ('" & supplyTransactID & "','" & row.Cells(0).Value.ToString & "','" & row.Cells(1).Value.ToString & "','" & row.Cells(2).Value.ToString & "','" & row.Cells(3).Value.ToString & "', '" & row.Cells(4).ToString & "')"
                    readQuery(query)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

            For Each row As DataGridViewRow In tableSupplyInclusion.Rows
                Try
                    Dim price As Double
                    Dim stock As Integer
                    Dim counter As Integer = 0
                    query = "SELECT * FROM product WHERE ProductName = '" & row.Cells(0).Value.ToString & "'"
                    readQuery(query)

                    If cmdReader.Read() Then
                        counter += 1
                        stock = CInt(cmdReader.Item("Stock"))
                    End If

                    price = CDbl(row.Cells(3).Value.ToString) + (CDbl(row.Cells(3).Value.ToString) * 0.1)

                    If counter <= 0 Then
                        query = "INSERT INTO `product`(`ProductName`, `ProductGroup`, `Price`, `Stock`) VALUES ('" & row.Cells(0).Value.ToString & "','" & row.Cells(1).Value.ToString & "','" & price & "','" & row.Cells(2).Value.ToString & "')"
                    Else
                        query = "UPDATE `product` SET `ProductGroup`='" & row.Cells(1).Value.ToString & "',`Price`='" & price & "',`Stock`='" & CInt(row.Cells(2).Value.ToString) + stock & "' WHERE `ProductName`='" & row.Cells(0).Value.ToString & "'"
                    End If

                    readQuery(query)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

            supplyTransactID += 1
            MessageBox.Show("Saved successfully.", "SUPPLY", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Record did not save.", "SUPPLY", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub cmbxProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxProduct.SelectedIndexChanged
        query = "select * from product"
        readQuery(query)
        Try
            While cmdReader.Read
                If cmdReader.Item("ProductName") = cmbxProduct.Text Then
                    cmbxGroup.Text = cmdReader.Item("ProductGroup")
                    txtPrice.Text = CDbl(cmdReader.Item("Price")) - (CDbl(cmdReader.Item("Price")) * 0.1)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class