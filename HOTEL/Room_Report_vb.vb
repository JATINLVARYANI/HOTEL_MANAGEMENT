Imports CrystalDecisions.CrystalReports.Engine
Public Class Room_Report_vb
    Dim dt As New DataTable

    Private Sub Room_Report_vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New Data
        dt = obj.data_fill("select Room_No from H_Sales")
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                Guna2ComboBox1.Items.Add(dt.Rows(i)("Room_No"))
            Next
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_gen_rpt.Click
        'Try
        Dim d As New Chkn_rprt
            Dim obj4 As New Data
            Dim obj2 As New Bill
            dt = obj4.data_fill("select * from H_Sales Where Check_In >=   '" & drp_frm.Value.ToString("yyyy-MM-dd") & "' and  Check_In <= '" & drp_to.Value.ToString("yyyy-MM-dd") & "'   ")
            d.Load()
            Dim d2 As New ReportDocument
            d2.Load(d.FileName)
            d2.SetDataSource(dt)
            d2.SetParameterValue("H_Name", obj4.get_feild("select H_Name from Hotel_Mst"))
            d2.SetParameterValue("H_Tag", obj4.get_feild("select H_Tagline from Hotel_Mst"))
            d2.SetParameterValue("H_Address", obj4.get_feild("select H_Address from Hotel_Mst"))
            d2.SetParameterValue("H_Email", obj4.get_feild("select H_Email from Hotel_Mst"))
        d2.SetParameterValue("H_Ctct", obj4.get_feild("select H_Contact from Hotel_Mst"))
        obj2.CrystalReportViewer1.ReportSource = d2
            obj2.Show()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub btn_chkt_Click(sender As Object, e As EventArgs) Handles btn_chkt.Click
        'Try
        Dim d As New CrystalReport2
        Dim obj4 As New Data
        Dim obj2 As New Bill
        dt = obj4.data_fill("select * from H_Sales Where Check_Out >=   '" & Guna2DateTimePicker2.Value.ToString("yyyy-MM-dd") & "' and  Check_Out <= '" & Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd") & "'   ")
        d.Load()
        Dim d2 As New ReportDocument
        d2.Load(d.FileName)
        d2.SetDataSource(dt)
        d2.SetParameterValue("P1", obj4.get_feild("select H_Name from Hotel_Mst"))
        d2.SetParameterValue("p2", obj4.get_feild("select H_Tagline from Hotel_Mst"))
        d2.SetParameterValue("p3", obj4.get_feild("select H_Address from Hotel_Mst"))
        d2.SetParameterValue("p4", obj4.get_feild("select H_Email from Hotel_Mst"))
        d2.SetParameterValue("p5", obj4.get_feild("select H_Contact from Hotel_Mst"))
        obj2.CrystalReportViewer1.ReportSource = d2
        obj2.Show()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        If Guna2ComboBox1.SelectedIndex <> -1 Then
            Guna2ComboBox2.SelectedIndex = -1
        End If
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        If Guna2ComboBox2.SelectedIndex <> -1 Then
            Guna2ComboBox1.SelectedIndex = -1
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2ComboBox1.SelectedIndex <> -1 Then
            'Try
            Dim d As New Room_Report
            Dim obj4 As New Data
            Dim obj2 As New Bill
            dt = obj4.data_fill("select * from H_Sales Where Room_No =  '" & Guna2ComboBox1.Text & "'    ")
            d.Load()
            Dim d2 As New ReportDocument
            d2.Load(d.FileName)
            d2.SetDataSource(dt)
            d2.SetParameterValue("P1", obj4.get_feild("select H_Name from Hotel_Mst"))
            d2.SetParameterValue("p2", obj4.get_feild("select H_Tagline from Hotel_Mst"))
            d2.SetParameterValue("p3", obj4.get_feild("select H_Address from Hotel_Mst"))
            d2.SetParameterValue("p4", obj4.get_feild("select H_Email from Hotel_Mst"))
            d2.SetParameterValue("p5", obj4.get_feild("select H_Contact from Hotel_Mst"))
            obj2.CrystalReportViewer1.ReportSource = d2
            obj2.Show()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try
        Else
            'Try
            Dim d As New RmCat_Report
            Dim obj4 As New Data
            Dim obj2 As New Bill
            dt = obj4.data_fill("select * from H_Sales Where Room_Type =  '" & Guna2ComboBox2.Text & "'    ")
            d.Load()
            Dim d2 As New ReportDocument
            d2.Load(d.FileName)
            d2.SetDataSource(dt)
            d2.SetParameterValue("P1", obj4.get_feild("select H_Name from Hotel_Mst"))
            d2.SetParameterValue("p2", obj4.get_feild("select H_Tagline from Hotel_Mst"))
            d2.SetParameterValue("p3", obj4.get_feild("select H_Address from Hotel_Mst"))
            d2.SetParameterValue("p4", obj4.get_feild("select H_Email from Hotel_Mst"))
            d2.SetParameterValue("p5", obj4.get_feild("select H_Contact from Hotel_Mst"))
            obj2.CrystalReportViewer1.ReportSource = d2
            obj2.Show()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.PictureBox1)
        Form1.SplitContainer1.Panel1.Controls.Add(Form1.Panel1)
    End Sub
End Class