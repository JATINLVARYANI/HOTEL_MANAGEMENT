Public Class Book_Room
    Dim dt As New DataTable
    Dim coll As New Collection
    Dim ppl As Integer
    Dim Locality(4) As String
    Dim curr_id As Integer
    Dim cid As Integer
    Dim rates() As Integer
    Dim dis_amnt As Integer
    Dim cm As New Customer_Master
    Dim RoomLst As New AutoCompleteStringCollection
    Private Sub btn_fndrm_Click(sender As Object, e As EventArgs) Handles btn_fndrm.Click
        cmb_rmno.Items.Clear()
        Dim obj As New Data
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        Dim avalrms As Integer = 0
        Dim r_count = 0

        If cmb_rmtp.SelectedIndex <> -1 And cmb_cpcty.SelectedIndex <> -1 Then
            dt = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_type = '" & cmb_rmtp.Text & "' And Capacity = '" & cmb_cpcty.Text & "' And Room_No in(select Room_No from Room_Bkngs where Booked_From > '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_From > '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt2 = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_type = '" & cmb_rmtp.Text & "' And Capacity = '" & cmb_cpcty.Text & "' And Room_No in(select Room_No from Room_Bkngs where Booked_Till < '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_Till < '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt3 = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_type = '" & cmb_rmtp.Text & "' And Capacity = '" & cmb_cpcty.Text & "' And Room_No not in(select Room_No from Room_Bkngs)")
        ElseIf cmb_rmtp.SelectedIndex = -1 And cmb_cpcty.SelectedIndex <> -1 Then
            dt = obj.data_fill("select Room_No,Room_Rate from H_Item where  Capacity = '" & cmb_cpcty.Text & "' And Room_No in(select Room_No from Room_Bkngs where Booked_From > '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_From > '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt2 = obj.data_fill("select Room_No,Room_Rate from H_Item where Capacity = '" & cmb_cpcty.Text & "' And Room_No in(select Room_No from Room_Bkngs where Booked_Till < '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_Till < '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt3 = obj.data_fill("select Room_No,Room_Rate from H_Item where  Capacity = '" & cmb_cpcty.Text & "' And Room_No not in(select Room_No from Room_Bkngs)")
        ElseIf cmb_rmtp.SelectedIndex <> -1 And cmb_cpcty.SelectedIndex = -1 Then
            dt = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_type = '" & cmb_rmtp.Text & "' And Room_No in(select Room_No from Room_Bkngs where Booked_From > '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_From > '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt2 = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_type = '" & cmb_rmtp.Text & "'  And Room_No in(select Room_No from Room_Bkngs where Booked_Till < '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_Till < '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt3 = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_type = '" & cmb_rmtp.Text & "' And Room_No not in(select Room_No from Room_Bkngs)")
        ElseIf cmb_rmtp.SelectedIndex = -1 And cmb_cpcty.SelectedIndex = -1 Then
            dt = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_No in(select Room_No from Room_Bkngs where Booked_From > '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_From > '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt2 = obj.data_fill("select Room_No,Room_Rate from H_Item where  Room_No in(select Room_No from Room_Bkngs where Booked_Till < '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and Booked_Till < '" & drp_to.Value.ToString("yyyy-MM-dd") & "' )")
            dt3 = obj.data_fill("select Room_No,Room_Rate from H_Item where Room_No Not in(select Room_No from Room_Bkngs)")
        End If
        If dt.Rows.Count = 0 And dt2.Rows.Count = 0 And dt3.Rows.Count = 0 Then
            MessageBox.Show("No Rooms Available")
        Else
            avalrms += dt.Rows.Count + dt2.Rows.Count + dt3.Rows.Count
            ReDim rates(avalrms)
            If dt.Rows.Count <> 0 Then
                For i = 0 To dt.Rows.Count - 1
                    cmb_rmno.Items.Add(dt.Rows(i)("Room_No"))
                    rates(r_count) = dt.Rows(i)("Room_Rate")
                    r_count += 1
                Next
            End If
            If dt2.Rows.Count <> 0 Then
                For i = 0 To dt2.Rows.Count - 1
                    cmb_rmno.Items.Add(dt2.Rows(i)("Room_No"))
                    rates(r_count) = dt2.Rows(i)("Room_Rate")
                    r_count += 1
                Next
            End If
            If dt3.Rows.Count <> 0 Then
                For i = 0 To dt3.Rows.Count - 1
                    cmb_rmno.Items.Add(dt3.Rows(i)("Room_No"))
                    rates(r_count) = dt3.Rows(i)("Room_Rate")
                    r_count += 1
                Next
            End If
        End If
        lbl_rms.Text = avalrms
        cmb_rmno.Focus()
    End Sub

    Private Sub btn_srch_Click(sender As Object, e As EventArgs) Handles btn_srch.Click
        If txt_cname.Text <> "" And txt_cctct.Text <> "" Then
            Dim obj As New Data
            cid = obj.Search_Cutomer("Select * from H_Ledger where C_Name = '" & txt_cname.Text & "' and  C_Contact = " & txt_cctct.Text & "  ")
            If cid = -1 Then
                MessageBox.Show("Not an Exsisting Customer")
                btn_add.Enabled = True
                btn_add.Focus()
            Else
                MessageBox.Show("Exsisting Customer")
                btn_genbill.Enabled = True
                txt_cname.ReadOnly = True
                txt_cctct.ReadOnly = True
                txt_mem1.Focus()
            End If
        Else
            MessageBox.Show("Enter name and contact no.")
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_add.Enabled = False
        Me.Hide()
        cm.txt_cname.Text = txt_cname.Text
        cm.txt_cctct.Text = txt_cctct.Text
        btn_srch.Focus()
        Form1.loadpnl(cm)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.PictureBox1)
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.Panel1)
    End Sub

    Private Sub btn_genbill_Click(sender As Object, e As EventArgs) Handles btn_genbill.Click

        If nud_mbrs.Value = 1 Then
            If txt_cname.Text = "" Or txt_cctct.Text = "" Or txt_mem1.Text = "" Or cmb_nat_m1.SelectedIndex = -1 Then
                MessageBox.Show("Enter all details")
            Else
                filldetaisl()
                pnl_bill.Visible = True
                btn_genbill.Enabled = False
                Dim obj As New Data
                curr_id = obj.get_one_feild("select C_Id from H_Ledger where C_Name = '" & txt_cname.Text & "' and C_Contact = '" & txt_cctct.Text & "'   ")

            End If

        ElseIf nud_mbrs.Value = 2 Then
            If txt_cname.Text = "" Or txt_cctct.Text = "" Or txt_mem1.Text = "" Or txt_mem2.Text = "" Or cmb_nat_m1.SelectedIndex = -1 Or cmb_nat_m2.SelectedIndex = -1 Then
                MessageBox.Show("Enter all details")
            Else
                filldetaisl()
                pnl_bill.Visible = True
                btn_genbill.Enabled = False
                Dim obj As New Data
                curr_id = obj.get_one_feild("select C_Id from H_Ledger where C_Name = '" & txt_cname.Text & "' and C_Contact = '" & txt_cctct.Text & "'   ")
            End If
        ElseIf nud_mbrs.Value = 3 Then
            If txt_cname.Text = "" Or txt_cctct.Text = "" Or txt_mem1.Text = "" Or txt_mem2.Text = "" Or txt_mem3.Text = "" Or cmb_nat_m1.SelectedIndex = -1 Or cmb_nat_m2.SelectedIndex = -1 Or cmb_nat_m3.SelectedIndex = -1 Then
                MessageBox.Show("Enter all details")
            Else
                filldetaisl()
                pnl_bill.Visible = True
                btn_genbill.Enabled = False
                Dim obj As New Data
                curr_id = obj.get_one_feild("select C_Id from H_Ledger where C_Name = '" & txt_cname.Text & "' and C_Contact = '" & txt_cctct.Text & "'   ")
            End If
        Else
            If txt_cname.Text = "" Or txt_cctct.Text = "" Or txt_mem1.Text = "" Or txt_mem2.Text = "" Or txt_mem3.Text = "" Or txt_mem4.Text = "" Or cmb_nat_m1.SelectedIndex = -1 Or cmb_nat_m2.SelectedIndex = -1 Or cmb_nat_m3.SelectedIndex = -1 Or cmb_nat_m4.SelectedIndex = -1 Then
                MessageBox.Show("Enter all details")
            Else
                filldetaisl()
                pnl_bill.Visible = True
                btn_genbill.Enabled = False
                Dim obj As New Data
                curr_id = obj.get_one_feild("select C_Id from H_Ledger where C_Name = '" & txt_cname.Text & "' and C_Contact = '" & txt_cctct.Text & "'   ")
            End If

        End If
    End Sub

    Private Sub filldetaisl()
        lbl_name.Text = txt_cname.Text
        lbl_roomno.Text = cmb_rmno.Text
        lbl_rmcat.Text = cmb_rmtp.Text
        lbl_rrpn.Text = lbl_rate.Text
        lbl_chkout.Text = drp_to.Value.ToString("yyyy-MM-dd")
        lbl_chkin.Text = drp_frm.Value.ToString("yyyy-MM-dd")
        lbl_ppl.Text = nud_mbrs.Value
        cmb_dis.SelectedIndex = 0
        Dim frmdt As Date = drp_frm.Value
        Dim todt As Date = drp_to.Value

        lbl_days.Text = Val(Math.Round((todt - frmdt).TotalDays))
        Dim tot As Integer = Val(lbl_days.Text) * Val(lbl_rrpn.Text)
        tot = tot - ((tot * Val(cmb_dis.Text)) / 100)
        lbl_tot.Text = tot + ((tot * 5) / 100) + ((tot * 10) / 100)
        dis_amnt = ((tot * Val(cmb_dis.Text)) / 100)
        pnl_bill.Visible = True
    End Sub


    Private Function genivnc() As String
        Dim obj As New Data
        Dim val As Integer = obj.get_one_feild("SELECT NEXT VALUE FOR dbo.invc")
        Dim ivcno As String = Trim("AA") + Trim(Str(val)) + Trim("BB")
        Return ivcno
    End Function

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rad_pay_advc.CheckedChanged
        If rad_pay_advc.Checked = True Then
            txt_Amnt.Visible = True
            lbl_amnt.Visible = True
            lbl_mode.Visible = True
            cmb_pmode.Visible = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_pay_chkt.CheckedChanged
        If rad_pay_chkt.Checked = True Then
            txt_Amnt.Visible = False
            lbl_amnt.Visible = False
            lbl_mode.Visible = False
            cmb_pmode.Visible = False
            cmb_pmode.SelectedIndex = -1
        End If
    End Sub

    Private Sub Book_Room_Load(sender As Object, e As EventArgs) Handles Me.Load

        lbl_invc.Text = genivnc()
        drp_frm.Value = Today
        drp_to.Value = Today.AddDays(1)
        drp_frm.MaxDate = Today.AddDays(15)
        drp_to.MaxDate = Today.AddDays(16)
        drp_frm.MinDate = Today
        drp_to.MinDate = Today.AddDays(1)
        btn_fndrm_Click(sender, e)
        coll.Add(txt_mem1)
        coll.Add(txt_mem2)
        coll.Add(txt_mem3)
        coll.Add(txt_mem4)
        cmb_rmtp.Focus()
        cmb_dis.SelectedIndex = 0
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (rad_pay_advc.Checked = False And rad_pay_chkt.Checked = False) Or (rad_pay_advc.Checked = True And (cmb_pmode.SelectedIndex = -1 Or txt_Amnt.Text = "")) Or cmb_dis.SelectedIndex = -1 Then
            MessageBox.Show("Please select the proper payment mode")
        Else
            Dim obj As New Data
            Dim dtl1 As Integer = 1
            Dim dtl2 As Integer = 1
            Dim dtl3 As Integer = 1
            Dim ans As DialogResult
            ans = MessageBox.Show("Confirm Booking?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If ans = DialogResult.Yes Then

                If rad_pay_chkt.Checked = True Then
                    Try
                        obj.insert_data("insert into Room_Allocation values ('" & lbl_invc.Text & "','" & lbl_roomno.Text & "','" & lbl_rmcat.Text & "','" & lbl_name.Text & "','" & curr_id & "','" & lbl_chkin.Text & "','" & lbl_chkout.Text & "','" & lbl_ppl.Text & "','" & dis_amnt & "','" & lbl_tot.Text & "',00,null)")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        dtl1 = 0
                    End Try
                End If
                If rad_pay_advc.Checked = True Then
                    Try
                        obj.insert_data("insert into Room_Allocation values ('" & lbl_invc.Text & "','" & lbl_roomno.Text & "','" & lbl_rmcat.Text & "','" & lbl_name.Text & "','" & curr_id & "','" & lbl_chkin.Text & "','" & lbl_chkout.Text & "','" & lbl_ppl.Text & "','" & dis_amnt & "','" & lbl_tot.Text & "','" & txt_Amnt.Text & "','" & cmb_pmode.Text & "')")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        dtl1 = 0
                    End Try
                End If
                Try
                    obj.insert_data("Insert into Room_Bkngs values('" & lbl_roomno.Text & "','" & lbl_chkin.Text & "','" & lbl_chkout.Text & "')")
                Catch ex As Exception
                    MessageBox.Show("Check Room No. and date")
                    dtl2 = 0
                    Try
                        'Have to write a code here for deleting properly
                        obj.insert_data("delete from Room_Allocation where C_Id = '" & curr_id & "' and Room_No =  '" & lbl_roomno.Text & "'  ")
                    Catch exc As Exception
                        MessageBox.Show("Please delete the allocated room record from checkout")
                    End Try
                End Try
                If Val(lbl_ppl.Text) >= 1 Then
                    Dim j As Integer = 0
                    Try
                        For i As Integer = 1 To Val(lbl_ppl.Text)
                            Dim tx As Guna.UI2.WinForms.Guna2TextBox = coll.Item(i)
                            obj.insert_data("insert into H_Ledger_Mem values ('" & curr_id & "','" & tx.Text & "','" & Locality(j) & "','" & lbl_roomno.Text & "','" & lbl_chkin.Text & "','" & lbl_chkout.Text & "' )  ")
                            j += 1
                        Next
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        dtl3 = 0
                    End Try
                End If
                If dtl1 = 1 And dtl2 = 1 And dtl3 = 1 Then
                    MessageBox.Show("Booking Confirmed!!!")
                    lbl_invc.Text = genivnc()
                    btn_clear_Click(sender, e)
                End If

            End If


        End If


    End Sub

    Private Sub nat_clear()
        cmb_nat_m1.SelectedIndex = -1
        cmb_nat_m2.SelectedIndex = -1
        cmb_nat_m3.SelectedIndex = -1
        cmb_nat_m4.SelectedIndex = -1
    End Sub

    Private Sub cmb_rmno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_rmno.SelectedIndexChanged
        If cmb_rmno.SelectedIndex <> -1 Then

            Dim obj As New Data
            Dim rate As Integer = obj.get_one_feild("select Room_Rate from H_Item where Room_No = '" & cmb_rmno.Items(cmb_rmno.SelectedIndex) & "' ")
            Dim cpcty As Integer = obj.get_one_feild("select Capacity from H_Item where Room_No = '" & cmb_rmno.Items(cmb_rmno.SelectedIndex) & "' ")
            Dim type As String = obj.get_feild("select Room_type from H_Item where Room_No = '" & cmb_rmno.Items(cmb_rmno.SelectedIndex) & "' ")

            If rate = 0 Then
                MessageBox.Show("Room Not Available")
            Else
                lbl_rate.Text = rate
                cmb_rmtp.Text = type
                cmb_cpcty.Text = cpcty
                nud_mbrs.Maximum = cpcty

            End If
        End If
    End Sub

    Private Sub btn_slctrm_Click(sender As Object, e As EventArgs) Handles btn_slctrm.Click
        ppl = nud_mbrs.Value
        If cmb_rmno.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Room")
        Else
            pnl_details.Visible = True
            If nud_mbrs.Value = 2 Then
                lbl_mem1.Visible = True
                txt_mem1.Visible = True
                cmb_nat_m1.Visible = True
                lbl_nat1.Visible = True
                lbl_mem2.Visible = True
                txt_mem2.Visible = True
                cmb_nat_m2.Visible = True
                lbl_nat2.Visible = True
                lbl_mem3.Visible = False
                txt_mem3.Visible = False
                cmb_nat_m3.Visible = False
                lbl_nat3.Visible = False
                lbl_mem4.Visible = False
                txt_mem4.Visible = False
                cmb_nat_m4.Visible = False
                lbl_nat4.Visible = False
            ElseIf nud_mbrs.Value = 3 Then
                lbl_mem1.Visible = True
                txt_mem1.Visible = True
                cmb_nat_m1.Visible = True
                lbl_nat1.Visible = True
                lbl_mem2.Visible = True
                txt_mem2.Visible = True
                cmb_nat_m2.Visible = True
                lbl_nat2.Visible = True
                lbl_mem3.Visible = True
                txt_mem3.Visible = True
                cmb_nat_m3.Visible = True
                lbl_nat3.Visible = True
                lbl_mem4.Visible = False
                txt_mem4.Visible = False
                cmb_nat_m4.Visible = False
                lbl_nat4.Visible = False
            ElseIf nud_mbrs.Value = 1 Then
                lbl_mem1.Visible = True
                txt_mem1.Visible = True
                cmb_nat_m1.Visible = True
                lbl_nat1.Visible = True
                lbl_mem2.Visible = False
                txt_mem2.Visible = False
                cmb_nat_m2.Visible = False
                lbl_nat2.Visible = False
                lbl_mem3.Visible = False
                txt_mem3.Visible = False
                cmb_nat_m3.Visible = False
                lbl_nat3.Visible = False
                lbl_mem4.Visible = False
                txt_mem4.Visible = False
                cmb_nat_m4.Visible = False
                lbl_nat4.Visible = False
            Else
                lbl_mem1.Visible = True
                txt_mem1.Visible = True
                cmb_nat_m1.Visible = True
                lbl_nat1.Visible = True
                lbl_mem2.Visible = True
                txt_mem2.Visible = True
                cmb_nat_m2.Visible = True
                lbl_nat2.Visible = True
                lbl_mem3.Visible = True
                txt_mem3.Visible = True
                cmb_nat_m3.Visible = True
                lbl_nat3.Visible = True
                lbl_mem4.Visible = True
                txt_mem4.Visible = True
                cmb_nat_m4.Visible = True
                lbl_nat4.Visible = True
            End If
            txt_cname.ReadOnly = False
            txt_cctct.ReadOnly = False
            txt_cname.Focus()

        End If
    End Sub

    Private Sub cmb_nat_m1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nat_m1.SelectedIndexChanged, cmb_nat_m2.SelectedIndexChanged, cmb_nat_m3.SelectedIndexChanged, cmb_nat_m4.SelectedIndexChanged
        If sender.SelectedIndex <> -1 Then
            If sender.Name = cmb_nat_m1.Name Then
                Locality(0) = cmb_nat_m1.Text
            ElseIf sender.Name = cmb_nat_m2.Name Then
                Locality(1) = cmb_nat_m2.Text
            ElseIf sender.Name = cmb_nat_m3.Name Then
                Locality(2) = cmb_nat_m3.Text
            ElseIf sender.Name = cmb_nat_m4.Name Then
                Locality(3) = cmb_nat_m4.Text
            End If
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_mem1.Visible = False
        txt_mem2.Visible = False
        txt_mem3.Visible = False
        txt_mem4.Visible = False
        cmb_nat_m1.Visible = False
        cmb_nat_m2.Visible = False
        cmb_nat_m3.Visible = False
        cmb_nat_m4.Visible = False
        cmb_pmode.Visible = False
        lbl_mode.Visible = False
        rad_pay_advc.Checked = False
        rad_pay_chkt.Checked = False
        nat_clear()
        drp_frm.Value = Today
        drp_to.Value = Today.AddDays(1)
        cmb_cpcty.SelectedIndex = -1
        cmb_rmtp.SelectedIndex = -1
        cmb_pmode.SelectedIndex = -1
        cmb_dis.SelectedIndex = 0
        lbl_rms.Text = ""
        btn_fndrm_Click(sender, e)
        nud_mbrs.Value = 1
        txt_cctct.Text = ""
        txt_cname.Text = ""
        txt_mem1.Text = ""
        txt_mem2.Text = ""
        txt_mem3.Text = ""
        txt_mem4.Text = ""
        lbl_name.Text = "------"

        lbl_roomno.Text = "------"
        lbl_rrpn.Text = "------"
        lbl_chkout.Text = "------"
        lbl_chkin.Text = "------"
        lbl_days.Text = "------"
        lbl_tot.Text = "------"
        lbl_ppl.Text = "------"
        lbl_rmcat.Text = "------"
        txt_Amnt.Text = "00.00"
        pnl_details.Visible = False
        pnl_bill.Visible = False

    End Sub







    Private Sub txt_mem4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mem1.KeyPress, txt_mem2.KeyPress, txt_mem3.KeyPress, txt_mem4.KeyPress, nud_mbrs.KeyPress, cmb_cpcty.KeyPress, cmb_rmno.KeyPress, cmb_rmtp.KeyPress, txt_cctct.KeyPress, txt_cname.KeyPress, cmb_nat_m1.KeyPress, cmb_nat_m2.KeyPress, cmb_nat_m3.KeyPress, cmb_nat_m4.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.Name = cmb_rmtp.Name Then
                cmb_cpcty.Focus()
            End If
            If sender.Name = cmb_cpcty.Name Then
                btn_fndrm_Click(sender, e)
            End If
            If sender.Name = cmb_rmno.Name Then
                nud_mbrs.Focus()
            End If
            If sender.Name = nud_mbrs.Name Then
                btn_slctrm_Click(sender, e)
            End If
            If sender.Name = txt_cname.Name Then
                txt_cctct.Focus()
            End If
            If sender.Name = txt_cctct.Name Then
                btn_srch_Click(sender, e)
            End If
            If sender.Name = txt_mem1.Name Then
                cmb_nat_m1.Focus()
            End If
            If sender.Name = cmb_nat_m1.Name Then
                If ppl = 1 Then
                    btn_genbill_Click(sender, e)
                Else
                    txt_mem2.Focus()
                End If

            End If
            If sender.Name = txt_mem2.Name Then
                cmb_nat_m2.Focus()
            End If
            If sender.Name = cmb_nat_m2.Name Then
                If ppl = 2 Then
                    btn_genbill_Click(sender, e)
                Else
                    txt_mem3.Focus()
                End If
            End If
            If sender.Name = txt_mem3.Name Then
                cmb_nat_m3.Focus()
            End If
            If sender.Name = cmb_nat_m3.Name Then
                If ppl = 3 Then
                    btn_genbill_Click(sender, e)
                Else
                    txt_mem4.Focus()
                End If
            End If
            If sender.Name = txt_mem4.Name Then
                cmb_nat_m4.Focus()
            End If
            If sender.Name = cmb_nat_m4.Name Then
                btn_genbill_Click(sender, e)
            End If
        End If
        If sender.Name = txt_cctct.Name Or sender.Name = txt_Amnt.Name Then
            Dim obj As New Data
            e.Handled = obj.NValidate(e.KeyChar, e.GetHashCode)
        End If
        If sender.Name = txt_mem1.Name Or sender.Name = txt_mem2.Name Or sender.Name = txt_mem3.Name Or sender.Name = txt_cname.Name Or sender.Name = txt_mem4.Name Then
            Dim obj As New Data
            e.Handled = obj.TValidate(e.KeyChar, e.GetHashCode)
        End If

    End Sub

    Private Sub cmb_dis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dis.SelectedIndexChanged
        If cmb_dis.SelectedIndex <> -1 Then
            Dim tot As Integer = Val(lbl_days.Text) * Val(lbl_rrpn.Text)
            tot = tot - ((tot * Val(cmb_dis.Text)) / 100)
            lbl_tot.Text = tot + ((tot * 5) / 100) + ((tot * 10) / 100)
            dis_amnt = ((tot * Val(cmb_dis.Text)) / 100)
        End If
    End Sub

    Private Sub txt_Amnt_OnValueChanged(sender As Object, e As EventArgs) Handles txt_Amnt.OnValueChanged
        If Val(txt_Amnt.Text) < 0 Or Val(txt_Amnt.Text) > Val(lbl_tot.Text) Then
            MessageBox.Show("The adavance amount cannot be less then 0 or greater than total amount")
            txt_Amnt.Text = 0
        End If
    End Sub




End Class