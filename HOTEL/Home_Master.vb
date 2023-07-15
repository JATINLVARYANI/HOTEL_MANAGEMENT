Public Class Home_Master

    Dim rm As Room_Master
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.PictureBox1)
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.Panel1)
        'Form1.Panel1.Show()
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Form1.loadpnl(Room_Master)
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Form1.loadpnl(Customer_Master)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Form1.loadpnl(Hotel_Master)
    End Sub
End Class