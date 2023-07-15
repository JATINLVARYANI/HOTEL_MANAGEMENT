Public Class Form1
    Dim hm As New Home_Master
    Dim bk As New Book_Room
    Dim chk As New CheckOut
    Dim Rpt As New Room_Report_vb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Close()
        LoadForm.Close()
    End Sub


    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        loadpnl(hm)
    End Sub

    Public Sub loadpnl(ByVal pnl As Form)
        'PictureBox1.Hide()
        'Panel1.Hide()
        SplitContainer1.Panel1.Controls.Clear()
        pnl.TopLevel = False
        SplitContainer1.Panel1.Controls.Add(pnl)
        pnl.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        loadpnl(bk)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        loadpnl(chk)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        loadpnl(Rpt)
    End Sub


End Class
