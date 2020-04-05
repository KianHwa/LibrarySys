Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

        lblCopyright.Text = My.Application.Info.Copyright

        lblCompany.Text = My.Application.Info.CompanyName

        lblBuild.Text = "This product was built using : " & vbNewLine & "Microsoft Visual Studio 2019"

        lblDevelopers.Text = "The developers of the Library Management System" & vbNewLine &
                             "- Voo Kee Yuen " & vbNewLine &
                             "- Khoo Teck Wei " & vbNewLine &
                             "- So Kian Hwa " & vbNewLine &
                             "- Tsen Jing Sheng " & vbNewLine &
                             "- Andy Chung Jack Vui " & vbNewLine

        lblDescription.Text = My.Application.Info.Description
    End Sub
End Class