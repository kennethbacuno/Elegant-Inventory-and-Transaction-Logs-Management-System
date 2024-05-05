<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product
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
        Me.tableProduct = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpboxProduct = New System.Windows.Forms.GroupBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.cmbx_group = New System.Windows.Forms.ComboBox()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_group = New System.Windows.Forms.Label()
        Me.lbl_productName = New System.Windows.Forms.Label()
        Me.txt_productSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        CType(Me.tableProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableProduct
        '
        Me.tableProduct.AllowUserToAddRows = False
        Me.tableProduct.AllowUserToDeleteRows = False
        Me.tableProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tableProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.tableProduct.Location = New System.Drawing.Point(398, 116)
        Me.tableProduct.Name = "tableProduct"
        Me.tableProduct.ReadOnly = True
        Me.tableProduct.RowHeadersVisible = False
        Me.tableProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableProduct.Size = New System.Drawing.Size(870, 592)
        Me.tableProduct.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Item Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "Group"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Stock"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 72
        '
        'grpboxProduct
        '
        Me.grpboxProduct.BackColor = System.Drawing.Color.Transparent
        Me.grpboxProduct.Controls.Add(Me.btn_update)
        Me.grpboxProduct.Controls.Add(Me.btn_delete)
        Me.grpboxProduct.Controls.Add(Me.btn_clear)
        Me.grpboxProduct.Controls.Add(Me.btn_save)
        Me.grpboxProduct.Controls.Add(Me.lbl_stock)
        Me.grpboxProduct.Controls.Add(Me.txt_stock)
        Me.grpboxProduct.Controls.Add(Me.txt_price)
        Me.grpboxProduct.Controls.Add(Me.cmbx_group)
        Me.grpboxProduct.Controls.Add(Me.txt_productName)
        Me.grpboxProduct.Controls.Add(Me.lbl_price)
        Me.grpboxProduct.Controls.Add(Me.lbl_group)
        Me.grpboxProduct.Controls.Add(Me.lbl_productName)
        Me.grpboxProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxProduct.ForeColor = System.Drawing.Color.Black
        Me.grpboxProduct.Location = New System.Drawing.Point(12, 12)
        Me.grpboxProduct.Name = "grpboxProduct"
        Me.grpboxProduct.Size = New System.Drawing.Size(380, 696)
        Me.grpboxProduct.TabIndex = 3
        Me.grpboxProduct.TabStop = False
        Me.grpboxProduct.Text = "Item Form"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Location = New System.Drawing.Point(25, 568)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(318, 31)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Location = New System.Drawing.Point(25, 622)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(318, 31)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Location = New System.Drawing.Point(243, 286)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(131, 31)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Location = New System.Drawing.Point(25, 518)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(318, 31)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.ForeColor = System.Drawing.Color.Black
        Me.lbl_stock.Location = New System.Drawing.Point(11, 226)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(41, 17)
        Me.lbl_stock.TabIndex = 7
        Me.lbl_stock.Text = "Stock"
        '
        'txt_stock
        '
        Me.txt_stock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock.ForeColor = System.Drawing.Color.Black
        Me.txt_stock.Location = New System.Drawing.Point(9, 246)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(365, 25)
        Me.txt_stock.TabIndex = 6
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.Black
        Me.txt_price.Location = New System.Drawing.Point(9, 187)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(365, 25)
        Me.txt_price.TabIndex = 5
        '
        'cmbx_group
        '
        Me.cmbx_group.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbx_group.ForeColor = System.Drawing.Color.Black
        Me.cmbx_group.FormattingEnabled = True
        Me.cmbx_group.Items.AddRange(New Object() {"Barong", "Dress", "Head Dress/Accessory", "Long Sleeve", "Pants", "Toxido", "Wedding Attire"})
        Me.cmbx_group.Location = New System.Drawing.Point(9, 124)
        Me.cmbx_group.Name = "cmbx_group"
        Me.cmbx_group.Size = New System.Drawing.Size(365, 25)
        Me.cmbx_group.TabIndex = 4
        '
        'txt_productName
        '
        Me.txt_productName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productName.ForeColor = System.Drawing.Color.Black
        Me.txt_productName.Location = New System.Drawing.Point(9, 65)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.Size = New System.Drawing.Size(365, 25)
        Me.txt_productName.TabIndex = 3
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Black
        Me.lbl_price.Location = New System.Drawing.Point(6, 167)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(37, 17)
        Me.lbl_price.TabIndex = 2
        Me.lbl_price.Text = "Price"
        '
        'lbl_group
        '
        Me.lbl_group.AutoSize = True
        Me.lbl_group.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_group.ForeColor = System.Drawing.Color.Black
        Me.lbl_group.Location = New System.Drawing.Point(6, 104)
        Me.lbl_group.Name = "lbl_group"
        Me.lbl_group.Size = New System.Drawing.Size(46, 17)
        Me.lbl_group.TabIndex = 1
        Me.lbl_group.Text = "Group"
        '
        'lbl_productName
        '
        Me.lbl_productName.AutoSize = True
        Me.lbl_productName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productName.ForeColor = System.Drawing.Color.Black
        Me.lbl_productName.Location = New System.Drawing.Point(6, 45)
        Me.lbl_productName.Name = "lbl_productName"
        Me.lbl_productName.Size = New System.Drawing.Size(76, 17)
        Me.lbl_productName.TabIndex = 0
        Me.lbl_productName.Text = "Item Name"
        '
        'txt_productSearch
        '
        Me.txt_productSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_productSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productSearch.Location = New System.Drawing.Point(1008, 85)
        Me.txt_productSearch.Name = "txt_productSearch"
        Me.txt_productSearch.Size = New System.Drawing.Size(260, 25)
        Me.txt_productSearch.TabIndex = 5
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.Black
        Me.lblSearch.Location = New System.Drawing.Point(955, 88)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 17)
        Me.lblSearch.TabIndex = 6
        Me.lblSearch.Text = "Search"
        '
        'product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txt_productSearch)
        Me.Controls.Add(Me.grpboxProduct)
        Me.Controls.Add(Me.tableProduct)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "product"
        CType(Me.tableProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxProduct.ResumeLayout(False)
        Me.grpboxProduct.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableProduct As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents grpboxProduct As GroupBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents cmbx_group As ComboBox
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_group As Label
    Friend WithEvents lbl_productName As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_productSearch As TextBox
    Friend WithEvents lblSearch As Label
End Class
