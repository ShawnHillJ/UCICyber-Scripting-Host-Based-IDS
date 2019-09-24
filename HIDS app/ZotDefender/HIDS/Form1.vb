Imports System.Text
Imports System.IO
Imports System
Imports System.Collections.ObjectModel
'Imports System.Management.Automation
'Imports System.Management.Automation.Runspaces




Public Class ZotDefender


    'Initialize globals to use in process calls
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private display_area As TextBox
    Private Delegate Sub InvokeWithString(ByVal text As String)
    Private display_output As String

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
            .CreateNoWindow = True
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


    Private Sub Execute_Script_and_Output_String(ByVal command As String, ByRef text_object As TextBox)

        'Close the cmd prompt if already opened previously by this function
        Try
            cmd.Kill()
        Catch ex As Exception
        End Try

        'Set display to text_object parameter, Clear the display area
        display_area = text_object
        text_object.Clear()

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

        AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received

        cmd.Start()
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()

    End Sub

    Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf Sync_Output), e.Data)
    End Sub

    Private Sub Sync_Output(ByVal text As String)
        display_area.AppendText(text & Environment.NewLine)
        display_area.ScrollToCaret()
    End Sub

    Private Sub ZotDefender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Execute_Script_and_Output_String("powershell C:\Users\Devastator\Documents\git\ZotDefender\Windows\Inventory\Get_Inventory.ps1", TextBox6)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Execute_Command("powershell wf.msc")
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        TextBox7.Text = "Opens the Firewall with Advanced Security Window."
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Execute_Command("powershell gpedit.msc")
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        TextBox7.Text = "Opens the Group Policy Editor. (Windows Server)"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Execute_Command("powershell eventvwr.msc")
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        TextBox7.Text = "Opens the Event Viewer."
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Call the SaveFileDialog to get file destination
        Dim destination As String
        SaveFileDialog1.Title = "Select Destination of file..."
        SaveFileDialog1.ShowDialog()

        'Set destination, set output to textbox contents
        destination = SaveFileDialog1.FileName
        display_output = TextBox6.Text

        'MsgBox(display_output)

        'Write contents to file specified earlier
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(destination, False)
        For Each line As String In display_output.Split("\r\n")
            file.WriteLine(line)
        Next
        file.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()

        'Execute_Command("powershell C:\Users\Devastator\Documents\git\ZotDefender\File_hasher.ps1")
    End Sub

    Private Sub Button7_MouseOver(sender As Object, e As EventArgs) Handles Button7.MouseHover
        TextBox7.Text = "Opens an interactive powershell prompt to grab file hashes"


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        connform.Show()
    End Sub


    Private Sub EventLog2_EntryWritten(sender As Object, e As EntryWrittenEventArgs) Handles EventLog2.EntryWritten

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button8_MouseOver(sender As Object, e As EventArgs) Handles Button8.MouseHover
        TextBox7.Text = "Launches the GUI setup to create an instance of an LDAP Server. Only works on Windows Server."
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button9_MouseOver(sender As Object, e As EventArgs) Handles Button9.MouseHover
        TextBox7.Text = "Launches a window to change user passwords on the local machine."
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button10_MouseOver(sender As Object, e As EventArgs) Handles Button10.MouseHover
        TextBox7.Text = "Displays a list of processes running that are not part of the native Windows library of processes."
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button11_MouseOver(sender As Object, e As EventArgs) Handles Button11.MouseHover
        TextBox7.Text = "Displays a list of intalled programs on the machine."
    End Sub


End Class
