Imports System.Diagnostics.Eventing.Reader

Public Class supplyTransact
    Dim query As String

    Private Sub supplyTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplyTransactTable()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub LoadSupplyTransactTable()
        tableSupplyTransact.Rows.Clear()
        Dim suppliercmbx As DataGridViewComboBoxColumn = DirectCast(tableSupplyTransact.Columns("Column3"), DataGridViewComboBoxColumn)
        Dim employeecmbx As DataGridViewComboBoxColumn = DirectCast(tableSupplyTransact.Columns("Column9"), DataGridViewComboBoxColumn)
        Dim toUpdateSuppID As DataGridViewComboBoxColumn = DirectCast(tableSupplyTransact.Columns("Column17"), DataGridViewComboBoxColumn)
        Dim toUpdateEmployee As DataGridViewComboBoxColumn = DirectCast(tableSupplyTransact.Columns("Column18"), DataGridViewComboBoxColumn)
        suppliercmbx.Items.Clear()
        employeecmbx.Items.Clear()
        query = "select SupplierID, LastName, GivenName from supplier"
        readQuery(query)
        While cmdReader.Read
            Dim suppfullName As String = cmdReader.Item("LastName") & ", " & cmdReader.Item("GivenName")
            suppliercmbx.Items.Add(suppfullName)
            toUpdateSuppID.Items.Add(cmdReader.Item("SupplierID"))
        End While
        query = "select EmployeeID, LastName, GivenName from employee"
        readQuery(query)
        While cmdReader.Read
            Dim empfullName As String = cmdReader.Item("LastName") & ", " & cmdReader.Item("GivenName")
            employeecmbx.Items.Add(empfullName)
            toUpdateEmployee.Items.Add(cmdReader.Item("EmployeeID"))
        End While

        query = "SELECT supplytransactions.*,
