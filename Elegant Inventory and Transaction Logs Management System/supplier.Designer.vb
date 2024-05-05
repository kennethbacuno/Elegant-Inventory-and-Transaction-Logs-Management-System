<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplier
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
        Me.tableSupplier = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpboxSupplier = New System.Windows.Forms.GroupBox()
        Me.cmbxProvince = New System.Windows.Forms.ComboBox()
        Me.lblProvince = New System.Windows.Forms.Label()
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
        Me.txtGivenName = New System.Windows.Forms.TextBox()
        Me.lblGivenName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tableSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableSupplier
        '
        Me.tableSupplier.AllowUserToAddRows = False
        Me.tableSupplier.AllowUserToDeleteRows = False
        Me.tableSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tableSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column10, Me.Column4, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.tableSupplier.Location = New System.Drawing.Point(12, 339)
        Me.tableSupplier.Name = "tableSupplier"
        Me.tableSupplier.ReadOnly = True
        Me.tableSupplier.RowHeadersVisible = False
        Me.tableSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableSupplier.Size = New System.Drawing.Size(1256, 369)
        Me.tableSupplier.TabIndex = 1
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
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Province"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
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
        'grpboxSupplier
        '
        Me.grpboxSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxSupplier.Controls.Add(Me.cmbxProvince)
        Me.grpboxSupplier.Controls.Add(Me.lblProvince)
        Me.grpboxSupplier.Controls.Add(Me.lblBirthdate)
        Me.grpboxSupplier.Controls.Add(Me.dtpickerBirthdate)
        Me.grpboxSupplier.Controls.Add(Me.btnClear)
        Me.grpboxSupplier.Controls.Add(Me.btnSave)
        Me.grpboxSupplier.Controls.Add(Me.btnUpdate)
        Me.grpboxSupplier.Controls.Add(Me.btnDelete)
        Me.grpboxSupplier.Controls.Add(Me.txtContact)
        Me.grpboxSupplier.Controls.Add(Me.lblContact)
        Me.grpboxSupplier.Controls.Add(Me.txtPurok)
        Me.grpboxSupplier.Controls.Add(Me.lblPurok)
        Me.grpboxSupplier.Controls.Add(Me.lblBarangay)
        Me.grpboxSupplier.Controls.Add(Me.cmbxBarangay)
        Me.grpboxSupplier.Controls.Add(Me.lblMunicipality)
        Me.grpboxSupplier.Controls.Add(Me.cmbxMunicipality)
        Me.grpboxSupplier.Controls.Add(Me.lblSex)
        Me.grpboxSupplier.Controls.Add(Me.cmbxSex)
        Me.grpboxSupplier.Controls.Add(Me.txtGivenName)
        Me.grpboxSupplier.Controls.Add(Me.lblGivenName)
        Me.grpboxSupplier.Controls.Add(Me.lblLastName)
        Me.grpboxSupplier.Controls.Add(Me.txtLastName)
        Me.grpboxSupplier.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxSupplier.Location = New System.Drawing.Point(12, 12)
        Me.grpboxSupplier.Name = "grpboxSupplier"
        Me.grpboxSupplier.Size = New System.Drawing.Size(1256, 255)
        Me.grpboxSupplier.TabIndex = 2
        Me.grpboxSupplier.TabStop = False
        Me.grpboxSupplier.Text = "Supplier Form"
        '
        'cmbxProvince
        '
        Me.cmbxProvince.FormattingEnabled = True
        Me.cmbxProvince.Location = New System.Drawing.Point(18, 156)
        Me.cmbxProvince.Name = "cmbxProvince"
        Me.cmbxProvince.Size = New System.Drawing.Size(228, 29)
        Me.cmbxProvince.TabIndex = 23
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(14, 132)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(73, 21)
        Me.lblProvince.TabIndex = 22
        Me.lblProvince.Text = "Province"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Location = New System.Drawing.Point(844, 56)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(78, 21)
        Me.lblBirthdate.TabIndex = 21
        Me.lblBirthdate.Text = "Birthdate"
        '
        'dtpickerBirthdate
        '
        Me.dtpickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpickerBirthdate.Location = New System.Drawing.Point(848, 80)
        Me.dtpickerBirthdate.Name = "dtpickerBirthdate"
        Me.dtpickerBirthdate.Size = New System.Drawing.Size(166, 29)
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
        Me.txtContact.Location = New System.Drawing.Point(1020, 80)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(203, 29)
        Me.txtContact.TabIndex = 15
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(1017, 56)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(97, 21)
        Me.lblContact.TabIndex = 14
        Me.lblContact.Text = "Contact No."
        '
        'txtPurok
        '
        Me.txtPurok.Location = New System.Drawing.Point(721, 156)
        Me.txtPurok.Name = "txtPurok"
        Me.txtPurok.Size = New System.Drawing.Size(211, 29)
        Me.txtPurok.TabIndex = 13
        '
        'lblPurok
        '
        Me.lblPurok.AutoSize = True
        Me.lblPurok.Location = New System.Drawing.Point(721, 132)
        Me.lblPurok.Name = "lblPurok"
        Me.lblPurok.Size = New System.Drawing.Size(182, 21)
        Me.lblPurok.TabIndex = 12
        Me.lblPurok.Text = "Purok/Street/Home Blk"
        '
        'lblBarangay
        '
        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Location = New System.Drawing.Point(482, 132)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(77, 21)
        Me.lblBarangay.TabIndex = 11
        Me.lblBarangay.Text = "Barangay"
        '
        'cmbxBarangay
        '
        Me.cmbxBarangay.FormattingEnabled = True
        Me.cmbxBarangay.Location = New System.Drawing.Point(486, 156)
        Me.cmbxBarangay.Name = "cmbxBarangay"
        Me.cmbxBarangay.Size = New System.Drawing.Size(229, 29)
        Me.cmbxBarangay.TabIndex = 10
        '
        'lblMunicipality
        '
        Me.lblMunicipality.AutoSize = True
        Me.lblMunicipality.Location = New System.Drawing.Point(248, 132)
        Me.lblMunicipality.Name = "lblMunicipality"
        Me.lblMunicipality.Size = New System.Drawing.Size(99, 21)
        Me.lblMunicipality.TabIndex = 9
        Me.lblMunicipality.Text = "Municipality"
        '
        'cmbxMunicipality
        '
        Me.cmbxMunicipality.FormattingEnabled = True
        Me.cmbxMunicipality.Location = New System.Drawing.Point(252, 156)
        Me.cmbxMunicipality.Name = "cmbxMunicipality"
        Me.cmbxMunicipality.Size = New System.Drawing.Size(228, 29)
        Me.cmbxMunicipality.TabIndex = 8
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(717, 56)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(36, 21)
        Me.lblSex.TabIndex = 7
        Me.lblSex.Text = "Sex"
        '
        'cmbxSex
        '
        Me.cmbxSex.FormattingEnabled = True
        Me.cmbxSex.Location = New System.Drawing.Point(721, 80)
        Me.cmbxSex.Name = "cmbxSex"
        Me.cmbxSex.Size = New System.Drawing.Size(121, 29)
        Me.cmbxSex.TabIndex = 6
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
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(1051, 304)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(211, 29)
        Me.txtSearch.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(988, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Search"
        '
        'supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpboxSupplier)
        Me.Controls.Add(Me.tableSupplier)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "supplier"
        Me.Text = "supplier"
        CType(Me.tableSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxSupplier.ResumeLayout(False)
        Me.grpboxSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableSupplier As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents grpboxSupplier As GroupBox
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents dtpickerBirthdate As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
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
    Friend WithEvents txtGivenName As TextBox
    Friend WithEvents lblGivenName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents cmbxProvince As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
End Class
