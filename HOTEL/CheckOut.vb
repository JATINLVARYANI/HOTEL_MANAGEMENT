Public Class CheckOut
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Form1.loadpnl(N_Chkt)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.PictureBox1)
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.Panel1)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Form1.loadpnl(E_Chkt)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Form1.loadpnl(Check_In)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Form1.loadpnl(Cancel_Room)
    End Sub
End Class