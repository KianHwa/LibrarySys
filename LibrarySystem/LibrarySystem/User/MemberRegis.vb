Public Class MemberRegis
    Private Sub ResetForm()
        txtName.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        mskIC.Text = ""
        cboGender.SelectedIndex = 0
        datePicker.Value = Date.Now
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim passLength As Integer

        Dim userId = "MM" + mskID.Text
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text
        Dim ic = mskIC.Text
        Dim address = txtAddress.Text
        Dim gender = cboGender.SelectedItem.ToString
        Dim status = lblStatus.Text
        Dim dob = datePicker.Value
        passLength = password.Length

        Dim user As New User()
        user.UserId = userId
        user.Name = name
        user.Email = email
        user.Password = password
        user.Ic = ic
        user.Address = address
        user.Gender = gender
        user.Status = status
        user.DateofBirth = dob

        Dim db As New UserDataContext()
        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()

        MsgBox("Member " + txtName.Text + " Registered", MsgBoxStyle.Information)
        formHome.loggedInID = userId
        formHome.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
        Me.Close()
    End Sub

End Class