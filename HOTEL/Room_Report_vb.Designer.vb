<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room_Report_vb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room_Report_vb))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.grp_rmws = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btn_gen_rpt = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drp_to = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.drp_frm = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btn_chkt = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_head.SuspendLayout()
        Me.grp_rmws.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'pnl_head
        '
        Me.pnl_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pnl_head.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnl_head.Controls.Add(Me.btn_close)
        Me.pnl_head.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_head.Location = New System.Drawing.Point(0, 0)
        Me.pnl_head.Name = "pnl_head"
        Me.pnl_head.Size = New System.Drawing.Size(1288, 59)
        Me.pnl_head.TabIndex = 26
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(464, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(361, 38)
        Me.Guna2HtmlLabel2.TabIndex = 42
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Reports"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(1226, -1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(62, 59)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'grp_rmws
        '
        Me.grp_rmws.Controls.Add(Me.btn_gen_rpt)
        Me.grp_rmws.Controls.Add(Me.Label2)
        Me.grp_rmws.Controls.Add(Me.Label1)
        Me.grp_rmws.Controls.Add(Me.drp_to)
        Me.grp_rmws.Controls.Add(Me.drp_frm)
        Me.grp_rmws.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.grp_rmws.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_rmws.ForeColor = System.Drawing.Color.White
        Me.grp_rmws.Location = New System.Drawing.Point(91, 65)
        Me.grp_rmws.Name = "grp_rmws"
        Me.grp_rmws.ShadowDecoration.Parent = Me.grp_rmws
        Me.grp_rmws.Size = New System.Drawing.Size(1101, 170)
        Me.grp_rmws.TabIndex = 27
        Me.grp_rmws.Text = "Check-In Reports"
        '
        'btn_gen_rpt
        '
        Me.btn_gen_rpt.BorderRadius = 15
        Me.btn_gen_rpt.CheckedState.Parent = Me.btn_gen_rpt
        Me.btn_gen_rpt.CustomImages.Parent = Me.btn_gen_rpt
        Me.btn_gen_rpt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_gen_rpt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_gen_rpt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_gen_rpt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_gen_rpt.DisabledState.Parent = Me.btn_gen_rpt
        Me.btn_gen_rpt.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_gen_rpt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_gen_rpt.ForeColor = System.Drawing.Color.White
        Me.btn_gen_rpt.HoverState.Parent = Me.btn_gen_rpt
        Me.btn_gen_rpt.Location = New System.Drawing.Point(778, 73)
        Me.btn_gen_rpt.Name = "btn_gen_rpt"
        Me.btn_gen_rpt.ShadowDecoration.Parent = Me.btn_gen_rpt
        Me.btn_gen_rpt.Size = New System.Drawing.Size(180, 45)
        Me.btn_gen_rpt.TabIndex = 6
        Me.btn_gen_rpt.Text = "Get Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(417, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(145, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From"
        '
        'drp_to
        '
        Me.drp_to.CheckedState.Parent = Me.drp_to
        Me.drp_to.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.drp_to.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.drp_to.ForeColor = System.Drawing.Color.White
        Me.drp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.drp_to.HoverState.Parent = Me.drp_to
        Me.drp_to.Location = New System.Drawing.Point(416, 79)
        Me.drp_to.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.drp_to.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.drp_to.Name = "drp_to"
        Me.drp_to.ShadowDecoration.Parent = Me.drp_to
        Me.drp_to.Size = New System.Drawing.Size(248, 39)
        Me.drp_to.TabIndex = 3
        Me.drp_to.Value = New Date(2021, 9, 13, 0, 30, 54, 850)
        '
        'drp_frm
        '
        Me.drp_frm.CheckedState.Parent = Me.drp_frm
        Me.drp_frm.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.drp_frm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.drp_frm.ForeColor = System.Drawing.Color.White
        Me.drp_frm.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.drp_frm.HoverState.Parent = Me.drp_frm
        Me.drp_frm.Location = New System.Drawing.Point(143, 79)
        Me.drp_frm.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.drp_frm.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.drp_frm.Name = "drp_frm"
        Me.drp_frm.ShadowDecoration.Parent = Me.drp_frm
        Me.drp_frm.Size = New System.Drawing.Size(248, 39)
        Me.drp_frm.TabIndex = 2
        Me.drp_frm.Value = New Date(2021, 9, 13, 0, 30, 54, 850)
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.btn_chkt)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(94, 251)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1101, 170)
        Me.Guna2GroupBox1.TabIndex = 28
        Me.Guna2GroupBox1.Text = "Check-Out Reports"
        '
        'btn_chkt
        '
        Me.btn_chkt.BorderRadius = 15
        Me.btn_chkt.CheckedState.Parent = Me.btn_chkt
        Me.btn_chkt.CustomImages.Parent = Me.btn_chkt
        Me.btn_chkt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_chkt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_chkt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_chkt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_chkt.DisabledState.Parent = Me.btn_chkt
        Me.btn_chkt.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_chkt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_chkt.ForeColor = System.Drawing.Color.White
        Me.btn_chkt.HoverState.Parent = Me.btn_chkt
        Me.btn_chkt.Location = New System.Drawing.Point(778, 73)
        Me.btn_chkt.Name = "btn_chkt"
        Me.btn_chkt.ShadowDecoration.Parent = Me.btn_chkt
        Me.btn_chkt.Size = New System.Drawing.Size(180, 45)
        Me.btn_chkt.TabIndex = 6
        Me.btn_chkt.Text = "Get Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(417, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(145, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "From"
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(416, 79)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(248, 39)
        Me.Guna2DateTimePicker1.TabIndex = 3
        Me.Guna2DateTimePicker1.Value = New Date(2021, 9, 13, 0, 30, 54, 850)
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.CheckedState.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker2.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.HoverState.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(143, 79)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.ShadowDecoration.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(248, 39)
        Me.Guna2DateTimePicker2.TabIndex = 2
        Me.Guna2DateTimePicker2.Value = New Date(2021, 9, 13, 0, 30, 54, 850)
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Label9)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2ComboBox2)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(97, 438)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1101, 170)
        Me.Guna2GroupBox2.TabIndex = 29
        Me.Guna2GroupBox2.Text = "Room-Wise Reports"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(263, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 34)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "OR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(323, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Room Catagory"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(146, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Room No."
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.BorderThickness = 3
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox2.HoverState.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Items.AddRange(New Object() {"Delux", "Normal", "Super Delux"})
        Me.Guna2ComboBox2.ItemsAppearance.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(322, 79)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.ShadowDecoration.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(133, 36)
        Me.Guna2ComboBox2.TabIndex = 8
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.BorderThickness = 3
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(147, 79)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(104, 36)
        Me.Guna2ComboBox1.TabIndex = 7
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(775, 79)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Get Report"
        '
        'Room_Report_vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 773)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.grp_rmws)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room_Report_vb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room_Report_vb"
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.grp_rmws.ResumeLayout(False)
        Me.grp_rmws.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnl_head As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents grp_rmws As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btn_gen_rpt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents drp_to As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents drp_frm As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btn_chkt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
