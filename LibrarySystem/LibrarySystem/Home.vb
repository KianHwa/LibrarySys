Public Class formHome
    Dim db As New LibraryDataContext()
    Public loggedInID As String = "M1001"
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DarkThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkThemeToolStripMenuItem.Click
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
        tsmiModifyBooks.BackColor = Color.Black
        tsmiRemoveBooks.BackColor = Color.Black
        tsmiSearchBook.BackColor = Color.Black
        tsmiTheme.BackColor = Color.Black
        tsmiUse.BackColor = Color.Black
        tsmiViewProfile.BackColor = Color.Black
        tsmiViewReports.BackColor = Color.Black

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
    End Sub

    Private Sub BtnBookBorrow_Click(sender As Object, e As EventArgs) Handles btnBookBorrow.Click
        BorrowBookv2.ShowDialog()
    End Sub

    Private Sub DefaultThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultThemeToolStripMenuItem.Click
        application.Restart()
    End Sub
End Class