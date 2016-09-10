<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table
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
        Me.DataGridView_Tables = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_Tables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Tables
        '
        Me.DataGridView_Tables.AllowUserToAddRows = False
        Me.DataGridView_Tables.AllowUserToDeleteRows = False
        Me.DataGridView_Tables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Tables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Tables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_Tables.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Tables.Name = "DataGridView_Tables"
        Me.DataGridView_Tables.ReadOnly = True
        Me.DataGridView_Tables.RowHeadersVisible = False
        Me.DataGridView_Tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Tables.Size = New System.Drawing.Size(1216, 551)
        Me.DataGridView_Tables.TabIndex = 0
        '
        'Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 551)
        Me.Controls.Add(Me.DataGridView_Tables)
        Me.Name = "Table"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table"
        CType(Me.DataGridView_Tables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView_Tables As System.Windows.Forms.DataGridView
End Class
