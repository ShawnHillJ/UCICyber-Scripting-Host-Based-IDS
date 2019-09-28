Imports System.IO
Imports System.Threading
Imports System.Timers

Public Class connform

    'declear global path variables
    Private ReadOnly log_dir As String = ZotDefender.FolderBrowserDialog1.SelectedPath
    Private ReadOnly lfilep As String = log_dir + "\log.txt"
    Private ReadOnly slfilep As String = log_dir + "\session.txt"
    Private ReadOnly bfilep As String = log_dir + "\list.txt"
    Private selected_log As String = lfilep

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialize form.
        initialize()
        Timer1.Interval = 15000
        Timer1.Start()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    'add host to the list
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim list = ListBox2
        Dim table = DataGridView1
        If (table.CurrentCell.ColumnIndex.Equals(2)) Or (table.CurrentCell.ColumnIndex.Equals(4)) Then
            If Not (list.Items.Contains(table.CurrentCell)) Then
                list.Items.Add(table.CurrentCell.Value)

            End If
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    'remove host from the blocked list
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim list = ListBox2
        list.Items.Remove(list.SelectedItem)

    End Sub

    'checks any new added hosts to the list.txt and update the text file and restart the script
    Private Sub list_check_update()
        Dim list = ListBox2
        Dim cur_hosts = list.Items
        If System.IO.File.Exists(bfilep) Then
            Dim writer As New System.IO.StreamWriter(bfilep, False)
            For Each host In cur_hosts
                writer.WriteLine(host.ToString)
            Next
            writer.Close()
        Else
            Dim writer As New System.IO.StreamWriter(bfilep, True)
            For Each host In cur_hosts
                writer.WriteLine(host)
            Next
            writer.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        list_check_update()
        ListBox2.Items.Clear()
        append_to_listbox()

    End Sub


    Private Sub append_to_listbox()
        For Each host As String In File.ReadAllLines(bfilep)
            ListBox2.Items.Add(host)

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Stop()
        Button4.Enabled = False
        Button4.Text = "Paused"
        Button5.Enabled = True
    End Sub

    'add items to the datagrid
    Private Sub append_to_table(filep As String)
        Try
            For Each line As String In File.ReadAllLines(filep)
                Dim data = line.Split(",")
                If (data.Length.Equals(9) And (Not data(1).Contains("LocalAddress"))) Then
                    Dim src As String = data(0)
                    Dim sport As String = data(1)
                    Dim dest As String = data(2)
                    Dim dport As String = data(3)
                    Dim state As String = data(4)
                    Dim conntype As String = data(5)
                    Dim pid As String = data(6)
                    Dim conndate As String = data(7)
                    Dim status As String = data(8)
                    DataGridView1.Rows.Add(status, conndate, src, sport, dest, dport, state, pid)
                End If
            Next
        Catch

        End Try

    End Sub


    Private Sub update_form(p As String)
        ListBox2.Items.Clear()
        DataGridView1.Rows.Clear()
        append_to_listbox()
        append_to_table(p)
    End Sub

    Private Sub initialize()
        TextBox1.AppendText("Blocked Hosts")
        TextBox1.ReadOnly = True
        Button1.Text = "Add"
        Button2.Text = "Delete"
        Button3.Text = "Apply Changes"
        Button4.Text = "Pause"
        Button5.Text = "Resume"
        Button5.Enabled = False
        CheckBox1.Text = "Read From Session Log"
        append_to_table(selected_log)
        append_to_listbox()

    End Sub


    'repeat the action
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        update_form(selected_log)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Start()
        Button4.Enabled = True
        Button4.Text = "Pause"
        Button5.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            selected_log = slfilep
            update_form(selected_log)
        Else
            selected_log = lfilep
            update_form(selected_log)

        End If

    End Sub
End Class
