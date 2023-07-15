Public Class Hotel_Master
    Dim DT As New DataTable
    Dim flag As Integer = 0

    Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMetroTextbox, ByVal maximumLength As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maximumLength
            End If
        Next
    End Sub
    Private Sub SetReadOnly(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMetroTextbox, ByVal bol As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                If bol = 0 Then
                    txt.ReadOnly = False
                Else
                    txt.ReadOnly = True
                End If
            End If
        Next
    End Sub

    Public Sub sro(ByVal paas As Integer)
        SetReadOnly(txt_htl_name, paas)
        SetReadOnly(txt_htl_ctct, paas)
        SetReadOnly(txt_htl_addr, paas)
        SetReadOnly(txt_htl_gst, paas)
        SetReadOnly(txt_htl_tgln, paas)
        SetReadOnly(txt_htl_id, paas)
    End Sub


    Public Sub Data_load()
        Dim obj As New Data
        DT = obj.data_fill("Select * from Hotel_Mst where Row_Id = 1")
        txt_htl_name.Text = DT.Rows(0)("H_Name").ToString
        txt_htl_ctct.Text = DT.Rows(0)("H_Contact").ToString
        txt_htl_addr.Text = DT.Rows(0)("H_Address").ToString
        txt_htl_gst.Text = DT.Rows(0)("H_GST_NO").ToString
        txt_htl_tgln.Text = DT.Rows(0)("H_Tagline").ToString
        txt_htl_id.Text = DT.Rows(0)("H_Email").ToString
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_load()
        txt_htl_name.Focus()
        sro(1)
        SetMaximumLength(txt_htl_ctct, 10)
    End Sub

    'Private Sub txt_htl_name_GotFocus(sender As Object, e As EventArgs) Handles txt_htl_name.GotFocus, txt_htl_ctct.GotFocus, txt_htl_addr.GotFocus, txt_htl_gst.GotFocus, txt_htl_id.GotFocus, txt_htl_tgln.GotFocus
    '    If sender.Name = txt_htl_name.Name Then
    '        txt_htl_name.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_htl_ctct.Name Then
    '        txt_htl_ctct.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_htl_addr.Name Then
    '        txt_htl_addr.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_htl_gst.Name Then
    '        txt_htl_gst.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_htl_tgln.Name Then
    '        txt_htl_tgln.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_htl_id.Name Then
    '        txt_htl_id.BackColor = Color.Gold

    '    End If
    'End Sub

    'Private Sub txt_htl_name_LostFocus(sender As Object, e As EventArgs) Handles txt_htl_name.LostFocus, txt_htl_ctct.LostFocus, txt_htl_addr.LostFocus, txt_htl_gst.LostFocus, txt_htl_tgln.LostFocus, txt_htl_id.LostFocus
    '    If sender.Name = txt_htl_name.Name Then
    '        txt_htl_name.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_htl_ctct.Name Then
    '        txt_htl_ctct.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_htl_addr.Name Then
    '        txt_htl_addr.BackColor = SystemColors.Window
    '    ElseIf sender.Name = txt_htl_gst.Name Then
    '        txt_htl_gst.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_htl_tgln.Name Then
    '        txt_htl_tgln.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_htl_id.Name Then
    '        txt_htl_id.BackColor = SystemColors.Window

    '    End If
    'End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, txt_htl_name.KeyPress, txt_htl_ctct.KeyPress, txt_htl_addr.KeyPress, txt_htl_gst.KeyPress, txt_htl_tgln.KeyPress, txt_htl_id.KeyPress

        If e.KeyChar.GetHashCode = 1769499 Then
            Button3_Click(sender, e)
        End If

        If e.KeyChar.GetHashCode = 851981 Then
            If sender.Name = txt_htl_name.Name Then
                txt_htl_ctct.Focus()
            ElseIf sender.Name = txt_htl_ctct.Name Then
                txt_htl_addr.Focus()
            ElseIf sender.Name = txt_htl_addr.Name Then
                txt_htl_gst.Focus()
            ElseIf sender.Name = txt_htl_gst.Name Then
                txt_htl_tgln.Focus()
            ElseIf sender.Name = txt_htl_tgln.Name Then
                txt_htl_id.Focus()
            ElseIf sender.Name = txt_htl_id.Name Then
                If flag = 1 Then
                    btn_update_Click(sender, e)
                End If
            End If
        End If
        If sender.Name = txt_htl_ctct.Name Then
            Dim d As New Data
            e.Handled = d.NValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

        If sender.Name = txt_htl_gst.Name Or sender.Name = txt_htl_addr.Name Then
            Dim d As New Data
            e.Handled = d.ANValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

        If sender.Name = txt_htl_name.Name Or sender.Name = txt_htl_tgln.Name Then
            Dim d As New Data
            e.Handled = d.TValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

        If sender.Name = txt_htl_id.Name Then
            Dim d As New Data
            e.Handled = d.EValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If flag = 1 Then


            If txt_htl_name.Text <> "" And txt_htl_ctct.Text <> "" And txt_htl_addr.Text <> "" And txt_htl_gst.Text <> "" And txt_htl_tgln.Text <> "" And txt_htl_id.Text <> "" Then
                Dim ans As DialogResult
                ans = MessageBox.Show("Do you really want to save the changes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If ans = DialogResult.Yes Then
                    Dim obj As New Data
                    obj.update_data(" update Hotel_Mst set H_name = '" & txt_htl_name.Text & "', H_Address = '" & txt_htl_addr.Text & "',H_Contact = '" & txt_htl_ctct.Text & "', H_GST_NO = '" & txt_htl_gst.Text & "', H_Tagline = '" & txt_htl_tgln.Text & "',H_Email = '" & txt_htl_id.Text & "' where Row_Id = 1 ")
                    MessageBox.Show("Records Updated")
                    Button1_Click(sender, e)
                End If
            Else
                MessageBox.Show("Please Enter All the details")
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        sro(0)
        txt_htl_name.Focus()
        flag = 1
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_rfrsh.Click
        sro(1)
        Data_load()
        flag = 0
        txt_htl_name.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        'Form1.PictureBox1.Show()
        'Form1.Panel1.Show()
        Form1.loadpnl(Home_Master)
    End Sub
End Class