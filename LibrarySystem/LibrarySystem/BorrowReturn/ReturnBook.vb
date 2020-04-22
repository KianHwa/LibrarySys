Imports System.Data.SqlClient
Imports System.Text

Public Class ReturnBook
    Dim db As New LibraryDataContext()
    Dim finedBooks As New StringBuilder()
    Dim count As Integer = 0

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If lvBorrowList.Items.Count <= 0 Then
            MessageBox.Show("No book selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Focus()
            Exit Sub
        End If
        For Each item In lvBorrowList.Items
            Dim bookISBN As String = item.SubItems(1).Text
            If Math.Abs(DateDiff(DateInterval.Day, Date.Now(), GetBorrowDate(bookISBN))) >= 7 Then
                finedBooks.Append(bookISBN + vbNewLine)
            End If
        Next

        If finedBooks.Length > 0 Then
            MessageBox.Show("Overdue Books: " + vbNewLine + finedBooks.ToString(), "Overdue!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnPaid.Visible = True
            btnReturn.Enabled = False
            Exit Sub
        Else
            For Each item In lvBorrowList.Items
                Dim bookISBN As String = item.SubItems(1).Text

                If Math.Abs(DateDiff(DateInterval.Day, Date.Now(), GetBorrowDate(bookISBN))) <= 7 Then
                    For Each record In db.Borrows
                        If record.ISBN = bookISBN Then
                            record.status = "Returned"
                            record.returnDate = Date.Now()
                        End If
                    Next
                End If
            Next
            db.SubmitChanges()
            MessageBox.Show("Book returned successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lvBorrowList.Items.Clear()
        End If
    End Sub

    'Get borrow Date (Of particular book)
    Private Function GetBorrowDate(bookISBN As String) As Date
        Dim borrowdate As DateTime
        Dim bookBorrowDate = From br In db.Borrows Where br.ISBN = bookISBN
        For Each bd In bookBorrowDate
            borrowdate = bd.borrowDate
        Next
        Return borrowdate
    End Function

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        err.Clear()

        Try
            Dim stdId As String = txtID.Text

            ' Check whether input fields are empty
            If stdId = Nothing Then
                err.SetError(txtID, "Please enter valid [ID]")
                txtID.Focus()
                Return
            End If

            lvBorrowList.Items.Clear()
            txtName.Text = ""
            BindData(stdId)
        Catch ex As Exception
            MessageBox.Show("Please enter valid details!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BindData(id As String)
        Dim item As ListViewItem

        For Each record In db.Borrows
            If record.memberID = id AndAlso record.status = "Borrow" Then
                item = lvBorrowList.Items.Add(lvBorrowList.Items.Count + 1)
                item.SubItems.Add(record.ISBN)
                item.SubItems.Add(GetBookName(record.ISBN))
                item.SubItems.Add(record.borrowDate)
            End If
        Next

        For Each stdName In db.Members
            If stdName.memberID = id Then
                txtName.Text = stdName.memberName
                Exit For
            End If
        Next

        If lvBorrowList.Items.Count <= 0 Then
            MessageBox.Show("No record found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetBookName(isbn As String) As String
        For Each book In db.Books
            If book.ISBN = isbn Then
                Return book.bookName
            End If
        Next
        Return "None"
    End Function

    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        btnPaid.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDisplayDateTime.Text = "Current Time:" + vbNewLine + DateTime.Now.ToString("MMMM dd, yyyy   HH:MM:ss")
    End Sub

    Private Sub lvBorrowList_DoubleClick(sender As Object, e As EventArgs) Handles lvBorrowList.DoubleClick
        For Each i As ListViewItem In lvBorrowList.SelectedItems
            lvBorrowList.Items.Remove(i)
        Next
    End Sub

    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Did the overdue charges been cleared?", "Sure mou?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Dim temp As String = finedBooks.ToString()
                Dim fined As String() = temp.Split(vbNewLine)
                Dim finedChanges As Integer = 0
                For Each record In db.Borrows
                    If record.ISBN.Equals(fined(finedChanges).Trim) Then
                        record.status = "Returned"
                        record.returnDate = Date.Now()
                        finedChanges += 1
                    End If
                Next
                db.SubmitChanges()
                btnPaid.Enabled = False
                btnReturn.Enabled = True
                MessageBox.Show("Fined books cleared!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                finedBooks.Clear()
                BtnCheck_Click(Nothing, Nothing)
            Else
                Exit Sub
            End If
            Return
        Catch ex As Exception
            Return
        End Try

    End Sub
End Class