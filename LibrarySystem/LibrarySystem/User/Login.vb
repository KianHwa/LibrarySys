Public Class Login
    Private Sub ResetForm()
        txtPassword.Text = ""
        mskId.Text = ""
        err.Clear()
    End Sub

    ' Dim userID As String
    Dim role As String = ""
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New LibraryDataContext()
        Dim status As String = ""
        For Each u In db.Users
            If u.UserID = mskId.Text Then
                status = u.Request.ToString
            End If
        Next
        If IsValidUser(mskId.Text, txtPassword.Text) Then

            If mskId.Text.Contains("LB") Or mskId.Text.Contains("lb") Or (mskId.Text.Contains("MM") And status = "Requested") Then
                LibrarySystem.formHome.loggedInID = mskId.Text
                LibrarySystem.formHome.tsmiRegisterLibrarian.Enabled = False
                LibrarySystem.formHome.tsmiAddBooks.Enabled = True
                LibrarySystem.formHome.tsmiRequest.Enabled = True
                Me.Hide()
                LibrarySystem.formHome.ShowDialog()
                ResetForm()
            ElseIf mskId.Text.Contains("MM") Or mskId.Text.Contains("mm") Then
                LibrarySystem.formHome.loggedInID = mskId.Text
                LibrarySystem.formHome.btnBookReturn.Enabled = False
                LibrarySystem.formHome.menuReports.Enabled = False
                LibrarySystem.formHome.tsmiAddBooks.Enabled = False
                LibrarySystem.formHome.tsmiRequest.Enabled = False
                LibrarySystem.formHome.tsmiRegisterLibrarian.Enabled = True
                Me.Hide()
                LibrarySystem.formHome.ShowDialog()
                ResetForm()
            Else
                LibrarySystem.formHome.tsmiRegisterLibrarian.Enabled = True
                LibrarySystem.formHome.tsmiAddBooks.Enabled = True
                LibrarySystem.formHome.loggedInID = mskId.Text
                Me.Hide()
                LibrarySystem.formHome.ShowDialog()
                ResetForm()
            End If
        ElseIf mskId.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter User ID and Password", "Invalid Login")
        Else
            MessageBox.Show("Invalid User ID or Password", "Invalid Login")
        End If
    End Sub

    Private Function IsValidUser(Name As String, Password As String) As Boolean
        Dim db As New LibraryDataContext()
        Dim status As String = ""
        For Each u In db.Users
            If u.UserID = mskId.Text Then
                status = u.Request.ToString
            End If
        Next

        If role = "Admin" Then
            Return (From user In db.Users Where user.UserID = mskId.Text And user.Password = txtPassword.Text And user.UserID.StartsWith("AD")).Any

        ElseIf role = "Member" Then
            If status <> "Requested" Then
                Return (From user In db.Users Where user.UserID = mskId.Text And user.Password = txtPassword.Text And user.UserID.StartsWith("MM")).Any
            End If

        ElseIf role = "Librarian" Then
            If status = "Requested" Then
                Return (From user In db.Users Where user.UserID = mskId.Text And user.Password = txtPassword.Text And (user.UserID.StartsWith("MM"))).Any
            Else
                Return (From user In db.Users Where user.UserID = mskId.Text And user.Password = txtPassword.Text And (user.UserID.StartsWith("LB"))).Any
            End If
        End If

    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MemberRegis.ShowDialog()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Visible = False
        btnRegister.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack2.Visible = False
        btnBack3.Visible = False
        btnBack4.Visible = False
        btnBack.Visible = False
        chkShowPass.Visible = False
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        Label1.Visible = True
        Label2.Visible = True
        txtPassword.Visible = True
        mskId.Visible = True
        btnLogin.Visible = True
        btnRegister.Visible = True
        btnLibrarian.Visible = False
        btnMember.Visible = False
        btnBack.Visible = True
        chkShowPass.Visible = True
        btnBack4.Visible = True
        mskId.Focus()
        role = "Member"
    End Sub

    Private Sub btnLibrarian_Click(sender As Object, e As EventArgs) Handles btnLibrarian.Click
        Label1.Visible = False
        Label2.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        btnLogin.Visible = False
        btnRegister.Visible = False
        btnLibrarian.Visible = False
        btnMember.Visible = False
        btnLogLibrarian.Visible = True
        btnLogAdmin.Visible = True
        btnBack.Visible = False
        btnBack2.Visible = True
        chkShowPass.Visible = False
        mskId.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnLogin.Visible = False
        btnRegister.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        btnLibrarian.Visible = True
        btnMember.Visible = True
        chkShowPass.Visible = False
        err.Clear()
        ResetForm()
    End Sub

    Private Sub btnLogLibrarian_Click(sender As Object, e As EventArgs) Handles btnLogLibrarian.Click
        Label1.Visible = True
        Label2.Visible = True
        txtPassword.Visible = True
        mskId.Visible = True
        btnLogin.Visible = True
        btnRegister.Visible = False
        btnLibrarian.Visible = False
        btnMember.Visible = False
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack.Visible = False
        btnBack2.Visible = False
        btnBack3.Visible = True
        chkShowPass.Visible = True
        mskId.Focus()
        role = "Librarian"
    End Sub

    Private Sub btnLogAdmin_Click(sender As Object, e As EventArgs) Handles btnLogAdmin.Click
        Label1.Visible = True
        Label2.Visible = True
        txtPassword.Visible = True
        mskId.Visible = True
        btnLogin.Visible = True
        btnRegister.Visible = False
        btnLibrarian.Visible = False
        btnMember.Visible = False
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack.Visible = False
        btnBack2.Visible = False
        btnBack3.Visible = True
        chkShowPass.Visible = True
        mskId.Focus()
        role = "Admin"
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Label1.Visible = False
        Label2.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        btnLogin.Visible = False
        btnRegister.Visible = False
        btnLibrarian.Visible = True
        btnMember.Visible = True
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack.Visible = False
        btnBack2.Visible = False
        chkShowPass.Visible = False
        err.Clear()
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        Label1.Visible = False
        Label2.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        btnLogin.Visible = False
        btnRegister.Visible = False
        btnLibrarian.Visible = False
        btnMember.Visible = False
        btnLogAdmin.Visible = True
        btnLogLibrarian.Visible = True
        btnBack.Visible = False
        btnBack2.Visible = True
        btnBack3.Visible = False
        chkShowPass.Visible = False
        err.Clear()
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        ElseIf chkShowPass.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub mskId_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskId.Validating
        Dim id As String = If(mskId.MaskCompleted, mskId.Text, "")

        If id = "" Then
            err.SetError(mskId, "Please enter valid ID")
            e.Cancel = True
        Else
            err.SetError(mskId, Nothing)
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        Dim pass As String = txtPassword.Text

        If pass = "" Then
            err.SetError(txtPassword, "Please enter valid Password")
            e.Cancel = True
        Else
            err.SetError(txtPassword, Nothing)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        Label1.Visible = False
        Label2.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        btnLogin.Visible = False
        btnRegister.Visible = False
        btnLibrarian.Visible = True
        btnMember.Visible = True
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack.Visible = False
        btnBack2.Visible = False
        btnBack3.Visible = False
        btnBack4.Visible = False
        chkShowPass.Visible = False
        err.Clear()
    End Sub
End Class