<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Check_In
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Check_In))
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pnl_search = New System.Windows.Forms.Panel()
        Me.txt_contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_crch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.mem2 = New System.Windows.Forms.Label()
        Me.mem4 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.mem1 = New System.Windows.Forms.Label()
        Me.mem3 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txt_chkin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_advnc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ppl = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_ivno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_chkout = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmb_rmno = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_chkin = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnl_head.SuspendLayout()
        Me.pnl_search.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnl_head.TabIndex = 10
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(457, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(375, 38)
        Me.Guna2HtmlLabel2.TabIndex = 38
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Check-In"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(1226, -1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(62, 59)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'pnl_search
        '
        Me.pnl_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_search.Controls.Add(Me.txt_contact)
        Me.pnl_search.Controls.Add(Me.txt_name)
        Me.pnl_search.Controls.Add(Me.btn_crch)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Location = New System.Drawing.Point(0, 65)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(1288, 109)
        Me.pnl_search.TabIndex = 11
        '
        'txt_contact
        '
        Me.txt_contact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_contact.BorderThickness = 3
        Me.txt_contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contact.DefaultText = ""
        Me.txt_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_contact.DisabledState.Parent = Me.txt_contact
        Me.txt_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contact.FocusedState.Parent = Me.txt_contact
        Me.txt_contact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contact.HoverState.Parent = Me.txt_contact
        Me.txt_contact.Location = New System.Drawing.Point(286, 42)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_contact.MaxLength = 10
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.PlaceholderText = ""
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.ShadowDecoration.Parent = Me.txt_contact
        Me.txt_contact.Size = New System.Drawing.Size(266, 36)
        Me.txt_contact.TabIndex = 20
        '
        'txt_name
        '
        Me.txt_name.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_name.BorderThickness = 3
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.Parent = Me.txt_name
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.FocusedState.Parent = Me.txt_name
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.HoverState.Parent = Me.txt_name
        Me.txt_name.Location = New System.Drawing.Point(12, 42)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = ""
        Me.txt_name.SelectedText = ""
        Me.txt_name.ShadowDecoration.Parent = Me.txt_name
        Me.txt_name.Size = New System.Drawing.Size(266, 36)
        Me.txt_name.TabIndex = 19
        '
        'btn_crch
        '
        Me.btn_crch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_crch.BorderRadius = 10
        Me.btn_crch.CheckedState.Parent = Me.btn_crch
        Me.btn_crch.CustomImages.Parent = Me.btn_crch
        Me.btn_crch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_crch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_crch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_crch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_crch.DisabledState.Parent = Me.btn_crch
        Me.btn_crch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_crch.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_crch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_crch.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_crch.HoverState.Parent = Me.btn_crch
        Me.btn_crch.Location = New System.Drawing.Point(588, 33)
        Me.btn_crch.Name = "btn_crch"
        Me.btn_crch.ShadowDecoration.Parent = Me.btn_crch
        Me.btn_crch.Size = New System.Drawing.Size(180, 45)
        Me.btn_crch.TabIndex = 11
        Me.btn_crch.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Panel1.Controls.Add(Me.btn_chkin)
        Me.Panel1.Location = New System.Drawing.Point(0, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1288, 422)
        Me.Panel1.TabIndex = 31
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TextBox4)
        Me.Guna2GroupBox2.Controls.Add(Me.mem2)
        Me.Guna2GroupBox2.Controls.Add(Me.mem4)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2GroupBox2.Controls.Add(Me.mem1)
        Me.Guna2GroupBox2.Controls.Add(Me.mem3)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(634, 3)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(654, 274)
        Me.Guna2GroupBox2.TabIndex = 37
        Me.Guna2GroupBox2.Text = "Member Details"
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TextBox4.BorderThickness = 3
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.HoverState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Location = New System.Drawing.Point(323, 171)
        Me.Guna2TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.ReadOnly = True
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.ShadowDecoration.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Size = New System.Drawing.Size(266, 36)
        Me.Guna2TextBox4.TabIndex = 35
        Me.Guna2TextBox4.Visible = False
        '
        'mem2
        '
        Me.mem2.AutoSize = True
        Me.mem2.BackColor = System.Drawing.Color.White
        Me.mem2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mem2.Location = New System.Drawing.Point(319, 53)
        Me.mem2.Name = "mem2"
        Me.mem2.Size = New System.Drawing.Size(152, 24)
        Me.mem2.TabIndex = 21
        Me.mem2.Text = "Member 2 Name"
        Me.mem2.Visible = False
        '
        'mem4
        '
        Me.mem4.AutoSize = True
        Me.mem4.BackColor = System.Drawing.Color.White
        Me.mem4.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mem4.Location = New System.Drawing.Point(319, 141)
        Me.mem4.Name = "mem4"
        Me.mem4.Size = New System.Drawing.Size(159, 24)
        Me.mem4.TabIndex = 34
        Me.mem4.Text = "Member 4 Namer"
        Me.mem4.Visible = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TextBox1.BorderThickness = 3
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(16, 83)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(266, 36)
        Me.Guna2TextBox1.TabIndex = 22
        Me.Guna2TextBox1.Visible = False
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TextBox3.BorderThickness = 3
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.HoverState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Location = New System.Drawing.Point(16, 171)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.ReadOnly = True
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.ShadowDecoration.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Size = New System.Drawing.Size(266, 36)
        Me.Guna2TextBox3.TabIndex = 33
        Me.Guna2TextBox3.Visible = False
        '
        'mem1
        '
        Me.mem1.AutoSize = True
        Me.mem1.BackColor = System.Drawing.Color.White
        Me.mem1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mem1.Location = New System.Drawing.Point(12, 53)
        Me.mem1.Name = "mem1"
        Me.mem1.Size = New System.Drawing.Size(152, 24)
        Me.mem1.TabIndex = 30
        Me.mem1.Text = "Member 1 Name"
        Me.mem1.Visible = False
        '
        'mem3
        '
        Me.mem3.AutoSize = True
        Me.mem3.BackColor = System.Drawing.Color.White
        Me.mem3.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mem3.Location = New System.Drawing.Point(12, 141)
        Me.mem3.Name = "mem3"
        Me.mem3.Size = New System.Drawing.Size(156, 24)
        Me.mem3.TabIndex = 32
        Me.mem3.Text = "Member 3  Name"
        Me.mem3.Visible = False
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TextBox2.BorderThickness = 3
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(323, 81)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.ReadOnly = True
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(266, 36)
        Me.Guna2TextBox2.TabIndex = 31
        Me.Guna2TextBox2.Visible = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.txt_chkin)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_advnc)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label12)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_ppl)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_ivno)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.txt_chkout)
        Me.Guna2GroupBox1.Controls.Add(Me.cmb_rmno)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(539, 349)
        Me.Guna2GroupBox1.TabIndex = 36
        Me.Guna2GroupBox1.Text = "Bill Details"
        '
        'txt_chkin
        '
        Me.txt_chkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_chkin.BorderThickness = 3
        Me.txt_chkin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_chkin.DefaultText = ""
        Me.txt_chkin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_chkin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_chkin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chkin.DisabledState.Parent = Me.txt_chkin
        Me.txt_chkin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chkin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chkin.FocusedState.Parent = Me.txt_chkin
        Me.txt_chkin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chkin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_chkin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chkin.HoverState.Parent = Me.txt_chkin
        Me.txt_chkin.Location = New System.Drawing.Point(44, 171)
        Me.txt_chkin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_chkin.Name = "txt_chkin"
        Me.txt_chkin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chkin.PlaceholderText = ""
        Me.txt_chkin.ReadOnly = True
        Me.txt_chkin.SelectedText = ""
        Me.txt_chkin.ShadowDecoration.Parent = Me.txt_chkin
        Me.txt_chkin.Size = New System.Drawing.Size(203, 36)
        Me.txt_chkin.TabIndex = 28
        '
        'txt_advnc
        '
        Me.txt_advnc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_advnc.BorderThickness = 3
        Me.txt_advnc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_advnc.DefaultText = ""
        Me.txt_advnc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_advnc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_advnc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_advnc.DisabledState.Parent = Me.txt_advnc
        Me.txt_advnc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_advnc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_advnc.FocusedState.Parent = Me.txt_advnc
        Me.txt_advnc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advnc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_advnc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_advnc.HoverState.Parent = Me.txt_advnc
        Me.txt_advnc.Location = New System.Drawing.Point(255, 269)
        Me.txt_advnc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_advnc.Name = "txt_advnc"
        Me.txt_advnc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_advnc.PlaceholderText = ""
        Me.txt_advnc.ReadOnly = True
        Me.txt_advnc.SelectedText = ""
        Me.txt_advnc.ShadowDecoration.Parent = Me.txt_advnc
        Me.txt_advnc.Size = New System.Drawing.Size(203, 36)
        Me.txt_advnc.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Advance Payment"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 24)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Total_Ppl"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Check-In"
        '
        'txt_ppl
        '
        Me.txt_ppl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_ppl.BorderThickness = 3
        Me.txt_ppl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ppl.DefaultText = ""
        Me.txt_ppl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ppl.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ppl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ppl.DisabledState.Parent = Me.txt_ppl
        Me.txt_ppl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ppl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ppl.FocusedState.Parent = Me.txt_ppl
        Me.txt_ppl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ppl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_ppl.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ppl.HoverState.Parent = Me.txt_ppl
        Me.txt_ppl.Location = New System.Drawing.Point(44, 269)
        Me.txt_ppl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ppl.Name = "txt_ppl"
        Me.txt_ppl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ppl.PlaceholderText = ""
        Me.txt_ppl.ReadOnly = True
        Me.txt_ppl.SelectedText = ""
        Me.txt_ppl.ShadowDecoration.Parent = Me.txt_ppl
        Me.txt_ppl.Size = New System.Drawing.Size(203, 36)
        Me.txt_ppl.TabIndex = 35
        '
        'txt_ivno
        '
        Me.txt_ivno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_ivno.BorderThickness = 3
        Me.txt_ivno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ivno.DefaultText = ""
        Me.txt_ivno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ivno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ivno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ivno.DisabledState.Parent = Me.txt_ivno
        Me.txt_ivno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ivno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ivno.FocusedState.Parent = Me.txt_ivno
        Me.txt_ivno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ivno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_ivno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ivno.HoverState.Parent = Me.txt_ivno
        Me.txt_ivno.Location = New System.Drawing.Point(254, 83)
        Me.txt_ivno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ivno.Name = "txt_ivno"
        Me.txt_ivno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ivno.PlaceholderText = ""
        Me.txt_ivno.ReadOnly = True
        Me.txt_ivno.SelectedText = ""
        Me.txt_ivno.ShadowDecoration.Parent = Me.txt_ivno
        Me.txt_ivno.Size = New System.Drawing.Size(203, 36)
        Me.txt_ivno.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(251, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Check-Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Room No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Invoice No."
        '
        'txt_chkout
        '
        Me.txt_chkout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_chkout.BorderThickness = 3
        Me.txt_chkout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_chkout.DefaultText = ""
        Me.txt_chkout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_chkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_chkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chkout.DisabledState.Parent = Me.txt_chkout
        Me.txt_chkout.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chkout.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chkout.FocusedState.Parent = Me.txt_chkout
        Me.txt_chkout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chkout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_chkout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chkout.HoverState.Parent = Me.txt_chkout
        Me.txt_chkout.Location = New System.Drawing.Point(255, 171)
        Me.txt_chkout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_chkout.Name = "txt_chkout"
        Me.txt_chkout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chkout.PlaceholderText = ""
        Me.txt_chkout.ReadOnly = True
        Me.txt_chkout.SelectedText = ""
        Me.txt_chkout.ShadowDecoration.Parent = Me.txt_chkout
        Me.txt_chkout.Size = New System.Drawing.Size(203, 38)
        Me.txt_chkout.TabIndex = 29
        '
        'cmb_rmno
        '
        Me.cmb_rmno.BackColor = System.Drawing.Color.Transparent
        Me.cmb_rmno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_rmno.BorderThickness = 3
        Me.cmb_rmno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_rmno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rmno.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_rmno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_rmno.FocusedState.Parent = Me.cmb_rmno
        Me.cmb_rmno.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_rmno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_rmno.HoverState.Parent = Me.cmb_rmno
        Me.cmb_rmno.ItemHeight = 30
        Me.cmb_rmno.ItemsAppearance.Parent = Me.cmb_rmno
        Me.cmb_rmno.Location = New System.Drawing.Point(44, 83)
        Me.cmb_rmno.MaxDropDownItems = 100
        Me.cmb_rmno.Name = "cmb_rmno"
        Me.cmb_rmno.ShadowDecoration.Parent = Me.cmb_rmno
        Me.cmb_rmno.Size = New System.Drawing.Size(203, 36)
        Me.cmb_rmno.TabIndex = 2
        '
        'btn_chkin
        '
        Me.btn_chkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkin.BorderRadius = 10
        Me.btn_chkin.CheckedState.Parent = Me.btn_chkin
        Me.btn_chkin.CustomImages.Parent = Me.btn_chkin
        Me.btn_chkin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_chkin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_chkin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_chkin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_chkin.DisabledState.Parent = Me.btn_chkin
        Me.btn_chkin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkin.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chkin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_chkin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_chkin.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkin.HoverState.Parent = Me.btn_chkin
        Me.btn_chkin.Location = New System.Drawing.Point(552, 360)
        Me.btn_chkin.Name = "btn_chkin"
        Me.btn_chkin.ShadowDecoration.Parent = Me.btn_chkin
        Me.btn_chkin.Size = New System.Drawing.Size(180, 45)
        Me.btn_chkin.TabIndex = 21
        Me.btn_chkin.Text = "Check-In"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'Check_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 773)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Check_In"
        Me.Text = "Check_In"
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_head As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents pnl_search As Panel
    Friend WithEvents txt_contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_crch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_chkin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_rmno As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_chkout As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_chkin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ivno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_advnc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mem4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_ppl As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mem3 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mem1 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mem2 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
