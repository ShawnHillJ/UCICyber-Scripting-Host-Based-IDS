Public Class Select_Scripts_Folder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        ZotDefender.Scripts_Path = ScriptsPathTxbx.Text
        ZotDefender.Enabled = True
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BringToFront()
        ScriptsPathTxbx.Text = System.Environment.ExpandEnvironmentVariables("%USERPROFILE%") & "\Desktop\PSScripts\"
    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        FolderBrowserDialog1.ShowDialog()
        ScriptsPathTxbx.Text = FolderBrowserDialog1.SelectedPath & "\"

    End Sub
End Class