Public Class ProcessRequest
    Dim db As New LibraryDataContext()
    Private Sub BindData()

        Dim rs = From c In db.Users Where c.Request = "Requesting" Select c.UserID, c.Name, c.Request
        dgvRequest.DataSource = rs
        lblCount.Text = rs.Count().ToString("0 request(s)")
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub ProcessRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub dgvRequest_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequest.CellDoubleClick

        Dim i As String = dgvRequest.CurrentCell.RowIndex
        Dim r As String = dgvRequest.SelectedRows(i).Cells(0).Value.ToString
        Dim confirm As MsgBoxResult
        confirm = MsgBox("Confirm to proceed ?", MsgBoxStyle.YesNo, "Confirmation")
        If confirm = MsgBoxResult.Yes Then
            For Each u In db.Users
                If u.UserID = r Then
                    u.Request = "Requested"
                    u.Status = "Librarian"
                End If
            Next
        End If
        db.SubmitChanges()
        MessageBox.Show("Application Approved", "Approved")
        BindData()
    End Sub
End Class