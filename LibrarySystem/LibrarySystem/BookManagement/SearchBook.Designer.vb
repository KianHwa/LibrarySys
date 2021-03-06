﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchBook))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkHistory = New System.Windows.Forms.CheckBox()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.chkMystery = New System.Windows.Forms.CheckBox()
        Me.chkHorror = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New LibrarySystem.LibraryDataSet()
        Me.BookTableAdapter = New LibrarySystem.LibraryDataSetTableAdapters.BookTableAdapter()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategory.SuspendLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeight = 25
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookDescDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.BookBindingSource
        Me.dgv.Location = New System.Drawing.Point(21, 130)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(951, 508)
        Me.dgv.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.dgv, "Double click to make changes of the book list.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label8.Location = New System.Drawing.Point(55, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Title :"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(117, 71)
        Me.txtBookName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(136, 22)
        Me.txtBookName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtBookName, "Search based on book title")
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Location = New System.Drawing.Point(328, 676)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 34)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "To add new books")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(117, 26)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(136, 22)
        Me.txtISBN.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtISBN, "Search based on book ISBN")
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 7.8!)
        Me.lblCount.Location = New System.Drawing.Point(30, 653)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(52, 14)
        Me.lblCount.TabIndex = 0
        Me.lblCount.Text = "X book(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(51, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Double click on selected column to makes changes."
        '
        'chkHistory
        '
        Me.chkHistory.AutoSize = True
        Me.chkHistory.Location = New System.Drawing.Point(5, 28)
        Me.chkHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkHistory.Name = "chkHistory"
        Me.chkHistory.Size = New System.Drawing.Size(160, 28)
        Me.chkHistory.TabIndex = 7
        Me.chkHistory.Text = "Historical fiction"
        Me.chkHistory.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.chkMystery)
        Me.grpCategory.Controls.Add(Me.chkHorror)
        Me.grpCategory.Controls.Add(Me.chkHistory)
        Me.grpCategory.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.8!)
        Me.grpCategory.Location = New System.Drawing.Point(535, 10)
        Me.grpCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCategory.Size = New System.Drawing.Size(288, 106)
        Me.grpCategory.TabIndex = 8
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'chkMystery
        '
        Me.chkMystery.AutoSize = True
        Me.chkMystery.Location = New System.Drawing.Point(5, 62)
        Me.chkMystery.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMystery.Name = "chkMystery"
        Me.chkMystery.Size = New System.Drawing.Size(94, 28)
        Me.chkMystery.TabIndex = 9
        Me.chkMystery.Text = "Mystery"
        Me.chkMystery.UseVisualStyleBackColor = True
        '
        'chkHorror
        '
        Me.chkHorror.AutoSize = True
        Me.chkHorror.Location = New System.Drawing.Point(172, 30)
        Me.chkHorror.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkHorror.Name = "chkHorror"
        Me.chkHorror.Size = New System.Drawing.Size(83, 28)
        Me.chkHorror.TabIndex = 8
        Me.chkHorror.Text = "Horror"
        Me.chkHorror.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(580, 676)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 34)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkRed
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.2!)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(455, 676)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 34)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookDescDataGridViewTextBoxColumn
        '
        Me.BookDescDataGridViewTextBoxColumn.DataPropertyName = "bookDesc"
        Me.BookDescDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.BookDescDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BookDescDataGridViewTextBoxColumn.Name = "BookDescDataGridViewTextBoxColumn"
        Me.BookDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'SearchBook
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1005, 721)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1023, 768)
        Me.Name = "SearchBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Book"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As LibraryDataSetTableAdapters.BookTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents chkHistory As CheckBox
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents chkMystery As CheckBox
    Friend WithEvents chkHorror As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
