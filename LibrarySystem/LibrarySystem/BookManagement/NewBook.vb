Imports System.Text

Public Class NewBook

    Private Function IsDuplicatedISBN(id As String) As Boolean
        Dim db As New LibraryDataContext()
        Return db.Books.Any(Function(o) o.ISBN = id)

    End Function



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim isbn As String = txtISBN.Text.Trim
        Dim err As New StringBuilder()
        Dim ctrl As Control = Nothing
        Dim title As String = txtBookName.Text.Trim
        Dim desc As String = txtBookDesc.Text.Trim
        Dim author As String = txtAuthor.Text.Trim
        Dim db As New LibraryDataContext()
        ' (3) Validate Borrow details


        If isbn = "" Then
            err.AppendLine("- Book ISBN is empty")
            ctrl = If(ctrl, txtISBN)
        End If
        If title = "" Then
            err.AppendLine("- Book Title is empty")
            ctrl = If(ctrl, txtBookName)
        End If
        If desc = "" Then
            err.AppendLine("- Book Description is empty")
            ctrl = If(ctrl, txtBookDesc)
        End If
        If author = "" Then
            err.AppendLine("- Author Name is empty")
            ctrl = If(ctrl, txtAuthor)
        End If
        ' (4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctrl.Focus()
            Return
        End If

        If CheckBookExistence() = True Then
            'Book existing
            MessageBox.Show("Book with ISBN [" & txtISBN.Text & "] already existing!Please re-enter another Book ISBN.", "Book not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim b As New Book()
            b.ISBN = isbn
            b.bookName = title
            b.bookDesc = desc
            b.author = author
            b.type = cboCategory.SelectedItem

            db.Books.InsertOnSubmit(b)
            db.SubmitChanges()
            MessageBox.Show("Book with ISBN[" & b.ISBN & "] successfully inserted", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetForm()
        End If
    End Sub
    Private Function CheckBookExistence() As Boolean
        'Check if the book is exist in the library
        Dim db As New LibraryDataContext()
        Dim exist As Boolean = False
        For Each book In db.Books
            If book.ISBN = txtISBN.Text Then
                exist = True
            End If
        Next
        Return exist
    End Function



    Private Sub NewBook_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
    End Sub
    Private Sub ResetForm()
        txtISBN.Text = ""
        txtAuthor.Text = ""
        txtBookName.Text = ""
        txtBookDesc.Text = ""
        cboCategory.SelectedIndex = 0
        txtISBN.Focus()

    End Sub
End Class