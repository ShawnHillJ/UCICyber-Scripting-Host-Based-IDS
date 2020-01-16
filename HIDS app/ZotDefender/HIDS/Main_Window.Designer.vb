<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ZotDefender
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EportAsCSVButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.EventLog2 = New System.Diagnostics.EventLog()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage3.Controls.Add(Me.Button14)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Button13)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(1061, 510)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "IDS, Logs and Events"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(431, 60)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(100, 28)
        Me.Button14.TabIndex = 15
        Me.Button14.Text = "Browse..."
        Me.Button14.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(176, 63)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(245, 22)
        Me.TextBox8.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 66)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Specify Log Folder:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(83, 110)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(274, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Note: Programs will open in a new window."
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(59, 432)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(344, 28)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "Deploy Event Logger"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(59, 396)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(344, 28)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "Deploy Connection Logger"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1061, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Utility / QoL Functions"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(603, 74)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(388, 223)
        Me.TextBox7.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(599, 54)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Description"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Button15)
        Me.Panel2.Controls.Add(Me.Button11)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Location = New System.Drawing.Point(36, 39)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 434)
        Me.Panel2.TabIndex = 0
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button15.Location = New System.Drawing.Point(59, 177)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(344, 28)
        Me.Button15.TabIndex = 10
        Me.Button15.Text = "Remove Vulnerable Programs"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button11.Location = New System.Drawing.Point(59, 142)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(344, 28)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "View Installed Programs"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button10.Location = New System.Drawing.Point(59, 106)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(344, 28)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "View Non-Native Processes"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button9.Location = New System.Drawing.Point(59, 70)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(344, 28)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Change All User Passwords..."
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button7.Location = New System.Drawing.Point(59, 34)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(344, 28)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Get File Hashes..."
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Utilities"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button6.Location = New System.Drawing.Point(59, 369)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(344, 28)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Event Viewer"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button5.Location = New System.Drawing.Point(59, 334)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(344, 28)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Group Policy Editor"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 278)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Shortcuts"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button4.Location = New System.Drawing.Point(59, 298)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(344, 28)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Firewall with Advanced Security"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.EportAsCSVButton)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1061, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventory"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(469, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(585, 492)
        Me.DataGridView1.TabIndex = 8
        '
        'EportAsCSVButton
        '
        Me.EportAsCSVButton.Location = New System.Drawing.Point(232, 428)
        Me.EportAsCSVButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EportAsCSVButton.Name = "EportAsCSVButton"
        Me.EportAsCSVButton.Size = New System.Drawing.Size(229, 71)
        Me.EportAsCSVButton.TabIndex = 7
        Me.EportAsCSVButton.Text = "Export as CSV"
        Me.EportAsCSVButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 428)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 71)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Export as Text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 7)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(455, 57)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Get Inventory"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(7, 72)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 350)
        Me.Panel1.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(16, 47)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(427, 285)
        Me.TextBox6.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Console Output"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(11, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1069, 539)
        Me.TabControl1.TabIndex = 0
        '
        'ToolTip1
        '
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'EventLog2
        '
        Me.EventLog2.SynchronizingObject = Me
        '
        'ZotDefender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1092, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ZotDefender"
        Me.Text = "ZotDefender"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents EportAsCSVButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents EventLog2 As EventLog
    Protected WithEvents TabPage2 As TabPage
    Friend WithEvents Button15 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
