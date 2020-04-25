Public Class formHome
    Dim db As New LibraryDataContext()
    Public loggedInID As String = ""
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub DarkThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiDarkTheme.Click
        'Home form
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
            End If

            If TypeOf ctrl Is MenuStrip Then
                Dim ms = DirectCast(ctrl, MenuStrip)

                ms.BackColor = Color.Black
            End If
        Next

        For Each ctrl In Panel1.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = Color.Gray
                btn.FlatAppearance.MouseDownBackColor = Color.LightGray
            End If
        Next

        Panel1.BackColor = Color.Black
        tsmiAbout.BackColor = Color.Black
        tsmiAddBooks.BackColor = Color.Black
        tsmiChangePassword.BackColor = Color.Black
        tsmiGenerateReports.BackColor = Color.Black

        tsmiSearchBook.BackColor = Color.Black
        tsmiTheme.BackColor = Color.Black
        tsmiUse.BackColor = Color.Black
        tsmiViewProfile.BackColor = Color.Black
        tsmiDefaultTheme.BackColor = Color.Black
        tsmiDarkTheme.BackColor = Color.Black

        '=====================================================================================
        'Borrow book form
        BorrowBookv2.BackColor = Color.DimGray
        For Each ctrl In BorrowBookv2.GroupBox1.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 22)
            End If
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = Color.White
            End If
        Next

        For Each ctrl In BorrowBookv2.GroupBox3.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
            End If


        Next
        '=====================================================================================
        'NewBook form
        NewBook.BackColor = Color.DimGray
        For Each ctrl In NewBook.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 22)
            End If
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = Color.White
            End If
        Next
        '=====================================================================================
        'ModifyBook form
        ModifyBook.BackColor = Color.DimGray
        For Each ctrl In ModifyBook.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 22)
            End If
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = Color.White
            End If
        Next
        '=====================================================================================
        'SearchBook form
        SearchBook.BackColor = Color.DimGray
        For Each ctrl In SearchBook.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 22)
            End If
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = Color.White
            End If
        Next
        '=====================================================================================
        'ReturnBook form
        ReturnBook.BackColor = Color.DimGray
        For Each ctrl In ReturnBook.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)

                btn.BackColor = Color.Black
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 22, 22)
            End If
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = Color.White
            End If
            If TypeOf ctrl Is ListView Then
                Dim lst = DirectCast(ctrl, ListView)
                lst.BackColor = Color.DarkGray
            End If
        Next
    End Sub

    Private Sub BtnBookBorrow_Click(sender As Object, e As EventArgs) Handles btnBookBorrow.Click
        BorrowBookv2.ShowDialog()
    End Sub

    Private Sub DefaultThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiDefaultTheme.Click
        Application.Restart()
    End Sub

    Private Sub TsmiAbout_Click(sender As Object, e As EventArgs) Handles tsmiAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub TsmiUse_Click(sender As Object, e As EventArgs) Handles tsmiUse.Click
        HowToUse.ShowDialog()
    End Sub

    Private Sub tsmiAddBooks_Click(sender As Object, e As EventArgs) Handles tsmiAddBooks.Click
        NewBook.ShowDialog()
    End Sub

    Private Sub SearchBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiSearchBook.Click
        SearchBook.ShowDialog()
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        SearchBook.ShowDialog()
    End Sub

    Private Sub btnAddNewBook_Click(sender As Object, e As EventArgs) Handles btnAddNewBook.Click
        NewBook.ShowDialog()
    End Sub

    Private Sub tsmiGenerateReports_Click(sender As Object, e As EventArgs) Handles tsmiGenerateReports.Click
        GenerateReport.ShowDialog()
    End Sub

    Private Sub btnBookReturn_Click(sender As Object, e As EventArgs) Handles btnBookReturn.Click
        ReturnBook.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDIsplayDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy   HH:MM:ss")
    End Sub

    Private Sub tsmiViewProfile_Click(sender As Object, e As EventArgs) Handles tsmiViewProfile.Click
        UserProfile.Show()
    End Sub

    Private Sub BorrowingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowingToolStripMenuItem.Click
        FrmBorrowing.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        BorrowHistory.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Restart()
    End Sub

    Private Sub RegisterLibrarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiRegisterLibrarian.Click
        LibrarianRegis.Show()
    End Sub
End Class