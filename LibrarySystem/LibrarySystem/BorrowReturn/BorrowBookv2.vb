Imports System.Text

Public Class BorrowBookv2
    Dim db As New LibraryDataContext()

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        'Error checking
        ' (1) Validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        ' (2) Read inputs
        Dim id As String = If(txtMemberID.MaskCompleted, txtMemberID.Text, "")
        Dim name As String = txtMemberName.Text.Trim()

        ' (3) Validate Borrow details
        If id = "" Then
            err.AppendLine("- Member ID is invalid")
            ctr = If(ctr, txtMemberID)
        End If

        If name = "" Then
            err.AppendLine("- Member name is empty")
            ctr = If(ctr, txtMemberName)
        End If

        ' (4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        End If

        ' If ALL input is VALID, proceed ..
        ' =================================


        'Check if the book available

        If CheckBookExistence() = True Then
            'Check if the member has returned the book A (if he borrow book A again)
            Dim bookstatus = CheckCurrentBookStatus()
            If (bookstatus = True) Then
                'Prevent from borrow the same book again
                MessageBox.Show("The book is not returned.", "Failed to borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If lvBorrowList.Items.Count <= 5 Then
                    Dim memberID, status As String
                    memberID = formHome.loggedInID
                    status = "Borrow"

                    If lvBorrowList.Items.Count = 0 Then
                        Dim item As ListViewItem
                        item = lvBorrowList.Items.Add(lvBorrowList.Items.Count + 1)
                        item.SubItems.Add(txtISBN.Text)
                        item.SubItems.Add(GetBookName(txtISBN.Text))
                        item.SubItems.Add(dtpBorrowDate.Value.ToString("dd/MM/yyyy"))
                    Else
                        Dim existedInlist = False
                        For Each item As ListViewItem In lvBorrowList.Items
                            If item.SubItems.Item(1).Text = txtISBN.Text Then
                                existedInlist = True
                            End If
                        Next

                        If existedInlist = False Then
                            Dim item As ListViewItem
                            item = lvBorrowList.Items.Add(lvBorrowList.Items.Count + 1)
                            item.SubItems.Add(txtISBN.Text)
                            item.SubItems.Add(GetBookName(txtISBN.Text))
                            item.SubItems.Add(dtpBorrowDate.Value.ToString("dd/MM/yyyy"))
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
        Dim bookstatus = From b In db.Books Join br In db.Borrows On b.ISBN Equals br.ISBN Join m In db.Users On br.UserID Equals m.UserID Where br.status = "Borrow" And m.UserID = formHome.loggedInID And br.ISBN = txtISBN.Text
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
                    .UserID = formHome.loggedInID,
                    .status = "Borrow",
                    .borrowDate = dtpBorrowDate.Value.ToString()}
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

    Private Sub BorrowBookv2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dtpBorrowDate.Format = DateTimePickerFormat.Custom
        'dtpBorrowDate.CustomFormat = "dd/MM/yyyy"
        dtpBorrowDate.Value = DateTime.Now

        Dim member = From m In db.Users Where m.UserID = formHome.loggedInID
        txtMemberID.Text = formHome.loggedInID
        For Each loggedInMember In member
            txtMemberName.Text = loggedInMember.Name
        Next

    End Sub

    Private Sub DtpBorrowDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBorrowDate.ValueChanged

        Dim currentDate As DateTime = dtpBorrowDate.Value.ToString()
        Dim dueDate As DateTime = currentDate.AddDays(7)

        lblDueDate.Text = dueDate.ToString("dd/MM/yyyy")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ' Remove all book from borrow list
        lvBorrowList.Items.Clear()
    End Sub

    Private Sub LvBorrowList_DoubleClick(sender As Object, e As EventArgs) Handles lvBorrowList.DoubleClick
        Dim selectedItem = lvBorrowList.SelectedIndices(0)
        lvBorrowList.Items(selectedItem).Remove()

    End Sub


End Class