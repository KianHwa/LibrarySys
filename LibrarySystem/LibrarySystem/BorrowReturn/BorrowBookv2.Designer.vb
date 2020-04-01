<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookv2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvBorrowList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBorrow)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblDueDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtMemberName)
        Me.GroupBox1.Controls.Add(Me.txtMemberID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 266)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBorrow.FlatAppearance.BorderSize = 0
        Me.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.White
        Me.btnBorrow.Location = New System.Drawing.Point(736, 202)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(120, 35)
        Me.btnBorrow.TabIndex = 13
        Me.btnBorrow.Text = "&Borrow"
        Me.btnBorrow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(587, 202)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 35)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "C&lear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblDueDate
        '
        Me.lblDueDate.BackColor = System.Drawing.Color.White
        Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueDate.Location = New System.Drawing.Point(656, 100)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(200, 30)
        Me.lblDueDate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(500, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Due Date"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(656, 150)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(200, 30)
        Me.txtISBN.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(656, 50)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker1.TabIndex = 3
        '
        'txtMemberName
        '
        Me.txtMemberName.Location = New System.Drawing.Point(176, 100)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(200, 30)
        Me.txtMemberName.TabIndex = 2
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(176, 47)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(200, 30)
        Me.txtMemberID.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Book ISBN"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(500, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Borrow Date"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvBorrowList)
        Me.GroupBox3.Controls.Add(Me.btnRemove)
        Me.GroupBox3.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(29, 330)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(914, 307)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lvBorrowList
        '
        Me.lvBorrowList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvBorrowList.FullRowSelect = True
        Me.lvBorrowList.GridLines = True
        Me.lvBorrowList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvBorrowList.HideSelection = False
        Me.lvBorrowList.Location = New System.Drawing.Point(33, 40)
        Me.lvBorrowList.Name = "lvBorrowList"
        Me.lvBorrowList.Size = New System.Drawing.Size(850, 184)
        Me.lvBorrowList.TabIndex = 7
        Me.lvBorrowList.UseCompatibleStateImageBehavior = False
        Me.lvBorrowList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Book ISBN"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Book Name"
        Me.ColumnHeader3.Width = 450
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Borrow Date"
        Me.ColumnHeader4.Width = 150
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(774, 253)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 35)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(803, 662)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(120, 35)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'BorrowBookv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BorrowBookv2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BorrowBookv2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDueDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lvBorrowList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnConfirm As Button
End Class
