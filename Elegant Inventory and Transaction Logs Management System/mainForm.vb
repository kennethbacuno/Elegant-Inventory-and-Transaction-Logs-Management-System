Public Class frmMain
    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Dim productFrm As New product()
        Me.IsMdiContainer = True
        productFrm.MdiParent = Me
        productFrm.Dock = DockStyle.Fill
        productFrm.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Dim employeeFrm As New employee()
        Me.IsMdiContainer = True
        employeeFrm.MdiParent = Me
        employeeFrm.Dock = DockStyle.Fill
        employeeFrm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim supplierFrm As New supplier()
        Me.IsMdiContainer = True
        supplierFrm.MdiParent = Me
        supplierFrm.Dock = DockStyle.Fill
        supplierFrm.Show()
    End Sub

    Private Sub SupplyLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplyLogToolStripMenuItem.Click
        Dim supplierTransactFrm As New supplyTransact()
        Me.IsMdiContainer = True
        supplierTransactFrm.MdiParent = Me
        supplierTransactFrm.Dock = DockStyle.Fill
        supplierTransactFrm.Show()
    End Sub

    Private Sub AddSupplyTransactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSupplyTransactToolStripMenuItem.Click
        Dim supplyTransactAddFrm As New supplyTransactAddForm()
        Me.IsMdiContainer = True
        supplyTransactAddFrm.MdiParent = Me
        supplyTransactAddFrm.Dock = DockStyle.Fill
        supplyTransactAddFrm.Show()
    End Sub
End Class
