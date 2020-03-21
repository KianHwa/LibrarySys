Public Class formHome
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBookBorrow_Click(sender As Object, e As EventArgs) Handles btnBookBorrow.Click
        BorrowBook.ShowDialog()
    End Sub
End Class