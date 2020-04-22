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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBookManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSearchBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGenerateReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDefaultTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDarkTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUse = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAddNewBook = New System.Windows.Forms.Button()
        Me.btnBookReturn = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnBookBorrow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDIsplayDateTime = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUser, Me.menuBookManagement, Me.menuReports, Me.menuSetting, Me.menuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1155, 41)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuUser
        '
        Me.menuUser.BackColor = System.Drawing.Color.Transparent
        Me.menuUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiViewProfile, Me.tsmiChangePassword})
        Me.menuUser.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuUser.ForeColor = System.Drawing.Color.White
        Me.menuUser.Name = "menuUser"
        Me.menuUser.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.menuUser.Size = New System.Drawing.Size(83, 39)
        Me.menuUser.Text = "&User"
        '
        'tsmiViewProfile
        '
        Me.tsmiViewProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiViewProfile.ForeColor = System.Drawing.Color.White
        Me.tsmiViewProfile.Name = "tsmiViewProfile"
        Me.tsmiViewProfile.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiViewProfile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmiViewProfile.Size = New System.Drawing.Size(276, 32)
        Me.tsmiViewProfile.Text = "View Profile"
        Me.tsmiViewProfile.ToolTipText = "View your profile details"
        '
        'tsmiChangePassword
        '
        Me.tsmiChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiChangePassword.ForeColor = System.Drawing.Color.White
        Me.tsmiChangePassword.Name = "tsmiChangePassword"
        Me.tsmiChangePassword.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiChangePassword.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmiChangePassword.Size = New System.Drawing.Size(276, 32)
        Me.tsmiChangePassword.Text = "Change Password"
        Me.tsmiChangePassword.ToolTipText = "Change your passwords"
        '
        'menuBookManagement
        '
        Me.menuBookManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAddBooks, Me.tsmiSearchBook})
        Me.menuBookManagement.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBookManagement.ForeColor = System.Drawing.Color.White
        Me.menuBookManagement.Name = "menuBookManagement"
        Me.menuBookManagement.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.menuBookManagement.Size = New System.Drawing.Size(132, 39)
        Me.menuBookManagement.Text = "Book &Management"
        '
        'tsmiAddBooks
        '
        Me.tsmiAddBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiAddBooks.ForeColor = System.Drawing.Color.White
        Me.tsmiAddBooks.Name = "tsmiAddBooks"
        Me.tsmiAddBooks.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiAddBooks.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsmiAddBooks.Size = New System.Drawing.Size(204, 32)
        Me.tsmiAddBooks.Text = "Add New Books"
        Me.tsmiAddBooks.ToolTipText = "Add new books to the library"
        '
        'tsmiSearchBook
        '
        Me.tsmiSearchBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiSearchBook.ForeColor = System.Drawing.Color.White
        Me.tsmiSearchBook.Name = "tsmiSearchBook"
        Me.tsmiSearchBook.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmiSearchBook.Size = New System.Drawing.Size(204, 24)
        Me.tsmiSearchBook.Text = "Search Books"
        '
        'menuReports
        '
        Me.menuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGenerateReports})
        Me.menuReports.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuReports.ForeColor = System.Drawing.Color.White
        Me.menuReports.Name = "menuReports"
        Me.menuReports.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.menuReports.Size = New System.Drawing.Size(96, 39)
        Me.menuReports.Text = "&Report"
        '
        'tsmiGenerateReports
        '
        Me.tsmiGenerateReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiGenerateReports.ForeColor = System.Drawing.Color.White
        Me.tsmiGenerateReports.Name = "tsmiGenerateReports"
        Me.tsmiGenerateReports.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiGenerateReports.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tsmiGenerateReports.Size = New System.Drawing.Size(278, 32)
        Me.tsmiGenerateReports.Text = "Generate Reports"
        Me.tsmiGenerateReports.ToolTipText = "Generate reports"
        '
        'menuSetting
        '
        Me.menuSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTheme})
        Me.menuSetting.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuSetting.ForeColor = System.Drawing.Color.White
        Me.menuSetting.Name = "menuSetting"
        Me.menuSetting.Size = New System.Drawing.Size(65, 39)
        Me.menuSetting.Text = "&Setting"
        '
        'tsmiTheme
        '
        Me.tsmiTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiTheme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDefaultTheme, Me.tsmiDarkTheme})
        Me.tsmiTheme.ForeColor = System.Drawing.Color.White
        Me.tsmiTheme.Name = "tsmiTheme"
        Me.tsmiTheme.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiTheme.Size = New System.Drawing.Size(122, 32)
        Me.tsmiTheme.Text = "Theme"
        '
        'tsmiDefaultTheme
        '
        Me.tsmiDefaultTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiDefaultTheme.ForeColor = System.Drawing.Color.White
        Me.tsmiDefaultTheme.Name = "tsmiDefaultTheme"
        Me.tsmiDefaultTheme.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiDefaultTheme.Size = New System.Drawing.Size(172, 32)
        Me.tsmiDefaultTheme.Text = "Default Theme"
        '
        'tsmiDarkTheme
        '
        Me.tsmiDarkTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiDarkTheme.ForeColor = System.Drawing.Color.White
        Me.tsmiDarkTheme.Name = "tsmiDarkTheme"
        Me.tsmiDarkTheme.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiDarkTheme.Size = New System.Drawing.Size(172, 32)
        Me.tsmiDarkTheme.Text = "Dark Theme"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAbout, Me.tsmiUse})
        Me.menuHelp.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuHelp.ForeColor = System.Drawing.Color.White
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.menuHelp.Size = New System.Drawing.Size(82, 39)
        Me.menuHelp.Text = "&Help"
        '
        'tsmiAbout
        '
        Me.tsmiAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiAbout.ForeColor = System.Drawing.Color.White
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiAbout.Size = New System.Drawing.Size(150, 32)
        Me.tsmiAbout.Text = "About"
        Me.tsmiAbout.ToolTipText = "Know more about us"
        '
        'tsmiUse
        '
        Me.tsmiUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tsmiUse.ForeColor = System.Drawing.Color.White
        Me.tsmiUse.Name = "tsmiUse"
        Me.tsmiUse.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.tsmiUse.Size = New System.Drawing.Size(150, 32)
        Me.tsmiUse.Text = "How to use"
        Me.tsmiUse.ToolTipText = "Guide on how to use the system"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblDIsplayDateTime)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnAddNewBook)
        Me.Panel1.Controls.Add(Me.btnBookReturn)
        Me.Panel1.Controls.Add(Me.btnSearchBook)
        Me.Panel1.Controls.Add(Me.btnBookBorrow)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 812)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.pngguru_com__5_
        Me.PictureBox1.Location = New System.Drawing.Point(72, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 469)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(267, 65)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log &out"
        Me.ToolTip1.SetToolTip(Me.btnLogout, "Log out from session")
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAddNewBook
        '
        Me.btnAddNewBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAddNewBook.FlatAppearance.BorderSize = 0
        Me.btnAddNewBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewBook.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBook.ForeColor = System.Drawing.Color.White
        Me.btnAddNewBook.Location = New System.Drawing.Point(0, 404)
        Me.btnAddNewBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNewBook.Name = "btnAddNewBook"
        Me.btnAddNewBook.Size = New System.Drawing.Size(267, 65)
        Me.btnAddNewBook.TabIndex = 4
        Me.btnAddNewBook.Text = "&Add Book"
        Me.ToolTip1.SetToolTip(Me.btnAddNewBook, "Add new book")
        Me.btnAddNewBook.UseVisualStyleBackColor = False
        '
        'btnBookReturn
        '
        Me.btnBookReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBookReturn.FlatAppearance.BorderSize = 0
        Me.btnBookReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBookReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookReturn.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookReturn.ForeColor = System.Drawing.Color.White
        Me.btnBookReturn.Location = New System.Drawing.Point(0, 274)
        Me.btnBookReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBookReturn.Name = "btnBookReturn"
        Me.btnBookReturn.Size = New System.Drawing.Size(267, 65)
        Me.btnBookReturn.TabIndex = 3
        Me.btnBookReturn.Text = "Book &Return"
        Me.ToolTip1.SetToolTip(Me.btnBookReturn, "Return books")
        Me.btnBookReturn.UseVisualStyleBackColor = False
        '
        'btnSearchBook
        '
        Me.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSearchBook.FlatAppearance.BorderSize = 0
        Me.btnSearchBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBook.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.ForeColor = System.Drawing.Color.White
        Me.btnSearchBook.Location = New System.Drawing.Point(0, 339)
        Me.btnSearchBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(267, 65)
        Me.btnSearchBook.TabIndex = 2
        Me.btnSearchBook.Text = "&Search Book"
        Me.ToolTip1.SetToolTip(Me.btnSearchBook, "Search for books")
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'btnBookBorrow
        '
        Me.btnBookBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBookBorrow.FlatAppearance.BorderSize = 0
        Me.btnBookBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBookBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnBookBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookBorrow.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookBorrow.ForeColor = System.Drawing.Color.White
        Me.btnBookBorrow.Location = New System.Drawing.Point(0, 209)
        Me.btnBookBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBookBorrow.Name = "btnBookBorrow"
        Me.btnBookBorrow.Size = New System.Drawing.Size(267, 65)
        Me.btnBookBorrow.TabIndex = 1
        Me.btnBookBorrow.Text = "Book &Borrow"
        Me.ToolTip1.SetToolTip(Me.btnBookBorrow, "Borrow books")
        Me.btnBookBorrow.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(838, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 232)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Library Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'lblDIsplayDateTime
        '
        Me.lblDIsplayDateTime.AutoSize = True
        Me.lblDIsplayDateTime.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDIsplayDateTime.Location = New System.Drawing.Point(46, 624)
        Me.lblDIsplayDateTime.Name = "lblDIsplayDateTime"
        Me.lblDIsplayDateTime.Size = New System.Drawing.Size(107, 20)
        Me.lblDIsplayDateTime.TabIndex = 3
        Me.lblDIsplayDateTime.Text = "Date and Time"
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.bg11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1155, 687)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(814, 592)
        Me.Name = "formHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuUser As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBookBorrow As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAddNewBook As Button
    Friend WithEvents btnBookReturn As Button
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents menuBookManagement As ToolStripMenuItem
    Friend WithEvents menuReports As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsmiViewProfile As ToolStripMenuItem
    Friend WithEvents tsmiChangePassword As ToolStripMenuItem
    Friend WithEvents tsmiAddBooks As ToolStripMenuItem
    Friend WithEvents tsmiGenerateReports As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiUse As ToolStripMenuItem
    Friend WithEvents menuSetting As ToolStripMenuItem
    Friend WithEvents tsmiTheme As ToolStripMenuItem
    Friend WithEvents tsmiDefaultTheme As ToolStripMenuItem
    Friend WithEvents tsmiDarkTheme As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tsmiSearchBook As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDIsplayDateTime As Label
End Class