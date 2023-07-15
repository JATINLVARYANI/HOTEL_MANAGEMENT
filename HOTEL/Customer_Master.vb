Public Class Customer_Master
    Dim flag = 0
    Dim img_idx = 0
    Dim ds As New DataSet
    Dim dt As New DataTable

    Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMetroTextbox, ByVal maximumLength As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maximumLength
            End If
        Next
    End Sub
    Private Sub SetMaximu(ByVal metroTextbox As Bunifu.Framework.UI.BunifuCustomDataGrid)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(DataGridViewRow) Then
                Dim txt = CType(ctl, TextBox)
                txt.Height = 50
            End If
        Next
    End Sub

    Public Sub Clear_txt()
        txt_cid.Text = ""
        txt_cname.Text = ""
        txt_cadar.Text = ""
        txt_cctct.Text = ""
        txt_cmail.Text = ""
        txt_cname.Focus()
    End Sub

    Public Sub D_load()
        Dim obj As New Data
        ds = obj.data_set("Select * from H_Ledger")
        dgv_cus_mst.DataSource = ds.Tables(0)
        'txt_cctct.MaxLength = 10
    End Sub
    'Private Sub txt_cid_GotFocus(sender As Object, e As EventArgs) Handles txt_cid.GotFocus, txt_cname.GotFocus, txt_cadar.GotFocus, txt_cctct.GotFocus, txt_cmail.GotFocus, txt_crmno.GotFocus
    '    If sender.Name = txt_cid.Name Then
    '        txt_cid.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_cname.Name Then
    '        txt_cname.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_cadar.Name Then
    '        txt_cadar.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_cctct.Name Then
    '        txt_cctct.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_cmail.Name Then
    '        txt_cmail.BackColor = Color.Gold

    '    ElseIf sender.Name = txt_crmno.Name Then
    '        txt_crmno.BackColor = Color.Gold

    '    End If
    'End Sub
    'Private Sub txt_cid_LostFocus(sender As Object, e As EventArgs) Handles txt_cid.LostFocus, txt_cname.LostFocus, txt_cadar.LostFocus, txt_cctct.LostFocus, txt_cmail.LostFocus, txt_crmno.LostFocus
    '    If sender.Name = txt_cid.Name Then
    '        txt_cid.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_cname.Name Then
    '        txt_cname.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_cadar.Name Then
    '        txt_cadar.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_cctct.Name Then
    '        txt_cctct.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_cmail.Name Then
    '        txt_cmail.BackColor = SystemColors.Window

    '    ElseIf sender.Name = txt_crmno.Name Then
    '        txt_crmno.BackColor = SystemColors.Window

    '    End If
    'End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, txt_cid.KeyPress, txt_cname.KeyPress, txt_cadar.KeyPress, txt_cctct.KeyPress, txt_cmail.KeyPress, dgv_cus_mst.KeyPress

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
            If sender.Name = txt_cname.Name Then
                txt_cctct.Focus()
            ElseIf sender.Name = txt_cctct.Name Then
                txt_cadar.Focus()
            ElseIf sender.Name = txt_cadar.Name Then
                txt_cmail.Focus()
            ElseIf sender.Name = txt_cmail.Name Then
                If img_idx = 0 Then
                    btn_add_Click(sender, e)
                Else
                    Btn_edit_Click(sender, e)
                End If
            End If
        End If

        If sender.Name = txt_cid.Name Or sender.Name = txt_cctct.Name Then
            Dim d As New Data
            e.Handled = d.NValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

        If sender.Name = txt_cmail.Name Then
            Dim d As New Data
            e.Handled = d.EValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

        If sender.Name = txt_cname.Name Then
            Dim d As New Data
            e.Handled = d.TValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

        If sender.Name = txt_cadar.Name Then
            Dim d As New Data
            e.Handled = d.ANValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
    End Sub



    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If img_idx = 0 Then
            txt_cid.Text = dgv_cus_mst.Item("C_Id", dgv_cus_mst.CurrentCell.RowIndex).Value
            txt_cname.Text = dgv_cus_mst.Item("C_Name", dgv_cus_mst.CurrentCell.RowIndex).Value
            txt_cadar.Text = dgv_cus_mst.Item("C_Address", dgv_cus_mst.CurrentCell.RowIndex).Value
            txt_cctct.Text = dgv_cus_mst.Item("C_Contact", dgv_cus_mst.CurrentCell.RowIndex).Value
            txt_cmail.Text = dgv_cus_mst.Item("C_Email", dgv_cus_mst.CurrentCell.RowIndex).Value
            img_idx = 1
            btn_edit.Image = ImageList1.Images(img_idx)
            txt_cname.Focus()
        Else
            If txt_cname.Text = "" Or txt_cadar.Text = "" Or txt_cctct.Text = "" Or txt_cmail.Text = "" Then
                MessageBox.Show("Please enter all the details")
            Else
                Dim ans As DialogResult
                ans = MessageBox.Show("Do you really want to save the changes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If ans = DialogResult.Yes Then
                    Dim obj As New Data
                    Try

                        obj.update_data("update H_Ledger set  C_Name = '" & txt_cname.Text & "',C_Address = '" & txt_cadar.Text & "',  C_Contact = '" & txt_cctct.Text & "', C_Email = '" & txt_cmail.Text & "' where C_Id = '" & txt_cid.Text & "' ")
                        MessageBox.Show("Record Updated")
                    Catch ex As Exception
                        MessageBox.Show("Eneter Vaild details")
                    End Try
                    Clear_txt()
                    img_idx = 0
                    btn_edit.Image = ImageList1.Images(img_idx)
                    D_load()
                End If
            End If
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_cname.Text = "" Or txt_cadar.Text = "" Or txt_cctct.Text = "" Or txt_cmail.Text = "" Then
            MessageBox.Show("Please enter all the details")
        Else

            Dim ans As DialogResult
            ans = MessageBox.Show("Do you want to insert the record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If ans = DialogResult.Yes Then
                Dim obj As New Data


                obj.insert_data("insert into H_Ledger   values('" & txt_cname.Text & "', '" & txt_cadar.Text & "',  '" & txt_cctct.Text & "', '" & txt_cmail.Text & "' ) ")

                MessageBox.Show("Record Inserted")

                Clear_txt()
                flag = 0
                D_load()
            End If
        End If
    End Sub

    Private Sub ROOM_MASTER_Load(sender As Object, e As EventArgs) Handles Me.Load
        D_load()
        txt_cname.Focus()
        SetMaximumLength(txt_cctct, 10)

        For i = 0 To dgv_cus_mst.Rows.Count - 1
            dgv_cus_mst.Rows(i).Height = 200
        Next
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        If img_idx = 0 Then
            Clear_txt()
        Else
            If txt_cname.Text = "" Or txt_cadar.Text = "" Or txt_cctct.Text = "" Or txt_cmail.Text = "" Then
                MessageBox.Show("Please enter all the details")
            Else

                Dim ans As DialogResult
                Dim obj As New Data
                Dim bol As Boolean = obj.Validate("Select * from H_ledger where C_Name =  '" & txt_cname.Text & "' and C_Contact =  '" & txt_cctct.Text & "'   ")
                ans = MessageBox.Show("Do you want to delete the record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If ans = DialogResult.Yes And bol = True Then

                    obj.insert_data("Delete from H_Ledger where C_Id = '" & txt_cid.Text & "' ")
                    MessageBox.Show("Record Deleted")
                    Clear_txt()
                    D_load()
                    img_idx = 0
                    btn_edit.Image = ImageList1.Images(img_idx)
                Else
                    MessageBox.Show("Enter Vaild Name and Contact no.")
                End If
            End If
        End If
    End Sub

    Private Sub Dgv_cus_mst_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cus_mst.CellDoubleClick
        txt_cid.Text = dgv_cus_mst.Item("C_Id", dgv_cus_mst.CurrentCell.RowIndex).Value
        txt_cname.Text = dgv_cus_mst.Item("C_Name", dgv_cus_mst.CurrentCell.RowIndex).Value
        txt_cadar.Text = dgv_cus_mst.Item("C_Address", dgv_cus_mst.CurrentCell.RowIndex).Value
        txt_cctct.Text = dgv_cus_mst.Item("C_Contact", dgv_cus_mst.CurrentCell.RowIndex).Value
        txt_cmail.Text = dgv_cus_mst.Item("C_Email", dgv_cus_mst.CurrentCell.RowIndex).Value
        img_idx = 1
        btn_edit.Image = ImageList1.Images(img_idx)
        txt_cname.Focus()

    End Sub

    'Private Sub btn_bck_Click(sender As Object, e As EventArgs) Handles btn_bck.Click
    '    Me.Hide()
    '    Home_Page.Show()
    'End Sub




    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        D_load()
        Clear_txt()
        img_idx = 0
        btn_edit.Image = ImageList1.Images(img_idx)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        'Form1.PictureBox1.Show()
        'Form1.Panel1.Show()
        Form1.loadpnl(Home_Master)
    End Sub


End Class