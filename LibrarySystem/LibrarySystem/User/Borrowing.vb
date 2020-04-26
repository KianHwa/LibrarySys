Public Class FrmBorrowing
    Private Sub BindData()
        Dim db As New LibraryDataContext()

        Dim rs = From c In db.Users
        dgvBorrowing.DataSource = rs
        lblCount.Text = rs.Count().ToString("0 record(s)")

    End Sub

    Private Sub FrmBorrowing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class