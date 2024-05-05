Public Class relatedEmployeeInfo
    Private _passedEmployeeID As String
    Dim query As String

    Public Property passedEmployee As String
        Get
            Return _passedEmployeeID
        End Get
        Set(value As String)
            _passedEmployeeID = value

        End Set
    End Property

    Private Sub relatedEmployeeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRelatedEmpInfo()
    End Sub

    Public Sub LoadRelatedEmpInfo()
        txtLastName.Enabled = False
        txtGivenName.Enabled = False
        txtRole.Enabled = False
        txtSex.Enabled = False
        dtpickerBirthdate.Enabled = False
        txtMunicipality.Enabled = False
        txtBarangay.Enabled = False
        txtPurok.Enabled = False
        txtContact.Enabled = False
        Try
            query = "select * from employee where EmployeeID = '" & _passedEmployeeID & "'"
            readQuery(query)
            While cmdReader.Read
                txtLastName.Text = cmdReader.Item("LastName")
                txtGivenName.Text = cmdReader.Item("GivenName")
                txtRole.Text = cmdReader.Item("Role")
                txtSex.Text = cmdReader.Item("Sex")
                dtpickerBirthdate.Value = CType(cmdReader.Item("Birthdate"), DateTime)
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
