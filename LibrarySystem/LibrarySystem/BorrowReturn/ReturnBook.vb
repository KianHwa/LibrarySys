Public Class ReturnBook
    Dim db As New LibraryDataContext()
    Dim todayDate = DateTime.Now
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If CheckIfBorrow() Then
            If DateDiff(DateInterval.Day, todayDate, GetBorrowDate()) <= 7 Then
                ' Do something here





                MessageBox.Show("Book Returned.", "Successfully return", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Do something here 
                ' Fine





                MessageBox.Show("Fine charged", "Successfully return", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("The book is not being borrow", "Failed to borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    ' Check if the book is in borrow status (only can return the book if it is in BORROW status)
    Private Function CheckIfBorrow() As Boolean
        Dim isBorrow As Boolean = False
        Dim returnBook = From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Members On br.memberID Equals m.memberID
                         Where m.memberID = formHome.loggedInID And br.ISBN = txtISBN.Text And br.status = "Borrow"

        For Each rb In returnBook
            isBorrow = True
        Next
        Return isBorrow
    End Function

    ' Get borrow date (of particular book)
    Private Function GetBorrowDate() As Date
        Dim borrowdate As DateTime
        Dim bookBorrowDate = From br In db.Borrows Where br.ISBN = txtISBN.Text
        For Each bd In bookBorrowDate
            borrowdate = bd.borrowDate
        Next
        Return borrowdate
    End Function

    Private Sub BtnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        todayDate = dtpSimulator.Value
    End Sub
End Class