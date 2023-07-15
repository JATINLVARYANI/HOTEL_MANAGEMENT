Public Class LoadForm
    Dim Count As Integer = 0
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Count = 5 Then
            Timer1.Stop()
            Me.Hide()
            Login.Show()
        Else
            Count = Count + 1
        End If
    End Sub

End Class