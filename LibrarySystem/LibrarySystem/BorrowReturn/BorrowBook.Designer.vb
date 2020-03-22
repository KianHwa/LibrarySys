<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowBook
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvBorrow = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtRemoveBorrowBook = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(41, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 266)
        Me.GroupBox1.TabIndex = 0
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
        Me.ToolTip1.SetToolTip(Me.lblDueDate, "The day you need to return the book")
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
        Me.ToolTip1.SetToolTip(Me.txtISBN, "Numerical number on the cover of the page")
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
        Me.ToolTip1.SetToolTip(Me.txtMemberName, "Your registered name")
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(176, 47)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(200, 30)
        Me.txtMemberID.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtMemberID, "Your member ID, start with M...")
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
        Me.GroupBox3.Controls.Add(Me.dgvBorrow)
        Me.GroupBox3.Controls.Add(Me.btnRemove)
        Me.GroupBox3.Controls.Add(Me.txtRemoveBorrowBook)
        Me.GroupBox3.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(41, 324)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(914, 307)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgvBorrow
        '
        Me.dgvBorrow.AllowUserToAddRows = False
        Me.dgvBorrow.AllowUserToDeleteRows = False
        Me.dgvBorrow.AllowUserToResizeColumns = False
        Me.dgvBorrow.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBorrow.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBorrow.CausesValidation = False
        Me.dgvBorrow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvBorrow.ColumnHeadersHeight = 35
        Me.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrow.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvBorrow.EnableHeadersVisualStyles = False
        Me.dgvBorrow.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBorrow.Location = New System.Drawing.Point(24, 30)
        Me.dgvBorrow.Name = "dgvBorrow"
        Me.dgvBorrow.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrow.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvBorrow.RowHeadersWidth = 51
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.dgvBorrow.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvBorrow.RowTemplate.Height = 24
        Me.dgvBorrow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrow.Size = New System.Drawing.Size(873, 194)
        Me.dgvBorrow.TabIndex = 15
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
        'txtRemoveBorrowBook
        '
        Me.txtRemoveBorrowBook.Location = New System.Drawing.Point(531, 256)
        Me.txtRemoveBorrowBook.Multiline = True
        Me.txtRemoveBorrowBook.Name = "txtRemoveBorrowBook"
        Me.txtRemoveBorrowBook.Size = New System.Drawing.Size(224, 35)
        Me.txtRemoveBorrowBook.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtRemoveBorrowBook, "Enter the book ISBN to remove")
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(818, 660)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(120, 35)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'BorrowBook
        '
        Me.AcceptButton = Me.btnBorrow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnConfirm
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "BorrowBook"
        Me.Text = "Borrow Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtRemoveBorrowBook As TextBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents dgvBorrow As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
End Class
