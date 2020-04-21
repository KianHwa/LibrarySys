Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsValidUser(mskId.Text, txtPassword.Text) Then
            LibrarySystem.formHome.ShowDialog()
        Else
            MessageBox.Show("Invalid Name or Password", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Function IsValidUser(Name As String, Password As String) As Boolean
        Dim db As New UserDataContext()
        Return (From user In db.Users Where user.UserId = mskId.Text And user.Password = txtPassword.Text).Any
    End Function
End Class