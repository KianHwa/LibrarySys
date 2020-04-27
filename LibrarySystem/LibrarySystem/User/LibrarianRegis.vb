Imports System.Text.RegularExpressions

Public Class LibrarianRegis
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

        Dim userId = "LB" + mskID.Text
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text
        Dim ic = mskIC.Text
        Dim address = txtAddress.Text
        Dim gender = cboGender.SelectedItem.ToString
        Dim status = lblLibrarian.Text
        Dim dob = datePicker.Value

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
    Private Sub LibrarianRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs = From m In db.Users Where m.UserID.StartsWith("LB")
        mskID.Text = (rs.Count() + 1).ToString("00000")
        mskID.Enabled = False
    End Sub

    Private Sub cboGender_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboGender.Validating
        Dim gender As String = cboGender.Text
        If gender = "" Then
            err.SetError(cboGender, "Please choose your Gender")
            e.Cancel = True
        Else
            err.SetError(cboGender, Nothing)
        End If
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim name As String = txtName.Text
        If name = "" Then
            err.SetError(txtName, "Please enter valid Name")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
        End If
    End Sub


    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        Dim pass As String = txtPassword.Text
        If pass = "" Then
            err.SetError(txtPassword, "Please enter valid Password")
            e.Cancel = True
        ElseIf pass.Length < 4 Then
            err.SetError(txtPassword, "Password must contains more than 4 characters")
            e.Cancel = True
        Else
            err.SetError(txtPassword, Nothing)
        End If
    End Sub

    Public Function IsValidIc(ic As String) As Boolean
        Dim chk As String = mskIC.Text.Substring(Len(mskIC.Text) - 1, 1) Mod 2
        If cboGender.SelectedItem = "Female" Then
            If chk = 0 Then
                Return True
            Else
                Return False
            End If
        ElseIf cboGender.SelectedItem = "Male" Then
            If chk <> 0 Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub mskIC_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskIC.Validating
        Dim ic As String = If(mskIC.MaskCompleted, txtPassword.Text, "")
        If IsValidIc(mskIC.Text) Then
            If ic = "" Then
                err.SetError(mskIC, "Please enter valid IC Number")
                e.Cancel = True
            ElseIf IsDuplicatedIc(ic) Then
                err.SetError(mskIC, mskIC.Text + " is Registered")
                e.Cancel = True
            Else
                err.SetError(mskIC, Nothing)
            End If
        Else
            err.SetError(mskIC, "Please enter valid IC Number")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        Dim address As String = txtAddress.Text
        If address = "" Then
            err.SetError(txtAddress, "Please enter valid Address")
            e.Cancel = True
        Else
            err.SetError(txtAddress, Nothing)
        End If
    End Sub
    Public Function IsDuplicatedIc(id As String) As Boolean
        Dim db As New LibraryDataContext()
        Return (From user In db.Users Where user.Ic = mskIC.Text).Any
    End Function

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim email As String = txtEmail.Text
        If IsValidEmailFormat(txtEmail.Text) Then
            If email = "" Then
                err.SetError(txtEmail, "Please enter your Email")
                e.Cancel = True
            Else
                err.SetError(txtEmail, Nothing)
            End If
        Else
            err.SetError(txtEmail, "Please enter valid format Email")
            e.Cancel = True
        End If
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        ElseIf chkShowPass.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class