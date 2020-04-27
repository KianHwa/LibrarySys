Public Class Request
    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Dim db As New LibraryDataContext()
        Dim confirm As MsgBoxResult
        confirm = MsgBox("Confirm to proceed ?", MsgBoxStyle.YesNo, "Confirmation")
        If confirm = MsgBoxResult.Yes Then
            For Each u In db.Users
                If u.UserID = formHome.loggedInID Then
                    u.Request = "Requesting"
                End If
            Next
        End If
        For Each i In db.Users
            If i.UserID = formHome.loggedInID And i.Request = "Requesting" Then
                MessageBox.Show("We have received your request and will contact you as soon as possible", "Request")
            End If
        Next
        Me.Close()
        db.SubmitChanges()
    End Sub
End Class