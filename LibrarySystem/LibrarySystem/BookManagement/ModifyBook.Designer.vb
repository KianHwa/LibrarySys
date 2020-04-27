<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyBook
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookDesc = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.chkMystery = New System.Windows.Forms.CheckBox()
        Me.chkHorror = New System.Windows.Forms.CheckBox()
        Me.chkHistory = New System.Windows.Forms.CheckBox()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkRed
        Me.btnClose.CausesValidation = False
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(209, 482)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 35)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnModify.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnModify.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModify.Location = New System.Drawing.Point(209, 427)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(120, 35)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(155, 246)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(162, 22)
        Me.txtAuthor.TabIndex = 3
        '
        'txtBookDesc
        '
        Me.txtBookDesc.Location = New System.Drawing.Point(155, 127)
        Me.txtBookDesc.Multiline = True
        Me.txtBookDesc.Name = "txtBookDesc"
        Me.txtBookDesc.Size = New System.Drawing.Size(162, 100)
        Me.txtBookDesc.TabIndex = 2
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(155, 91)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(162, 22)
        Me.txtBookName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label6.Location = New System.Drawing.Point(71, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Author :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label7.Location = New System.Drawing.Point(37, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Description :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label8.Location = New System.Drawing.Point(92, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Title :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label9.Location = New System.Drawing.Point(88, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ISBN :"
        '
        'lblISBN
        '
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.Location = New System.Drawing.Point(155, 52)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(162, 27)
        Me.lblISBN.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRemove.CausesValidation = False
        Me.btnRemove.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemove.Location = New System.Drawing.Point(45, 427)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 35)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(45, 482)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 35)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "R&eset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.chkMystery)
        Me.grpCategory.Controls.Add(Me.chkHorror)
        Me.grpCategory.Controls.Add(Me.chkHistory)
        Me.grpCategory.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.grpCategory.Location = New System.Drawing.Point(41, 289)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(288, 106)
        Me.grpCategory.TabIndex = 4
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'chkMystery
        '
        Me.chkMystery.AutoSize = True
        Me.chkMystery.Location = New System.Drawing.Point(6, 62)
        Me.chkMystery.Name = "chkMystery"
        Me.chkMystery.Size = New System.Drawing.Size(94, 28)
        Me.chkMystery.TabIndex = 1
        Me.chkMystery.Text = "Mystery"
        Me.chkMystery.UseVisualStyleBackColor = True
        '
        'chkHorror
        '
        Me.chkHorror.AutoSize = True
        Me.chkHorror.Location = New System.Drawing.Point(172, 29)
        Me.chkHorror.Name = "chkHorror"
        Me.chkHorror.Size = New System.Drawing.Size(83, 28)
        Me.chkHorror.TabIndex = 2
        Me.chkHorror.Text = "Horror"
        Me.chkHorror.UseVisualStyleBackColor = True
        '
        'chkHistory
        '
        Me.chkHistory.AutoSize = True
        Me.chkHistory.Location = New System.Drawing.Point(6, 28)
        Me.chkHistory.Name = "chkHistory"
        Me.chkHistory.Size = New System.Drawing.Size(160, 28)
        Me.chkHistory.TabIndex = 0
        Me.chkHistory.Text = "Historical fiction"
        Me.chkHistory.UseVisualStyleBackColor = True
        '
        'ModifyBook
        '
        Me.AcceptButton = Me.btnModify
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(363, 535)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookDesc)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ModifyBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ModifyBook"
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookDesc As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents chkMystery As CheckBox
    Friend WithEvents chkHorror As CheckBox
    Friend WithEvents chkHistory As CheckBox
End Class
