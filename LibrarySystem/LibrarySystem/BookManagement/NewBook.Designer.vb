<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBook
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookDesc = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.chkMystery = New System.Windows.Forms.CheckBox()
        Me.chkHorror = New System.Windows.Forms.CheckBox()
        Me.chkHistory = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.mskISBN = New System.Windows.Forms.MaskedTextBox()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(138, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label2.Location = New System.Drawing.Point(142, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label3.Location = New System.Drawing.Point(87, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Description :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label4.Location = New System.Drawing.Point(121, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Author :"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(210, 80)
        Me.txtBookName.MaxLength = 50
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(162, 22)
        Me.txtBookName.TabIndex = 1
        '
        'txtBookDesc
        '
        Me.txtBookDesc.Location = New System.Drawing.Point(210, 116)
        Me.txtBookDesc.MaxLength = 100
        Me.txtBookDesc.Multiline = True
        Me.txtBookDesc.Name = "txtBookDesc"
        Me.txtBookDesc.Size = New System.Drawing.Size(259, 99)
        Me.txtBookDesc.TabIndex = 2
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(210, 237)
        Me.txtAuthor.MaxLength = 50
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(162, 22)
        Me.txtAuthor.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Location = New System.Drawing.Point(149, 456)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 35)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(297, 456)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.chkMystery)
        Me.grpCategory.Controls.Add(Me.chkHorror)
        Me.grpCategory.Controls.Add(Me.chkHistory)
        Me.grpCategory.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.grpCategory.Location = New System.Drawing.Point(125, 298)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(288, 106)
        Me.grpCategory.TabIndex = 11
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'chkMystery
        '
        Me.chkMystery.AutoSize = True
        Me.chkMystery.Location = New System.Drawing.Point(6, 62)
        Me.chkMystery.Name = "chkMystery"
        Me.chkMystery.Size = New System.Drawing.Size(94, 28)
        Me.chkMystery.TabIndex = 9
        Me.chkMystery.Text = "Mystery"
        Me.chkMystery.UseVisualStyleBackColor = True
        '
        'chkHorror
        '
        Me.chkHorror.AutoSize = True
        Me.chkHorror.Location = New System.Drawing.Point(172, 29)
        Me.chkHorror.Name = "chkHorror"
        Me.chkHorror.Size = New System.Drawing.Size(83, 28)
        Me.chkHorror.TabIndex = 8
        Me.chkHorror.Text = "Horror"
        Me.chkHorror.UseVisualStyleBackColor = True
        '
        'chkHistory
        '
        Me.chkHistory.AutoSize = True
        Me.chkHistory.Location = New System.Drawing.Point(6, 28)
        Me.chkHistory.Name = "chkHistory"
        Me.chkHistory.Size = New System.Drawing.Size(160, 28)
        Me.chkHistory.TabIndex = 7
        Me.chkHistory.Text = "Historical fiction"
        Me.chkHistory.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(158, 343)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(158, 315)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'mskISBN
        '
        Me.mskISBN.Location = New System.Drawing.Point(210, 44)
        Me.mskISBN.Mask = "0000000000000"
        Me.mskISBN.Name = "mskISBN"
        Me.mskISBN.Size = New System.Drawing.Size(115, 22)
        Me.mskISBN.TabIndex = 16
        '
        'NewBook
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(580, 542)
        Me.Controls.Add(Me.mskISBN)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookDesc)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NewBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NewBook"
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtBookDesc As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents chkMystery As CheckBox
    Friend WithEvents chkHorror As CheckBox
    Friend WithEvents chkHistory As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents mskISBN As MaskedTextBox
End Class
