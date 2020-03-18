<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyBook
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtBookType = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookDesc = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(212, 243)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 38)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(80, 243)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(84, 38)
        Me.btnModify.TabIndex = 30
        Me.btnModify.Text = "&Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'txtBookType
        '
        Me.txtBookType.Location = New System.Drawing.Point(200, 185)
        Me.txtBookType.Name = "txtBookType"
        Me.txtBookType.Size = New System.Drawing.Size(100, 22)
        Me.txtBookType.TabIndex = 29
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(200, 150)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 22)
        Me.txtAuthor.TabIndex = 28
        '
        'txtBookDesc
        '
        Me.txtBookDesc.Location = New System.Drawing.Point(200, 120)
        Me.txtBookDesc.Name = "txtBookDesc"
        Me.txtBookDesc.Size = New System.Drawing.Size(100, 22)
        Me.txtBookDesc.TabIndex = 27
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(200, 84)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(100, 22)
        Me.txtBookName.TabIndex = 26
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(200, 46)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 22)
        Me.txtISBN.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Category :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Author :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Description :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(121, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Title :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ISBN :"
        '
        'ModifyBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 322)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.txtBookType)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookDesc)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ModifyBook"
        Me.Text = "ModifyBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents txtBookType As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookDesc As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
