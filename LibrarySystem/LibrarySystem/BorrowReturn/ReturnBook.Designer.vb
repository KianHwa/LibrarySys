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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.dtpSimulator = New System.Windows.Forms.DateTimePicker()
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(452, 194)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(192, 80)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(183, 223)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(210, 22)
        Me.txtISBN.TabIndex = 1
        '
        'dtpSimulator
        '
        Me.dtpSimulator.Location = New System.Drawing.Point(183, 101)
        Me.dtpSimulator.Name = "dtpSimulator"
        Me.dtpSimulator.Size = New System.Drawing.Size(210, 22)
        Me.dtpSimulator.TabIndex = 2
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(452, 78)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(192, 73)
        Me.btnSimulate.TabIndex = 3
        Me.btnSimulate.Text = "Simulate date"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimulate)
        Me.Controls.Add(Me.dtpSimulator)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "ReturnBook"
        Me.Text = "ReturnBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents dtpSimulator As DateTimePicker
    Friend WithEvents btnSimulate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
