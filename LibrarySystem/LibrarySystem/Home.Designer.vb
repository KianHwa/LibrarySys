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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAddNewBook = New System.Windows.Forms.Button()
        Me.btnBookReturn = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnBookBorrow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontAndStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.UserToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(92, 48)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'BookManagementToolStripMenuItem
        '
        Me.BookManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBooksToolStripMenuItem, Me.SearchBooksToolStripMenuItem, Me.ModifyBooksToolStripMenuItem, Me.RemoveBooksToolStripMenuItem})
        Me.BookManagementToolStripMenuItem.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BookManagementToolStripMenuItem.Name = "BookManagementToolStripMenuItem"
        Me.BookManagementToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BookManagementToolStripMenuItem.Size = New System.Drawing.Size(165, 48)
        Me.BookManagementToolStripMenuItem.Text = "Book &Management"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReportsToolStripMenuItem, Me.GenerateReportsToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(108, 48)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontAndStyleToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.SettingToolStripMenuItem.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(110, 48)
        Me.SettingToolStripMenuItem.Text = "&Setting"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 577)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(353, 80)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log &out"
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
        Me.btnAddNewBook.Location = New System.Drawing.Point(0, 497)
        Me.btnAddNewBook.Name = "btnAddNewBook"
        Me.btnAddNewBook.Size = New System.Drawing.Size(353, 80)
        Me.btnAddNewBook.TabIndex = 4
        Me.btnAddNewBook.Text = "&Add Book"
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
        Me.btnBookReturn.Location = New System.Drawing.Point(0, 331)
        Me.btnBookReturn.Name = "btnBookReturn"
        Me.btnBookReturn.Size = New System.Drawing.Size(350, 80)
        Me.btnBookReturn.TabIndex = 3
        Me.btnBookReturn.Text = "Book &Return"
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
        Me.btnSearchBook.Location = New System.Drawing.Point(0, 417)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(353, 80)
        Me.btnSearchBook.TabIndex = 2
        Me.btnSearchBook.Text = "&Search Book"
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
        Me.btnBookBorrow.Location = New System.Drawing.Point(3, 257)
        Me.btnBookBorrow.Name = "btnBookBorrow"
        Me.btnBookBorrow.Size = New System.Drawing.Size(350, 80)
        Me.btnBookBorrow.TabIndex = 1
        Me.btnBookBorrow.Text = "Book &Borrow"
        Me.btnBookBorrow.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Hobo Std", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1118, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 286)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Library Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewProfileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ViewProfileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(352, 36)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ChangePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ChangePasswordToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(352, 36)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'AddNewBooksToolStripMenuItem
        '
        Me.AddNewBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddNewBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddNewBooksToolStripMenuItem.Name = "AddNewBooksToolStripMenuItem"
        Me.AddNewBooksToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.AddNewBooksToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AddNewBooksToolStripMenuItem.Size = New System.Drawing.Size(257, 36)
        Me.AddNewBooksToolStripMenuItem.Text = "Add New Books"
        '
        'SearchBooksToolStripMenuItem
        '
        Me.SearchBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.SearchBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchBooksToolStripMenuItem.Name = "SearchBooksToolStripMenuItem"
        Me.SearchBooksToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.SearchBooksToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.SearchBooksToolStripMenuItem.Size = New System.Drawing.Size(257, 36)
        Me.SearchBooksToolStripMenuItem.Text = "Search Books"
        '
        'ModifyBooksToolStripMenuItem
        '
        Me.ModifyBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ModifyBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ModifyBooksToolStripMenuItem.Name = "ModifyBooksToolStripMenuItem"
        Me.ModifyBooksToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ModifyBooksToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ModifyBooksToolStripMenuItem.Size = New System.Drawing.Size(257, 36)
        Me.ModifyBooksToolStripMenuItem.Text = "Modify Books"
        '
        'RemoveBooksToolStripMenuItem
        '
        Me.RemoveBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.RemoveBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RemoveBooksToolStripMenuItem.Name = "RemoveBooksToolStripMenuItem"
        Me.RemoveBooksToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.RemoveBooksToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.RemoveBooksToolStripMenuItem.Size = New System.Drawing.Size(257, 36)
        Me.RemoveBooksToolStripMenuItem.Text = "Remove Books"
        '
        'ViewReportsToolStripMenuItem
        '
        Me.ViewReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewReportsToolStripMenuItem.Name = "ViewReportsToolStripMenuItem"
        Me.ViewReportsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ViewReportsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewReportsToolStripMenuItem.Size = New System.Drawing.Size(349, 36)
        Me.ViewReportsToolStripMenuItem.Text = "View Reports"
        '
        'GenerateReportsToolStripMenuItem
        '
        Me.GenerateReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GenerateReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GenerateReportsToolStripMenuItem.Name = "GenerateReportsToolStripMenuItem"
        Me.GenerateReportsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.GenerateReportsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GenerateReportsToolStripMenuItem.Size = New System.Drawing.Size(349, 36)
        Me.GenerateReportsToolStripMenuItem.Text = "Generate Reports"
        '
        'FontAndStyleToolStripMenuItem
        '
        Me.FontAndStyleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.FontAndStyleToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FontAndStyleToolStripMenuItem.Name = "FontAndStyleToolStripMenuItem"
        Me.FontAndStyleToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.FontAndStyleToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.FontAndStyleToolStripMenuItem.Text = "Font and Style"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ThemeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 36)
        Me.ToolStripMenuItem2.Text = "How to use"
        '
        'GelpToolStripMenuItem
        '
        Me.GelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.GelpToolStripMenuItem.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GelpToolStripMenuItem.Name = "GelpToolStripMenuItem"
        Me.GelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.GelpToolStripMenuItem.Size = New System.Drawing.Size(91, 48)
        Me.GelpToolStripMenuItem.Text = "&Help"
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.bg11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
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
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAddNewBook As Button
    Friend WithEvents btnBookReturn As Button
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents BookManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ViewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontAndStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class