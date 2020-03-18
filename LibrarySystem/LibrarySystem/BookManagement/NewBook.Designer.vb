<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBook
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookDesc = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookType = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Description :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Author :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Category :"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(197, 46)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 22)
        Me.txtISBN.TabIndex = 1
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(197, 84)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(100, 22)
        Me.txtBookName.TabIndex = 2
        '
        'txtBookDesc
        '
        Me.txtBookDesc.Location = New System.Drawing.Point(197, 120)
        Me.txtBookDesc.Name = "txtBookDesc"
        Me.txtBookDesc.Size = New System.Drawing.Size(100, 22)
        Me.txtBookDesc.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(197, 150)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 22)
        Me.txtAuthor.TabIndex = 4
        '
        'txtBookType
        '
        Me.txtBookType.Location = New System.Drawing.Point(197, 185)
        Me.txtBookType.Name = "txtBookType"
        Me.txtBookType.Size = New System.Drawing.Size(100, 22)
        Me.txtBookType.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(77, 243)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 38)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(209, 243)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 38)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 335)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBookType)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookDesc)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NewBook"
        Me.Text = "NewBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtBookDesc As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookType As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
