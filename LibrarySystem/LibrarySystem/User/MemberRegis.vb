Public Class MemberRegis
    Dim db As New LibraryDataContext()
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
        user.UserID = userId
        user.Name = name
        user.Email = email
        user.Password = password
        user.Ic = ic
        user.Address = address
        user.Gender = gender
        user.Status = status
        user.DateofBirth = dob

        db.Users.InsertOnSubmit(user)
        db.SubmitChanges()

        MsgBox("Member " + txtName.Text + " Registered", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
        Me.Close()
    End Sub

    Private Sub MemberRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = From m In db.Users Where m.UserID.StartsWith("MM")
        mskID.Text = rs.Count().ToString("00000")
    End Sub
End Class