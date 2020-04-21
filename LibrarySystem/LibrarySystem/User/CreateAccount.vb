Public Class CreateAccount
    Private Sub ResetForm()
        txtName.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        mskIC.Text = ""
        cboOccupation.SelectedIndex = 0
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

        Dim userId = mskID.Text
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text
        Dim ic = mskIC.Text
        Dim address = txtAddress.Text
        Dim gender = cboGender.SelectedItem.ToString
        Dim occupation = cboOccupation.SelectedItem.ToString
        Dim dob = datePicker.Value

        Dim user As New User()
        user.UserId = userId
        user.Name = name
        user.Email = email
        user.Password = password
        user.Ic = ic
        user.Address = address
        user.Gender = gender
        user.Occupation = occupation
        user.DateOfBirth = dob

        Dim db As New UserDataContext()
        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()

        MessageBox.Show("User [" + txtName.Text + "] Inserted")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class