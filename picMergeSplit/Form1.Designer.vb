<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnAddFiles = New System.Windows.Forms.Button()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cboAlize = New System.Windows.Forms.ComboBox()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.btnAddFolder = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.fbdAddFile = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.ofdAddFile = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddFolder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboAlize)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboLocation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpenFile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnNewFile)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(679, 552)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 631)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNewFile
        '
        Me.btnNewFile.Location = New System.Drawing.Point(3, 3)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(75, 23)
        Me.btnNewFile.TabIndex = 0
        Me.btnNewFile.Text = "新建"
        Me.btnNewFile.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(84, 3)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "打开"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Location = New System.Drawing.Point(3, 44)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFiles.TabIndex = 3
        Me.btnAddFiles.Text = "添加文件"
        Me.btnAddFiles.UseVisualStyleBackColor = True
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"向下", "向右", "向左", "向上"})
        Me.cboLocation.Location = New System.Drawing.Point(3, 467)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(48, 20)
        Me.cboLocation.TabIndex = 4
        Me.cboLocation.Text = "向下"
        '
        'cboAlize
        '
        Me.cboAlize.FormattingEnabled = True
        Me.cboAlize.Items.AddRange(New Object() {"居中", "靠左/上", "靠右/下"})
        Me.cboAlize.Location = New System.Drawing.Point(57, 467)
        Me.cboAlize.Name = "cboAlize"
        Me.cboAlize.Size = New System.Drawing.Size(48, 20)
        Me.cboAlize.TabIndex = 5
        Me.cboAlize.Text = "居中"
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.ItemHeight = 12
        Me.lstFiles.Location = New System.Drawing.Point(3, 73)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(183, 388)
        Me.lstFiles.TabIndex = 6
        '
        'btnAddFolder
        '
        Me.btnAddFolder.Location = New System.Drawing.Point(84, 44)
        Me.btnAddFolder.Name = "btnAddFolder"
        Me.btnAddFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFolder.TabIndex = 7
        Me.btnAddFolder.Text = "添加目录"
        Me.btnAddFolder.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(111, 524)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "保存"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(111, 467)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "插入"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'ofdAddFile
        '
        Me.ofdAddFile.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 552)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnAddFolder As Button
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents cboAlize As ComboBox
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents btnAddFiles As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnNewFile As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents fbdAddFile As FolderBrowserDialog
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents sfdSaveFile As SaveFileDialog
    Friend WithEvents ofdAddFile As OpenFileDialog
End Class
