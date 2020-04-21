Public Class formSplash
    Private Sub FormSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Assigning information
        lblTitle.Text = "Library Management System"
        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        lblCopyright.Text = My.Application.Info.Copyright
        lblDevelopers.Text = "A reading a day, keep the teacher away~"

        'Progress bar
        progressBarTimer.Start()

    End Sub

    Private Sub ProgressBarTimer_Tick(sender As Object, e As EventArgs) Handles progressBarTimer.Tick
        pbSplashScreen.Increment(10)
        If pbSplashScreen.Value = 100 Then
            progressBarTimer.Stop()
        End If
    End Sub
End Class