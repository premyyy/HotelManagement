Imports MySql.Data.MySqlClient

Public Class reciption
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=future;persistsecurityinfo=True;database=hotelm")
    Dim cmd1 As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim rd As New DataTable
    Dim cmd As MySqlCommand
    Dim adr As MySqlDataAdapter
    Private Sub reciption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelmDataSet.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.HotelmDataSet.room)
        'TODO: This line of code loads data into the 'HotelmDataSet.food' table. You can move, or remove it, as needed.
        Me.FoodTableAdapter.Fill(Me.HotelmDataSet.food)

    End Sub
    Dim a As Integer
    Dim b As Integer
    Dim mul As Integer


    Private Sub GetInfo_Click(sender As Object, e As EventArgs) Handles GetInfo.Click
        Try

            conn.Open()
            cmd = New MySqlCommand("use hotelm", conn)
            cmd.ExecuteNonQuery()
            cmd1 = New MySqlCommand("select * from customer where cid=@id", conn)
            cmd1.Parameters.AddWithValue("@id", Val(TB1.Text))
            adr = New MySqlDataAdapter(cmd1)
            Try
                adr.Fill(rd)
                Label2.Text = rd(0)(1)
                Label3.Text = rd(0)(2)
                MessageBox.Show("data shown")
            Catch ex As Exception
                MessageBox.Show("Invalid id")

            End Try


        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newid.Show()
    End Sub

    Private Sub M1_Click(sender As Object, e As EventArgs) Handles M1.Click
        a = Val(R1.Text)
        b = Val(Q1.Text)
        mul = (a * b)
        M1.Text = mul
    End Sub

    Private Sub M2_Click(sender As Object, e As EventArgs) Handles M2.Click
        a = Val(R2.Text)
        b = Val(Q2.Text)
        mul = (a * b)
        M2.Text = mul
    End Sub

    Private Sub M3_Click(sender As Object, e As EventArgs) Handles M3.Click
        a = Val(R3.Text)
        b = Val(Q3.Text)
        mul = (a * b)
        M3.Text = mul
    End Sub
    Dim sum As Integer
    Dim c As Integer
    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        a = Val(M1.Text)
        b = Val(M2.Text)
        c = Val(M3.Text)
        sum = (a + b + c)
        Total.Text = sum
    End Sub

    Private Sub Amt_Click(sender As Object, e As EventArgs) Handles Amt.Click
        a = Val(RR.Text)
        b = Val(RQ.Text)
        mul = (a * b)
        Amt.Text = mul
    End Sub

    Private Sub RTotal_Click(sender As Object, e As EventArgs) Handles RTotal.Click
        RTotal.Text = Amt.Text
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = Val(Total.Text)
        b = Val(RTotal.Text)
        sum = (a + b)
        TA.Text = sum
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Q1.Text = ""
        Q2.Text = ""
        Q3.Text = ""

        M1.Text = "__________"
        M2.Text = "__________"
        M3.Text = "__________"

        Total.Text = "__________"

        RQ.Text = ""
        Amt.Text = "__________"
        RTotal.Text = "__________"

        TA.Text = "_____"
    End Sub
    Dim cmd2 As MySqlCommand
    Dim cmd3 As MySqlCommand
    Dim cmd4 As MySqlCommand
    Dim cmd5 As MySqlCommand
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try


            cmd = New MySqlCommand("use hotelm", conn)
            cmd.ExecuteNonQuery()

            cmd2 = New MySqlCommand("insert into fbill values(@cid, @fid, @Qty, @Amt)", conn)
            cmd2.Parameters.AddWithValue("@cid", Val(TB1.Text))
            cmd2.Parameters.AddWithValue("@fid", Val(F1.Text))
            cmd2.Parameters.AddWithValue("@Qty", Val(Q1.Text))
            cmd2.Parameters.AddWithValue("@Amt", Val(M1.Text))
            cmd2.ExecuteNonQuery()


            cmd3 = New MySqlCommand("insert into fbill values(@cid, @fid, @Qty, @Amt)", conn)
            cmd3.Parameters.AddWithValue("@cid", Val(TB1.Text))
            cmd3.Parameters.AddWithValue("@fid", Val(F2.Text))
            cmd3.Parameters.AddWithValue("@Qty", Val(Q2.Text))
            cmd3.Parameters.AddWithValue("@Amt", Val(M2.Text))
            cmd3.ExecuteNonQuery()


            cmd4 = New MySqlCommand("insert into fbill values(@cid, @fid, @Qty, @Amt)", conn)
            cmd4.Parameters.AddWithValue("@cid", Val(TB1.Text))
            cmd4.Parameters.AddWithValue("@fid", Val(F3.Text))
            cmd4.Parameters.AddWithValue("@Qty", Val(Q3.Text))
            cmd4.Parameters.AddWithValue("@Amt", Val(M3.Text))
            cmd4.ExecuteNonQuery()


            cmd5 = New MySqlCommand("insert into rbill values(@cid, @fid, @Qty, @Amt)", conn)
            cmd5.Parameters.AddWithValue("@cid", Val(TB1.Text))
            cmd5.Parameters.AddWithValue("@fid", Val(RN.Text))
            cmd5.Parameters.AddWithValue("@Qty", Val(RQ.Text))
            cmd5.Parameters.AddWithValue("@Amt", Val(Amt.Text))
            cmd5.ExecuteNonQuery()


            MessageBox.Show("Order Complted")
        Catch ex As MySqlException
            MessageBox.Show("Some Food or Room is Already Ordered")
        End Try
    End Sub
End Class