<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class N_Chkt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(N_Chkt))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pnl_search = New System.Windows.Forms.Panel()
        Me.txt_ivno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_chkout = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_chkin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_rmno = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.btn_clear = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_chkout = New Guna.UI2.WinForms.Guna2Button()
        Me.dgv_bill = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Room_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staying_Charge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room_Service = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LUXRY_TAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_pay_mode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_srvc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnl_head.SuspendLayout()
        Me.pnl_search.SuspendLayout()
        Me.pnl_main.SuspendLayout()
        CType(Me.dgv_bill, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_head.TabIndex = 8
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(446, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(397, 38)
        Me.Guna2HtmlLabel2.TabIndex = 39
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Check-Out"
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
        Me.pnl_search.Controls.Add(Me.txt_ivno)
        Me.pnl_search.Controls.Add(Me.txt_chkout)
        Me.pnl_search.Controls.Add(Me.txt_chkin)
        Me.pnl_search.Controls.Add(Me.txt_contact)
        Me.pnl_search.Controls.Add(Me.txt_name)
        Me.pnl_search.Controls.Add(Me.Label5)
        Me.pnl_search.Controls.Add(Me.Label6)
        Me.pnl_search.Controls.Add(Me.Label4)
        Me.pnl_search.Controls.Add(Me.cmb_rmno)
        Me.pnl_search.Controls.Add(Me.Label3)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Location = New System.Drawing.Point(0, 65)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(1288, 109)
        Me.pnl_search.TabIndex = 9
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
        Me.txt_ivno.Location = New System.Drawing.Point(1062, 40)
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
        Me.txt_chkout.Location = New System.Drawing.Point(807, 40)
        Me.txt_chkout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_chkout.Name = "txt_chkout"
        Me.txt_chkout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chkout.PlaceholderText = ""
        Me.txt_chkout.ReadOnly = True
        Me.txt_chkout.SelectedText = ""
        Me.txt_chkout.ShadowDecoration.Parent = Me.txt_chkout
        Me.txt_chkout.Size = New System.Drawing.Size(203, 38)
        Me.txt_chkout.TabIndex = 22
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
        Me.txt_chkin.Location = New System.Drawing.Point(596, 42)
        Me.txt_chkin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_chkin.Name = "txt_chkin"
        Me.txt_chkin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chkin.PlaceholderText = ""
        Me.txt_chkin.ReadOnly = True
        Me.txt_chkin.SelectedText = ""
        Me.txt_chkin.ShadowDecoration.Parent = Me.txt_chkin
        Me.txt_chkin.Size = New System.Drawing.Size(203, 36)
        Me.txt_chkin.TabIndex = 21
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
        Me.txt_contact.Location = New System.Drawing.Point(345, 42)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.PlaceholderText = ""
        Me.txt_contact.ReadOnly = True
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.ShadowDecoration.Parent = Me.txt_contact
        Me.txt_contact.Size = New System.Drawing.Size(203, 36)
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
        Me.txt_name.Location = New System.Drawing.Point(134, 42)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = ""
        Me.txt_name.ReadOnly = True
        Me.txt_name.SelectedText = ""
        Me.txt_name.ShadowDecoration.Parent = Me.txt_name
        Me.txt_name.Size = New System.Drawing.Size(203, 36)
        Me.txt_name.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(803, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Check-Out"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(592, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Check-In"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1058, 12)
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
        Me.cmb_rmno.Location = New System.Drawing.Point(11, 42)
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
        Me.Label3.Location = New System.Drawing.Point(7, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Room No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Name"
        '
        'pnl_main
        '
        Me.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_main.Controls.Add(Me.btn_clear)
        Me.pnl_main.Controls.Add(Me.btn_chkout)
        Me.pnl_main.Controls.Add(Me.dgv_bill)
        Me.pnl_main.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_main.Location = New System.Drawing.Point(0, 290)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(1288, 204)
        Me.pnl_main.TabIndex = 11
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
        Me.btn_clear.Location = New System.Drawing.Point(1096, 104)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.ShadowDecoration.Parent = Me.btn_clear
        Me.btn_clear.Size = New System.Drawing.Size(180, 45)
        Me.btn_clear.TabIndex = 2
        Me.btn_clear.Text = "Clear"
        '
        'btn_chkout
        '
        Me.btn_chkout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkout.BorderRadius = 10
        Me.btn_chkout.CheckedState.Parent = Me.btn_chkout
        Me.btn_chkout.CustomImages.Parent = Me.btn_chkout
        Me.btn_chkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_chkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_chkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_chkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_chkout.DisabledState.Parent = Me.btn_chkout
        Me.btn_chkout.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkout.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chkout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_chkout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_chkout.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chkout.HoverState.Parent = Me.btn_chkout
        Me.btn_chkout.Location = New System.Drawing.Point(1096, 53)
        Me.btn_chkout.Name = "btn_chkout"
        Me.btn_chkout.ShadowDecoration.Parent = Me.btn_chkout
        Me.btn_chkout.Size = New System.Drawing.Size(180, 45)
        Me.btn_chkout.TabIndex = 1
        Me.btn_chkout.Text = "Check-Out"
        '
        'dgv_bill
        '
        Me.dgv_bill.AllowUserToAddRows = False
        Me.dgv_bill.AllowUserToDeleteRows = False
        Me.dgv_bill.AllowUserToResizeColumns = False
        Me.dgv_bill.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgv_bill.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_bill.BackgroundColor = System.Drawing.Color.White
        Me.dgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_bill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_bill.ColumnHeadersHeight = 50
        Me.dgv_bill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Room_No, Me.Staying_Charge, Me.Discount, Me.Room_Service, Me.GST, Me.LUXRY_TAX, Me.Total, Me.Paid, Me.Pay})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bill.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_bill.EnableHeadersVisualStyles = False
        Me.dgv_bill.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_bill.Location = New System.Drawing.Point(0, 2)
        Me.dgv_bill.Name = "dgv_bill"
        Me.dgv_bill.ReadOnly = True
        Me.dgv_bill.RowHeadersVisible = False
        Me.dgv_bill.RowHeadersWidth = 51
        Me.dgv_bill.RowTemplate.Height = 40
        Me.dgv_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_bill.Size = New System.Drawing.Size(1090, 197)
        Me.dgv_bill.TabIndex = 0
        Me.dgv_bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgv_bill.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.dgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.dgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgv_bill.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_bill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_bill.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dgv_bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_bill.ThemeStyle.HeaderStyle.Height = 50
        Me.dgv_bill.ThemeStyle.ReadOnly = True
        Me.dgv_bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_bill.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_bill.ThemeStyle.RowsStyle.Height = 40
        Me.dgv_bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Room_No
        '
        Me.Room_No.HeaderText = "Room No."
        Me.Room_No.MinimumWidth = 6
        Me.Room_No.Name = "Room_No"
        Me.Room_No.ReadOnly = True
        '
        'Staying_Charge
        '
        Me.Staying_Charge.HeaderText = "Stay Charge"
        Me.Staying_Charge.MinimumWidth = 6
        Me.Staying_Charge.Name = "Staying_Charge"
        Me.Staying_Charge.ReadOnly = True
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount"
        Me.Discount.MinimumWidth = 6
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        '
        'Room_Service
        '
        Me.Room_Service.HeaderText = "Room Service"
        Me.Room_Service.MinimumWidth = 6
        Me.Room_Service.Name = "Room_Service"
        Me.Room_Service.ReadOnly = True
        '
        'GST
        '
        Me.GST.HeaderText = "GST"
        Me.GST.MinimumWidth = 6
        Me.GST.Name = "GST"
        Me.GST.ReadOnly = True
        '
        'LUXRY_TAX
        '
        Me.LUXRY_TAX.HeaderText = "LUXRY TAX"
        Me.LUXRY_TAX.MinimumWidth = 6
        Me.LUXRY_TAX.Name = "LUXRY_TAX"
        Me.LUXRY_TAX.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Paid
        '
        Me.Paid.HeaderText = "Advance"
        Me.Paid.MinimumWidth = 6
        Me.Paid.Name = "Paid"
        Me.Paid.ReadOnly = True
        '
        'Pay
        '
        Me.Pay.HeaderText = "Amount Payable"
        Me.Pay.MinimumWidth = 6
        Me.Pay.Name = "Pay"
        Me.Pay.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Room Service"
        '
        'cmb_pay_mode
        '
        Me.cmb_pay_mode.BackColor = System.Drawing.Color.Transparent
        Me.cmb_pay_mode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_pay_mode.BorderThickness = 3
        Me.cmb_pay_mode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_pay_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pay_mode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pay_mode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pay_mode.FocusedState.Parent = Me.cmb_pay_mode
        Me.cmb_pay_mode.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_pay_mode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_pay_mode.HoverState.Parent = Me.cmb_pay_mode
        Me.cmb_pay_mode.ItemHeight = 30
        Me.cmb_pay_mode.Items.AddRange(New Object() {"Cash", "Card", "Online"})
        Me.cmb_pay_mode.ItemsAppearance.Parent = Me.cmb_pay_mode
        Me.cmb_pay_mode.Location = New System.Drawing.Point(222, 203)
        Me.cmb_pay_mode.Name = "cmb_pay_mode"
        Me.cmb_pay_mode.ShadowDecoration.Parent = Me.cmb_pay_mode
        Me.cmb_pay_mode.Size = New System.Drawing.Size(160, 36)
        Me.cmb_pay_mode.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(218, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Payment Mode"
        '
        'txt_srvc
        '
        Me.txt_srvc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_srvc.BorderThickness = 3
        Me.txt_srvc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_srvc.DefaultText = ""
        Me.txt_srvc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_srvc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_srvc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_srvc.DisabledState.Parent = Me.txt_srvc
        Me.txt_srvc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_srvc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_srvc.FocusedState.Parent = Me.txt_srvc
        Me.txt_srvc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_srvc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_srvc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_srvc.HoverState.Parent = Me.txt_srvc
        Me.txt_srvc.Location = New System.Drawing.Point(12, 203)
        Me.txt_srvc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_srvc.Name = "txt_srvc"
        Me.txt_srvc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_srvc.PlaceholderText = ""
        Me.txt_srvc.SelectedText = ""
        Me.txt_srvc.ShadowDecoration.Parent = Me.txt_srvc
        Me.txt_srvc.Size = New System.Drawing.Size(203, 36)
        Me.txt_srvc.TabIndex = 24
        '
        'N_Chkt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 773)
        Me.Controls.Add(Me.txt_srvc)
        Me.Controls.Add(Me.cmb_pay_mode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "N_Chkt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "N_Chkt"
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        Me.pnl_main.ResumeLayout(False)
        CType(Me.dgv_bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnl_search As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_rmno As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pnl_head As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents pnl_main As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_pay_mode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_chkout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv_bill As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_srvc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_ivno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_chkout As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_chkin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Room_No As DataGridViewTextBoxColumn
    Friend WithEvents Staying_Charge As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents Room_Service As DataGridViewTextBoxColumn
    Friend WithEvents GST As DataGridViewTextBoxColumn
    Friend WithEvents LUXRY_TAX As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Paid As DataGridViewTextBoxColumn
    Friend WithEvents Pay As DataGridViewTextBoxColumn
    Friend WithEvents btn_clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
