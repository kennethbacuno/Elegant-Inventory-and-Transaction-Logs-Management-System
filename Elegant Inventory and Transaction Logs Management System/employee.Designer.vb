<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employee
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
        Me.tableEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpboxEmployee = New System.Windows.Forms.GroupBox()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.dtpickerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtPurok = New System.Windows.Forms.TextBox()
        Me.lblPurok = New System.Windows.Forms.Label()
        Me.lblBarangay = New System.Windows.Forms.Label()
        Me.cmbxBarangay = New System.Windows.Forms.ComboBox()
        Me.lblMunicipality = New System.Windows.Forms.Label()
        Me.cmbxMunicipality = New System.Windows.Forms.ComboBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.cmbxSex = New System.Windows.Forms.ComboBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbxRole = New System.Windows.Forms.ComboBox()
        Me.txtGivenName = New System.Windows.Forms.TextBox()
        Me.lblGivenName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtEmployeeSearch = New System.Windows.Forms.TextBox()
        CType(Me.tableEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableEmployee
        '
        Me.tableEmployee.AllowUserToAddRows = False
        Me.tableEmployee.AllowUserToDeleteRows = False
        Me.tableEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tableEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column10, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.tableEmployee.Location = New System.Drawing.Point(12, 339)
        Me.tableEmployee.Name = "tableEmployee"
        Me.tableEmployee.ReadOnly = True
        Me.tableEmployee.RowHeadersVisible = False
        Me.tableEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableEmployee.Size = New System.Drawing.Size(1256, 369)
        Me.tableEmployee.TabIndex = 0
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
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Given Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Role"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 66
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Sex"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 59
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Birthdate"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 98
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Municipality"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Barangay"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Purok/Street/Home Blk"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Contact No."
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 106
        '
        'grpboxEmployee
        '
        Me.grpboxEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxEmployee.Controls.Add(Me.lblBirthdate)
        Me.grpboxEmployee.Controls.Add(Me.dtpickerBirthdate)
        Me.grpboxEmployee.Controls.Add(Me.btnClear)
        Me.grpboxEmployee.Controls.Add(Me.btnSave)
        Me.grpboxEmployee.Controls.Add(Me.btnUpdate)
        Me.grpboxEmployee.Controls.Add(Me.btnDelete)
        Me.grpboxEmployee.Controls.Add(Me.txtContact)
        Me.grpboxEmployee.Controls.Add(Me.lblContact)
        Me.grpboxEmployee.Controls.Add(Me.txtPurok)
        Me.grpboxEmployee.Controls.Add(Me.lblPurok)
        Me.grpboxEmployee.Controls.Add(Me.lblBarangay)
        Me.grpboxEmployee.Controls.Add(Me.cmbxBarangay)
        Me.grpboxEmployee.Controls.Add(Me.lblMunicipality)
        Me.grpboxEmployee.Controls.Add(Me.cmbxMunicipality)
        Me.grpboxEmployee.Controls.Add(Me.lblSex)
        Me.grpboxEmployee.Controls.Add(Me.cmbxSex)
        Me.grpboxEmployee.Controls.Add(Me.lblRole)
        Me.grpboxEmployee.Controls.Add(Me.cmbxRole)
        Me.grpboxEmployee.Controls.Add(Me.txtGivenName)
        Me.grpboxEmployee.Controls.Add(Me.lblGivenName)
        Me.grpboxEmployee.Controls.Add(Me.lblLastName)
        Me.grpboxEmployee.Controls.Add(Me.txtLastName)
        Me.grpboxEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxEmployee.Location = New System.Drawing.Point(12, 12)
        Me.grpboxEmployee.Name = "grpboxEmployee"
        Me.grpboxEmployee.Size = New System.Drawing.Size(1256, 255)
        Me.grpboxEmployee.TabIndex = 1
        Me.grpboxEmployee.TabStop = False
        Me.grpboxEmployee.Text = "Employee Form"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Location = New System.Drawing.Point(992, 59)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(78, 21)
        Me.lblBirthdate.TabIndex = 21
        Me.lblBirthdate.Text = "Birthdate"
        '
        'dtpickerBirthdate
        '
        Me.dtpickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpickerBirthdate.Location = New System.Drawing.Point(996, 83)
        Me.dtpickerBirthdate.Name = "dtpickerBirthdate"
        Me.dtpickerBirthdate.Size = New System.Drawing.Size(200, 29)
        Me.dtpickerBirthdate.TabIndex = 20
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(1154, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 31)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(1052, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 31)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(950, 218)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 31)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(848, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 31)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(742, 161)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(290, 29)
        Me.txtContact.TabIndex = 15
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(742, 137)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(97, 21)
        Me.lblContact.TabIndex = 14
        Me.lblContact.Text = "Contact No."
        '
        'txtPurok
        '
        Me.txtPurok.Location = New System.Drawing.Point(487, 161)
        Me.txtPurok.Name = "txtPurok"
        Me.txtPurok.Size = New System.Drawing.Size(211, 29)
        Me.txtPurok.TabIndex = 13
        '
        'lblPurok
        '
        Me.lblPurok.AutoSize = True
        Me.lblPurok.Location = New System.Drawing.Point(487, 137)
        Me.lblPurok.Name = "lblPurok"
        Me.lblPurok.Size = New System.Drawing.Size(182, 21)
        Me.lblPurok.TabIndex = 12
        Me.lblPurok.Text = "Purok/Street/Home Blk"
        '
        'lblBarangay
        '
        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Location = New System.Drawing.Point(248, 137)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(77, 21)
        Me.lblBarangay.TabIndex = 11
        Me.lblBarangay.Text = "Barangay"
        '
        'cmbxBarangay
        '
        Me.cmbxBarangay.FormattingEnabled = True
        Me.cmbxBarangay.Location = New System.Drawing.Point(252, 161)
        Me.cmbxBarangay.Name = "cmbxBarangay"
        Me.cmbxBarangay.Size = New System.Drawing.Size(229, 29)
        Me.cmbxBarangay.TabIndex = 10
        '
        'lblMunicipality
        '
        Me.lblMunicipality.AutoSize = True
        Me.lblMunicipality.Location = New System.Drawing.Point(14, 137)
        Me.lblMunicipality.Name = "lblMunicipality"
        Me.lblMunicipality.Size = New System.Drawing.Size(99, 21)
        Me.lblMunicipality.TabIndex = 9
        Me.lblMunicipality.Text = "Municipality"
        '
        'cmbxMunicipality
        '
        Me.cmbxMunicipality.FormattingEnabled = True
        Me.cmbxMunicipality.Location = New System.Drawing.Point(18, 161)
        Me.cmbxMunicipality.Name = "cmbxMunicipality"
        Me.cmbxMunicipality.Size = New System.Drawing.Size(228, 29)
        Me.cmbxMunicipality.TabIndex = 8
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(865, 59)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(36, 21)
        Me.lblSex.TabIndex = 7
        Me.lblSex.Text = "Sex"
        '
        'cmbxSex
        '
        Me.cmbxSex.FormattingEnabled = True
        Me.cmbxSex.Location = New System.Drawing.Point(869, 83)
        Me.cmbxSex.Name = "cmbxSex"
        Me.cmbxSex.Size = New System.Drawing.Size(121, 29)
        Me.cmbxSex.TabIndex = 6
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(738, 59)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(43, 21)
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Role"
        '
        'cmbxRole
        '
        Me.cmbxRole.FormattingEnabled = True
        Me.cmbxRole.Location = New System.Drawing.Point(742, 83)
        Me.cmbxRole.Name = "cmbxRole"
        Me.cmbxRole.Size = New System.Drawing.Size(121, 29)
        Me.cmbxRole.TabIndex = 4
        '
        'txtGivenName
        '
        Me.txtGivenName.Location = New System.Drawing.Point(361, 83)
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.Size = New System.Drawing.Size(337, 29)
        Me.txtGivenName.TabIndex = 3
        '
        'lblGivenName
        '
        Me.lblGivenName.AutoSize = True
        Me.lblGivenName.Location = New System.Drawing.Point(361, 59)
        Me.lblGivenName.Name = "lblGivenName"
        Me.lblGivenName.Size = New System.Drawing.Size(98, 21)
        Me.lblGivenName.TabIndex = 2
        Me.lblGivenName.Text = "Given Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(14, 59)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 21)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(18, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(337, 29)
        Me.txtLastName.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.Black
        Me.lblSearch.Location = New System.Drawing.Point(949, 311)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 17)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search"
        '
        'txtEmployeeSearch
        '
        Me.txtEmployeeSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmployeeSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeSearch.Location = New System.Drawing.Point(1002, 308)
        Me.txtEmployeeSearch.Name = "txtEmployeeSearch"
        Me.txtEmployeeSearch.Size = New System.Drawing.Size(260, 25)
        Me.txtEmployeeSearch.TabIndex = 9
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtEmployeeSearch)
        Me.Controls.Add(Me.grpboxEmployee)
        Me.Controls.Add(Me.tableEmployee)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employee"
        CType(Me.tableEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxEmployee.ResumeLayout(False)
        Me.grpboxEmployee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableEmployee As DataGridView
    Friend WithEvents grpboxEmployee As GroupBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtPurok As TextBox
    Friend WithEvents lblPurok As Label
    Friend WithEvents lblBarangay As Label
    Friend WithEvents cmbxBarangay As ComboBox
    Friend WithEvents lblMunicipality As Label
    Friend WithEvents cmbxMunicipality As ComboBox
    Friend WithEvents lblSex As Label
    Friend WithEvents cmbxSex As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbxRole As ComboBox
    Friend WithEvents txtGivenName As TextBox
    Friend WithEvents lblGivenName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtEmployeeSearch As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents dtpickerBirthdate As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
