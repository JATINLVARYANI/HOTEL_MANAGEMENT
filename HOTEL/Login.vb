Public Class Login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_usr.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Enter All the details")
        Else
            Dim obj1 As New Data
            Dim bol As Boolean
            bol = obj1.Validate("Select * from U_Login where U_Name = '" & txt_usr.Text & "' and U_Paas = '" & txt_pass.Text & "'  ")
            If bol = True Then
                txt_usr.Text = ""
                txt_pass.Text = ""
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Invaild Credentials")
                txt_usr.Text = ""
                txt_pass.Text = ""
            End If
        End If
    End Sub

    Private Sub Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, txt_pass.KeyPress, txt_usr.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.Name = txt_usr.Name Then
                txt_pass.Focus()
            End If
            If sender.Name = txt_pass.Name Then
                btn_login_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_usr_GotFocus(sender As Object, e As EventArgs) Handles txt_usr.GotFocus, txt_pass.GotFocus
        If sender.Name = txt_usr.Name Then
            txt_usr.BackColor = Color.FromArgb(18, 38, 32)
            txt_usr.ForeColor = SystemColors.HighlightText
            pnl_usr.BackColor = Color.DeepSkyBlue
        End If
        If sender.Name = txt_pass.Name Then
            txt_pass.BackColor = Color.FromArgb(18, 38, 32)
            txt_pass.ForeColor = SystemColors.HighlightText
            pnl_pass.BackColor = Color.DeepSkyBlue
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadForm.Close()
        Me.Close()
    End Sub

    Private Sub txt_usr_LostFocus(sender As Object, e As EventArgs) Handles txt_usr.LostFocus, txt_pass.LostFocus
        If sender.Name = txt_usr.Name Then
            txt_usr.BackColor = SystemColors.Window
            txt_usr.ForeColor = Color.Black
            pnl_usr.BackColor = Color.Gold
        End If
        If sender.Name = txt_pass.Name Then
            txt_pass.BackColor = SystemColors.Window
            txt_pass.ForeColor = Color.Black
            pnl_pass.BackColor = Color.Gold
        End If
    End Sub
End Class