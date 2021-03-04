Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyDB = "select * from admin where username='" & TextBox1.Text & "'and password='" & TextBox2.Text & "'"
        Cmd = New Odbc.OdbcCommand(MyDB, Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read = True Then
            'MsgBox("Login Relah berhasil", MsgBoxStyle.Information, "Warning")
            Me.Hide()
            Form3.Show()
            TextBox1.Text = "Username"
            TextBox2.Text = "Password"
            TextBox1.Focus()
        Else
            TextBox1.Text = "Username"
            TextBox2.Text = "Password"
            MsgBox("Username Dan Password Salah", MsgBoxStyle.Information, "Warning")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New Odbc.OdbcConnection
        If Conn.State = ConnectionState.Closed Then
            koneksi()
        End If
        TextBox1.Text = "Username"
        TextBox2.Text = "Password"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
    End Sub
End Class