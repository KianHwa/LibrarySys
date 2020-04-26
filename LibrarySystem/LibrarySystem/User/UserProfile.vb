Public Class UserProfile

    Private Sub UserProfile_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim db As New UserDataContext()
        Dim user As User = db.Users.FirstOrDefault(Function(o) o.UserId = LibrarySystem.formHome.loggedInID)

        If user Is Nothing Then
            MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        lblUserId.Text = user.UserId
        lblName.Text = user.Name
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        ElseIf chkShowPass.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
        txtPassword.Text = user.Password
        txtPassword.Enabled = False
        lblGender.Text = user.Gender
        lblDob.Text = user.DateOfBirth
        lblIc.Text = user.Ic
        txtAddress.Text = user.Address
        txtEmail.Text = user.Email
        labelStatus.Text = user.Status

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New UserDataContext()
        Dim user As User = db.Users.FirstOrDefault(Function(o) o.UserId = LibrarySystem.formHome.loggedInID)

        If user Is Nothing Then
            MessageBox.Show("User not found", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        user.Status = labelStatus.Text
        user.Password = txtPassword.Text
        user.Email = txtEmail.Text
        user.Address = txtAddress.Text

        db.SubmitChanges()

        MessageBox.Show("User [" + lblName.Text + "] updated")
        Me.Close()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        txtPassword.Enabled = True
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        ElseIf chkShowPass.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub

End Class