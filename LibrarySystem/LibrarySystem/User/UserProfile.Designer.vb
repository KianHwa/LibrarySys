<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserProfile
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lbl09 = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblIc = New System.Windows.Forms.Label()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "User ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Password :"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(38, 470)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 28)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(167, 470)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 416)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Occupation :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 310)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Date of Birth :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Gender :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 374)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Email Address :"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(35, 269)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(117, 17)
        Me.lblStudentID.TabIndex = 41
        Me.lblStudentID.Text = "Identity Card No :"
        '
        'lbl09
        '
        Me.lbl09.AutoSize = True
        Me.lbl09.Location = New System.Drawing.Point(33, 138)
        Me.lbl09.Name = "lbl09"
        Me.lbl09.Size = New System.Drawing.Size(131, 17)
        Me.lbl09.TabIndex = 40
        Me.lbl09.Text = "Name of Applicant :"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUserId.Location = New System.Drawing.Point(102, 95)
        Me.lblUserId.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(100, 19)
        Me.lblUserId.TabIndex = 60
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(170, 138)
        Me.lblName.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 19)
        Me.lblName.TabIndex = 66
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGender.Location = New System.Drawing.Point(106, 229)
        Me.lblGender.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(100, 19)
        Me.lblGender.TabIndex = 68
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDob.Location = New System.Drawing.Point(329, 229)
        Me.lblDob.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(100, 19)
        Me.lblDob.TabIndex = 69
        '
        'lblIc
        '
        Me.lblIc.AutoSize = True
        Me.lblIc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIc.Location = New System.Drawing.Point(158, 269)
        Me.lblIc.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblIc.Name = "lblIc"
        Me.lblIc.Size = New System.Drawing.Size(100, 19)
        Me.lblIc.TabIndex = 70
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Location = New System.Drawing.Point(296, 470)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(155, 28)
        Me.btnResetPassword.TabIndex = 7
        Me.btnResetPassword.Text = "Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(110, 307)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(334, 49)
        Me.txtAddress.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(148, 371)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(158, 22)
        Me.txtEmail.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(119, 180)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtPassword.TabIndex = 1
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Location = New System.Drawing.Point(246, 179)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(129, 21)
        Me.chkShowPass.TabIndex = 0
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 55)
        Me.Panel1.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(241, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "User Profile"
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(130, 416)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(0, 21)
        Me.labelStatus.TabIndex = 72
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 516)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.lblIc)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lbl09)
        Me.Name = "UserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lbl09 As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents lblIc As Label
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents labelStatus As Label
End Class
