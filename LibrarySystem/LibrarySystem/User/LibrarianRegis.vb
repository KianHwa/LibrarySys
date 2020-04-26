Public Class LibrarianRegis
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

        Dim userId = "LB" + mskID.Text
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text
        Dim ic = mskIC.Text
        Dim address = txtAddress.Text
        Dim gender = cboGender.SelectedItem.ToString
        Dim status = lblLibrarian.Text
        Dim dob = datePicker.Value
        passLength = password.Length

        If passLength < 4 Then
            MessageBox.Show("Password must be minimum 4 character long", "Invalid Password Style")
        ElseIf name.IndexOf("LB") > 0 Then

        End If
        Dim user As New User()
        user.UserId = userId
        user.Name = name
        user.Email = email
        user.Password = password
        user.Ic = ic
        user.Address = address
        user.Gender = gender
        user.Status = status
        user.DateOfBirth = dob

        Dim db As New LibraryDataContext()
        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()

        MsgBox("Librarian " + txtName.Text + " Registered", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
        Me.Close()
    End Sub

End Class