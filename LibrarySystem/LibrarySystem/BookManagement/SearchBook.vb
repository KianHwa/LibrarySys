Public Class SearchBook

    Private Sub BindData()
        Dim title As String = txtBookName.Text
        Dim category As String = cboCategory.Text
        Dim isbn As String = txtISBN.Text
        Dim db As New LibraryDataContext()
        Dim rs = From b In db.Books
                 Where b.bookName.Contains(title) And b.ISBN.Contains(isbn) And (category = "All" Or b.type.StartsWith(category))


        dgv.DataSource = rs

        lblCount.Text = rs.Count().ToString("0 book(s)")
    End Sub
    Private Sub SearchBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LibraryDataSet.Book)
        Dim db As New LibraryDataContext()
        Dim rs = From b In db.Books


        cboCategory.SelectedIndex = 0
        BindData()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        NewBook.ShowDialog()
        BindData()
    End Sub



    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            ModifyBook.SelectedId = id
            ModifyBook.ShowDialog(Me)
            BindData()
        End If
    End Sub



    Private Sub txtBookName_TextChanged(sender As Object, e As EventArgs) Handles txtBookName.TextChanged
        BindData()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        BindData()
    End Sub


End Class