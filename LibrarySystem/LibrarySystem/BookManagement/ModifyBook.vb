Imports System.Text

Public Class ModifyBook

    Public SelectedId As String



    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim db As New LibraryDataContext
        Dim err As New StringBuilder()
        Dim ctrl As Control = Nothing
        Dim title As String = txtBookName.Text.Trim
        Dim desc As String = txtBookDesc.Text.Trim
        Dim author As String = txtAuthor.Text.Trim

        If Me.ValidateChildren() = False Then
            Return
        End If
        Dim b As Book = db.Books.FirstOrDefault(Function(o) o.ISBN = SelectedId)


        ' (3) Validate Borrow details
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

        b.bookName = title
        b.bookDesc = desc
        b.author = author
        b.type = cboCategory.SelectedItem


        db.SubmitChanges()
        MessageBox.Show("Book with ISBN [" & lblISBN.Text & "] successfully modified", "Modify Book", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim db As New LibraryDataContext
        Dim err As New StringBuilder()
        Dim ctrl As Control = Nothing
        Dim title As String = txtBookName.Text.Trim
        Dim desc As String = txtBookDesc.Text.Trim
        Dim author As String = txtAuthor.Text.Trim

        If Me.ValidateChildren() = False Then
            Return
        End If
        Dim b As Book = db.Books.FirstOrDefault(Function(o) o.ISBN = SelectedId)


        ' (3) Validate Borrow details
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

        b.bookName = title
        b.bookDesc = desc
        b.author = author
        b.type = cboCategory.SelectedItem

        db.Books.DeleteOnSubmit(b)
        db.SubmitChanges()
        MessageBox.Show("Book with ISBN [" & lblISBN.Text & "] successfully deleted", "Modify Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub ModifyBook_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim db As New LibraryDataContext
        Dim b As Book = db.Books.FirstOrDefault(Function(o) o.ISBN = SelectedId)
        If b Is Nothing Then
            MessageBox.Show("Book not found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        ' Book found 
        lblISBN.Text = b.ISBN
        txtBookName.Text = b.bookName
        txtBookDesc.Text = b.bookDesc
        txtAuthor.Text = b.author
        cboCategory.SelectedItem = b.type

    End Sub
End Class