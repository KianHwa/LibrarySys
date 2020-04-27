<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HowToUse
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
        Me.panelHome = New System.Windows.Forms.Panel()
        Me.lblHomeDetails = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelBorrow = New System.Windows.Forms.Panel()
        Me.lblBorrowDetails = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelHome.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBorrow.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHome
        '
        Me.panelHome.AutoScroll = True
        Me.panelHome.Controls.Add(Me.lblHomeDetails)
        Me.panelHome.Controls.Add(Me.PictureBox2)
        Me.panelHome.Location = New System.Drawing.Point(37, 150)
        Me.panelHome.Margin = New System.Windows.Forms.Padding(2)
        Me.panelHome.Name = "panelHome"
        Me.panelHome.Size = New System.Drawing.Size(689, 425)
        Me.panelHome.TabIndex = 0
        '
        'lblHomeDetails
        '
        Me.lblHomeDetails.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeDetails.Location = New System.Drawing.Point(25, 320)
        Me.lblHomeDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHomeDetails.Name = "lblHomeDetails"
        Me.lblHomeDetails.Size = New System.Drawing.Size(593, 610)
        Me.lblHomeDetails.TabIndex = 6
        Me.lblHomeDetails.Text = "Home details"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.home
        Me.PictureBox2.Location = New System.Drawing.Point(72, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(546, 289)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'panelBorrow
        '
        Me.panelBorrow.AutoScroll = True
        Me.panelBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBorrow.Controls.Add(Me.lblBorrowDetails)
        Me.panelBorrow.Controls.Add(Me.PictureBox3)
        Me.panelBorrow.Location = New System.Drawing.Point(37, 150)
        Me.panelBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.panelBorrow.Name = "panelBorrow"
        Me.panelBorrow.Size = New System.Drawing.Size(689, 425)
        Me.panelBorrow.TabIndex = 11
        '
        'lblBorrowDetails
        '
        Me.lblBorrowDetails.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowDetails.Location = New System.Drawing.Point(17, 292)
        Me.lblBorrowDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowDetails.Name = "lblBorrowDetails"
        Me.lblBorrowDetails.Size = New System.Drawing.Size(648, 422)
        Me.lblBorrowDetails.TabIndex = 7
        Me.lblBorrowDetails.Text = "Borrow details"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.LibrarySystem.My.Resources.Resources.borrow
        Me.PictureBox3.Location = New System.Drawing.Point(153, 10)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(403, 280)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(651, 111)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 24)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(562, 111)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 24)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(138, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 56)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "How to use"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.pngguru_com__5_
        Me.PictureBox1.Location = New System.Drawing.Point(37, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'HowToUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 586)
        Me.Controls.Add(Me.panelBorrow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.panelHome)
        Me.Controls.Add(Me.btnPrevious)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HowToUse"
        Me.Text = "How To Use"
        Me.panelHome.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBorrow.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHome As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents panelBorrow As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblHomeDetails As Label
    Friend WithEvents lblBorrowDetails As Label
End Class
