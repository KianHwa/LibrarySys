<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnAddNewBook = New System.Windows.Forms.Button()
        Me.btnBookReturn = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnBookBorrow = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.BookManagementToolStripMenuItem, Me.ReportToolStripMenuItem, Me.SettingToolStripMenuItem, Me.GelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 50)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Hobo Std", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(90, 48)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'BookManagementToolStripMenuItem
        '
        Me.BookManagementToolStripMenuItem.Font = New System.Drawing.Font("Hobo Std", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BookManagementToolStripMenuItem.Name = "BookManagementToolStripMenuItem"
        Me.BookManagementToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.BookManagementToolStripMenuItem.Size = New System.Drawing.Size(195, 48)
        Me.BookManagementToolStripMenuItem.Text = "Book Management"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Hobo Std", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(106, 48)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Font = New System.Drawing.Font("Hobo Std", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(109, 48)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'GelpToolStripMenuItem
        '
        Me.GelpToolStripMenuItem.Font = New System.Drawing.Font("Hobo Std", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GelpToolStripMenuItem.Name = "GelpToolStripMenuItem"
        Me.GelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.GelpToolStripMenuItem.Size = New System.Drawing.Size(88, 48)
        Me.GelpToolStripMenuItem.Text = "Help"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnAddNewBook)
        Me.Panel1.Controls.Add(Me.btnBookReturn)
        Me.Panel1.Controls.Add(Me.btnSearchBook)
        Me.Panel1.Controls.Add(Me.btnBookBorrow)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 1001)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.pngguru_com__5_
        Me.PictureBox1.Location = New System.Drawing.Point(96, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Hobo Std", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 577)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(353, 80)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Log out"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnAddNewBook
        '
        Me.btnAddNewBook.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNewBook.FlatAppearance.BorderSize = 0
        Me.btnAddNewBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewBook.Font = New System.Drawing.Font("Hobo Std", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBook.ForeColor = System.Drawing.Color.White
        Me.btnAddNewBook.Location = New System.Drawing.Point(0, 497)
        Me.btnAddNewBook.Name = "btnAddNewBook"
        Me.btnAddNewBook.Size = New System.Drawing.Size(353, 80)
        Me.btnAddNewBook.TabIndex = 3
        Me.btnAddNewBook.Text = "Add Book"
        Me.btnAddNewBook.UseVisualStyleBackColor = False
        '
        'btnBookReturn
        '
        Me.btnBookReturn.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookReturn.FlatAppearance.BorderSize = 0
        Me.btnBookReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBookReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookReturn.Font = New System.Drawing.Font("Hobo Std", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookReturn.ForeColor = System.Drawing.Color.White
        Me.btnBookReturn.Location = New System.Drawing.Point(3, 417)
        Me.btnBookReturn.Name = "btnBookReturn"
        Me.btnBookReturn.Size = New System.Drawing.Size(350, 80)
        Me.btnBookReturn.TabIndex = 2
        Me.btnBookReturn.Text = "Book Return"
        Me.btnBookReturn.UseVisualStyleBackColor = False
        '
        'btnSearchBook
        '
        Me.btnSearchBook.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearchBook.FlatAppearance.BorderSize = 0
        Me.btnSearchBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBook.Font = New System.Drawing.Font("Hobo Std", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.ForeColor = System.Drawing.Color.White
        Me.btnSearchBook.Location = New System.Drawing.Point(0, 337)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(353, 80)
        Me.btnSearchBook.TabIndex = 1
        Me.btnSearchBook.Text = "Search Book"
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'btnBookBorrow
        '
        Me.btnBookBorrow.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBookBorrow.FlatAppearance.BorderSize = 0
        Me.btnBookBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBookBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBookBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookBorrow.Font = New System.Drawing.Font("Hobo Std", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookBorrow.ForeColor = System.Drawing.Color.White
        Me.btnBookBorrow.Location = New System.Drawing.Point(3, 257)
        Me.btnBookBorrow.Name = "btnBookBorrow"
        Me.btnBookBorrow.Size = New System.Drawing.Size(350, 80)
        Me.btnBookBorrow.TabIndex = 0
        Me.btnBookBorrow.Text = "Book Borrow"
        Me.btnBookBorrow.UseVisualStyleBackColor = False
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibrarySystem.My.Resources.Resources._0zuld2__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "formHome"
        Me.Text = "Library Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBookBorrow As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnAddNewBook As Button
    Friend WithEvents btnBookReturn As Button
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents BookManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
