Imports System.Globalization

Public Class employee
    Dim query As String
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeTable()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub LoadEmployeeTable()
        tableEmployee.Rows.Clear()
        query = "SELECT * FROM employee"
        readQuery(query)
        Try
            While cmdReader.Read
                Dim formattedBirthdate As String = CType(cmdReader.Item("Birthdate"), DateTime).ToString("yyyy-MM-dd")
                tableEmployee.Rows.Add(cmdReader.Item("EmployeeID"), cmdReader.Item("LastName"), cmdReader.Item("GivenName"), cmdReader.Item("Role"), cmdReader.Item("Sex"), formattedBirthdate, cmdReader.Item("Municipality"), cmdReader.Item("Barangay"), cmdReader.Item("Purok"), cmdReader.Item("ContactNo"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
        Clear()
        LoadEmployeeTable()
    End Sub

    Public Sub Save()
        Dim birthdate As String = dtpickerBirthdate.Value.ToString("yyyy-MM-dd")
        query = "SELECT * FROM employee WHERE LastName = '" & txtLastName.Text & "' AND GivenName='" & txtGivenName.Text & "' AND Role='" & cmbxRole.Text & "' AND Sex='" & cmbxSex.Text & "' AND Birthdate='" & dtpickerBirthdate.Value.ToString("yyyy-MM-dd") & "' AND Municipality='" & cmbxMunicipality.Text & "' AND Barangay='" & cmbxBarangay.Text & "' AND Purok='" & txtPurok.Text & "' AND ContactNo='" & txtContact.Text & "'"
        readQuery(query)
        Try
            Dim counter As Integer = 0
            While cmdReader.Read
                counter += 1
            End While
            If counter <= 0 Then
                query = "INSERT INTO `employee`(`EmployeeID`, `LastName`, `GivenName`, `Role`, `Sex`, `Birthdate`, `Municipality`, `Barangay`, `Purok`, `ContactNo`) VALUES ('','" & txtLastName.Text & "','" & txtGivenName.Text & "','" & cmbxRole.Text & "','" & cmbxSex.Text & "', '" & birthdate & "','" & cmbxMunicipality.Text & "', '" & cmbxBarangay.Text & "', '" & txtPurok.Text & "', '" & txtContact.Text & "')"
                Try
                    readQuery(query)
                    MessageBox.Show("Successfully added a new employee.", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Employee was not saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Employee with the exact same credentials is already existing in your database.", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Public Sub Clear()
        txtLastName.Clear()
        txtGivenName.Clear()
        txtPurok.Clear()
        txtContact.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub tableEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableEmployee.CellClick
        txtLastName.Text = tableEmployee.CurrentRow.Cells(1).Value
        txtGivenName.Text = tableEmployee.CurrentRow.Cells(2).Value
        cmbxRole.Text = tableEmployee.CurrentRow.Cells(3).Value
        cmbxSex.Text = tableEmployee.CurrentRow.Cells(4).Value
        dtpickerBirthdate.Value = CType(tableEmployee.CurrentRow.Cells(5).Value, DateTime)
        cmbxMunicipality.Text = tableEmployee.CurrentRow.Cells(6).Value
        cmbxBarangay.Text = tableEmployee.CurrentRow.Cells(7).Value
        txtPurok.Text = tableEmployee.CurrentRow.Cells(8).Value
        txtContact.Text = tableEmployee.CurrentRow.Cells(9).Value
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit()
        Clear()
        LoadEmployeeTable()
        btnSave.Enabled = True
    End Sub

    Public Sub Edit()
        Dim birthdate As String = dtpickerBirthdate.Value.ToString("yyyy-MM-dd")
        query = "SELECT * FROM employee WHERE LastName = '" & txtLastName.Text & "' AND GivenName='" & txtGivenName.Text & "' AND Role='" & cmbxRole.Text & "' AND Sex='" & cmbxSex.Text & "' AND Birthdate='" & dtpickerBirthdate.Value.ToString("yyyy-MM-dd") & "' AND Municipality='" & cmbxMunicipality.Text & "' AND Barangay='" & cmbxBarangay.Text & "' AND Purok='" & txtPurok.Text & "' AND ContactNo='" & txtContact.Text & "' AND EmployeeID <> '" & tableEmployee.CurrentRow.Cells(0).Value & "'"
        readQuery(query)
        Try
            Dim counter As Integer = 0
            While cmdReader.Read
                counter += 1
            End While
            If counter <= 0 Then
                query = "UPDATE `employee` SET `LastName`='" & txtLastName.Text & "',`GivenName`='" & txtGivenName.Text & "',`Role`='" & cmbxRole.Text & "',`Sex`='" & cmbxSex.Text & "', `Birthdate`='" & birthdate & "',`Municipality`='" & cmbxMunicipality.Text & "',`Barangay`='" & cmbxBarangay.Text & "',`Purok`='" & txtPurok.Text & "',`ContactNo`='" & txtContact.Text & "' WHERE `EmployeeID`='" & tableEmployee.CurrentRow.Cells(0).Value & "'"
                Try
                    readQuery(query)
                    MessageBox.Show("Successfully updated", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Employee was not updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Employee with the exact same credentials is already existing in your database.", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        LoadEmployeeTable()
        Clear()
        btnSave.Enabled = True
    End Sub

    Public Sub Delete()
        If MsgBox("You're going to delete this employee record. Do you insist to proceed?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            query = "DELETE FROM `employee` WHERE `EmployeeID`='" & tableEmployee.CurrentRow.Cells(0).Value & "'"
            Try
                readQuery(query)
                MessageBox.Show("Employee record is successfully deleted.", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Employee record was not deleted.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtEmployeeSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeSearch.TextChanged
        tableEmployee.Rows.Clear()
        Dim keyword As String = txtEmployeeSearch.Text
        Try
            query = "SELECT * FROM employee WHERE Lastname LIKE '" & keyword & "' OR GivenName LIKE '" & keyword & "' OR Role LIKE '" & keyword & "' OR Sex LIKE '" & keyword & "' OR Birthdate LIKE '" & keyword & "' OR Municipality LIKE '" & keyword & "' OR Barangay LIKE '" & keyword & "' OR Purok LIKE '" & keyword & "' OR ContactNo LIKE '" & keyword & "'"
            readQuery(query)
            While cmdReader.Read
                Dim formattedBirthdate As String = CType(cmdReader.Item("Birthdate"), DateTime).ToString("yyyy-MM-dd")
                tableEmployee.Rows.Add(cmdReader.Item("EmployeeID"), cmdReader.Item("LastName"), cmdReader.Item("GivenName"), cmdReader.Item("Role"), cmdReader.Item("Sex"), formattedBirthdate, cmdReader.Item("Municipality"), cmdReader.Item("Barangay"), cmdReader.Item("Purok"), cmdReader.Item("ContactNo"))
            End While
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        End Try
    End Sub
End Class