<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Scripts_Folder
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
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScriptsPathTxbx = New System.Windows.Forms.TextBox()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.Location = New System.Drawing.Point(148, 131)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(232, 27)
        Me.ConfirmBtn.TabIndex = 0
        Me.ConfirmBtn.Text = "OK"
        Me.ConfirmBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please select the location of the PowerShell Scripts folder:"
        '
        'ScriptsPathTxbx
        '
        Me.ScriptsPathTxbx.Location = New System.Drawing.Point(73, 85)
        Me.ScriptsPathTxbx.Name = "ScriptsPathTxbx"
        Me.ScriptsPathTxbx.Size = New System.Drawing.Size(324, 22)
        Me.ScriptsPathTxbx.TabIndex = 2
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Location = New System.Drawing.Point(403, 85)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(74, 23)
        Me.BrowseBtn.TabIndex = 3
        Me.BrowseBtn.Text = "Browse..."
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'Select_Scripts_Folder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 179)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.ScriptsPathTxbx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Select_Scripts_Folder"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ScriptsPathTxbx As TextBox
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
