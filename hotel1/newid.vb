Imports MySql.Data.MySqlClient
Public Class newid
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=future;persistsecurityinfo=True;database=hotelm")
    Dim cmd1 As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim rd As New DataTable
    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("use hotelm", conn)
            cmd.ExecuteNonQuery()
            'cmd1 = New MySqlCommand("insert into marksheet1 values('name',62,11,'BC',20,20)", conn)

            cmd1 = New MySqlCommand("insert into customer values(@cid,@cname,@caid)", conn)
            cmd1.Parameters.AddWithValue("@cid", Val(TextBox1.Text))
            cmd1.Parameters.AddWithValue("@cname", (TextBox2.Text))
            cmd1.Parameters.AddWithValue("@caid", Val(TextBox3.Text))

            cmd1.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("DATA SAVED")


        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class