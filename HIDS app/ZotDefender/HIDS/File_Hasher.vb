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
        Dim input_file As String
        Dim output_file As String
        Dim recursive_argument As String = "-r "
        Dim max_files_argument As String = "-m "
        Dim algorithm_argument As String = "-a "



        Execute_Command("powershell " + "")
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
End Class