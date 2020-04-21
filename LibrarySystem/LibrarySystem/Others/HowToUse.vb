Public Class HowToUse
    Dim listPanel As List(Of Panel) = New List(Of Panel)()
    Dim index As Integer

    Private Sub HowToUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        index = 0
        ' Add panels to list
        listPanel.Add(panelHome)
        listPanel.Add(panelBorrow)
        listPanel(index).BringToFront()

        ' Load Home Details
        lblHomeDetails.Text = "This is the home page after you logged into the library system." & vbNewLine &
                              "On the top of the form with menu strip with the following items : " & vbNewLine & vbNewLine &
                              "<< User >> " & vbNewLine &
                              "- View Profile : Allow user to view their personal profile and view the books borrowed and returned, and view the fine they have" & vbNewLine &
                              "- Change Password : User may allow to change their passwords that used to log in into their account" & vbNewLine &
                              "<< Book Management >> " & vbNewLine &
                              "- Add New Books : Allow the librarian to add new book's information whenever there's new book added into the library" & vbNewLine &
                              "- Search Books : Member and librarian can search for the particular book " & vbNewLine &
                              "- Modify Books : Allow the librarian to update the latest book information" & vbNewLine &
                              "- Remove Books : Allow the librarian to remove certain books information from the system" & vbNewLine &
                              "<< View reports >>" & vbNewLine &
                              "- View the reports generated previously" & vbNewLine &
                              "- Generate new reports " & vbNewLine &
                              "<< Setting >>" & vbNewLine &
                              "- Theme : Allow the users to change the system theme to dark theme or default theme (Blue)" & vbNewLine &
                              "<< Help >>" & vbNewLine &
                              "- About : Assembly informations" & vbNewLine &
                              "- How to use : Provide user a manual guide on how to use the system" & vbNewLine & vbNewLine &
                              "On the left side of the window, there's five buttons allow the user to quick access to certain action" & vbNewLine &
                              "- Book Borrow : To borrow books " & vbNewLine &
                              "- Book Return : To return the books borrowed, fine will be added if there's any late return" & vbNewLine &
                              "- Search Book : To search for particular book information in the library" & vbNewLine &
                              "- Add Book : To add new book information into the system" & vbNewLine &
                              "- Log out : To logout from the system" & vbNewLine & vbNewLine

        ' Load Borrow Details
        lblBorrowDetails.Text = "When you wanted to borrow book, here is the form you must fill in the book details" & vbNewLine &
                                "Procedures" & vbNewLine &
                                "==========" & vbNewLine &
                                "(1) Enter the book details you want to borrow (ISBN found on the cover page of the book)" & vbNewLine &
                                "(2) Borrow date will be set on the day you borrow." & vbNewLine &
                                "(3) Due date is the day you must return your borrowed book, or else fine will be charge upon you" & vbNewLine &
                                "(4) After that, click BORROW button to add the book into your borrow list" & vbNewLine &
                                "(5) The table shows the borrow list of yours, you can double check the book you want to borrow" & vbNewLine &
                                "(6) You can only borrow the maximum number of five books, and only allowed to borrow again after you return the borrowed books" & vbNewLine &
                                "(7) You may remove the book added into the borrow list by select the book in the list and click REMOVE button or simply double click on it" & vbNewLine &
                                "(8) Click CONFIRM button to borrow the books" & vbNewLine



    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index > 0 Then
            index -= 1
            listPanel(index).BringToFront()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < listPanel.Count - 1 Then
            index += 1
            listPanel(index).BringToFront()
        End If
    End Sub
End Class