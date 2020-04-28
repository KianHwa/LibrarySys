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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyBook))
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
        Me.btnClose.Location = New System.Drawing.Point(157, 392)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 28)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnModify.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnModify.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModify.Location = New System.Drawing.Point(157, 347)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(90, 28)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "&Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(116, 200)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(122, 20)
        Me.txtAuthor.TabIndex = 3
        '
        'txtBookDesc
        '
        Me.txtBookDesc.Location = New System.Drawing.Point(116, 103)
        Me.txtBookDesc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBookDesc.Multiline = True
        Me.txtBookDesc.Name = "txtBookDesc"
        Me.txtBookDesc.Size = New System.Drawing.Size(122, 82)
        Me.txtBookDesc.TabIndex = 2
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(116, 74)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(122, 20)
        Me.txtBookName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label6.Location = New System.Drawing.Point(53, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Author :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label7.Location = New System.Drawing.Point(28, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Description :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label8.Location = New System.Drawing.Point(69, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Title :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label9.Location = New System.Drawing.Point(66, 37)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ISBN :"
        '
        'lblISBN
        '
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.Location = New System.Drawing.Point(116, 42)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(122, 22)
        Me.lblISBN.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRemove.CausesValidation = False
        Me.btnRemove.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemove.Location = New System.Drawing.Point(34, 347)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(90, 28)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(34, 392)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 28)
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
        Me.grpCategory.Location = New System.Drawing.Point(31, 235)
        Me.grpCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpCategory.Size = New System.Drawing.Size(216, 86)
        Me.grpCategory.TabIndex = 4
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'chkMystery
        '
        Me.chkMystery.AutoSize = True
        Me.chkMystery.Location = New System.Drawing.Point(4, 50)
        Me.chkMystery.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkMystery.Name = "chkMystery"
        Me.chkMystery.Size = New System.Drawing.Size(77, 23)
        Me.chkMystery.TabIndex = 1
        Me.chkMystery.Text = "Mystery"
        Me.chkMystery.UseVisualStyleBackColor = True
        '
        'chkHorror
        '
        Me.chkHorror.AutoSize = True
        Me.chkHorror.Location = New System.Drawing.Point(129, 24)
        Me.chkHorror.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkHorror.Name = "chkHorror"
        Me.chkHorror.Size = New System.Drawing.Size(69, 23)
        Me.chkHorror.TabIndex = 2
        Me.chkHorror.Text = "Horror"
        Me.chkHorror.UseVisualStyleBackColor = True
        '
        'chkHistory
        '
        Me.chkHistory.AutoSize = True
        Me.chkHistory.Location = New System.Drawing.Point(4, 23)
        Me.chkHistory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkHistory.Name = "chkHistory"
        Me.chkHistory.Size = New System.Drawing.Size(128, 23)
        Me.chkHistory.TabIndex = 0
        Me.chkHistory.Text = "Historical fiction"
        Me.chkHistory.UseVisualStyleBackColor = True
        '
        'ModifyBook
        '
        Me.AcceptButton = Me.btnModify
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(272, 435)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
