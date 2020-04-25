<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateReport
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
        Me.btnReportBorrowBook = New System.Windows.Forms.Button()
        Me.btnReportReturnBook = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReportMember = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReportBorrowBook
        '
        Me.btnReportBorrowBook.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportBorrowBook.Location = New System.Drawing.Point(21, 85)
        Me.btnReportBorrowBook.Name = "btnReportBorrowBook"
        Me.btnReportBorrowBook.Size = New System.Drawing.Size(140, 50)
        Me.btnReportBorrowBook.TabIndex = 0
        Me.btnReportBorrowBook.Text = "&Borrow Book Report"
        Me.btnReportBorrowBook.UseVisualStyleBackColor = True
        '
        'btnReportReturnBook
        '
        Me.btnReportReturnBook.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportReturnBook.Location = New System.Drawing.Point(184, 85)
        Me.btnReportReturnBook.Name = "btnReportReturnBook"
        Me.btnReportReturnBook.Size = New System.Drawing.Size(140, 50)
        Me.btnReportReturnBook.TabIndex = 1
        Me.btnReportReturnBook.Text = "&Return Book Report"
        Me.btnReportReturnBook.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 67)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "What Report Do You Want To Generate?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(184, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReportMember)
        Me.GroupBox1.Controls.Add(Me.btnReportReturnBook)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnReportBorrowBook)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 265)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnReportMember
        '
        Me.btnReportMember.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportMember.Location = New System.Drawing.Point(21, 170)
        Me.btnReportMember.Name = "btnReportMember"
        Me.btnReportMember.Size = New System.Drawing.Size(140, 50)
        Me.btnReportMember.TabIndex = 5
        Me.btnReportMember.Text = "&Member Report"
        Me.btnReportMember.UseVisualStyleBackColor = True
        '
        'GenerateReport
        '
        Me.AcceptButton = Me.btnReportBorrowBook
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(426, 410)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GenerateReport"
        Me.Text = "GenerateReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReportBorrowBook As Button
    Friend WithEvents btnReportReturnBook As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReportMember As Button
End Class
