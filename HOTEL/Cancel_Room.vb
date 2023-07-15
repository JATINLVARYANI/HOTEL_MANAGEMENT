Public Class Cancel_Room
    Dim dt As New DataTable
    Dim curr_id As Integer
    Private Sub Cancel_Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New Data
        dt = obj.data_fill("select * from Room_Allocation Where Check_In  >  '" & Date.Now.ToString("yyyy-MM-dd") & "'  ")
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Advance Bookings")
            txt_name.ReadOnly = True
            txt_contact.ReadOnly = True
            btn_crch.Enabled = False
            btn_cancel.Enabled = False
        Else
            txt_name.ReadOnly = False
            txt_contact.ReadOnly = False
            btn_crch.Enabled = True
            btn_cancel.Enabled = True
            For i = 0 To dt.Rows.Count - 1
                cmb_rmno.Items.Add(dt.Rows(i)("Room_No"))
            Next
        End If
    End Sub

    Private Sub cmb_rmno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_rmno.SelectedIndexChanged
        Dim obj As New Data
        dt = obj.data_fill("select * from Room_Allocation Where Row_Id = '" & dt.Rows(cmb_rmno.SelectedIndex)("Row_Id") & "'  ")
        txt_advnc.Text = dt.Rows(0)("Amount_Paid")
        txt_chkin.Text = dt.Rows(0)("Check_In")
        txt_chkout.Text = dt.Rows(0)("Check_Out")
        txt_ivno.Text = dt.Rows(0)("Invoice_No")
    End Sub

    Private Sub btn_crch_Click(sender As Object, e As EventArgs) Handles btn_crch.Click
        Dim obj As New Data
        curr_id = obj.get_one_feild("select * from H_Ledger where C_Name  like '%" & txt_name.Text & "%'  and C_Contact =   '" & txt_contact.Text & "'   ")
        If curr_id = 0 Then
            MessageBox.Show("No Customer Found")
        Else
            dt = obj.data_fill("select * from Room_Allocation where C_Id = '" & curr_id & "' and Check_In >  '" & Date.Now.ToString("yyyy-MM-dd") & "'  ")
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No bookings For this Customer")
            Else
                For i = 0 To dt.Rows.Count - 1
                    cmb_rmno.Items.Add(dt.Rows(i)("Room_No"))
                Next
            End If
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If cmb_rmno.SelectedIndex <> -1 Then
            Dim ans As DialogResult = MessageBox.Show("Do you really want to cancel the room ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If ans = DialogResult.Yes Then
                Dim chk As Boolean = True
                Dim obj As New Data
                Try
                    obj.insert_data("delete from Room_Allocation where Row_Id = '" & dt.Rows(cmb_rmno.SelectedIndex)("Row_Id") & "' ")
                    obj.insert_data("insert into Cancel_Rooms values ('" & cmb_rmno.Text & "','" & curr_id & "','" & txt_advnc.Text & "','" & txt_ivno.Text & "'   )   ")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    chk = False
                End Try
                If chk = True Then
                    txt_advnc.Text = ""
                    txt_chkin.Text = ""
                    txt_chkout.Text = ""
                    txt_name.Text = ""
                    txt_ivno.Text = ""
                    txt_contact.Text = ""
                    cmb_rmno.Items.Clear()
                    Cancel_Room_Load(sender, e)
                End If
            End If
        Else
            MessageBox.Show("Eneter All the details")
        End If

    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_advnc.Text = ""
        txt_chkin.Text = ""
        txt_chkout.Text = ""
        txt_name.Text = ""
        txt_ivno.Text = ""
        txt_contact.Text = ""
        cmb_rmno.Items.Clear()
        Cancel_Room_Load(sender, e)
    End Sub



    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress, txt_contact.KeyPress
        Dim obj As New Data
        If sender.Name = txt_name.Name Then

            e.Handled = obj.TValidate(e.KeyChar, e.GetHashCode)
        End If
        If sender.Name = txt_contact.Name Then
            e.Handled = obj.NValidate(e.KeyChar, e.GetHashCode)
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        Form1.loadpnl(CheckOut)
    End Sub
End Class