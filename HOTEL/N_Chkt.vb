Imports CrystalDecisions.CrystalReports.Engine

Public Class N_Chkt
    Dim dt As New DataTable
    Dim dat1 As Date
    Dim dat2 As Date
    Dim ds As New DataSet
    Private Sub N_Chkt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New Data
        dt = obj.data_fill("select * from Room_Allocation Where Check_Out =  '" & Date.Now.ToString("yyyy-MM-dd") & "' and Invoice_No in(select Invoice_No from Check_In) ")
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No CheckOut Pending Today")
        Else
            For i = 0 To dt.Rows.Count - 1
                cmb_rmno.Items.Add(dt.Rows(i)("Room_No"))
            Next
        End If
        txt_srvc.Text = 0
    End Sub

    Private Sub cmb_rmno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_rmno.SelectedIndexChanged
        Dim f As Boolean = True
        If cmb_rmno.SelectedIndex <> -1 Then
            'Dim r As DataGridViewRow
            If dgv_bill.Rows.Count > 0 Then
                dgv_bill.Rows.RemoveAt(0)
            End If

            'For i = 0 To dgv_bill.Rows.Count - 1
            '    r = dgv_bill.Rows(i)
            '    If r.Cells(0).Value = cmb_rmno.Text Then
            '        f = False
            '        Exit For
            '    End If
            'Next
            If f = True Then
                Dim obj As New Data
                dt = obj.data_fill("select * from Room_Allocation Where Room_No = '" & cmb_rmno.Text & "' and Check_Out =  '" & Date.Now.ToString("yyyy-MM-dd") & "' and Invoice_No in(select Invoice_No from Check_In) ")
                txt_name.Text = dt.Rows(0)("C_Name").ToString
                txt_contact.Text = obj.get_feild("select C_Contact from H_Ledger where C_Id =  '" & dt.Rows(0)("C_Id") & "' ")
                txt_chkin.Text = dt.Rows(0)("Check_In")
                txt_chkout.Text = dt.Rows(0)("Check_Out")
                dat1 = dt.Rows(0)("Check_In")
                dat2 = dt.Rows(0)("Check_Out")
                txt_ivno.Text = dt.Rows(0)("Invoice_No")
                Dim frmdt As Date = dt.Rows(0)("Check_In")
                Dim todt As Date = dt.Rows(0)("Check_Out")
                Dim days As Integer = Val(Math.Round((todt - frmdt).TotalDays))
                Dim rate As Integer = obj.get_one_feild("Select Room_Rate from H_Item where Room_No = '" & cmb_rmno.Text & "' ")
                Dim stay = (days * rate)
                Dim dis_rate As Integer
                If IsDBNull(dt.Rows(0)("Discount")) Then
                    dis_rate = 0
                Else
                    dis_rate = dt.Rows(0)("Discount")
                End If

                Dim tot As Integer = Val(dt.Rows(0)("Total_Amount")) + Val(txt_srvc.Text)
                    dgv_bill.Rows.Add(cmb_rmno.Text, stay, dis_rate, txt_srvc.Text, "@10%", "@5%", tot, dt.Rows(0)("Amount_Paid"), tot - Val(dt.Rows(0)("Amount_Paid")))
                End If

            End If
    End Sub


    Private Sub txt_srvc_TextChanged(sender As Object, e As EventArgs) Handles txt_srvc.TextChanged

        If dgv_bill.Rows.Count > 0 Then
            Dim obj As New Data
            Dim row As DataGridViewRow = dgv_bill.Rows(dgv_bill.CurrentRow.Index)
            Dim tot As Integer = Val(dt.Rows(0)("Total_Amount")) + Val(txt_srvc.Text)
            row.Cells("Room_Service").Value = txt_srvc.Text
            row.Cells("Total").Value = tot
            row.Cells("Pay").Value = row.Cells("Total").Value - row.Cells("Paid").Value
        End If

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        Form1.loadpnl(CheckOut)
    End Sub

    Private Sub btn_chkout_Click(sender As Object, e As EventArgs) Handles btn_chkout.Click
        If cmb_pay_mode.SelectedIndex <> -1 And cmb_rmno.SelectedIndex <> -1 Then
            Dim chk1 As Boolean = True 'This variable is to check if the data has been successfully inserted in the H_Sales table
            Dim chk2 As Boolean = True 'This Variable is to check if the data has beeen deleted from Room_allocattion table
            Dim chk3 As Boolean = True 'This variable is to check if the data has been deleted from Room_Bkngs
            Try
                Dim obj As New Data
                'For i = 0 To dgv_bill.Rows.Count - 1
                Dim id = dt.Rows(0)("C_Id")
                Dim chkin As Date = dt.Rows(0)("Check_In")
                Dim chkout As Date = dt.Rows(0)("Check_Out")
                If IsDBNull(dt.Rows(0)("Payment_Mode")) Then
                    obj.insert_data("insert into H_Sales values(" & id & ",'" & txt_name.Text & "','" & dt.Rows(0)("Invoice_No") & "','" & Today.ToString("yyyy-MM-dd") & "','" & dgv_bill.Rows.Item(0).Cells("Room_No").Value & "','" & dt.Rows(0)("Room_Type") & "', '" & dt.Rows(0)("Person_Stay") & "' ,'" & dat1.ToString("yyyy-MM-dd") & "','" & dat2.ToString("yyyy-MM-dd") & "',  '" & dt.Rows(0)("Total_Amount") & "', '" & dgv_bill.Rows.Item(0).Cells("Discount").Value & "','" & dgv_bill.Rows.Item(0).Cells("Room_Service").Value & "','" & dgv_bill.Rows.Item(0).Cells("Total").Value & "', '@10%' , '@5%','" & dgv_bill.Rows.Item(0).Cells("Paid").Value & "','" & dgv_bill.Rows.Item(0).Cells("Pay").Value & "',  '" & cmb_pay_mode.Text & "',null )  ")
                Else
                    Dim pmod = dt.Rows(0)("Payment_Mode")
                    Dim pay_mode As String
                    If pmod = cmb_pay_mode.Text Then
                        pay_mode = pmod
                    Else
                        pay_mode = pmod + " And " + Trim(cmb_pay_mode.Text)
                    End If
                    obj.insert_data("insert into H_Sales values(" & id & ",'" & txt_name.Text & "','" & dt.Rows(0)("Invoice_No") & "','" & Today.ToString("yyyy-MM-dd") & "','" & dgv_bill.Rows.Item(0).Cells("Room_No").Value & "','" & dt.Rows(0)("Room_Type") & "', '" & dt.Rows(0)("Person_Stay") & "' ,'" & dat1.ToString("yyyy-MM-dd") & "','" & dat2.ToString("yyyy-MM-dd") & "',  '" & dt.Rows(0)("Total_Amount") & "', '" & dgv_bill.Rows.Item(0).Cells("Discount").Value & "','" & dgv_bill.Rows.Item(0).Cells("Room_Service").Value & "','" & dgv_bill.Rows.Item(0).Cells("Total").Value & "', '@10%' , '@5%','" & dgv_bill.Rows.Item(0).Cells("Paid").Value & "','" & dgv_bill.Rows.Item(0).Cells("Pay").Value & "', '" & pay_mode & "',null)  ")
                End If
                'Next
            Catch ex As Exception
                Dim obj As New Data
                MessageBox.Show(ex.Message)
                chk1 = False
                obj.insert_data("delete from H_Sales where C_Id = '" & dt.Rows(0)("C_Id") & "'    ")
            End Try
            If chk1 = True Then
                Try
                    Dim obj As New Data
                    obj.insert_data("delete from Room_Allocation where C_Id = '" & dt.Rows(0)("C_Id") & "'  and Room_No = '" & cmb_rmno.Text & "' and Check_Out = '" & Today.ToString("yyyy-MM-dd") & "' ")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    chk2 = False
                End Try
            End If
            If chk1 = True And chk2 = True Then
                Try
                    Dim obj As New Data
                    'For i = 0 To dgv_bill.Rows.Count - 1
                    obj.insert_data("delete from Room_Bkngs where Room_No = '" & dt.Rows(0)("Room_No") & "' and Booked_Till = '" & Today.ToString("yyyy-MM-dd") & "'  ")
                    'clear_all()
                    'Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    chk3 = False
                    'have to write a code here to get the deleted data back 
                End Try
            End If
            If chk1 = True And chk2 = True And chk3 = True Then
                Try
                    Dim d As New CrystalReport1
                    Dim obj4 As New Data
                    Dim obj2 As New Bill
                    dt = obj4.data_fill("select * from H_Sales Where Invoice_No = '" & txt_ivno.Text & "'  ")
                    d.Load()
                    Dim d2 As New ReportDocument
                    d2.Load(d.FileName)
                    d2.SetDataSource(dt)
                    obj2.CrystalReportViewer1.ReportSource = d2
                    obj2.Show()
                    btn_clear_Click(sender, e)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Please Enter All the details")
        End If


    End Sub

    Private Sub clear_all()
        cmb_rmno.SelectedIndex = -1
        cmb_pay_mode.SelectedIndex = -1
        txt_chkin.Text = ""
        txt_chkout.Text = ""
        txt_contact.Text = ""
        txt_ivno.Text = ""
        txt_name.Text = ""
        txt_srvc.Text = 00.00
        If dgv_bill.Rows.Count = 1 Then
            dgv_bill.Rows.RemoveAt(0)
        Else
            For i = 0 To dgv_bill.Rows.Count - 2
                dgv_bill.Rows.RemoveAt(i)
            Next
            dgv_bill.Rows.RemoveAt(0)
        End If
    End Sub



    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_name.Text = ""
        txt_ivno.Text = ""
        txt_chkin.Text = ""
        txt_chkout.Text = ""
        txt_contact.Text = ""
        If dgv_bill.Rows.Count > 0 Then
            dgv_bill.Rows.RemoveAt(0)
        End If
        cmb_pay_mode.SelectedIndex = -1
        cmb_rmno.SelectedIndex = -1
        N_Chkt_Load(sender, e)


    End Sub

    Private Sub txt_srvc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_srvc.KeyPress, cmb_rmno.KeyPress, cmb_pay_mode.KeyPress
        If e.GetHashCode = 851981 Then
            If sender.Name = cmb_rmno.Name Then
                txt_srvc.Focus()
            ElseIf sender.Name = txt_srvc.Name Then
                cmb_pay_mode.Focus()
            End If
        End If
        If sender.Name = txt_srvc.Name Then
            Dim obj As New Data
            e.Handled = obj.NValidate(e.KeyChar, e.GetHashCode)
        End If

    End Sub
End Class