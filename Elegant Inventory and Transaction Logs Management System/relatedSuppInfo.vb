Public Class relatedSuppInfo
    Private _passedSupplierID As String
    Dim query As String

    Public Property passedEmployee As String
        Get
            Return _passedSupplierID
        End Get
        Set(value As String)
            _passedSupplierID = value

        End Set
    End Property

    Private Sub relatedSuppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRelatedSuppInfo()
    End Sub

    Public Sub LoadRelatedSuppInfo()
        txtLastName.Enabled = False
        txtGivenName.Enabled = False
        txtSex.Enabled = False
        dtpickerBirthdate.Enabled = False
        txtProvince.Enabled = False
        txtMunicipality.Enabled = False
        txtBarangay.Enabled = False
        txtPurok.Enabled = False
        txtContact.Enabled = False
        Try
            query = "select * from supplier where SupplierID = '" & _passedSupplierID & "'"
            readQuery(query)
            While cmdReader.Read
                txtLastName.Text = cmdReader.Item("LastName")
                txtGivenName.Text = cmdReader.Item("GivenName")
                txtSex.Text = cmdReader.Item("Sex")
                dtpickerBirthdate.Value = CType(cmdReader.Item("Birthdate"), DateTime)
                txtProvince.Text = cmdReader.Item("Province")
                txtMunicipality.Text = cmdReader.Item("Municipality")
                txtBarangay.Text = cmdReader.Item("Barangay")
                txtPurok.Text = cmdReader.Item("Purok")
                txtContact.Text = cmdReader.Item("ContactNo")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

End Class
