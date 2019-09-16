Imports System.Text
Imports System.IO
Imports System
Imports System.Collections.ObjectModel
'Imports System.Management.Automation
'Imports System.Management.Automation.Runspaces




Public Class ZotDefender

    Private psi As ProcessStartInfo
    Private cmd As Process
    Private display_area As TextBox
    Private Delegate Sub InvokeWithString(ByVal text As String)

    Private Sub Execute_Script_and_Output_String(ByVal command As String, ByRef text_object As TextBox)
        Try
            cmd.Kill()
        Catch ex As Exception
        End Try


        text_object.Clear()
        display_area = text_object

        psi = New ProcessStartInfo(TextBox1.Text)

        Dim outputs As New System.Collections.Generic.List(Of String)
        Dim output_errors As New System.Collections.Generic.List(Of String)

        Dim systemencoding As System.Text.Encoding
        System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)

        With psi
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = False
            .StandardOutputEncoding = systemencoding
            .StandardErrorEncoding = systemencoding
        End With

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim command As New PSCommand
        'Dim output As String = vbNullChar
        'Dim pos As Int32 = InStr(output, "\n")

        Try
            cmd.Kill()
        Catch ex As Exception
        End Try

        TextBox6.Clear()
        If TextBox1.Text.Contains(" ") Then
            psi = New ProcessStartInfo(TextBox1.Text.Split(" ")(0), TextBox1.Text.Split()(1))
        Else
            psi = New ProcessStartInfo(TextBox1.Text$)
        End If

        Dim systemencoding As System.Text.Encoding
        System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)

        With psi
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = False
            .StandardOutputEncoding = systemencoding
            .StandardErrorEncoding = systemencoding
        End With
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}
        AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received
        cmd.Start()
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()

    End Sub

    'Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
    'Me.Invoke(New InvokeWithString(AddressOf Sync_Output), e.Data)
    'End Sub

    'Private Sub Sync_Output(ByVal text As String)
    '   TextBox6.AppendText(text & Environment.NewLine)
    '    TextBox6.ScrollToCaret()
    'End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
