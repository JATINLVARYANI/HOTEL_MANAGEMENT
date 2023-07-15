Public Class Room_Master
    Dim flag = 0
    Dim img_idx = 0
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim id As Integer
    Dim fm As Form1

    'Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMetroTextbox, ByVal maximumLength As Integer)
    '    For Each ctl As Control In metroTextbox.Controls

    '        If ctl.[GetType]() = GetType(TextBox) Then
    '            Dim txt = CType(ctl, TextBox)
    '            txt.MaxLength = maximumLength
    '        End If
    '    Next
    'End Sub

    Public Sub Clear_txt()
        txt_rmno.Text = ""
        txt_rmrt.Text = ""
        cmb_rmtp.SelectedIndex = -1
        cmb_rmcp.SelectedIndex = -1
        txt_rmno.Focus()
    End Sub

    Public Sub D_load()
        Dim obj As New Data
        ds = obj.data_set("Select * from H_Item")
        dgv_rm_mst.DataSource = ds.Tables(0)
    End Sub
    Private Sub txt_rmno_GotFocus(sender As Object, e As EventArgs) Handles txt_rmno.GotFocus, txt_rmrt.GotFocus, cmb_rmcp.GotFocus, cmb_rmtp.GotFocus
        If sender.Name = txt_rmno.Name Then
            txt_rmno.BackColor = Color.FromArgb(255, 61, 87)
            txt_rmno.ForeColor = Color.White
            'ElseIf sender.Name = cmb_rmtp.Name Then
            '    cmb_rmtp.BackColor = Color.FromArgb(255, 61, 87)
            '    cmb_rmtp.ForeColor = Color.White
            '    pnl_rmtp.BackColor = Color.FromArgb(67, 67, 67)
        ElseIf sender.Name = txt_rmrt.Name Then
            txt_rmrt.BackColor = Color.FromArgb(255, 61, 87)
            txt_rmrt.ForeColor = Color.White
            'ElseIf sender.Name = cmb_rmcp.Name Then
            '    cmb_rmcp.BackColor = Color.FromArgb(255, 61, 87)
            '    cmb_rmcp.ForeColor = Color.White
            '    pnl_rmcp.BackColor = Color.FromArgb(67, 67, 67)
        End If
    End Sub
    Private Sub txt_rmno_LostFocus(sender As Object, e As EventArgs) Handles txt_rmno.LostFocus, txt_rmrt.LostFocus, cmb_rmcp.LostFocus, cmb_rmtp.LostFocus
        If sender.Name = txt_rmno.Name Then
            txt_rmno.BackColor = SystemColors.Window
            txt_rmno.ForeColor = Color.Black
            'ElseIf sender.Name = cmb_rmtp.Name Then
            '    cmb_rmtp.BackColor = SystemColors.Window
            '    cmb_rmtp.ForeColor = Color.Black
            '    pnl_rmtp.BackColor = Color.FromArgb(255, 61, 87)
        ElseIf sender.Name = txt_rmrt.Name Then
            txt_rmrt.BackColor = SystemColors.Window
            txt_rmno.ForeColor = Color.Black
            'ElseIf sender.Name = cmb_rmcp.Name Then
            '    cmb_rmcp.BackColor = SystemColors.Window
            '    cmb_rmcp.ForeColor = Color.Black
            '    pnl_rmcp.BackColor = Color.FromArgb(255, 61, 87)
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, txt_rmno.KeyPress, txt_rmrt.KeyPress, cmb_rmcp.KeyPress, cmb_rmtp.KeyPress, pnl_head.KeyPress, SplitContainer1.KeyPress, dgv_rm_mst.KeyPress
        If e.KeyChar.GetHashCode = 1769499 Then
            If img_idx = 0 Then
                Button1_Click(sender, e)
            Else
                img_idx = 0
                btn_edit.Image = ImageList1.Images(img_idx)
                Clear_txt()
            End If

        End If
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.Name = txt_rmno.Name Then
                cmb_rmtp.Focus()
            ElseIf sender.Name = cmb_rmtp.Name Then
                txt_rmrt.Focus()
            ElseIf sender.Name = txt_rmrt.Name Then
                cmb_rmcp.Focus()
            ElseIf sender.Name = cmb_rmcp.Name Then
                If img_idx = 0 Then
                    btn_add_Click(sender, e)
                Else
                    btn_edit_Click(sender, e)
                End If
            End If
        End If
        If sender.Name = txt_rmno.Name Or sender.Name = txt_rmrt.Name Then
            Dim d As New Data
            e.Handled = d.NValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
    End Sub



    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If img_idx = 0 Then
            img_idx = 1
            btn_edit.Image = ImageList1.Images(img_idx)
            id = dgv_rm_mst.CurrentRow.Cells("ROW_ID").Value
            txt_rmno.Text = dgv_rm_mst.CurrentRow.Cells("Room_No").Value
            cmb_rmtp.Text = dgv_rm_mst.CurrentRow.Cells("Room_Type").Value
            txt_rmrt.Text = dgv_rm_mst.CurrentRow.Cells("Room_Rate").Value
            cmb_rmcp.Text = dgv_rm_mst.CurrentRow.Cells("Capacity").Value
        Else
            If txt_rmno.Text = "" Or cmb_rmtp.Text = "" Or txt_rmrt.Text = "" Or cmb_rmcp.Text = "" Then
                MessageBox.Show("Please enter all the details")
            Else
                If cmb_rmcp.Text = "No" Then
                    Dim ans As DialogResult
                    ans = MessageBox.Show("Do you really want to save the changes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If ans = DialogResult.Yes Then
                        Dim obj As New Data
                        Try
                            obj.update_data("update H_Item set  Room_No =  '" & txt_rmno.Text & "',Room_type = '" & cmb_rmtp.Text & "',Room_Rate = '" & txt_rmrt.Text & "',  Capacity = '" & cmb_rmcp.Text & "'  where Col_Id =  " & id & " ")
                            MessageBox.Show("Record Updated")
                        Catch ex As Exception
                            MessageBox.Show("Check Room No.")
                        End Try
                        Clear_txt()
                        img_idx = 0
                        btn_edit.Image = ImageList1.Images(img_idx)
                        D_load()
                    End If
                Else
                    Dim ans As DialogResult
                    ans = MessageBox.Show("Do you really want to save the changes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If ans = DialogResult.Yes Then
                        Dim obj As New Data
                        Try
                            obj.update_data("update H_Item set  Room_No =  '" & txt_rmno.Text & "',Room_type = '" & cmb_rmtp.Text & "',Room_Rate = '" & txt_rmrt.Text & "',  Capacity = '" & cmb_rmcp.Text & "' where Col_Id =  " & id & "  ")
                            MessageBox.Show("Record Updated")
                        Catch ex As Exception
                            MessageBox.Show("Check Room No.")
                        End Try
                        Clear_txt()
                        img_idx = 0
                        btn_edit.Image = ImageList1.Images(img_idx)
                        D_load()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_rmno.Text = "" Or cmb_rmtp.SelectedIndex = -1 Or txt_rmrt.Text = "" Or cmb_rmcp.SelectedIndex = -1 Then
            MessageBox.Show("Please enter all the details")
        Else
            If cmb_rmcp.Text = "No" Then
                Dim ans As DialogResult
                ans = MessageBox.Show("Do you want to insert the record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If ans = DialogResult.Yes Then
                    Dim obj As New Data
                    'Try
                    obj.insert_data("insert into H_Item  values('" & txt_rmno.Text & "','" & cmb_rmtp.Text & "', '" & txt_rmrt.Text & "','" & cmb_rmcp.Text & "') ")
                    MessageBox.Show("Record Inserted")
                    'Catch ex As Exception
                    '    MessageBox.Show("Check Room No.")
                    'End Try
                    D_load()
                    Clear_txt()
                End If
            Else
                Dim ans As DialogResult
                ans = MessageBox.Show("Do you want to insert the record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If ans = DialogResult.Yes Then
                    Dim obj As New Data
                    Try
                        obj.insert_data("insert into H_Item  values('" & txt_rmno.Text & "','" & cmb_rmtp.Text & "', '" & txt_rmrt.Text & "',  '" & cmb_rmcp.Text & "') ")
                        MessageBox.Show("Record Inserted")
                    Catch ex As Exception
                        MessageBox.Show("Check Room No.")
                    End Try
                    Clear_txt()
                    D_load()
                End If
            End If
        End If
    End Sub

    Private Sub ROOM_MASTER_Load(sender As Object, e As EventArgs) Handles Me.Load
        D_load()
        Clear_txt()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        'If img_idx = 1 Then
        '    If txt_rmno.Text = "" Or cmb_rmtp.SelectedIndex = -1 Or txt_rmrt.Text = "" Or cmb_rmavl.SelectedIndex = -1 Then
        '        MessageBox.Show("PLease enter all the details")
        '    Else
        '        Dim del As New Data
        '        Dim bol As Boolean = del.Validate("Select * from H_Item where Room_No =  '" & txt_rmno.Text & "' ")
        '        Dim ans As DialogResult
        '        ans = MessageBox.Show("Do you want to delete the record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        '        If ans = DialogResult.Yes And bol = True Then

        '            del.insert_data("Delete from H_Item where Col_Id =  " & id & " ")
        '            MessageBox.Show("Record Deleted")
        '            img_idx = 0
        '            btn_edit.Image = ImageList1.Images(img_idx)
        '            Clear_txt()
        '            D_load()
        '        Else
        '            MessageBox.Show("Eneter Vaild Room No.")
        '        End If
        '    End If
        'Else
        '    Clear_txt()
        'End If
        D_load()
        Clear_txt()
        img_idx = 0
        btn_edit.Image = ImageList1.Images(img_idx)
    End Sub

    Private Sub dgv_rm_mst_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rm_mst.CellDoubleClick


        id = dgv_rm_mst.CurrentRow.Cells("ROW_ID").Value
        txt_rmno.Text = dgv_rm_mst.CurrentRow.Cells("Room_No").Value
        cmb_rmtp.Text = dgv_rm_mst.CurrentRow.Cells("Room_Type").Value
        txt_rmrt.Text = dgv_rm_mst.CurrentRow.Cells("Room_Rate").Value
        cmb_rmcp.Text = dgv_rm_mst.CurrentRow.Cells("Capacity").Value
        img_idx = 1
        btn_edit.Image = ImageList1.Images(img_idx)

    End Sub

    'Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
    '    Me.Hide()
    '    Home_Page.Show()
    'End Sub


    Private Sub btn_refresh_Click(sender As Object, e As EventArgs)
        D_load()
        Clear_txt()
    End Sub

    Private Sub btn_clear_Click_1(sender As Object, e As EventArgs) Handles btn_clear.Click
        If img_idx = 1 Then
            If txt_rmno.Text = "" Or cmb_rmtp.SelectedIndex = -1 Or txt_rmrt.Text = "" Or cmb_rmcp.SelectedIndex = -1 Then
                MessageBox.Show("PLease enter all the details")
            Else
                Dim del As New Data
                Dim bol As Boolean = del.Validate("Select * from H_Item where Room_No =  '" & txt_rmno.Text & "' ")
                Dim ans As DialogResult
                ans = MessageBox.Show("Do you want to delete the record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If ans = DialogResult.Yes And bol = True Then

                    del.insert_data("Delete from H_Item where Col_Id =  " & id & " ")
                    MessageBox.Show("Record Deleted")
                    img_idx = 0
                    btn_edit.Image = ImageList1.Images(img_idx)
                    Clear_txt()
                    D_load()
                Else
                    MessageBox.Show("Eneter Vaild Room No.")
                End If
            End If
        Else
            Clear_txt()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'Form1.PictureBox1.Show()
        'Form1.Panel1.Show()
        Form1.loadpnl(Home_Master)
    End Sub

End Class