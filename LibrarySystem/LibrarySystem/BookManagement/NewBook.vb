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
        Dim history As String = ""
        Dim mystery As String = ""
        Dim horror As String = ""

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
            Dim count As Integer = 0
            b.ISBN = isbn
            b.bookName = title
            b.bookDesc = desc
            b.author = author
            Dim counter As Integer = 0

            If chkHistory.Checked Then
                counter += 1

            End If
            If chkMystery.Checked Then
                counter += 1

            End If
            If chkHorror.Checked Then
                counter += 1

            End If



            If chkHistory.Checked Then
                If counter > 1 Then
                    b.type += chkHistory.Text + ","

                Else
                    b.type += chkHistory.Text
                End If
            End If

            If chkMystery.Checked Then
                If counter > 1 Then
                    b.type += chkMystery.Text + ","

                Else
                    b.type += chkMystery.Text
                End If
            End If

            If chkHorror.Checked Then
                If counter > 1 Then
                    b.type += chkHorror.Text + ","

                Else
                    b.type += chkHorror.Text
                End If
            End If

            If counter > 1 Then
                Dim lastComma As Integer = b.type.LastIndexOf(",")
                b.type = b.type.Substring(0, lastComma) & " " & b.type.Substring(lastComma + 1)
            End If

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
        chkHistory.Checked = False
        chkMystery.Checked = False
        chkHorror.Checked = False
        txtISBN.Focus()

    End Sub

End Class