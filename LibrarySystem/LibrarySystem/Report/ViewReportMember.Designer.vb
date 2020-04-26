<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewReportMember
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radDaily = New System.Windows.Forms.RadioButton()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.lstView = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPortrait = New System.Windows.Forms.RadioButton()
        Me.radLanscape = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.cboDays = New System.Windows.Forms.ComboBox()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radDaily)
        Me.GroupBox2.Controls.Add(Me.radMonthly)
        Me.GroupBox2.Controls.Add(Me.radYearly)
        Me.GroupBox2.Location = New System.Drawing.Point(180, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 65)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'radDaily
        '
        Me.radDaily.AutoSize = True
        Me.radDaily.Font = New System.Drawing.Font("High Tower Text", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDaily.Location = New System.Drawing.Point(271, 21)
        Me.radDaily.Name = "radDaily"
        Me.radDaily.Size = New System.Drawing.Size(84, 32)
        Me.radDaily.TabIndex = 2
        Me.radDaily.TabStop = True
        Me.radDaily.Text = "Daily"
        Me.radDaily.UseVisualStyleBackColor = True
        '
        'radMonthly
        '
        Me.radMonthly.AutoSize = True
        Me.radMonthly.Font = New System.Drawing.Font("High Tower Text", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMonthly.Location = New System.Drawing.Point(131, 21)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(116, 32)
        Me.radMonthly.TabIndex = 1
        Me.radMonthly.TabStop = True
        Me.radMonthly.Text = "Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        '
        'radYearly
        '
        Me.radYearly.AutoSize = True
        Me.radYearly.Font = New System.Drawing.Font("High Tower Text", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radYearly.Location = New System.Drawing.Point(6, 21)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(97, 32)
        Me.radYearly.TabIndex = 0
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "Yearly"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'lstView
        '
        Me.lstView.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstView.FormattingEnabled = True
        Me.lstView.ItemHeight = 22
        Me.lstView.Location = New System.Drawing.Point(25, 87)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(516, 268)
        Me.lstView.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPortrait)
        Me.GroupBox1.Controls.Add(Me.radLanscape)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboYears)
        Me.GroupBox1.Controls.Add(Me.cboDays)
        Me.GroupBox1.Controls.Add(Me.cboMonths)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(578, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 379)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'radPortrait
        '
        Me.radPortrait.AutoSize = True
        Me.radPortrait.Location = New System.Drawing.Point(17, 205)
        Me.radPortrait.Name = "radPortrait"
        Me.radPortrait.Size = New System.Drawing.Size(82, 26)
        Me.radPortrait.TabIndex = 13
        Me.radPortrait.TabStop = True
        Me.radPortrait.Text = "Portrait"
        Me.radPortrait.UseVisualStyleBackColor = True
        '
        'radLanscape
        '
        Me.radLanscape.AutoSize = True
        Me.radLanscape.Location = New System.Drawing.Point(116, 205)
        Me.radLanscape.Name = "radLanscape"
        Me.radLanscape.Size = New System.Drawing.Size(110, 26)
        Me.radLanscape.TabIndex = 12
        Me.radLanscape.TabStop = True
        Me.radLanscape.Text = "Landscape"
        Me.radLanscape.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Months"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Days"
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024"})
        Me.cboYears.Location = New System.Drawing.Point(19, 53)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(201, 30)
        Me.cboYears.TabIndex = 5
        '
        'cboDays
        '
        Me.cboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDays.FormattingEnabled = True
        Me.cboDays.Location = New System.Drawing.Point(19, 169)
        Me.cboDays.Name = "cboDays"
        Me.cboDays.Size = New System.Drawing.Size(198, 30)
        Me.cboDays.TabIndex = 6
        '
        'cboMonths
        '
        Me.cboMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "Oktober", "November", "Desember"})
        Me.cboMonths.Location = New System.Drawing.Point(19, 111)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(198, 30)
        Me.cboMonths.TabIndex = 7
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(137, 248)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 40)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Years"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(22, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(195, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(19, 248)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(21, 381)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(120, 40)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "0 record(s)"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(165, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 30)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "- Member Report -"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewReportMember
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(848, 459)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCount)
        Me.Name = "ViewReportMember"
        Me.Text = "ViewReportMember"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radDaily As RadioButton
    Friend WithEvents radMonthly As RadioButton
    Friend WithEvents radYearly As RadioButton
    Friend WithEvents lstView As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radPortrait As RadioButton
    Friend WithEvents radLanscape As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboYears As ComboBox
    Friend WithEvents cboDays As ComboBox
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents Label4 As Label
End Class
