<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBook
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
        Me.components = New System.ComponentModel.Container()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.grpBorrowList = New System.Windows.Forms.GroupBox()
        Me.btnPaid = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDisplayDateTime = New System.Windows.Forms.Label()
        Me.lvBorrowList = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpDetails.SuspendLayout()
        Me.grpBorrowList.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(557, 212)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(90, 37)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(310, 70)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(90, 37)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "&Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student Name:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(142, 77)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(127, 27)
        Me.txtName.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(142, 34)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(127, 27)
        Me.txtID.TabIndex = 0
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.Label1)
        Me.grpDetails.Controls.Add(Me.Label2)
        Me.grpDetails.Controls.Add(Me.btnCheck)
        Me.grpDetails.Controls.Add(Me.txtID)
        Me.grpDetails.Controls.Add(Me.txtName)
        Me.grpDetails.Location = New System.Drawing.Point(25, 12)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(415, 118)
        Me.grpDetails.TabIndex = 0
        Me.grpDetails.TabStop = False
        '
        'grpBorrowList
        '
        Me.grpBorrowList.Controls.Add(Me.btnPaid)
        Me.grpBorrowList.Controls.Add(Me.Label3)
        Me.grpBorrowList.Controls.Add(Me.lblDisplayDateTime)
        Me.grpBorrowList.Controls.Add(Me.lvBorrowList)
        Me.grpBorrowList.Controls.Add(Me.btnReturn)
        Me.grpBorrowList.Location = New System.Drawing.Point(25, 136)
        Me.grpBorrowList.Name = "grpBorrowList"
        Me.grpBorrowList.Size = New System.Drawing.Size(662, 263)
        Me.grpBorrowList.TabIndex = 1
        Me.grpBorrowList.TabStop = False
        Me.grpBorrowList.Text = "Book(s) Borrowed"
        '
        'btnPaid
        '
        Me.btnPaid.Location = New System.Drawing.Point(17, 214)
        Me.btnPaid.Name = "btnPaid"
        Me.btnPaid.Size = New System.Drawing.Size(103, 37)
        Me.btnPaid.TabIndex = 2
        Me.btnPaid.Text = "Clear Fined Books"
        Me.btnPaid.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Double-click any book in the list if the student is not returning this time"
        '
        'lblDisplayDateTime
        '
        Me.lblDisplayDateTime.AutoSize = True
        Me.lblDisplayDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayDateTime.Location = New System.Drawing.Point(386, 214)
        Me.lblDisplayDateTime.Name = "lblDisplayDateTime"
        Me.lblDisplayDateTime.Size = New System.Drawing.Size(0, 15)
        Me.lblDisplayDateTime.TabIndex = 9
        '
        'lvBorrowList
        '
        Me.lvBorrowList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvBorrowList.FullRowSelect = True
        Me.lvBorrowList.GridLines = True
        Me.lvBorrowList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvBorrowList.HideSelection = False
        Me.lvBorrowList.Location = New System.Drawing.Point(9, 36)
        Me.lvBorrowList.Margin = New System.Windows.Forms.Padding(2)
        Me.lvBorrowList.Name = "lvBorrowList"
        Me.lvBorrowList.Size = New System.Drawing.Size(638, 150)
        Me.lvBorrowList.TabIndex = 8
        Me.lvBorrowList.UseCompatibleStateImageBehavior = False
        Me.lvBorrowList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "No"
        Me.ColumnHeader0.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book ISBN"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Book Name"
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Borrow Date"
        Me.ColumnHeader3.Width = 130
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'Timer1
        '
        '
        'ReturnBook
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 415)
        Me.Controls.Add(Me.grpBorrowList)
        Me.Controls.Add(Me.grpDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ReturnBook"
        Me.Text = "Return Book"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpBorrowList.ResumeLayout(False)
        Me.grpBorrowList.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents grpBorrowList As GroupBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents lvBorrowList As ListView
    Friend WithEvents ColumnHeader0 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lblDisplayDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPaid As Button
End Class
