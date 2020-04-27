<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.mskId = New System.Windows.Forms.MaskedTextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLibrarian = New System.Windows.Forms.Button()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogLibrarian = New System.Windows.Forms.Button()
        Me.btnLogAdmin = New System.Windows.Forms.Button()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(209, 172)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(138, 22)
        Me.txtPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(204, 234)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(92, 34)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'mskId
        '
        Me.mskId.Location = New System.Drawing.Point(234, 126)
        Me.mskId.Mask = "00000"
        Me.mskId.Name = "mskId"
        Me.mskId.Size = New System.Drawing.Size(113, 22)
        Me.mskId.TabIndex = 0
        '
        'btnRegister
        '
        Me.btnRegister.CausesValidation = False
        Me.btnRegister.Location = New System.Drawing.Point(161, 340)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(185, 34)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register as Member"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLibrarian
        '
        Me.btnLibrarian.Location = New System.Drawing.Point(283, 200)
        Me.btnLibrarian.Name = "btnLibrarian"
        Me.btnLibrarian.Size = New System.Drawing.Size(131, 43)
        Me.btnLibrarian.TabIndex = 8
        Me.btnLibrarian.Text = "Login as Staff"
        Me.btnLibrarian.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.Location = New System.Drawing.Point(83, 200)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(131, 43)
        Me.btnMember.TabIndex = 7
        Me.btnMember.Text = "Login as Member"
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(201, 129)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(27, 17)
        Me.lblId.TabIndex = 9
        Me.lblId.Text = "AD"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(204, 274)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(92, 34)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Welcome to Library Management System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 82)
        Me.Panel1.TabIndex = 11
        '
        'btnLogLibrarian
        '
        Me.btnLogLibrarian.Location = New System.Drawing.Point(83, 200)
        Me.btnLogLibrarian.Name = "btnLogLibrarian"
        Me.btnLogLibrarian.Size = New System.Drawing.Size(131, 43)
        Me.btnLogLibrarian.TabIndex = 12
        Me.btnLogLibrarian.Text = "Librarian"
        Me.btnLogLibrarian.UseVisualStyleBackColor = True
        '
        'btnLogAdmin
        '
        Me.btnLogAdmin.Location = New System.Drawing.Point(283, 200)
        Me.btnLogAdmin.Name = "btnLogAdmin"
        Me.btnLogAdmin.Size = New System.Drawing.Size(131, 43)
        Me.btnLogAdmin.TabIndex = 13
        Me.btnLogAdmin.Text = "Admin"
        Me.btnLogAdmin.UseVisualStyleBackColor = True
        '
        'btnBack2
        '
        Me.btnBack2.Location = New System.Drawing.Point(204, 274)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(92, 34)
        Me.btnBack2.TabIndex = 14
        Me.btnBack2.Text = "Back"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'btnBack3
        '
        Me.btnBack3.CausesValidation = False
        Me.btnBack3.Location = New System.Drawing.Point(204, 274)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(92, 34)
        Me.btnBack3.TabIndex = 15
        Me.btnBack3.Text = "Back"
        Me.btnBack3.UseVisualStyleBackColor = True
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Location = New System.Drawing.Point(319, 177)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(18, 17)
        Me.chkShowPass.TabIndex = 16
        Me.chkShowPass.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(427, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 36)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack4
        '
        Me.btnBack4.Location = New System.Drawing.Point(204, 274)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(92, 34)
        Me.btnBack4.TabIndex = 18
        Me.btnBack4.Text = "Back"
        Me.btnBack4.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(497, 398)
        Me.Controls.Add(Me.btnBack4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.btnBack3)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.btnLogAdmin)
        Me.Controls.Add(Me.btnLogLibrarian)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnMember)
        Me.Controls.Add(Me.btnLibrarian)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.mskId)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents mskId As MaskedTextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLibrarian As Button
    Friend WithEvents btnMember As Button
    Friend WithEvents lblId As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogLibrarian As Button
    Friend WithEvents btnLogAdmin As Button
    Friend WithEvents btnBack2 As Button
    Friend WithEvents btnBack3 As Button
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack4 As Button
End Class
