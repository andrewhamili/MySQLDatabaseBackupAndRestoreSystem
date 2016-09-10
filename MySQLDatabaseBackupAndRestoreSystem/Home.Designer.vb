<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.ListBox_Databases = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox_Tables = New System.Windows.Forms.ListBox()
        Me.btn_ShowTables = New System.Windows.Forms.Button()
        Me.Button_ShowTableData = New System.Windows.Forms.Button()
        Me.SaveFileDialog_DatabaseBackup = New System.Windows.Forms.SaveFileDialog()
        Me.Button_DatabaseBackup = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_Databases
        '
        Me.ListBox_Databases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Databases.FormattingEnabled = True
        Me.ListBox_Databases.ItemHeight = 18
        Me.ListBox_Databases.Location = New System.Drawing.Point(4, 23)
        Me.ListBox_Databases.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox_Databases.Name = "ListBox_Databases"
        Me.ListBox_Databases.Size = New System.Drawing.Size(212, 242)
        Me.ListBox_Databases.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox_Databases)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(220, 269)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Databases"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox_Tables)
        Me.GroupBox2.Location = New System.Drawing.Point(459, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 265)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tables"
        '
        'ListBox_Tables
        '
        Me.ListBox_Tables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Tables.FormattingEnabled = True
        Me.ListBox_Tables.ItemHeight = 18
        Me.ListBox_Tables.Location = New System.Drawing.Point(3, 22)
        Me.ListBox_Tables.Name = "ListBox_Tables"
        Me.ListBox_Tables.Size = New System.Drawing.Size(172, 240)
        Me.ListBox_Tables.TabIndex = 0
        '
        'btn_ShowTables
        '
        Me.btn_ShowTables.Location = New System.Drawing.Point(244, 152)
        Me.btn_ShowTables.Name = "btn_ShowTables"
        Me.btn_ShowTables.Size = New System.Drawing.Size(200, 23)
        Me.btn_ShowTables.TabIndex = 3
        Me.btn_ShowTables.Text = ">>SHOW TABLES>>"
        Me.btn_ShowTables.UseVisualStyleBackColor = True
        '
        'Button_ShowTableData
        '
        Me.Button_ShowTableData.Location = New System.Drawing.Point(648, 152)
        Me.Button_ShowTableData.Name = "Button_ShowTableData"
        Me.Button_ShowTableData.Size = New System.Drawing.Size(140, 50)
        Me.Button_ShowTableData.TabIndex = 4
        Me.Button_ShowTableData.Text = "Show Table Data"
        Me.Button_ShowTableData.UseVisualStyleBackColor = True
        '
        'Button_DatabaseBackup
        '
        Me.Button_DatabaseBackup.Location = New System.Drawing.Point(261, 194)
        Me.Button_DatabaseBackup.Name = "Button_DatabaseBackup"
        Me.Button_DatabaseBackup.Size = New System.Drawing.Size(169, 35)
        Me.Button_DatabaseBackup.TabIndex = 5
        Me.Button_DatabaseBackup.Text = "Database Backup"
        Me.Button_DatabaseBackup.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_DatabaseBackup)
        Me.Controls.Add(Me.Button_ShowTableData)
        Me.Controls.Add(Me.btn_ShowTables)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox_Databases As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox_Tables As System.Windows.Forms.ListBox
    Friend WithEvents btn_ShowTables As System.Windows.Forms.Button
    Friend WithEvents Button_ShowTableData As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog_DatabaseBackup As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button_DatabaseBackup As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
