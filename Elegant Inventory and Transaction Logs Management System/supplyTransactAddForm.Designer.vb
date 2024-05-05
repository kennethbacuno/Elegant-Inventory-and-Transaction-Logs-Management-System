<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplyTransactAddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpboxSupplyPartyInfo = New System.Windows.Forms.GroupBox()
        Me.btnViewEmployee = New System.Windows.Forms.Button()
        Me.btnViewSupplier = New System.Windows.Forms.Button()
        Me.tableEmployeeName = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tableSupplierName = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpickerSupply = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbxProduct = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpboxInclusion = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.tableSupplyInclusion = New System.Windows.Forms.DataGridView()
        Me.cmbxGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpboxSupplyPartyInfo.SuspendLayout()
        CType(Me.tableEmployeeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableSupplierName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpboxInclusion.SuspendLayout()
        CType(Me.tableSupplyInclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpboxSupplyPartyInfo
        '
        Me.grpboxSupplyPartyInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.btnViewEmployee)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.btnViewSupplier)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.tableEmployeeName)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.tableSupplierName)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.dtpickerSupply)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.Label2)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.lblEmployeeName)
        Me.grpboxSupplyPartyInfo.Controls.Add(Me.lblSupplier)
        Me.grpboxSupplyPartyInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxSupplyPartyInfo.Location = New System.Drawing.Point(12, 107)
        Me.grpboxSupplyPartyInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSupplyPartyInfo.Name = "grpboxSupplyPartyInfo"
        Me.grpboxSupplyPartyInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSupplyPartyInfo.Size = New System.Drawing.Size(426, 308)
        Me.grpboxSupplyPartyInfo.TabIndex = 0
        Me.grpboxSupplyPartyInfo.TabStop = False
        Me.grpboxSupplyPartyInfo.Text = "Related Party Information Form"
        '
        'btnViewEmployee
        '
        Me.btnViewEmployee.Enabled = False
        Me.btnViewEmployee.Location = New System.Drawing.Point(312, 172)
        Me.btnViewEmployee.Name = "btnViewEmployee"
        Me.btnViewEmployee.Size = New System.Drawing.Size(102, 37)
        Me.btnViewEmployee.TabIndex = 13
        Me.btnViewEmployee.Text = "View Info"
        Me.btnViewEmployee.UseVisualStyleBackColor = True
        '
        'btnViewSupplier
        '
        Me.btnViewSupplier.Enabled = False
        Me.btnViewSupplier.Location = New System.Drawing.Point(312, 77)
        Me.btnViewSupplier.Name = "btnViewSupplier"
        Me.btnViewSupplier.Size = New System.Drawing.Size(102, 37)
        Me.btnViewSupplier.TabIndex = 12
        Me.btnViewSupplier.Text = "View Info"
        Me.btnViewSupplier.UseVisualStyleBackColor = True
        '
        'tableEmployeeName
        '
        Me.tableEmployeeName.AllowUserToAddRows = False
        Me.tableEmployeeName.AllowUserToDeleteRows = False
        Me.tableEmployeeName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableEmployeeName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.tableEmployeeName.Location = New System.Drawing.Point(10, 160)
        Me.tableEmployeeName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tableEmployeeName.Name = "tableEmployeeName"
        Me.tableEmployeeName.ReadOnly = True
        Me.tableEmployeeName.RowHeadersVisible = False
        Me.tableEmployeeName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableEmployeeName.Size = New System.Drawing.Size(297, 61)
        Me.tableEmployeeName.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Given Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'tableSupplierName
        '
        Me.tableSupplierName.AllowUserToAddRows = False
        Me.tableSupplierName.AllowUserToDeleteRows = False
        Me.tableSupplierName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSupplierName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.tableSupplierName.Location = New System.Drawing.Point(10, 65)
        Me.tableSupplierName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tableSupplierName.Name = "tableSupplierName"
        Me.tableSupplierName.ReadOnly = True
        Me.tableSupplierName.RowHeadersVisible = False
        Me.tableSupplierName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableSupplierName.Size = New System.Drawing.Size(297, 61)
        Me.tableSupplierName.TabIndex = 9
        '
        'Column4
        '
        Me.Column4.HeaderText = "Supplier ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Last Name"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Given Name"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'dtpickerSupply
        '
        Me.dtpickerSupply.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpickerSupply.Location = New System.Drawing.Point(10, 257)
        Me.dtpickerSupply.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpickerSupply.Name = "dtpickerSupply"
        Me.dtpickerSupply.Size = New System.Drawing.Size(271, 29)
        Me.dtpickerSupply.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(6, 137)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(103, 21)
        Me.lblEmployeeName.TabIndex = 4
        Me.lblEmployeeName.Text = "Received By:"
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(6, 40)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(118, 21)
        Me.lblSupplier.TabIndex = 0
        Me.lblSupplier.Text = "Supplier Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbxGroup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbxProduct)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 445)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(426, 263)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information Form"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(211, 217)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 31)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(312, 217)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 31)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(233, 145)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(176, 29)
        Me.txtPrice.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price /Item"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(10, 145)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(176, 29)
        Me.txtQty.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Quantity"
        '
        'cmbxProduct
        '
        Me.cmbxProduct.FormattingEnabled = True
        Me.cmbxProduct.Location = New System.Drawing.Point(10, 77)
        Me.cmbxProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbxProduct.Name = "cmbxProduct"
        Me.cmbxProduct.Size = New System.Drawing.Size(176, 29)
        Me.cmbxProduct.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Item Name"
        '
        'grpboxInclusion
        '
        Me.grpboxInclusion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxInclusion.Controls.Add(Me.txtTotal)
        Me.grpboxInclusion.Controls.Add(Me.Label1)
        Me.grpboxInclusion.Controls.Add(Me.btnSave)
        Me.grpboxInclusion.Controls.Add(Me.btnDelete)
        Me.grpboxInclusion.Controls.Add(Me.tableSupplyInclusion)
        Me.grpboxInclusion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxInclusion.Location = New System.Drawing.Point(496, 12)
        Me.grpboxInclusion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxInclusion.Name = "grpboxInclusion"
        Me.grpboxInclusion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxInclusion.Size = New System.Drawing.Size(771, 695)
        Me.grpboxInclusion.TabIndex = 10
        Me.grpboxInclusion.TabStop = False
        Me.grpboxInclusion.Text = "Supply Inclusion"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(642, 611)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(110, 29)
        Me.txtTotal.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(591, 614)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Total"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(555, 650)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 31)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(657, 650)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 31)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'tableSupplyInclusion
        '
        Me.tableSupplyInclusion.AllowUserToAddRows = False
        Me.tableSupplyInclusion.AllowUserToDeleteRows = False
        Me.tableSupplyInclusion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSupplyInclusion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column7})
        Me.tableSupplyInclusion.Location = New System.Drawing.Point(17, 40)
        Me.tableSupplyInclusion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tableSupplyInclusion.Name = "tableSupplyInclusion"
        Me.tableSupplyInclusion.ReadOnly = True
        Me.tableSupplyInclusion.RowHeadersVisible = False
        Me.tableSupplyInclusion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableSupplyInclusion.Size = New System.Drawing.Size(735, 566)
        Me.tableSupplyInclusion.TabIndex = 0
        '
        'cmbxGroup
        '
        Me.cmbxGroup.FormattingEnabled = True
        Me.cmbxGroup.Location = New System.Drawing.Point(233, 77)
        Me.cmbxGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbxGroup.Name = "cmbxGroup"
        Me.cmbxGroup.Size = New System.Drawing.Size(176, 29)
        Me.cmbxGroup.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Item Group"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Item Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.FillWeight = 70.0!
        Me.Column8.HeaderText = "Group"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "Cost"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 68
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.FillWeight = 50.0!
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'supplyTransactAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 720)
        Me.Controls.Add(Me.grpboxInclusion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpboxSupplyPartyInfo)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "supplyTransactAddForm"
        Me.Text = "supplyTransactAddForm"
        Me.grpboxSupplyPartyInfo.ResumeLayout(False)
        Me.grpboxSupplyPartyInfo.PerformLayout()
        CType(Me.tableEmployeeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableSupplierName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpboxInclusion.ResumeLayout(False)
        Me.grpboxInclusion.PerformLayout()
        CType(Me.tableSupplyInclusion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpboxSupplyPartyInfo As GroupBox
    Friend WithEvents dtpickerSupply As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbxProduct As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpboxInclusion As GroupBox
    Friend WithEvents tableSupplyInclusion As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents tableSupplierName As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents tableEmployeeName As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnViewEmployee As Button
    Friend WithEvents btnViewSupplier As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbxGroup As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
