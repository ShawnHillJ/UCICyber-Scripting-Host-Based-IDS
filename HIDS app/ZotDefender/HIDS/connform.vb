Imports System.IO

Public Class connform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table = DataGridView1
        Dim list = ListBox2
        Dim lfilep As String = "C:\Users\Devastator\Documents\git\ZotDefender\log.txt"
        Dim bfilep As String = "C:\Users\Devastator\Documents\git\ZotDefender\list.txt"
        Dim btitle = TextBox1
        btitle.AppendText("Blocked Hosts")
        btitle.ReadOnly = True
        Dim addbtn = Button1
        addbtn.Text = "Add"
        Dim dltbtn = Button2
        dltbtn.Text = "Delete"

        For Each line As String In File.ReadAllLines(lfilep)
            Dim data = line.Split(",")
            Dim src As String = data(0)
            Dim sport As String = data(1)
            Dim dest As String = data(2)
            Dim dport As String = data(3)
            Dim state As String = data(4)
            Dim conntype As String = data(5)
            Dim pid As String = data(6)
            Dim conndate As String = data(7)
            Dim status As String = data(8)
            table.Rows.Add(status, conndate, src, sport, dest, dport, state, pid)
        Next
        For Each host As String In File.ReadAllLines(bfilep)
            list.Items.Add(host)

        Next
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim list = ListBox2
        Dim table = DataGridView1
        If (table.CurrentCell.ColumnIndex.Equals(2)) Or (table.CurrentCell.ColumnIndex.Equals(4)) Then

            list.Items.Add(table.CurrentCell.Value)
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim list = ListBox2
        list.Items.Remove(list.SelectedItem)
    End Sub
End Class
