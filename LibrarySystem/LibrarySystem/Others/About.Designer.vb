<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblDevelopers = New System.Windows.Forms.Label()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(167, 101)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(381, 43)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "Versions"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Hobo Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(164, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(594, 69)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Library Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.pngguru_com__5_
        Me.PictureBox1.Location = New System.Drawing.Point(43, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(24, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 349)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblDescription)
        Me.Panel2.Controls.Add(Me.lblCompany)
        Me.Panel2.Controls.Add(Me.lblDevelopers)
        Me.Panel2.Controls.Add(Me.lblBuild)
        Me.Panel2.Controls.Add(Me.lblCopyright)
        Me.Panel2.Location = New System.Drawing.Point(40, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 525)
        Me.Panel2.TabIndex = 0
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(45, 380)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(381, 43)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(45, 96)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(513, 43)
        Me.lblCompany.TabIndex = 7
        Me.lblCompany.Text = "Company"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDevelopers
        '
        Me.lblDevelopers.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevelopers.Location = New System.Drawing.Point(45, 225)
        Me.lblDevelopers.Name = "lblDevelopers"
        Me.lblDevelopers.Size = New System.Drawing.Size(513, 134)
        Me.lblDevelopers.TabIndex = 6
        Me.lblDevelopers.Text = "Developers"
        '
        'lblBuild
        '
        Me.lblBuild.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuild.Location = New System.Drawing.Point(45, 163)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(513, 62)
        Me.lblBuild.TabIndex = 5
        Me.lblBuild.Text = "How it built"
        '
        'lblCopyright
        '
        Me.lblCopyright.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(45, 36)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(513, 43)
        Me.lblCopyright.TabIndex = 5
        Me.lblCopyright.Text = "Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "About"
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblDevelopers As Label
    Friend WithEvents lblBuild As Label
    Friend WithEvents lblCopyright As Label
End Class