supplier.LastName as supplname, supplier.GivenName as suppgname,
supplier.Sex as suppsex, supplier.Birthdate as suppbdate,
supplier.Province as suppadd1, supplier.Municipality as suppadd2,
supplier.Barangay as suppadd3, supplier.Purok as suppadd4, supplier.ContactNo as suppcontact,
employee.LastName emplname, employee.GivenName as empgname, employee.Role, employee.Sex as empsex,
employee.Birthdate as empbdate, employee.Municipality as empadd1, employee.Barangay as empadd2,
employee.Purok as empadd3, employee.ContactNo as empcontact
FROM supplytransactions
JOIN supplier ON supplier.supplierID = supplytransactions.supplierID
JOIN employee ON employee.employeeID = supplytransactions.employeeID
"
        readQuery(query)
        Try
            While cmdReader.Read
                Dim suppfullName As String = cmdReader.Item("supplname") & ", " & cmdReader.Item("suppgname")
                Dim empfullName As String = cmdReader.Item("emplname") & ", " & cmdReader.Item("empgname")

                ' Add a new row to the DataTable
                tableSupplyTransact.Rows.Add(cmdReader.Item("SupplyID"), cmdReader.Item("SupplierID"),
                                     suppfullName,
                                     cmdReader.Item("suppsex"), CType(cmdReader.Item("suppbdate"), DateTime).ToString("yyyy-MM-dd"),
                                     cmdReader.Item("suppadd1") & ", " & cmdReader.Item("suppadd2") & ", " & cmdReader.Item("suppadd3") & ", " & cmdReader.Item("suppadd4"),
                                     cmdReader.Item("suppcontact"), cmdReader.Item("EmployeeID"),
                                     empfullName,
                                     cmdReader.Item("Role"), cmdReader.Item("empsex"), CType(cmdReader.Item("empbdate"), DateTime).ToString("yyyy-MM-dd"),
                                     cmdReader.Item("empadd1") & ", " & cmdReader.Item("empadd2") & ", " & cmdReader.Item("empadd3"), cmdReader.Item("empcontact"),
                                     cmdReader.Item("SupplyDate"), cmdReader.Item("TotalCost"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadInvoiceTable()
        tableInvoice.Rows.Clear()
        query = "select * from suppy_invoice where SupplyID = '" & tableSupplyTransact.CurrentRow.Cells(0).Value & "'"
        readQuery(query)
        While cmdReader.Read
            tableInvoice.Rows.Add(cmdReader.Item("SupplyID"), cmdReader.Item("ProductName"), cmdReader.Item("ProductGroup"), cmdReader.Item("Quantity"), cmdReader.Item("Cost"), cmdReader.Item("Total"))
        End While
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        LoadSupplyTransactTable()
        Edit()
        btnUpdate.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub tableSupplyTransact_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles tableSupplyTransact.EditingControlShowing
        ' Check if the current cell is a ComboBox cell in the desired column
        If tableSupplyTransact.CurrentRow.Cells(2).ColumnIndex = tableSupplyTransact.Columns("Column3").Index AndAlso TypeOf e.Control Is ComboBox Then
            ' Attach SelectedIndexChanged event handler to the ComboBox
            Dim comboBox As ComboBox = TryCast(e.Control, ComboBox)
            AddHandler comboBox.SelectedIndexChanged, AddressOf SupplierComboBox_SelectedIndexChanged
        End If

        If tableSupplyTransact.CurrentRow.Cells(8).ColumnIndex = tableSupplyTransact.Columns("Column9").Index AndAlso TypeOf e.Control Is ComboBox Then
            ' Attach SelectedIndexChanged event handler to the ComboBox
            Dim comboBox As ComboBox = TryCast(e.Control, ComboBox)
            AddHandler comboBox.SelectedIndexChanged, AddressOf EmployeeComboBox_SelectedIndexChanged
        End If
    End Sub

    Private Sub SupplierComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim selectedIndex As Integer = comboBox.SelectedIndex
        Dim toUpdateSuppID As DataGridViewComboBoxColumn = DirectCast(tableSupplyTransact.Columns("Column17"), DataGridViewComboBoxColumn)
        tableSupplyTransact.CurrentRow.Cells(16).Value = toUpdateSuppID.Items(selectedIndex)
        query = "select * from supplier where SupplierID = '" & tableSupplyTransact.CurrentRow.Cells(16).Value & "'"
        readQuery(query)
        While cmdReader.Read
            tableSupplyTransact.CurrentRow.Cells(3).Value = cmdReader.Item("Sex")
            tableSupplyTransact.CurrentRow.Cells(4).Value = CType(cmdReader.Item("Birthdate"), DateTime).ToString("yyyy-MM-dd")
            tableSupplyTransact.CurrentRow.Cells(5).Value = cmdReader.Item("Province") + ", " + cmdReader.Item("Municipality") + ", " + cmdReader.Item("Barangay") + ", " + cmdReader.Item("Purok")
            tableSupplyTransact.CurrentRow.Cells(6).Value = cmdReader.Item("ContactNo")
        End While
    End Sub

    Private Sub EmployeeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)
        Dim selectedIndex As Integer = comboBox.SelectedIndex
        Dim toUpdateEmployee As DataGridViewComboBoxColumn = DirectCast(tableSupplyTransact.Columns("Column18"), DataGridViewComboBoxColumn)
        tableSupplyTransact.CurrentRow.Cells(17).Value = toUpdateEmployee.Items(selectedIndex)
        query = "select * from employee where EmployeeID = '" & tableSupplyTransact.CurrentRow.Cells(17).Value & "'"
        readQuery(query)
        While cmdReader.Read
            tableSupplyTransact.CurrentRow.Cells(9).Value = cmdReader.Item("Role")
            tableSupplyTransact.CurrentRow.Cells(10).Value = cmdReader.Item("Sex")
            tableSupplyTransact.CurrentRow.Cells(11).Value = CType(cmdReader.Item("Birthdate"), DateTime).ToString("yyyy-MM-dd")
            tableSupplyTransact.CurrentRow.Cells(12).Value = cmdReader.Item("Municipality") + ", " + cmdReader.Item("Barangay") + ", " + cmdReader.Item("Purok")
            tableSupplyTransact.CurrentRow.Cells(13).Value = cmdReader.Item("ContactNo")
        End While
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit()
        LoadSupplyTransactTable()
    End Sub

    Public Sub Edit()
        If MessageBox.Show("Do you insist to update this supply transaction record?", "SUPPLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                query = "UPDATE supplytransactions SET SupplierID = '" & tableSupplyTransact.CurrentRow.Cells(16).Value.ToString() & "', EmployeeID = '" & tableSupplyTransact.CurrentRow.Cells(17).Value.ToString() & "' WHERE SupplyID = '"& tableSupplyTransact.CurrentRow.Cells(0).Value.ToString() &"'"
                readQuery(query)
                MessageBox.Show("Updated Successfuly", "SUPPLY", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtSearchTransact_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTransact.TextChanged
        Dim key As String = txtSearchTransact.Text
        query = "SELECT supplytransactions.*,
supplier.LastName as supplname, supplier.GivenName as suppgname,
supplier.Sex as suppsex, supplier.Birthdate as suppbdate,
supplier.Province as suppadd1, supplier.Municipality as suppadd2,
supplier.Barangay as suppadd3, supplier.Purok as suppadd4, supplier.ContactNo as suppcontact,
employee.LastName emplname, employee.GivenName as empgname, employee.Role, employee.Sex as empsex,
employee.Birthdate as empbdate, employee.Municipality as empadd1, employee.Barangay as empadd2,
employee.Purok as empadd3, employee.ContactNo as empcontact
FROM supplytransactions
JOIN supplier ON supplier.supplierID = supplytransactions.supplierID
JOIN employee ON employee.employeeID = supplytransactions.employeeID
"
        readQuery(query)
        While cmdReader.Read
            Dim suppfullName As String = cmdReader.Item("supplname") & ", " & cmdReader.Item("suppgname")
            Dim empfullName As String = cmdReader.Item("emplname") & ", " & cmdReader.Item("empgname")
            If txtSearchTransact.Text = "" Or txtSearchTransact.Text = Nothing Then
                LoadSupplyTransactTable()
            Else
                tableSupplyTransact.Rows.Clear()
                If suppfullName = key Or empfullName = key Or CType(cmdReader.Item("SupplyDate"), DateTime).ToString("yyyy-MM-dd") = key Then
                    tableSupplyTransact.Rows.Add(cmdReader.Item("SupplyID"), cmdReader.Item("SupplierID"),
                                             suppfullName,
                                             cmdReader.Item("suppsex"), CType(cmdReader.Item("suppbdate"), DateTime).ToString("yyyy-MM-dd"),
                                             cmdReader.Item("suppadd1") & ", " & cmdReader.Item("suppadd2") & ", " & cmdReader.Item("suppadd3") & ", " & cmdReader.Item("suppadd4"),
                                             cmdReader.Item("suppcontact"), cmdReader.Item("EmployeeID"),
                                             empfullName,
                                             cmdReader.Item("Role"), cmdReader.Item("empsex"), CType(cmdReader.Item("empbdate"), DateTime).ToString("yyyy-MM-dd"),
                                             cmdReader.Item("empadd1") & ", " & cmdReader.Item("empadd2") & ", " & cmdReader.Item("empadd3"), cmdReader.Item("empcontact"),
                                             cmdReader.Item("SupplyDate"), cmdReader.Item("TotalCost"))
                End If
            End If
        End While
    End Sub

    Private Sub tableSupplyTransact_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableSupplyTransact.CellClick
        LoadInvoiceTable()
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you insist to delete this supply record?", "SUPPLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            query = "delete from supplytransactions where SupplyID = '" & tableSupplyTransact.CurrentRow.Cells(0).Value & "'"
            readQuery(query)
            MessageBox.Show("Deleted successfuly", "SUPPLY", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdateInvoice_Click(sender As Object, e As EventArgs) Handles btnUpdateInvoice.Click
        EditInvoice()
        LoadSupplyTransactTable()
        LoadInvoiceTable()
    End Sub

    Public Sub EditInvoice()
        If MessageBox.Show("Do you insist to update an item in this invoice record?", "SUPPLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            query = "update suppy_invoice set ProductName = '" & tableInvoice.CurrentRow.Cells(1).Value & "', ProductGroup = '" & tableInvoice.CurrentRow.Cells(2).Value & "', Quantity = '" & tableInvoice.CurrentRow.Cells(3).Value & "', Cost = '" & tableInvoice.CurrentRow.Cells(4).Value & "', Total = '" & CDbl(tableInvoice.CurrentRow.Cells(3).Value) * CDbl(tableInvoice.CurrentRow.Cells(4).Value) & "' where SupplyID = '" & tableSupplyTransact.CurrentRow.Cells(0).Value & "'"
            readQuery(query)
            MessageBox.Show("Updated successfuly", "SUPPLY", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub DeleteInvoice()
        If MessageBox.Show("Do you insist to delete an item in this invoice record?", "SUPPLY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            query = "delete from suppy_invoice where SupplyID = '" & tableSupplyTransact.CurrentRow.Cells(0).Value & "'"
            readQuery(query)
            MessageBox.Show("Deleted successfuly", "SUPPLY", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeleteInvoice_Click(sender As Object, e As EventArgs) Handles btnDeleteInvoice.Click
        DeleteInvoice()
        LoadSupplyTransactTable()
        LoadInvoiceTable()
    End Sub

    Private Sub txtSearchInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtSearchInvoice.TextChanged
        tableInvoice.Rows.Clear()
        Dim key As String = txtSearchInvoice.Text
        query = "SELECT * FROM suppy_invoice WHERE (ProductName LIKE '" & key & "' OR ProductGroup LIKE '" & key & "' OR Quantity LIKE '" & key & "' OR Cost LIKE '" & key & "') and SupplyID = '" & tableSupplyTransact.CurrentRow.Cells(0).Value & "'"
        readQuery(query)
        If txtSearchInvoice.Text = "" Or txtSearchInvoice.Text = Nothing Then
            LoadInvoiceTable()
        Else
            While cmdReader.Read
                tableInvoice.Rows.Add(cmdReader.Item("SupplyID"), cmdReader.Item("ProductName"), cmdReader.Item("ProductGroup"), cmdReader.Item("Quantity"), cmdReader.Item("Cost"), cmdReader.Item("Total"))
            End While
        End If
    End Sub
End Class