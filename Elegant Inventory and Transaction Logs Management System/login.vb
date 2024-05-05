Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Then
            MsgBox("Username entry is empty, please fill it out.")
            txt_username.Focus()
            Exit Sub
        End If
        If txt_password.Text = "" Then
            MsgBox("Password entry is empty, please fill it out.")
            txt_password.Focus()
            Exit Sub
        End If

        Try
            'check account if existing query
            Dim query As String = "SELECT * FROM admin WHERE Username = '" + txt_username.Text + "' AND Password = '" + txt_password.Text + "'"
            readQuery(query)
            If (cmdReader.Read) Then
                frmMain.Show()
                Me.Hide()
                txt_username.Text = ""
                txt_password.Text = ""
            Else
                MsgBox("Username and Password might be incorrect. Please enter a valid one.")
                txt_username.Text = ""
                txt_password.Text = ""
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        ' Setting password characters to • to show bullets instead of actual characters
        txt_password.PasswordChar = "•"
    End Sub

    Private Sub chbx_showpwd_CheckedChanged(sender As Object, e As EventArgs) Handles check_togglepwd.CheckedChanged
        If check_togglepwd.Checked Then
            ' If the checkbox is checked, show the password
            txt_password.PasswordChar = ControlChars.NullChar ' Show actual characters
        Else
            ' If the checkbox is unchecked, hide the password
            txt_password.PasswordChar = "•"
        End If
    End Sub

End Class