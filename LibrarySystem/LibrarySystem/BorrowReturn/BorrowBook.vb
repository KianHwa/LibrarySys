Public Class BorrowBook
    Dim db As New LibraryDataContext()
    Private Sub BorrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display current book borrowed
        RefreshBorrowData()

        'Customize header view
        dgvBorrow.Columns(0).HeaderCell.Value = "Borrow ID"
        dgvBorrow.Columns(1).HeaderCell.Value = "Book Name"
        dgvBorrow.Columns(2).HeaderCell.Value = "ISBN"
        dgvBorrow.Columns(3).HeaderCell.Value = "Borrow Date"
    End Sub

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        'Check if the book available
        Try
            If CheckBookExistence() = True Then
                'Check if the member has returned the book A (if he borrow book A again)
                Dim bookstatus = CheckCurrentBookStatus()
                If (bookstatus = True) Then
                    'Prevent from borrow the same book again
                    MessageBox.Show("The book is not returned.", "Failed to borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If CountBorrowBook() <= 5 Then
                        'Borrow the book
                        Dim borrow As New Borrow With {
                        .ISBN = txtISBN.Text,
                        .memberID = "M1001",
                        .status = "Borrow"}
                        db.Borrows.InsertOnSubmit(borrow)

                        db.SubmitChanges()
                        RefreshBorrowData()

                        MessageBox.Show("Successfully borrow a book", "Borrow successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        'Maximum five books at a time
                        MessageBox.Show("Sorry, you can only borrow five books at a time ", "Failed to borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                'Book not found
                MessageBox.Show("Book with ISBN " & txtISBN.Text & " not found", "Book not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshBorrowData()
        'Refresh the borrow table
        Dim currentBorrow = From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Members On br.memberID Equals m.memberID Where m.memberID = "M1001" And br.status = "Borrow" Select br.borrowID, b.bookName, b.ISBN, br.borrowDate
        dgvBorrow.DataSource = currentBorrow

    End Sub

    Private Function CheckCurrentBookStatus() As Boolean
        'Check if the current borrow book is borrowed by the same person
        Dim isBorrow As Boolean = False
        Dim bookstatus = From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Members On br.memberID Equals m.memberID Where br.status = "Borrow" And m.memberID = "M1001" And br.ISBN = txtISBN.Text
        For Each bs In bookstatus
            isBorrow = True
        Next
        Return isBorrow
    End Function

    Private Function CountBorrowBook() As Integer
        'Check the total borrowed book at that time
        Dim bookCount As Integer = 0
        Dim bookstatus = From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Members On br.memberID Equals m.memberID Where br.status = "Borrow" And m.memberID = "M1001"
        For Each bs In bookstatus
            bookCount += 1
        Next
        Return bookCount
    End Function

    Private Function CheckBookExistence() As Boolean
        'Check if the book is exist in the library
        Dim exist As Boolean = False
        For Each book In db.Books
            If book.ISBN = txtISBN.Text Then
                exist = True
            End If
        Next
        Return exist
    End Function

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the textboxes
        txtMemberID.Clear()
        txtMemberName.Clear()
        txtISBN.Clear()

        'Focus to the desired textbox
        txtMemberID.Focus()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            'Remove a borrowed book based on the ISBN entered (the book will not turn to RETURN status
            Dim removeBorrowedBook = (From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Members On br.memberID Equals m.memberID Where m.memberID = "M1001" And br.status = "Borrow" And b.ISBN = txtRemoveBorrowBook.Text Select br).Single()
            db.Borrows.DeleteOnSubmit(removeBorrowedBook)


            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the book?", "Removing a book", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            'If the user click OK button
            If result = DialogResult.OK Then
                db.SubmitChanges()
                RefreshBorrowData()
                MessageBox.Show("Successfully removed from borrow list", "Remove successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch
            'Book not found
            MessageBox.Show("Book with ISBN " & txtISBN.Text & " not found", "Book not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class