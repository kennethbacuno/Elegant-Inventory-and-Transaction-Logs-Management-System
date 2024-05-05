Public Class product
    Dim query As String

    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductTable()
    End Sub

    Public Sub LoadProductTable()
        tableProduct.Rows.Clear()
        query = "SELECT * FROM product"
        readQuery(query)
        Try
            While cmdReader.Read
                tableProduct.Rows.Add(cmdReader.Item("ProductID"), cmdReader.Item("ProductName"), cmdReader.Item("ProductGroup"), cmdReader.Item("Price"), cmdReader.Item("Stock"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Save()
        LoadProductTable()
        Clear()
    End Sub

    Public Sub Save()
        query = "SELECT * FROM product WHERE ProductName = '" & txt_productName.Text & "'"
        readQuery(query)
        Try
            Dim counter As Integer = 0
            While cmdReader.Read
                counter += 1
            End While
            If counter <= 0 Then
                query = "INSERT INTO `product`(`ProductID`, `ProductName`, `ProductGroup`, `Price`, `Stock`) VALUES ('','" & txt_productName.Text & "','" & cmbx_group.Text & "','" & txt_price.Text & "','" & txt_stock.Text & "')"
                Try
                    readQuery(query)
                    MessageBox.Show("Item is successfully saved.", "PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Item was not saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                If MessageBox.Show("Item is already existing. Do you want to proceed on updating it instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    query = "UPDATE `product` SET `ProductGroup`='" & cmbx_group.Text & "',`Price`='" & txt_price.Text & "',`Stock`='" & txt_stock.Text & "' WHERE `ProductName`='" & txt_productName.Text & "'"
                    Try
                        readQuery(query)
                        MessageBox.Show("Item is successfully updated.", "PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Item was not updated.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
        btn_save.Enabled = True
    End Sub

    Public Sub Clear()
        txt_productName.Clear()
        txt_price.Clear()
        txt_stock.Clear()
    End Sub

    Private Sub tableProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableProduct.CellClick
        txt_productName.Text = tableProduct.CurrentRow.Cells(1).Value
        cmbx_group.Text = tableProduct.CurrentRow.Cells(2).Value
        txt_price.Text = tableProduct.CurrentRow.Cells(3).Value
        txt_stock.Text = tableProduct.CurrentRow.Cells(4).Value
        btn_save.Enabled = False
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Edit()
        LoadProductTable()
        Clear()
        btn_save.Enabled = True
    End Sub

    Public Sub Edit()
        query = "SELECT * FROM product WHERE ProductName = '" & txt_productName.Text & "'"
        readQuery(query)
        Try
            Dim counter As Integer = 0
            While cmdReader.Read
                counter += 1
            End While
            If counter <= 0 Then
                query = "UPDATE `product` SET `ProductName`='" & txt_productName.Text & "', `ProductGroup`='" & cmbx_group.Text & "',`Price`='" & txt_price.Text & "',`Stock`='" & txt_stock.Text & "' WHERE `ProductID`='" & tableProduct.CurrentRow.Cells(0).Value & "'"
                Try
                    readQuery(query)
                    MessageBox.Show("Item is successfully saved.", "PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Item was not saved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                If MessageBox.Show("Item is already existing. Do you want to proceed on updating it instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    query = "UPDATE `product` SET `ProductGroup`='" & cmbx_group.Text & "',`Price`='" & txt_price.Text & "',`Stock`='" & txt_stock.Text & "' WHERE `ProductName`='" & txt_productName.Text & "'"
                    Try
                        readQuery(query)
                        MessageBox.Show("Item is successfully updated.", "PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Item was not updated.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Delete()
        LoadProductTable()
        Clear()
        btn_save.Enabled = True
    End Sub

    Public Sub Delete()
        If MsgBox("You're going to delete this item. Do you insist to proceed?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            query = "DELETE FROM `product` WHERE `ProductID`='" & tableProduct.CurrentRow.Cells(0).Value & "'"
            Try
                readQuery(query)
                MessageBox.Show("Item is successfully deleted.", "PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Item was not deleted.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txt_productSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_productSearch.TextChanged
        tableProduct.Rows.Clear()
        Dim keyword As String = txt_productSearch.Text
        Try
            query = "SELECT * FROM product WHERE ProductName LIKE '" & keyword & "' OR ProductGroup LIKE '" & keyword & "' OR Price LIKE '" & keyword & "'"
            readQuery(query)
            While cmdReader.Read
                tableProduct.Rows.Add(cmdReader.Item("ProductID"), cmdReader.Item("ProductName"), cmdReader.Item("ProductGroup"), cmdReader.Item("Price"), cmdReader.Item("Stock"))
            End While
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        End Try
    End Sub
End Class