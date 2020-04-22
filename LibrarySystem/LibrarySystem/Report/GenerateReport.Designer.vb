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
        Me.btnReport1 = New System.Windows.Forms.Button()
        Me.btnReport2 = New System.Windows.Forms.Button()
        Me.btnReport3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReport1
        '
        Me.btnReport1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport1.Location = New System.Drawing.Point(12, 137)
        Me.btnReport1.Name = "btnReport1"
        Me.btnReport1.Size = New System.Drawing.Size(140, 50)
        Me.btnReport1.TabIndex = 0
        Me.btnReport1.Text = "Report 1"
        Me.btnReport1.UseVisualStyleBackColor = True
        '
        'btnReport2
        '
        Me.btnReport2.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport2.Location = New System.Drawing.Point(212, 137)
        Me.btnReport2.Name = "btnReport2"
        Me.btnReport2.Size = New System.Drawing.Size(140, 50)
        Me.btnReport2.TabIndex = 1
        Me.btnReport2.Text = "Report &2"
        Me.btnReport2.UseVisualStyleBackColor = True
        '
        'btnReport3
        '
        Me.btnReport3.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport3.Location = New System.Drawing.Point(12, 205)
        Me.btnReport3.Name = "btnReport3"
        Me.btnReport3.Size = New System.Drawing.Size(140, 50)
        Me.btnReport3.TabIndex = 2
        Me.btnReport3.Text = "Reprot &3"
        Me.btnReport3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 91)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "What Report Do You Want To Generate?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(212, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GenerateReport
        '
        Me.AcceptButton = Me.btnReport1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(370, 273)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReport3)
        Me.Controls.Add(Me.btnReport2)
        Me.Controls.Add(Me.btnReport1)
        Me.Name = "GenerateReport"
        Me.Text = "GenerateReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReport1 As Button
    Friend WithEvents btnReport2 As Button
    Friend WithEvents btnReport3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
