<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowHistory
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvBorrowing = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.dgvBorrowing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(26, 499)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(136, 41)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvBorrowing
        '
        Me.dgvBorrowing.AllowUserToAddRows = False
        Me.dgvBorrowing.AllowUserToDeleteRows = False
        Me.dgvBorrowing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBorrowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrowing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowing.Location = New System.Drawing.Point(26, 80)
        Me.dgvBorrowing.Name = "dgvBorrowing"
        Me.dgvBorrowing.ReadOnly = True
        Me.dgvBorrowing.RowHeadersWidth = 51
        Me.dgvBorrowing.RowTemplate.Height = 24
        Me.dgvBorrowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowing.Size = New System.Drawing.Size(471, 362)
        Me.dgvBorrowing.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 55)
        Me.Panel1.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(159, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(192, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Books Borrowed History"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(23, 457)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(69, 17)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "X book(s)"
        '
        'BorrowHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 552)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBorrowing)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BorrowHistory"
        Me.Text = "BorrowHistory"
        CType(Me.dgvBorrowing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvBorrowing As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label1 As Label
    Friend WithEvents lblCount As Label
End Class
