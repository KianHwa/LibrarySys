<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBorrowing
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvBorrowing = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvBorrowing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(184, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(137, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Books Borrowing"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 55)
        Me.Panel1.TabIndex = 1
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
        Me.dgvBorrowing.Location = New System.Drawing.Point(26, 81)
        Me.dgvBorrowing.Name = "dgvBorrowing"
        Me.dgvBorrowing.ReadOnly = True
        Me.dgvBorrowing.RowHeadersWidth = 51
        Me.dgvBorrowing.RowTemplate.Height = 24
        Me.dgvBorrowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowing.Size = New System.Drawing.Size(471, 355)
        Me.dgvBorrowing.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(26, 489)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(136, 41)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(23, 451)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(69, 17)
        Me.lblCount.TabIndex = 4
        Me.lblCount.Text = "X book(s)"
        '
        'FrmBorrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 542)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBorrowing)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmBorrowing"
        Me.Text = "Borrowing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvBorrowing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvBorrowing As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents lblCount As Label
End Class
