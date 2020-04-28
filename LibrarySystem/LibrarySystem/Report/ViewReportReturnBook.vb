Imports System.Drawing.Printing
Imports System.Text

Public Class ViewReportReturnBook

    Private Sub ViewReportReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        cboYears.Enabled = False
        cboMonths.Enabled = False
        cboDays.Enabled = False
        radPortrait.Checked = True
    End Sub

    Public Function GetLastDayOfMonth(intMonth, intYear) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub cboDays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radYearly.CheckedChanged, radMonthly.CheckedChanged, radDaily.CheckedChanged, cboYears.SelectedIndexChanged, cboMonths.SelectedValueChanged, cboDays.SelectedIndexChanged
        lstView.Items.Clear()
        Try
            Dim Years As Integer = cboYears.SelectedItem
            Dim Months As Integer = cboMonths.SelectedIndex + 1
            Dim Days As Integer = cboDays.SelectedItem

            If radYearly.Checked = True Then
                'Setting
                lstView.Items.Clear()
                cboYears.Enabled = True
                cboMonths.Enabled = False
                cboDays.Enabled = False
                cboMonths.SelectedIndex = -1
                cboDays.SelectedIndex = -1
                'Below code is the Function
                Dim selectedDate As Date = New Date(Years, 1, 1)
                Dim db As New LibraryDataContext()
                For Each row1 In db.Books
                    For Each row2 In db.Borrows
                        Try
                            Dim dbDate As String = CDate(row2.returnDate).ToString("yyyy")
                            If selectedDate.ToString("yyyy") = dbDate Then
                                For Each row3 In db.Users
                                    If row3.UserID = row2.UserID And row1.ISBN = row2.ISBN Then
                                        lstView.Items.Add(row2.returnDate & vbTab & vbTab & row2.UserID & vbTab & vbTab & row1.bookName)
                                        Exit For
                                    End If
                                Next
                            End If
                        Catch ex As Exception
                            Continue For
                        End Try
                    Next
                Next
                lblCount.Text = lstView.Items.Count().ToString("0 record(s)")
            ElseIf radMonthly.Checked = True Then
                'Setting
                lstView.Items.Clear()
                cboYears.Enabled = True
                cboMonths.Enabled = True
                cboDays.Enabled = False
                cboDays.SelectedIndex = -1
                'Below code is the Function
                Dim selectedDate As Date = New DateTime(Years, Months, 1)
                Dim db As New LibraryDataContext()
                For Each row1 In db.Books
                    For Each row2 In db.Borrows
                        Try
                            Dim dbDate As String = CDate(row2.returnDate).ToString("MM/yyyy")
                            If selectedDate.ToString("MM/yyyy") = dbDate Then
                                For Each row3 In db.Users
                                    If row3.UserID = row2.UserID And row1.ISBN = row2.ISBN Then
                                        lstView.Items.Add(row2.returnDate & vbTab & vbTab & row2.UserID & vbTab & vbTab & row1.bookName)
                                        Exit For
                                    End If
                                Next
                            End If
                        Catch ex As Exception
                            Continue For
                        End Try
                    Next
                Next
                lblCount.Text = lstView.Items.Count().ToString("0 record(s)")
            ElseIf radDaily.Checked = True Then
                'Setting
                lstView.Items.Clear()
                cboYears.Enabled = True
                cboMonths.Enabled = True
                cboDays.Enabled = True
                'Below code is the Function
                Dim selectedDate As Date = New DateTime(Years, Months, Days)
                Dim db As New LibraryDataContext()
                For Each row1 In db.Books
                    For Each row2 In db.Borrows
                        Try
                            Dim dbDate As String = CDate(row2.returnDate).ToString("dd/MM/yyyy")
                            If selectedDate.ToString("dd/MM/yyyy") = dbDate Then
                                For Each row3 In db.Users
                                    If row3.UserID = row2.UserID And row1.ISBN = row2.ISBN Then
                                        lstView.Items.Add(row2.returnDate & vbTab & vbTab & row2.UserID & vbTab & vbTab & row1.bookName)
                                        Exit For
                                    End If
                                Next
                            End If
                        Catch ex As Exception
                            Continue For
                        End Try
                    Next
                Next
                lblCount.Text = lstView.Items.Count().ToString("0 record(s)")
            End If

            'This Is the backup restore code for about
            '============================================================================
            'Dim selectedDate As Date = New DateTime(Years, Months, Days)
            'Dim db As New LibraryDataContext()
            'For Each row1 In db.Books
            '    For Each row2 In db.Borrows
            '        Try
            '            Dim dbDate As String = CDate(row2.returnDate).ToString("dd/MM/yyyy")
            '            If selectedDate.ToString("dd/MM/yyyy") = dbDate Then
            '                For Each row3 In db.Members
            '                    If row3.memberID = row2.memberID And row1.ISBN = row2.ISBN Then
            '                        lstView.Items.Add(row2.returnDate & vbTab & vbTab & row2.memberID & vbTab & vbTab & row1.bookName)
            '                        Exit For
            '                    End If
            '                Next
            '            End If
            '        Catch ex As Exception
            '            Continue For
            '        End Try
            '    Next
            'Next
            'lblCount.Text = lstView.Items.Count().ToString("0 record(s)")
            '============================================================================
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        cboDays.Items.Clear()
        Dim Years As Integer = cboYears.SelectedItem
        Dim Months As Integer = cboMonths.SelectedIndex + 1
        Dim days As Integer = GetLastDayOfMonth(Years, Months).Day
        For value As Integer = 1 To days
            cboDays.Items.Add(value)
        Next


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstView.Items.Clear()
        cboYears.Enabled = False
        cboMonths.Enabled = False
        cboDays.Enabled = False
        cboDays.SelectedIndex = -1
        cboMonths.SelectedIndex = -1
        cboYears.SelectedIndex = -1
        radYearly.Checked = False
        radMonthly.Checked = False
        radDaily.Checked = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        '（1）Font
        Dim fntPrint As New Font("Calibri", 12)
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim formLineHeight As Single = fntPrint.GetHeight + 2
        Dim formMarginX As Single = e.MarginBounds.Left
        Dim formMarginY As Single = e.MarginBounds.Top

        '(2) Prepare Header and Sub Header
        Dim header As String = "Return Book Report"
        formMarginY += formLineHeight
        Dim subHeader As String = String.Format(
            "Printed On {0:dd-MMMM-yyyy hh:mm:ss}" & vbNewLine &
            "Prepared by Administrator", DateTime.Now
)
        '(3) Prepare body
        Dim body As New StringBuilder()

        body.AppendLine("No      Return Date          Member ID                 Book Name")
        body.AppendLine("--     -------------     ----------------     ------------------------------")

        Dim cnt As Integer = 0
        Dim parts() As String
        For Each item In lstView.Items
            cnt += 1
            parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,-8} {1,-20} {2,-22} {3,10}" & vbNewLine,
                                cnt, parts(0), parts(2), parts(4))
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        '(4) Print
        With e.Graphics
            .DrawImage(My.Resources.pngguru_com__5_, 240, 20, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 370, 20)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 370, 60)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 130, 140)
        End With
    End Sub

    Private Sub doc_QueryPageSettings(sender As Object, e As QueryPageSettingsEventArgs) Handles doc.QueryPageSettings
        Dim newMargins As System.Drawing.Printing.Margins

        newMargins = New System.Drawing.Printing.Margins(20, 20, 20, 20)

        e.PageSettings.Margins = newMargins

        If radPortrait.Checked = True Then
            e.PageSettings.Landscape = False
        ElseIf radLanscape.Checked = True Then
            e.PageSettings.Landscape = True
        End If

    End Sub

    Private Sub Reset()
        lstView.Items.Clear()
        radDaily.Checked = False
        radMonthly.Checked = False
        radYearly.Checked = False
        cboYears.SelectedIndex = -1
        cboMonths.SelectedIndex = -1
        cboDays.SelectedIndex = -1
    End Sub
End Class