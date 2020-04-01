Public Class BorrowBookv2
    Dim db As New LibraryDataContext()
    'Getting current date
    Dim todayDate As Date = Date.Now()
    Dim strDate As String = todayDate.ToString("dd/MM/yyyy")

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
                    If lvBorrowList.Items.Count <= 5 Then
                        Dim memberID, status As String
                        memberID = "M1001"
                        status = "Borrow"

                        If lvBorrowList.Items.Count = 0 Then
                            Dim item As ListViewItem
                            item = lvBorrowList.Items.Add(1)
                            item.SubItems.Add(txtISBN.Text)
                            item.SubItems.Add(GetBookName(txtISBN.Text))
                            item.SubItems.Add(strDate)
                        Else
                            Dim existedInlist = False
                            For Each item As ListViewItem In lvBorrowList.Items
                                If item.SubItems.Item(1).Text = txtISBN.Text Then
                                    existedInlist = True
                                End If
                            Next

                            If existedInlist = False Then
                                Dim item As ListViewItem
                                item = lvBorrowList.Items.Add(1)
                                item.SubItems.Add(txtISBN.Text)
                                item.SubItems.Add(GetBookName(txtISBN.Text))
                                item.SubItems.Add(strDate)
                            Else
                                MessageBox.Show("The book is already in the borrow list.", "Failed to borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End If

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

    Private Function CheckCurrentBookStatus() As Boolean
        'Check if the current borrow book is borrowed by the same person
        Dim isBorrow As Boolean = False
        Dim bookstatus = From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Members On br.memberID Equals m.memberID Where br.status = "Borrow" And m.memberID = formHome.loggedInID And br.ISBN = txtISBN.Text
        For Each bs In bookstatus
            isBorrow = True
        Next
        Return isBorrow
    End Function

    'Get book name
    Private Function GetBookName(isbn As String) As String
        For Each book In db.Books
            If book.ISBN = isbn Then
                Return book.bookName
            End If
        Next
        Return "None"
    End Function



    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the book?", "Removing a book", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If lvBorrowList.SelectedItems.Count > 0 Then
                For n As Integer = lvBorrowList.SelectedItems.Count - 1 To 0 Step -1
                    ' remove the current selected item from items
                    lvBorrowList.Items.Remove(lvBorrowList.SelectedItems(n))
                Next n
                MessageBox.Show("Successfully removed from borrow list", "Remove successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Remove failed, please select a book to remove", "Remove failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the textboxes
        txtMemberID.Clear()
        txtMemberName.Clear()
        txtISBN.Clear()

        'Focus to the desired textbox
        txtMemberID.Focus()
    End Sub



    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim result As DialogResult = MessageBox.Show("Confirm borrow?", "Borrowing a book", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If lvBorrowList.Items.Count > 0 Then
                'Borrow the book
                For Each item As ListViewItem In lvBorrowList.Items
                    'Borrow the book
                    Dim borrow As New Borrow With {
                    .ISBN = item.SubItems.Item(1).Text,
                    .memberID = formHome.loggedInID,
                    .status = "Borrow",
                    .borrowDate = strDate}
                    db.Borrows.InsertOnSubmit(borrow)
                Next
                MessageBox.Show("Successfully borrowed", "Borrow successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvBorrowList.Items.Clear()

                'Clear all the textboxes
                txtMemberID.Clear()
                txtMemberName.Clear()
                txtISBN.Clear()

                'Focus to the desired textbox
                txtMemberID.Focus()

                db.SubmitChanges()
            Else
                MessageBox.Show("Borrow list is empty", "Borrow failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
    End Sub
End Class