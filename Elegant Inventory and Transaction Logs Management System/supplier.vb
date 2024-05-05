Imports MySql.Data.MySqlClient

Public Class supplier
    Dim query As String

    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplierTable()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Public Sub LoadSupplierTable()
        tableSupplier.Rows.Clear()
        query = "SELECT * FROM supplier"
        readQuery(query)
        Try
            While cmdReader.Read
                Dim formattedBirthdate As String = CType(cmdReader.Item("Birthdate"), DateTime).ToString("yyyy-MM-dd")
                tableSupplier.Rows.Add(cmdReader.Item("SupplierID"), cmdReader.Item("LastName"), cmdReader.Item("GivenName"), cmdReader.Item("Sex"), formattedBirthdate, cmdReader.Item("Province"), cmdReader.Item("Municipality"), cmdReader.Item("Barangay"), cmdReader.Item("Purok"), cmdReader.Item("ContactNo"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
        Clear()
        LoadSupplierTable()
    End Sub

    Public Sub Save()
        Dim birthdate As String = dtpickerBirthdate.Value.ToString("yyyy-MM-dd")
        query = "SELECT * FROM supplier WHERE LastName = '" & txtLastName.Text & "' AND GivenName='" & txtGivenName.Text & "' AND Sex='" & cmbxSex.Text & "' AND Birthdate='" & dtpickerBirthdate.Value.ToString("yyyy-MM-dd") & "' AND Province='" & cmbxProvince.Text & "' AND Municipality='" & cmbxMunicipality.Text & "' AND Barangay='" & cmbxBarangay.Text & "' AND Purok='" & txtPurok.Text & "' AND ContactNo='" & txtContact.Text & "'"
        readQuery(query)
        Try
            Dim counter As Integer = 0
            While cmdReader.Read
                counter += 1
            End While
            If counter <= 0 Then
                query = "INSERT INTO `supplier`(`SupplierID`, `LastName`, `GivenName`, `Sex`, `Birthdate`, `Province`, `Municipality`, `Barangay`, `Purok`, `ContactNo`) VALUES ('','" & txtLastName.Text & "','" & txtGivenName.Text & "','" & cmbxSex.Text & "', '" & birthdate & "','" & cmbxProvince.Text & "','" & cmbxMunicipality.Text & "', '" & cmbxBarangay.Text & "', '" & txtPurok.Text & "', '" & txtContact.Text & "')"
                Try
                    readQuery(query)
                    MessageBox.Show("Successfully added a new supplier.", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Supplier was not saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Supplier with the exact same credentials is already existing in your database.", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub tableSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableSupplier.CellClick
        txtLastName.Text = tableSupplier.CurrentRow.Cells(1).Value
        txtGivenName.Text = tableSupplier.CurrentRow.Cells(2).Value
        cmbxSex.Text = tableSupplier.CurrentRow.Cells(3).Value
        dtpickerBirthdate.Value = CType(tableSupplier.CurrentRow.Cells(4).Value, DateTime)
        cmbxProvince.Text = tableSupplier.CurrentRow.Cells(5).Value
        cmbxMunicipality.Text = tableSupplier.CurrentRow.Cells(6).Value
        cmbxBarangay.Text = tableSupplier.CurrentRow.Cells(7).Value
        txtPurok.Text = tableSupplier.CurrentRow.Cells(8).Value
        txtContact.Text = tableSupplier.CurrentRow.Cells(9).Value
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Edit()
        Clear()
        LoadSupplierTable()
        btnSave.Enabled = True
    End Sub

    Public Sub Edit()
        Dim birthdate As String = dtpickerBirthdate.Value.ToString("yyyy-MM-dd")
        query = "SELECT * FROM supplier WHERE LastName = '" & txtLastName.Text & "' AND GivenName='" & txtGivenName.Text & "' AND Sex='" & cmbxSex.Text & "' AND Birthdate='" & dtpickerBirthdate.Value.ToString("yyyy-MM-dd") & "' AND Province='" & cmbxProvince.Text & "' AND Municipality='" & cmbxMunicipality.Text & "' AND Barangay='" & cmbxBarangay.Text & "' AND Purok='" & txtPurok.Text & "' AND ContactNo='" & txtContact.Text & "' AND SupplierID <> '" & tableSupplier.CurrentRow.Cells(0).Value & "'"
        readQuery(query)
        Try
            Dim counter As Integer = 0
            While cmdReader.Read
                counter += 1
            End While
            If counter <= 0 Then
                query = "UPDATE `supplier` SET `LastName`='" & txtLastName.Text & "',`GivenName`='" & txtGivenName.Text & "', `Sex`='" & cmbxSex.Text & "', `Birthdate`='" & birthdate & "', `Province`='" & cmbxProvince.Text & "',`Municipality`='" & cmbxMunicipality.Text & "',`Barangay`='" & cmbxBarangay.Text & "',`Purok`='" & txtPurok.Text & "',`ContactNo`='" & txtContact.Text & "' WHERE `SupplierID`='" & tableSupplier.CurrentRow.Cells(0).Value & "'"
                Try
                    readQuery(query)
                    MessageBox.Show("Successfully updated.", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Supplier was not updated.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Supplier with the exact same credentials is already existing in your database.", "SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
        LoadSupplierTable()
        Clear()
        btnSave.Enabled = True
    End Sub

    Public Sub Delete()
        If MsgBox("You're going to delete this supplier record. Do you insist to proceed?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            query = "DELETE FROM `supplier` WHERE `SupplierID`='" & tableSupplier.CurrentRow.Cells(0).Value & "'"
            Try
                readQuery(query)
                MessageBox.Show("Supplier record is successfully deleted.", "EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Supplier record was not deleted.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        tableSupplier.Rows.Clear()
        Dim keyword As String = txtSearch.Text
        Try
            query = "SELECT * FROM supplier WHERE Lastname LIKE '" & keyword & "' OR GivenName LIKE '" & keyword & "' OR Sex LIKE '" & keyword & "' OR Birthdate LIKE '" & keyword & "' OR Province LIKE '" & keyword & "' OR Municipality LIKE '" & keyword & "' OR Barangay LIKE '" & keyword & "' OR Purok LIKE '" & keyword & "' OR ContactNo LIKE '" & keyword & "'"
            readQuery(query)
            While cmdReader.Read
                Dim formattedBirthdate As String = CType(cmdReader.Item("Birthdate"), DateTime).ToString("yyyy-MM-dd")
                tableSupplier.Rows.Add(cmdReader.Item("SupplierID"), cmdReader.Item("LastName"), cmdReader.Item("GivenName"), cmdReader.Item("Sex"), formattedBirthdate, cmdReader.Item("Province"), cmdReader.Item("Municipality"), cmdReader.Item("Barangay"), cmdReader.Item("Purok"), cmdReader.Item("ContactNo"))
            End While
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        End Try
    End Sub
End Class