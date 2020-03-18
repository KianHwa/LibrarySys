Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New LibraryDataContext()

        Dim b As New Book()
        b.bookName = "Little Cat"
        b.bookDesc = "Cat is cute"
        b.author = "Henry"
        b.ISBN = "12-9481093"
        b.type = "Storybook"

        db.Books.InsertOnSubmit(b)
        db.SubmitChanges()


    End Sub
End Class
