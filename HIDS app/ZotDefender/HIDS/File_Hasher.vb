Public Class Form2

    'Initialize globals to use in process calls
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)

    Private Sub Execute_Command(ByVal command As String)

        'Close the cmd prompt if already opened previously by this function
        Try
            cmd.Kill()
        Catch ex As Exception
        End Try


        'Create a processinfo thing to feed to a new process
        'Use the contents of `command` as the command to execute
        If command.Contains(" ") Then
            psi = New ProcessStartInfo(command.Split(" ")(0), command.Split(" ")(1))
        Else
            psi = New ProcessStartInfo(command$)
        End If

        'Set up encoding for text
        Dim systemencoding As System.Text.Encoding
        systemencoding = System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)

        'Specify the parts for the processinfo object we made
        With psi
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = False
            .StandardOutputEncoding = systemencoding
            .StandardErrorEncoding = systemencoding
        End With

        'Create the new process to execute commands using the processinfo object
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}

        'AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
        'AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received

        cmd.Start()
        'cmd.BeginOutputReadLine()
        'cmd.BeginErrorReadLine()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("No Input Folder Specified!")
            Return
        End If

        If TextBox2.Text = "" Then
            MsgBox("No Output File Specified!")
            Return
        End If

        If ComboBox1.SelectedText = "Select Hashing Algorithm..." Then
            MsgBox("No Algorithm Specified!")
            Return
        End If


        Dim input_file As String = " -p " + TextBox1.Text
        Dim output_file As String = " -n " + TextBox2.Text
        Dim recursive_argument As String
        Dim max_files_argument As String
        Dim algorithm_argument As String = " -a " + ComboBox1.SelectedText



        If CheckBox1.Checked Then
            recursive_argument = " -r " + IIf(RadioButton6.Checked, "true", CStr(NumericUpDown3.Value))
        Else
            recursive_argument = ""
        End If

        If CheckBox2.Checked Then
            max_files_argument = " -m " + CStr(NumericUpDown2.Value)
        Else
            max_files_argument = ""
        End If

        Execute_Command("powershell C:\Blue_Team\File_hasher.ps1 " + input_file + output_file + recursive_argument + max_files_argument + algorithm_argument)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Panel2.Enabled = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        NumericUpDown2.Enabled = CheckBox2.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub

End Class