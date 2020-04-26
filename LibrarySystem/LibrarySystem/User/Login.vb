Public Class Login
    Private Sub ResetForm()
        txtPassword.Text = ""
        mskId.Text = ""
    End Sub

    Dim userID As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsValidUser(userID, txtPassword.Text) Then
            If userID.Contains("LB") Or userID.Contains("lb") Then
                LibrarySystem.formHome.loggedInID = "LB" + mskId.Text
                LibrarySystem.formHome.tsmiRegisterLibrarian.Enabled = False
                LibrarySystem.formHome.ShowDialog()
                Me.Close()
            ElseIf userID.Contains("MM") Or userID.Contains("mm") Then
                LibrarySystem.formHome.loggedInID = "MM" + mskId.Text
                LibrarySystem.formHome.btnBookReturn.Enabled = False
                LibrarySystem.formHome.menuReports.Enabled = False
                LibrarySystem.formHome.tsmiAddBooks.Enabled = False
                LibrarySystem.formHome.tsmiRegisterLibrarian.Enabled = False
                LibrarySystem.formHome.ShowDialog()
                Me.Close()
            Else
                LibrarySystem.formHome.loggedInID = "AD" + mskId.Text
                LibrarySystem.formHome.ShowDialog()
                Me.Close()
            End If

        Else
            MessageBox.Show("Invalid Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsValidUser(Name As String, Password As String) As Boolean
        Dim db As New LibraryDataContext()
        If userID.Contains("MM") Then
            Return (From user In db.Users Where user.UserId = "MM" + mskId.Text And user.Password = txtPassword.Text).Any
        ElseIf userID.Contains("LB") Then
            Return (From user In db.Users Where user.UserId = "LB" + mskId.Text And user.Password = txtPassword.Text).Any
        Else
            Return (From user In db.Users Where user.UserId = "AD" + mskId.Text And user.Password = txtPassword.Text).Any
        End If
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MemberRegis.ShowDialog()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mskId.Focus()
        btnLogin.Visible = False
        btnRegister.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        lblId.Visible = False
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack2.Visible = False
        btnBack3.Visible = False
        btnBack.Visible = False
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
        lblId.Visible = True
        lblId.Text = "MM"
        userID = "MM" + mskId.Text
        btnBack.Visible = True
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
        lblId.Visible = False
        btnLogLibrarian.Visible = True
        btnLogAdmin.Visible = True
        btnBack.Visible = False
        btnBack2.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnLogin.Visible = False
        btnRegister.Visible = False
        txtPassword.Visible = False
        mskId.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        lblId.Visible = False
        btnLibrarian.Visible = True
        btnMember.Visible = True
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
        lblId.Visible = True
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        lblId.Text = "LB"
        userID = "LB" + mskId.Text
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
        lblId.Visible = True
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack.Visible = False
        btnBack2.Visible = False
        btnBack3.Visible = True
        lblId.Text = "AD"
        userID = "AD" + mskId.Text
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
        lblId.Visible = False
        btnLogAdmin.Visible = False
        btnLogLibrarian.Visible = False
        btnBack.Visible = False
        btnBack2.Visible = False
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
        lblId.Visible = False
        btnLogAdmin.Visible = True
        btnLogLibrarian.Visible = True
        btnBack.Visible = False
        btnBack2.Visible = True
        btnBack3.Visible = False
    End Sub
End Class