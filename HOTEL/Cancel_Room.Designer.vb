<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cancel_Room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancel_Room))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pnl_search = New System.Windows.Forms.Panel()
        Me.btn_clear = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_crch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ivno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_rmno = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_advnc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_chkout = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_chkin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnl_head.SuspendLayout()
        Me.pnl_search.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.pnl_head.TabIndex = 9
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(426, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(437, 38)
        Me.Guna2HtmlLabel2.TabIndex = 41
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Cancel-Room"
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
        Me.pnl_search.Controls.Add(Me.btn_clear)
        Me.pnl_search.Controls.Add(Me.txt_contact)
        Me.pnl_search.Controls.Add(Me.txt_name)
        Me.pnl_search.Controls.Add(Me.btn_crch)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Location = New System.Drawing.Point(0, 65)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(1288, 109)
        Me.pnl_search.TabIndex = 10
        '
        'btn_clear
        '
        Me.btn_clear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_clear.BorderRadius = 10
        Me.btn_clear.CheckedState.Parent = Me.btn_clear
        Me.btn_clear.CustomImages.Parent = Me.btn_clear
        Me.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_clear.DisabledState.Parent = Me.btn_clear
        Me.btn_clear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_clear.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_clear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_clear.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_clear.HoverState.Parent = Me.btn_clear
        Me.btn_clear.Location = New System.Drawing.Point(791, 33)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.ShadowDecoration.Parent = Me.btn_clear
        Me.btn_clear.Size = New System.Drawing.Size(180, 45)
        Me.btn_clear.TabIndex = 21
        Me.btn_clear.Text = "Clear"
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
        Me.txt_ivno.Location = New System.Drawing.Point(860, 37)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(856, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Invoice No."
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
        Me.cmb_rmno.Location = New System.Drawing.Point(16, 39)
        Me.cmb_rmno.MaxDropDownItems = 100
        Me.cmb_rmno.Name = "cmb_rmno"
        Me.cmb_rmno.ShadowDecoration.Parent = Me.cmb_rmno
        Me.cmb_rmno.Size = New System.Drawing.Size(98, 36)
        Me.cmb_rmno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Room No."
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
        Me.txt_advnc.Location = New System.Drawing.Point(187, 37)
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
        Me.Label5.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Advance Payment"
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
        Me.txt_chkout.Location = New System.Drawing.Point(609, 35)
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
        Me.txt_chkin.Location = New System.Drawing.Point(398, 37)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(605, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Check-Out"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(394, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Check-In"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.cmb_rmno)
        Me.Panel1.Controls.Add(Me.txt_chkout)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_chkin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_ivno)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_advnc)
        Me.Panel1.Location = New System.Drawing.Point(0, 216)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1288, 106)
        Me.Panel1.TabIndex = 30
        '
        'btn_cancel
        '
        Me.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.BorderRadius = 10
        Me.btn_cancel.CheckedState.Parent = Me.btn_cancel
        Me.btn_cancel.CustomImages.Parent = Me.btn_cancel
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.DisabledState.Parent = Me.btn_cancel
        Me.btn_cancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_cancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_cancel.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.HoverState.Parent = Me.btn_cancel
        Me.btn_cancel.Location = New System.Drawing.Point(1096, 28)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.ShadowDecoration.Parent = Me.btn_cancel
        Me.btn_cancel.Size = New System.Drawing.Size(180, 45)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel Room"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'Cancel_Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 773)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cancel_Room"
        Me.Text = "Cancel_Room"
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnl_head As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents pnl_search As Panel
    Friend WithEvents txt_advnc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ivno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_rmno As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_crch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_chkout As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_chkin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
