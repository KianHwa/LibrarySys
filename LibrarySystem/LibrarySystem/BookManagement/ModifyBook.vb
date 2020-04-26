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

        ' (3) Validate Borrow details
        If title = "" Then
            err.AppendLine("[Book Title is empty!]")
            ctrl = If(ctrl, txtBookName)
        End If
        If desc = "" Then
            err.AppendLine("[Book Description is empty!]")
            ctrl = If(ctrl, txtBookDesc)
        End If
        If author = "" Then
            err.AppendLine("[Author Name is empty!]")
            ctrl = If(ctrl, txtAuthor)
        End If
        If counter = 0 Then

            err.AppendLine("[Category is empty!]")
            ctrl = If(ctrl, chkHistory)
            ctrl = If(ctrl, chkMystery)
            ctrl = If(ctrl, chkHorror)

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
        If chkHistory.Checked Then
            counter += 1

        End If
        If chkMystery.Checked Then
            counter += 1

        End If
        If chkHorror.Checked Then
            counter += 1

        End If

        b.type = ""

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

        ' Replace the comma at last index to spaces
        Dim lastComma As Integer = b.type.LastIndexOf(",")
        b.type = b.type.Substring(0, lastComma) & " " & b.type.Substring(lastComma + 1)
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

        ' (3) Validate Borrow details
        If title = "" Then
            err.AppendLine("[Book Title is empty!]")
            ctrl = If(ctrl, txtBookName)
        End If
        If desc = "" Then
            err.AppendLine("[Book Description is empty!]")
            ctrl = If(ctrl, txtBookDesc)
        End If
        If author = "" Then
            err.AppendLine("[Author Name is empty!]")
            ctrl = If(ctrl, txtAuthor)
        End If
        If counter = 0 Then
            err.AppendLine("[Category is empty!]")
            ctrl = If(ctrl, chkHistory)
            ctrl = If(ctrl, chkMystery)
            ctrl = If(ctrl, chkHorror)
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

        db.Books.DeleteOnSubmit(b)
        db.SubmitChanges()
        MessageBox.Show("Book with ISBN [" & lblISBN.Text & "] successfully deleted", "Modify Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub ModifyBook_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
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

        If b.type.Contains("Historical fiction") Then
            chkHistory.Checked = True
        End If

        If b.type.Contains("Mystery") Then
            chkMystery.Checked = True
        End If
        If b.type.Contains("Horror") Then
            chkHorror.Checked = True
        End If

    End Sub
    Private Sub ResetForm()
        txtBookName.Select()
        txtAuthor.Text = ""
        txtBookName.Text = ""
        txtBookDesc.Text = ""
        chkHistory.Checked = False
        chkMystery.Checked = False
        chkHorror.Checked = False


    End Sub
End Class