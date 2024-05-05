<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class supplyTransact
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpSupplyTransact = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearchTransact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tableSupplyTransact = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grpSupplyInvoice = New System.Windows.Forms.GroupBox()
        Me.btnUpdateInvoice = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.txtSearchInvoice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tableInvoice = New System.Windows.Forms.DataGridView()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpSupplyTransact.SuspendLayout()
        CType(Me.tableSupplyTransact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSupplyInvoice.SuspendLayout()
        CType(Me.tableInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSupplyTransact
        '
        Me.grpSupplyTransact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSupplyTransact.Controls.Add(Me.btnUpdate)
        Me.grpSupplyTransact.Controls.Add(Me.btnDelete)
        Me.grpSupplyTransact.Controls.Add(Me.txtSearchTransact)
        Me.grpSupplyTransact.Controls.Add(Me.Label1)
        Me.grpSupplyTransact.Controls.Add(Me.tableSupplyTransact)
        Me.grpSupplyTransact.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSupplyTransact.Location = New System.Drawing.Point(15, 15)
        Me.grpSupplyTransact.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSupplyTransact.Name = "grpSupplyTransact"
        Me.grpSupplyTransact.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSupplyTransact.Size = New System.Drawing.Size(1616, 329)
        Me.grpSupplyTransact.TabIndex = 0
        Me.grpSupplyTransact.TabStop = False
        Me.grpSupplyTransact.Text = "Supply Transactions"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(1097, 30)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 29)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1178, 30)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSearchTransact
        '
        Me.txtSearchTransact.Location = New System.Drawing.Point(61, 35)
        Me.txtSearchTransact.Name = "txtSearchTransact"
        Me.txtSearchTransact.Size = New System.Drawing.Size(267, 25)
        Me.txtSearchTransact.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'tableSupplyTransact
        '
        Me.tableSupplyTransact.AllowUserToAddRows = False
        Me.tableSupplyTransact.AllowUserToDeleteRows = False
        Me.tableSupplyTransact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableSupplyTransact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSupplyTransact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column16, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column17, Me.Column18})
        Me.tableSupplyTransact.Location = New System.Drawing.Point(10, 65)
        Me.tableSupplyTransact.Name = "tableSupplyTransact"
        Me.tableSupplyTransact.RowHeadersVisible = False
        Me.tableSupplyTransact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableSupplyTransact.Size = New System.Drawing.Size(1246, 253)
        Me.tableSupplyTransact.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Supply ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 91
        '
        'Column2
        '
        Me.Column2.HeaderText = "SupplierID"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Supplier"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Sex"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 54
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Birthdate"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 89
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Address"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Contact Info"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 99
        '
        'Column8
        '
        Me.Column8.HeaderText = "EmployeeID"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Employee"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Role"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column10.Width = 40
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Sex"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column11.Width = 35
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column16.HeaderText = "Birthdate"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 89
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Address"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = "Contact Info"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column13.Width = 80
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column14.HeaderText = "Supply Date"
        Me.Column14.Name = "Column14"
        Me.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column14.Width = 78
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column15.HeaderText = "Total Cost"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column15.Width = 67
        '
        'Column17
        '
        Me.Column17.HeaderText = "toUpdateSuppID"
        Me.Column17.Name = "Column17"
        Me.Column17.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column17.Visible = False
        '
        'Column18
        '
        Me.Column18.HeaderText = "toUpdateEmployeeID"
        Me.Column18.Name = "Column18"
        Me.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column18.Visible = False
        '
        'grpSupplyInvoice
        '
        Me.grpSupplyInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSupplyInvoice.Controls.Add(Me.btnUpdateInvoice)
        Me.grpSupplyInvoice.Controls.Add(Me.btnDeleteInvoice)
        Me.grpSupplyInvoice.Controls.Add(Me.txtSearchInvoice)
        Me.grpSupplyInvoice.Controls.Add(Me.Label2)
        Me.grpSupplyInvoice.Controls.Add(Me.tableInvoice)
        Me.grpSupplyInvoice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSupplyInvoice.Location = New System.Drawing.Point(15, 352)
        Me.grpSupplyInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSupplyInvoice.Name = "grpSupplyInvoice"
        Me.grpSupplyInvoice.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSupplyInvoice.Size = New System.Drawing.Size(1616, 355)
        Me.grpSupplyInvoice.TabIndex = 5
        Me.grpSupplyInvoice.TabStop = False
        Me.grpSupplyInvoice.Text = "Supply Transactions"
        '
        'btnUpdateInvoice
        '
        Me.btnUpdateInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateInvoice.Location = New System.Drawing.Point(1097, 30)
        Me.btnUpdateInvoice.Name = "btnUpdateInvoice"
        Me.btnUpdateInvoice.Size = New System.Drawing.Size(75, 29)
        Me.btnUpdateInvoice.TabIndex = 4
        Me.btnUpdateInvoice.Text = "Update"
        Me.btnUpdateInvoice.UseVisualStyleBackColor = True
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(1178, 30)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(75, 29)
        Me.btnDeleteInvoice.TabIndex = 3
        Me.btnDeleteInvoice.Text = "Delete"
        Me.btnDeleteInvoice.UseVisualStyleBackColor = True
        '
        'txtSearchInvoice
        '
        Me.txtSearchInvoice.Location = New System.Drawing.Point(61, 35)
        Me.txtSearchInvoice.Name = "txtSearchInvoice"
        Me.txtSearchInvoice.Size = New System.Drawing.Size(267, 25)
        Me.txtSearchInvoice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search"
        '
        'tableInvoice
        '
        Me.tableInvoice.AllowUserToAddRows = False
        Me.tableInvoice.AllowUserToDeleteRows = False
        Me.tableInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24})
        Me.tableInvoice.Location = New System.Drawing.Point(10, 65)
        Me.tableInvoice.Name = "tableInvoice"
        Me.tableInvoice.RowHeadersVisible = False
        Me.tableInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableInvoice.Size = New System.Drawing.Size(1246, 277)
        Me.tableInvoice.TabIndex = 0
        '
        'Column19
        '
        Me.Column19.HeaderText = "SupplyID"
        Me.Column19.Name = "Column19"
        Me.Column19.Visible = False
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column20.HeaderText = "Item Name"
        Me.Column20.Name = "Column20"
        '
        'Column21
        '
        Me.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column21.HeaderText = "Group"
        Me.Column21.Name = "Column21"
        Me.Column21.Width = 71
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column22.HeaderText = "Quantity"
        Me.Column22.Name = "Column22"
        Me.Column22.Width = 86
        '
        'Column23
        '
        Me.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column23.HeaderText = "Cost per Item"
        Me.Column23.Name = "Column23"
        Me.Column23.Width = 106
        '
        'Column24
        '
        Me.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column24.HeaderText = "Total Cost"
        Me.Column24.Name = "Column24"
        Me.Column24.Width = 86
        '
        'supplyTransact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 720)
        Me.Controls.Add(Me.grpSupplyInvoice)
        Me.Controls.Add(Me.grpSupplyTransact)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "supplyTransact"
        Me.Text = "supplyTransact"
        Me.grpSupplyTransact.ResumeLayout(False)
        Me.grpSupplyTransact.PerformLayout()
        CType(Me.tableSupplyTransact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSupplyInvoice.ResumeLayout(False)
        Me.grpSupplyInvoice.PerformLayout()
        CType(Me.tableInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSupplyTransact As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tableSupplyTransact As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearchTransact As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewComboBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewComboBoxColumn
    Friend WithEvents Column18 As DataGridViewComboBoxColumn
    Friend WithEvents grpSupplyInvoice As GroupBox
    Friend WithEvents btnUpdateInvoice As Button
    Friend WithEvents btnDeleteInvoice As Button
    Friend WithEvents txtSearchInvoice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tableInvoice As DataGridView
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
End Class
