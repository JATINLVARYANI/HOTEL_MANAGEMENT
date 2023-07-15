Public Class Check_In
    Dim dt As New DataTable
    Dim curr_id As New Integer
    Dim txt As New Collection
    Dim lbl As New Collection
    Private Sub btn_crch_Click(sender As Object, e As EventArgs) Handles btn_crch.Click
        If txt_name.Text = "" And txt_contact.Text = "" Then
            MessageBox.Show("Please Enter All the Details")
        Else
            Dim obj As New Data
            If txt_name.Text = "" Then
                curr_id = obj.get_one_feild("select * from H_Ledger where C_Contact =   '" & txt_contact.Text & "'   ")
            ElseIf txt_contact.Text = "" Then
                curr_id = obj.get_one_feild("select * from H_Ledger where C_Name  like '" & txt_name.Text & "%' ")
            Else
                curr_id = obj.get_one_feild("select * from H_Ledger where C_Name  like '" & txt_name.Text & "%'  and C_Contact =   '" & txt_contact.Text & "'   ")
            End If

            If curr_id = 0 Then
                MessageBox.Show("No Customer Found")
            Else

                dt = obj.data_fill("select * from Room_Allocation where C_Id = '" & curr_id & "' and Check_In = '" & Date.Now.ToString("yyyy-MM-dd") & "' and Invoice_No not in (select Invoice_No from Check_In)  ")
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No bookings For this Customer")
                Else
                    For i = 0 To dt.Rows.Count - 1

                        cmb_rmno.Items.Add(dt.Rows(i)("Room_No"))
                    Next
                End If
            End If
        End If

    End Sub

    Private Sub Check_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt.Add(Guna2TextBox1)
        txt.Add(Guna2TextBox2)
        txt.Add(Guna2TextBox3)
        txt.Add(Guna2TextBox4)
        lbl.Add(mem1)
        lbl.Add(mem2)
        lbl.Add(mem3)
        lbl.Add(mem4)
        Dim obj As New Data
        Dim dt3 As New DataTable
        dt3 = obj.data_fill("select * from Room_Allocation where  Check_In = '" & Date.Now.ToString("yyyy-MM-dd") & "' and Invoice_No not in (select Invoice_No from Check_In)  ")
        If dt3.Rows.Count > 0 Then
            For i = 0 To dt3.Rows.Count - 1
                cmb_rmno.Items.Add(dt3.Rows(i)("Room_No"))
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
        txt_ppl.Text = dt.Rows(0)("Person_Stay")
        txt_lbl_ivis()
        txt_lbl_vis(Val(txt_ppl.Text))
    End Sub

    Private Sub txt_lbl_ivis()
        For i = 1 To 4
            txt(i).Text = ""
            txt(i).Visible = False
            lbl(i).Visible = False
        Next
    End Sub

    Private Sub txt_lbl_vis(v As Integer)
        Dim obj As New Data
        For i = 0 To v - 1
            Dim dt2 As New DataTable
            dt2 = obj.data_fill("select M_Name from H_Ledger_Mem where C_Id = '" & curr_id & "' and Check_In = '" & Date.Now.ToString("yyyy-MM-dd") & "' and  Room_No = '" & cmb_rmno.Text & "'   ")
            txt(i + 1).Text = dt2.Rows(i)("M_Name")
            txt(i + 1).Visible = True
            lbl(i + 1).Visible = True
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_chkin.Click
        If cmb_rmno.SelectedIndex <> -1 Then
            Dim obj As New Data
            Dim red As Boolean = True
            Try
                obj.insert_data("insert into Check_In values ('" & txt_ivno.Text & "','" & Date.Now.ToString("yyyy-MM-dd") & "')  ")
                txt_contact.Text = ""
                txt_name.Text = ""
                cmb_rmno.SelectedIndex = -1
                txt_chkin.Text = ""
                txt_chkout.Text = ""
                txt_ivno.Text = ""
                txt_ppl.Text = ""
                txt_advnc.Text = ""
                txt_lbl_ivis()
                MessageBox.Show("Room_Booked ")
            Catch ex As Exception
                MessageBox.Show("Room_Booked !")
                txt_contact.Text = ""
                txt_name.Text = ""
                cmb_rmno.SelectedIndex = -1
                txt_chkin.Text = ""
                txt_chkout.Text = ""
                txt_ivno.Text = ""
                txt_ppl.Text = ""
                txt_advnc.Text = ""
                txt_lbl_ivis()
            End Try
        End If
    End Sub
    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress, txt_contact.KeyPress, cmb_rmno.KeyPress
        Dim obj As New Data
        If e.GetHashCode = 851981 Then
            If sender.Name = txt_name.Name Then
                txt_contact.Focus()
            ElseIf sender.Name = txt_contact.Name Then
                cmb_rmno.Focus()
            ElseIf sender.Name = cmb_rmno.Name Then
                btn_cancel_Click(sender, e)

            End If
        End If
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

    Private Sub pnl_search_Paint(sender As Object, e As PaintEventArgs) Handles pnl_search.Paint

    End Sub
End Class