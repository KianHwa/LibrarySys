Public Class SearchBook
    Dim rowIndex As Integer = 0
    Private Sub BindData()
        Dim title As String = txtBookName.Text
        Dim history As String = ""
        Dim mystery As String = ""
        Dim horror As String = ""

        Dim isbn As String = If(mskISBN.MaskCompleted, mskISBN.Text, "")
        Dim db As New LibraryDataContext()

        If chkHistory.Checked Then
            history = chkHistory.Text
        End If
        If chkMystery.Checked Then
            mystery = chkMystery.Text

        End If
        If chkHorror.Checked Then
            horror = chkHorror.Text

        End If
        Dim rs = From b In db.Books
                 Where b.bookName.Contains(title) And b.ISBN.Contains(isbn) And ((b.type.Contains(history) And b.type.Contains(mystery) And b.type.Contains(horror)))




        dgv.DataSource = rs

        lblCount.Text = rs.Count().ToString("0 book(s)")
    End Sub
    Private Sub SearchBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LibraryDataSet.Book)
        Dim db As New LibraryDataContext()
        Dim rs = From b In db.Books



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

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        BindData()
    End Sub







    Private Sub chkHistory_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistory.CheckedChanged, chkMystery.CheckedChanged, chkHorror.CheckedChanged
        BindData()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtISBN.Text = ""
        txtBookName.Text = ""
        chkHistory.Checked = False
        chkMystery.Checked = False
        chkHorror.Checked = False
        txtBookName.Focus()
    End Sub

    Private Sub mskISBN_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskISBN.MaskInputRejected
        BindData()
    End Sub
End Class