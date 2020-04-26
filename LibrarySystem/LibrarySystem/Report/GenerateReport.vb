Public Class GenerateReport

    Private Sub btnReportBorrowBook_Click(sender As Object, e As EventArgs) Handles btnReportBorrowBook.Click
        ViewReport.ShowDialog(Me)
    End Sub

    Private Sub btnReportReturnBook_Click(sender As Object, e As EventArgs) Handles btnReportReturnBook.Click
        ViewReportReturnBook.ShowDialog(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReportMember_Click(sender As Object, e As EventArgs) Handles btnReportMember.Click
        ViewReportMember.ShowDialog(Me)
    End Sub
End Class